using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Modelo.Modelo
{
    public class Conexion
    {
        private static string servidor = @".\MSSQLSERVER01";
        private static string baseDeDatos = "DbSyncore";

        public static SqlConnection conectar()
        {
            string cadena;
            SqlConnection conexion;

            cadena = $"Data Source={servidor};Initial Catalog={baseDeDatos};Integrated Security=true;";
            conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();
                return conexion;
            }
            catch (SqlException ex)
            {
                conexion.Dispose();
                MostrarErrorSql(ex);
                return null;
            }
        }

        public static void MostrarErrorSql(SqlException ex)
        {
            if (ex.Number == 2 || ex.Number == 26 || ex.Number == 53)
            {
                MessageBox.Show("No se pudo encontrar el servidor de base de datos.", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ex.Number == 4060)
            {
                MessageBox.Show("No se pudo encontrar la base de datos.", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ex.Number == 18456)
            {
                MessageBox.Show("No se pudo iniciar sesión en la base de datos.", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ex.Number == 2601 || ex.Number == 2627)
            {
                MessageBox.Show("Ya existe un registro con esos datos.", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ex.Number == 547)
            {
                MessageBox.Show("No se puede completar la operación porque existen datos relacionados.", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ex.Number == 515)
            {
                MessageBox.Show("Falta información obligatoria para guardar el registro.", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al trabajar con la base de datos.", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable EjecutarConsulta(string consulta)
        {
            DataTable tabla;
            SqlConnection conexion;
            SqlDataAdapter adaptador;

            tabla = new DataTable();
            conexion = conectar();

            if (conexion == null)
            {
                return tabla;
            }

            try
            {
                adaptador = new SqlDataAdapter(consulta, conexion);
                adaptador.Fill(tabla);
                adaptador.Dispose();
            }
            catch (SqlException ex)
            {
                MostrarErrorSql(ex);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }

            return tabla;
        }

        public bool EjecutarComando(string consulta)
        {
            SqlConnection conexion;
            SqlCommand comando;

            conexion = conectar();

            if (conexion == null)
            {
                return false;
            }

            try
            {
                comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                comando.Dispose();
                return true;
            }
            catch (SqlException ex)
            {
                MostrarErrorSql(ex);
                return false;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
        }

        public object EjecutarEscalar(string consulta)
        {
            SqlConnection conexion;
            SqlCommand comando;
            object resultado;

            conexion = conectar();

            if (conexion == null)
            {
                return null;
            }

            try
            {
                comando = new SqlCommand(consulta, conexion);
                resultado = comando.ExecuteScalar();
                comando.Dispose();
                return resultado;
            }
            catch (SqlException ex)
            {
                MostrarErrorSql(ex);
                return null;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
        }
    }
}
