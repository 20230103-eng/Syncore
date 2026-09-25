using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmAdministracionSistema : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;
        private System.Windows.Forms.ErrorProvider errorProviderValidacion;

        private Usuario usuarioModelo;
        private Area areaModelo;
        private TipoUsuario tipoUsuarioModelo;
        private DataTable usuariosOriginales;
        private int idUsuarioSeleccionado;

        public frmAdministracionSistema()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            errorProviderValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            errorProviderValidacion.ContainerControl = this;
            errorProviderValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            toolTipAyuda.SetToolTip(txtNombreCompleto, "Ingrese nombre completo.");
            toolTipAyuda.SetToolTip(txtUsuario, "Ingrese nombre de usuario.");
            toolTipAyuda.SetToolTip(txtContrasena, "Ingrese contraseña.");
            toolTipAyuda.SetToolTip(txtConfirmarContrasena, "Ingrese confirmación de contraseña.");
            toolTipAyuda.SetToolTip(cboTipoUsuario, "Seleccione el tipo de usuario.");
            toolTipAyuda.SetToolTip(cboArea, "Seleccione área.");
            toolTipAyuda.SetToolTip(chkActivo, "Indique si el usuario se encuentra activo.");
            toolTipAyuda.SetToolTip(btnNuevo, "Preparar el formulario para un nuevo registro.");
            toolTipAyuda.SetToolTip(btnGuardar, "Guardar la información ingresada.");
            toolTipAyuda.SetToolTip(btnActualizar, "Actualizar la información.");
            toolTipAyuda.SetToolTip(btnEliminar, "Eliminar el registro seleccionado.");
            toolTipAyuda.SetToolTip(btnClaveTemporal, "Generar una clave temporal para recuperar el acceso del usuario seleccionado.");
            toolTipAyuda.SetToolTip(txtBuscar, "Escriba el texto que desea buscar.");
            toolTipAyuda.SetToolTip(dgvUsuarios, "Muestra los usuarios registrados.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);

            ucPaginador.Tabla = dgvUsuarios;
            ucPaginador.PaginaCambiada += ucPaginador_PaginaCambiada;
        }

        private void frmAdministracionSistema_Load(object sender, EventArgs e)
        {
            usuarioModelo = new Usuario();
            areaModelo = new Area();
            tipoUsuarioModelo = new TipoUsuario();
            usuariosOriginales = new DataTable();
            idUsuarioSeleccionado = 0;
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            CargarCatalogos();
            CargarUsuarios();
            PrepararNuevoUsuario();
        }

        private void CargarCatalogos()
        {
            DataTable tipos;
            DataTable areas;

            tipos = tipoUsuarioModelo.ObtenerTiposUsuario();
            areas = areaModelo.ObtenerAreas();

            cboTipoUsuario.DisplayMember = "Nombre";
            cboTipoUsuario.ValueMember = "IdTipoUsuario";
            cboTipoUsuario.DataSource = tipos;
            cboTipoUsuario.SelectedIndex = -1;

            cboArea.DisplayMember = "Nombre";
            cboArea.ValueMember = "IdArea";
            cboArea.DataSource = areas;
            cboArea.SelectedIndex = -1;
        }

        private void CargarUsuarios()
        {
            usuariosOriginales = usuarioModelo.ObtenerUsuarios();
            AplicarBusqueda();
        }

        private void AplicarBusqueda()
        {
            string texto;
            DataTable filtrados;

            texto = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(texto) == true)
            {
                ucPaginador.Mostrar(usuariosOriginales);
                ConfigurarColumnas();
                return;
            }

            filtrados = usuariosOriginales.Clone();

            foreach (DataRow fila in usuariosOriginales.Rows)
            {
                if (fila["NombreUsuario"].ToString().ToLower().Contains(texto) == true || fila["NombreCompleto"].ToString().ToLower().Contains(texto) == true || fila["TipoUsuario"].ToString().ToLower().Contains(texto) == true || fila["Area"].ToString().ToLower().Contains(texto) == true)
                {
                    filtrados.ImportRow(fila);
                }
            }

            ucPaginador.Mostrar(filtrados);
            ConfigurarColumnas();
        }

        private void ConfigurarColumnas()
        {
            if (dgvUsuarios.Columns.Contains("IdUsuario") == true)
            {
                dgvUsuarios.Columns["IdUsuario"].Visible = false;
            }

            if (dgvUsuarios.Columns.Contains("IdTipoUsuario") == true)
            {
                dgvUsuarios.Columns["IdTipoUsuario"].Visible = false;
            }

            if (dgvUsuarios.Columns.Contains("IdArea") == true)
            {
                dgvUsuarios.Columns["IdArea"].Visible = false;
            }

            if (dgvUsuarios.Columns.Contains("NombreUsuario") == true)
            {
                dgvUsuarios.Columns["NombreUsuario"].HeaderText = "USUARIO";
                dgvUsuarios.Columns["NombreUsuario"].FillWeight = 16;
            }

            if (dgvUsuarios.Columns.Contains("NombreCompleto") == true)
            {
                dgvUsuarios.Columns["NombreCompleto"].HeaderText = "NOMBRE COMPLETO";
                dgvUsuarios.Columns["NombreCompleto"].FillWeight = 25;
            }

            if (dgvUsuarios.Columns.Contains("TipoUsuario") == true)
            {
                dgvUsuarios.Columns["TipoUsuario"].HeaderText = "TIPO";
                dgvUsuarios.Columns["TipoUsuario"].FillWeight = 14;
            }

            if (dgvUsuarios.Columns.Contains("Area") == true)
            {
                dgvUsuarios.Columns["Area"].HeaderText = "ÁREA";
                dgvUsuarios.Columns["Area"].FillWeight = 18;
            }

            if (dgvUsuarios.Columns.Contains("Activo") == true)
            {
                dgvUsuarios.Columns["Activo"].HeaderText = "ACTIVO";
                dgvUsuarios.Columns["Activo"].FillWeight = 10;
            }

            if (dgvUsuarios.Columns.Contains("FechaCreacion") == true)
            {
                dgvUsuarios.Columns["FechaCreacion"].HeaderText = "CREADO";
                dgvUsuarios.Columns["FechaCreacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvUsuarios.Columns["FechaCreacion"].FillWeight = 17;
            }

            dgvUsuarios.ClearSelection();
        }

        private void PrepararNuevoUsuario()
        {
            idUsuarioSeleccionado = 0;
            lblModo.Text = "Nuevo usuario";
            txtNombreCompleto.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtConfirmarContrasena.Clear();
            cboTipoUsuario.SelectedIndex = -1;
            cboArea.SelectedIndex = -1;
            chkActivo.Checked = true;
            cboTipoUsuario.Enabled = true;
            chkActivo.Enabled = true;
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            lblAyudaContrasena.Text = "Contraseña obligatoria para usuarios nuevos.";
            txtNombreCompleto.Focus();
        }

        private bool ValidarDatos(bool esNuevo)
        {
            bool existe;

            errorProviderValidacion.Clear();

            if (string.IsNullOrEmpty(txtNombreCompleto.Text.Trim()) == true)
            {
                errorProviderValidacion.SetError(txtNombreCompleto, "Ingrese el nombre completo del usuario.");
                MessageBox.Show("Ingrese el nombre completo del usuario.");
                txtNombreCompleto.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()) == true)
            {
                errorProviderValidacion.SetError(txtUsuario, "Ingrese el nombre de usuario.");
                MessageBox.Show("Ingrese el nombre de usuario.");
                txtUsuario.Focus();
                return false;
            }

            existe = usuarioModelo.ExisteNombreUsuarioEnOtroUsuario(txtUsuario.Text.Trim(), idUsuarioSeleccionado);

            if (existe == true)
            {
                errorProviderValidacion.SetError(txtUsuario, "El nombre de usuario ya existe.");
                MessageBox.Show("El nombre de usuario ya existe.");
                txtUsuario.Focus();
                return false;
            }

            if (cboTipoUsuario.SelectedValue == null)
            {
                errorProviderValidacion.SetError(cboTipoUsuario, "Seleccione el tipo de usuario.");
                MessageBox.Show("Seleccione el tipo de usuario.");
                cboTipoUsuario.Focus();
                return false;
            }

            if (esNuevo == true || string.IsNullOrEmpty(txtContrasena.Text) == false || string.IsNullOrEmpty(txtConfirmarContrasena.Text) == false)
            {
                if (string.IsNullOrEmpty(txtContrasena.Text) == true)
                {
                    errorProviderValidacion.SetError(txtContrasena, "Ingrese la contraseña.");
                    MessageBox.Show("Ingrese la contraseña.");
                    txtContrasena.Focus();
                    return false;
                }

                if (txtContrasena.Text.Length < 6)
                {
                    errorProviderValidacion.SetError(txtContrasena, "La contraseña debe tener al menos 6 caracteres.");
                    MessageBox.Show("La contraseña debe tener al menos 6 caracteres.");
                    txtContrasena.Focus();
                    return false;
                }

                if (txtContrasena.Text != txtConfirmarContrasena.Text)
                {
                    errorProviderValidacion.SetError(txtConfirmarContrasena, "Las contraseñas no coinciden.");
                    MessageBox.Show("Las contraseñas no coinciden.");
                    txtConfirmarContrasena.Focus();
                    return false;
                }
            }

            if (idUsuarioSeleccionado > 0 && Sesion.UsuarioActual != null && idUsuarioSeleccionado == Sesion.UsuarioActual.IdUsuario && chkActivo.Checked == false)
            {
                MessageBox.Show("No puede desactivar el usuario de la sesión actual.");
                chkActivo.Checked = true;
                return false;
            }

            return true;
        }

        private Usuario CrearUsuarioFormulario()
        {
            Usuario usuario;

            usuario = new Usuario();
            usuario.IdUsuario = idUsuarioSeleccionado;
            usuario.NombreCompleto = txtNombreCompleto.Text.Trim();
            usuario.NombreUsuario = txtUsuario.Text.Trim();
            usuario.Contrasena = txtContrasena.Text;
            usuario.IdTipoUsuario = Convert.ToInt32(cboTipoUsuario.SelectedValue);
            usuario.Activo = chkActivo.Checked;
            usuario.IdArea = null;

            if (cboArea.SelectedValue != null)
            {
                usuario.IdArea = Convert.ToInt32(cboArea.SelectedValue);
            }

            return usuario;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PrepararNuevoUsuario();
            dgvUsuarios.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            bool guardado;

            if (ValidarDatos(true) == false)
            {
                return;
            }

            usuario = CrearUsuarioFormulario();
            guardado = usuario.CrearUsuario();

            if (guardado == false)
            {
                return;
            }

            MessageBox.Show("El usuario fue creado correctamente.");
            CargarUsuarios();
            PrepararNuevoUsuario();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            bool cambiarContrasena;
            bool actualizado;

            if (idUsuarioSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un usuario de la lista.");
                return;
            }

            if (ValidarDatos(false) == false)
            {
                return;
            }

            cambiarContrasena = false;

            if (string.IsNullOrEmpty(txtContrasena.Text) == false)
            {
                cambiarContrasena = true;
            }

            usuario = CrearUsuarioFormulario();
            actualizado = usuario.ActualizarUsuario(cambiarContrasena);

            if (actualizado == false)
            {
                return;
            }

            if (Sesion.UsuarioActual != null && usuario.IdUsuario == Sesion.UsuarioActual.IdUsuario)
            {
                Sesion.UsuarioActual.NombreCompleto = usuario.NombreCompleto;
                Sesion.UsuarioActual.NombreUsuario = usuario.NombreUsuario;
                Sesion.UsuarioActual.IdArea = usuario.IdArea;
            }

            MessageBox.Show("El usuario fue actualizado correctamente.");
            CargarUsuarios();
            PrepararNuevoUsuario();
        }


        private void btnClaveTemporal_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            Random aleatorio;
            string claveTemporal;
            bool actualizado;

            if (idUsuarioSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un usuario de la lista.", "Clave temporal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            aleatorio = new Random();
            claveTemporal = "TMP" + aleatorio.Next(100000, 999999).ToString();
            usuario = new Usuario();
            usuario.IdUsuario = idUsuarioSeleccionado;
            actualizado = usuario.RestablecerContrasenaTemporal(claveTemporal);

            if (actualizado == false)
            {
                return;
            }

            MessageBox.Show("Clave temporal generada: " + claveTemporal + "\n\nEl usuario puede iniciar sesión con esta clave y luego cambiarla desde Perfil.", "Recuperación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            DialogResult respuesta;
            bool eliminado;

            if (idUsuarioSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un usuario de la lista.");
                return;
            }

            if (Sesion.UsuarioActual != null && idUsuarioSeleccionado == Sesion.UsuarioActual.IdUsuario)
            {
                MessageBox.Show("No puede eliminar el usuario de la sesión actual.");
                return;
            }

            respuesta = MessageBox.Show("¿Desea eliminar este usuario?\n\nSi tiene información relacionada, el sistema no permitirá eliminarlo.", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            usuario = new Usuario();
            usuario.IdUsuario = idUsuarioSeleccionado;
            eliminado = usuario.EliminarUsuario();

            if (eliminado == false)
            {
                return;
            }

            MessageBox.Show("El usuario fue eliminado correctamente.");
            CargarUsuarios();
            PrepararNuevoUsuario();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila;

            if (e.RowIndex < 0)
            {
                return;
            }

            fila = dgvUsuarios.Rows[e.RowIndex];
            idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["IdUsuario"].Value);
            lblModo.Text = "Editar usuario";
            txtNombreCompleto.Text = fila.Cells["NombreCompleto"].Value.ToString();
            txtUsuario.Text = fila.Cells["NombreUsuario"].Value.ToString();
            cboTipoUsuario.SelectedValue = Convert.ToInt32(fila.Cells["IdTipoUsuario"].Value);
            cboArea.SelectedIndex = -1;

            if (fila.Cells["IdArea"].Value != DBNull.Value)
            {
                cboArea.SelectedValue = Convert.ToInt32(fila.Cells["IdArea"].Value);
            }

            chkActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value);
            txtContrasena.Clear();
            txtConfirmarContrasena.Clear();
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            cboTipoUsuario.Enabled = true;
            chkActivo.Enabled = true;
            lblAyudaContrasena.Text = "Deje la contraseña vacía para conservar la actual.";

            if (Sesion.UsuarioActual != null && idUsuarioSeleccionado == Sesion.UsuarioActual.IdUsuario)
            {
                cboTipoUsuario.Enabled = false;
                chkActivo.Enabled = false;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarBusqueda();
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

        private void txtNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool permitido;

            permitido = false;

            if (char.IsControl(e.KeyChar) == true)
            {
                permitido = true;
            }
            else if (char.IsLetter(e.KeyChar) == true || char.IsWhiteSpace(e.KeyChar) == true)
            {
                permitido = true;
            }
            else if (e.KeyChar == '-' || e.KeyChar == '\'')
            {
                permitido = true;
            }

            if (permitido == false)
            {
                e.Handled = true;
            }
        }
        private void ucPaginador_PaginaCambiada(object sender, EventArgs e)
        {
            PrepararNuevoUsuario();
        }

    }
}
