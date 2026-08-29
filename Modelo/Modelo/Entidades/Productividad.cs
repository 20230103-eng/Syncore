using System;
using System.Data;
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
            DateTime fechaInicio = DateTime.Today.AddDays(-dias);

            string query = $@"
            SELECT COUNT(*)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbEstadoTarea.Nombre = N'Completada'
            AND FechaCompletada >= '{fechaInicio:yyyyMMdd}'";

            DataTable datos = conexion.EjecutarConsulta(query);
            int cantidad = 0;

            if (datos.Rows.Count > 0)
            {
                cantidad = Convert.ToInt32(datos.Rows[0][0]);
            }

            return cantidad;
        }

        public int ContarTareasCompletadasUsuario(int idUsuario, int dias)
        {
            DateTime fechaInicio = DateTime.Today.AddDays(-dias);

            string query = $@"
            SELECT COUNT(*)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = {idUsuario}
            AND tbEstadoTarea.Nombre = N'Completada'
            AND FechaCompletada >= '{fechaInicio:yyyyMMdd}'";

            DataTable datos = conexion.EjecutarConsulta(query);
            int cantidad = 0;

            if (datos.Rows.Count > 0)
            {
                cantidad = Convert.ToInt32(datos.Rows[0][0]);
            }

            return cantidad;
        }

        public int ContarTareasATiempo(int dias)
        {
            DateTime fechaInicio = DateTime.Today.AddDays(-dias);

            string query = $@"
            SELECT FechaLimite, FechaCompletada
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbEstadoTarea.Nombre = N'Completada'
            AND FechaCompletada >= '{fechaInicio:yyyyMMdd}'";

            DataTable tareas = conexion.EjecutarConsulta(query);
            int cantidad = 0;

            foreach (DataRow fila in tareas.Rows)
            {
                DateTime fechaLimite = Convert.ToDateTime(fila["FechaLimite"]);
                DateTime fechaCompletada = Convert.ToDateTime(fila["FechaCompletada"]);

                if (fechaCompletada.Date <= fechaLimite.Date)
                {
                    cantidad = cantidad + 1;
                }
            }

            return cantidad;
        }

        public int ContarTareasATiempoUsuario(int idUsuario, int dias)
        {
            DateTime fechaInicio = DateTime.Today.AddDays(-dias);

            string query = $@"
            SELECT FechaLimite, FechaCompletada
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = {idUsuario}
            AND tbEstadoTarea.Nombre = N'Completada'
            AND FechaCompletada >= '{fechaInicio:yyyyMMdd}'";

            DataTable tareas = conexion.EjecutarConsulta(query);
            int cantidad = 0;

            foreach (DataRow fila in tareas.Rows)
            {
                DateTime fechaLimite = Convert.ToDateTime(fila["FechaLimite"]);
                DateTime fechaCompletada = Convert.ToDateTime(fila["FechaCompletada"]);

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
            DateTime fechaInicioPeriodo = DateTime.Today.AddDays(-dias);

            string query = $@"
            SELECT FechaInicio, FechaCompletada
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbEstadoTarea.Nombre = N'Completada'
            AND FechaCompletada >= '{fechaInicioPeriodo:yyyyMMdd}'";

            DataTable tareas = conexion.EjecutarConsulta(query);
            decimal sumaDias = 0;
            decimal promedio = 0;
            int cantidad = 0;

            foreach (DataRow fila in tareas.Rows)
            {
                DateTime fechaInicio = Convert.ToDateTime(fila["FechaInicio"]);
                DateTime fechaCompletada = Convert.ToDateTime(fila["FechaCompletada"]);
                TimeSpan diferencia = fechaCompletada.Date - fechaInicio.Date;
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
            string query = $@"
            SELECT tbUsuario.IdUsuario, tbUsuario.NombreCompleto
            FROM tbUsuario
            INNER JOIN tbTipoUsuario ON tbUsuario.IdTipoUsuario = tbTipoUsuario.IdTipoUsuario
            WHERE tbTipoUsuario.Nombre = N'Colaborador'
            AND tbUsuario.Activo = 1
            ORDER BY tbUsuario.NombreCompleto";

            DataTable colaboradores = conexion.EjecutarConsulta(query);
            colaboradores.Columns.Add("Tareas", typeof(int));
            colaboradores.Columns.Add("PorcentajeATiempo", typeof(int));
            colaboradores.Columns.Add("Cumplimiento", typeof(int));
            colaboradores.Columns.Add("Tendencia", typeof(string));

            foreach (DataRow fila in colaboradores.Rows)
            {
                int idUsuario = Convert.ToInt32(fila["IdUsuario"]);
                int tareas = indicadorUsuario.ContarTareasUsuario(idUsuario);
                int porcentajeATiempo = CalcularPorcentajeATiempoUsuario(idUsuario, dias);
                int cumplimiento = porcentajeATiempo;
                int completadasActuales = ContarTareasCompletadasUsuario(idUsuario, dias);
                int completadasAnteriores = ContarTareasCompletadasUsuarioAnterior(idUsuario, dias);
                string tendencia = "Estable";

                if (completadasActuales > completadasAnteriores)
                {
                    tendencia = "Alta";
                }
                else if (completadasActuales < completadasAnteriores)
                {
                    tendencia = "Baja";
                }

                fila["Tareas"] = tareas;
                fila["PorcentajeATiempo"] = porcentajeATiempo;
                fila["Cumplimiento"] = cumplimiento;
                fila["Tendencia"] = tendencia;
            }

            return colaboradores;
        }

        private int ContarTareasCompletadasUsuarioAnterior(int idUsuario, int dias)
        {
            int diasAnteriores = dias * 2;
            DateTime fechaInicio = DateTime.Today.AddDays(-diasAnteriores);
            DateTime fechaFin = DateTime.Today.AddDays(-dias);

            string query = $@"
            SELECT COUNT(*)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = {idUsuario}
            AND tbEstadoTarea.Nombre = N'Completada'
            AND FechaCompletada >= '{fechaInicio:yyyyMMdd}'
            AND FechaCompletada < '{fechaFin:yyyyMMdd}'";

            DataTable datos = conexion.EjecutarConsulta(query);
            int cantidad = 0;

            if (datos.Rows.Count > 0)
            {
                cantidad = Convert.ToInt32(datos.Rows[0][0]);
            }

            return cantidad;
        }

        public DataTable ObtenerTendenciaSemanal(int dias)
        {
            DateTime fechaInicio = DateTime.Today.AddDays(-dias + 1);

            string query = $@"
            SELECT FechaCompletada
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbEstadoTarea.Nombre = N'Completada'
            AND FechaCompletada >= '{fechaInicio:yyyyMMdd}'";

            DataTable tareas = conexion.EjecutarConsulta(query);
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
    }
}
