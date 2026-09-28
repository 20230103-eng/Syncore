using System;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmCambiarContrasena : Form
    {
        private bool validacionEnTiempoRealHabilitada;
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
        
            txtActual.TextChanged += CamposEnTiempoReal;
            txtActual.Leave += CamposEnTiempoReal;
            txtNueva.TextChanged += CamposEnTiempoReal;
            txtNueva.Leave += CamposEnTiempoReal;
            txtConfirmar.TextChanged += CamposEnTiempoReal;
            txtConfirmar.Leave += CamposEnTiempoReal;
            validacionEnTiempoRealHabilitada = true;
        }

        private bool ValidarDatos()
        {
            bool correcto;

            errorProviderValidacion.Clear();
            correcto = true;

            if (string.IsNullOrEmpty(txtActual.Text) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtActual, "ERR-VAL-001", "Ingrese la contraseña actual o la clave temporal.");
                correcto = false;
            }

            if (string.IsNullOrEmpty(txtNueva.Text) == true || txtNueva.Text.Length < 6)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtNueva, "ERR-VAL-003", "La nueva contraseña debe tener al menos 6 caracteres.");
                correcto = false;
            }

            if (txtNueva.Text != txtConfirmar.Text)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtConfirmar, "ERR-VAL-004", "Las contraseñas no coinciden.");
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
                CatalogoErrores.MostrarDetalle("ERR-NEG-001", "Syncore", "No hay una sesión activa.");
                return;
            }

            if (ValidarDatos() == false)
            {
                CatalogoErrores.MostrarDetalle("ERR-VAL-999", "Cambiar contraseña", "Revise los campos marcados.");
                return;
            }

            usuario = new Usuario();
            actualizado = usuario.CambiarContrasena(Sesion.UsuarioActual.IdUsuario, txtActual.Text, txtNueva.Text);

            if (actualizado == false)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtActual, "ERR-NEG-002", "La contraseña actual o clave temporal no es correcta.");
                CatalogoErrores.MostrarDetalle("ERR-NEG-002", "Cambiar contraseña", "La contraseña actual o clave temporal no es correcta.");
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
        private void CamposEnTiempoReal(object sender, EventArgs e)
        {
            if (validacionEnTiempoRealHabilitada == false)
            {
                return;
            }

            if (sender == txtActual)
            {
                if (string.IsNullOrEmpty(txtActual.Text) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtActual, "ERR-VAL-001", "Ingrese la contraseña actual o la clave temporal.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtActual, "");
                }
            }
            if (sender == txtNueva)
            {
                if (txtNueva.Text.Length < 6)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtNueva, "ERR-VAL-003", "La nueva contraseña debe tener al menos 6 caracteres.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtNueva, "");
                }
            }
            if (sender == txtConfirmar)
            {
                if (txtConfirmar.Text != txtNueva.Text)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtConfirmar, "ERR-VAL-004", "Las contraseñas no coinciden.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtConfirmar, "");
                }
            }
        
            if (sender == txtNueva && txtConfirmar.Text.Length > 0)
            {
                if (txtConfirmar.Text != txtNueva.Text)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtConfirmar, "ERR-VAL-004", "Las contraseñas no coinciden.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtConfirmar, "");
                }
            }
        }

    }
}
