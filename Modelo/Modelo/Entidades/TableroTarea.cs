using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class TableroTarea
    {
        private string estado;
        private int cantidad;
        private Conexion conexion;

        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }

        public TableroTarea()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerResumenTareasVencidas()
        {
            string query = @"
            SELECT
            COUNT(*) AS TareasVencidas,
            COUNT(DISTINCT IdProyecto) AS ProyectosAfectados
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbEstadoTarea.Nombre = N'Vencida'";

            DataTable resumen = conexion.EjecutarConsulta(query);
            return resumen;
        }

        public DataTable ObtenerTareasPorEstado()
        {
            string query = @"
            SELECT
            tbEstadoTarea.Nombre AS Estado,
            COUNT(*) AS Cantidad
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            GROUP BY tbEstadoTarea.Nombre";

            DataTable tareas = conexion.EjecutarConsulta(query);
            return tareas;
        }

        public DataTable ObtenerTareasConResponsableInactivo()
        {
            string query = @"
            SELECT TOP (5)
            tbTarea.IdTarea,
            tbTarea.Nombre AS Tarea,
            tbProyecto.Nombre AS Proyecto,
            tbUsuario.NombreCompleto AS Responsable,
            tbTarea.FechaLimite
            FROM tbTarea
            INNER JOIN tbProyecto
            ON tbTarea.IdProyecto = tbProyecto.IdProyecto
            INNER JOIN tbUsuario
            ON tbTarea.IdResponsable = tbUsuario.IdUsuario
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            INNER JOIN tbEstadoProyecto ON tbProyecto.IdEstadoProyecto = tbEstadoProyecto.IdEstadoProyecto
            WHERE tbUsuario.Activo = 0
            AND tbEstadoTarea.Nombre <> N'Completada'
            AND tbEstadoProyecto.Nombre <> N'Cerrado'
            ORDER BY tbTarea.FechaLimite, tbTarea.IdTarea";

            DataTable tareas = conexion.EjecutarConsulta(query);
            return tareas;
        }

        public DataTable ObtenerTareasProximasUsuario(int idUsuario, int cantidad)
        {
            string query;
            DataTable tareas;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT TOP (@Cantidad)
            tbTarea.IdTarea,
            tbTarea.Nombre AS Tarea,
            tbProyecto.Nombre AS Proyecto,
            tbTarea.FechaLimite,
            tbPrioridad.Nombre AS Prioridad,
            tbEstadoTarea.Nombre AS Estado,
            tbTarea.AvanceActual
            FROM tbTarea
            INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
            INNER JOIN tbPrioridad ON tbTarea.IdPrioridad = tbPrioridad.IdPrioridad
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = @IdUsuario
            AND tbEstadoTarea.Nombre <> N'Completada'
            ORDER BY tbTarea.FechaLimite";

            tareas = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return tareas;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@Cantidad", cantidad);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
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

        public DataTable ObtenerTareasProximasUsuarioPagina(int idUsuario, int pagina, int tamanoPagina, out int total)
        {
            string consulta = @"
                SELECT tbTarea.IdTarea, tbTarea.Nombre AS Tarea,
                    tbProyecto.Nombre AS Proyecto, tbTarea.FechaLimite,
                    tbPrioridad.Nombre AS Prioridad, tbEstadoTarea.Nombre AS Estado,
                    tbTarea.AvanceActual, COUNT(*) OVER() AS TotalRegistros
                FROM tbTarea
                INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
                INNER JOIN tbPrioridad ON tbTarea.IdPrioridad = tbPrioridad.IdPrioridad
                INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
                WHERE tbTarea.IdResponsable = @IdUsuario
                AND tbEstadoTarea.Nombre <> N'Completada'
                ORDER BY tbTarea.FechaLimite, tbTarea.IdTarea
                OFFSET @Inicio ROWS FETCH NEXT @Tamano ROWS ONLY";
            SqlParameter[] parametros = { new SqlParameter("@IdUsuario", idUsuario) };
            return new Conexion().EjecutarPaginaTamano(consulta, parametros, pagina, tamanoPagina, out total);
        }

        public DataTable ObtenerTareasCompletadasUsuario(int idUsuario, int dias, int cantidad)
        {
            string query;
            DataTable tareas;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT TOP (@Cantidad)
            tbTarea.Nombre AS Tarea,
            tbTarea.FechaCompletada
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = @IdUsuario
            AND tbEstadoTarea.Nombre = N'Completada'
            AND tbTarea.FechaCompletada >= DATEADD(DAY, -@Dias, GETDATE())
            ORDER BY tbTarea.FechaCompletada DESC";

            tareas = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return tareas;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@Cantidad", cantidad);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@Dias", dias);
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

        public DataTable ObtenerTareasCompletadasUsuarioPagina(int idUsuario, int dias, int pagina, int tamanoPagina, out int total)
        {
            string consulta = @"
                SELECT tbTarea.Nombre AS Tarea, tbTarea.FechaCompletada,
                    COUNT(*) OVER() AS TotalRegistros
                FROM tbTarea
                INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
                WHERE tbTarea.IdResponsable = @IdUsuario
                AND tbEstadoTarea.Nombre = N'Completada'
                AND tbTarea.FechaCompletada >= DATEADD(DAY, -@Dias, GETDATE())
                ORDER BY tbTarea.FechaCompletada DESC, tbTarea.IdTarea DESC
                OFFSET @Inicio ROWS FETCH NEXT @Tamano ROWS ONLY";
            SqlParameter[] parametros =
            {
                new SqlParameter("@IdUsuario", idUsuario),
                new SqlParameter("@Dias", dias)
            };
            return new Conexion().EjecutarPaginaTamano(consulta, parametros, pagina, tamanoPagina, out total);
        }

        public DataTable ObtenerTareasTableroGestor(int idProyecto)
        {
            string query;
            DataTable tareas;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT
            tbTarea.IdTarea,
            tbTarea.Nombre Tarea,
            tbProyecto.Nombre Proyecto,
            tbTarea.IdResponsable,
            tbUsuario.NombreCompleto AS Responsable,
            tbTarea.FechaLimite,
            tbEstadoTarea.Nombre AS Estado,
            ultimoAvance.IdAvance AS IdUltimoAvance
            FROM tbTarea
            INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
            INNER JOIN tbUsuario ON tbTarea.IdResponsable = tbUsuario.IdUsuario
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            INNER JOIN tbEstadoProyecto ON tbProyecto.IdEstadoProyecto = tbEstadoProyecto.IdEstadoProyecto
            OUTER APPLY
            (
                SELECT TOP 1 tbAvance.IdAvance
                FROM tbAvance
                WHERE tbAvance.IdTarea = tbTarea.IdTarea
                ORDER BY tbAvance.IdAvance DESC
            ) AS ultimoAvance
            WHERE tbEstadoProyecto.Nombre <> N'Cerrado'
            AND (@IdProyecto = 0 OR tbTarea.IdProyecto = @IdProyecto)
            ORDER BY
            CASE WHEN ultimoAvance.IdAvance IS NULL THEN 1 ELSE 0 END,
            ultimoAvance.IdAvance DESC,
            tbTarea.FechaLimite ASC,
            tbTarea.IdTarea DESC";

            tareas = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return tareas;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
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

        public DataTable ObtenerTareasTableroUsuario(int idUsuario, int idProyecto)
        {
            string query;
            DataTable tareas;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT
            tbTarea.IdTarea,
            tbTarea.Nombre Tarea,
            tbProyecto.Nombre Proyecto,
            tbTarea.FechaLimite,
            tbEstadoTarea.Nombre AS Estado
            FROM tbTarea
            INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = @IdUsuario
            AND (@IdProyecto = 0 OR tbTarea.IdProyecto = @IdProyecto)
            ORDER BY tbTarea.FechaLimite";

            tareas = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return tareas;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
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
        public DataTable ObtenerTareasTableroGestorPagina(int idProyecto, int idResponsable, string texto, int pagina)
        {
            DataTable tareas = new DataTable();
            SqlConnection conexionSql = Conexion.conectar();
            if (conexionSql == null)
            {
                return tareas;
            }
            string query = @"
                WITH TareasFiltradas AS
                (
                    SELECT t.IdTarea, t.Nombre AS Tarea, p.Nombre AS Proyecto,
                        t.IdResponsable, u.NombreCompleto AS Responsable,
                        t.FechaLimite, et.Nombre AS Estado, ultimo.IdAvance AS IdUltimoAvance
                    FROM tbTarea t
                    INNER JOIN tbProyecto p ON p.IdProyecto = t.IdProyecto
                    INNER JOIN tbUsuario u ON u.IdUsuario = t.IdResponsable
                    INNER JOIN tbEstadoTarea et ON et.IdEstadoTarea = t.IdEstadoTarea
                    INNER JOIN tbEstadoProyecto ep ON ep.IdEstadoProyecto = p.IdEstadoProyecto
                    OUTER APPLY
                    (
                        SELECT TOP 1 a.IdAvance
                        FROM tbAvance a WHERE a.IdTarea = t.IdTarea
                        ORDER BY a.IdAvance DESC
                    ) ultimo
                    WHERE ep.Nombre <> N'Cerrado'
                        AND (@IdProyecto = 0 OR t.IdProyecto = @IdProyecto)
                        AND (@IdResponsable = 0 OR t.IdResponsable = @IdResponsable)
                        AND (@Texto = N'' OR t.Nombre LIKE N'%' + @Texto + N'%'
                            OR p.Nombre LIKE N'%' + @Texto + N'%')
                )
                SELECT *, COUNT(*) OVER() AS TotalRegistros,
                    SUM(CASE WHEN Estado IN (N'Pendiente', N'Devuelta') THEN 1 ELSE 0 END) OVER() AS Conteo1,
                    SUM(CASE WHEN Estado = N'En progreso' THEN 1 ELSE 0 END) OVER() AS Conteo2,
                    SUM(CASE WHEN Estado = N'En revisión' THEN 1 ELSE 0 END) OVER() AS Conteo3,
                    SUM(CASE WHEN Estado = N'Vencida' THEN 1 ELSE 0 END) OVER() AS Conteo4,
                    SUM(CASE WHEN Estado = N'Completada' THEN 1 ELSE 0 END) OVER() AS Conteo5
                FROM TareasFiltradas
                ORDER BY CASE WHEN IdUltimoAvance IS NULL THEN 1 ELSE 0 END,
                    IdUltimoAvance DESC, FechaLimite ASC, IdTarea DESC
                OFFSET @Inicio ROWS FETCH NEXT 20 ROWS ONLY";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, conexionSql))
                {
                    comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                    comando.Parameters.AddWithValue("@IdResponsable", idResponsable);
                    if (texto == null)
                    {
                        texto = "";
                    }
                    comando.Parameters.AddWithValue("@Texto", texto);
                    comando.Parameters.AddWithValue("@Inicio", Math.Max(0, pagina) * 20);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tareas);
                    }
                }
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

        public DataTable ObtenerTareasTableroUsuarioPagina(int idUsuario, int idProyecto, int pagina)
        {
            DataTable tareas = new DataTable();
            SqlConnection conexionSql = Conexion.conectar();
            if (conexionSql == null)
            {
                return tareas;
            }
            string query = @"
                WITH TareasFiltradas AS
                (
                    SELECT t.IdTarea, t.Nombre AS Tarea, p.Nombre AS Proyecto,
                        t.FechaLimite, et.Nombre AS Estado, ultimo.IdAvance AS IdUltimoAvance
                    FROM tbTarea t
                    INNER JOIN tbProyecto p ON p.IdProyecto = t.IdProyecto
                    INNER JOIN tbEstadoTarea et ON et.IdEstadoTarea = t.IdEstadoTarea
                    OUTER APPLY
                    (
                        SELECT TOP 1 a.IdAvance
                        FROM tbAvance a WHERE a.IdTarea = t.IdTarea
                        ORDER BY a.IdAvance DESC
                    ) ultimo
                    WHERE t.IdResponsable = @IdUsuario
                        AND (@IdProyecto = 0 OR t.IdProyecto = @IdProyecto)
                )
                SELECT *, COUNT(*) OVER() AS TotalRegistros,
                    SUM(CASE WHEN Estado IN (N'Pendiente', N'Vencida') THEN 1 ELSE 0 END) OVER() AS Conteo1,
                    SUM(CASE WHEN Estado = N'En progreso' THEN 1 ELSE 0 END) OVER() AS Conteo2,
                    SUM(CASE WHEN Estado = N'En revisión' THEN 1 ELSE 0 END) OVER() AS Conteo3,
                    SUM(CASE WHEN Estado = N'Devuelta' THEN 1 ELSE 0 END) OVER() AS Conteo4,
                    SUM(CASE WHEN Estado = N'Completada' THEN 1 ELSE 0 END) OVER() AS Conteo5
                FROM TareasFiltradas
                ORDER BY CASE WHEN IdUltimoAvance IS NULL THEN 1 ELSE 0 END,
                    IdUltimoAvance DESC, FechaLimite ASC, IdTarea DESC
                OFFSET @Inicio ROWS FETCH NEXT 20 ROWS ONLY";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, conexionSql))
                {
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                    comando.Parameters.AddWithValue("@Inicio", Math.Max(0, pagina) * 20);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tareas);
                    }
                }
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

        public DataTable ObtenerAlertasGestionPagina(int pagina, int tamanoPagina, out int total)
        {
            string consulta = @"
                WITH Alertas AS
                (
                    SELECT p.IdProyecto, 0 AS IdTarea, p.Nombre AS Nombre,
                        CAST(N'' AS NVARCHAR(200)) AS Responsable,
                        ep.Nombre AS Categoria, p.FechaCierreEstimada AS Fecha,
                        (SELECT COUNT(*) FROM tbTarea t
                         INNER JOIN tbEstadoTarea et ON et.IdEstadoTarea = t.IdEstadoTarea
                         WHERE t.IdProyecto = p.IdProyecto AND et.Nombre = N'Vencida') AS TareasVencidas,
                        0 AS Orden
                    FROM tbProyecto p
                    INNER JOIN tbEstadoProyecto ep ON ep.IdEstadoProyecto = p.IdEstadoProyecto
                    WHERE ep.Nombre IN (N'Crítico', N'Observación')
                    UNION ALL
                    SELECT 0, t.IdTarea, t.Nombre, u.NombreCompleto,
                        N'Responsable inactivo', t.FechaLimite, 0, 1
                    FROM tbTarea t
                    INNER JOIN tbProyecto p ON p.IdProyecto = t.IdProyecto
                    INNER JOIN tbUsuario u ON u.IdUsuario = t.IdResponsable
                    INNER JOIN tbEstadoTarea et ON et.IdEstadoTarea = t.IdEstadoTarea
                    INNER JOIN tbEstadoProyecto ep ON ep.IdEstadoProyecto = p.IdEstadoProyecto
                    WHERE u.Activo = 0 AND et.Nombre <> N'Completada' AND ep.Nombre <> N'Cerrado'
                )
                SELECT IdProyecto, IdTarea, Nombre, Responsable, Categoria, Fecha,
                    TareasVencidas, COUNT(*) OVER() AS TotalRegistros
                FROM Alertas
                ORDER BY Orden, Fecha, IdProyecto, IdTarea
                OFFSET @Inicio ROWS FETCH NEXT @Tamano ROWS ONLY";
            return new Conexion().EjecutarPaginaTamano(consulta, new SqlParameter[0], pagina, tamanoPagina, out total);
        }

    }
}
