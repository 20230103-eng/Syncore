using System.Data;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class RolProyecto
    {
        private int idRolProyecto;
        private string nombre;
        private string descripcion;
        private bool activo;
        private Conexion conexion;

        public int IdRolProyecto
        {
            get
            {
                return idRolProyecto;
            }
            set
            {
                idRolProyecto = value;
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

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        public bool Activo
        {
            get
            {
                return activo;
            }
            set
            {
                activo = value;
            }
        }

        public RolProyecto()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerRolesActivos()
        {
            string query;

            query = @"
            SELECT IdRolProyecto, Nombre
            FROM tbRolProyecto
            WHERE Activo = 1
            ORDER BY Nombre";

            return conexion.EjecutarConsulta(query);
        }
    }
}
