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
            DataTable proyectos;

            query = @"
            SELECT
            tbProyecto.IdProyecto,
            tbProyecto.Codigo,
            tbProyecto.Nombre AS Proyecto,
            ISNULL(tbTipoProyecto.Nombre, N'Sin tipo') AS Tipo,
            tbArea.Nombre AS Area,
            tbUsuario.NombreCompleto AS Responsable,
            tbEstadoProyecto.Nombre AS Estado,
            tbPrioridad.Nombre AS Prioridad
            FROM tbProyecto
            INNER JOIN tbArea ON tbProyecto.IdArea = tbArea.IdArea
            INNER JOIN tbUsuario ON tbProyecto.IdResponsable = tbUsuario.IdUsuario
            INNER JOIN tbPrioridad ON tbProyecto.IdPrioridad = tbPrioridad.IdPrioridad
            INNER JOIN tbEstadoProyecto ON tbProyecto.IdEstadoProyecto = tbEstadoProyecto.IdEstadoProyecto
            LEFT JOIN tbTipoProyecto ON tbProyecto.IdTipoProyecto = tbTipoProyecto.IdTipoProyecto
            ORDER BY tbProyecto.FechaCreacion DESC";

            proyectos = conexion.EjecutarConsulta(query);
            proyectos.Columns.Add("Avance", typeof(decimal));

            foreach (DataRow fila in proyectos.Rows)
            {
                int idProyecto;
                decimal avanceReal;

                idProyecto = Convert.ToInt32(fila["IdProyecto"]);
                avanceReal = ObtenerAvanceRealProyecto(idProyecto);
                fila["Avance"] = avanceReal;
            }

            return proyectos;
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
            object justificacion;
            object alcance;
            object observaciones;
            bool creado;

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
            (@Codigo, @Nombre, @Objetivo, @Justificacion, @Alcance, @ResultadoEsperado, @Observacion, @IdArea, @IdTipoProyecto, @IdResponsable, @IdPrioridad, (SELECT TOP 1 IdEstadoProyecto FROM tbEstadoProyecto WHERE Nombre = N'Activo'), @FechaInicio, @FechaCierreEstimada, NULL, @AvancePlanificado, GETDATE(), NULL)";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
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
                comando.ExecuteNonQuery();
                comando.Dispose();
                creado = true;
            }
            catch (SqlException ex)
            {
                Conexion.MostrarErrorSql(ex);
                creado = false;
            }
            finally
            {
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

        public bool ActualizarProyecto()
        {
            string query;
            SqlConnection conexionSql;
            SqlCommand comando;
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
            WHERE IdProyecto = @IdProyecto";

            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return false;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
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
                actualizado = comando.ExecuteNonQuery() > 0;
                comando.Dispose();
            }
            catch (SqlException ex)
            {
                Conexion.MostrarErrorSql(ex);
                actualizado = false;
            }
            finally
            {
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

            transaccion = conexionSql.BeginTransaction();
            eliminado = false;

            try
            {
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
                transaccion.Rollback();
                Conexion.MostrarErrorSql(ex);
                eliminado = false;
            }
            finally
            {
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
    }
}
