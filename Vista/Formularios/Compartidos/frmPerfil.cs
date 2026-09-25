using System;
using System.Windows.Forms;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmPerfil : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        public event EventHandler CerrarSesionSolicitada;

        public frmPerfil()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(btnCerrarSesion, "Cerrar la sesión actual.");
            toolTipAyuda.SetToolTip(btnCambiarContrasena, "Cambiar la contraseña de la cuenta.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            CargarDatosUsuario();
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
