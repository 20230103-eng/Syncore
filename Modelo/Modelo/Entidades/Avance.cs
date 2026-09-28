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

        public DataTable ObtenerAvancesRecientes(int cantidad, int idGestor)
        {
            string query;
            DataTable avances;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            if (cantidad < 1)
            {
                cantidad = 5;
            }

            query = @"
            SELECT TOP (@Cantidad)
            tbAvance.IdAvance,
            tbAvance.IdTarea,
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
            WHERE tbProyecto.IdResponsable = @IdGestor
            ORDER BY tbAvance.IdAvance DESC";

            avances = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return avances;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@Cantidad", cantidad);
                comando.Parameters.AddWithValue("@IdGestor", idGestor);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(avances);
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

            return avances;
        }

        public DataTable ObtenerAvancesUsuario(int idUsuario, int dias, int cantidad)
        {
            string query;
            DataTable avances;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT TOP (@Cantidad)
            tbAvance.FechaRegistro,
            tbTarea.Nombre AS Tarea,
            tbProyecto.Nombre AS Proyecto,
            tbAvance.Porcentaje,
            tbAvance.Descripcion
            FROM tbAvance
            INNER JOIN tbTarea ON tbAvance.IdTarea = tbTarea.IdTarea
            INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
            WHERE tbAvance.IdUsuario = @IdUsuario
            AND tbAvance.FechaRegistro >= DATEADD(DAY, -@Dias, CAST(GETDATE() AS DATE))
            ORDER BY tbAvance.FechaRegistro DESC, tbAvance.IdAvance DESC";

            avances = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return avances;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@Cantidad", cantidad);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@Dias", dias);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(avances);
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

            transaccion = null;
            idAvance = 0;
            estadoActual = "";
            nombreTarea = "";
            idProyectoNotificacion = 0;
            idGestorNotificacion = 0;
            idPrioridadNotificacion = 0;

            try
            {
                transaccion = conexionSql.BeginTransaction();
                query = @"
                INSERT INTO tbAvance
                (IdTarea, IdUsuario, Porcentaje, FechaRegistro, Descripcion, Dificultad, ProximoPaso)
                SELECT @IdTarea, @IdUsuario, @Porcentaje, @FechaRegistro, @Descripcion, @Dificultad, @ProximoPaso
                FROM tbTarea WITH (UPDLOCK, HOLDLOCK)
                INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
                INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
                INNER JOIN tbEstadoProyecto ON tbProyecto.IdEstadoProyecto = tbEstadoProyecto.IdEstadoProyecto
                INNER JOIN tbUsuario ON tbTarea.IdResponsable = tbUsuario.IdUsuario
                INNER JOIN tbTipoUsuario ON tbUsuario.IdTipoUsuario = tbTipoUsuario.IdTipoUsuario
                INNER JOIN tbEquipoProyecto ON tbTarea.IdProyecto = tbEquipoProyecto.IdProyecto
                    AND tbEquipoProyecto.IdUsuario = tbUsuario.IdUsuario
                WHERE tbTarea.IdTarea = @IdTarea
                AND tbTarea.IdResponsable = @IdUsuario
                AND tbEstadoTarea.Nombre IN (N'Pendiente', N'En progreso', N'Devuelta', N'Vencida')
                AND tbEstadoProyecto.Nombre <> N'Cerrado'
                AND tbUsuario.Activo = 1
                AND tbTipoUsuario.Nombre = N'Colaborador'
                AND tbEquipoProyecto.Activo = 1;
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
                if (transaccion != null && transaccion.Connection != null)
                {
                    try
                    {
                        transaccion.Rollback();
                    }
                    catch (SqlException)
                    {
                    }
                }
                Conexion.MostrarErrorSql(ex);
                return 0;
            }
            finally
            {
                if (transaccion != null)
                {
                    transaccion.Dispose();
                }
                conexionSql.Close();
                conexionSql.Dispose();
            }

            return idAvance;
        }

        public DataTable ObtenerHistorialTarea(int idTarea)
        {
            string query;
            DataTable historial;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT IdAvance, Porcentaje, FechaRegistro, Descripcion
            FROM tbAvance
            WHERE IdTarea = @IdTarea
            ORDER BY IdAvance";

            historial = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return historial;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdTarea", idTarea);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(historial);
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

            return historial;
        }
        public DataTable ObtenerHistorialTareaPagina(int idTarea, int pagina, int tamanoPagina, out int total)
        {
            string consulta = @"
                SELECT a.IdAvance, a.Porcentaje, a.FechaRegistro, a.Descripcion,
                    (SELECT COUNT(*) FROM tbEvidencia e WHERE e.IdAvance = a.IdAvance) AS CantidadEvidencias,
                    COUNT(*) OVER() AS TotalRegistros
                FROM tbAvance a
                WHERE a.IdTarea = @IdTarea
                ORDER BY a.IdAvance DESC
                OFFSET @Inicio ROWS FETCH NEXT @Tamano ROWS ONLY";
            SqlParameter[] parametros = { new SqlParameter("@IdTarea", idTarea) };
            return new Conexion().EjecutarPaginaTamano(consulta, parametros, pagina, tamanoPagina, out total);
        }

        public DataTable ObtenerAvancesRecientesPagina(int idGestor, int pagina, int tamanoPagina, out int total)
        {
            string consulta = @"
                SELECT a.IdAvance, a.IdTarea, t.Nombre AS Tarea,
                    p.Nombre AS Proyecto, u.NombreCompleto AS Usuario,
                    a.Porcentaje, a.FechaRegistro, a.Descripcion,
                    COUNT(*) OVER() AS TotalRegistros
                FROM tbAvance a
                INNER JOIN tbTarea t ON t.IdTarea = a.IdTarea
                INNER JOIN tbProyecto p ON p.IdProyecto = t.IdProyecto
                INNER JOIN tbUsuario u ON u.IdUsuario = a.IdUsuario
                WHERE p.IdResponsable = @IdGestor
                ORDER BY a.IdAvance DESC
                OFFSET @Inicio ROWS FETCH NEXT @Tamano ROWS ONLY";
            SqlParameter[] parametros = { new SqlParameter("@IdGestor", idGestor) };
            return new Conexion().EjecutarPaginaTamano(consulta, parametros, pagina, tamanoPagina, out total);
        }

        public DataTable ObtenerAvancesUsuarioPagina(int idUsuario, int dias,
            int pagina, int tamanoPagina, out int total)
        {
            string consulta = @"
                SELECT a.FechaRegistro, t.Nombre AS Tarea, p.Nombre AS Proyecto,
                    a.Porcentaje, a.Descripcion, COUNT(*) OVER() AS TotalRegistros
                FROM tbAvance a
                INNER JOIN tbTarea t ON t.IdTarea = a.IdTarea
                INNER JOIN tbProyecto p ON p.IdProyecto = t.IdProyecto
                WHERE a.IdUsuario = @IdUsuario
                    AND a.FechaRegistro >= DATEADD(DAY, -@Dias, CAST(GETDATE() AS DATE))
                ORDER BY a.IdAvance DESC
                OFFSET @Inicio ROWS FETCH NEXT @Tamano ROWS ONLY";
            SqlParameter[] parametros = {
                new SqlParameter("@IdUsuario", idUsuario), new SqlParameter("@Dias", dias)
            };
            return new Conexion().EjecutarPaginaTamano(consulta, parametros, pagina, tamanoPagina, out total);
        }

    }
}
