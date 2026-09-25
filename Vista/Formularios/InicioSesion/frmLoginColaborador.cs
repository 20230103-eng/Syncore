using System;
using System.IO;
using System.Windows.Forms;
using Modelo.Modelo;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmLoginColaborador : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;
        private System.Windows.Forms.ErrorProvider errorProviderValidacion;

        private Usuario usuarioModelo;
        private string rutaUsuarioRecordado;

        public frmLoginColaborador()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            errorProviderValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            errorProviderValidacion.ContainerControl = this;
            errorProviderValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            toolTipAyuda.SetToolTip(txtUsuario, "Ingrese nombre de usuario.");
            toolTipAyuda.SetToolTip(txtContrasena, "Ingrese contraseña.");
            toolTipAyuda.SetToolTip(chkRecordar, "Active esta opción para recordar el nombre de usuario.");
            toolTipAyuda.SetToolTip(btnCancelar, "Cancelar la operación actual.");
            toolTipAyuda.SetToolTip(btnIngresar, "Iniciar sesión con las credenciales ingresadas.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            usuarioModelo = new Usuario();
            rutaUsuarioRecordado = Application.UserAppDataPath + "\\usuario_colaborador.txt";
            CargarUsuarioRecordado();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            errorProviderValidacion.Clear();

            if (string.IsNullOrEmpty(nombreUsuario) == true)
            {
                errorProviderValidacion.SetError(txtUsuario, "Ingrese el nombre de usuario.");
            }

            if (string.IsNullOrEmpty(contrasena) == true)
            {
                errorProviderValidacion.SetError(txtContrasena, "Ingrese la contraseña.");
            }

            if (string.IsNullOrEmpty(nombreUsuario) == true || string.IsNullOrEmpty(contrasena) == true)
            {
                MessageBox.Show("Ingrese el usuario y la contraseña.", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario = usuarioModelo.ValidarUsuario(nombreUsuario, contrasena, "Colaborador");

            if (usuario == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Clear();
                txtContrasena.Focus();
                return;
            }

            GuardarUsuarioRecordado(nombreUsuario);
            Sesion.IniciarSesion(usuario);
            ReglasSistema reglas = new ReglasSistema();
            reglas.AplicarReglas();
            frmPrincipalColaborador formulario = new frmPrincipalColaborador();
            this.Hide();
            formulario.ShowDialog();

            if (formulario.CerrarSesionSolicitada == true)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void CargarUsuarioRecordado()
        {
            if (File.Exists(rutaUsuarioRecordado) == true)
            {
                txtUsuario.Text = File.ReadAllText(rutaUsuarioRecordado);
                chkRecordar.Checked = true;
                txtContrasena.Focus();
            }
        }

        private void GuardarUsuarioRecordado(string nombreUsuario)
        {
            if (chkRecordar.Checked == true)
            {
                File.WriteAllText(rutaUsuarioRecordado, nombreUsuario);
            }
            else if (File.Exists(rutaUsuarioRecordado) == true)
            {
                File.Delete(rutaUsuarioRecordado);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool permitido;

            permitido = false;

            if (char.IsControl(e.KeyChar) == true)
            {
                permitido = true;
            }
            else if (char.IsLetterOrDigit(e.KeyChar) == true)
            {
                permitido = true;
            }
            else if (e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '-')
            {
                permitido = true;
            }

            if (permitido == false)
            {
                e.Handled = true;
            }
        }

    }
}
