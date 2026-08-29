using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmNuevoProyecto : Form
    {
        private Proyecto proyectoModelo;
        private Area areaModelo;
        private TipoProyecto tipoProyectoModelo;
        private Prioridad prioridadModelo;

        public event EventHandler VolverSolicitado;

        public frmNuevoProyecto()
        {
            InitializeComponent();
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
        }

        private bool ValidarDatos()
        {
            bool codigoExiste;

            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("No hay una sesión activa.");
                return false;
            }

            if (Sesion.UsuarioActual.TipoUsuario != "Gestor")
            {
                MessageBox.Show("Solo un gestor puede crear proyectos.");
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()) == true)
            {
                MessageBox.Show("Ingrese el nombre del proyecto.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCodigo.Text.Trim()) == true)
            {
                MessageBox.Show("Ingrese el código del proyecto.");
                txtCodigo.Focus();
                return false;
            }

            codigoExiste = proyectoModelo.ExisteCodigoProyecto(txtCodigo.Text.Trim());

            if (codigoExiste == true)
            {
                MessageBox.Show("El código del proyecto ya existe.");
                txtCodigo.Focus();
                return false;
            }

            if (cboTipo.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el tipo de proyecto.");
                cboTipo.Focus();
                return false;
            }

            if (cboArea.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el área solicitante.");
                cboArea.Focus();
                return false;
            }

            if (cboPrioridad.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione la prioridad del proyecto.");
                cboPrioridad.Focus();
                return false;
            }

            if (dtpCierre.Value.Date < dtpInicio.Value.Date)
            {
                MessageBox.Show("La fecha de cierre no puede ser anterior a la fecha de inicio.");
                dtpCierre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtObjetivo.Text.Trim()) == true)
            {
                MessageBox.Show("Ingrese el objetivo del proyecto.");
                txtObjetivo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtResultado.Text.Trim()) == true)
            {
                MessageBox.Show("Ingrese el resultado esperado.");
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
    }
}
