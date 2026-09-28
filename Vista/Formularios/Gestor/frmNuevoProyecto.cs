using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmNuevoProyecto : Form
    {
        private bool validacionEnTiempoRealHabilitada;
        private System.Windows.Forms.ToolTip toolTipAyuda;
        private System.Windows.Forms.ErrorProvider errorProviderValidacion;

        private Proyecto proyectoModelo;
        private Area areaModelo;
        private TipoProyecto tipoProyectoModelo;
        private Prioridad prioridadModelo;

        public event EventHandler VolverSolicitado;

        public frmNuevoProyecto()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            errorProviderValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            errorProviderValidacion.ContainerControl = this;
            errorProviderValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            toolTipAyuda.SetToolTip(txtNombre, "Ingrese nombre.");
            toolTipAyuda.SetToolTip(txtCodigo, "Ingrese código.");
            toolTipAyuda.SetToolTip(cboTipo, "Seleccione tipo.");
            toolTipAyuda.SetToolTip(cboArea, "Seleccione área.");
            toolTipAyuda.SetToolTip(cboResponsable, "Seleccione responsable.");
            toolTipAyuda.SetToolTip(dtpInicio, "Seleccione fecha de inicio.");
            toolTipAyuda.SetToolTip(dtpCierre, "Seleccione fecha de cierre.");
            toolTipAyuda.SetToolTip(cboPrioridad, "Seleccione prioridad.");
            toolTipAyuda.SetToolTip(txtObjetivo, "Ingrese objetivo.");
            toolTipAyuda.SetToolTip(txtJustificacion, "Ingrese justificación.");
            toolTipAyuda.SetToolTip(txtAlcance, "Ingrese alcance.");
            toolTipAyuda.SetToolTip(txtResultado, "Ingrese resultado esperado.");
            toolTipAyuda.SetToolTip(txtObservaciones, "Ingrese observaciones.");
            toolTipAyuda.SetToolTip(btnCrearProyecto, "Crear el proyecto con la información ingresada.");
            toolTipAyuda.SetToolTip(btnCancelar, "Cancelar la operación actual.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);

            txtNombre.TextChanged += CamposEnTiempoReal;
            txtNombre.Leave += CamposEnTiempoReal;
            txtCodigo.TextChanged += CamposEnTiempoReal;
            txtCodigo.Leave += CamposEnTiempoReal;
            txtObjetivo.TextChanged += CamposEnTiempoReal;
            txtObjetivo.Leave += CamposEnTiempoReal;
            txtResultado.TextChanged += CamposEnTiempoReal;
            txtResultado.Leave += CamposEnTiempoReal;
            cboTipo.SelectedIndexChanged += CamposEnTiempoReal;
            cboTipo.Leave += CamposEnTiempoReal;
            cboArea.SelectedIndexChanged += CamposEnTiempoReal;
            cboArea.Leave += CamposEnTiempoReal;
            cboResponsable.SelectedIndexChanged += CamposEnTiempoReal;
            cboResponsable.Leave += CamposEnTiempoReal;
            cboPrioridad.SelectedIndexChanged += CamposEnTiempoReal;
            cboPrioridad.Leave += CamposEnTiempoReal;
            dtpCierre.ValueChanged += CamposEnTiempoReal;
            dtpInicio.ValueChanged += CamposEnTiempoReal;
            txtCodigo.Leave += Codigo_Leave;
        }

        private void frmNuevoProyecto_Load(object sender, EventArgs e)
        {
            proyectoModelo = new Proyecto();
            areaModelo = new Area();
            tipoProyectoModelo = new TipoProyecto();
            prioridadModelo = new Prioridad();
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            AjustarBreadcrumb();
            CargarCombos();
            PrepararFormulario();
            CargarResponsableSesion();
        
            validacionEnTiempoRealHabilitada = true;
        }

        private void AjustarBreadcrumb()
        {
            lblBreadcrumbActual.Left = lblBreadcrumbBase.Right + 8;
        }

        private void CargarCombos()
        {
            DataTable tiposProyecto;
            DataTable areas;
            DataTable prioridades;

            tiposProyecto = tipoProyectoModelo.ObtenerTiposProyecto();
            areas = areaModelo.ObtenerAreas();
            prioridades = prioridadModelo.ObtenerPrioridades();

            cboTipo.DisplayMember = "Nombre";
            cboTipo.ValueMember = "IdTipoProyecto";
            cboTipo.DataSource = tiposProyecto;
            cboArea.DisplayMember = "Nombre";
            cboArea.ValueMember = "IdArea";
            cboArea.DataSource = areas;
            cboPrioridad.DisplayMember = "Nombre";
            cboPrioridad.ValueMember = "IdPrioridad";
            cboPrioridad.DataSource = prioridades;
        }


        private void CargarResponsableSesion()
        {
            cboResponsable.Items.Clear();
            cboResponsable.Enabled = false;
            cboResponsable.TabStop = false;

            if (Sesion.UsuarioActual == null)
            {
                return;
            }

            cboResponsable.Items.Add(Sesion.UsuarioActual.NombreCompleto);
            cboResponsable.SelectedIndex = 0;
        }

        private void PrepararFormulario()
        {
            cboTipo.SelectedIndex = -1;
            cboArea.SelectedIndex = -1;
            cboPrioridad.SelectedIndex = -1;
            dtpInicio.Value = DateTime.Today;
            dtpCierre.Value = DateTime.Today.AddDays(30);
            errorProviderValidacion.Clear();
        }

        private bool ValidarDatos()
        {
            bool codigoExiste;
            errorProviderValidacion.Clear();

            if (Sesion.UsuarioActual == null)
            {
                CatalogoErrores.MostrarDetalle("ERR-NEG-001", "Syncore", "No hay una sesión activa.");
                return false;
            }

            if (Sesion.UsuarioActual.TipoUsuario != "Gestor")
            {
                CatalogoErrores.MostrarDetalle("ERR-NEG-001", "Syncore", "Solo un gestor puede crear proyectos.");
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtNombre, "ERR-VAL-001", "Ingrese el nombre del proyecto.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-001", "Syncore", "Ingrese el nombre del proyecto.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCodigo.Text.Trim()) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtCodigo, "ERR-VAL-001", "Ingrese el código del proyecto.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-001", "Syncore", "Ingrese el código del proyecto.");
                txtCodigo.Focus();
                return false;
            }

            foreach (char caracter in txtCodigo.Text)
            {
                if (char.IsLetterOrDigit(caracter) == false && caracter != '-')
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtCodigo, "ERR-VAL-002", "El código solo admite letras, números y guiones.");
                    CatalogoErrores.MostrarDetalle("ERR-VAL-002", "Syncore", "El código solo admite letras, números y guiones.");
                    txtCodigo.Focus();
                    return false;
                }
            }

            codigoExiste = proyectoModelo.ExisteCodigoProyecto(txtCodigo.Text.Trim());

            if (codigoExiste == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtCodigo, "ERR-VAL-005", "El código del proyecto ya existe.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-005", "Syncore", "El código del proyecto ya existe.");
                txtCodigo.Focus();
                return false;
            }

            if (cboTipo.SelectedValue == null)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, cboTipo, "ERR-VAL-007", "Seleccione el tipo de proyecto.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Syncore", "Seleccione el tipo de proyecto.");
                cboTipo.Focus();
                return false;
            }

            if (cboArea.SelectedValue == null)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, cboArea, "ERR-VAL-007", "Seleccione el área solicitante.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Syncore", "Seleccione el área solicitante.");
                cboArea.Focus();
                return false;
            }

            if (cboPrioridad.SelectedIndex < 0)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, cboPrioridad, "ERR-VAL-007", "Seleccione la prioridad.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Syncore", "Seleccione la prioridad del proyecto.");
                cboPrioridad.Focus();
                return false;
            }

            if (dtpCierre.Value.Date < dtpInicio.Value.Date)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, dtpCierre, "ERR-VAL-004", "Revise la fecha de cierre.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-004", "Syncore", "La fecha de cierre no puede ser anterior a la fecha de inicio.");
                dtpCierre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtObjetivo.Text.Trim()) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtObjetivo, "ERR-VAL-001", "Ingrese el objetivo.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-001", "Syncore", "Ingrese el objetivo del proyecto.");
                txtObjetivo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtResultado.Text.Trim()) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtResultado, "ERR-VAL-001", "Ingrese el resultado esperado.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-001", "Syncore", "Ingrese el resultado esperado.");
                txtResultado.Focus();
                return false;
            }

            return true;
        }

        private void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            bool datosCorrectos;
            bool proyectoCreado;
            Proyecto proyecto;

            datosCorrectos = ValidarDatos();

            if (datosCorrectos == false)
            {
                return;
            }

            proyecto = new Proyecto();
            proyecto.Codigo = txtCodigo.Text.Trim();
            proyecto.Nombre = txtNombre.Text.Trim();
            proyecto.Objetivo = txtObjetivo.Text.Trim();
            proyecto.Justificacion = txtJustificacion.Text.Trim();
            proyecto.Alcance = txtAlcance.Text.Trim();
            proyecto.ResultadoEsperado = txtResultado.Text.Trim();
            proyecto.Observaciones = txtObservaciones.Text.Trim();
            proyecto.IdArea = Convert.ToInt32(cboArea.SelectedValue);
            proyecto.IdTipoProyecto = Convert.ToInt32(cboTipo.SelectedValue);
            proyecto.IdResponsable = Sesion.UsuarioActual.IdUsuario;
            proyecto.IdPrioridad = Convert.ToInt32(cboPrioridad.SelectedValue);
            proyecto.FechaInicio = dtpInicio.Value.Date;
            proyecto.FechaCierreEstimada = dtpCierre.Value.Date;
            proyecto.AvancePlanificado = 0;

            proyectoCreado = proyecto.CrearProyecto();

            if (proyectoCreado == true)
            {
                MessageBox.Show("El proyecto fue creado correctamente.");
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            txtObjetivo.Clear();
            txtJustificacion.Clear();
            txtAlcance.Clear();
            txtResultado.Clear();
            txtObservaciones.Clear();
            PrepararFormulario();
            CargarResponsableSesion();
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (VolverSolicitado != null)
            {
                VolverSolicitado(this, EventArgs.Empty);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (e.KeyChar == '-')
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

            if (sender == txtNombre)
            {
                if (string.IsNullOrEmpty(txtNombre.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtNombre, "ERR-VAL-001", "Ingrese el nombre del proyecto.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtNombre, "");
                }
            }
            if (sender == txtCodigo)
            {
                bool formatoCorrecto;
                formatoCorrecto = true;
                foreach (char caracter in txtCodigo.Text)
                {
                    if (char.IsLetterOrDigit(caracter) == false && caracter != '-')
                    {
                        formatoCorrecto = false;
                    }
                }
                if (string.IsNullOrEmpty(txtCodigo.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtCodigo, "ERR-VAL-001", "Ingrese el código del proyecto.");
                }
                else if (formatoCorrecto == false)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtCodigo, "ERR-VAL-002", "El código solo admite letras, números y guiones.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtCodigo, "");
                }
            }
            if (sender == txtObjetivo)
            {
                if (string.IsNullOrEmpty(txtObjetivo.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtObjetivo, "ERR-VAL-001", "Ingrese el objetivo del proyecto.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtObjetivo, "");
                }
            }
            if (sender == txtResultado)
            {
                if (string.IsNullOrEmpty(txtResultado.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtResultado, "ERR-VAL-001", "Ingrese el resultado esperado.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtResultado, "");
                }
            }
            if (sender == cboTipo)
            {
                if (cboTipo.SelectedIndex < 0)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, cboTipo, "ERR-VAL-007", "Seleccione el tipo de proyecto.");
                }
                else
                {
                    errorProviderValidacion.SetError(cboTipo, "");
                }
            }
            if (sender == cboArea)
            {
                if (cboArea.SelectedIndex < 0)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, cboArea, "ERR-VAL-007", "Seleccione el área solicitante.");
                }
                else
                {
                    errorProviderValidacion.SetError(cboArea, "");
                }
            }
            if (sender == cboResponsable)
            {
                if (cboResponsable.SelectedIndex < 0)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, cboResponsable, "ERR-VAL-007", "Seleccione el responsable.");
                }
                else
                {
                    errorProviderValidacion.SetError(cboResponsable, "");
                }
            }
            if (sender == cboPrioridad)
            {
                if (cboPrioridad.SelectedIndex < 0)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, cboPrioridad, "ERR-VAL-007", "Seleccione la prioridad.");
                }
                else
                {
                    errorProviderValidacion.SetError(cboPrioridad, "");
                }
            }
            if (sender == dtpCierre || sender == dtpInicio)
            {
                if (dtpCierre.Value.Date < dtpInicio.Value.Date)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, dtpCierre, "ERR-VAL-004", "La fecha de cierre no puede ser anterior al inicio.");
                }
                else
                {
                    errorProviderValidacion.SetError(dtpCierre, "");
                }
            }
        }

        private void Codigo_Leave(object sender, EventArgs e)
        {
            if (validacionEnTiempoRealHabilitada == false || proyectoModelo == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtCodigo.Text.Trim()) == true)
            {
                return;
            }
            if (errorProviderValidacion.GetError(txtCodigo) != "")
            {
                return;
            }
            if (proyectoModelo.ExisteCodigoProyecto(txtCodigo.Text.Trim()) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtCodigo, "ERR-VAL-005", "El código del proyecto ya existe.");
            }
        }

    }
}
