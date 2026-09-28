using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class Notificacion
    {
        private int idNotificacion;
        private int idUsuario;
        private string tipo;
        private string titulo;
        private string mensaje;
        private string prioridad;
        private int? idTarea;
        private int? idProyecto;
        private bool leida;
        private DateTime fechaCreacion;
        private Conexion conexion;

        public int IdNotificacion
        {
            get { return idNotificacion; }
            set { idNotificacion = value; }
        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        public string Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }

        public int? IdTarea
        {
            get { return idTarea; }
            set { idTarea = value; }
        }

        public int? IdProyecto
        {
            get { return idProyecto; }
            set { idProyecto = value; }
        }

        public bool Leida
        {
            get { return leida; }
            set { leida = value; }
        }

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }

        public Notificacion()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerNotificacionesNoLeidas(int idUsuario, int cantidad)
        {
            DataTable notificaciones;

            notificaciones = ObtenerNotificacionesUsuario(idUsuario);
            return LimitarNotificaciones(notificaciones, cantidad, true);
        }

        public DataTable ObtenerNotificacionesRecientes(int idUsuario, int cantidad)
        {
            if (cantidad < 1)
            {
                cantidad = 3;
            }
            string consulta = @"
                SELECT TOP (@Cantidad) n.IdNotificacion, tipo.Nombre AS Tipo,
                    n.Titulo, n.Mensaje, prioridad.Nombre AS Prioridad,
                    n.IdTarea, n.IdProyecto, n.Leida, n.FechaCreacion
                FROM tbNotificacion n
                INNER JOIN tbTipoNotificacion tipo ON tipo.IdTipoNotificacion = n.IdTipoNotificacion
                INNER JOIN tbPrioridad prioridad ON prioridad.IdPrioridad = n.IdPrioridad
                WHERE n.IdUsuario = @IdUsuario
                ORDER BY n.Leida, n.IdNotificacion DESC";
            DataTable notificaciones = new DataTable();
            SqlConnection conexionSql = Conexion.conectar();
            if (conexionSql == null)
            {
                return notificaciones;
            }
            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexionSql))
                {
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@Cantidad", cantidad);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(notificaciones);
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
            return notificaciones;
        }

        public DataTable ObtenerNotificacionesRecientesPagina(int idUsuario, int pagina, int tamanoPagina, out int total)
        {
            string consulta = @"
                SELECT n.IdNotificacion, tipo.Nombre AS Tipo,
                    n.Titulo, n.Mensaje, prioridad.Nombre AS Prioridad,
                    n.IdTarea, n.IdProyecto, n.Leida, n.FechaCreacion,
                    COUNT(*) OVER() AS TotalRegistros
                FROM tbNotificacion n
                INNER JOIN tbTipoNotificacion tipo ON tipo.IdTipoNotificacion = n.IdTipoNotificacion
                INNER JOIN tbPrioridad prioridad ON prioridad.IdPrioridad = n.IdPrioridad
                WHERE n.IdUsuario = @IdUsuario
                ORDER BY n.Leida, n.IdNotificacion DESC
                OFFSET @Inicio ROWS FETCH NEXT @Tamano ROWS ONLY";
            SqlParameter[] parametros = { new SqlParameter("@IdUsuario", idUsuario) };
            return new Conexion().EjecutarPaginaTamano(consulta, parametros, pagina, tamanoPagina, out total);
        }

        public DataTable ObtenerNotificacionesUsuario(int idUsuario)
        {
            string query;
            DataTable notificaciones;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT
            tbNotificacion.IdNotificacion,
            tbTipoNotificacion.Nombre AS Tipo,
            tbNotificacion.Titulo,
            tbNotificacion.Mensaje,
            tbPrioridad.Nombre AS Prioridad,
            tbNotificacion.IdTarea,
            tbNotificacion.IdProyecto,
            tbNotificacion.Leida,
            tbNotificacion.FechaCreacion
            FROM tbNotificacion
            INNER JOIN tbTipoNotificacion ON tbNotificacion.IdTipoNotificacion = tbTipoNotificacion.IdTipoNotificacion
            INNER JOIN tbPrioridad ON tbNotificacion.IdPrioridad = tbPrioridad.IdPrioridad
            WHERE tbNotificacion.IdUsuario = @IdUsuario
            AND
            (
                tbNotificacion.Leida = 0
                OR tbNotificacion.IdNotificacion IN
                (
                    SELECT TOP (@CantidadLeidas) IdNotificacion
                    FROM tbNotificacion
                    WHERE IdUsuario = @IdUsuario
                    AND Leida = 1
                    ORDER BY IdNotificacion DESC
                )
            )
            ORDER BY tbNotificacion.Leida, tbNotificacion.IdNotificacion DESC";

            notificaciones = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return notificaciones;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@CantidadLeidas", 30);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(notificaciones);
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

            return notificaciones;
        }

        public bool EliminarLeidasAntiguas(int idUsuario, int dias)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            bool eliminadas;

            query = @"
            DELETE FROM tbNotificacion
            WHERE IdUsuario = @IdUsuario
            AND Leida = 1
            AND FechaCreacion < DATEADD(DAY, -@Dias, GETDATE())";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            eliminadas = false;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@Dias", dias);
                comando.ExecuteNonQuery();
                comando.Dispose();
                eliminadas = true;
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

            return eliminadas;
        }

        public int ContarNotificacionesNoLeidas(int idUsuario)
        {
            string query;
            DataTable datos;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;
            int cantidad;

            query = @"
            SELECT COUNT(*)
            FROM tbNotificacion
            WHERE IdUsuario = @IdUsuario
            AND Leida = 0";

            datos = new DataTable();
            conexionSql = Conexion.conectar();
            cantidad = 0;

            if (conexionSql == null)
            {
                return cantidad;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(datos);
                adaptador.Dispose();
                comando.Dispose();

                if (datos.Rows.Count > 0)
                {
                    cantidad = Convert.ToInt32(datos.Rows[0][0]);
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

            return cantidad;
        }

        public bool MarcarLeida()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            bool actualizada;

            query = @"
            UPDATE tbNotificacion
            SET Leida = 1
            WHERE IdNotificacion = @IdNotificacion";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            actualizada = false;

            try
            {
                int filasAfectadas;

                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdNotificacion", this.IdNotificacion);
                filasAfectadas = comando.ExecuteNonQuery();
                comando.Dispose();

                if (filasAfectadas > 0)
                {
                    actualizada = true;
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

            return actualizada;
        }

        public bool MarcarTodasLeidas(int idUsuario)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            bool actualizadas;

            query = @"
            UPDATE tbNotificacion
            SET Leida = 1
            WHERE IdUsuario = @IdUsuario
            AND Leida = 0";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            actualizadas = false;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.ExecuteNonQuery();
                comando.Dispose();
                actualizadas = true;
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

            return actualizadas;
        }

        public DataTable ObtenerAlertasProyecto(int idProyecto, int cantidad)
        {
            string query;
            DataTable alertas;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            if (cantidad < 1)
            {
                cantidad = 4;
            }

            query = @"
            SELECT TOP (@Cantidad)
            tbNotificacion.IdNotificacion,
            tbTipoNotificacion.Nombre AS Tipo,
            tbNotificacion.Titulo,
            tbNotificacion.Mensaje,
            tbPrioridad.Nombre AS Prioridad,
            tbNotificacion.FechaCreacion
            FROM tbNotificacion
            INNER JOIN tbTipoNotificacion ON tbNotificacion.IdTipoNotificacion = tbTipoNotificacion.IdTipoNotificacion
            INNER JOIN tbPrioridad ON tbNotificacion.IdPrioridad = tbPrioridad.IdPrioridad
            WHERE tbNotificacion.IdProyecto = @IdProyecto
            AND Leida = 0
            ORDER BY IdNotificacion DESC";

            alertas = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return alertas;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@Cantidad", cantidad);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(alertas);
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

            return alertas;
        }

        public DataTable ObtenerAlertasProyectoPagina(int idProyecto, int pagina, int tamanoPagina, out int total)
        {
            string consulta = @"
                SELECT tbNotificacion.IdNotificacion,
                    tbTipoNotificacion.Nombre AS Tipo,
                    tbNotificacion.Titulo, tbNotificacion.Mensaje,
                    tbPrioridad.Nombre AS Prioridad, tbNotificacion.FechaCreacion,
                    COUNT(*) OVER() AS TotalRegistros
                FROM tbNotificacion
                INNER JOIN tbTipoNotificacion ON tbNotificacion.IdTipoNotificacion = tbTipoNotificacion.IdTipoNotificacion
                INNER JOIN tbPrioridad ON tbNotificacion.IdPrioridad = tbPrioridad.IdPrioridad
                WHERE tbNotificacion.IdProyecto = @IdProyecto
                AND Leida = 0
                ORDER BY tbNotificacion.IdNotificacion DESC
                OFFSET @Inicio ROWS FETCH NEXT @Tamano ROWS ONLY";
            SqlParameter[] parametros = { new SqlParameter("@IdProyecto", idProyecto) };
            return new Conexion().EjecutarPaginaTamano(consulta, parametros, pagina, tamanoPagina, out total);
        }

        private DataTable LimitarNotificaciones(DataTable origen, int cantidad, bool soloNoLeidas)
        {
            DataTable resultado;
            int contador;

            if (cantidad < 1)
            {
                cantidad = 5;
            }

            resultado = origen.Clone();
            contador = 0;

            foreach (DataRow fila in origen.Rows)
            {
                bool leidaFila;

                leidaFila = Convert.ToBoolean(fila["Leida"]);

                if (soloNoLeidas == true && leidaFila == true)
                {
                    continue;
                }

                resultado.ImportRow(fila);
                contador = contador + 1;

                if (contador >= cantidad)
                {
                    break;
                }
            }

            return resultado;
        }
        public DataTable ObtenerCatalogoNotificacionesUsuario(int idUsuario)
        {
            DataTable catalogo = new DataTable();
            SqlConnection conexionSql = Conexion.conectar();
            if (conexionSql == null)
            {
                return catalogo;
            }
            string query = @"
                SELECT DISTINCT tn.Nombre AS Tipo, pr.Nombre AS Prioridad
                FROM tbNotificacion n
                INNER JOIN tbTipoNotificacion tn ON tn.IdTipoNotificacion = n.IdTipoNotificacion
                INNER JOIN tbPrioridad pr ON pr.IdPrioridad = n.IdPrioridad
                WHERE n.IdUsuario = @IdUsuario
                    AND (n.Leida = 0 OR n.IdNotificacion IN
                        (SELECT TOP 30 IdNotificacion FROM tbNotificacion
                         WHERE IdUsuario = @IdUsuario AND Leida = 1
                         ORDER BY IdNotificacion DESC))";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, conexionSql))
                {
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(catalogo);
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
            return catalogo;
        }

        public DataTable ObtenerNotificacionesUsuarioPagina(int idUsuario, string tipo,
            string prioridad, int pagina)
        {
            DataTable notificaciones = new DataTable();
            SqlConnection conexionSql = Conexion.conectar();
            if (conexionSql == null)
            {
                return notificaciones;
            }
            string query = @"
                WITH Recortadas AS
                (
                    SELECT n.IdNotificacion, tn.Nombre AS Tipo, n.Titulo, n.Mensaje,
                        pr.Nombre AS Prioridad, n.IdTarea, n.IdProyecto,
                        n.Leida, n.FechaCreacion
                    FROM tbNotificacion n
                    INNER JOIN tbTipoNotificacion tn ON tn.IdTipoNotificacion = n.IdTipoNotificacion
                    INNER JOIN tbPrioridad pr ON pr.IdPrioridad = n.IdPrioridad
                    WHERE n.IdUsuario = @IdUsuario
                        AND (n.Leida = 0 OR n.IdNotificacion IN
                            (SELECT TOP 30 IdNotificacion FROM tbNotificacion
                             WHERE IdUsuario = @IdUsuario AND Leida = 1
                             ORDER BY IdNotificacion DESC))
                )
                SELECT *, COUNT(*) OVER() AS TotalRegistros
                FROM Recortadas
                WHERE (@Tipo = N'' OR Tipo = @Tipo)
                    AND (@Prioridad = N'' OR Prioridad = @Prioridad)
                ORDER BY Leida ASC, IdNotificacion DESC
                OFFSET @Inicio ROWS FETCH NEXT 20 ROWS ONLY";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, conexionSql))
                {
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@Tipo", tipo);
                    comando.Parameters.AddWithValue("@Prioridad", prioridad);
                    comando.Parameters.AddWithValue("@Inicio", Math.Max(0, pagina) * 20);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(notificaciones);
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
            return notificaciones;
        }

    }
}
