using System.Data;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class EstadoTarea
    {
        private int idEstadoTarea;
        private string nombre;
        private Conexion conexion;

        public int IdEstadoTarea
        {
            get
            {
                return idEstadoTarea;
            }
            set
            {
                idEstadoTarea = value;
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

        public EstadoTarea()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerEstadosTarea()
        {
            string query;

            query = @"
            SELECT IdEstadoTarea, Nombre
            FROM tbEstadoTarea
            WHERE Activo = 1
            ORDER BY IdEstadoTarea";

            return conexion.EjecutarConsulta(query);
        }
    }
}
