using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class Cronograma
    {
        public DataTable ObtenerCronogramaGestor(int idGestor, int idProyecto, DateTime fechaDesde, DateTime fechaHasta)
        {
            DataTable resultado;
            DataTable tareas;
            DataTable hitos;

            resultado = CrearTablaResultado();
            tareas = ObtenerTareas(idGestor, idProyecto, fechaDesde, fechaHasta);
            hitos = ObtenerHitos(idGestor, idProyecto, fechaDesde, fechaHasta);

            foreach (DataRow fila in tareas.Rows)
            {
                resultado.Rows.Add(
                    "Tarea",
                    fila["Actividad"].ToString(),
                    fila["Proyecto"].ToString(),
                    fila["Responsable"].ToString(),
                    Convert.ToDateTime(fila["FechaInicio"]),
                    Convert.ToDateTime(fila["FechaFin"]),
                    fila["Estado"].ToString(),
                    Convert.ToDecimal(fila["Avance"]));
            }

            foreach (DataRow fila in hitos.Rows)
            {
                decimal avance;

                avance = 0;

                if (fila["Estado"].ToString() == "Cumplido")
                {
                    avance = 100;
                }

                resultado.Rows.Add(
                    "Hito",
                    fila["Actividad"].ToString(),
                    fila["Proyecto"].ToString(),
                    fila["Responsable"].ToString(),
                    Convert.ToDateTime(fila["Fecha"]),
                    Convert.ToDateTime(fila["Fecha"]),
                    fila["Estado"].ToString(),
                    avance);
            }

            DataView vista;

            vista = new DataView(resultado);
            vista.Sort = "FechaInicio ASC, Proyecto ASC, Actividad ASC";
            return vista.ToTable();
        }

        public DataTable ObtenerCronogramaGestorPagina(int idGestor, int idProyecto,
            DateTime fechaDesde, DateTime fechaHasta, string tipo, int pagina, out int total)
        {
            string consulta = @"
                WITH Actividades AS
                (
                    SELECT N'Tarea' AS Tipo, t.Nombre AS Actividad,
                        p.Nombre AS Proyecto, u.NombreCompleto AS Responsable,
                        t.FechaInicio, t.FechaLimite AS FechaFin,
                        et.Nombre AS Estado, CAST(t.AvanceActual AS DECIMAL(10,2)) AS Avance,
                        t.IdTarea AS OrdenId
                    FROM tbTarea t
                    INNER JOIN tbProyecto p ON p.IdProyecto = t.IdProyecto
                    INNER JOIN tbUsuario u ON u.IdUsuario = t.IdResponsable
                    INNER JOIN tbEstadoTarea et ON et.IdEstadoTarea = t.IdEstadoTarea
                    WHERE p.IdResponsable = @IdGestor
                        AND (@IdProyecto = 0 OR p.IdProyecto = @IdProyecto)
                        AND t.FechaInicio <= @FechaHasta AND t.FechaLimite >= @FechaDesde
                        AND @Tipo <> N'Hito'
                    UNION ALL
                    SELECT N'Hito', h.Nombre, p.Nombre,
                        ISNULL(u.NombreCompleto, N'Sin responsable'),
                        h.FechaObjetivo, h.FechaObjetivo, eh.Nombre,
                        CAST(CASE WHEN eh.Nombre = N'Cumplido' THEN 100 ELSE 0 END AS DECIMAL(10,2)),
                        h.IdHito
                    FROM tbHito h
                    INNER JOIN tbProyecto p ON p.IdProyecto = h.IdProyecto
                    INNER JOIN tbEstadoHito eh ON eh.IdEstadoHito = h.IdEstadoHito
                    LEFT JOIN tbUsuario u ON u.IdUsuario = h.IdResponsable
                    WHERE p.IdResponsable = @IdGestor
                        AND (@IdProyecto = 0 OR p.IdProyecto = @IdProyecto)
                        AND h.FechaObjetivo BETWEEN @FechaDesde AND @FechaHasta
                        AND @Tipo <> N'Tarea'
                )
                SELECT Tipo, Actividad, Proyecto, Responsable, FechaInicio, FechaFin,
                    Estado, Avance, COUNT(*) OVER() AS TotalRegistros
                FROM Actividades
                ORDER BY FechaInicio, Proyecto, Actividad, Tipo, OrdenId
                OFFSET @Inicio ROWS FETCH NEXT 20 ROWS ONLY";
            SqlParameter[] parametros =
            {
                new SqlParameter("@IdGestor", idGestor),
                new SqlParameter("@IdProyecto", idProyecto),
                new SqlParameter("@FechaDesde", fechaDesde.Date),
                new SqlParameter("@FechaHasta", fechaHasta.Date),
                new SqlParameter("@Tipo", tipo)
            };
            return new Conexion().EjecutarPagina(consulta, parametros, pagina, out total);
        }

        private DataTable CrearTablaResultado()
        {
            DataTable tabla;

            tabla = new DataTable();
            tabla.Columns.Add("Tipo", typeof(string));
            tabla.Columns.Add("Actividad", typeof(string));
            tabla.Columns.Add("Proyecto", typeof(string));
            tabla.Columns.Add("Responsable", typeof(string));
            tabla.Columns.Add("FechaInicio", typeof(DateTime));
            tabla.Columns.Add("FechaFin", typeof(DateTime));
            tabla.Columns.Add("Estado", typeof(string));
            tabla.Columns.Add("Avance", typeof(decimal));
            return tabla;
        }

        private DataTable ObtenerTareas(int idGestor, int idProyecto, DateTime fechaDesde, DateTime fechaHasta)
        {
            string query;
            DataTable tareas;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT
            tbTarea.Nombre AS Actividad,
            tbProyecto.Nombre AS Proyecto,
            tbUsuario.NombreCompleto AS Responsable,
            tbTarea.FechaInicio,
            tbTarea.FechaLimite AS FechaFin,
            tbEstadoTarea.Nombre AS Estado,
            tbTarea.AvanceActual AS Avance
            FROM tbTarea
            INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
            INNER JOIN tbUsuario ON tbTarea.IdResponsable = tbUsuario.IdUsuario
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbProyecto.IdResponsable = @IdGestor
            AND (@IdProyecto = 0 OR tbProyecto.IdProyecto = @IdProyecto)
            AND tbTarea.FechaInicio <= @FechaHasta
            AND tbTarea.FechaLimite >= @FechaDesde";

            tareas = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return tareas;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdGestor", idGestor);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                comando.Parameters.AddWithValue("@FechaDesde", fechaDesde.Date);
                comando.Parameters.AddWithValue("@FechaHasta", fechaHasta.Date);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tareas);
                adaptador.Dispose();
                comando.Dispose();
            }
            catch (SqlException ex)
            {
                Conexion.MostrarErrorSql(ex);
            }
            finally
            {
                conexionSql.Close();
                conexionSql.Dispose();
            }

            return tareas;
        }

        private DataTable ObtenerHitos(int idGestor, int idProyecto, DateTime fechaDesde, DateTime fechaHasta)
        {
            string query;
            DataTable hitos;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT
            tbHito.Nombre AS Actividad,
            tbProyecto.Nombre AS Proyecto,
            ISNULL(tbUsuario.NombreCompleto, N'Sin responsable') AS Responsable,
            tbHito.FechaObjetivo AS Fecha,
            tbEstadoHito.Nombre AS Estado
            FROM tbHito
            INNER JOIN tbProyecto ON tbHito.IdProyecto = tbProyecto.IdProyecto
            INNER JOIN tbEstadoHito ON tbHito.IdEstadoHito = tbEstadoHito.IdEstadoHito
            LEFT JOIN tbUsuario ON tbHito.IdResponsable = tbUsuario.IdUsuario
            WHERE tbProyecto.IdResponsable = @IdGestor
            AND (@IdProyecto = 0 OR tbProyecto.IdProyecto = @IdProyecto)
            AND tbHito.FechaObjetivo >= @FechaDesde
            AND tbHito.FechaObjetivo <= @FechaHasta";

            hitos = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return hitos;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdGestor", idGestor);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                comando.Parameters.AddWithValue("@FechaDesde", fechaDesde.Date);
                comando.Parameters.AddWithValue("@FechaHasta", fechaHasta.Date);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(hitos);
                adaptador.Dispose();
                comando.Dispose();
            }
            catch (SqlException ex)
            {
                Conexion.MostrarErrorSql(ex);
            }
            finally
            {
                conexionSql.Close();
                conexionSql.Dispose();
            }

            return hitos;
        }
    }
}
