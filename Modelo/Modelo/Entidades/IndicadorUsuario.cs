using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class IndicadorUsuario
    {
        private int idUsuario;
        private decimal valor;
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

        public decimal Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }

        public IndicadorUsuario()
        {
            conexion = new Conexion();
        }

        public int ContarTareasUsuarioEstado(int idUsuario, string estado)
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
            WHERE tbTarea.IdResponsable = @IdUsuario
            AND tbEstadoTarea.Nombre = @Estado";

            cantidad = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return cantidad;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@Estado", estado);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado != null)
                {
                    cantidad = Convert.ToInt32(resultado);
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

        public int ContarTareasUsuario(int idUsuario)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int cantidad;

            query = @"
            SELECT COUNT(*)
            FROM tbTarea
            WHERE IdResponsable = @IdUsuario";

            cantidad = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return cantidad;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado != null)
                {
                    cantidad = Convert.ToInt32(resultado);
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

        public int ContarTareasAbiertasUsuario(int idUsuario)
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
            WHERE tbTarea.IdResponsable = @IdUsuario
            AND tbEstadoTarea.Nombre IN (N'Pendiente', N'En progreso', N'Devuelta')";

            cantidad = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return cantidad;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado != null)
                {
                    cantidad = Convert.ToInt32(resultado);
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

        public int ContarTareasPendientesAgrupadasUsuario(int idUsuario)
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
            WHERE tbTarea.IdResponsable = @IdUsuario
            AND tbEstadoTarea.Nombre IN (N'Pendiente', N'Devuelta', N'Vencida')";

            cantidad = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return cantidad;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado != null)
                {
                    cantidad = Convert.ToInt32(resultado);
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

        public int ContarTareasQueVencenSemanaUsuario(int idUsuario)
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
            WHERE tbTarea.IdResponsable = @IdUsuario
            AND tbTarea.FechaLimite >= CAST(GETDATE() AS DATE)
            AND tbTarea.FechaLimite <= DATEADD(DAY, 7, CAST(GETDATE() AS DATE))
            AND tbEstadoTarea.Nombre NOT IN (N'Completada', N'En revisión')";

            cantidad = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return cantidad;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado != null)
                {
                    cantidad = Convert.ToInt32(resultado);
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

        public decimal ObtenerAvancePromedioUsuario(int idUsuario)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            decimal cantidad;

            query = @"
            SELECT ISNULL(AVG(AvanceActual), 0)
            FROM tbTarea
            WHERE IdResponsable = @IdUsuario";

            cantidad = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return cantidad;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado != null)
                {
                    cantidad = Convert.ToDecimal(resultado);
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
    }
}
