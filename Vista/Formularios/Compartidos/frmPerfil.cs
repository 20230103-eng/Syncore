using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Modelo.Modelo.Infraestructura;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmPerfil : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        public event EventHandler CerrarSesionSolicitada;
        public event EventHandler EmpresaActualizada;

        public frmPerfil()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(btnCerrarSesion, "Cerrar la sesión actual.");
            toolTipAyuda.SetToolTip(btnCambiarContrasena, "Cambiar la contraseña de la cuenta.");
            toolTipAyuda.SetToolTip(btnConfigurarEmpresa, "Actualizar los datos y el logotipo de la empresa.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            CargarDatosUsuario();
            CargarDatosEmpresa();
        }

        private void CargarDatosUsuario()
        {
            if (Sesion.UsuarioActual == null)
            {
                lblNombreValor.Text = "Sin sesión activa";
                lblUsuarioValor.Text = "-";
                lblRolValor.Text = "-";
                btnCerrarSesion.Enabled = false;
                return;
            }

            lblNombreValor.Text = Sesion.UsuarioActual.NombreCompleto;
            lblUsuarioValor.Text = Sesion.UsuarioActual.NombreUsuario;
            lblRolValor.Text = Sesion.UsuarioActual.TipoUsuario;
            btnConfigurarEmpresa.Visible = Sesion.UsuarioActual.TipoUsuario == "Gestor";
        }

        private void CargarDatosEmpresa()
        {
            ConfiguracionEmpresa modelo;
            ConfiguracionEmpresa empresa;
            Image anterior;

            modelo = new ConfiguracionEmpresa();
            empresa = modelo.ObtenerConfiguracion();
            if (empresa == null)
            {
                return;
            }

            lblSubtitulo.Text = empresa.NombreEmpresa;
            anterior = picLogoEmpresa.Image;
            picLogoEmpresa.Image = null;
            picLogoEmpresa.Visible = false;
            if (empresa.LogoImagen != null && empresa.LogoImagen.Length > 0)
            {
                using (MemoryStream flujo = new MemoryStream(empresa.LogoImagen))
                {
                    using (Image original = Image.FromStream(flujo))
                    {
                        picLogoEmpresa.Image = new Bitmap(original);
                    }
                }
                picLogoEmpresa.Visible = true;
                toolTipAyuda.SetToolTip(picLogoEmpresa, empresa.InformacionGeneral);
            }
            if (anterior != null)
            {
                anterior.Dispose();
            }
        }

        private void btnConfigurarEmpresa_Click(object sender, EventArgs e)
        {
            frmConfiguracionInicial formulario;
            DialogResult resultado;

            if (Sesion.UsuarioActual == null || Sesion.UsuarioActual.TipoUsuario != "Gestor")
            {
                return;
            }
            formulario = new frmConfiguracionInicial();
            resultado = formulario.ShowDialog(this);
            formulario.Dispose();
            if (resultado == DialogResult.OK)
            {
                CargarDatosEmpresa();
                if (EmpresaActualizada != null)
                {
                    EmpresaActualizada(this, EventArgs.Empty);
                }
            }
        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            frmCambiarContrasena formulario;

            formulario = new frmCambiarContrasena();
            formulario.ShowDialog(this);
            formulario.Dispose();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (CerrarSesionSolicitada != null)
            {
                CerrarSesionSolicitada(this, EventArgs.Empty);
            }
        }
    }
}
