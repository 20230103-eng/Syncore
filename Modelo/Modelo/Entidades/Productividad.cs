using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class Productividad
    {
        private int tareasCompletadas;
        private int porcentajeATiempo;
        private decimal diasPromedioCierre;
        private IndicadorUsuario indicadorUsuario;
        private Conexion conexion;

        public int TareasCompletadas
        {
            get
            {
                return tareasCompletadas;
            }
            set
            {
                tareasCompletadas = value;
            }
        }

        public int PorcentajeATiempo
        {
            get
            {
                return porcentajeATiempo;
            }
            set
            {
                porcentajeATiempo = value;
            }
        }

        public decimal DiasPromedioCierre
        {
            get
            {
                return diasPromedioCierre;
            }
            set
            {
                diasPromedioCierre = value;
            }
        }

        public Productividad()
        {
            conexion = new Conexion();
            indicadorUsuario = new IndicadorUsuario();
        }

        public int ContarTareasCompletadas(int dias)
        {
            DateTime fechaInicio;
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int cantidad;

            fechaInicio = DateTime.Today.AddDays(-dias);
            query = @"
            SELECT COUNT(*)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbEstadoTarea.Nombre = N'Completada'
            AND FechaCompletada >= @FechaInicio";

            cantidad = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return cantidad;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
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

        public int ContarTareasCompletadasUsuario(int idUsuario, int dias)
        {
            DateTime fechaInicio;
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int cantidad;

            fechaInicio = DateTime.Today.AddDays(-dias);
            query = @"
            SELECT COUNT(*)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = @IdUsuario
            AND tbEstadoTarea.Nombre = N'Completada'
            AND FechaCompletada >= @FechaInicio";

            cantidad = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return cantidad;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
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

        public int ContarTareasATiempo(int dias)
        {
            DateTime fechaInicio;
            string query;
            DataTable tareas;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;
            int cantidad;

            fechaInicio = DateTime.Today.AddDays(-dias);
            query = @"
            SELECT FechaLimite, FechaCompletada
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbEstadoTarea.Nombre = N'Completada'
            AND FechaCompletada >= @FechaInicio";

            tareas = new DataTable();
            cantidad = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return cantidad;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tareas);
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

            foreach (DataRow fila in tareas.Rows)
            {
                DateTime fechaLimite;
                DateTime fechaCompletada;

                fechaLimite = Convert.ToDateTime(fila["FechaLimite"]);
                fechaCompletada = Convert.ToDateTime(fila["FechaCompletada"]);

                if (fechaCompletada.Date <= fechaLimite.Date)
                {
                    cantidad = cantidad + 1;
                }
            }

            return cantidad;
        }

        public int ContarTareasATiempoUsuario(int idUsuario, int dias)
        {
            DateTime fechaInicio;
            string query;
            DataTable tareas;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;
            int cantidad;

            fechaInicio = DateTime.Today.AddDays(-dias);
            query = @"
            SELECT FechaLimite, FechaCompletada
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = @IdUsuario
            AND tbEstadoTarea.Nombre = N'Completada'
            AND FechaCompletada >= @FechaInicio";

            tareas = new DataTable();
            cantidad = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return cantidad;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tareas);
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

            foreach (DataRow fila in tareas.Rows)
            {
                DateTime fechaLimite;
                DateTime fechaCompletada;

                fechaLimite = Convert.ToDateTime(fila["FechaLimite"]);
                fechaCompletada = Convert.ToDateTime(fila["FechaCompletada"]);

                if (fechaCompletada.Date <= fechaLimite.Date)
                {
                    cantidad = cantidad + 1;
                }
            }

            return cantidad;
        }

        public int CalcularPorcentajeATiempo(int dias)
        {
            int completadas = ContarTareasCompletadas(dias);
            int aTiempo = ContarTareasATiempo(dias);
            int porcentaje = 0;

            if (completadas > 0)
            {
                porcentaje = aTiempo * 100 / completadas;
            }

            return porcentaje;
        }

        public int CalcularPorcentajeATiempoUsuario(int idUsuario, int dias)
        {
            int completadas = ContarTareasCompletadasUsuario(idUsuario, dias);
            int aTiempo = ContarTareasATiempoUsuario(idUsuario, dias);
            int porcentaje = 0;

            if (completadas > 0)
            {
                porcentaje = aTiempo * 100 / completadas;
            }

            return porcentaje;
        }

        public decimal CalcularDiasPromedioCierre(int dias)
        {
            DateTime fechaInicioPeriodo;
            string query;
            DataTable tareas;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;
            decimal sumaDias;
            decimal promedio;
            int cantidad;

            fechaInicioPeriodo = DateTime.Today.AddDays(-dias);
            query = @"
            SELECT FechaInicio, FechaCompletada
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbEstadoTarea.Nombre = N'Completada'
            AND FechaCompletada >= @FechaInicioPeriodo";

            tareas = new DataTable();
            sumaDias = 0;
            promedio = 0;
            cantidad = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return promedio;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@FechaInicioPeriodo", fechaInicioPeriodo.Date);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tareas);
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

            foreach (DataRow fila in tareas.Rows)
            {
                DateTime fechaInicio;
                DateTime fechaCompletada;
                TimeSpan diferencia;

                fechaInicio = Convert.ToDateTime(fila["FechaInicio"]);
                fechaCompletada = Convert.ToDateTime(fila["FechaCompletada"]);
                diferencia = fechaCompletada.Date - fechaInicio.Date;
                sumaDias = sumaDias + diferencia.Days;
                cantidad = cantidad + 1;
            }

            if (cantidad > 0)
            {
                promedio = sumaDias / cantidad;
            }

            return promedio;
        }

        public int CalcularCumplimientoUsuario(int idUsuario)
        {
            int tareas = indicadorUsuario.ContarTareasUsuario(idUsuario);
            int completadas = indicadorUsuario.ContarTareasUsuarioEstado(idUsuario, "Completada");
            int porcentaje = 0;

            if (tareas > 0)
            {
                porcentaje = completadas * 100 / tareas;
            }

            return porcentaje;
        }

        public DataTable ObtenerProductividadColaboradores(int dias)
        {
            DataTable colaboradores;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            colaboradores = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return colaboradores;
            }

            try
            {
                comando = new SqlCommand("spReporteProductividad", conexionSql);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Dias", dias);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(colaboradores);
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

            return colaboradores;
        }

        public DataTable ObtenerProductividadColaboradoresPagina(int dias, int pagina, out int total)
        {
            string consulta = @"
                DECLARE @Resultados TABLE
                (
                    IdUsuario INT, NombreCompleto NVARCHAR(200), Tareas INT,
                    PorcentajeATiempo INT, Cumplimiento INT, Tendencia NVARCHAR(30)
                );
                INSERT INTO @Resultados
                EXEC spReporteProductividad @Dias = @Dias;
                SELECT IdUsuario, NombreCompleto, Tareas, PorcentajeATiempo,
                    Cumplimiento, Tendencia, COUNT(*) OVER() AS TotalRegistros
                FROM @Resultados
                ORDER BY NombreCompleto, IdUsuario
                OFFSET @Inicio ROWS FETCH NEXT 20 ROWS ONLY";
            SqlParameter[] parametros = { new SqlParameter("@Dias", dias) };
            return new Conexion().EjecutarPagina(consulta, parametros, pagina, out total);
        }

        private int ContarTareasCompletadasUsuarioAnterior(int idUsuario, int dias)
        {
            int diasAnteriores;
            DateTime fechaInicio;
            DateTime fechaFin;
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int cantidad;

            diasAnteriores = dias * 2;
            fechaInicio = DateTime.Today.AddDays(-diasAnteriores);
            fechaFin = DateTime.Today.AddDays(-dias);
            query = @"
            SELECT COUNT(*)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = @IdUsuario
            AND tbEstadoTarea.Nombre = N'Completada'
            AND FechaCompletada >= @FechaInicio
            AND FechaCompletada < @FechaFin";

            cantidad = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return cantidad;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                comando.Parameters.AddWithValue("@FechaFin", fechaFin.Date);
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

        public DataTable ObtenerTendenciaSemanal(int dias)
        {
            DateTime fechaInicio;
            string query;
            DataTable tareas;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            fechaInicio = DateTime.Today.AddDays(-dias + 1);
            query = @"
            SELECT FechaCompletada
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbEstadoTarea.Nombre = N'Completada'
            AND FechaCompletada >= @FechaInicio";

            tareas = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql != null)
            {
                try
                {
                    comando = new SqlCommand(query, conexionSql);
                    comando.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                    adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tareas);
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
            }

            DataTable semanas = new DataTable();
            semanas.Columns.Add("Semana", typeof(string));
            semanas.Columns.Add("Cantidad", typeof(int));
            semanas.Rows.Add("S1", 0);
            semanas.Rows.Add("S2", 0);
            semanas.Rows.Add("S3", 0);
            semanas.Rows.Add("S4", 0);
            int tamanoSemana = dias / 4;

            if (tamanoSemana < 1)
            {
                tamanoSemana = 1;
            }

            foreach (DataRow fila in tareas.Rows)
            {
                DateTime fecha = Convert.ToDateTime(fila["FechaCompletada"]);
                int diferencia = (fecha.Date - fechaInicio.Date).Days;
                int indice = diferencia / tamanoSemana;

                if (indice < 0)
                {
                    indice = 0;
                }

                if (indice > 3)
                {
                    indice = 3;
                }

                int cantidad = Convert.ToInt32(semanas.Rows[indice]["Cantidad"]);
                semanas.Rows[indice]["Cantidad"] = cantidad + 1;
            }

            return semanas;
        }
        public DataTable ObtenerProductividadColaboradoresResumenPagina(int dias, int pagina, int tamanoPagina, out int total)
        {
            string consulta = @"
                DECLARE @Resultados TABLE
                (
                    IdUsuario INT, NombreCompleto NVARCHAR(200), Tareas INT,
                    PorcentajeATiempo INT, Cumplimiento INT, Tendencia NVARCHAR(30)
                );
                INSERT INTO @Resultados
                EXEC spReporteProductividad @Dias = @Dias;
                SELECT IdUsuario, NombreCompleto, Tareas, PorcentajeATiempo,
                    Cumplimiento, Tendencia, COUNT(*) OVER() AS TotalRegistros
                FROM @Resultados
                ORDER BY NombreCompleto, IdUsuario
                OFFSET @Inicio ROWS FETCH NEXT @Tamano ROWS ONLY";
            SqlParameter[] parametros = { new SqlParameter("@Dias", dias) };
            return new Conexion().EjecutarPaginaTamano(consulta, parametros, pagina, tamanoPagina, out total);
        }

    }
}
