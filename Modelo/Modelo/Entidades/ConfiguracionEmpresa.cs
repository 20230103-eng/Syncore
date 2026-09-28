using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class ConfiguracionEmpresa
    {
        private int idConfiguracion;
        private string nombreEmpresa;
        private string rutaLogo;
        private byte[] logoImagen;
        private string informacionGeneral;
        private Conexion conexion;

        public int IdConfiguracion
        {
            get { return idConfiguracion; }
            set { idConfiguracion = value; }
        }

        public string NombreEmpresa
        {
            get { return nombreEmpresa; }
            set { nombreEmpresa = value; }
        }

        public string RutaLogo
        {
            get { return rutaLogo; }
            set { rutaLogo = value; }
        }

        public byte[] LogoImagen
        {
            get { return logoImagen; }
            set { logoImagen = value; }
        }

        public string InformacionGeneral
        {
            get { return informacionGeneral; }
            set { informacionGeneral = value; }
        }

        public ConfiguracionEmpresa()
        {
            conexion = new Conexion();
        }

        public bool ExisteConfiguracion()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int cantidad;

            query = "SELECT COUNT(*) FROM TbConfiguracionEmpresa";
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


        public ConfiguracionEmpresa ObtenerConfiguracion()
        {
            string query;
            DataTable datos;
            DataRow fila;
            ConfiguracionEmpresa configuracion;

            query = @"
            SELECT TOP 1
            IdConfiguracion,
            NombreEmpresa,
            RutaLogo,
            LogoImagen,
            InformacionGeneral
            FROM TbConfiguracionEmpresa
            ORDER BY IdConfiguracion";

            datos = conexion.EjecutarConsulta(query);

            if (datos.Rows.Count == 0)
            {
                return null;
            }

            fila = datos.Rows[0];
            configuracion = new ConfiguracionEmpresa();
            configuracion.IdConfiguracion = Convert.ToInt32(fila["IdConfiguracion"]);
            configuracion.NombreEmpresa = fila["NombreEmpresa"].ToString();
            configuracion.RutaLogo = fila["RutaLogo"].ToString();
            if (fila["LogoImagen"] != DBNull.Value)
            {
                configuracion.LogoImagen = (byte[])fila["LogoImagen"];
            }
            configuracion.InformacionGeneral = fila["InformacionGeneral"].ToString();
            return configuracion;
        }


        public bool GuardarPrimerUso(Usuario administrador)
        {
            SqlConnection conexionSql;
            SqlTransaction transaccion;
            SqlCommand comando;
            object imagen;
            object area;
            string hash;
            int gestores;
            int tipoGestorValido;

            if (administrador == null || administrador.IdTipoUsuario <= 0 ||
                string.IsNullOrEmpty(administrador.NombreUsuario) == true ||
                string.IsNullOrEmpty(administrador.Contrasena) == true ||
                string.IsNullOrEmpty(this.NombreEmpresa) == true ||
                this.LogoImagen == null || this.LogoImagen.Length == 0)
            {
                return false;
            }

            hash = BCrypt.Net.BCrypt.HashPassword(administrador.Contrasena);
            imagen = this.LogoImagen;
            area = DBNull.Value;

            if (administrador.IdArea.HasValue == true)
            {
                area = administrador.IdArea.Value;
            }

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            transaccion = null;

            try
            {
                transaccion = conexionSql.BeginTransaction(IsolationLevel.Serializable);

                comando = new SqlCommand(@"
                    SELECT COUNT(*)
                    FROM tbTipoUsuario
                    WHERE IdTipoUsuario = @IdTipoUsuario AND Nombre = N'Gestor'", conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdTipoUsuario", administrador.IdTipoUsuario);
                tipoGestorValido = Convert.ToInt32(comando.ExecuteScalar());
                comando.Dispose();

                if (tipoGestorValido == 0)
                {
                    transaccion.Rollback();
                    return false;
                }

                comando = new SqlCommand(@"
                    SELECT COUNT(*)
                    FROM tbUsuario WITH (UPDLOCK, HOLDLOCK)
                    WHERE IdTipoUsuario = @IdTipoUsuario AND Activo = 1", conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdTipoUsuario", administrador.IdTipoUsuario);
                gestores = Convert.ToInt32(comando.ExecuteScalar());
                comando.Dispose();

                if (gestores > 0)
                {
                    transaccion.Rollback();
                    return false;
                }

                comando = new SqlCommand(@"
                    IF EXISTS (SELECT 1 FROM TbConfiguracionEmpresa)
                    BEGIN
                        UPDATE TbConfiguracionEmpresa
                        SET NombreEmpresa = @NombreEmpresa,
                            RutaLogo = @RutaLogo,
                            LogoImagen = @LogoImagen,
                            InformacionGeneral = @InformacionGeneral,
                            FechaConfiguracion = GETDATE()
                    END
                    ELSE
                    BEGIN
                        INSERT INTO TbConfiguracionEmpresa
                        (NombreEmpresa, RutaLogo, LogoImagen, InformacionGeneral, FechaConfiguracion)
                        VALUES
                        (@NombreEmpresa, @RutaLogo, @LogoImagen, @InformacionGeneral, GETDATE())
                    END", conexionSql, transaccion);
                comando.Parameters.AddWithValue("@NombreEmpresa", this.NombreEmpresa);
                comando.Parameters.AddWithValue("@RutaLogo", this.RutaLogo);
                comando.Parameters.AddWithValue("@LogoImagen", imagen);
                comando.Parameters.AddWithValue("@InformacionGeneral", this.InformacionGeneral);
                comando.ExecuteNonQuery();
                comando.Dispose();

                comando = new SqlCommand(@"
                    INSERT INTO tbUsuario
                    (NombreUsuario, Contrasena, NombreCompleto, IdTipoUsuario, IdArea, Activo, FechaCreacion)
                    VALUES
                    (@NombreUsuario, @Contrasena, @NombreCompleto, @IdTipoUsuario, @IdArea, 1, GETDATE())", conexionSql, transaccion);
                comando.Parameters.AddWithValue("@NombreUsuario", administrador.NombreUsuario);
                comando.Parameters.AddWithValue("@Contrasena", hash);
                comando.Parameters.AddWithValue("@NombreCompleto", administrador.NombreCompleto);
                comando.Parameters.AddWithValue("@IdTipoUsuario", administrador.IdTipoUsuario);
                comando.Parameters.AddWithValue("@IdArea", area);
                comando.ExecuteNonQuery();
                comando.Dispose();

                transaccion.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                if (transaccion != null && transaccion.Connection != null)
                {
                    try
                    {
                        transaccion.Rollback();
                    }
                    catch (SqlException)
                    {
                    }
                }

                Conexion.MostrarErrorSql(ex);
                return false;
            }
            finally
            {
                if (transaccion != null)
                {
                    transaccion.Dispose();
                }

                conexionSql.Close();
                conexionSql.Dispose();
            }
        }

        public bool GuardarConfiguracion()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            int filas;
            object imagen;

            query = @"
            IF EXISTS (SELECT 1 FROM TbConfiguracionEmpresa)
            BEGIN
                UPDATE TbConfiguracionEmpresa
                SET NombreEmpresa = @NombreEmpresa,
                    RutaLogo = @RutaLogo,
                    LogoImagen = @LogoImagen,
                    InformacionGeneral = @InformacionGeneral,
                    FechaConfiguracion = GETDATE()
            END
            ELSE
            BEGIN
                INSERT INTO TbConfiguracionEmpresa
                (NombreEmpresa, RutaLogo, LogoImagen, InformacionGeneral, FechaConfiguracion)
                VALUES
                (@NombreEmpresa, @RutaLogo, @LogoImagen, @InformacionGeneral, GETDATE())
            END";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            filas = 0;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@NombreEmpresa", this.NombreEmpresa);
                comando.Parameters.AddWithValue("@RutaLogo", this.RutaLogo);
                imagen = DBNull.Value;
                if (this.LogoImagen != null)
                {
                    imagen = this.LogoImagen;
                }
                comando.Parameters.AddWithValue("@LogoImagen", imagen);
                comando.Parameters.AddWithValue("@InformacionGeneral", this.InformacionGeneral);
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
