using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmNuevaTarea : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;
        private System.Windows.Forms.ErrorProvider errorProviderValidacion;

        private Proyecto proyectoModelo;
        private EquipoProyecto equipoModelo;
        private Prioridad prioridadModelo;
        private EstadoTarea estadoTareaModelo;
        private Tarea tareaModelo;

        public event EventHandler VolverSolicitado;
        public event EventHandler TareaGuardada;

        public int IdTarea { get; set; }

        public frmNuevaTarea()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            errorProviderValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            errorProviderValidacion.ContainerControl = this;
            errorProviderValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            toolTipAyuda.SetToolTip(txtNombre, "Ingrese nombre.");
            toolTipAyuda.SetToolTip(cmbProyecto, "Seleccione proyecto.");
            toolTipAyuda.SetToolTip(cmbResponsable, "Seleccione un colaborador activo del equipo del proyecto.");
            toolTipAyuda.SetToolTip(dtpInicio, "Seleccione fecha de inicio.");
            toolTipAyuda.SetToolTip(dtpLimite, "Seleccione fecha límite.");
            toolTipAyuda.SetToolTip(cmbPrioridad, "Seleccione prioridad.");
            toolTipAyuda.SetToolTip(cmbEstado, "Seleccione estado.");
            toolTipAyuda.SetToolTip(txtDescripcion, "Ingrese descripción.");
            toolTipAyuda.SetToolTip(txtObservaciones, "Ingrese observaciones.");
            toolTipAyuda.SetToolTip(btnCancelar, "Cancelar la operación actual.");
            toolTipAyuda.SetToolTip(btnCrear, "Crear la tarea con la información ingresada.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
        }

        private void frmNuevaTarea_Load(object sender, EventArgs e)
        {
            proyectoModelo = new Proyecto();
            equipoModelo = new EquipoProyecto();
            prioridadModelo = new Prioridad();
            estadoTareaModelo = new EstadoTarea();
            tareaModelo = new Tarea();
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            CargarCombos();
            PrepararFormulario();
        }

        private void CargarCombos()
        {
            DataTable proyectos;
            DataTable prioridades;
            DataTable estados;

            if (Sesion.UsuarioActual == null)
            {
                proyectos = proyectoModelo.ObtenerCatalogoProyectos();
            }
            else
            {
                proyectos = proyectoModelo.ObtenerCatalogoProyectosResponsable(Sesion.UsuarioActual.IdUsuario);
            }

            prioridades = prioridadModelo.ObtenerPrioridades();
            estados = estadoTareaModelo.ObtenerEstadosTarea();

            cmbProyecto.DisplayMember = "Proyecto";
            cmbProyecto.ValueMember = "IdProyecto";
            cmbProyecto.DataSource = proyectos;
            cmbResponsable.DataSource = null;
            cmbResponsable.Items.Clear();
            cmbResponsable.Enabled = false;
            cmbPrioridad.DisplayMember = "Nombre";
            cmbPrioridad.ValueMember = "IdPrioridad";
            cmbPrioridad.DataSource = prioridades;
            cmbEstado.DisplayMember = "Nombre";
            cmbEstado.ValueMember = "IdEstadoTarea";
            cmbEstado.DataSource = estados;
        }

        private void CargarResponsablesProyecto()
        {
            DataTable equipo;
            int idProyecto;

            cmbResponsable.DataSource = null;
            cmbResponsable.Items.Clear();
            cmbResponsable.Enabled = false;

            if (cmbProyecto.SelectedValue == null)
            {
                return;
            }

            idProyecto = Convert.ToInt32(cmbProyecto.SelectedValue);
            equipo = equipoModelo.ObtenerColaboradoresProyecto(idProyecto);
            cmbResponsable.DisplayMember = "NombreCompleto";
            cmbResponsable.ValueMember = "IdUsuario";
            cmbResponsable.DataSource = equipo;
            cmbResponsable.SelectedIndex = -1;

            if (equipo.Rows.Count > 0)
            {
                cmbResponsable.Enabled = true;
            }
        }

        private void cmbProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarResponsablesProyecto();
        }

        private void PrepararFormulario()
        {
            if (IdTarea > 0)
            {
                CargarTareaEdicion();
                return;
            }

            cmbProyecto.SelectedIndex = -1;
            cmbResponsable.SelectedIndex = -1;
            cmbPrioridad.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            cmbEstado.Enabled = true;
            dtpInicio.Value = DateTime.Today;
            dtpLimite.Value = DateTime.Today.AddDays(1);
            btnCrear.Text = "Crear tarea";
        }

        private void CargarTareaEdicion()
        {
            DataTable datos;
            DataRow fila;
            int idProyecto;
            int idResponsable;

            datos = tareaModelo.ObtenerTareaParaEditar(IdTarea);

            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró la tarea seleccionada.");
                return;
            }

            fila = datos.Rows[0];
            idProyecto = Convert.ToInt32(fila["IdProyecto"]);
            idResponsable = Convert.ToInt32(fila["IdResponsable"]);

            lblBreadcrumbBase.Text = "Tareas > Detalle de tarea >";
            lblBreadcrumbActual.Text = "Editar tarea";
            lblTitulo.Text = "Editar tarea";
            lblSubtitulo.Text = "Actualice los datos necesarios de la tarea.";
            lblTituloFormulario.Text = "Datos de la tarea";
            btnCrear.Text = "Guardar cambios";

            cmbProyecto.SelectedValue = idProyecto;
            CargarResponsablesProyecto();
            cmbResponsable.SelectedValue = idResponsable;

            if (cmbResponsable.SelectedIndex < 0)
            {
                MessageBox.Show("El responsable actual no es un colaborador activo del equipo. Seleccione otro responsable.");
            }

            cmbPrioridad.SelectedValue = Convert.ToInt32(fila["IdPrioridad"]);
            cmbEstado.SelectedValue = Convert.ToInt32(fila["IdEstadoTarea"]);
            cmbEstado.Enabled = false;
            txtNombre.Text = fila["Nombre"].ToString();
            txtDescripcion.Text = fila["Descripcion"].ToString();

            if (fila["Observacion"] != DBNull.Value)
            {
                txtObservaciones.Text = fila["Observacion"].ToString();
            }
            else
            {
                txtObservaciones.Clear();
            }

            dtpInicio.Value = Convert.ToDateTime(fila["FechaInicio"]);
            dtpLimite.Value = Convert.ToDateTime(fila["FechaLimite"]);
        }

        private bool ValidarDatos()
        {
            errorProviderValidacion.Clear();
            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("No hay una sesión activa.");
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()) == true)
            {
                errorProviderValidacion.SetError(txtNombre, "Ingrese el nombre de la tarea.");
                MessageBox.Show("Ingrese el nombre de la tarea.");
                txtNombre.Focus();
                return false;
            }

            if (cmbProyecto.SelectedValue == null)
            {
                errorProviderValidacion.SetError(cmbProyecto, "Seleccione el proyecto.");
                MessageBox.Show("Seleccione el proyecto.");
                cmbProyecto.Focus();
                return false;
            }

            if (cmbResponsable.Items.Count == 0)
            {
                errorProviderValidacion.SetError(cmbResponsable, "El proyecto no tiene colaboradores activos.");
                MessageBox.Show("El proyecto seleccionado no tiene colaboradores activos. Agregue un colaborador al equipo de trabajo antes de asignar tareas.");
                cmbProyecto.Focus();
                return false;
            }

            if (cmbResponsable.SelectedValue == null)
            {
                errorProviderValidacion.SetError(cmbResponsable, "Seleccione el responsable de la tarea.");
                MessageBox.Show("Seleccione un colaborador activo del equipo como responsable de la tarea.");
                cmbResponsable.Focus();
                return false;
            }

            if (cmbPrioridad.SelectedIndex < 0)
            {
                errorProviderValidacion.SetError(cmbPrioridad, "Seleccione la prioridad de la tarea.");
                MessageBox.Show("Seleccione la prioridad de la tarea.");
                cmbPrioridad.Focus();
                return false;
            }

            if (cmbEstado.SelectedIndex < 0)
            {
                errorProviderValidacion.SetError(cmbEstado, "Seleccione el estado inicial de la tarea.");
                MessageBox.Show("Seleccione el estado inicial de la tarea.");
                cmbEstado.Focus();
                return false;
            }

            if (dtpLimite.Value.Date < dtpInicio.Value.Date)
            {
                errorProviderValidacion.SetError(dtpLimite, "La fecha límite no puede ser anterior a la fecha de inicio.");
                MessageBox.Show("La fecha límite no puede ser anterior a la fecha de inicio.");
                dtpLimite.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()) == true)
            {
                errorProviderValidacion.SetError(txtDescripcion, "Ingrese la descripción de la tarea.");
                MessageBox.Show("Ingrese la descripción de la tarea.");
                txtDescripcion.Focus();
                return false;
            }

            return true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            bool datosCorrectos;
            Tarea tarea;

            datosCorrectos = ValidarDatos();

            if (datosCorrectos == false)
            {
                return;
            }

            tarea = new Tarea();
            tarea.IdProyecto = Convert.ToInt32(cmbProyecto.SelectedValue);
            tarea.Nombre = txtNombre.Text.Trim();
            tarea.Descripcion = txtDescripcion.Text.Trim();
            tarea.Observaciones = txtObservaciones.Text.Trim();
            tarea.IdResponsable = Convert.ToInt32(cmbResponsable.SelectedValue);
            tarea.IdCreador = Sesion.UsuarioActual.IdUsuario;
            tarea.IdPrioridad = Convert.ToInt32(cmbPrioridad.SelectedValue);
            tarea.IdEstadoTarea = Convert.ToInt32(cmbEstado.SelectedValue);
            tarea.FechaInicio = dtpInicio.Value.Date;
            tarea.FechaLimite = dtpLimite.Value.Date;

            if (IdTarea > 0)
            {
                bool actualizada;

                tarea.IdTarea = IdTarea;
                actualizada = tarea.ActualizarTarea();

                if (actualizada == true)
                {
                    MessageBox.Show("La tarea fue actualizada correctamente.");

                    if (TareaGuardada != null)
                    {
                        TareaGuardada(this, EventArgs.Empty);
                    }
                }

                return;
            }

            tarea.AvanceActual = 0;

            if (tarea.CrearTarea() == true)
            {
                MessageBox.Show("La tarea fue creada correctamente.");
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtObservaciones.Clear();
            PrepararFormulario();
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (VolverSolicitado != null)
            {
                VolverSolicitado(this, EventArgs.Empty);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                permitido = true;
            }
            else if (e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == '.')
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
