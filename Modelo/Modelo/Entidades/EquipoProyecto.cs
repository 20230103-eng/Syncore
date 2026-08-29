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

            query = $@"
            SELECT
            tbUsuario.IdUsuario,
            tbUsuario.NombreCompleto,
            ISNULL(tbArea.Nombre, N'Sin área') AS Area,
            tbRolProyecto.Nombre AS RolProyecto
            FROM tbEquipoProyecto
            INNER JOIN tbUsuario ON tbEquipoProyecto.IdUsuario = tbUsuario.IdUsuario
            INNER JOIN tbRolProyecto ON tbEquipoProyecto.IdRolProyecto = tbRolProyecto.IdRolProyecto
            LEFT JOIN tbArea ON tbUsuario.IdArea = tbArea.IdArea
            WHERE tbEquipoProyecto.IdProyecto = {idProyecto}
            AND tbEquipoProyecto.Activo = 1
            AND tbUsuario.Activo = 1
            ORDER BY tbUsuario.NombreCompleto";

            equipo = conexion.EjecutarConsulta(query);
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
            DataTable datos;
            int cantidad;

            query = $@"
            SELECT COUNT(*)
            FROM tbEquipoProyecto
            WHERE IdProyecto = {idProyecto}
            AND IdUsuario = {idUsuario}";

            datos = conexion.EjecutarConsulta(query);
            cantidad = 0;

            if (datos.Rows.Count > 0)
            {
                cantidad = Convert.ToInt32(datos.Rows[0][0]);
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
            DataTable datos;
            int cantidad;

            query = $@"
            SELECT COUNT(*)
            FROM tbTarea
            WHERE IdProyecto = {idProyecto}
            AND IdResponsable = {idUsuario}";

            datos = conexion.EjecutarConsulta(query);
            cantidad = 0;

            if (datos.Rows.Count > 0)
            {
                cantidad = Convert.ToInt32(datos.Rows[0][0]);
            }

            return cantidad;
        }

        public int ContarTareasPorEstado(int idProyecto, int idUsuario, string estado)
        {
            string query;
            DataTable datos;
            int cantidad;

            estado = estado.Replace("'", "''");

            query = $@"
            SELECT COUNT(*)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdProyecto = {idProyecto}
            AND tbTarea.IdResponsable = {idUsuario}
            AND tbEstadoTarea.Nombre = N'{estado}'";

            datos = conexion.EjecutarConsulta(query);
            cantidad = 0;

            if (datos.Rows.Count > 0)
            {
                cantidad = Convert.ToInt32(datos.Rows[0][0]);
            }

            return cantidad;
        }

        public bool AgregarIntegrante()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            bool agregado;

            query = @"
            INSERT INTO tbEquipoProyecto
            (IdProyecto, IdUsuario, IdRolProyecto, FechaAsignacion, Activo)
            VALUES
            (@IdProyecto, @IdUsuario, @IdRolProyecto, @FechaAsignacion, @Activo)";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
                comando.Parameters.AddWithValue("@IdUsuario", this.IdUsuario);
                comando.Parameters.AddWithValue("@IdRolProyecto", this.IdRolProyecto);
                comando.Parameters.AddWithValue("@FechaAsignacion", this.FechaAsignacion);
                comando.Parameters.AddWithValue("@Activo", this.Activo);
                comando.ExecuteNonQuery();
                comando.Dispose();
                agregado = true;
            }
            catch (SqlException ex)
            {
                Conexion.MostrarErrorSql(ex);
                agregado = false;
            }
            finally
            {
                conexionSql.Close();
                conexionSql.Dispose();
            }

            return agregado;
        }
    }
}
