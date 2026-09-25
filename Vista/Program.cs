using System;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ConfiguracionEmpresa configuracion;
            Usuario usuario;
            frmConfiguracionInicial formularioConfiguracion;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            configuracion = new ConfiguracionEmpresa();
            usuario = new Usuario();

            if (configuracion.ExisteConfiguracion() == false || usuario.ExisteGestorActivo() == false)
            {
                formularioConfiguracion = new frmConfiguracionInicial();

                if (formularioConfiguracion.ShowDialog() != DialogResult.OK)
                {
                    formularioConfiguracion.Dispose();
                    return;
                }

                formularioConfiguracion.Dispose();
            }

            Application.Run(new frmSeleccionRol());
        }
    }
}
