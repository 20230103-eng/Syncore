using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Modelo.Modelo
{
    public class Conexion
    {
        // ponemos el nombre de nuestra base de datos y el nombre de el servidor donde se encuentra
        private static string servidor = @".\MSSQLSERVER01";
        private static string baseDeDatos = "DbSyncore";

        // definimos el metodo para conectarnos a la base de datos de el servidor, definimos el metodo conectar para conectarnos a la base de datos y devolver la conexion con la cual se van a poder realizar consultas
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
            string codigo;
            string mensaje;
            MessageBoxIcon icono;

            // aca si no encuentra el servidor donde esta la base de datos
            if (ex.Number == 2 || ex.Number == 26 || ex.Number == 53)
            {
                codigo = "ERR-SQL-001";
                mensaje = "No se pudo encontrar el servidor de base de datos.";
                icono = MessageBoxIcon.Error;
            }
            // aca si encuentra el servidor pero no encuentra la base de datos
            else if (ex.Number == 4060)
            {
                codigo = "ERR-SQL-002";
                mensaje = "No se pudo encontrar la base de datos.";
                icono = MessageBoxIcon.Error;
            }
            // aca si no nos deja iniciar sesion en la base de datos
            else if (ex.Number == 18456)
            {
                codigo = "ERR-SQL-003";
                mensaje = "No se pudo iniciar sesión en la base de datos.";
                icono = MessageBoxIcon.Error;
            }
            // aca si ya existe un registro con esos mismos datos
            else if (ex.Number == 2601 || ex.Number == 2627)
            {
                codigo = "ERR-SQL-004";
                mensaje = "Ya existe un registro con esos datos.";
                icono = MessageBoxIcon.Warning;
            }
            // aca si el registro esta relacionado con otro por llave foranea
            else if (ex.Number == 547)
            {
                codigo = "ERR-SQL-005";
                mensaje = "No se puede completar la operación porque existen datos relacionados.";
                icono = MessageBoxIcon.Warning;
            }
            // aca si falta llenar un campo que es obligatorio
            else if (ex.Number == 515)
            {
                codigo = "ERR-SQL-006";
                mensaje = "Falta información obligatoria para guardar el registro.";
                icono = MessageBoxIcon.Warning;
            }
            else if (ex.Number == 102 || ex.Number == 156)
            {
                codigo = "ERR-SQL-007";
                mensaje = "Ocurrió un error al procesar una consulta de la base de datos.";
                icono = MessageBoxIcon.Error;
            }
            else if (ex.Number == 64 || ex.Number == 121 || ex.Number == 233 || ex.Number == 258 || ex.Number == 10053 || ex.Number == 10054 || ex.Number == 10060)
            {
                codigo = "ERR-SQL-008";
                mensaje = "Se perdió la comunicación con el servidor de base de datos.";
                icono = MessageBoxIcon.Error;
            }
            // aca cualquier otro error que no tengamos contemplado
            else
            {
                codigo = "ERR-SQL-999";
                mensaje = "Ocurrió un error al trabajar con la base de datos.";
                icono = MessageBoxIcon.Error;
            }

            MessageBox.Show(codigo + " - " + mensaje, "Base de datos", MessageBoxButtons.OK, icono);
        }

        // aca definimos el metodo de ejecutar consulta, con este recibimos una consulta y nos conectamos a la base de datos, y ejecutamos una consulta teniendo en cuenta estos dos, definimos una datatable y la llenamos con los que nos devuelva la base de datos y retornamos la tabla definida
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

    }
}
