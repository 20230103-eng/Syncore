using System.Data;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class Prioridad
    {
        private int idPrioridad;
        private string nombre;
        private Conexion conexion;

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

        public Prioridad()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerPrioridades()
        {
            string query;

            query = @"
            SELECT IdPrioridad, Nombre
            FROM tbPrioridad
            WHERE Activo = 1
            ORDER BY IdPrioridad";

            return conexion.EjecutarConsulta(query);
        }
    }
}
