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
            SELECT
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
            AND tbEstadoProyecto.Nombre <> N'Cerrado'";

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
            tbEstadoTarea.Nombre AS Estado
            FROM tbTarea
            INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
            INNER JOIN tbUsuario ON tbTarea.IdResponsable = tbUsuario.IdUsuario
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            INNER JOIN tbEstadoProyecto ON tbProyecto.IdEstadoProyecto = tbEstadoProyecto.IdEstadoProyecto
            WHERE tbEstadoProyecto.Nombre <> N'Cerrado'
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
    }
}
