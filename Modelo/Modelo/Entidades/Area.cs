using System;
using System.Data;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class Area
    {
        private int idArea;
        private string nombre;
        private bool activo;
        private Conexion conexion;

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

        public Area()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerAreas()
        {
            string query = @"
            SELECT IdArea, Nombre
            FROM tbArea
            ORDER BY Nombre";

            return conexion.EjecutarConsulta(query);
        }
    }
}
