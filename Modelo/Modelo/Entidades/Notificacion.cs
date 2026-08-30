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
            DataTable notificaciones;

            notificaciones = ObtenerNotificacionesUsuario(idUsuario);
            return LimitarNotificaciones(notificaciones, cantidad, false);
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
            ORDER BY tbNotificacion.IdNotificacion DESC";

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
    }
}
