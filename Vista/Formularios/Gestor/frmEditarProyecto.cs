using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmEditarProyecto : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;
        private System.Windows.Forms.ErrorProvider errorProviderValidacion;

        private Proyecto proyectoModelo;
        private Usuario usuarioModelo;
        private Area areaModelo;
        private TipoProyecto tipoProyectoModelo;
        private Prioridad prioridadModelo;

        public event EventHandler ProyectoActualizado;
        public event EventHandler ProyectoCerrado;
        public event EventHandler ProyectoEliminado;
        public event EventHandler VolverSolicitado;

        public int IdProyecto { get; set; }
        private string estadoActual;

        public frmEditarProyecto()
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
            toolTipAyuda.SetToolTip(btnGuardar, "Guardar la información ingresada.");
            toolTipAyuda.SetToolTip(btnCerrarProyecto, "Cerrar el proyecto.");
            toolTipAyuda.SetToolTip(btnCancelar, "Cancelar la operación actual.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
        }

        private void frmEditarProyecto_Load(object sender, EventArgs e)
        {
            proyectoModelo = new Proyecto();
            usuarioModelo = new Usuario();
            areaModelo = new Area();
            tipoProyectoModelo = new TipoProyecto();
            prioridadModelo = new Prioridad();
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            AjustarBreadcrumb();
            CargarCombos();
            CargarProyecto();
        }

        private void AjustarBreadcrumb()
        {
            lblBreadcrumbActual.Left = lblBreadcrumbBase.Right + 8;
        }

        private void CargarCombos()
        {
            DataTable tiposProyecto;
            DataTable areas;
            DataTable responsables;
            DataTable prioridades;

            tiposProyecto = tipoProyectoModelo.ObtenerTiposProyecto();
            areas = areaModelo.ObtenerAreas();
            responsables = usuarioModelo.ObtenerUsuariosActivos();
            prioridades = prioridadModelo.ObtenerPrioridades();

            cboTipo.DisplayMember = "Nombre";
            cboTipo.ValueMember = "IdTipoProyecto";
            cboTipo.DataSource = tiposProyecto;
            cboArea.DisplayMember = "Nombre";
            cboArea.ValueMember = "IdArea";
            cboArea.DataSource = areas;
            cboResponsable.DisplayMember = "NombreCompleto";
            cboResponsable.ValueMember = "IdUsuario";
            cboResponsable.DataSource = responsables;
            cboPrioridad.DisplayMember = "Nombre";
            cboPrioridad.ValueMember = "IdPrioridad";
            cboPrioridad.DataSource = prioridades;
        }

        private void CargarProyecto()
        {
            DataTable datos;
            DataRow fila;
            DateTime fechaModificacion;

            if (IdProyecto <= 0)
            {
                MessageBox.Show("No se recibió un proyecto válido.");
                pnlFormulario.Enabled = false;
                return;
            }

            datos = proyectoModelo.ObtenerProyectoPorId(IdProyecto);

            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró el proyecto.");
                pnlFormulario.Enabled = false;
                return;
            }

            fila = datos.Rows[0];
            estadoActual = fila["Estado"].ToString();
            txtNombre.Text = fila["Nombre"].ToString();
            txtCodigo.Text = fila["Codigo"].ToString();
            cboTipo.SelectedValue = Convert.ToInt32(fila["IdTipoProyecto"]);
            cboArea.SelectedValue = Convert.ToInt32(fila["IdArea"]);
            cboResponsable.SelectedValue = Convert.ToInt32(fila["IdResponsable"]);
            cboPrioridad.SelectedValue = Convert.ToInt32(fila["IdPrioridad"]);
            dtpInicio.Value = Convert.ToDateTime(fila["FechaInicio"]);
            dtpCierre.Value = Convert.ToDateTime(fila["FechaCierreEstimada"]);
            txtObjetivo.Text = fila["Objetivo"].ToString();
            txtJustificacion.Text = ObtenerTexto(fila["Justificacion"]);
            txtAlcance.Text = ObtenerTexto(fila["Alcance"]);
            txtResultado.Text = fila["ResultadoEsperado"].ToString();
            txtObservaciones.Text = ObtenerTexto(fila["Observaciones"]);

            fechaModificacion = Convert.ToDateTime(fila["FechaCreacion"]);

            if (fila["UltimaModificacion"] != DBNull.Value)
            {
                fechaModificacion = Convert.ToDateTime(fila["UltimaModificacion"]);
            }

            lblModificacion.Text = "Última modificación: " + fechaModificacion.ToString("dd/MM/yyyy");
            PrepararBotonCerrar();
        }


        private void PrepararBotonCerrar()
        {
            btnCerrarProyecto.Enabled = true;
            btnCerrarProyecto.Text = "Cerrar proyecto";

            if (estadoActual == "Cerrado")
            {
                btnCerrarProyecto.Text = "Eliminar proyecto";
            }
        }

        private string ObtenerTexto(object valor)
        {
            if (valor == DBNull.Value)
            {
                return "";
            }

            return valor.ToString();
        }

        private bool ValidarDatos()
        {
            bool codigoExiste;
            errorProviderValidacion.Clear();

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()) == true)
            {
                errorProviderValidacion.SetError(txtNombre, "Ingrese el nombre del proyecto.");
                MessageBox.Show("Ingrese el nombre del proyecto.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCodigo.Text.Trim()) == true)
            {
                errorProviderValidacion.SetError(txtCodigo, "Ingrese el código del proyecto.");
                MessageBox.Show("Ingrese el código del proyecto.");
                txtCodigo.Focus();
                return false;
            }

            codigoExiste = proyectoModelo.ExisteCodigoProyectoEnOtroProyecto(txtCodigo.Text.Trim(), IdProyecto);

            if (codigoExiste == true)
            {
                errorProviderValidacion.SetError(txtCodigo, "El código ya pertenece a otro proyecto.");
                MessageBox.Show("El código ya pertenece a otro proyecto.");
                txtCodigo.Focus();
                return false;
            }

            if (cboTipo.SelectedValue == null)
            {
                errorProviderValidacion.SetError(cboTipo, "Seleccione el tipo de proyecto.");
                MessageBox.Show("Seleccione el tipo de proyecto.");
                cboTipo.Focus();
                return false;
            }

            if (cboArea.SelectedValue == null)
            {
                errorProviderValidacion.SetError(cboArea, "Seleccione el área solicitante.");
                MessageBox.Show("Seleccione el área solicitante.");
                cboArea.Focus();
                return false;
            }

            if (cboResponsable.SelectedValue == null)
            {
                errorProviderValidacion.SetError(cboResponsable, "Seleccione el responsable.");
                MessageBox.Show("Seleccione el responsable principal.");
                cboResponsable.Focus();
                return false;
            }

            if (cboPrioridad.SelectedIndex < 0)
            {
                errorProviderValidacion.SetError(cboPrioridad, "Seleccione la prioridad.");
                MessageBox.Show("Seleccione la prioridad.");
                cboPrioridad.Focus();
                return false;
            }

            if (dtpCierre.Value.Date < dtpInicio.Value.Date)
            {
                errorProviderValidacion.SetError(dtpCierre, "Revise la fecha de cierre.");
                MessageBox.Show("La fecha de cierre no puede ser anterior a la fecha de inicio.");
                dtpCierre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtObjetivo.Text.Trim()) == true)
            {
                errorProviderValidacion.SetError(txtObjetivo, "Ingrese el objetivo.");
                MessageBox.Show("Ingrese el objetivo del proyecto.");
                txtObjetivo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtResultado.Text.Trim()) == true)
            {
                errorProviderValidacion.SetError(txtResultado, "Ingrese el resultado esperado.");
                MessageBox.Show("Ingrese el resultado esperado.");
                txtResultado.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool datosCorrectos;
            bool actualizado;
            Proyecto proyecto;

            datosCorrectos = ValidarDatos();

            if (datosCorrectos == false)
            {
                return;
            }

            proyecto = new Proyecto();
            proyecto.IdProyecto = IdProyecto;
            proyecto.Codigo = txtCodigo.Text.Trim();
            proyecto.Nombre = txtNombre.Text.Trim();
            proyecto.Objetivo = txtObjetivo.Text.Trim();
            proyecto.Justificacion = txtJustificacion.Text.Trim();
            proyecto.Alcance = txtAlcance.Text.Trim();
            proyecto.ResultadoEsperado = txtResultado.Text.Trim();
            proyecto.Observaciones = txtObservaciones.Text.Trim();
            proyecto.IdArea = Convert.ToInt32(cboArea.SelectedValue);
            proyecto.IdTipoProyecto = Convert.ToInt32(cboTipo.SelectedValue);
            proyecto.IdResponsable = Convert.ToInt32(cboResponsable.SelectedValue);
            proyecto.IdPrioridad = Convert.ToInt32(cboPrioridad.SelectedValue);
            proyecto.FechaInicio = dtpInicio.Value.Date;
            proyecto.FechaCierreEstimada = dtpCierre.Value.Date;

            actualizado = proyecto.ActualizarProyecto();

            if (actualizado == true)
            {
                MessageBox.Show("Los cambios fueron guardados correctamente.");

                if (ProyectoActualizado != null)
                {
                    ProyectoActualizado(this, EventArgs.Empty);
                }
            }
        }

        private void btnCerrarProyecto_Click(object sender, EventArgs e)
        {
            if (estadoActual == "Cerrado")
            {
                EliminarProyecto();
                return;
            }

            CerrarProyecto();
        }

        private void CerrarProyecto()
        {
            bool cerrado;
            DialogResult respuesta;
            Proyecto proyecto;

            respuesta = MessageBox.Show("¿Desea cerrar este proyecto? La información no se eliminará. El proyecto quedará oculto de las vistas activas y podrá consultarse con el filtro Cerrado.", "Cerrar proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            proyecto = new Proyecto();
            proyecto.IdProyecto = IdProyecto;
            cerrado = proyecto.CerrarProyecto();

            if (cerrado == true)
            {
                MessageBox.Show("El proyecto fue cerrado y archivado correctamente.");

                if (ProyectoCerrado != null)
                {
                    ProyectoCerrado(this, EventArgs.Empty);
                }
            }
        }

        private void EliminarProyecto()
        {
            bool eliminado;
            DialogResult respuesta;
            Proyecto proyecto;

            respuesta = MessageBox.Show("¿Desea eliminar definitivamente este proyecto cerrado? Se eliminarán también sus tareas, avances, evidencias, revisiones, comentarios, integrantes, hitos y notificaciones. Esta acción no se puede deshacer.", "Eliminar proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            proyecto = new Proyecto();
            proyecto.IdProyecto = IdProyecto;
            eliminado = proyecto.EliminarProyectoCerrado();

            if (eliminado == true)
            {
                MessageBox.Show("El proyecto cerrado fue eliminado definitivamente.");

                if (ProyectoEliminado != null)
                {
                    ProyectoEliminado(this, EventArgs.Empty);
                }
            }
            else
            {
                MessageBox.Show("El proyecto no pudo eliminarse. Verifique que esté cerrado.");
            }
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
