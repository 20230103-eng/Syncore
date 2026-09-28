using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Modelo.Modelo.Infraestructura;

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
            string servidorConfigurado;
            SqlConnection conexion;

            servidorConfigurado = System.Configuration.ConfigurationManager.AppSettings["ServidorSQL"];
            if (string.IsNullOrEmpty(servidorConfigurado) == false)
            {
                servidor = servidorConfigurado;
            }
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

        public static bool ProbarConexion()
        {
            SqlConnection conexion;

            conexion = conectar();

            if (conexion == null)
            {
                return false;
            }

            conexion.Close();
            conexion.Dispose();
            return true;
        }

        public static void MostrarErrorSql(SqlException ex)
        {
            string codigo = CatalogoErrores.CodigoSql(ex.Number);

            if (codigo == "ERR-SQL-999")
            {
                CatalogoErrores.MostrarDetalle(codigo, "Base de datos", "Código SQL Server: " + ex.Number.ToString());
            }
            else
            {
                CatalogoErrores.Mostrar(codigo, "Base de datos");
            }
        }

        public DataTable EjecutarPagina(string consulta, SqlParameter[] parametros, int pagina, out int total)
        {
            DataTable tabla = new DataTable();
            total = 0;
            SqlConnection conexion = conectar();
            if (conexion == null)
            {
                return tabla;
            }
            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    for (int indice = 0; indice < parametros.Length; indice = indice + 1)
                    {
                        comando.Parameters.Add(parametros[indice]);
                    }
                    comando.Parameters.AddWithValue("@Inicio", Math.Max(0, pagina) * 20);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                    if (tabla.Rows.Count > 0 && tabla.Columns.Contains("TotalRegistros"))
                    {
                        total = Convert.ToInt32(tabla.Rows[0]["TotalRegistros"]);
                    }
                    if (tabla.Columns.Contains("TotalRegistros"))
                    {
                        tabla.Columns.Remove("TotalRegistros");
                    }
                }
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

        public DataTable EjecutarPaginaTamano(string consulta, SqlParameter[] parametros, int pagina, int tamanoPagina, out int total)
        {
            DataTable tabla = new DataTable();
            total = 0;
            SqlConnection conexion = conectar();
            if (conexion == null)
            {
                return tabla;
            }
            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    for (int indice = 0; indice < parametros.Length; indice = indice + 1)
                    {
                        comando.Parameters.Add(parametros[indice]);
                    }
                    int tamano = Math.Max(1, Math.Min(20, tamanoPagina));
                    comando.Parameters.AddWithValue("@Inicio", Math.Max(0, pagina) * tamano);
                    comando.Parameters.AddWithValue("@Tamano", tamano);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                    if (tabla.Rows.Count > 0 && tabla.Columns.Contains("TotalRegistros"))
                    {
                        total = Convert.ToInt32(tabla.Rows[0]["TotalRegistros"]);
                    }
                    if (tabla.Columns.Contains("TotalRegistros"))
                    {
                        tabla.Columns.Remove("TotalRegistros");
                    }
                }
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
