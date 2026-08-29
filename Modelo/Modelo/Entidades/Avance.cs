using System;
using System.Data;
using Modelo.Modelo;
using System.Data.SqlClient;

namespace Modelo.Modelo.Entidades
{
    public class Avance
    {
        private int idAvance;
        private int idTarea;
        private int idUsuario;
        private decimal porcentaje;
        private DateTime fechaRegistro;
        private string descripcion;
        private string dificultades;
        private string proximosPasos;
        private Conexion conexion;

        public int IdAvance
        {
            get
            {
                return idAvance;
            }
            set
            {
                idAvance = value;
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

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }
            set
            {
                idUsuario = value;
            }
        }

        public decimal Porcentaje
        {
            get
            {
                return porcentaje;
            }
            set
            {
                porcentaje = value;
            }
        }

        public DateTime FechaRegistro
        {
            get
            {
                return fechaRegistro;
            }
            set
            {
                fechaRegistro = value;
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

        public string Dificultades
        {
            get
            {
                return dificultades;
            }
            set
            {
                dificultades = value;
            }
        }

        public string ProximosPasos
        {
            get
            {
                return proximosPasos;
            }
            set
            {
                proximosPasos = value;
            }
        }

        public Avance()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerAvancesRecientes(int cantidad)
        {
            string query;
            DataTable avances;

            if (cantidad < 1)
            {
                cantidad = 5;
            }

            query = $@"
            SELECT TOP {cantidad}
            tbAvance.IdAvance,
            tbTarea.Nombre AS Tarea,
            tbProyecto.Nombre AS Proyecto,
            tbUsuario.NombreCompleto AS Usuario,
            tbAvance.Porcentaje,
            tbAvance.FechaRegistro,
            tbAvance.Descripcion
            FROM tbAvance
            INNER JOIN tbTarea ON tbAvance.IdTarea = tbTarea.IdTarea
            INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
            INNER JOIN tbUsuario ON tbAvance.IdUsuario = tbUsuario.IdUsuario
            ORDER BY tbAvance.IdAvance DESC";

            avances = conexion.EjecutarConsulta(query);
            return avances;
        }

        public DataTable ObtenerAvancesUsuario(int idUsuario, int dias, int cantidad)
        {
            string query;
            DataTable avances;

            query = $@"
            SELECT TOP {cantidad}
            tbAvance.FechaRegistro,
            tbTarea.Nombre AS Tarea,
            tbProyecto.Nombre AS Proyecto,
            tbAvance.Porcentaje,
            tbAvance.Descripcion
            FROM tbAvance
            INNER JOIN tbTarea ON tbAvance.IdTarea = tbTarea.IdTarea
            INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
            WHERE tbAvance.IdUsuario = {idUsuario}
            AND tbAvance.FechaRegistro >= DATEADD(DAY, -{dias}, CAST(GETDATE() AS DATE))
            ORDER BY tbAvance.FechaRegistro DESC, tbAvance.IdAvance DESC";

            avances = conexion.EjecutarConsulta(query);
            return avances;
        }

        public int RegistrarAvance()
        {
            string query;
            SqlConnection conexionSql;
            SqlTransaction transaccion;
            SqlCommand comando;
            SqlDataReader lector;
            object dificultades;
            object proximosPasos;
            object resultado;
            object estadoResultado;
            int idAvance;
            string estadoActual;
            string nuevoEstado;
            string nombreTarea;
            int idProyectoNotificacion;
            int idGestorNotificacion;
            int idPrioridadNotificacion;

            dificultades = this.Dificultades;
            proximosPasos = this.ProximosPasos;

            if (string.IsNullOrEmpty(this.Dificultades) == true || string.IsNullOrEmpty(this.Dificultades.Trim()) == true)
            {
                dificultades = DBNull.Value;
            }

            if (string.IsNullOrEmpty(this.ProximosPasos) == true || string.IsNullOrEmpty(this.ProximosPasos.Trim()) == true)
            {
                proximosPasos = DBNull.Value;
            }

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return 0;
            }

            transaccion = conexionSql.BeginTransaction();
            idAvance = 0;
            estadoActual = "";
            nombreTarea = "";
            idProyectoNotificacion = 0;
            idGestorNotificacion = 0;
            idPrioridadNotificacion = 0;

            try
            {
                query = @"
                INSERT INTO tbAvance
                (IdTarea, IdUsuario, Porcentaje, FechaRegistro, Descripcion, Dificultad, ProximoPaso)
                VALUES
                (@IdTarea, @IdUsuario, @Porcentaje, @FechaRegistro, @Descripcion, @Dificultad, @ProximoPaso);
                SELECT SCOPE_IDENTITY();";

                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                comando.Parameters.AddWithValue("@IdUsuario", this.IdUsuario);
                comando.Parameters.AddWithValue("@Porcentaje", this.Porcentaje);
                comando.Parameters.AddWithValue("@FechaRegistro", this.FechaRegistro.Date);
                comando.Parameters.AddWithValue("@Descripcion", this.Descripcion);
                comando.Parameters.AddWithValue("@Dificultad", dificultades);
                comando.Parameters.AddWithValue("@ProximoPaso", proximosPasos);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado != null)
                {
                    idAvance = Convert.ToInt32(resultado);
                }

                if (idAvance == 0)
                {
                    transaccion.Rollback();
                    return 0;
                }

                query = @"
                SELECT tbEstadoTarea.Nombre
                FROM tbTarea
                INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
                WHERE tbTarea.IdTarea = @IdTarea";

                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                estadoResultado = comando.ExecuteScalar();
                comando.Dispose();

                if (estadoResultado != null)
                {
                    estadoActual = estadoResultado.ToString();
                }

                nuevoEstado = "En progreso";

                if (this.Porcentaje >= 100)
                {
                    nuevoEstado = "En revisión";
                }
                else if (estadoActual == "Vencida")
                {
                    nuevoEstado = "Vencida";
                }

                query = @"
                UPDATE tbTarea
                SET AvanceActual = @Porcentaje,
                IdEstadoTarea = (SELECT TOP 1 IdEstadoTarea FROM tbEstadoTarea WHERE Nombre = @Estado)
                WHERE IdTarea = @IdTarea";

                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@Porcentaje", this.Porcentaje);
                comando.Parameters.AddWithValue("@Estado", nuevoEstado);
                comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);

                if (comando.ExecuteNonQuery() == 0)
                {
                    comando.Dispose();
                    transaccion.Rollback();
                    return 0;
                }

                comando.Dispose();

                if (nuevoEstado == "En revisión")
                {
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
                        WHERE tbRevisionTarea.IdTarea = @IdTarea
                        AND tbRevisionTarea.IdResultadoRevision = (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Pendiente')
                    )";

                    comando = new SqlCommand(query, conexionSql, transaccion);
                    comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                    comando.ExecuteNonQuery();
                    comando.Dispose();

                    query = @"
                    UPDATE tbRevisionTarea
                    SET IdRevisor = tbProyecto.IdResponsable
                    FROM tbRevisionTarea
                    INNER JOIN tbTarea ON tbRevisionTarea.IdTarea = tbTarea.IdTarea
                    INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
                    WHERE tbRevisionTarea.IdTarea = @IdTarea
                    AND tbRevisionTarea.IdResultadoRevision = (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Pendiente')";

                    comando = new SqlCommand(query, conexionSql, transaccion);
                    comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                    comando.ExecuteNonQuery();
                    comando.Dispose();

                    query = @"
                    SELECT COUNT(*)
                    FROM tbRevisionTarea
                    WHERE IdTarea = @IdTarea
                    AND IdResultadoRevision = (SELECT TOP 1 IdResultadoRevision FROM tbEstadoRevision WHERE Nombre = N'Pendiente')";

                    comando = new SqlCommand(query, conexionSql, transaccion);
                    comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                    resultado = comando.ExecuteScalar();
                    comando.Dispose();

                    if (resultado == null || Convert.ToInt32(resultado) == 0)
                    {
                        transaccion.Rollback();
                        return 0;
                    }

                    query = @"
                    SELECT tbTarea.Nombre,
                    tbTarea.IdProyecto,
                    tbProyecto.IdResponsable,
                    tbTarea.IdPrioridad
                    FROM tbTarea
                    INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
                    WHERE tbTarea.IdTarea = @IdTarea";

                    comando = new SqlCommand(query, conexionSql, transaccion);
                    comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                    lector = comando.ExecuteReader();

                    if (lector.Read() == true)
                    {
                        nombreTarea = lector["Nombre"].ToString();
                        idProyectoNotificacion = Convert.ToInt32(lector["IdProyecto"]);
                        idGestorNotificacion = Convert.ToInt32(lector["IdResponsable"]);
                        idPrioridadNotificacion = Convert.ToInt32(lector["IdPrioridad"]);
                    }

                    lector.Close();
                    lector.Dispose();
                    comando.Dispose();

                    if (idGestorNotificacion > 0)
                    {
                        query = @"
                        INSERT INTO tbNotificacion
                        (IdUsuario, IdTipoNotificacion, Titulo, Mensaje, IdPrioridad, IdTarea, IdProyecto, Leida, FechaCreacion)
                        VALUES
                        (@IdUsuario,
                        (SELECT TOP 1 IdTipoNotificacion FROM tbTipoNotificacion WHERE Nombre = N'Alerta proyecto'),
                        @Titulo,
                        @Mensaje,
                        @IdPrioridad,
                        @IdTarea,
                        @IdProyecto,
                        0,
                        GETDATE())";

                        comando = new SqlCommand(query, conexionSql, transaccion);
                        comando.Parameters.AddWithValue("@IdUsuario", idGestorNotificacion);
                        comando.Parameters.AddWithValue("@Titulo", "Tarea enviada a revisión");
                        comando.Parameters.AddWithValue("@Mensaje", "La tarea " + nombreTarea + " fue enviada a revisión.");
                        comando.Parameters.AddWithValue("@IdPrioridad", idPrioridadNotificacion);
                        comando.Parameters.AddWithValue("@IdTarea", this.IdTarea);
                        comando.Parameters.AddWithValue("@IdProyecto", idProyectoNotificacion);
                        comando.ExecuteNonQuery();
                        comando.Dispose();
                    }
                }

                transaccion.Commit();
            }
            catch (SqlException ex)
            {
                transaccion.Rollback();
                Conexion.MostrarErrorSql(ex);
                return 0;
            }
            finally
            {
                transaccion.Dispose();
                conexionSql.Close();
                conexionSql.Dispose();
            }

            return idAvance;
        }

        public DataTable ObtenerHistorialTarea(int idTarea)
        {
            string query = $@"
            SELECT IdAvance, Porcentaje, FechaRegistro, Descripcion
            FROM tbAvance
            WHERE IdTarea = {idTarea}
            ORDER BY IdAvance";

            DataTable historial = conexion.EjecutarConsulta(query);
            return historial;
        }
    }
}
