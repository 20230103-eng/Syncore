using System;
using System.Data;
using Modelo.Modelo;

namespace Modelo.Modelo.Entidades
{
    public class TipoUsuario
    {
        private int idTipoUsuario;
        private string nombre;
        private string descripcion;
        private Conexion conexion;

        public int IdTipoUsuario
        {
            get
            {
                return idTipoUsuario;
            }
            set
            {
                idTipoUsuario = value;
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

        public TipoUsuario()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerTiposUsuario()
        {
            string query;

            query = @"
            SELECT IdTipoUsuario, Nombre
            FROM tbTipoUsuario
            ORDER BY IdTipoUsuario";

            return conexion.EjecutarConsulta(query);
        }
    }
}
