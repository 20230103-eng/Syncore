using System;
using System.IO;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmConfiguracionInicial : Form
    {
        private ToolTip toolTipAyuda;
        private ErrorProvider errorProviderValidacion;
        private ConfiguracionEmpresa configuracionModelo;
        private Usuario usuarioModelo;
        private bool requiereAdministrador;
        private byte[] logoSeleccionado;

        public frmConfiguracionInicial()
        {
            InitializeComponent();
            toolTipAyuda = new ToolTip(this.components);
            errorProviderValidacion = new ErrorProvider(this.components);
            errorProviderValidacion.ContainerControl = this;
            errorProviderValidacion.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            toolTipAyuda.SetToolTip(txtNombreEmpresa, "Ingrese el nombre de la empresa.");
            toolTipAyuda.SetToolTip(txtInformacionGeneral, "Ingrese información general de la empresa.");
            toolTipAyuda.SetToolTip(txtRutaLogo, "Ruta del logotipo seleccionado.");
            toolTipAyuda.SetToolTip(btnExaminar, "Seleccionar el logotipo de la empresa.");
            toolTipAyuda.SetToolTip(txtNombreAdministrador, "Ingrese el nombre completo del primer administrador.");
            toolTipAyuda.SetToolTip(txtUsuarioAdministrador, "Ingrese el nombre de usuario del primer administrador.");
            toolTipAyuda.SetToolTip(txtContrasena, "Ingrese la contraseña del primer administrador.");
            toolTipAyuda.SetToolTip(txtConfirmarContrasena, "Confirme la contraseña.");
            toolTipAyuda.SetToolTip(btnGuardar, "Guardar la configuración inicial.");
            toolTipAyuda.SetToolTip(btnSalir, "Salir sin guardar la configuración.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void frmConfiguracionInicial_Load(object sender, EventArgs e)
        {
            configuracionModelo = new ConfiguracionEmpresa();
            usuarioModelo = new Usuario();
            ConfiguracionEmpresa actual;
            actual = configuracionModelo.ObtenerConfiguracion();
            if (actual != null)
            {
                txtNombreEmpresa.Text = actual.NombreEmpresa;
                txtRutaLogo.Text = actual.RutaLogo;
                txtInformacionGeneral.Text = actual.InformacionGeneral;
                logoSeleccionado = actual.LogoImagen;
            }
            requiereAdministrador = usuarioModelo.ExisteGestorActivo() == false;
            pnlAdministrador.Enabled = requiereAdministrador;

            if (requiereAdministrador == false)
            {
                lblEstadoAdministrador.Text = "Ya existe un usuario Gestor. Solo se configurará la empresa.";
            }
            else
            {
                lblEstadoAdministrador.Text = "Debe registrar el primer usuario administrador del sistema.";
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selector;
            DialogResult resultado;

            selector = new OpenFileDialog();
            selector.Title = "Seleccionar logotipo";
            selector.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg;*.bmp";
            resultado = selector.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                FileInfo archivo;
                archivo = new FileInfo(selector.FileName);
                if (archivo.Length > 2097152)
                {
                    MessageBox.Show("El logotipo no debe superar 2 MB.", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    selector.Dispose();
                    return;
                }
                byte[] imagen;
                bool formatoValido;
                imagen = File.ReadAllBytes(selector.FileName);
                formatoValido = false;
                if (imagen.Length > 8)
                {
                    if (imagen[0] == 137 && imagen[1] == 80 && imagen[2] == 78 && imagen[3] == 71)
                    {
                        formatoValido = true;
                    }
                    else if (imagen[0] == 255 && imagen[1] == 216 && imagen[2] == 255)
                    {
                        formatoValido = true;
                    }
                    else if (imagen[0] == 66 && imagen[1] == 77)
                    {
                        formatoValido = true;
                    }
                }
                if (formatoValido == false)
                {
                    MessageBox.Show("Seleccione una imagen PNG, JPEG o BMP válida.", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    selector.Dispose();
                    return;
                }
                logoSeleccionado = imagen;
                txtRutaLogo.Text = selector.FileName;
            }

            selector.Dispose();
        }

        private bool ValidarDatos()
        {
            bool correcto;

            errorProviderValidacion.Clear();
            correcto = true;

            if (string.IsNullOrEmpty(txtNombreEmpresa.Text.Trim()) == true)
            {
                errorProviderValidacion.SetError(txtNombreEmpresa, "Ingrese el nombre de la empresa.");
                correcto = false;
            }

            if (string.IsNullOrEmpty(txtRutaLogo.Text.Trim()) == true && logoSeleccionado == null)
            {
                errorProviderValidacion.SetError(txtRutaLogo, "Seleccione el logotipo de la empresa.");
                correcto = false;
            }

            if (string.IsNullOrEmpty(txtInformacionGeneral.Text.Trim()) == true)
            {
                errorProviderValidacion.SetError(txtInformacionGeneral, "Ingrese la información general.");
                correcto = false;
            }

            if (requiereAdministrador == true)
            {
                if (string.IsNullOrEmpty(txtNombreAdministrador.Text.Trim()) == true)
                {
                    errorProviderValidacion.SetError(txtNombreAdministrador, "Ingrese el nombre completo.");
                    correcto = false;
                }

                if (string.IsNullOrEmpty(txtUsuarioAdministrador.Text.Trim()) == true)
                {
                    errorProviderValidacion.SetError(txtUsuarioAdministrador, "Ingrese el nombre de usuario.");
                    correcto = false;
                }

                if (string.IsNullOrEmpty(txtContrasena.Text) == true || txtContrasena.Text.Length < 6)
                {
                    errorProviderValidacion.SetError(txtContrasena, "La contraseña debe tener al menos 6 caracteres.");
                    correcto = false;
                }

                if (txtContrasena.Text != txtConfirmarContrasena.Text)
                {
                    errorProviderValidacion.SetError(txtConfirmarContrasena, "Las contraseñas no coinciden.");
                    correcto = false;
                }
            }

            if (correcto == false)
            {
                MessageBox.Show("Revise los campos marcados antes de continuar.", "Configuración inicial", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return correcto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ConfiguracionEmpresa configuracion;
            Usuario administrador;
            int idTipoGestor;
            bool guardado;

            if (ValidarDatos() == false)
            {
                return;
            }

            configuracion = new ConfiguracionEmpresa();
            configuracion.NombreEmpresa = txtNombreEmpresa.Text.Trim();
            configuracion.RutaLogo = txtRutaLogo.Text.Trim();
            if (logoSeleccionado == null && File.Exists(configuracion.RutaLogo) == true)
            {
                FileInfo archivo;
                archivo = new FileInfo(configuracion.RutaLogo);
                if (archivo.Length <= 2097152)
                {
                    logoSeleccionado = File.ReadAllBytes(configuracion.RutaLogo);
                }
            }
            configuracion.LogoImagen = logoSeleccionado;
            configuracion.InformacionGeneral = txtInformacionGeneral.Text.Trim();
            guardado = configuracion.GuardarConfiguracion();

            if (guardado == false)
            {
                return;
            }

            if (requiereAdministrador == true)
            {
                idTipoGestor = usuarioModelo.ObtenerIdTipoUsuario("Gestor");

                if (idTipoGestor == 0)
                {
                    MessageBox.Show("No se encontró el tipo de usuario Gestor en la base de datos.", "Configuración inicial", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (usuarioModelo.ExisteNombreUsuarioEnOtroUsuario(txtUsuarioAdministrador.Text.Trim(), 0) == true)
                {
                    errorProviderValidacion.SetError(txtUsuarioAdministrador, "El nombre de usuario ya existe.");
                    MessageBox.Show("El nombre de usuario ya existe.", "Configuración inicial", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                administrador = new Usuario();
                administrador.NombreCompleto = txtNombreAdministrador.Text.Trim();
                administrador.NombreUsuario = txtUsuarioAdministrador.Text.Trim();
                administrador.Contrasena = txtContrasena.Text;
                administrador.IdTipoUsuario = idTipoGestor;
                administrador.IdArea = null;
                administrador.Activo = true;

                if (administrador.CrearUsuario() == false)
                {
                    return;
                }
            }

            MessageBox.Show("La configuración inicial se guardó correctamente.", "Configuración inicial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtUsuarioAdministrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool permitido;

            permitido = false;

            if (char.IsControl(e.KeyChar) == true || char.IsLetterOrDigit(e.KeyChar) == true)
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
