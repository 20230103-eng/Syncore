using System;
using System.IO;
using System.Windows.Forms;
using Modelo.Modelo.Infraestructura;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmConfiguracionInicial : Form
    {
        private bool validacionEnTiempoRealHabilitada;
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
        
            txtNombreEmpresa.TextChanged += CamposEnTiempoReal;
            txtNombreEmpresa.Leave += CamposEnTiempoReal;
            txtInformacionGeneral.TextChanged += CamposEnTiempoReal;
            txtInformacionGeneral.Leave += CamposEnTiempoReal;
            txtRutaLogo.TextChanged += CamposEnTiempoReal;
            txtRutaLogo.Leave += CamposEnTiempoReal;
            txtNombreAdministrador.TextChanged += CamposEnTiempoReal;
            txtNombreAdministrador.Leave += CamposEnTiempoReal;
            txtUsuarioAdministrador.TextChanged += CamposEnTiempoReal;
            txtUsuarioAdministrador.Leave += CamposEnTiempoReal;
            txtContrasena.TextChanged += CamposEnTiempoReal;
            txtContrasena.Leave += CamposEnTiempoReal;
            txtConfirmarContrasena.TextChanged += CamposEnTiempoReal;
            txtConfirmarContrasena.Leave += CamposEnTiempoReal;
            txtUsuarioAdministrador.Leave += Administrador_Leave;
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
        
            validacionEnTiempoRealHabilitada = true;
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
                byte[] imagen = ArchivosSeguros.LeerBytes(selector.FileName);
                if (imagen == null)
                {
                    selector.Dispose();
                    return;
                }
                if (imagen.Length > 2097152)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtRutaLogo, "ERR-VAL-003", "El logotipo no debe superar 2 MB.");
                    CatalogoErrores.MostrarDetalle("ERR-VAL-006", "Configuración", "El logotipo no debe superar 2 MB.");
                    selector.Dispose();
                    return;
                }
                bool formatoValido;
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
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtRutaLogo, "ERR-VAL-006", "Seleccione una imagen PNG, JPEG o BMP válida.");
                    CatalogoErrores.MostrarDetalle("ERR-VAL-006", "Configuración", "Seleccione una imagen PNG, JPEG o BMP válida.");
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
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtNombreEmpresa, "ERR-VAL-001", "Ingrese el nombre de la empresa.");
                correcto = false;
            }

            if (logoSeleccionado == null || logoSeleccionado.Length == 0)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtRutaLogo, "ERR-VAL-006", "Seleccione el logotipo de la empresa.");
                correcto = false;
            }

            if (string.IsNullOrEmpty(txtInformacionGeneral.Text.Trim()) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtInformacionGeneral, "ERR-VAL-001", "Ingrese la información general.");
                correcto = false;
            }

            if (requiereAdministrador == true)
            {
                if (string.IsNullOrEmpty(txtNombreAdministrador.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtNombreAdministrador, "ERR-VAL-001", "Ingrese el nombre completo.");
                    correcto = false;
                }

                if (string.IsNullOrEmpty(txtUsuarioAdministrador.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtUsuarioAdministrador, "ERR-VAL-001", "Ingrese el nombre de usuario.");
                    correcto = false;
                }

                if (string.IsNullOrEmpty(txtContrasena.Text) == true || txtContrasena.Text.Length < 6)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtContrasena, "ERR-VAL-003", "La contraseña debe tener al menos 6 caracteres.");
                    correcto = false;
                }

                if (txtContrasena.Text != txtConfirmarContrasena.Text)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtConfirmarContrasena, "ERR-VAL-004", "Las contraseñas no coinciden.");
                    correcto = false;
                }
            }

            if (correcto == false)
            {
                CatalogoErrores.MostrarDetalle("ERR-VAL-999", "Configuración inicial", "Revise los campos marcados antes de continuar.");
            }

            return correcto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ConfiguracionEmpresa configuracion;
            Usuario administrador;
            int idTipoGestor = 0;
            bool guardado;

            if (ValidarDatos() == false)
            {
                return;
            }

            if (requiereAdministrador == true)
            {
                foreach (char caracter in txtNombreAdministrador.Text)
                {
                    if (char.IsLetter(caracter) == false && char.IsWhiteSpace(caracter) == false && caracter != '-' && caracter != '\'')
                    {
                        CatalogoErrores.MarcarCampo(errorProviderValidacion, txtNombreAdministrador, "ERR-VAL-002", "El nombre contiene caracteres no permitidos.");
                        CatalogoErrores.MostrarDetalle("ERR-VAL-002", "Syncore", "El nombre solo admite letras, espacios, guiones y apóstrofes.");
                        return;
                    }
                }
                foreach (char caracter in txtUsuarioAdministrador.Text)
                {
                    if (char.IsLetterOrDigit(caracter) == false && caracter != '.' && caracter != '_' && caracter != '-')
                    {
                        CatalogoErrores.MarcarCampo(errorProviderValidacion, txtUsuarioAdministrador, "ERR-VAL-002", "El usuario contiene caracteres no permitidos.");
                        CatalogoErrores.MostrarDetalle("ERR-VAL-002", "Syncore", "El usuario contiene caracteres no permitidos.");
                        return;
                    }
                }
                idTipoGestor = usuarioModelo.ObtenerIdTipoUsuario("Gestor");

                if (idTipoGestor == 0)
                {
                    CatalogoErrores.MostrarDetalle("ERR-NEG-004", "Configuración inicial", "No se encontró el tipo de usuario Gestor en la base de datos.");
                    return;
                }

                if (usuarioModelo.ExisteNombreUsuarioEnOtroUsuario(txtUsuarioAdministrador.Text.Trim(), 0) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtUsuarioAdministrador, "ERR-VAL-005", "El nombre de usuario ya existe.");
                    CatalogoErrores.MostrarDetalle("ERR-VAL-005", "Configuración inicial", "El nombre de usuario ya existe.");
                    return;
                }
            }

            configuracion = new ConfiguracionEmpresa();
            configuracion.NombreEmpresa = txtNombreEmpresa.Text.Trim();
            configuracion.RutaLogo = txtRutaLogo.Text.Trim();
            if (logoSeleccionado == null && File.Exists(configuracion.RutaLogo) == true)
            {
                byte[] imagenExistente = ArchivosSeguros.LeerBytes(configuracion.RutaLogo);
                if (imagenExistente != null && imagenExistente.Length <= 2097152)
                {
                    logoSeleccionado = imagenExistente;
                }
            }
            configuracion.LogoImagen = logoSeleccionado;
            configuracion.InformacionGeneral = txtInformacionGeneral.Text.Trim();

            if (requiereAdministrador == true)
            {
                administrador = new Usuario();
                administrador.NombreCompleto = txtNombreAdministrador.Text.Trim();
                administrador.NombreUsuario = txtUsuarioAdministrador.Text.Trim();
                administrador.Contrasena = txtContrasena.Text;
                administrador.IdTipoUsuario = idTipoGestor;
                administrador.IdArea = null;
                administrador.Activo = true;
                guardado = configuracion.GuardarPrimerUso(administrador);
            }
            else
            {
                guardado = configuracion.GuardarConfiguracion();
            }

            if (guardado == false)
            {
                CatalogoErrores.MostrarDetalle("ERR-NEG-003", "Configuración inicial", "No se completó la configuración inicial. Verifique los datos y vuelva a intentarlo.");
                return;
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
        private void CamposEnTiempoReal(object sender, EventArgs e)
        {
            if (validacionEnTiempoRealHabilitada == false)
            {
                return;
            }

            if (sender == txtNombreEmpresa)
            {
                if (string.IsNullOrEmpty(txtNombreEmpresa.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtNombreEmpresa, "ERR-VAL-001", "Ingrese el nombre de la empresa.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtNombreEmpresa, "");
                }
            }
            if (sender == txtInformacionGeneral)
            {
                if (string.IsNullOrEmpty(txtInformacionGeneral.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtInformacionGeneral, "ERR-VAL-001", "Ingrese la información general.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtInformacionGeneral, "");
                }
            }
            if (sender == txtRutaLogo)
            {
                if (logoSeleccionado == null || logoSeleccionado.Length == 0)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtRutaLogo, "ERR-VAL-006", "Seleccione un logotipo válido.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtRutaLogo, "");
                }
            }
            if (sender == txtNombreAdministrador)
            {
                bool nombreValido;
                nombreValido = true;
                foreach (char caracter in txtNombreAdministrador.Text)
                {
                    if (char.IsLetter(caracter) == false && char.IsWhiteSpace(caracter) == false && caracter != '-' && caracter != '\'')
                    {
                        nombreValido = false;
                    }
                }
                if (string.IsNullOrEmpty(txtNombreAdministrador.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtNombreAdministrador, "ERR-VAL-001", "Ingrese el nombre completo del primer administrador.");
                }
                else if (nombreValido == false)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtNombreAdministrador, "ERR-VAL-002", "El nombre solo admite letras, espacios, guiones y apóstrofes.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtNombreAdministrador, "");
                }
            }
            if (sender == txtUsuarioAdministrador)
            {
                bool formatoCorrecto;
                formatoCorrecto = true;
                foreach (char caracter in txtUsuarioAdministrador.Text)
                {
                    if (char.IsLetterOrDigit(caracter) == false && caracter != '.' && caracter != '_' && caracter != '-')
                    {
                        formatoCorrecto = false;
                    }
                }
                if (string.IsNullOrEmpty(txtUsuarioAdministrador.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtUsuarioAdministrador, "ERR-VAL-001", "Ingrese el nombre de usuario.");
                }
                else if (formatoCorrecto == false)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtUsuarioAdministrador, "ERR-VAL-999", "Usuario: solo letras, números, punto, guion o guion bajo.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtUsuarioAdministrador, "");
                }
            }
            if (sender == txtContrasena)
            {
                if (txtContrasena.Text.Length < 6)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtContrasena, "ERR-VAL-003", "La contraseña debe tener al menos 6 caracteres.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtContrasena, "");
                }
            }
            if (sender == txtConfirmarContrasena)
            {
                if (txtConfirmarContrasena.Text != txtContrasena.Text)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtConfirmarContrasena, "ERR-VAL-004", "Las contraseñas no coinciden.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtConfirmarContrasena, "");
                }
            }
        
            if (sender == txtContrasena && txtConfirmarContrasena.Text.Length > 0)
            {
                if (txtConfirmarContrasena.Text != txtContrasena.Text)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtConfirmarContrasena, "ERR-VAL-004", "Las contraseñas no coinciden.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtConfirmarContrasena, "");
                }
            }
        }

        private void Administrador_Leave(object sender, EventArgs e)
        {
            if (validacionEnTiempoRealHabilitada == false || requiereAdministrador == false || usuarioModelo == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtUsuarioAdministrador.Text.Trim()) == true)
            {
                return;
            }
            if (errorProviderValidacion.GetError(txtUsuarioAdministrador) != "")
            {
                return;
            }
            if (usuarioModelo.ExisteNombreUsuarioEnOtroUsuario(txtUsuarioAdministrador.Text.Trim(), 0) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtUsuarioAdministrador, "ERR-VAL-005", "El nombre de usuario ya existe.");
            }
        }

    }
}
