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
            DataTable hitos;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            hitos = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return hitos;
            }

            try
            {
                comando = new SqlCommand("spReporteHitosGestor", conexionSql);
                comando.CommandType = CommandType.StoredProcedure;
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

        public DataTable ObtenerHitosGestorPagina(int idGestor, string texto,
            int idProyectoFiltro, int idEstadoFiltro, int pagina, out int total)
        {
            string consulta = @"
                SELECT h.IdHito, h.IdProyecto, h.Proyecto, h.Hito, h.Descripcion,
                    h.FechaObjetivo, h.IdResponsable, h.Responsable,
                    h.IdEstadoHito, h.Estado, h.FechaCumplimiento,
                    ISNULL(conteo.TareasVencidas, 0) AS TareasVencidas,
                    COUNT(*) OVER() AS TotalRegistros
                FROM vwReporteHitos h
                OUTER APPLY
                (
                    SELECT COUNT(*) AS TareasVencidas
                    FROM tbTarea t
                    INNER JOIN tbEstadoTarea e ON e.IdEstadoTarea = t.IdEstadoTarea
                    WHERE t.IdHito = h.IdHito AND t.FechaLimite < CONVERT(DATE, GETDATE())
                    AND e.Nombre IN (N'Pendiente', N'En progreso', N'Devuelta', N'Vencida')
                ) conteo
                WHERE h.IdGestor = @IdGestor
                    AND (@IdProyecto = 0 OR h.IdProyecto = @IdProyecto)
                    AND (@IdEstado = 0 OR h.IdEstadoHito = @IdEstado)
                    AND (@Texto = N'' OR h.Hito LIKE N'%' + @Texto + N'%'
                        OR h.Proyecto LIKE N'%' + @Texto + N'%'
                        OR h.Responsable LIKE N'%' + @Texto + N'%')
                ORDER BY h.FechaObjetivo, h.Hito, h.IdHito
                OFFSET @Inicio ROWS FETCH NEXT 20 ROWS ONLY";
            SqlParameter[] parametros =
            {
                new SqlParameter("@IdGestor", idGestor),
                new SqlParameter("@IdProyecto", idProyectoFiltro),
                new SqlParameter("@IdEstado", idEstadoFiltro),
                new SqlParameter("@Texto", texto)
            };
            return conexion.EjecutarPagina(consulta, parametros, pagina, out total);
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
        public DataTable ObtenerHitosProyectoReporte(int idProyecto)
        {
            string consulta = @"
                SELECT h.Nombre AS Hito, h.FechaObjetivo,
                    ISNULL(u.NombreCompleto, N'Sin asignar') AS Responsable,
                    eh.Nombre AS Estado
                FROM tbHito h
                LEFT JOIN tbUsuario u ON u.IdUsuario = h.IdResponsable
                INNER JOIN tbEstadoHito eh ON eh.IdEstadoHito = h.IdEstadoHito
                WHERE h.IdProyecto = @IdProyecto
                ORDER BY h.FechaObjetivo, h.IdHito";
            DataTable hitos = new DataTable();
            SqlConnection conexionSql = Conexion.conectar();
            if (conexionSql == null)
            {
                return hitos;
            }
            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexionSql))
                {
                    comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(hitos);
                    }
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
            return hitos;
        }

        public DataTable ObtenerHitosProximosProyectoPagina(int idProyecto, int pagina,
            int tamanoPagina, out int total)
        {
            string consulta = @"
                SELECT h.IdHito, h.Nombre AS Hito, h.FechaObjetivo,
                    ISNULL(u.NombreCompleto, N'Sin asignar') AS Responsable,
                    estado.Nombre AS Estado, COUNT(*) OVER() AS TotalRegistros
                FROM tbHito h
                LEFT JOIN tbUsuario u ON u.IdUsuario = h.IdResponsable
                INNER JOIN tbEstadoHito estado ON estado.IdEstadoHito = h.IdEstadoHito
                WHERE h.IdProyecto = @IdProyecto AND estado.Nombre <> N'Cumplido'
                ORDER BY h.FechaObjetivo, h.IdHito
                OFFSET @Inicio ROWS FETCH NEXT @Tamano ROWS ONLY";
            SqlParameter[] parametros = { new SqlParameter("@IdProyecto", idProyecto) };
            return new Conexion().EjecutarPaginaTamano(consulta, parametros, pagina, tamanoPagina, out total);
        }

    }
}
