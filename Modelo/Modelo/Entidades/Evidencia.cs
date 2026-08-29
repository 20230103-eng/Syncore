using System;
using System.Data;
using Modelo.Modelo;
using System.Data.SqlClient;

namespace Modelo.Modelo.Entidades
{
    public class Evidencia
    {
        private int idEvidencia;
        private int idAvance;
        private string nombreArchivo;
        private string rutaArchivo;
        private string tipoArchivo;
        private DateTime fechaSubida;
        private Conexion conexion;

        public int IdEvidencia
        {
            get
            {
                return idEvidencia;
            }
            set
            {
                idEvidencia = value;
            }
        }

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

        public string NombreArchivo
        {
            get
            {
                return nombreArchivo;
            }
            set
            {
                nombreArchivo = value;
            }
        }

        public string RutaArchivo
        {
            get
            {
                return rutaArchivo;
            }
            set
            {
                rutaArchivo = value;
            }
        }

        public string TipoArchivo
        {
            get
            {
                return tipoArchivo;
            }
            set
            {
                tipoArchivo = value;
            }
        }

        public DateTime FechaSubida
        {
            get
            {
                return fechaSubida;
            }
            set
            {
                fechaSubida = value;
            }
        }

        public Evidencia()
        {
            conexion = new Conexion();
        }

        public bool GuardarEvidencia()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object tipoArchivo;
            bool guardada;

            tipoArchivo = this.TipoArchivo;

            if (string.IsNullOrEmpty(this.TipoArchivo) == true || string.IsNullOrEmpty(this.TipoArchivo.Trim()) == true)
            {
                tipoArchivo = DBNull.Value;
            }

            query = @"
            INSERT INTO tbEvidencia
            (IdAvance, NombreArchivo, RutaArchivo, TipoArchivo, FechaSubida)
            VALUES
            (@IdAvance, @NombreArchivo, @RutaArchivo, @TipoArchivo, @FechaSubida)";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdAvance", this.IdAvance);
                comando.Parameters.AddWithValue("@NombreArchivo", this.NombreArchivo);
                comando.Parameters.AddWithValue("@RutaArchivo", this.RutaArchivo);
                comando.Parameters.AddWithValue("@TipoArchivo", tipoArchivo);
                comando.Parameters.AddWithValue("@FechaSubida", this.FechaSubida);
                comando.ExecuteNonQuery();
                comando.Dispose();
                guardada = true;
            }
            catch (SqlException ex)
            {
                Conexion.MostrarErrorSql(ex);
                guardada = false;
            }
            finally
            {
                conexionSql.Close();
                conexionSql.Dispose();
            }

            return guardada;
        }

        public DataTable ObtenerEvidenciasTarea(int idTarea)
        {
            string query = $@"
            SELECT tbEvidencia.NombreArchivo, tbEvidencia.TipoArchivo, tbEvidencia.FechaSubida
            FROM tbEvidencia
            INNER JOIN tbAvance
            ON tbEvidencia.IdAvance = tbAvance.IdAvance
            WHERE tbAvance.IdTarea = {idTarea}
            ORDER BY tbEvidencia.IdEvidencia";

            DataTable evidencias = conexion.EjecutarConsulta(query);
            return evidencias;
        }

        public int ContarEvidenciasTarea(int idTarea)
        {
            string query = $@"
            SELECT COUNT(*)
            FROM tbEvidencia
            INNER JOIN tbAvance
            ON tbEvidencia.IdAvance = tbAvance.IdAvance
            WHERE tbAvance.IdTarea = {idTarea}";

            DataTable datos = conexion.EjecutarConsulta(query);
            int cantidad = 0;

            if (datos.Rows.Count > 0)
            {
                cantidad = Convert.ToInt32(datos.Rows[0][0]);
            }

            return cantidad;
        }

        public int ContarEvidenciasAvance(int idAvance)
        {
            string query = $@"
            SELECT COUNT(*)
            FROM tbEvidencia
            WHERE IdAvance = {idAvance}";

            DataTable datos = conexion.EjecutarConsulta(query);
            int cantidad = 0;

            if (datos.Rows.Count > 0)
            {
                cantidad = Convert.ToInt32(datos.Rows[0][0]);
            }

            return cantidad;
        }
    }
}
