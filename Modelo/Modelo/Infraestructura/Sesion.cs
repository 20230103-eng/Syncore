using Modelo.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelo.Infraestructura
{
    public static class Sesion
    {
        private static Usuario usuarioActual;

        public static Usuario UsuarioActual
        {
            get
            {
                return usuarioActual;
            }
        }

        public static void IniciarSesion(Usuario usuario)
        {
            usuarioActual = usuario;
        }

        public static void CerrarSesion()
        {
            usuarioActual = null;
        }
    }
}
