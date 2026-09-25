using System;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmCambiarContrasena : Form
    {
        private ToolTip toolTipAyuda;
        private ErrorProvider errorProviderValidacion;

        public frmCambiarContrasena()
        {
            InitializeComponent();
            toolTipAyuda = new ToolTip(this.components);
            errorProviderValidacion = new ErrorProvider(this.components);
            errorProviderValidacion.ContainerControl = this;
            errorProviderValidacion.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            toolTipAyuda.SetToolTip(txtActual, "Ingrese su contraseña actual o la clave temporal.");
            toolTipAyuda.SetToolTip(txtNueva, "Ingrese la nueva contraseña.");
            toolTipAyuda.SetToolTip(txtConfirmar, "Confirme la nueva contraseña.");
            toolTipAyuda.SetToolTip(btnGuardar, "Guardar la nueva contraseña.");
            toolTipAyuda.SetToolTip(btnCancelar, "Cancelar el cambio de contraseña.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private bool ValidarDatos()
        {
            bool correcto;

            errorProviderValidacion.Clear();
            correcto = true;

            if (string.IsNullOrEmpty(txtActual.Text) == true)
            {
                errorProviderValidacion.SetError(txtActual, "Ingrese la contraseña actual o la clave temporal.");
                correcto = false;
            }

            if (string.IsNullOrEmpty(txtNueva.Text) == true || txtNueva.Text.Length < 6)
            {
                errorProviderValidacion.SetError(txtNueva, "La nueva contraseña debe tener al menos 6 caracteres.");
                correcto = false;
            }

            if (txtNueva.Text != txtConfirmar.Text)
            {
                errorProviderValidacion.SetError(txtConfirmar, "Las contraseñas no coinciden.");
                correcto = false;
            }

            return correcto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            bool actualizado;

            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("No hay una sesión activa.");
                return;
            }

            if (ValidarDatos() == false)
            {
                MessageBox.Show("Revise los campos marcados.", "Cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            usuario = new Usuario();
            actualizado = usuario.CambiarContrasena(Sesion.UsuarioActual.IdUsuario, txtActual.Text, txtNueva.Text);

            if (actualizado == false)
            {
                errorProviderValidacion.SetError(txtActual, "La contraseña actual o clave temporal no es correcta.");
                MessageBox.Show("La contraseña actual o clave temporal no es correcta.", "Cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("La contraseña se actualizó correctamente.", "Cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
