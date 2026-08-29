using System;
using System.Data;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class SeguimientoProyectoUsuario
    {
        private int idUsuario;
        private int idProyecto;
        private decimal avance;
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

        public decimal Avance
        {
            get
            {
                return avance;
            }
            set
            {
                avance = value;
            }
        }

        public SeguimientoProyectoUsuario()
        {
            conexion = new Conexion();
        }

        public int ContarTareasUsuarioProyecto(int idUsuario, int idProyecto)
        {
            string query = $@"
            SELECT COUNT(*)
            FROM tbTarea
            WHERE IdResponsable = {idUsuario}
            AND IdProyecto = {idProyecto}";

            DataTable datos = conexion.EjecutarConsulta(query);
            int cantidad = Convert.ToInt32(datos.Rows[0][0]);
            return cantidad;
        }

        public int ContarTareasVencidasUsuarioProyecto(int idUsuario, int idProyecto)
        {
            string query = $@"
            SELECT COUNT(*)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = {idUsuario}
            AND tbTarea.IdProyecto = {idProyecto}
            AND tbEstadoTarea.Nombre = N'Vencida'";

            DataTable datos = conexion.EjecutarConsulta(query);
            int cantidad = Convert.ToInt32(datos.Rows[0][0]);
            return cantidad;
        }

        public DateTime? ObtenerProximaFechaUsuarioProyecto(int idUsuario, int idProyecto)
        {
            string query = $@"
            SELECT MIN(FechaLimite)
            FROM tbTarea
            INNER JOIN tbEstadoTarea ON tbTarea.IdEstadoTarea = tbEstadoTarea.IdEstadoTarea
            WHERE tbTarea.IdResponsable = {idUsuario}
            AND tbTarea.IdProyecto = {idProyecto}
            AND tbEstadoTarea.Nombre <> N'Completada'";

            DataTable datos = conexion.EjecutarConsulta(query);
            DateTime? fecha = null;

            if (datos.Rows[0][0] != DBNull.Value)
            {
                fecha = Convert.ToDateTime(datos.Rows[0][0]);
            }

            return fecha;
        }

        public decimal ObtenerAvanceUsuarioProyecto(int idUsuario, int idProyecto)
        {
            string query = $@"
            SELECT ISNULL(AVG(AvanceActual), 0)
            FROM tbTarea
            WHERE IdResponsable = {idUsuario}
            AND IdProyecto = {idProyecto}";

            DataTable datos = conexion.EjecutarConsulta(query);
            decimal avance = Convert.ToDecimal(datos.Rows[0][0]);
            return avance;
        }
    }
}
