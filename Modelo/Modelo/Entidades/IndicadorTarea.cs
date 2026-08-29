using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class IndicadorTarea
    {
        private string nombre;
        private decimal valor;
        private Conexion conexion;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
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

        public IndicadorTarea()
        {
            conexion = new Conexion();
        }

        public int ContarTareasVencidasProyecto(int idProyecto)
        {
            string query = $@"
            SELECT COUNT(*)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdProyecto = {idProyecto}
            AND tbEstadoTarea.Nombre = N'Vencida'";

            DataTable datos = conexion.EjecutarConsulta(query);
            int cantidad = Convert.ToInt32(datos.Rows[0][0]);
            return cantidad;
        }

        public DataTable AgregarTareasVencidas(DataTable proyectos)
        {
            if (proyectos.Columns.Contains("TareasVencidas") == false)
            {
                proyectos.Columns.Add("TareasVencidas", typeof(int));
            }

            foreach (DataRow fila in proyectos.Rows)
            {
                int idProyecto = Convert.ToInt32(fila["IdProyecto"]);
                int tareasVencidas = ContarTareasVencidasProyecto(idProyecto);
                fila["TareasVencidas"] = tareasVencidas;
            }

            return proyectos;
        }

        public int ContarTareasProyecto(int idProyecto)
        {
            string query = $@"
            SELECT COUNT(*)
            FROM tbTarea
            WHERE IdProyecto = {idProyecto}";

            DataTable datos = conexion.EjecutarConsulta(query);
            int cantidad = Convert.ToInt32(datos.Rows[0][0]);
            return cantidad;
        }

        public int ContarTareasProyectoPorEstado(int idProyecto, string estado)
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
            WHERE tbTarea.IdProyecto = @IdProyecto
            AND tbEstadoTarea.Nombre = @Estado";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return 0;
            }

            cantidad = 0;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                comando.Parameters.AddWithValue("@Estado", estado);
                resultado = comando.ExecuteScalar();

                if (resultado != null)
                {
                    cantidad = Convert.ToInt32(resultado);
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

            return cantidad;
        }
    }
}
