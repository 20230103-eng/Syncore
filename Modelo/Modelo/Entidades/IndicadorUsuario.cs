using System;
using System.Data;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class IndicadorUsuario
    {
        private int idUsuario;
        private decimal valor;
        private Conexion conexion;

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

        public decimal Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }

        public IndicadorUsuario()
        {
            conexion = new Conexion();
        }

        public int ContarTareasUsuarioEstado(int idUsuario, string estado)
        {
            estado = estado.Replace("'", "''");

            string query = $@"
            SELECT COUNT(*)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = {idUsuario}
            AND tbEstadoTarea.Nombre = '{estado}'";

            DataTable datos = conexion.EjecutarConsulta(query);
            int cantidad = Convert.ToInt32(datos.Rows[0][0]);
            return cantidad;
        }

        public int ContarTareasUsuario(int idUsuario)
        {
            string query = $@"
            SELECT COUNT(*)
            FROM tbTarea
            WHERE IdResponsable = {idUsuario}";

            DataTable datos = conexion.EjecutarConsulta(query);
            int cantidad = Convert.ToInt32(datos.Rows[0][0]);
            return cantidad;
        }

        public int ContarTareasAbiertasUsuario(int idUsuario)
        {
            string query = $@"
            SELECT COUNT(*)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = {idUsuario}
            AND tbEstadoTarea.Nombre IN ('Pendiente', 'En progreso', 'Devuelta')";

            DataTable datos = conexion.EjecutarConsulta(query);
            int cantidad = Convert.ToInt32(datos.Rows[0][0]);
            return cantidad;
        }

        public int ContarTareasPendientesAgrupadasUsuario(int idUsuario)
        {
            string query = $@"
            SELECT COUNT(*)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = {idUsuario}
            AND tbEstadoTarea.Nombre IN ('Pendiente', 'Devuelta', 'Vencida')";

            DataTable datos = conexion.EjecutarConsulta(query);
            int cantidad = Convert.ToInt32(datos.Rows[0][0]);
            return cantidad;
        }

        public int ContarTareasQueVencenSemanaUsuario(int idUsuario)
        {
            string query = $@"
            SELECT COUNT(*)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = {idUsuario}
            AND tbTarea.FechaLimite >= CAST(GETDATE() AS DATE)
            AND tbTarea.FechaLimite <= DATEADD(DAY, 7, CAST(GETDATE() AS DATE))
            AND tbEstadoTarea.Nombre NOT IN ('Completada', 'En revisión')";

            DataTable datos = conexion.EjecutarConsulta(query);
            int cantidad = Convert.ToInt32(datos.Rows[0][0]);
            return cantidad;
        }

        public decimal ObtenerAvancePromedioUsuario(int idUsuario)
        {
            string query = $@"
            SELECT ISNULL(AVG(AvanceActual), 0)
            FROM tbTarea
            WHERE IdResponsable = {idUsuario}";

            DataTable datos = conexion.EjecutarConsulta(query);
            decimal promedio = Convert.ToDecimal(datos.Rows[0][0]);
            return promedio;
        }
    }
}
