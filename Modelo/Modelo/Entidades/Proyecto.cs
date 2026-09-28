using System;
using System.Data;
using Modelo.Modelo;
using System.Data.SqlClient;

namespace Modelo.Modelo.Entidades
{
    public class Proyecto
    {
        private int idProyecto;
        private string codigo;
        private string nombre;
        private string objetivo;
        private string justificacion;
        private string alcance;
        private string resultadoEsperado;
        private string observaciones;
        private int idArea;
        private int idTipoProyecto;
        private int idResponsable;
        private int idPrioridad;
        private int idEstadoProyecto;
        private string prioridad;
        private string estado;
        private DateTime fechaInicio;
        private DateTime fechaCierreEstimada;
        private DateTime? fechaCierreReal;
        private decimal avancePlanificado;
        private DateTime fechaCreacion;
        private DateTime? ultimaModificacion;
        private Conexion conexion;

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

        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

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

        public string Objetivo
        {
            get
            {
                return objetivo;
            }
            set
            {
                objetivo = value;
            }
        }

        public string Justificacion
        {
            get
            {
                return justificacion;
            }
            set
            {
                justificacion = value;
            }
        }

        public string Alcance
        {
            get
            {
                return alcance;
            }
            set
            {
                alcance = value;
            }
        }

        public string ResultadoEsperado
        {
            get
            {
                return resultadoEsperado;
            }
            set
            {
                resultadoEsperado = value;
            }
        }

        public string Observaciones
        {
            get
            {
                return observaciones;
            }
            set
            {
                observaciones = value;
            }
        }

        public int IdArea
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

        public int IdTipoProyecto
        {
            get
            {
                return idTipoProyecto;
            }
            set
            {
                idTipoProyecto = value;
            }
        }

        public int IdResponsable
        {
            get
            {
                return idResponsable;
            }
            set
            {
                idResponsable = value;
            }
        }

        public int IdPrioridad
        {
            get
            {
                return idPrioridad;
            }
            set
            {
                idPrioridad = value;
            }
        }

        public int IdEstadoProyecto
        {
            get
            {
                return idEstadoProyecto;
            }
            set
            {
                idEstadoProyecto = value;
            }
        }

