using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmSeleccionRol : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        public frmSeleccionRol()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(btnGestor, "Ingresar al sistema como Gestor.");
            toolTipAyuda.SetToolTip(btnColaborador, "Ingresar al sistema como Colaborador.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            CargarEmpresa();
        }


        private void CargarEmpresa()
        {
            ConfiguracionEmpresa modelo;
            ConfiguracionEmpresa configuracion;
            Image anterior;

            modelo = new ConfiguracionEmpresa();
            configuracion = modelo.ObtenerConfiguracion();
            anterior = picLogoEmpresa.Image;
            picLogoEmpresa.Image = null;
            picLogoEmpresa.Visible = false;
            if (anterior != null)
            {
                anterior.Dispose();
            }

            if (configuracion != null && string.IsNullOrEmpty(configuracion.NombreEmpresa) == false)
            {
                lblBienvenido.Text = "Bienvenido a " + configuracion.NombreEmpresa;
                if (configuracion.LogoImagen != null && configuracion.LogoImagen.Length > 0)
                {
                    using (MemoryStream flujo = new MemoryStream(configuracion.LogoImagen))
                    {
                        using (Image original = Image.FromStream(flujo))
                        {
                            picLogoEmpresa.Image = new Bitmap(original);
                        }
                    }
                    picLogoEmpresa.Visible = true;
                }
            }
        }

        private void btnGestor_Click(object sender, EventArgs e)
        {
            frmLoginGestor formulario = new frmLoginGestor();

            this.Hide();
            formulario.ShowDialog();
            formulario.Dispose();

            if (this.IsDisposed == false)
            {
                CargarEmpresa();
                this.Show();
            }
        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            frmLoginColaborador formulario = new frmLoginColaborador();

            this.Hide();
            formulario.ShowDialog();
            formulario.Dispose();

            if (this.IsDisposed == false)
            {
                CargarEmpresa();
                this.Show();
            }
        }
    }
}
