using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class EquipoProyecto
    {
        private int idEquipo;
        private int idProyecto;
        private int idUsuario;
        private int idRolProyecto;
        private DateTime fechaAsignacion;
        private bool activo;
        private Conexion conexion;

        public int IdEquipo
        {
            get
            {
                return idEquipo;
            }
            set
            {
                idEquipo = value;
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

        public int IdRolProyecto
        {
            get
            {
                return idRolProyecto;
            }
            set
            {
                idRolProyecto = value;
            }
        }

        public DateTime FechaAsignacion
        {
            get
            {
                return fechaAsignacion;
            }
            set
            {
                fechaAsignacion = value;
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

        public EquipoProyecto()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerEquipoProyecto(int idProyecto)
        {
            string query;
            DataTable equipo;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT
            tbEquipoProyecto.IdEquipo,
            tbEquipoProyecto.IdRolProyecto,
            tbUsuario.IdUsuario,
            tbUsuario.NombreCompleto,
            ISNULL(tbArea.Nombre, N'Sin área') AS Area,
            tbRolProyecto.Nombre AS RolProyecto
            FROM tbEquipoProyecto
            INNER JOIN tbUsuario ON tbEquipoProyecto.IdUsuario = tbUsuario.IdUsuario
            INNER JOIN tbRolProyecto ON tbEquipoProyecto.IdRolProyecto = tbRolProyecto.IdRolProyecto
            LEFT JOIN tbArea ON tbUsuario.IdArea = tbArea.IdArea
            WHERE tbEquipoProyecto.IdProyecto = @IdProyecto
            AND tbEquipoProyecto.Activo = 1
            AND tbUsuario.Activo = 1
            ORDER BY tbUsuario.NombreCompleto";

            equipo = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return equipo;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(equipo);
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

            equipo.Columns.Add("TareasAsignadas", typeof(int));
            equipo.Columns.Add("TareasCompletadas", typeof(int));
            equipo.Columns.Add("TareasVencidas", typeof(int));

            foreach (DataRow fila in equipo.Rows)
            {
                int idUsuario;

                idUsuario = Convert.ToInt32(fila["IdUsuario"]);
                fila["TareasAsignadas"] = ContarTareas(idProyecto, idUsuario);
                fila["TareasCompletadas"] = ContarTareasPorEstado(idProyecto, idUsuario, "Completada");
                fila["TareasVencidas"] = ContarTareasPorEstado(idProyecto, idUsuario, "Vencida");
            }

            return equipo;
        }

        public DataTable ObtenerUsuariosDisponibles(int idProyecto, string texto)
        {
            DataTable usuarios;
            DataTable disponibles;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;
            string query;

            query = @"
            SELECT IdUsuario, NombreUsuario, NombreCompleto
            FROM tbUsuario
            WHERE Activo = 1
            AND
            (
                @Texto = N''
                OR NombreUsuario LIKE N'%' + @Texto + N'%'
                OR NombreCompleto LIKE N'%' + @Texto + N'%'
            )
            ORDER BY NombreCompleto";

            usuarios = new DataTable();
            disponibles = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return disponibles;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@Texto", texto);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(usuarios);
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

            disponibles = usuarios.Clone();

            foreach (DataRow fila in usuarios.Rows)
            {
                int idUsuario;
                bool existe;

                idUsuario = Convert.ToInt32(fila["IdUsuario"]);
                existe = ExisteIntegrante(idProyecto, idUsuario);

                if (existe == false)
                {
                    disponibles.ImportRow(fila);
                }
            }

            return disponibles;
        }

        public bool ExisteIntegrante(int idProyecto, int idUsuario)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int cantidad;

            query = @"
            SELECT COUNT(*)
            FROM tbEquipoProyecto
            WHERE IdProyecto = @IdProyecto
            AND IdUsuario = @IdUsuario
            AND Activo = 1";

            cantidad = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
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

            if (cantidad > 0)
            {
                return true;
            }

            return false;
        }

        public int ContarTareas(int idProyecto, int idUsuario)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int cantidad;

            query = @"
            SELECT COUNT(*)
            FROM tbTarea
            WHERE IdProyecto = @IdProyecto
            AND IdResponsable = @IdUsuario";

            cantidad = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return cantidad;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
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

        public int ContarTareasPorEstado(int idProyecto, int idUsuario, string estado)
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
            AND tbTarea.IdResponsable = @IdUsuario
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
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
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

        public bool AgregarIntegrante()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            int filas;
            bool agregado;

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            agregado = false;

            try
            {
                query = @"
                UPDATE tbEquipoProyecto
                SET IdRolProyecto = @IdRolProyecto,
                FechaAsignacion = @FechaAsignacion,
                Activo = @Activo
                WHERE IdProyecto = @IdProyecto
                AND IdUsuario = @IdUsuario
                AND Activo = 0";

                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
                comando.Parameters.AddWithValue("@IdUsuario", this.IdUsuario);
                comando.Parameters.AddWithValue("@IdRolProyecto", this.IdRolProyecto);
                comando.Parameters.AddWithValue("@FechaAsignacion", this.FechaAsignacion);
                comando.Parameters.AddWithValue("@Activo", this.Activo);
                filas = comando.ExecuteNonQuery();
                comando.Dispose();

                if (filas == 0)
                {
                    query = @"
                    INSERT INTO tbEquipoProyecto
                    (IdProyecto, IdUsuario, IdRolProyecto, FechaAsignacion, Activo)
                    VALUES
                    (@IdProyecto, @IdUsuario, @IdRolProyecto, @FechaAsignacion, @Activo)";

                    comando = new SqlCommand(query, conexionSql);
                    comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
                    comando.Parameters.AddWithValue("@IdUsuario", this.IdUsuario);
                    comando.Parameters.AddWithValue("@IdRolProyecto", this.IdRolProyecto);
                    comando.Parameters.AddWithValue("@FechaAsignacion", this.FechaAsignacion);
                    comando.Parameters.AddWithValue("@Activo", this.Activo);
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                }

                agregado = true;
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

            return agregado;
        }

        public bool ActualizarRol()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            bool actualizado;

            query = @"
            UPDATE tbEquipoProyecto
            SET IdRolProyecto = @IdRolProyecto
            WHERE IdEquipo = @IdEquipo
            AND Activo = 1";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            actualizado = false;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdRolProyecto", this.IdRolProyecto);
                comando.Parameters.AddWithValue("@IdEquipo", this.IdEquipo);
                actualizado = comando.ExecuteNonQuery() > 0;
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

            return actualizado;
        }

        public bool TieneTareasActivasAsignadas()
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
            AND tbTarea.IdResponsable = @IdUsuario
            AND tbEstadoTarea.Nombre <> N'Completada'";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return true;
            }

            cantidad = 0;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
                comando.Parameters.AddWithValue("@IdUsuario", this.IdUsuario);
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
                return true;
            }
            finally
            {
                conexionSql.Close();
                conexionSql.Dispose();
            }

            return cantidad > 0;
        }

        public bool RetirarIntegrante()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            bool retirado;

            query = @"
            UPDATE tbEquipoProyecto
            SET Activo = 0
            WHERE IdEquipo = @IdEquipo
            AND IdProyecto = @IdProyecto
            AND IdUsuario = @IdUsuario";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            retirado = false;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdEquipo", this.IdEquipo);
                comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
                comando.Parameters.AddWithValue("@IdUsuario", this.IdUsuario);
                retirado = comando.ExecuteNonQuery() > 0;
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

            return retirado;
        }

    }
}