        public string Prioridad
        {
            get
            {
                return prioridad;
            }
            set
            {
                prioridad = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }

        public DateTime FechaInicio
        {
            get
            {
                return fechaInicio;
            }
            set
            {
                fechaInicio = value;
            }
        }

        public DateTime FechaCierreEstimada
        {
            get
            {
                return fechaCierreEstimada;
            }
            set
            {
                fechaCierreEstimada = value;
            }
        }

        public DateTime? FechaCierreReal
        {
            get
            {
                return fechaCierreReal;
            }
            set
            {
                fechaCierreReal = value;
            }
        }

        public decimal AvancePlanificado
        {
            get
            {
                return avancePlanificado;
            }
            set
            {
                avancePlanificado = value;
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

        public DateTime? UltimaModificacion
        {
            get
            {
                return ultimaModificacion;
            }
            set
            {
                ultimaModificacion = value;
            }
        }

        public Proyecto()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerResumenDashboard()
        {
            string consulta = @"
                SELECT ISNULL(SUM(CASE WHEN proyectos.Estado = N'Activo' THEN 1 ELSE 0 END), 0) AS ProyectosActivos,
                    ISNULL(SUM(CASE WHEN proyectos.AvanceReal < proyectos.AvancePlanificado THEN 1 ELSE 0 END), 0) AS ProyectosAtrasados,
                    ISNULL(AVG(proyectos.AvanceReal), 0) AS AvancePromedio
                FROM
                (
                    SELECT ep.Nombre AS Estado, ISNULL(tareas.AvanceReal, 0) AS AvanceReal,
                        CASE
                            WHEN CAST(GETDATE() AS DATE) <= p.FechaInicio THEN 0.0
                            WHEN CAST(GETDATE() AS DATE) >= p.FechaCierreEstimada THEN 100.0
                            WHEN DATEDIFF(DAY, p.FechaInicio, p.FechaCierreEstimada) > 0
                                THEN CAST(DATEDIFF(DAY, p.FechaInicio, CAST(GETDATE() AS DATE)) AS DECIMAL(18,4))
                                    * 100.0 / DATEDIFF(DAY, p.FechaInicio, p.FechaCierreEstimada)
                            ELSE 0.0
                        END AS AvancePlanificado
                    FROM tbProyecto p
                    INNER JOIN tbEstadoProyecto ep ON ep.IdEstadoProyecto = p.IdEstadoProyecto
                    OUTER APPLY
                    (
                        SELECT AVG(CAST(t.AvanceActual AS DECIMAL(10,2))) AS AvanceReal
                        FROM tbTarea t WHERE t.IdProyecto = p.IdProyecto
                    ) tareas
                    WHERE ep.Nombre <> N'Cerrado'
                ) proyectos";
            return conexion.EjecutarConsulta(consulta);
        }

        public DataTable ObtenerProyectosConAlertaPagina(int pagina, out int total)
        {
            string consulta = @"
                SELECT p.IdProyecto, p.Nombre AS Proyecto, a.Nombre AS Area,
                    ep.Nombre AS Estado, p.FechaCierreEstimada,
                    ISNULL(tareas.TareasVencidas, 0) AS TareasVencidas,
                    ISNULL(tareas.AvanceReal, 0) AS AvanceReal,
                    COUNT(*) OVER() AS TotalRegistros
                FROM tbProyecto p
                INNER JOIN tbArea a ON a.IdArea = p.IdArea
                INNER JOIN tbEstadoProyecto ep ON ep.IdEstadoProyecto = p.IdEstadoProyecto
                OUTER APPLY
                (
                    SELECT COUNT(CASE WHEN et.Nombre = N'Vencida' THEN 1 END) AS TareasVencidas,
                        AVG(CAST(t.AvanceActual AS DECIMAL(10,2))) AS AvanceReal
                    FROM tbTarea t
                    INNER JOIN tbEstadoTarea et ON et.IdEstadoTarea = t.IdEstadoTarea
                    WHERE t.IdProyecto = p.IdProyecto
                ) tareas
                WHERE ep.Nombre IN (N'Crítico', N'Observación')
                ORDER BY CASE WHEN ep.Nombre = N'Crítico' THEN 0 ELSE 1 END,
                    p.FechaCierreEstimada, p.IdProyecto
                OFFSET @Inicio ROWS FETCH NEXT 20 ROWS ONLY";
            return conexion.EjecutarPagina(consulta, new SqlParameter[0], pagina, out total);
        }

        public DataTable ObtenerAvancesProyectosPagina(int pagina, out int total)
        {
            string consulta = @"
                SELECT p.IdProyecto, p.Nombre AS Proyecto, ep.Nombre AS Estado,
                    ISNULL(tareas.AvanceReal, 0) AS AvanceReal,
                    COUNT(*) OVER() AS TotalRegistros
                FROM tbProyecto p
                INNER JOIN tbEstadoProyecto ep ON ep.IdEstadoProyecto = p.IdEstadoProyecto
                OUTER APPLY
                (
                    SELECT AVG(CAST(t.AvanceActual AS DECIMAL(10,2))) AS AvanceReal
                    FROM tbTarea t WHERE t.IdProyecto = p.IdProyecto
                ) tareas
                WHERE ep.Nombre <> N'Cerrado'
                ORDER BY p.Nombre, p.IdProyecto
                OFFSET @Inicio ROWS FETCH NEXT 20 ROWS ONLY";
            return conexion.EjecutarPagina(consulta, new SqlParameter[0], pagina, out total);
        }

        public DataTable ObtenerProyectosConAlerta()
        {
            string query = @"
            SELECT
            tbProyecto.IdProyecto,
            tbProyecto.Nombre AS Proyecto,
            tbArea.Nombre AS Area,
            tbProyecto.AvancePlanificado,
            tbEstadoProyecto.Nombre AS Estado,
            tbProyecto.FechaCierreEstimada
            FROM tbProyecto
            INNER JOIN tbArea ON tbProyecto.IdArea = tbArea.IdArea
            INNER JOIN tbEstadoProyecto ON tbProyecto.IdEstadoProyecto = tbEstadoProyecto.IdEstadoProyecto
            WHERE tbEstadoProyecto.Nombre = N'Crítico'
            OR tbEstadoProyecto.Nombre = N'Observación'";

            DataTable proyectos;

            proyectos = conexion.EjecutarConsulta(query);

            return proyectos;
        }

        public decimal ObtenerAvanceRealProyecto(int idProyecto)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            decimal avanceReal;

            query = @"
            SELECT ISNULL(AVG(AvanceActual), 0)
            FROM tbTarea
            WHERE IdProyecto = @IdProyecto";

            avanceReal = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return avanceReal;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado != null)
                {
                    avanceReal = Convert.ToDecimal(resultado);
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

            return avanceReal;
        }

        public decimal CalcularAvancePlanificado(DateTime fechaInicio, DateTime fechaCierre)
        {
            decimal avancePlanificado;
            double diasTotales;
            double diasTranscurridos;

            avancePlanificado = 0;

            if (DateTime.Today <= fechaInicio.Date)
            {
                return avancePlanificado;
            }

            if (DateTime.Today >= fechaCierre.Date)
            {
                return 100;
            }

            diasTotales = (fechaCierre.Date - fechaInicio.Date).TotalDays;
            diasTranscurridos = (DateTime.Today - fechaInicio.Date).TotalDays;

            if (diasTotales > 0)
            {
                avancePlanificado = Convert.ToDecimal(diasTranscurridos / diasTotales * 100);
            }

            if (avancePlanificado < 0)
            {
                avancePlanificado = 0;
            }

            if (avancePlanificado > 100)
            {
                avancePlanificado = 100;
            }

            return avancePlanificado;
        }

        public DataTable ObtenerAvancesProyectos()
        {
            string query = @"
            SELECT
            tbProyecto.IdProyecto,
            tbProyecto.Nombre AS Proyecto,
            tbProyecto.AvancePlanificado,
            tbProyecto.FechaInicio,
            tbProyecto.FechaCierreEstimada,
            tbEstadoProyecto.Nombre AS Estado
            FROM tbProyecto
            INNER JOIN tbEstadoProyecto ON tbProyecto.IdEstadoProyecto = tbEstadoProyecto.IdEstadoProyecto
            WHERE tbEstadoProyecto.Nombre <> N'Cerrado'
            ORDER BY tbProyecto.Nombre";

            DataTable proyectos;

            proyectos = conexion.EjecutarConsulta(query);
            proyectos.Columns.Add("AvanceReal", typeof(decimal));

            foreach (DataRow fila in proyectos.Rows)
            {
                int idProyecto;
                decimal avanceReal;
                decimal avancePlanificado;
                DateTime fechaInicio;
                DateTime fechaCierre;

                idProyecto = Convert.ToInt32(fila["IdProyecto"]);
                fechaInicio = Convert.ToDateTime(fila["FechaInicio"]);
                fechaCierre = Convert.ToDateTime(fila["FechaCierreEstimada"]);
                avanceReal = ObtenerAvanceRealProyecto(idProyecto);
                avancePlanificado = CalcularAvancePlanificado(fechaInicio, fechaCierre);
                fila["AvanceReal"] = avanceReal;
                fila["AvancePlanificado"] = avancePlanificado;
            }

            return proyectos;
        }

        public DataTable ObtenerProyectosUsuario(int idUsuario)
        {
            string query;
            DataTable proyectos;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT DISTINCT
            tbProyecto.IdProyecto,
            tbProyecto.Nombre AS Proyecto,
            tbUsuario.NombreCompleto AS Responsable,
            tbEstadoProyecto.Nombre AS Estado,
            tbProyecto.FechaCierreEstimada
            FROM tbProyecto
            INNER JOIN tbUsuario ON tbProyecto.IdResponsable = tbUsuario.IdUsuario
            INNER JOIN tbEstadoProyecto ON tbProyecto.IdEstadoProyecto = tbEstadoProyecto.IdEstadoProyecto
            LEFT JOIN tbEquipoProyecto ON tbProyecto.IdProyecto = tbEquipoProyecto.IdProyecto
            LEFT JOIN tbTarea ON tbProyecto.IdProyecto = tbTarea.IdProyecto
            WHERE tbEstadoProyecto.Nombre <> N'Cerrado'
            AND ((tbEquipoProyecto.IdUsuario = @IdUsuario AND tbEquipoProyecto.Activo = 1)
            OR tbTarea.IdResponsable = @IdUsuario)
            ORDER BY tbProyecto.FechaCierreEstimada";

            proyectos = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return proyectos;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(proyectos);
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

            return proyectos;
        }

        public DataTable ObtenerCatalogoProyectosUsuario(int idUsuario)
        {
            string query;
            DataTable proyectos;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT DISTINCT tbProyecto.IdProyecto, tbProyecto.Nombre AS Proyecto
            FROM tbProyecto
            INNER JOIN tbEstadoProyecto ON tbProyecto.IdEstadoProyecto = tbEstadoProyecto.IdEstadoProyecto
            LEFT JOIN tbEquipoProyecto ON tbProyecto.IdProyecto = tbEquipoProyecto.IdProyecto
            LEFT JOIN tbTarea ON tbProyecto.IdProyecto = tbTarea.IdProyecto
            WHERE tbEstadoProyecto.Nombre <> N'Cerrado'
            AND
            (
                (tbEquipoProyecto.IdUsuario = @IdUsuario AND tbEquipoProyecto.Activo = 1)
                OR tbTarea.IdResponsable = @IdUsuario
            )
            ORDER BY tbProyecto.Nombre";

            proyectos = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return proyectos;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(proyectos);
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

            return proyectos;
        }

        public DataTable ObtenerCatalogoProyectosResponsable(int idResponsable)
        {
            string query;
            DataTable proyectos;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT tbProyecto.IdProyecto, tbProyecto.Nombre AS Proyecto
            FROM tbProyecto
            INNER JOIN tbEstadoProyecto ON tbProyecto.IdEstadoProyecto = tbEstadoProyecto.IdEstadoProyecto
            WHERE tbProyecto.IdResponsable = @IdResponsable
            AND tbEstadoProyecto.Nombre <> N'Cerrado'
            ORDER BY tbProyecto.Nombre";

            proyectos = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return proyectos;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdResponsable", idResponsable);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(proyectos);
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

            return proyectos;
        }

        public DataTable ObtenerListadoProyectos()
        {
            string query;

            query = @"
            SELECT IdProyecto, Codigo, Proyecto, Tipo, Area,
                   Responsable, Estado, Prioridad, Avance
            FROM vwReporteProyectos
            ORDER BY FechaCreacion DESC, IdProyecto DESC";

            return conexion.EjecutarConsulta(query);
        }

        public DataTable ObtenerCatalogoProyectos()
        {
            string query = @"
            SELECT tbProyecto.IdProyecto, tbProyecto.Nombre AS Proyecto
            FROM tbProyecto
            INNER JOIN tbEstadoProyecto ON tbProyecto.IdEstadoProyecto = tbEstadoProyecto.IdEstadoProyecto
            WHERE tbEstadoProyecto.Nombre <> N'Cerrado'
            ORDER BY tbProyecto.Nombre";

            return conexion.EjecutarConsulta(query);
        }

        public bool ExisteCodigoProyecto(string codigo)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int cantidad;

            query = @"
            SELECT COUNT(*)
            FROM tbProyecto
            WHERE Codigo = @Codigo";

            cantidad = 0;
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@Codigo", codigo);
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

        public bool CrearProyecto()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlTransaction transaccion;
            object justificacion;
            object alcance;
            object observaciones;
            bool creado;
            object resultado;
            int idRolCoordinador;
            int gestorValido;

            justificacion = this.Justificacion;
            alcance = this.Alcance;
            observaciones = this.Observaciones;

            if (string.IsNullOrEmpty(this.Justificacion) == true || string.IsNullOrEmpty(this.Justificacion.Trim()) == true)
            {
                justificacion = DBNull.Value;
            }

            if (string.IsNullOrEmpty(this.Alcance) == true || string.IsNullOrEmpty(this.Alcance.Trim()) == true)
            {
                alcance = DBNull.Value;
            }

            if (string.IsNullOrEmpty(this.Observaciones) == true || string.IsNullOrEmpty(this.Observaciones.Trim()) == true)
            {
                observaciones = DBNull.Value;
            }

            query = @"
            INSERT INTO tbProyecto
            (Codigo, Nombre, Objetivo, Justificacion, Alcance, ResultadoEsperado, Observacion, IdArea, IdTipoProyecto, IdResponsable, IdPrioridad, IdEstadoProyecto, FechaInicio, FechaCierreEstimada, FechaCierreReal, AvancePlanificado, FechaCreacion, UltimaModificacion)
            VALUES
            (@Codigo, @Nombre, @Objetivo, @Justificacion, @Alcance, @ResultadoEsperado, @Observacion, @IdArea, @IdTipoProyecto, @IdResponsable, @IdPrioridad, (SELECT TOP 1 IdEstadoProyecto FROM tbEstadoProyecto WHERE Nombre = N'Activo'), @FechaInicio, @FechaCierreEstimada, NULL, @AvancePlanificado, GETDATE(), NULL);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            transaccion = null;
            creado = false;

            try
            {
                transaccion = conexionSql.BeginTransaction();

                comando = new SqlCommand(@"
                    SELECT COUNT(*)
                    FROM tbUsuario
                    INNER JOIN tbTipoUsuario ON tbUsuario.IdTipoUsuario = tbTipoUsuario.IdTipoUsuario
                    WHERE tbUsuario.IdUsuario = @IdResponsable
                    AND tbUsuario.Activo = 1
                    AND tbTipoUsuario.Nombre = N'Gestor'", conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdResponsable", this.IdResponsable);
                gestorValido = Convert.ToInt32(comando.ExecuteScalar());
                comando.Dispose();

                if (gestorValido == 0)
                {
                    transaccion.Rollback();
                    return false;
                }

                comando = new SqlCommand(@"
                    SELECT TOP 1 IdRolProyecto
                    FROM tbRolProyecto
                    WHERE Nombre = N'Coordinador' AND Activo = 1", conexionSql, transaccion);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado == null || resultado == DBNull.Value)
                {
                    transaccion.Rollback();
                    return false;
                }

                idRolCoordinador = Convert.ToInt32(resultado);
                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@Codigo", this.Codigo);
                comando.Parameters.AddWithValue("@Nombre", this.Nombre);
                comando.Parameters.AddWithValue("@Objetivo", this.Objetivo);
                comando.Parameters.AddWithValue("@Justificacion", justificacion);
                comando.Parameters.AddWithValue("@Alcance", alcance);
                comando.Parameters.AddWithValue("@ResultadoEsperado", this.ResultadoEsperado);
                comando.Parameters.AddWithValue("@Observacion", observaciones);
                comando.Parameters.AddWithValue("@IdArea", this.IdArea);
                comando.Parameters.AddWithValue("@IdTipoProyecto", this.IdTipoProyecto);
                comando.Parameters.AddWithValue("@IdResponsable", this.IdResponsable);
                comando.Parameters.AddWithValue("@IdPrioridad", this.IdPrioridad);
                comando.Parameters.AddWithValue("@FechaInicio", this.FechaInicio.Date);
                comando.Parameters.AddWithValue("@FechaCierreEstimada", this.FechaCierreEstimada.Date);
                comando.Parameters.AddWithValue("@AvancePlanificado", this.AvancePlanificado);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado == null || resultado == DBNull.Value)
                {
                    transaccion.Rollback();
                    return false;
                }

                this.IdProyecto = Convert.ToInt32(resultado);

                comando = new SqlCommand(@"
                    INSERT INTO tbEquipoProyecto
                    (IdProyecto, IdUsuario, IdRolProyecto, FechaAsignacion, Activo)
                    VALUES
                    (@IdProyecto, @IdResponsable, @IdRolProyecto, GETDATE(), 1)", conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
                comando.Parameters.AddWithValue("@IdResponsable", this.IdResponsable);
                comando.Parameters.AddWithValue("@IdRolProyecto", idRolCoordinador);
                comando.ExecuteNonQuery();
                comando.Dispose();

                transaccion.Commit();
                creado = true;
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
                creado = false;
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

            return creado;
        }


        public DataTable ObtenerProyectoPorId(int idProyecto)
        {
            string query;
            DataTable proyecto;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT
            tbProyecto.IdProyecto,
            tbProyecto.Codigo,
            tbProyecto.Nombre,
            tbProyecto.Objetivo,
            tbProyecto.Justificacion,
            tbProyecto.Alcance,
            tbProyecto.ResultadoEsperado,
            tbProyecto.Observacion AS Observaciones,
            tbProyecto.IdArea,
            tbProyecto.IdTipoProyecto,
            tbProyecto.IdResponsable,
            tbProyecto.IdPrioridad,
            tbProyecto.IdEstadoProyecto,
            tbPrioridad.Nombre AS Prioridad,
            tbEstadoProyecto.Nombre AS Estado,
            tbProyecto.FechaInicio,
            tbProyecto.FechaCierreEstimada,
            tbProyecto.FechaCierreReal,
            tbProyecto.AvancePlanificado,
            tbProyecto.FechaCreacion,
            tbProyecto.UltimaModificacion
            FROM tbProyecto
            INNER JOIN tbPrioridad ON tbProyecto.IdPrioridad = tbPrioridad.IdPrioridad
            INNER JOIN tbEstadoProyecto ON tbProyecto.IdEstadoProyecto = tbEstadoProyecto.IdEstadoProyecto
            WHERE tbProyecto.IdProyecto = @IdProyecto";

            proyecto = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return proyecto;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(proyecto);
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

            return proyecto;
        }

        public DataTable ObtenerDetalleProyecto(int idProyecto)
        {
            string query;
            DataTable proyecto;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT
            tbProyecto.IdProyecto,
            tbProyecto.Codigo,
            tbProyecto.Nombre AS Proyecto,
            tbProyecto.Objetivo,
            tbProyecto.ResultadoEsperado,
            tbArea.Nombre AS Area,
            tbTipoProyecto.Nombre AS TipoProyecto,
            tbUsuario.NombreCompleto AS Responsable,
            tbPrioridad.Nombre AS Prioridad,
            tbEstadoProyecto.Nombre AS Estado,
            tbProyecto.FechaInicio,
            tbProyecto.FechaCierreEstimada,
            tbProyecto.FechaCierreReal,
            tbProyecto.AvancePlanificado
            FROM tbProyecto
            INNER JOIN tbArea ON tbProyecto.IdArea = tbArea.IdArea
            INNER JOIN tbTipoProyecto ON tbProyecto.IdTipoProyecto = tbTipoProyecto.IdTipoProyecto
            INNER JOIN tbUsuario ON tbProyecto.IdResponsable = tbUsuario.IdUsuario
            INNER JOIN tbPrioridad ON tbProyecto.IdPrioridad = tbPrioridad.IdPrioridad
            INNER JOIN tbEstadoProyecto ON tbProyecto.IdEstadoProyecto = tbEstadoProyecto.IdEstadoProyecto
            WHERE tbProyecto.IdProyecto = @IdProyecto";

            proyecto = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return proyecto;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(proyecto);
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

            return proyecto;
        }

        public bool ExisteCodigoProyectoEnOtroProyecto(string codigo, int idProyecto)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            object resultado;
            int cantidad;

            query = @"
            SELECT COUNT(*)
            FROM tbProyecto
            WHERE Codigo = @Codigo
            AND IdProyecto <> @IdProyecto";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            cantidad = 0;

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@Codigo", codigo);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
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

            if (cantidad > 0)
            {
                return true;
            }

            return false;
        }

        public bool ActualizarProyecto(int idGestorActual)
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlTransaction transaccion;
            object resultado;
            int idRolCoordinador;
            int gestorValido;
            int filasEquipo;
            object justificacion;
            object alcance;
            object observaciones;
            bool actualizado;

            justificacion = this.Justificacion;
            alcance = this.Alcance;
            observaciones = this.Observaciones;

            if (string.IsNullOrEmpty(this.Justificacion) == true || string.IsNullOrEmpty(this.Justificacion.Trim()) == true)
            {
                justificacion = DBNull.Value;
            }

            if (string.IsNullOrEmpty(this.Alcance) == true || string.IsNullOrEmpty(this.Alcance.Trim()) == true)
            {
                alcance = DBNull.Value;
            }

            if (string.IsNullOrEmpty(this.Observaciones) == true || string.IsNullOrEmpty(this.Observaciones.Trim()) == true)
            {
                observaciones = DBNull.Value;
            }

            query = @"
            UPDATE tbProyecto
            SET Codigo = @Codigo,
            Nombre = @Nombre,
            Objetivo = @Objetivo,
            Justificacion = @Justificacion,
            Alcance = @Alcance,
            ResultadoEsperado = @ResultadoEsperado,
            Observacion = @Observacion,
            IdArea = @IdArea,
            IdTipoProyecto = @IdTipoProyecto,
            IdResponsable = @IdResponsable,
            IdPrioridad = @IdPrioridad,
            FechaInicio = @FechaInicio,
            FechaCierreEstimada = @FechaCierreEstimada,
            UltimaModificacion = GETDATE()
            WHERE IdProyecto = @IdProyecto AND IdResponsable = @IdGestorActual";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            transaccion = null;
            actualizado = false;

            try
            {
                transaccion = conexionSql.BeginTransaction();

                comando = new SqlCommand(@"
                    SELECT COUNT(*)
                    FROM tbUsuario
                    INNER JOIN tbTipoUsuario ON tbUsuario.IdTipoUsuario = tbTipoUsuario.IdTipoUsuario
                    WHERE tbUsuario.IdUsuario = @IdResponsable
                    AND tbUsuario.Activo = 1
                    AND tbTipoUsuario.Nombre = N'Gestor'", conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdResponsable", this.IdResponsable);
                gestorValido = Convert.ToInt32(comando.ExecuteScalar());
                comando.Dispose();

                if (gestorValido == 0)
                {
                    transaccion.Rollback();
                    return false;
                }

                comando = new SqlCommand(@"
                    SELECT TOP 1 IdRolProyecto
                    FROM tbRolProyecto
                    WHERE Nombre = N'Coordinador' AND Activo = 1", conexionSql, transaccion);
                resultado = comando.ExecuteScalar();
                comando.Dispose();

                if (resultado == null || resultado == DBNull.Value)
                {
                    transaccion.Rollback();
                    return false;
                }

                idRolCoordinador = Convert.ToInt32(resultado);
                comando = new SqlCommand(query, conexionSql, transaccion);
                comando.Parameters.AddWithValue("@Codigo", this.Codigo);
                comando.Parameters.AddWithValue("@Nombre", this.Nombre);
                comando.Parameters.AddWithValue("@Objetivo", this.Objetivo);
                comando.Parameters.AddWithValue("@Justificacion", justificacion);
                comando.Parameters.AddWithValue("@Alcance", alcance);
                comando.Parameters.AddWithValue("@ResultadoEsperado", this.ResultadoEsperado);
                comando.Parameters.AddWithValue("@Observacion", observaciones);
                comando.Parameters.AddWithValue("@IdArea", this.IdArea);
                comando.Parameters.AddWithValue("@IdTipoProyecto", this.IdTipoProyecto);
                comando.Parameters.AddWithValue("@IdResponsable", this.IdResponsable);
                comando.Parameters.AddWithValue("@IdPrioridad", this.IdPrioridad);
                comando.Parameters.AddWithValue("@FechaInicio", this.FechaInicio.Date);
                comando.Parameters.AddWithValue("@FechaCierreEstimada", this.FechaCierreEstimada.Date);
                comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
                comando.Parameters.AddWithValue("@IdGestorActual", idGestorActual);
                actualizado = comando.ExecuteNonQuery() > 0;
                comando.Dispose();

                if (actualizado == false)
                {
                    transaccion.Rollback();
                    return false;
                }

                comando = new SqlCommand(@"
                    UPDATE tbEquipoProyecto
                    SET Activo = 1, IdRolProyecto = @IdRolProyecto
                    WHERE IdProyecto = @IdProyecto AND IdUsuario = @IdResponsable", conexionSql, transaccion);
                comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
                comando.Parameters.AddWithValue("@IdResponsable", this.IdResponsable);
                comando.Parameters.AddWithValue("@IdRolProyecto", idRolCoordinador);
                filasEquipo = comando.ExecuteNonQuery();
                comando.Dispose();

                if (filasEquipo == 0)
                {
                    comando = new SqlCommand(@"
                        INSERT INTO tbEquipoProyecto
                        (IdProyecto, IdUsuario, IdRolProyecto, FechaAsignacion, Activo)
                        VALUES
                        (@IdProyecto, @IdResponsable, @IdRolProyecto, GETDATE(), 1)", conexionSql, transaccion);
                    comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
                    comando.Parameters.AddWithValue("@IdResponsable", this.IdResponsable);
                    comando.Parameters.AddWithValue("@IdRolProyecto", idRolCoordinador);
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                }

                transaccion.Commit();
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
                actualizado = false;
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

            return actualizado;
        }


        private bool EsProyectoCerrado(SqlConnection conexionSql, SqlTransaction transaccion)
        {
            string query;
            SqlCommand comando;
            object resultado;
            int cantidad;

            query = @"
            SELECT COUNT(*)
            FROM tbProyecto
            WHERE IdProyecto = @IdProyecto
            AND IdEstadoProyecto = (SELECT TOP 1 IdEstadoProyecto FROM tbEstadoProyecto WHERE Nombre = N'Cerrado')";

            comando = new SqlCommand(query, conexionSql, transaccion);
            comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
            resultado = comando.ExecuteScalar();
            comando.Dispose();
            cantidad = Convert.ToInt32(resultado);

            if (cantidad > 0)
            {
                return true;
            }

            return false;
        }

        private void EjecutarEliminacionProyecto(SqlConnection conexionSql, SqlTransaction transaccion, string query)
        {
            SqlCommand comando;

            comando = new SqlCommand(query, conexionSql, transaccion);
            comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
            comando.ExecuteNonQuery();
            comando.Dispose();
        }

        public bool EliminarProyectoCerrado()
        {
            SqlConnection conexionSql;
            SqlTransaction transaccion;
            bool cerrado;
            bool eliminado;

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            transaccion = null;
            eliminado = false;

            try
            {
                transaccion = conexionSql.BeginTransaction();
                cerrado = EsProyectoCerrado(conexionSql, transaccion);

                if (cerrado == true)
                {
                    EjecutarEliminacionProyecto(conexionSql, transaccion, @"
                    DELETE FROM tbEvidencia
                    WHERE IdAvance IN
                    (
                        SELECT tbAvance.IdAvance
                        FROM tbAvance
                        INNER JOIN tbTarea ON tbAvance.IdTarea = tbTarea.IdTarea
                        WHERE tbTarea.IdProyecto = @IdProyecto
                    )");

                    EjecutarEliminacionProyecto(conexionSql, transaccion, @"
                    DELETE FROM tbRevisionTarea
                    WHERE IdTarea IN
                    (
                        SELECT IdTarea
                        FROM tbTarea
                        WHERE IdProyecto = @IdProyecto
                    )");

                    EjecutarEliminacionProyecto(conexionSql, transaccion, @"
                    DELETE FROM tbComentarioTarea
                    WHERE IdTarea IN
                    (
                        SELECT IdTarea
                        FROM tbTarea
                        WHERE IdProyecto = @IdProyecto
                    )");

                    EjecutarEliminacionProyecto(conexionSql, transaccion, @"
                    DELETE FROM tbNotificacion
                    WHERE IdProyecto = @IdProyecto
                    OR IdTarea IN
                    (
                        SELECT IdTarea
                        FROM tbTarea
                        WHERE IdProyecto = @IdProyecto
                    )");

                    EjecutarEliminacionProyecto(conexionSql, transaccion, @"
                    DELETE FROM tbAvance
                    WHERE IdTarea IN
                    (
                        SELECT IdTarea
                        FROM tbTarea
                        WHERE IdProyecto = @IdProyecto
                    )");

                    EjecutarEliminacionProyecto(conexionSql, transaccion, @"
                    DELETE FROM tbTarea
                    WHERE IdProyecto = @IdProyecto");

                    EjecutarEliminacionProyecto(conexionSql, transaccion, @"
                    DELETE FROM tbHito
                    WHERE IdProyecto = @IdProyecto");

                    EjecutarEliminacionProyecto(conexionSql, transaccion, @"
                    DELETE FROM tbEquipoProyecto
                    WHERE IdProyecto = @IdProyecto");

                    EjecutarEliminacionProyecto(conexionSql, transaccion, @"
                    DELETE FROM tbProyecto
                    WHERE IdProyecto = @IdProyecto
                    AND IdEstadoProyecto = (SELECT TOP 1 IdEstadoProyecto FROM tbEstadoProyecto WHERE Nombre = N'Cerrado')");

                    transaccion.Commit();
                    eliminado = true;
                }
                else
                {
                    transaccion.Rollback();
                }
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
                eliminado = false;
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

            return eliminado;
        }

        public bool CerrarProyecto()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
            bool cerrado;

            query = @"
            UPDATE tbProyecto
            SET IdEstadoProyecto = (SELECT TOP 1 IdEstadoProyecto FROM tbEstadoProyecto WHERE Nombre = N'Cerrado'),
            FechaCierreReal = @FechaCierreReal,
            UltimaModificacion = GETDATE()
            WHERE IdProyecto = @IdProyecto";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@FechaCierreReal", DateTime.Today);
                comando.Parameters.AddWithValue("@IdProyecto", this.IdProyecto);
                cerrado = comando.ExecuteNonQuery() > 0;
                comando.Dispose();
            }
            catch (SqlException ex)
            {
                Conexion.MostrarErrorSql(ex);
                cerrado = false;
            }
            finally
            {
                conexionSql.Close();
                conexionSql.Dispose();
            }

            return cerrado;
        }
        public DataTable ObtenerFiltrosListadoProyectos()
        {
            return conexion.EjecutarConsulta(@"SELECT DISTINCT Area, Responsable, Tipo FROM vwReporteProyectos");
        }

        public DataTable ObtenerListadoProyectosPagina(string texto, string estado,
            string area, string responsable, string prioridad, string tipo, int pagina)
        {
            DataTable proyectos = new DataTable();
            SqlConnection conexionSql = Conexion.conectar();
            if (conexionSql == null)
            {
                return proyectos;
            }
            string query = @"
                WITH Filtrados AS
                (
                    SELECT IdProyecto, Codigo, Proyecto, Tipo, Area, Responsable,
                        Estado, Prioridad, Avance, FechaCreacion
                    FROM vwReporteProyectos
                    WHERE (@Texto = N'' OR Codigo LIKE N'%' + @Texto + N'%'
                        OR Proyecto LIKE N'%' + @Texto + N'%')
                        AND ((@Estado = N'Todos los visibles' AND Estado <> N'Cerrado')
                             OR (@Estado <> N'Todos los visibles' AND Estado = @Estado))
                        AND (@Area = N'' OR Area = @Area)
                        AND (@Responsable = N'' OR Responsable = @Responsable)
                        AND (@Prioridad = N'' OR Prioridad = @Prioridad)
                        AND (@Tipo = N'' OR Tipo = @Tipo)
                )
                SELECT IdProyecto, Codigo, Proyecto, Tipo, Area, Responsable,
                    Estado, Prioridad, Avance, COUNT(*) OVER() AS TotalRegistros
                FROM Filtrados
                ORDER BY FechaCreacion DESC, IdProyecto DESC
                OFFSET @Inicio ROWS FETCH NEXT 20 ROWS ONLY";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, conexionSql))
                {
                    comando.Parameters.AddWithValue("@Texto", texto);
                    comando.Parameters.AddWithValue("@Estado", estado);
                    comando.Parameters.AddWithValue("@Area", area);
                    comando.Parameters.AddWithValue("@Responsable", responsable);
                    comando.Parameters.AddWithValue("@Prioridad", prioridad);
                    comando.Parameters.AddWithValue("@Tipo", tipo);
                    comando.Parameters.AddWithValue("@Inicio", Math.Max(0, pagina) * 20);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(proyectos);
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
            return proyectos;
        }

        public DataTable ObtenerReporteProyectosPagina(int pagina, out int total)
        {
            string consulta = @"
                SELECT IdProyecto, Codigo, Proyecto, Tipo, Area, Responsable,
                    Estado, Prioridad, Avance, COUNT(*) OVER() AS TotalRegistros
                FROM vwReporteProyectos
                ORDER BY FechaCreacion DESC, IdProyecto DESC
                OFFSET @Inicio ROWS FETCH NEXT 20 ROWS ONLY";
            return new Conexion().EjecutarPagina(consulta,
                new SqlParameter[0], pagina, out total);
        }

        public DataTable ObtenerProyectosUsuarioPagina(int idUsuario, string texto,
            string estado, int filtroFecha, int pagina, int idInicial)
        {
            DataTable proyectos = new DataTable();
            SqlConnection conexionSql = Conexion.conectar();
            if (conexionSql == null)
            {
                return proyectos;
            }
            string query = @"
                WITH Filtrados AS
                (
                    SELECT p.IdProyecto, p.Nombre AS Proyecto, u.NombreCompleto AS Responsable,
                        ep.Nombre AS Estado, p.FechaCierreEstimada
                    FROM tbProyecto p
                    INNER JOIN tbUsuario u ON u.IdUsuario = p.IdResponsable
                    INNER JOIN tbEstadoProyecto ep ON ep.IdEstadoProyecto = p.IdEstadoProyecto
                    WHERE ep.Nombre <> N'Cerrado'
                        AND (EXISTS (SELECT 1 FROM tbEquipoProyecto e WHERE e.IdProyecto = p.IdProyecto
                            AND e.IdUsuario = @IdUsuario AND e.Activo = 1)
                            OR EXISTS (SELECT 1 FROM tbTarea t WHERE t.IdProyecto = p.IdProyecto
                                AND t.IdResponsable = @IdUsuario))
                        AND (@IdInicial = 0 OR p.IdProyecto = @IdInicial)
                        AND (@Texto = N'' OR p.Nombre LIKE N'%' + @Texto + N'%'
                            OR u.NombreCompleto LIKE N'%' + @Texto + N'%')
                        AND (@Estado = N'Todos los estados' OR ep.Nombre = @Estado)
                        AND (@FiltroFecha = 0 OR
                            (p.FechaCierreEstimada >= @Hoy AND
                            ((@FiltroFecha = 1 AND p.FechaCierreEstimada <= @Hasta7)
                            OR (@FiltroFecha = 2 AND p.FechaCierreEstimada <= @Hasta30))))
                )
                SELECT *, COUNT(*) OVER() AS TotalRegistros
                FROM Filtrados
                ORDER BY FechaCierreEstimada ASC, IdProyecto DESC
                OFFSET @Inicio ROWS FETCH NEXT 20 ROWS ONLY";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, conexionSql))
                {
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@Texto", texto);
                    comando.Parameters.AddWithValue("@Estado", estado);
                    comando.Parameters.AddWithValue("@FiltroFecha", filtroFecha);
                    comando.Parameters.AddWithValue("@IdInicial", idInicial);
                    comando.Parameters.AddWithValue("@Hoy", DateTime.Today);
                    comando.Parameters.AddWithValue("@Hasta7", DateTime.Today.AddDays(7));
                    comando.Parameters.AddWithValue("@Hasta30", DateTime.Today.AddDays(30));
                    comando.Parameters.AddWithValue("@Inicio", Math.Max(0, pagina) * 20);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(proyectos);
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
            return proyectos;
        }

        public DataTable ObtenerProyectosUsuarioResumenPagina(int idUsuario, int pagina, int tamanoPagina, out int total)
        {
            string consulta = @"
                SELECT p.IdProyecto, p.Nombre AS Proyecto,
                    u.NombreCompleto AS Responsable, ep.Nombre AS Estado,
                    p.FechaCierreEstimada, COUNT(*) OVER() AS TotalRegistros
                FROM tbProyecto p
                INNER JOIN tbUsuario u ON u.IdUsuario = p.IdResponsable
                INNER JOIN tbEstadoProyecto ep ON ep.IdEstadoProyecto = p.IdEstadoProyecto
                WHERE ep.Nombre <> N'Cerrado' AND
                    (EXISTS (SELECT 1 FROM tbEquipoProyecto e
                        WHERE e.IdProyecto = p.IdProyecto AND e.IdUsuario = @IdUsuario AND e.Activo = 1)
                    OR EXISTS (SELECT 1 FROM tbTarea t
                        WHERE t.IdProyecto = p.IdProyecto AND t.IdResponsable = @IdUsuario))
                ORDER BY p.FechaCierreEstimada, p.IdProyecto
                OFFSET @Inicio ROWS FETCH NEXT @Tamano ROWS ONLY";
            SqlParameter[] parametros = { new SqlParameter("@IdUsuario", idUsuario) };
            return new Conexion().EjecutarPaginaTamano(consulta, parametros, pagina, tamanoPagina, out total);
        }

        public DataTable ObtenerAvancesProyectosResumenPagina(int pagina, int tamanoPagina, out int total)
        {
            string consulta = @"
                SELECT IdProyecto, Proyecto, Avance AS AvanceReal,
                    COUNT(*) OVER() AS TotalRegistros
                FROM vwReporteProyectos
                WHERE Estado <> N'Cerrado'
                ORDER BY Proyecto, IdProyecto
                OFFSET @Inicio ROWS FETCH NEXT @Tamano ROWS ONLY";
            return new Conexion().EjecutarPaginaTamano(consulta, new SqlParameter[0], pagina, tamanoPagina, out total);
        }

    }
}
