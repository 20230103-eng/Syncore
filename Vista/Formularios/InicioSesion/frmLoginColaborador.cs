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
        private bool validacionEnTiempoRealHabilitada;
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
        
            txtUsuario.TextChanged += CamposEnTiempoReal;
            txtUsuario.Leave += CamposEnTiempoReal;
            txtContrasena.TextChanged += CamposEnTiempoReal;
            txtContrasena.Leave += CamposEnTiempoReal;
            validacionEnTiempoRealHabilitada = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            errorProviderValidacion.Clear();

            if (string.IsNullOrEmpty(nombreUsuario) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtUsuario, "ERR-VAL-001", "Ingrese el nombre de usuario.");
            }

            if (string.IsNullOrEmpty(contrasena) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtContrasena, "ERR-VAL-001", "Ingrese la contraseña.");
            }

            if (string.IsNullOrEmpty(nombreUsuario) == true || string.IsNullOrEmpty(contrasena) == true)
            {
                CatalogoErrores.MostrarDetalle("ERR-VAL-001", "Inicio de sesión", "Ingrese el usuario y la contraseña.");
                return;
            }

            foreach (char caracter in nombreUsuario)
            {
                if (char.IsLetterOrDigit(caracter) == false && caracter != '.' && caracter != '_' && caracter != '-')
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtUsuario, "ERR-VAL-002", "El nombre de usuario contiene caracteres no permitidos.");
                    CatalogoErrores.MostrarDetalle("ERR-VAL-002", "Inicio de sesión", "El nombre de usuario contiene caracteres no permitidos.");
                    txtUsuario.Focus();
                    return;
                }
            }

            Usuario usuario = usuarioModelo.ValidarUsuario(nombreUsuario, contrasena, "Colaborador");

            if (usuario == null)
            {
                CatalogoErrores.Mostrar("ERR-NEG-002", "Inicio de sesión");
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
                string recordado = ArchivosSeguros.LeerTexto(rutaUsuarioRecordado);
                if (recordado == null)
                {
                    return;
                }
                txtUsuario.Text = recordado;
                chkRecordar.Checked = true;
                txtContrasena.Focus();
            }
        }

        private void GuardarUsuarioRecordado(string nombreUsuario)
        {
            if (chkRecordar.Checked == true)
            {
                ArchivosSeguros.GuardarTexto(rutaUsuarioRecordado, nombreUsuario);
            }
            else if (File.Exists(rutaUsuarioRecordado) == true)
            {
                ArchivosSeguros.Eliminar(rutaUsuarioRecordado);
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

        private void CamposEnTiempoReal(object sender, EventArgs e)
        {
            if (validacionEnTiempoRealHabilitada == false)
            {
                return;
            }

            if (sender == txtUsuario)
            {
                bool formatoCorrecto;
                formatoCorrecto = true;
                foreach (char caracter in txtUsuario.Text)
                {
                    if (char.IsLetterOrDigit(caracter) == false && caracter != '.' && caracter != '_' && caracter != '-')
                    {
                        formatoCorrecto = false;
                    }
                }
                if (string.IsNullOrEmpty(txtUsuario.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtUsuario, "ERR-VAL-001", "Ingrese el nombre de usuario.");
                }
                else if (formatoCorrecto == false)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtUsuario, "ERR-VAL-002", "El usuario solo admite letras, números, punto, guion y guion bajo.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtUsuario, "");
                }
            }
            if (sender == txtContrasena)
            {
                if (string.IsNullOrEmpty(txtContrasena.Text) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtContrasena, "ERR-VAL-001", "Ingrese la contraseña.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtContrasena, "");
                }
            }
        }

    }
}
