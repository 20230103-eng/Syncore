using System;
using System.Data;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class TipoProyecto
    {
        private int idTipoProyecto;
        private string nombre;
        private bool activo;
        private Conexion conexion;

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

        public TipoProyecto()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerTiposProyecto()
        {
            string query = @"
            SELECT IdTipoProyecto, Nombre
            FROM tbTipoProyecto
            ORDER BY Nombre";

            return conexion.EjecutarConsulta(query);
        }
    }
}
