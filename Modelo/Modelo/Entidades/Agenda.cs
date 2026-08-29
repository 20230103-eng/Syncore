using System;
using System.Data;
using System.Data.SqlClient;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class Agenda
    {
        private DateTime fecha;
        private string actividad;
        private string tipo;
        private Conexion conexion;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Actividad
        {
            get { return actividad; }
            set { actividad = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Agenda()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerAgendaSemanalUsuario(int idUsuario, int cantidad)
        {
            DateTime fechaInicio;
            DateTime fechaFin;
            DataTable agenda;
            DataTable resultado;
            int contador;

            fechaInicio = DateTime.Today;
            fechaFin = fechaInicio.AddDays(7);
            agenda = ObtenerCalendarioUsuario(idUsuario, 0, fechaInicio, fechaFin, "Todos");
            resultado = agenda.Clone();
            contador = 0;

            foreach (DataRow fila in agenda.Rows)
            {
                if (contador >= cantidad)
                {
                    break;
                }

                resultado.ImportRow(fila);
                contador = contador + 1;
            }

            return resultado;
        }

        public DataTable ObtenerCalendarioUsuario(int idUsuario, int idProyecto, DateTime fechaInicio, DateTime fechaFin, string tipo)
        {
            DataTable agenda;
            DataTable tareas;
            DataTable hitos;

            agenda = CrearTablaAgenda();
            tareas = new DataTable();
            hitos = new DataTable();

            if (tipo == "Todos" || tipo == "Tarea")
            {
                tareas = ObtenerTareasCalendario(idUsuario, idProyecto, fechaInicio, fechaFin);
            }

            if (tipo == "Todos" || tipo == "Hito")
            {
                hitos = ObtenerHitosCalendario(idUsuario, idProyecto, fechaInicio, fechaFin);
            }

            foreach (DataRow fila in tareas.Rows)
            {
                agenda.Rows.Add(
                    Convert.ToDateTime(fila["Fecha"]),
                    fila["Actividad"].ToString(),
                    "Tarea",
                    fila["Proyecto"].ToString(),
                    fila["Estado"].ToString(),
                    Convert.ToInt32(fila["IdTarea"]),
                    Convert.ToInt32(fila["IdProyecto"]));
            }

            foreach (DataRow fila in hitos.Rows)
            {
                agenda.Rows.Add(
                    Convert.ToDateTime(fila["Fecha"]),
                    fila["Actividad"].ToString(),
                    "Hito",
                    fila["Proyecto"].ToString(),
                    fila["Estado"].ToString(),
                    0,
                    Convert.ToInt32(fila["IdProyecto"]));
            }

            DataView vista;

            vista = new DataView(agenda);
            vista.Sort = "Fecha ASC, Tipo ASC, Actividad ASC";
            return vista.ToTable();
        }

        private DataTable CrearTablaAgenda()
        {
            DataTable tabla;

            tabla = new DataTable();
            tabla.Columns.Add("Fecha", typeof(DateTime));
            tabla.Columns.Add("Actividad", typeof(string));
            tabla.Columns.Add("Tipo", typeof(string));
            tabla.Columns.Add("Proyecto", typeof(string));
            tabla.Columns.Add("Estado", typeof(string));
            tabla.Columns.Add("IdTarea", typeof(int));
            tabla.Columns.Add("IdProyecto", typeof(int));
            return tabla;
        }

        private DataTable ObtenerTareasCalendario(int idUsuario, int idProyecto, DateTime fechaInicio, DateTime fechaFin)
        {
            string query;
            DataTable tareas;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT
            tbTarea.IdTarea,
            tbTarea.IdProyecto,
            tbTarea.FechaLimite AS Fecha,
            tbTarea.Nombre AS Actividad,
            tbProyecto.Nombre AS Proyecto,
            tbEstadoTarea.Nombre AS Estado
            FROM tbTarea
            INNER JOIN tbProyecto ON tbTarea.IdProyecto = tbProyecto.IdProyecto
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = @IdUsuario
            AND (@IdProyecto = 0 OR tbTarea.IdProyecto = @IdProyecto)
            AND tbTarea.FechaLimite >= @FechaInicio
            AND tbTarea.FechaLimite <= @FechaFin
            ORDER BY tbTarea.FechaLimite";

            tareas = new DataTable();
            conexionSql = Conexion.conectar();

            if (conexionSql == null)
            {
                return tareas;
            }

            try
            {
                comando = new SqlCommand(query, conexionSql);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                comando.Parameters.AddWithValue("@FechaFin", fechaFin.Date);
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

            return tareas;
        }

        private DataTable ObtenerHitosCalendario(int idUsuario, int idProyecto, DateTime fechaInicio, DateTime fechaFin)
        {
            string query;
            DataTable hitos;
            SqlConnection conexionSql;
            SqlCommand comando;
            SqlDataAdapter adaptador;

            query = @"
            SELECT
            tbHito.IdProyecto,
            tbHito.FechaObjetivo AS Fecha,
            tbHito.Nombre AS Actividad,
            tbProyecto.Nombre AS Proyecto,
            tbEstadoHito.Nombre AS Estado
            FROM tbHito
            INNER JOIN tbProyecto ON tbHito.IdProyecto = tbProyecto.IdProyecto
            INNER JOIN tbEstadoHito ON tbHito.IdEstadoHito = tbEstadoHito.IdEstadoHito
            WHERE tbHito.IdResponsable = @IdUsuario
            AND (@IdProyecto = 0 OR tbHito.IdProyecto = @IdProyecto)
            AND tbHito.FechaObjetivo >= @FechaInicio
            AND tbHito.FechaObjetivo <= @FechaFin
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
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                comando.Parameters.AddWithValue("@FechaFin", fechaFin.Date);
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
    }
}
