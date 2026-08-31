using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelo.Modelo
{
    public class ReglasSistema
    {
        private Conexion conexion;

        public ReglasSistema()
        {
            conexion = new Conexion();
        }

        public void AplicarReglas()
        {
            ActualizarTareasVencidas();
            ActualizarEstadosProyectos();
        }

        private void ActualizarTareasVencidas()
        {
            string query;
            DataTable tareas;

            query = @"
            SELECT
            tbTarea.IdTarea,
            tbTarea.IdProyecto,
            tbTarea.IdResponsable,
            tbTarea.Nombre,
            tbTarea.FechaLimite,
            tbEstadoTarea.Nombre AS Estado
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea";

            tareas = conexion.EjecutarConsulta(query);

            foreach (DataRow fila in tareas.Rows)
            {
                int idTarea;
                int idProyecto;
                int idResponsable;
                string nombre;
                string estado;
                DateTime fechaLimite;

                idTarea = Convert.ToInt32(fila["IdTarea"]);
                idProyecto = Convert.ToInt32(fila["IdProyecto"]);
                idResponsable = Convert.ToInt32(fila["IdResponsable"]);
                nombre = fila["Nombre"].ToString();
                estado = fila["Estado"].ToString();
                fechaLimite = Convert.ToDateTime(fila["FechaLimite"]);

                if (fechaLimite.Date < DateTime.Today && estado != "Completada" && estado != "Vencida")
                {
                    if (MarcarTareaVencida(idTarea) == true)
                    {
                        CrearAlertaTarea(idResponsable, idTarea, idProyecto, nombre);
                    }
                }
            }
        }

        private bool MarcarTareaVencida(int idTarea)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            int filasAfectadas;

            query = @"
            UPDATE tbTarea
            SET IdEstadoTarea = (SELECT TOP 1 IdEstadoTarea FROM tbEstadoTarea WHERE Nombre = @Estado)
            WHERE IdTarea = @IdTarea";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@Estado", "Vencida");
                comando.Parameters.AddWithValue("@IdTarea", idTarea);
                filasAfectadas = comando.ExecuteNonQuery();
                comando.Dispose();

                if (filasAfectadas > 0)
                {
                    return true;
                }

                return false;
            }
            catch (SqlException ex)
            {
                Conexion.MostrarErrorSql(ex);
                return false;
            }
            finally
            {
                conexionSql.Close();
                conexionSql.Dispose();
            }
        }

        private void ActualizarEstadosProyectos()
        {
            string query;
            DataTable proyectos;

            query = @"
            SELECT
            tbProyecto.IdProyecto,
            tbProyecto.FechaCierreEstimada,
            tbEstadoProyecto.Nombre AS Estado
            FROM tbProyecto
            INNER JOIN tbEstadoProyecto ON tbProyecto.IdEstadoProyecto = tbEstadoProyecto.IdEstadoProyecto";

            proyectos = conexion.EjecutarConsulta(query);

            foreach (DataRow fila in proyectos.Rows)
            {
                int idProyecto;
                string estadoActual;
                DateTime fechaCierre;
                int cantidadVencidas;
                string nuevoEstado;

                idProyecto = Convert.ToInt32(fila["IdProyecto"]);
                estadoActual = fila["Estado"].ToString();
                fechaCierre = Convert.ToDateTime(fila["FechaCierreEstimada"]);

                if (estadoActual == "Cerrado")
                {
                    continue;
                }

                cantidadVencidas = ContarTareasVencidasProyecto(idProyecto);
                nuevoEstado = "Activo";

                if (fechaCierre.Date < DateTime.Today || cantidadVencidas >= 3)
                {
                    nuevoEstado = "Crítico";
                }
                else if (cantidadVencidas >= 1)
                {
                    nuevoEstado = "Observación";
                }

                if (estadoActual != nuevoEstado)
                {
                    ActualizarEstadoProyecto(idProyecto, nuevoEstado);
                }
            }
        }

        private int ContarTareasVencidasProyecto(int idProyecto)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int cantidad;

            query = @"
            SELECT COUNT(*)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdProyecto = @IdProyecto
            AND tbEstadoTarea.Nombre = @Estado";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return 0;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                comando.Parameters.AddWithValue("@Estado", "Vencida");
                resultado = comando.ExecuteScalar();
                comando.Dispose();
                cantidad = 0;

                if (resultado != null && resultado != DBNull.Value)
                {
                    cantidad = Convert.ToInt32(resultado);
                }

                return cantidad;
            }
            catch (SqlException ex)
            {
                Conexion.MostrarErrorSql(ex);
                return 0;
            }
            finally
            {
                conexionSql.Close();
                conexionSql.Dispose();
            }
        }

        private bool ActualizarEstadoProyecto(int idProyecto, string nuevoEstado)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            int filasAfectadas;

            query = @"
            UPDATE tbProyecto
            SET IdEstadoProyecto = (SELECT TOP 1 IdEstadoProyecto FROM tbEstadoProyecto WHERE Nombre = @Estado),
            UltimaModificacion = GETDATE()
            WHERE IdProyecto = @IdProyecto";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@Estado", nuevoEstado);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                filasAfectadas = comando.ExecuteNonQuery();
                comando.Dispose();

                if (filasAfectadas > 0)
                {
                    return true;
                }

                return false;
            }
            catch (SqlException ex)
            {
                Conexion.MostrarErrorSql(ex);
                return false;
            }
            finally
            {
                conexionSql.Close();
                conexionSql.Dispose();
            }
        }

        private void CrearAlertaTarea(int idUsuario, int idTarea, int idProyecto, string nombreTarea)
        {
            string mensaje;
            string consulta;
            SqlConnection conexionSql;
            SqlCommand comando;

            mensaje = "La tarea " + nombreTarea + " está vencida";

            consulta = @"
            INSERT INTO tbNotificacion
            (IdUsuario, IdTipoNotificacion, Titulo, Mensaje, IdPrioridad, IdTarea, IdProyecto, Leida, FechaCreacion)
            VALUES
            (@IdUsuario,
            (SELECT TOP 1 IdTipoNotificacion FROM tbTipoNotificacion WHERE Nombre = @Tipo),
            @Titulo,
            @Mensaje,
            (SELECT TOP 1 IdPrioridad FROM tbPrioridad WHERE Nombre = @Prioridad),
            @IdTarea,
            @IdProyecto,
            @Leida,
            @FechaCreacion)";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return;
            }

            try
            {
                comando = new SqlCommand(consulta, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@Tipo", "Tarea vencida");
                comando.Parameters.AddWithValue("@Titulo", "Tarea vencida");
                comando.Parameters.AddWithValue("@Mensaje", mensaje);
                comando.Parameters.AddWithValue("@Prioridad", "Alta");
                comando.Parameters.AddWithValue("@IdTarea", idTarea);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                comando.Parameters.AddWithValue("@Leida", false);
                comando.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                comando.ExecuteNonQuery();
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
        }
    }
}
