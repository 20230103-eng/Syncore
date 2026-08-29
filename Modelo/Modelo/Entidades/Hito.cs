using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class Hito
    {
        private int idHito;
        private int idProyecto;
        private string nombre;
        private string descripcion;
        private DateTime fechaObjetivo;
        private int? idResponsable;
        private int idEstadoHito;
        private string estado;
        private DateTime? fechaCumplimiento;
        private Conexion conexion;

        public int IdHito
        {
            get { return idHito; }
            set { idHito = value; }
        }

        public int IdProyecto
        {
            get { return idProyecto; }
            set { idProyecto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public DateTime FechaObjetivo
        {
            get { return fechaObjetivo; }
            set { fechaObjetivo = value; }
        }

        public int? IdResponsable
        {
            get { return idResponsable; }
            set { idResponsable = value; }
        }

        public int IdEstadoHito
        {
            get { return idEstadoHito; }
            set { idEstadoHito = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public DateTime? FechaCumplimiento
        {
            get { return fechaCumplimiento; }
            set { fechaCumplimiento = value; }
        }

        public Hito()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerHitosProximosProyecto(int idProyecto, int cantidad)
        {
            string query;
            DataTable hitos;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            if (cantidad < 1)
            {
                cantidad = 2;
            }

            query = @"
            SELECT TOP (@Cantidad)
            tbHito.IdHito,
            tbHito.Nombre AS Hito,
            tbHito.FechaObjetivo,
            ISNULL(tbUsuario.NombreCompleto, N'Sin asignar') AS Responsable,
            tbEstadoHito.Nombre AS Estado
            FROM tbHito
            LEFT JOIN tbUsuario ON tbHito.IdResponsable = tbUsuario.IdUsuario
            INNER JOIN tbEstadoHito ON tbHito.IdEstadoHito = tbEstadoHito.IdEstadoHito
            WHERE tbHito.IdProyecto = @IdProyecto
            AND tbEstadoHito.Nombre <> N'Cumplido'
            ORDER BY tbHito.FechaObjetivo";

            hitos = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return hitos;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@Cantidad", cantidad);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(hitos);
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

            return hitos;
        }

        public DataTable ObtenerHitosGestor(int idGestor)
        {
            string query;
            DataTable hitos;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT
            tbHito.IdHito,
            tbHito.IdProyecto,
            tbProyecto.Nombre AS Proyecto,
            tbHito.Nombre AS Hito,
            tbHito.Descripcion,
            tbHito.FechaObjetivo,
            tbHito.IdResponsable,
            ISNULL(tbUsuario.NombreCompleto, N'Sin responsable') AS Responsable,
            tbHito.IdEstadoHito,
            tbEstadoHito.Nombre AS Estado,
            tbHito.FechaCumplimiento
            FROM tbHito
            INNER JOIN tbProyecto ON tbHito.IdProyecto = tbProyecto.IdProyecto
            INNER JOIN tbEstadoHito ON tbHito.IdEstadoHito = tbEstadoHito.IdEstadoHito
            LEFT JOIN tbUsuario ON tbHito.IdResponsable = tbUsuario.IdUsuario
            WHERE tbProyecto.IdResponsable = @IdGestor
            ORDER BY tbHito.FechaObjetivo, tbHito.Nombre";

            hitos = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return hitos;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdGestor", idGestor);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(hitos);
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

            return hitos;
        }

        public DataTable ObtenerEstadosHito()
        {
            string query;

            query = @"
            SELECT IdEstadoHito, Nombre
            FROM tbEstadoHito
            WHERE Activo = 1
            ORDER BY IdEstadoHito";

            return conexion.EjecutarConsulta(query);
        }

        public bool CrearHito()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object descripcionSql;
            object responsableSql;
            object fechaCumplimientoSql;
            bool creado;

            descripcionSql = DBNull.Value;
            responsableSql = DBNull.Value;
            fechaCumplimientoSql = DBNull.Value;

            if (string.IsNullOrEmpty(this.Descripcion) == false && string.IsNullOrEmpty(this.Descripcion.Trim()) == false)
            {
                descripcionSql = this.Descripcion.Trim();
            }

            if (this.IdResponsable.HasValue == true)
            {
                responsableSql = this.IdResponsable.Value;
            }

            if (this.FechaCumplimiento.HasValue == true)
            {
                fechaCumplimientoSql = this.FechaCumplimiento.Value.Date;
            }

            query = @"
            INSERT INTO tbHito
            (IdProyecto, Nombre, Descripcion, FechaObjetivo, IdResponsable, IdEstadoHito, FechaCumplimiento)
            VALUES
            (@IdProyecto, @Nombre, @Descripcion, @FechaObjetivo, @IdResponsable, @IdEstadoHito, @FechaCumplimiento)";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            creado = false;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
                comando.Parameters.AddWithValue("@Nombre", this.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", descripcionSql);
                comando.Parameters.AddWithValue("@FechaObjetivo", this.FechaObjetivo.Date);
                comando.Parameters.AddWithValue("@IdResponsable", responsableSql);
                comando.Parameters.AddWithValue("@IdEstadoHito", this.IdEstadoHito);
                comando.Parameters.AddWithValue("@FechaCumplimiento", fechaCumplimientoSql);
                comando.ExecuteNonQuery();
                comando.Dispose();
                creado = true;
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

            return creado;
        }

        public bool ActualizarHito()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object descripcionSql;
            object responsableSql;
            object fechaCumplimientoSql;
            bool actualizado;

            descripcionSql = DBNull.Value;
            responsableSql = DBNull.Value;
            fechaCumplimientoSql = DBNull.Value;

            if (string.IsNullOrEmpty(this.Descripcion) == false && string.IsNullOrEmpty(this.Descripcion.Trim()) == false)
            {
                descripcionSql = this.Descripcion.Trim();
            }

            if (this.IdResponsable.HasValue == true)
            {
                responsableSql = this.IdResponsable.Value;
            }

            if (this.FechaCumplimiento.HasValue == true)
            {
                fechaCumplimientoSql = this.FechaCumplimiento.Value.Date;
            }

            query = @"
            UPDATE tbHito
            SET IdProyecto = @IdProyecto,
            Nombre = @Nombre,
            Descripcion = @Descripcion,
            FechaObjetivo = @FechaObjetivo,
            IdResponsable = @IdResponsable,
            IdEstadoHito = @IdEstadoHito,
            FechaCumplimiento = @FechaCumplimiento
            WHERE IdHito = @IdHito";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            actualizado = false;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
                comando.Parameters.AddWithValue("@Nombre", this.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", descripcionSql);
                comando.Parameters.AddWithValue("@FechaObjetivo", this.FechaObjetivo.Date);
                comando.Parameters.AddWithValue("@IdResponsable", responsableSql);
                comando.Parameters.AddWithValue("@IdEstadoHito", this.IdEstadoHito);
                comando.Parameters.AddWithValue("@FechaCumplimiento", fechaCumplimientoSql);
                comando.Parameters.AddWithValue("@IdHito", this.IdHito);
                comando.ExecuteNonQuery();
                comando.Dispose();
                actualizado = true;
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

        public bool EliminarHito()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            bool eliminado;

            query = @"
            DELETE FROM tbHito
            WHERE IdHito = @IdHito";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            eliminado = false;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdHito", this.IdHito);
                comando.ExecuteNonQuery();
                comando.Dispose();
                eliminado = true;
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

            return eliminado;
        }
    }
}
