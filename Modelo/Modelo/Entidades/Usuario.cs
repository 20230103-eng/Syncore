using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string contrasena;
        private string nombreCompleto;
        private int idTipoUsuario;
        private string tipoUsuario;
        private int? idArea;
        private bool activo;
        private DateTime fechaCreacion;
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

        public string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }
            set
            {
                nombreUsuario = value;
            }
        }

        public string Contrasena
        {
            get
            {
                return contrasena;
            }
            set
            {
                contrasena = value;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return nombreCompleto;
            }
            set
            {
                nombreCompleto = value;
            }
        }

        public int IdTipoUsuario
        {
            get
            {
                return idTipoUsuario;
            }
            set
            {
                idTipoUsuario = value;
            }
        }

        public string TipoUsuario
        {
            get
            {
                return tipoUsuario;
            }
            set
            {
                tipoUsuario = value;
            }
        }

        public int? IdArea
        {
            get
            {
                return idArea;
            }
            set
            {
                idArea = value;
            }
        }

        public bool Activo
        {
            get
            {
                return activo;
            }
            set
            {
                activo = value;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }
            set
            {
                fechaCreacion = value;
            }
        }

        public Usuario()
        {
            conexion = new Conexion();
        }

        public Usuario ValidarUsuario(string nombreUsuario, string contrasena, string tipoUsuario)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;
            DataTable datos;
            DataRow fila;
            string contrasenaGuardada;
            bool contrasenaCorrecta;
            Usuario usuario;

            query = @"
            SELECT
            tbUsuario.IdUsuario,
            tbUsuario.NombreUsuario,
            tbUsuario.Contrasena,
            tbUsuario.NombreCompleto,
            tbUsuario.IdTipoUsuario,
            tbTipoUsuario.Nombre AS TipoUsuario,
            tbUsuario.IdArea,
            tbUsuario.Activo,
            tbUsuario.FechaCreacion
            FROM tbUsuario
            INNER JOIN tbTipoUsuario ON tbUsuario.IdTipoUsuario = tbTipoUsuario.IdTipoUsuario
            WHERE tbUsuario.NombreUsuario = @NombreUsuario
            AND tbTipoUsuario.Nombre = @TipoUsuario
            AND tbUsuario.Activo = 1";

            datos = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return null;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@TipoUsuario", tipoUsuario);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(datos);
                adaptador.Dispose();
                comando.Dispose();
            }
            catch (SqlException ex)
            {
                Conexion.MostrarErrorSql(ex);
                return null;
            }
            finally
            {
                conexionSql.Close();
                conexionSql.Dispose();
            }

            if (datos.Rows.Count == 0)
            {
                return null;
            }

            fila = datos.Rows[0];
            contrasenaGuardada = fila["Contrasena"].ToString();
            contrasenaCorrecta = BCrypt.Net.BCrypt.Verify(contrasena, contrasenaGuardada);

            if (contrasenaCorrecta == false)
            {
                return null;
            }

            usuario = CrearUsuarioDesdeFila(fila);
            return usuario;
        }

        private Usuario CrearUsuarioDesdeFila(DataRow fila)
        {
            Usuario usuario;

            usuario = new Usuario();
            usuario.IdUsuario = Convert.ToInt32(fila["IdUsuario"]);
            usuario.NombreUsuario = fila["NombreUsuario"].ToString();
            usuario.NombreCompleto = fila["NombreCompleto"].ToString();
            usuario.IdTipoUsuario = Convert.ToInt32(fila["IdTipoUsuario"]);
            usuario.TipoUsuario = fila["TipoUsuario"].ToString();

            if (fila["IdArea"] != DBNull.Value)
            {
                usuario.IdArea = Convert.ToInt32(fila["IdArea"]);
            }

            usuario.Activo = Convert.ToBoolean(fila["Activo"]);
            usuario.FechaCreacion = Convert.ToDateTime(fila["FechaCreacion"]);
            return usuario;
        }

        public DataTable ObtenerUsuarios()
        {
            string query;

            query = @"
            SELECT
            tbUsuario.IdUsuario,
            tbUsuario.NombreUsuario,
            tbUsuario.NombreCompleto,
            tbUsuario.IdTipoUsuario,
            tbTipoUsuario.Nombre AS TipoUsuario,
            tbUsuario.IdArea,
            ISNULL(tbArea.Nombre, N'Sin área') AS Area,
            tbUsuario.Activo,
            tbUsuario.FechaCreacion
            FROM tbUsuario
            INNER JOIN tbTipoUsuario ON tbUsuario.IdTipoUsuario = tbTipoUsuario.IdTipoUsuario
            LEFT JOIN tbArea ON tbUsuario.IdArea = tbArea.IdArea
            ORDER BY tbUsuario.NombreCompleto";

            return conexion.EjecutarConsulta(query);
        }

        public DataTable ObtenerUsuariosActivos()
        {
            string query;

            query = @"
            SELECT IdUsuario, NombreCompleto
            FROM tbUsuario
            WHERE Activo = 1
            ORDER BY NombreCompleto";

            return conexion.EjecutarConsulta(query);
        }

        public DataTable ObtenerColaboradoresActivos()
        {
            string query;

            query = @"
            SELECT tbUsuario.IdUsuario, tbUsuario.NombreCompleto
            FROM tbUsuario
            INNER JOIN tbTipoUsuario ON tbUsuario.IdTipoUsuario = tbTipoUsuario.IdTipoUsuario
            WHERE tbUsuario.Activo = 1
            AND tbTipoUsuario.Nombre = N'Colaborador'
            ORDER BY tbUsuario.NombreCompleto";

            return conexion.EjecutarConsulta(query);
        }

        public bool ExisteNombreUsuarioEnOtroUsuario(string nombreUsuario, int idUsuarioExcluir)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int cantidad;

            query = @"
            SELECT COUNT(*)
            FROM tbUsuario
            WHERE NombreUsuario = @NombreUsuario
            AND IdUsuario <> @IdUsuario";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return true;
            }

            cantidad = 0;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuarioExcluir);
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
                return true;
            }
            finally
            {
                conexionSql.Close();
                conexionSql.Dispose();
            }

            if (cantidad > 0)
            {
                return true;
            }

            return false;
        }

        public bool CrearUsuario()
        {
            string query;
            string hash;
            object area;
            SqlConnection conexionSql;
            SqlCommand comando;
            int filas;

            hash = BCrypt.Net.BCrypt.HashPassword(this.Contrasena);
            area = DBNull.Value;

            if (this.IdArea.HasValue == true)
            {
                area = this.IdArea.Value;
            }

            query = @"
            INSERT INTO tbUsuario
            (NombreUsuario, Contrasena, NombreCompleto, IdTipoUsuario, IdArea, Activo, FechaCreacion)
            VALUES
            (@NombreUsuario, @Contrasena, @NombreCompleto, @IdTipoUsuario, @IdArea, @Activo, GETDATE())";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            filas = 0;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@NombreUsuario", this.NombreUsuario);
                comando.Parameters.AddWithValue("@Contrasena", hash);
                comando.Parameters.AddWithValue("@NombreCompleto", this.NombreCompleto);
                comando.Parameters.AddWithValue("@IdTipoUsuario", this.IdTipoUsuario);
                comando.Parameters.AddWithValue("@IdArea", area);
                comando.Parameters.AddWithValue("@Activo", this.Activo);
                filas = comando.ExecuteNonQuery();
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

            if (filas > 0)
            {
                return true;
            }

            return false;
        }

        public bool ActualizarUsuario(bool cambiarContrasena)
        {
            string query;
            string hash;
            object area;
            SqlConnection conexionSql;
            SqlCommand comando;
            int filas;

            area = DBNull.Value;

            if (this.IdArea.HasValue == true)
            {
                area = this.IdArea.Value;
            }

            query = @"
            UPDATE tbUsuario
            SET NombreUsuario = @NombreUsuario,
            NombreCompleto = @NombreCompleto,
            IdTipoUsuario = @IdTipoUsuario,
            IdArea = @IdArea,
            Activo = @Activo
            WHERE IdUsuario = @IdUsuario";

            if (cambiarContrasena == true)
            {
                query = @"
                UPDATE tbUsuario
                SET NombreUsuario = @NombreUsuario,
                Contrasena = @Contrasena,
                NombreCompleto = @NombreCompleto,
                IdTipoUsuario = @IdTipoUsuario,
                IdArea = @IdArea,
                Activo = @Activo
                WHERE IdUsuario = @IdUsuario";
            }

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            filas = 0;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@NombreUsuario", this.NombreUsuario);
                comando.Parameters.AddWithValue("@NombreCompleto", this.NombreCompleto);
                comando.Parameters.AddWithValue("@IdTipoUsuario", this.IdTipoUsuario);
                comando.Parameters.AddWithValue("@IdArea", area);
                comando.Parameters.AddWithValue("@Activo", this.Activo);
                comando.Parameters.AddWithValue("@IdUsuario", this.IdUsuario);

                if (cambiarContrasena == true)
                {
                    hash = BCrypt.Net.BCrypt.HashPassword(this.Contrasena);
                    comando.Parameters.AddWithValue("@Contrasena", hash);
                }

                filas = comando.ExecuteNonQuery();
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

            if (filas > 0)
            {
                return true;
            }

            return false;
        }

        public bool EliminarUsuario()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            int filas;

            query = @"
            DELETE FROM tbUsuario
            WHERE IdUsuario = @IdUsuario";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            filas = 0;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", this.IdUsuario);
                filas = comando.ExecuteNonQuery();
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

            if (filas > 0)
            {
                return true;
            }

            return false;
        }
        public bool ExisteGestorActivo()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int cantidad;

            query = @"
            SELECT COUNT(*)
            FROM tbUsuario
            INNER JOIN tbTipoUsuario ON tbUsuario.IdTipoUsuario = tbTipoUsuario.IdTipoUsuario
            WHERE tbTipoUsuario.Nombre = N'Gestor'
            AND tbUsuario.Activo = 1";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            cantidad = 0;

            try
            {
                comando = new SqlCommand(query, conexionSql);
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
                return false;
            }
            finally
            {
                conexionSql.Close();
                conexionSql.Dispose();
            }

            if (cantidad > 0)
            {
                return true;
            }

            return false;
        }

        public int ObtenerIdTipoUsuario(string nombreTipoUsuario)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int idTipo;

            query = @"
            SELECT IdTipoUsuario
            FROM tbTipoUsuario
            WHERE Nombre = @Nombre";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return 0;
            }

            idTipo = 0;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@Nombre", nombreTipoUsuario);
                resultado = comando.ExecuteScalar();

                if (resultado != null)
                {
                    idTipo = Convert.ToInt32(resultado);
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

            return idTipo;
        }

        public bool RestablecerContrasenaTemporal(string claveTemporal)
        {
            string query;
            string hash;
            SqlConnection conexionSql;
            SqlCommand comando;
            int filas;

            hash = BCrypt.Net.BCrypt.HashPassword(claveTemporal);
            query = @"
            UPDATE tbUsuario
            SET Contrasena = @Contrasena
            WHERE IdUsuario = @IdUsuario";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            filas = 0;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@Contrasena", hash);
                comando.Parameters.AddWithValue("@IdUsuario", this.IdUsuario);
                filas = comando.ExecuteNonQuery();
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

            if (filas > 0)
            {
                return true;
            }

            return false;
        }

        public bool CambiarContrasena(int idUsuario, string contrasenaActual, string nuevaContrasena)
        {
            string queryConsulta;
            string queryActualizar;
            string contrasenaGuardada;
            string hashNuevo;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int filas;

            queryConsulta = @"
            SELECT Contrasena
            FROM tbUsuario
            WHERE IdUsuario = @IdUsuario
            AND Activo = 1";

            queryActualizar = @"
            UPDATE tbUsuario
            SET Contrasena = @Contrasena
            WHERE IdUsuario = @IdUsuario";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            filas = 0;

            try
            {
                comando = new SqlCommand(queryConsulta, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado == null)
                {
                    return false;
                }

                contrasenaGuardada = resultado.ToString();

                if (BCrypt.Net.BCrypt.Verify(contrasenaActual, contrasenaGuardada) == false)
                {
                    return false;
                }

                hashNuevo = BCrypt.Net.BCrypt.HashPassword(nuevaContrasena);
                comando = new SqlCommand(queryActualizar, conexionSql);
                comando.Parameters.AddWithValue("@Contrasena", hashNuevo);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                filas = comando.ExecuteNonQuery();
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

            if (filas > 0)
            {
                return true;
            }

            return false;
        }

    }
}
