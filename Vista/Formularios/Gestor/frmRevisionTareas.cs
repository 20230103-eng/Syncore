using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmRevisionTareas : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;
        private System.Windows.Forms.ErrorProvider errorProviderValidacion;

        private RevisionTarea revisionModelo;
        private DataTable revisionesOriginales;
        private int idRevisionSeleccionada;
        private int idTareaSeleccionada;

        public event EventHandler VerDetalleSolicitado;

        public int IdTareaSeleccionada
        {
            get
            {
                return idTareaSeleccionada;
            }
        }

        public frmRevisionTareas()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            errorProviderValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            errorProviderValidacion.ContainerControl = this;
            errorProviderValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            toolTipAyuda.SetToolTip(txtBuscar, "Escriba el texto que desea buscar.");
            toolTipAyuda.SetToolTip(dgvRevisiones, "Muestra las revisiones disponibles.");
            toolTipAyuda.SetToolTip(txtDescripcion, "Muestra descripción.");
            toolTipAyuda.SetToolTip(txtObservaciones, "Muestra observaciones.");
            toolTipAyuda.SetToolTip(txtUltimoAvance, "Muestra último avance.");
            toolTipAyuda.SetToolTip(txtComentario, "Ingrese comentario.");
            toolTipAyuda.SetToolTip(btnVerDetalle, "Ver el detalle del registro seleccionado.");
            toolTipAyuda.SetToolTip(btnSolicitarCorreccion, "Solicitar correcciones para la tarea seleccionada.");
            toolTipAyuda.SetToolTip(btnAprobar, "Aprobar la tarea seleccionada.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);

            ucPaginador.Tabla = dgvRevisiones;
            ucPaginador.PaginaCambiada += ucPaginador_PaginaCambiada;
        }

        private void frmRevisionTareas_Load(object sender, EventArgs e)
        {
            revisionModelo = new RevisionTarea();
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            idRevisionSeleccionada = 0;
            idTareaSeleccionada = 0;
            ConfigurarTabla();
            CargarRevisiones();
        }

        private void ConfigurarTabla()
        {
            dgvRevisiones.AutoGenerateColumns = true;
            dgvRevisiones.DataSource = null;
        }

        private void CargarRevisiones()
        {
            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("No hay una sesión activa.");
                DeshabilitarDetalle();
                return;
            }

            if (Sesion.UsuarioActual.TipoUsuario != "Gestor")
            {
                MessageBox.Show("Solo un gestor puede revisar tareas.");
                DeshabilitarDetalle();
                return;
            }

            revisionModelo.PrepararRevisionesPendientesGestor(Sesion.UsuarioActual.IdUsuario);
            revisionesOriginales = revisionModelo.ObtenerRevisionesPendientes(Sesion.UsuarioActual.IdUsuario);
            lblCantidad.Text = revisionesOriginales.Rows.Count.ToString() + " pendiente(s)";
            AplicarBusqueda();
        }

        private void AplicarBusqueda()
        {
            DataTable filtradas;
            string texto;

            if (revisionesOriginales == null)
            {
                return;
            }

            filtradas = revisionesOriginales.Clone();
            texto = txtBuscar.Text.Trim().ToLower();

            foreach (DataRow fila in revisionesOriginales.Rows)
            {
                bool coincide;

                coincide = true;

                if (string.IsNullOrEmpty(texto) == false)
                {
                    coincide = false;

                    if (fila["Tarea"].ToString().ToLower().Contains(texto) == true)
                    {
                        coincide = true;
                    }
                    else if (fila["Proyecto"].ToString().ToLower().Contains(texto) == true)
                    {
                        coincide = true;
                    }
                    else if (fila["Responsable"].ToString().ToLower().Contains(texto) == true)
                    {
                        coincide = true;
                    }
                }

                if (coincide == true)
                {
                    filtradas.ImportRow(fila);
                }
            }

            ucPaginador.Mostrar(filtradas);
            PrepararColumnas();

            if (dgvRevisiones.Rows.Count > 0)
            {
                dgvRevisiones.ClearSelection();
                dgvRevisiones.Rows[0].Selected = true;
                CargarDetalleFila(dgvRevisiones.Rows[0]);
            }
            else
            {
                DeshabilitarDetalle();
            }
        }

        private void PrepararColumnas()
        {
            OcultarColumna("IdRevision");
            OcultarColumna("IdTarea");
            OcultarColumna("AvanceActual");
            OcultarColumna("Descripcion");
            OcultarColumna("Observaciones");
            OcultarColumna("UltimoAvance");
            OcultarColumna("Evidencias");

            if (dgvRevisiones.Columns.Contains("Tarea") == true)
            {
                dgvRevisiones.Columns["Tarea"].HeaderText = "TAREA";
                dgvRevisiones.Columns["Tarea"].FillWeight = 30;
            }

            if (dgvRevisiones.Columns.Contains("Proyecto") == true)
            {
                dgvRevisiones.Columns["Proyecto"].HeaderText = "PROYECTO";
                dgvRevisiones.Columns["Proyecto"].FillWeight = 25;
            }

            if (dgvRevisiones.Columns.Contains("Responsable") == true)
            {
                dgvRevisiones.Columns["Responsable"].HeaderText = "RESPONSABLE";
                dgvRevisiones.Columns["Responsable"].FillWeight = 20;
            }

            if (dgvRevisiones.Columns.Contains("FechaEnvio") == true)
            {
                dgvRevisiones.Columns["FechaEnvio"].HeaderText = "ENVIADA";
                dgvRevisiones.Columns["FechaEnvio"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvRevisiones.Columns["FechaEnvio"].FillWeight = 13;
            }

            if (dgvRevisiones.Columns.Contains("FechaLimite") == true)
            {
                dgvRevisiones.Columns["FechaLimite"].Visible = false;
            }

            if (dgvRevisiones.Columns.Contains("Prioridad") == true)
            {
                dgvRevisiones.Columns["Prioridad"].HeaderText = "PRIORIDAD";
                dgvRevisiones.Columns["Prioridad"].FillWeight = 12;
            }
        }

        private void OcultarColumna(string nombre)
        {
            if (dgvRevisiones.Columns.Contains(nombre) == true)
            {
                dgvRevisiones.Columns[nombre].Visible = false;
            }
        }

        private void dgvRevisiones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRevisiones.SelectedRows.Count == 0)
            {
                return;
            }

            CargarDetalleFila(dgvRevisiones.SelectedRows[0]);
        }

        private void CargarDetalleFila(DataGridViewRow fila)
        {
            string observaciones;

            if (fila == null)
            {
                DeshabilitarDetalle();
                return;
            }

            idRevisionSeleccionada = Convert.ToInt32(fila.Cells["IdRevision"].Value);
            idTareaSeleccionada = Convert.ToInt32(fila.Cells["IdTarea"].Value);
            observaciones = "Sin observaciones";

            if (fila.Cells["Observaciones"].Value != DBNull.Value)
            {
                if (string.IsNullOrEmpty(fila.Cells["Observaciones"].Value.ToString().Trim()) == false)
                {
                    observaciones = fila.Cells["Observaciones"].Value.ToString();
                }
            }

            lblTareaValor.Text = fila.Cells["Tarea"].Value.ToString();
            lblProyectoValor.Text = fila.Cells["Proyecto"].Value.ToString();
            lblResponsableValor.Text = fila.Cells["Responsable"].Value.ToString();
            lblEnvioValor.Text = Convert.ToDateTime(fila.Cells["FechaEnvio"].Value).ToString("dd/MM/yyyy HH:mm");
            lblLimiteValor.Text = Convert.ToDateTime(fila.Cells["FechaLimite"].Value).ToString("dd/MM/yyyy");
            lblPrioridadValor.Text = fila.Cells["Prioridad"].Value.ToString();
            lblAvanceValor.Text = Convert.ToDecimal(fila.Cells["AvanceActual"].Value).ToString("0") + "%";
            lblEvidenciasValor.Text = fila.Cells["Evidencias"].Value.ToString() + " archivo(s)";
            txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            txtObservaciones.Text = observaciones;
            txtUltimoAvance.Text = fila.Cells["UltimoAvance"].Value.ToString();
            txtComentario.Clear();
            AplicarPrioridad();
            HabilitarDetalle();
        }

        private void AplicarPrioridad()
        {
            lblPrioridadValor.BackColor = Color.FromArgb(238, 242, 247);
            lblPrioridadValor.ForeColor = Color.FromArgb(79, 93, 109);

            if (lblPrioridadValor.Text == "Alta")
            {
                lblPrioridadValor.BackColor = Color.FromArgb(255, 232, 232);
                lblPrioridadValor.ForeColor = Color.FromArgb(207, 48, 57);
            }
            else if (lblPrioridadValor.Text == "Media")
            {
                lblPrioridadValor.BackColor = Color.FromArgb(255, 244, 220);
                lblPrioridadValor.ForeColor = Color.FromArgb(197, 120, 35);
            }
        }

        private void HabilitarDetalle()
        {
            pnlDetalle.Enabled = true;
            btnVerDetalle.Enabled = true;
            btnSolicitarCorreccion.Enabled = true;
            btnAprobar.Enabled = true;
        }

        private void DeshabilitarDetalle()
        {
            idRevisionSeleccionada = 0;
            idTareaSeleccionada = 0;
            lblTareaValor.Text = "Seleccione una tarea";
            lblProyectoValor.Text = "—";
            lblResponsableValor.Text = "—";
            lblEnvioValor.Text = "—";
            lblLimiteValor.Text = "—";
            lblPrioridadValor.Text = "—";
            lblAvanceValor.Text = "—";
            lblEvidenciasValor.Text = "—";
            txtDescripcion.Clear();
            txtObservaciones.Clear();
            txtUltimoAvance.Clear();
            txtComentario.Clear();
            pnlDetalle.Enabled = false;
            btnVerDetalle.Enabled = false;
            btnSolicitarCorreccion.Enabled = false;
            btnAprobar.Enabled = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarBusqueda();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (idTareaSeleccionada <= 0)
            {
                return;
            }

            if (VerDetalleSolicitado != null)
            {
                VerDetalleSolicitado(this, EventArgs.Empty);
            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            RevisionTarea revision;
            DialogResult respuesta;
            bool aprobada;

            if (ValidarSeleccion() == false)
            {
                return;
            }

            if (AsegurarRevisionSeleccionada() == false)
            {
                return;
            }

            respuesta = MessageBox.Show("¿Desea aprobar esta tarea?", "Aprobar tarea", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            revision = new RevisionTarea();
            revision.IdRevision = idRevisionSeleccionada;
            revision.IdTarea = idTareaSeleccionada;
            revision.IdRevisor = Sesion.UsuarioActual.IdUsuario;
            revision.Comentario = txtComentario.Text.Trim();
            aprobada = revision.AprobarRevision();

            if (aprobada == false)
            {
                return;
            }

            MessageBox.Show("La tarea fue aprobada y marcada como completada.");
            CargarRevisiones();
        }

        private void btnSolicitarCorreccion_Click(object sender, EventArgs e)
        {
            RevisionTarea revision;
            DialogResult respuesta;
            bool devuelta;

            errorProviderValidacion.Clear();

            if (ValidarSeleccion() == false)
            {
                return;
            }

            if (AsegurarRevisionSeleccionada() == false)
            {
                return;
            }

            if (string.IsNullOrEmpty(txtComentario.Text.Trim()) == true)
            {
                errorProviderValidacion.SetError(txtComentario, "Escriba la corrección solicitada.");
                MessageBox.Show("Escriba la corrección que debe realizar el colaborador.");
                txtComentario.Focus();
                return;
            }

            respuesta = MessageBox.Show("¿Desea devolver esta tarea para corrección?", "Solicitar corrección", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            revision = new RevisionTarea();
            revision.IdRevision = idRevisionSeleccionada;
            revision.IdTarea = idTareaSeleccionada;
            revision.IdRevisor = Sesion.UsuarioActual.IdUsuario;
            revision.Comentario = txtComentario.Text.Trim();
            devuelta = revision.SolicitarCorreccion();

            if (devuelta == false)
            {
                return;
            }

            MessageBox.Show("La tarea fue devuelta al colaborador con la observación indicada.");
            CargarRevisiones();
        }


        private bool AsegurarRevisionSeleccionada()
        {
            int idRevision;

            if (idTareaSeleccionada <= 0)
            {
                return false;
            }

            if (idRevisionSeleccionada > 0)
            {
                return true;
            }

            if (Sesion.UsuarioActual == null)
            {
                return false;
            }

            idRevision = revisionModelo.AsegurarRevisionPendiente(idTareaSeleccionada, Sesion.UsuarioActual.IdUsuario);

            if (idRevision <= 0)
            {
                MessageBox.Show("No se pudo preparar la revisión de esta tarea.");
                return false;
            }

            idRevisionSeleccionada = idRevision;
            return true;
        }

        private bool ValidarSeleccion()
        {
            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("No hay una sesión activa.");
                return false;
            }

            if (idRevisionSeleccionada <= 0 || idTareaSeleccionada <= 0)
            {
                MessageBox.Show("Seleccione una tarea para revisar.");
                return false;
            }

            return true;
        }
        private void ucPaginador_PaginaCambiada(object sender, EventArgs e)
        {
            DeshabilitarDetalle();
        }

    }
}
