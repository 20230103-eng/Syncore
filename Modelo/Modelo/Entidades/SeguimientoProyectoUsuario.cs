using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class SeguimientoProyectoUsuario
    {
        private int idUsuario;
        private int idProyecto;
        private decimal avance;
        private Conexion conexion;

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

        public decimal Avance
        {
            get
            {
                return avance;
            }
            set
            {
                avance = value;
            }
        }

        public SeguimientoProyectoUsuario()
        {
            conexion = new Conexion();
        }

        public int ContarTareasUsuarioProyecto(int idUsuario, int idProyecto)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int valor;

            query = @"
            SELECT COUNT(*)
            FROM tbTarea
            WHERE IdResponsable = @IdUsuario
            AND IdProyecto = @IdProyecto";

            valor = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return valor;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado != null && resultado != DBNull.Value)
                {
                    valor = Convert.ToInt32(resultado);
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

            return valor;
        }

        public int ContarTareasVencidasUsuarioProyecto(int idUsuario, int idProyecto)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int valor;

            query = @"
            SELECT COUNT(*)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = @IdUsuario
            AND tbTarea.IdProyecto = @IdProyecto
            AND tbEstadoTarea.Nombre = N'Vencida' ";

            valor = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return valor;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado != null && resultado != DBNull.Value)
                {
                    valor = Convert.ToInt32(resultado);
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

            return valor;
        }

        public DateTime? ObtenerProximaFechaUsuarioProyecto(int idUsuario, int idProyecto)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            DateTime? fecha;

            query = @"
            SELECT MIN(FechaLimite)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = @IdUsuario
            AND tbTarea.IdProyecto = @IdProyecto
            AND tbEstadoTarea.Nombre <> N'Completada'";

            fecha = null;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return fecha;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado != null && resultado != DBNull.Value)
                {
                    fecha = Convert.ToDateTime(resultado);
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

            return fecha;
        }

        public decimal ObtenerAvanceUsuarioProyecto(int idUsuario, int idProyecto)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            decimal valor;

            query = @"
            SELECT ISNULL(AVG(AvanceActual), 0)
            FROM tbTarea
            WHERE IdResponsable = @IdUsuario
            AND IdProyecto = @IdProyecto";

            valor = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return valor;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado != null && resultado != DBNull.Value)
                {
                    valor = Convert.ToDecimal(resultado);
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

            return valor;
        }
    }
}
