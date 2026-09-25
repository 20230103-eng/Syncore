using System;
using System.Data;
using Modelo.Modelo;
using System.Data.SqlClient;

namespace Modelo.Modelo.Entidades
{
    public class Tarea
    {
        private int idTarea;
        private int idProyecto;
        private int? idHito;
        private string nombre;
        private string descripcion;
        private string observaciones;
        private int idResponsable;
        private int idCreador;
        private int idPrioridad;
        private int idEstadoTarea;
        private string prioridad;
        private string estado;
        private DateTime fechaInicio;
        private DateTime fechaLimite;
        private decimal avanceActual;
        private DateTime fechaCreacion;
        private DateTime? fechaCompletada;
        private Conexion conexion;

        public int IdTarea
        {
            get
            {
                return idTarea;
            }
            set
            {
                idTarea = value;
            }
        }

        public int IdProyecto
        {
            get
            {
                return idProyecto;
            }
            set
            {
                idProyecto = value;
            }
        }

        public int? IdHito
        {
            get
            {
                return idHito;
            }
            set
            {
                idHito = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        public string Observaciones
        {
            get
            {
                return observaciones;
            }
            set
            {
                observaciones = value;
            }
        }

        public int IdResponsable
        {
            get
            {
                return idResponsable;
            }
            set
            {
                idResponsable = value;
            }
        }

        public int IdCreador
        {
            get
            {
                return idCreador;
            }
            set
            {
                idCreador = value;
            }
        }

        public int IdPrioridad
        {
            get
            {
                return idPrioridad;
            }
            set
            {
                idPrioridad = value;
            }
        }

        public int IdEstadoTarea
        {
            get
            {
                return idEstadoTarea;
            }
            set
            {
                idEstadoTarea = value;
            }
        }

        public string Prioridad
        {
            get
            {
                return prioridad;
            }
            set
            {
                prioridad = value;
            }
        }

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

        public DateTime FechaInicio
        {
            get
            {
                return fechaInicio;
            }
            set
            {
                fechaInicio = value;
            }
        }

        public DateTime FechaLimite
        {
            get
            {
                return fechaLimite;
            }
            set
            {
                fechaLimite = value;
            }
        }

        public decimal AvanceActual
        {
            get
            {
                return avanceActual;
            }
            set
            {
                avanceActual = value;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }
            set
            {
                fechaCreacion = value;
            }
        }

        public DateTime? FechaCompletada
        {
            get
            {
                return fechaCompletada;
            }
            set
            {
                fechaCompletada = value;
            }
        }

        public Tarea()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerDetalleTarea(int idTarea)
        {
            string query;
            DataTable tarea;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT
            tbTarea.IdTarea,
            tbTarea.IdProyecto,
            tbTarea.Nombre Tarea,
            tbTarea.Descripcion,
            tbTarea.Observacion AS Observaciones,
            tbPrioridad.Nombre AS Prioridad,
            tbEstadoTarea.Nombre AS Estado,
            tbTarea.FechaInicio,
            tbTarea.FechaLimite,
            tbTarea.AvanceActual,
            tbProyecto.Nombre Proyecto,
            tbProyecto.IdResponsable AS IdResponsableProyecto,
            tbUsuario.NombreCompleto Responsable,
            tbHito.Nombre Hito
            FROM tbTarea
            INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
            INNER JOIN tbUsuario ON tbTarea.IdResponsable = tbUsuario.IdUsuario
            INNER JOIN tbPrioridad ON tbTarea.IdPrioridad = tbPrioridad.IdPrioridad
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            LEFT JOIN tbHito ON tbTarea.IdHito = tbHito.IdHito
            WHERE tbTarea.IdTarea = @IdTarea";

            tarea = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return tarea;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdTarea", idTarea);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tarea);
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

            return tarea;
        }

        public DataTable ObtenerTareasUsuarioProyecto(int idUsuario, int idProyecto)
        {
            string query;
            DataTable tareas;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT tbTarea.IdTarea, tbTarea.Nombre AS Tarea, tbTarea.AvanceActual
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = @IdUsuario
            AND tbTarea.IdProyecto = @IdProyecto
            AND tbEstadoTarea.Nombre <> N'Completada'
            AND tbEstadoTarea.Nombre <> N'En revisión'
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

        public int ObtenerAvanceActualTarea(int idTarea)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int avance;

            query = @"
            SELECT AvanceActual
            FROM tbTarea
            WHERE IdTarea = @IdTarea";

            avance = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return avance;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdTarea", idTarea);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado != null && resultado != DBNull.Value)
                {
                    avance = Convert.ToInt32(resultado);
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

            return avance;
        }

        public bool CrearTarea()
        {
            string query;
            SqlConnection conexionSql;
            SqlTransaction transaccion;
            SqlCommand comando;
            object observaciones;
            object idHito;
            object resultado;
            bool creada;

            observaciones = this.Observaciones;
            idHito = DBNull.Value;

            if (string.IsNullOrEmpty(this.Observaciones) == true || string.IsNullOrEmpty(this.Observaciones.Trim()) == true)
            {
                observaciones = DBNull.Value;
            }

            if (this.IdHito.HasValue == true)
            {
                idHito = this.IdHito.Value;
            }

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            transaccion = conexionSql.BeginTransaction();
            creada = false;

            try
            {
                query = @"
                INSERT INTO tbTarea
                (IdProyecto, IdHito, Nombre, Descripcion, Observacion, IdResponsable, IdCreador, IdPrioridad, IdEstadoTarea, FechaInicio, FechaLimite, AvanceActual, FechaCreacion)
                SELECT
                @IdProyecto, @IdHito, @Nombre, @Descripcion, @Observacion, @IdResponsable, @IdCreador, @IdPrioridad, @IdEstadoTarea, @FechaInicio, @FechaLimite, @AvanceActual, GETDATE()
                WHERE EXISTS
                (
                    SELECT 1
                    FROM tbEquipoProyecto
                    INNER JOIN tbUsuario ON tbEquipoProyecto.IdUsuario = tbUsuario.IdUsuario
                    INNER JOIN tbTipoUsuario ON tbUsuario.IdTipoUsuario = tbTipoUsuario.IdTipoUsuario
                    WHERE tbEquipoProyecto.IdProyecto = @IdProyecto
                    AND tbEquipoProyecto.IdUsuario = @IdResponsable
                    AND tbEquipoProyecto.Activo = 1
                    AND tbUsuario.Activo = 1
                    AND tbTipoUsuario.Nombre = N'Colaborador'
                );
                SELECT SCOPE_IDENTITY();";

                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
                comando.Parameters.AddWithValue("@IdHito", idHito);
                comando.Parameters.AddWithValue("@Nombre", this.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", this.Descripcion);
                comando.Parameters.AddWithValue("@Observacion", observaciones);
                comando.Parameters.AddWithValue("@IdResponsable", this.IdResponsable);
                comando.Parameters.AddWithValue("@IdCreador", this.IdCreador);
                comando.Parameters.AddWithValue("@IdPrioridad", this.IdPrioridad);
                comando.Parameters.AddWithValue("@IdEstadoTarea", this.IdEstadoTarea);
                comando.Parameters.AddWithValue("@FechaInicio", this.FechaInicio.Date);
                comando.Parameters.AddWithValue("@FechaLimite", this.FechaLimite.Date);
                comando.Parameters.AddWithValue("@AvanceActual", this.AvanceActual);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado == null || resultado == DBNull.Value)
                {
                    transaccion.Rollback();
                    return false;
                }

                this.IdTarea = Convert.ToInt32(resultado);

                query = @"
                INSERT INTO tbNotificacion
                (IdUsuario, IdTipoNotificacion, Titulo, Mensaje, IdPrioridad, IdTarea, IdProyecto, Leida, FechaCreacion)
                VALUES
                (@IdUsuario,
                (SELECT TOP 1 IdTipoNotificacion FROM tbTipoNotificacion WHERE Nombre = N'Nueva tarea'),
                @Titulo,
                @Mensaje,
                @IdPrioridad,
                @IdTarea,
                @IdProyecto,
                0,
                GETDATE())";

                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdUsuario", this.IdResponsable);
                comando.Parameters.AddWithValue("@Titulo", "Nueva tarea asignada");
                comando.Parameters.AddWithValue("@Mensaje", "Se te asignó la tarea " + this.Nombre + ".");
                comando.Parameters.AddWithValue("@IdPrioridad", this.IdPrioridad);
                comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
                comando.ExecuteNonQuery();
                comando.Dispose();

                transaccion.Commit();
                creada = true;
            }
            catch (SqlException ex)
            {
                transaccion.Rollback();
                Conexion.MostrarErrorSql(ex);
            }
            finally
            {
                transaccion.Dispose();
                conexionSql.Close();
                conexionSql.Dispose();
            }

            return creada;
        }

        public DataTable ObtenerTareaParaEditar(int idTarea)
        {
            string query;
            DataTable datos;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT
            tbTarea.IdTarea,
            tbTarea.IdProyecto,
            tbTarea.IdHito,
            tbTarea.Nombre,
            tbTarea.Descripcion,
            tbTarea.Observacion,
            tbTarea.IdResponsable,
            tbTarea.IdPrioridad,
            tbTarea.IdEstadoTarea,
            tbEstadoTarea.Nombre AS Estado,
            tbTarea.FechaInicio,
            tbTarea.FechaLimite,
            tbTarea.AvanceActual
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdTarea = @IdTarea";

            datos = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return datos;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdTarea", idTarea);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(datos);
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

            return datos;
        }

        public bool ActualizarTarea()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object observaciones;
            bool actualizada;

            observaciones = this.Observaciones;

            if (string.IsNullOrEmpty(this.Observaciones) == true || string.IsNullOrEmpty(this.Observaciones.Trim()) == true)
            {
                observaciones = DBNull.Value;
            }

            query = @"
            UPDATE tbTarea
            SET IdProyecto = @IdProyecto,
            Nombre = @Nombre,
            Descripcion = @Descripcion,
            Observacion = @Observacion,
            IdResponsable = @IdResponsable,
            IdPrioridad = @IdPrioridad,
            FechaInicio = @FechaInicio,
            FechaLimite = @FechaLimite
            WHERE IdTarea = @IdTarea
            AND EXISTS
            (
                SELECT 1
                FROM tbProyecto
                WHERE tbProyecto.IdProyecto = @IdProyecto
                AND tbProyecto.IdResponsable = @IdGestor
            )
            AND EXISTS
            (
                SELECT 1
                FROM tbEquipoProyecto
                INNER JOIN tbUsuario ON tbEquipoProyecto.IdUsuario = tbUsuario.IdUsuario
                INNER JOIN tbTipoUsuario ON tbUsuario.IdTipoUsuario = tbTipoUsuario.IdTipoUsuario
                WHERE tbEquipoProyecto.IdProyecto = @IdProyecto
                AND tbEquipoProyecto.IdUsuario = @IdResponsable
                AND tbEquipoProyecto.Activo = 1
                AND tbUsuario.Activo = 1
                AND tbTipoUsuario.Nombre = N'Colaborador'
            )";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            actualizada = false;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
                comando.Parameters.AddWithValue("@Nombre", this.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", this.Descripcion);
                comando.Parameters.AddWithValue("@Observacion", observaciones);
                comando.Parameters.AddWithValue("@IdResponsable", this.IdResponsable);
                comando.Parameters.AddWithValue("@IdPrioridad", this.IdPrioridad);
                comando.Parameters.AddWithValue("@FechaInicio", this.FechaInicio.Date);
                comando.Parameters.AddWithValue("@FechaLimite", this.FechaLimite.Date);
                comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                comando.Parameters.AddWithValue("@IdGestor", this.IdCreador);
                actualizada = comando.ExecuteNonQuery() > 0;
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

            return actualizada;
        }

        public bool EliminarTarea()
        {
            string query;
            SqlConnection conexionSql;
            SqlTransaction transaccion;
            SqlCommand comando;
            bool eliminada;

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            transaccion = conexionSql.BeginTransaction();
            eliminada = false;

            try
            {
                query = @"
                DELETE FROM tbNotificacion
                WHERE IdTarea = @IdTarea";

                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                comando.ExecuteNonQuery();
                comando.Dispose();

                query = @"
                DELETE FROM tbTarea
                WHERE IdTarea = @IdTarea
                AND EXISTS
                (
                    SELECT 1
                    FROM tbProyecto
                    WHERE tbProyecto.IdProyecto = tbTarea.IdProyecto
                    AND tbProyecto.IdResponsable = @IdGestor
                )";

                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                comando.Parameters.AddWithValue("@IdGestor", this.IdCreador);
                eliminada = comando.ExecuteNonQuery() > 0;
                comando.Dispose();

                if (eliminada == true)
                {
                    transaccion.Commit();
                }
                else
                {
                    transaccion.Rollback();
                }
            }
            catch (SqlException ex)
            {
                transaccion.Rollback();
                Conexion.MostrarErrorSql(ex);
            }
            finally
            {
                transaccion.Dispose();
                conexionSql.Close();
                conexionSql.Dispose();
            }

            return eliminada;
        }

    }
}
