using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class RevisionTarea
    {
        private int idRevision;
        private int idTarea;
        private int idRevisor;
        private DateTime fechaEnvio;
        private DateTime? fechaRevision;
        private string resultado;
        private string comentario;
        private Conexion conexion;

        public int IdRevision
        {
            get
            {
                return idRevision;
            }
            set
            {
                idRevision = value;
            }
        }

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

        public int IdRevisor
        {
            get
            {
                return idRevisor;
            }
            set
            {
                idRevisor = value;
            }
        }

        public DateTime FechaEnvio
        {
            get
            {
                return fechaEnvio;
            }
            set
            {
                fechaEnvio = value;
            }
        }

        public DateTime? FechaRevision
        {
            get
            {
                return fechaRevision;
            }
            set
            {
                fechaRevision = value;
            }
        }

        public string Resultado
        {
            get
            {
                return resultado;
            }
            set
            {
                resultado = value;
            }
        }

        public string Comentario
        {
            get
            {
                return comentario;
            }
            set
            {
                comentario = value;
            }
        }

        public RevisionTarea()
        {
            conexion = new Conexion();
        }

        public bool CrearRevisionPendiente(int idTarea)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            int filas;

            query = @"
            INSERT INTO tbRevisionTarea
            (IdTarea, IdRevisor, FechaEnvio, FechaRevision, IdResultadoRevision, Comentario)
            SELECT
            tbTarea.IdTarea,
            tbProyecto.IdResponsable,
            GETDATE(),
            NULL,
            (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Pendiente'),
            NULL
            FROM tbTarea
            INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
            WHERE tbTarea.IdTarea = @IdTarea
            AND NOT EXISTS
            (
                SELECT 1
                FROM tbRevisionTarea
                WHERE IdTarea = @IdTarea
                AND IdResultadoRevision = (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Pendiente')
            )";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            filas = 0;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdTarea", idTarea);
                filas = comando.ExecuteNonQuery();
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

            if (filas > 0)
            {
                return true;
            }

            return ExisteRevisionPendiente(idTarea);
        }

        private bool ExisteRevisionPendiente(int idTarea)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultadoConsulta;
            int cantidad;

            query = @"
            SELECT COUNT(*)
            FROM tbRevisionTarea
            WHERE IdTarea = @IdTarea
            AND IdResultadoRevision = (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Pendiente')";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            cantidad = 0;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdTarea", idTarea);
                resultadoConsulta = comando.ExecuteScalar();

                if (resultadoConsulta != null)
                {
                    cantidad = Convert.ToInt32(resultadoConsulta);
                }

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

            if (cantidad > 0)
            {
                return true;
            }

            return false;
        }

        public void PrepararRevisionesPendientesGestor(int idRevisor)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return;
            }

            try
            {
                query = @"
                UPDATE tbRevisionTarea
                SET IdRevisor = @IdRevisor
                FROM tbRevisionTarea
                INNER JOIN tbTarea ON tbRevisionTarea.IdTarea = tbTarea.IdTarea
                INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
                WHERE tbProyecto.IdResponsable = @IdRevisor
                AND tbTarea.IdEstadoTarea = (SELECT TOP 1 IdEstadoTarea FROM tbEstadoTarea WHERE Nombre = N'En revisión')
                AND tbRevisionTarea.IdResultadoRevision = (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Pendiente')";

                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdRevisor", idRevisor);
                comando.ExecuteNonQuery();
                comando.Dispose();

                query = @"
                INSERT INTO tbRevisionTarea
                (IdTarea, IdRevisor, FechaEnvio, FechaRevision, IdResultadoRevision, Comentario)
                SELECT
                tbTarea.IdTarea,
                @IdRevisor,
                GETDATE(),
                NULL,
                (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Pendiente'),
                NULL
                FROM tbTarea
                INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
                WHERE tbTarea.IdEstadoTarea = (SELECT TOP 1 IdEstadoTarea FROM tbEstadoTarea WHERE Nombre = N'En revisión')
                AND tbProyecto.IdResponsable = @IdRevisor
                AND NOT EXISTS
                (
                    SELECT 1
                    FROM tbRevisionTarea
                    WHERE tbRevisionTarea.IdTarea = tbTarea.IdTarea
                    AND tbRevisionTarea.IdResultadoRevision = (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Pendiente')
                )";

                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdRevisor", idRevisor);
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

        public DataTable ObtenerRevisionesPendientes(int idRevisor)
        {
            string query;
            DataTable revisiones;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT
            ISNULL(tbRevisionTarea.IdRevision, 0) AS IdRevision,
            tbTarea.IdTarea,
            tbTarea.Nombre AS Tarea,
            tbProyecto.Nombre AS Proyecto,
            tbUsuario.NombreCompleto AS Responsable,
            ISNULL(tbRevisionTarea.FechaEnvio, tbTarea.FechaCreacion) AS FechaEnvio,
            tbTarea.FechaLimite,
            tbPrioridad.Nombre AS Prioridad,
            tbTarea.AvanceActual,
            tbTarea.Descripcion,
            tbTarea.Observacion AS Observaciones,
            ISNULL
            (
                (
                    SELECT TOP 1 tbAvance.Descripcion
                    FROM tbAvance
                    WHERE tbAvance.IdTarea = tbTarea.IdTarea
                    ORDER BY tbAvance.IdAvance DESC
                ),
                N'Sin avances registrados'
            ) AS UltimoAvance,
            (
                SELECT COUNT(*)
                FROM tbEvidencia
                INNER JOIN tbAvance ON tbEvidencia.IdAvance = tbAvance.IdAvance
                WHERE tbAvance.IdTarea = tbTarea.IdTarea
            ) AS Evidencias
            FROM tbTarea
            INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
            INNER JOIN tbUsuario ON tbTarea.IdResponsable = tbUsuario.IdUsuario
            INNER JOIN tbPrioridad ON tbTarea.IdPrioridad = tbPrioridad.IdPrioridad
            LEFT JOIN tbRevisionTarea
            ON tbRevisionTarea.IdRevision =
            (
                SELECT TOP 1 revisionPendiente.IdRevision
                FROM tbRevisionTarea revisionPendiente
                WHERE revisionPendiente.IdTarea = tbTarea.IdTarea
                AND revisionPendiente.IdResultadoRevision = (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Pendiente')
                ORDER BY revisionPendiente.IdRevision DESC
            )
            WHERE tbProyecto.IdResponsable = @IdRevisor
            AND tbTarea.IdEstadoTarea = (SELECT TOP 1 IdEstadoTarea FROM tbEstadoTarea WHERE Nombre = N'En revisión')
            ORDER BY FechaEnvio, tbTarea.IdTarea";

            revisiones = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return revisiones;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdRevisor", idRevisor);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(revisiones);
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

            return revisiones;
        }

        public int AsegurarRevisionPendiente(int idTarea, int idRevisor)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultadoConsulta;
            int idRevision;

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return 0;
            }

            idRevision = 0;

            try
            {
                query = @"
                SELECT TOP 1 tbRevisionTarea.IdRevision
                FROM tbRevisionTarea
                INNER JOIN tbTarea ON tbRevisionTarea.IdTarea = tbTarea.IdTarea
                INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
                WHERE tbRevisionTarea.IdTarea = @IdTarea
                AND tbRevisionTarea.IdResultadoRevision = (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Pendiente')
                AND tbTarea.IdEstadoTarea = (SELECT TOP 1 IdEstadoTarea FROM tbEstadoTarea WHERE Nombre = N'En revisión')
                AND tbProyecto.IdResponsable = @IdRevisor
                ORDER BY tbRevisionTarea.IdRevision DESC";

                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdTarea", idTarea);
                comando.Parameters.AddWithValue("@IdRevisor", idRevisor);
                resultadoConsulta = comando.ExecuteScalar();
                comando.Dispose();

                if (resultadoConsulta != null)
                {
                    idRevision = Convert.ToInt32(resultadoConsulta);
                    return idRevision;
                }

                query = @"
                INSERT INTO tbRevisionTarea
                (IdTarea, IdRevisor, FechaEnvio, FechaRevision, IdResultadoRevision, Comentario)
                SELECT
                tbTarea.IdTarea,
                @IdRevisor,
                GETDATE(),
                NULL,
                (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Pendiente'),
                NULL
                FROM tbTarea
                INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
                WHERE tbTarea.IdTarea = @IdTarea
                AND tbTarea.IdEstadoTarea = (SELECT TOP 1 IdEstadoTarea FROM tbEstadoTarea WHERE Nombre = N'En revisión')
                AND tbProyecto.IdResponsable = @IdRevisor;

                SELECT SCOPE_IDENTITY();";

                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdTarea", idTarea);
                comando.Parameters.AddWithValue("@IdRevisor", idRevisor);
                resultadoConsulta = comando.ExecuteScalar();
                comando.Dispose();

                if (resultadoConsulta != null && resultadoConsulta != DBNull.Value)
                {
                    idRevision = Convert.ToInt32(resultadoConsulta);
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

            return idRevision;
        }

        public bool AprobarRevision()
        {
            SqlConnection conexionSql;
            SqlTransaction transaccion;
            SqlCommand comando;
            string query;
            object comentarioSql;
            int filasRevision;
            int filasTarea;

            comentarioSql = this.Comentario;

            if (string.IsNullOrEmpty(this.Comentario) == true || string.IsNullOrEmpty(this.Comentario.Trim()) == true)
            {
                comentarioSql = "Tarea aprobada.";
            }

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            transaccion = conexionSql.BeginTransaction();
            filasRevision = 0;
            filasTarea = 0;

            try
            {
                query = @"
                UPDATE tbRevisionTarea
                SET FechaRevision = GETDATE(),
                IdResultadoRevision = (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Aprobada'),
                Comentario = @Comentario,
                IdRevisor = @IdRevisor
                WHERE IdRevision = @IdRevision
                AND IdResultadoRevision = (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Pendiente')
                AND EXISTS
                (
                    SELECT 1
                    FROM tbTarea
                    INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
                    WHERE tbTarea.IdTarea = tbRevisionTarea.IdTarea
                    AND tbProyecto.IdResponsable = @IdRevisor
                )";

                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@Comentario", comentarioSql);
                comando.Parameters.AddWithValue("@IdRevision", this.IdRevision);
                comando.Parameters.AddWithValue("@IdRevisor", this.IdRevisor);
                filasRevision = comando.ExecuteNonQuery();
                comando.Dispose();

                if (filasRevision == 0)
                {
                    transaccion.Rollback();
                    return false;
                }

                query = @"
                UPDATE tbTarea
                SET IdEstadoTarea = (SELECT TOP 1 IdEstadoTarea FROM tbEstadoTarea WHERE Nombre = N'Completada'),
                AvanceActual = 100,
                FechaCompletada = GETDATE()
                WHERE IdTarea = @IdTarea
                AND IdEstadoTarea = (SELECT TOP 1 IdEstadoTarea FROM tbEstadoTarea WHERE Nombre = N'En revisión')
                AND EXISTS
                (
                    SELECT 1
                    FROM tbProyecto
                    WHERE tbProyecto.IdProyecto = tbTarea.IdProyecto
                    AND tbProyecto.IdResponsable = @IdRevisor
                )";

                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                comando.Parameters.AddWithValue("@IdRevisor", this.IdRevisor);
                filasTarea = comando.ExecuteNonQuery();
                comando.Dispose();

                if (filasTarea == 0)
                {
                    transaccion.Rollback();
                    return false;
                }

                query = @"
                INSERT INTO tbComentarioTarea
                (IdTarea, IdUsuario, Comentario, FechaComentario)
                VALUES
                (@IdTarea, @IdUsuario, @Comentario, GETDATE())";

                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                comando.Parameters.AddWithValue("@IdUsuario", this.IdRevisor);
                comando.Parameters.AddWithValue("@Comentario", comentarioSql);
                comando.ExecuteNonQuery();
                comando.Dispose();

                transaccion.Commit();
            }
            catch (SqlException ex)
            {
                transaccion.Rollback();
                Conexion.MostrarErrorSql(ex);
                return false;
            }
            finally
            {
                transaccion.Dispose();
                conexionSql.Close();
                conexionSql.Dispose();
            }

            return true;
        }

        public bool SolicitarCorreccion()
        {
            SqlConnection conexionSql;
            SqlTransaction transaccion;
            SqlCommand comando;
            string query;
            int filasRevision;
            int filasTarea;

            if (string.IsNullOrEmpty(this.Comentario) == true || string.IsNullOrEmpty(this.Comentario.Trim()) == true)
            {
                return false;
            }

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            transaccion = conexionSql.BeginTransaction();
            filasRevision = 0;
            filasTarea = 0;

            try
            {
                query = @"
                UPDATE tbRevisionTarea
                SET FechaRevision = GETDATE(),
                IdResultadoRevision = (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Corrección solicitada'),
                Comentario = @Comentario,
                IdRevisor = @IdRevisor
                WHERE IdRevision = @IdRevision
                AND IdResultadoRevision = (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Pendiente')
                AND EXISTS
                (
                    SELECT 1
                    FROM tbTarea
                    INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
                    WHERE tbTarea.IdTarea = tbRevisionTarea.IdTarea
                    AND tbProyecto.IdResponsable = @IdRevisor
                )";

                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@Comentario", this.Comentario.Trim());
                comando.Parameters.AddWithValue("@IdRevision", this.IdRevision);
                comando.Parameters.AddWithValue("@IdRevisor", this.IdRevisor);
                filasRevision = comando.ExecuteNonQuery();
                comando.Dispose();

                if (filasRevision == 0)
                {
                    transaccion.Rollback();
                    return false;
                }

                query = @"
                UPDATE tbTarea
                SET IdEstadoTarea = (SELECT TOP 1 IdEstadoTarea FROM tbEstadoTarea WHERE Nombre = N'Devuelta'),
                FechaCompletada = NULL
                WHERE IdTarea = @IdTarea
                AND IdEstadoTarea = (SELECT TOP 1 IdEstadoTarea FROM tbEstadoTarea WHERE Nombre = N'En revisión')
                AND EXISTS
                (
                    SELECT 1
                    FROM tbProyecto
                    WHERE tbProyecto.IdProyecto = tbTarea.IdProyecto
                    AND tbProyecto.IdResponsable = @IdRevisor
                )";

                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                comando.Parameters.AddWithValue("@IdRevisor", this.IdRevisor);
                filasTarea = comando.ExecuteNonQuery();
                comando.Dispose();

                if (filasTarea == 0)
                {
                    transaccion.Rollback();
                    return false;
                }

                query = @"
                INSERT INTO tbComentarioTarea
                (IdTarea, IdUsuario, Comentario, FechaComentario)
                VALUES
                (@IdTarea, @IdUsuario, @Comentario, GETDATE())";

                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                comando.Parameters.AddWithValue("@IdUsuario", this.IdRevisor);
                comando.Parameters.AddWithValue("@Comentario", this.Comentario.Trim());
                comando.ExecuteNonQuery();
                comando.Dispose();

                query = @"
                INSERT INTO tbNotificacion
                (IdUsuario, IdTipoNotificacion, Titulo, Mensaje, IdPrioridad, IdTarea, IdProyecto, Leida, FechaCreacion)
                SELECT
                tbTarea.IdResponsable,
                (SELECT TOP 1 IdTipoNotificacion FROM tbTipoNotificacion WHERE Nombre = N'Tarea devuelta'),
                N'Tarea devuelta para corrección',
                @Comentario,
                tbTarea.IdPrioridad,
                tbTarea.IdTarea,
                tbTarea.IdProyecto,
                0,
                GETDATE()
                FROM tbTarea
                WHERE tbTarea.IdTarea = @IdTarea";

                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@Comentario", this.Comentario.Trim());
                comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                comando.ExecuteNonQuery();
                comando.Dispose();

                transaccion.Commit();
            }
            catch (SqlException ex)
            {
                transaccion.Rollback();
                Conexion.MostrarErrorSql(ex);
                return false;
            }
            finally
            {
                transaccion.Dispose();
                conexionSql.Close();
                conexionSql.Dispose();
            }

            return true;
        }
    }
}
