using System;
using System.Data;
using Modelo.Modelo;
using System.Data.SqlClient;

namespace Modelo.Modelo.Entidades
{
    public class ComentarioTarea
    {
        private int idComentario;
        private int idTarea;
        private int idUsuario;
        private string comentario;
        private DateTime fechaComentario;
        private Conexion conexion;

        public int IdComentario
        {
            get
            {
                return idComentario;
            }
            set
            {
                idComentario = value;
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

        public string Comentario
        {
            get
            {
                return comentario;
            }
            set
            {
                comentario = value;
            }
        }

        public DateTime FechaComentario
        {
            get
            {
                return fechaComentario;
            }
            set
            {
                fechaComentario = value;
            }
        }

        public ComentarioTarea()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerComentariosTarea(int idTarea)
        {
            string query;
            DataTable comentarios;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT TOP (1) tbUsuario.NombreCompleto, tbComentarioTarea.FechaComentario, tbComentarioTarea.Comentario
            FROM tbComentarioTarea
            INNER JOIN tbUsuario ON tbComentarioTarea.IdUsuario = tbUsuario.IdUsuario
            WHERE tbComentarioTarea.IdTarea = @IdTarea
            ORDER BY tbComentarioTarea.IdComentario DESC";

            comentarios = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return comentarios;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdTarea", idTarea);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(comentarios);
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

            return comentarios;
        }

        public void AgregarComentario(int idTarea, int idUsuario, string comentario)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;

            query = @"
            INSERT INTO tbComentarioTarea
            (IdTarea, IdUsuario, Comentario, FechaComentario)
            VALUES
            (@IdTarea, @IdUsuario, @Comentario, @FechaComentario)";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdTarea", idTarea);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@Comentario", comentario);
                comando.Parameters.AddWithValue("@FechaComentario", DateTime.Now);
                comando.ExecuteNonQuery();
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
        }
        public DataTable ObtenerComentariosTareaPagina(int idTarea, int pagina, out int total)
        {
            string consulta = @"
                SELECT u.NombreCompleto, c.FechaComentario, c.Comentario,
                    COUNT(*) OVER() AS TotalRegistros
                FROM tbComentarioTarea c
                INNER JOIN tbUsuario u ON u.IdUsuario = c.IdUsuario
                WHERE c.IdTarea = @IdTarea
                ORDER BY c.IdComentario DESC
                OFFSET @Inicio ROWS FETCH NEXT @Tamano ROWS ONLY";
            SqlParameter[] parametros = { new SqlParameter("@IdTarea", idTarea) };
            return new Conexion().EjecutarPaginaTamano(consulta, parametros, pagina, 1, out total);
        }

    }
}
