using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmHitosEntregables : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;
        private System.Windows.Forms.ErrorProvider errorProviderValidacion;

        private Hito hitoModelo;
        private Proyecto proyectoModelo;
        private EquipoProyecto equipoModelo;
        private DataTable hitosOriginales;
        private int idHitoSeleccionado;
        private DateTime? fechaCumplimientoSeleccionada;
        private bool cargando;

        public frmHitosEntregables()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            errorProviderValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            errorProviderValidacion.ContainerControl = this;
            errorProviderValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            toolTipAyuda.SetToolTip(cboProyectoFiltro, "Seleccione proyecto para filtrar.");
            toolTipAyuda.SetToolTip(cboEstadoFiltro, "Seleccione estado para filtrar.");
            toolTipAyuda.SetToolTip(txtBuscar, "Escriba el texto que desea buscar.");
            toolTipAyuda.SetToolTip(cboProyecto, "Seleccione proyecto.");
            toolTipAyuda.SetToolTip(txtNombre, "Ingrese nombre.");
            toolTipAyuda.SetToolTip(txtDescripcion, "Ingrese descripción.");
            toolTipAyuda.SetToolTip(dtpFechaObjetivo, "Seleccione fecha objetivo.");
            toolTipAyuda.SetToolTip(cboResponsable, "Seleccione responsable.");
            toolTipAyuda.SetToolTip(cboEstado, "Seleccione estado.");
            toolTipAyuda.SetToolTip(btnNuevo, "Preparar el formulario para un nuevo registro.");
            toolTipAyuda.SetToolTip(btnGuardar, "Guardar la información ingresada.");
            toolTipAyuda.SetToolTip(btnActualizar, "Actualizar la información.");
            toolTipAyuda.SetToolTip(btnCumplir, "Marcar el hito seleccionado como cumplido.");
            toolTipAyuda.SetToolTip(btnEliminar, "Eliminar el registro seleccionado.");
            toolTipAyuda.SetToolTip(dgvHitos, "Muestra los hitos disponibles.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);

            ucPaginador.Tabla = dgvHitos;
            ucPaginador.PaginaCambiada += ucPaginador_PaginaCambiada;
            hitoModelo = new Hito();
            proyectoModelo = new Proyecto();
            equipoModelo = new EquipoProyecto();
            hitosOriginales = new DataTable();
            idHitoSeleccionado = 0;
            fechaCumplimientoSeleccionada = null;
            cargando = false;
        }

        private void frmHitosEntregables_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");

            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("No hay una sesión activa.");
                return;
            }

            if (Sesion.UsuarioActual.TipoUsuario != "Gestor")
            {
                MessageBox.Show("Solo un gestor puede administrar hitos.");
                return;
            }

            CargarCatalogos();
            CargarHitos();
            PrepararNuevo();
        }

        private void CargarCatalogos()
        {
            DataTable proyectos;
            DataTable proyectosFiltro;
            DataTable estados;
            DataTable estadosFiltro;
            DataRow fila;

            proyectos = proyectoModelo.ObtenerCatalogoProyectosResponsable(Sesion.UsuarioActual.IdUsuario);
            proyectosFiltro = proyectos.Copy();
            fila = proyectosFiltro.NewRow();
            fila["IdProyecto"] = 0;
            fila["Proyecto"] = "Todos mis proyectos";
            proyectosFiltro.Rows.InsertAt(fila, 0);

            cargando = true;
            cboProyectoFiltro.DataSource = proyectosFiltro;
            cboProyectoFiltro.DisplayMember = "Proyecto";
            cboProyectoFiltro.ValueMember = "IdProyecto";
            cboProyectoFiltro.SelectedIndex = 0;

            cboProyecto.DataSource = proyectos;
            cboProyecto.DisplayMember = "Proyecto";
            cboProyecto.ValueMember = "IdProyecto";

            estados = hitoModelo.ObtenerEstadosHito();
            estadosFiltro = estados.Copy();
            fila = estadosFiltro.NewRow();
            fila["IdEstadoHito"] = 0;
            fila["Nombre"] = "Todos los estados";
            estadosFiltro.Rows.InsertAt(fila, 0);

            cboEstadoFiltro.DataSource = estadosFiltro;
            cboEstadoFiltro.DisplayMember = "Nombre";
            cboEstadoFiltro.ValueMember = "IdEstadoHito";
            cboEstadoFiltro.SelectedIndex = 0;

            cboEstado.DataSource = estados;
            cboEstado.DisplayMember = "Nombre";
            cboEstado.ValueMember = "IdEstadoHito";
            cargando = false;

            if (cboProyecto.Items.Count > 0)
            {
                cboProyecto.SelectedIndex = 0;
                CargarResponsables();
            }
        }

        private void CargarResponsables()
        {
            int idProyecto;
            DataTable equipo;
            DataRow fila;

            if (cargando == true || cboProyecto.SelectedValue == null)
            {
                return;
            }

            idProyecto = Convert.ToInt32(cboProyecto.SelectedValue);
            equipo = equipoModelo.ObtenerEquipoProyecto(idProyecto);
            fila = equipo.NewRow();
            fila["IdUsuario"] = 0;
            fila["NombreCompleto"] = "Sin responsable";
            fila["Area"] = "";
            fila["RolProyecto"] = "";
            fila["TareasAsignadas"] = 0;
            fila["TareasCompletadas"] = 0;
            fila["TareasVencidas"] = 0;
            equipo.Rows.InsertAt(fila, 0);

            cboResponsable.DataSource = equipo;
            cboResponsable.DisplayMember = "NombreCompleto";
            cboResponsable.ValueMember = "IdUsuario";
            cboResponsable.SelectedIndex = 0;
        }

        private void CargarHitos()
        {
            hitosOriginales = hitoModelo.ObtenerHitosGestor(Sesion.UsuarioActual.IdUsuario);
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            DataTable resultado;
            string texto;
            int idProyectoFiltro;
            int idEstadoFiltro;

            resultado = hitosOriginales.Clone();
            texto = txtBuscar.Text.Trim().ToLower();
            idProyectoFiltro = 0;
            idEstadoFiltro = 0;

            if (cboProyectoFiltro.SelectedValue != null)
            {
                int.TryParse(cboProyectoFiltro.SelectedValue.ToString(), out idProyectoFiltro);
            }

            if (cboEstadoFiltro.SelectedValue != null)
            {
                int.TryParse(cboEstadoFiltro.SelectedValue.ToString(), out idEstadoFiltro);
            }

            foreach (DataRow fila in hitosOriginales.Rows)
            {
                bool mostrar;
                int idProyecto;
                int idEstado;

                mostrar = true;
                idProyecto = Convert.ToInt32(fila["IdProyecto"]);
                idEstado = Convert.ToInt32(fila["IdEstadoHito"]);

                if (idProyectoFiltro > 0 && idProyecto != idProyectoFiltro)
                {
                    mostrar = false;
                }

                if (idEstadoFiltro > 0 && idEstado != idEstadoFiltro)
                {
                    mostrar = false;
                }

                if (string.IsNullOrEmpty(texto) == false)
                {
                    bool coincide;

                    coincide = false;

                    if (fila["Hito"].ToString().ToLower().Contains(texto) == true)
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

                    if (coincide == false)
                    {
                        mostrar = false;
                    }
                }

                if (mostrar == true)
                {
                    resultado.ImportRow(fila);
                }
            }

            cargando = true;
            ucPaginador.Mostrar(resultado);
            ConfigurarTabla();
            lblCantidad.Text = resultado.Rows.Count.ToString() + " hito(s)";
            cargando = false;
        }

        private void ConfigurarTabla()
        {
            if (dgvHitos.Columns.Contains("IdHito") == true)
            {
                dgvHitos.Columns["IdHito"].Visible = false;
            }

            if (dgvHitos.Columns.Contains("IdProyecto") == true)
            {
                dgvHitos.Columns["IdProyecto"].Visible = false;
            }

            if (dgvHitos.Columns.Contains("Descripcion") == true)
            {
                dgvHitos.Columns["Descripcion"].Visible = false;
            }

            if (dgvHitos.Columns.Contains("IdResponsable") == true)
            {
                dgvHitos.Columns["IdResponsable"].Visible = false;
            }

            if (dgvHitos.Columns.Contains("IdEstadoHito") == true)
            {
                dgvHitos.Columns["IdEstadoHito"].Visible = false;
            }

            if (dgvHitos.Columns.Contains("FechaCumplimiento") == true)
            {
                dgvHitos.Columns["FechaCumplimiento"].Visible = false;
            }

            if (dgvHitos.Columns.Contains("Proyecto") == true)
            {
                dgvHitos.Columns["Proyecto"].HeaderText = "PROYECTO";
            }

            if (dgvHitos.Columns.Contains("Hito") == true)
            {
                dgvHitos.Columns["Hito"].HeaderText = "HITO / ENTREGABLE";
            }

            if (dgvHitos.Columns.Contains("FechaObjetivo") == true)
            {
                dgvHitos.Columns["FechaObjetivo"].HeaderText = "FECHA OBJETIVO";
                dgvHitos.Columns["FechaObjetivo"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvHitos.Columns.Contains("Responsable") == true)
            {
                dgvHitos.Columns["Responsable"].HeaderText = "RESPONSABLE";
            }

            if (dgvHitos.Columns.Contains("Estado") == true)
            {
                dgvHitos.Columns["Estado"].HeaderText = "ESTADO";
            }

            dgvHitos.ClearSelection();
        }

        private void PrepararNuevo()
        {
            idHitoSeleccionado = 0;
            fechaCumplimientoSeleccionada = null;
            lblModo.Text = "Nuevo hito / entregable";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            dtpFechaObjetivo.Value = DateTime.Today;
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
            btnCumplir.Enabled = false;
            btnEliminar.Enabled = false;

            if (cboEstado.Items.Count > 0)
            {
                SeleccionarEstado("Planificado");
            }

            if (cboProyecto.Items.Count > 0)
            {
                cboProyecto.SelectedIndex = 0;
            }
        }

        private void SeleccionarEstado(string nombre)
        {
            int indice;

            indice = 0;

            foreach (DataRowView item in cboEstado.Items)
            {
                if (item["Nombre"].ToString() == nombre)
                {
                    cboEstado.SelectedIndex = indice;
                    return;
                }

                indice = indice + 1;
            }
        }

        private bool ValidarDatos()
        {
            errorProviderValidacion.Clear();
            DataTable proyecto;
            DateTime fechaInicio;
            DateTime fechaCierre;
            int idProyecto;

            if (cboProyecto.SelectedValue == null)
            {
                errorProviderValidacion.SetError(cboProyecto, "Seleccione el proyecto.");
                MessageBox.Show("Seleccione el proyecto.");
                cboProyecto.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()) == true)
            {
                errorProviderValidacion.SetError(txtNombre, "Ingrese el nombre del hito o entregable.");
                MessageBox.Show("Ingrese el nombre del hito o entregable.");
                txtNombre.Focus();
                return false;
            }

            if (cboEstado.SelectedValue == null)
            {
                errorProviderValidacion.SetError(cboEstado, "Seleccione el estado.");
                MessageBox.Show("Seleccione el estado.");
                cboEstado.Focus();
                return false;
            }

            idProyecto = Convert.ToInt32(cboProyecto.SelectedValue);
            proyecto = proyectoModelo.ObtenerProyectoPorId(idProyecto);

            if (proyecto.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró el proyecto seleccionado.");
                return false;
            }

            fechaInicio = Convert.ToDateTime(proyecto.Rows[0]["FechaInicio"]);
            fechaCierre = Convert.ToDateTime(proyecto.Rows[0]["FechaCierreEstimada"]);

            if (dtpFechaObjetivo.Value.Date < fechaInicio.Date || dtpFechaObjetivo.Value.Date > fechaCierre.Date)
            {
                errorProviderValidacion.SetError(dtpFechaObjetivo, "La fecha objetivo debe estar dentro de las fechas del proyecto.");
                MessageBox.Show("La fecha objetivo debe estar dentro de las fechas del proyecto.");
                dtpFechaObjetivo.Focus();
                return false;
            }

            return true;
        }

        private Hito CrearHitoFormulario()
        {
            Hito hito;
            int idResponsable;
            string estado;

            hito = new Hito();
            hito.IdHito = idHitoSeleccionado;
            hito.IdProyecto = Convert.ToInt32(cboProyecto.SelectedValue);
            hito.Nombre = txtNombre.Text.Trim();
            hito.Descripcion = txtDescripcion.Text.Trim();
            hito.FechaObjetivo = dtpFechaObjetivo.Value.Date;
            hito.IdEstadoHito = Convert.ToInt32(cboEstado.SelectedValue);
            idResponsable = 0;

            if (cboResponsable.SelectedValue != null)
            {
                int.TryParse(cboResponsable.SelectedValue.ToString(), out idResponsable);
            }

            if (idResponsable > 0)
            {
                hito.IdResponsable = idResponsable;
            }
            else
            {
                hito.IdResponsable = null;
            }

            estado = cboEstado.Text;

            if (estado == "Cumplido")
            {
                if (fechaCumplimientoSeleccionada.HasValue == true)
                {
                    hito.FechaCumplimiento = fechaCumplimientoSeleccionada.Value;
                }
                else
                {
                    hito.FechaCumplimiento = DateTime.Today;
                }
            }
            else
            {
                hito.FechaCumplimiento = null;
            }

            return hito;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PrepararNuevo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Hito hito;

            if (ValidarDatos() == false)
            {
                return;
            }

            hito = CrearHitoFormulario();

            if (hito.CrearHito() == true)
            {
                MessageBox.Show("El hito fue creado correctamente.");
                CargarHitos();
                PrepararNuevo();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Hito hito;

            if (idHitoSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un hito para actualizar.");
                return;
            }

            if (ValidarDatos() == false)
            {
                return;
            }

            hito = CrearHitoFormulario();

            if (hito.ActualizarHito() == true)
            {
                MessageBox.Show("El hito fue actualizado correctamente.");
                CargarHitos();
                PrepararNuevo();
            }
        }

        private void btnCumplir_Click(object sender, EventArgs e)
        {
            if (idHitoSeleccionado <= 0)
            {
                return;
            }

            SeleccionarEstado("Cumplido");
            btnActualizar_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            Hito hito;

            if (idHitoSeleccionado <= 0)
            {
                return;
            }

            respuesta = MessageBox.Show("¿Desea eliminar el hito seleccionado?", "Eliminar hito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            hito = new Hito();
            hito.IdHito = idHitoSeleccionado;

            if (hito.EliminarHito() == true)
            {
                MessageBox.Show("El hito fue eliminado correctamente.");
                CargarHitos();
                PrepararNuevo();
            }
        }

        private void dgvHitos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow fila;

            if (cargando == true)
            {
                return;
            }
            int idProyecto;
            int idResponsable;

            if (dgvHitos.SelectedRows.Count == 0)
            {
                return;
            }

            fila = dgvHitos.SelectedRows[0];

            if (fila.Cells["IdHito"].Value == null)
            {
                return;
            }

            idHitoSeleccionado = Convert.ToInt32(fila.Cells["IdHito"].Value);
            fechaCumplimientoSeleccionada = null;

            if (fila.Cells["FechaCumplimiento"].Value != DBNull.Value)
            {
                fechaCumplimientoSeleccionada = Convert.ToDateTime(fila.Cells["FechaCumplimiento"].Value);
            }

            idProyecto = Convert.ToInt32(fila.Cells["IdProyecto"].Value);
            lblModo.Text = "Editar hito / entregable";
            cboProyecto.SelectedValue = idProyecto;
            CargarResponsables();
            txtNombre.Text = fila.Cells["Hito"].Value.ToString();
            txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            dtpFechaObjetivo.Value = Convert.ToDateTime(fila.Cells["FechaObjetivo"].Value);
            cboEstado.SelectedValue = Convert.ToInt32(fila.Cells["IdEstadoHito"].Value);
            idResponsable = 0;

            if (fila.Cells["IdResponsable"].Value != DBNull.Value)
            {
                idResponsable = Convert.ToInt32(fila.Cells["IdResponsable"].Value);
            }

            cboResponsable.SelectedValue = idResponsable;
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;
            btnCumplir.Enabled = fila.Cells["Estado"].Value.ToString() != "Cumplido";
            btnEliminar.Enabled = true;
        }

        private void cboProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarResponsables();
        }

        private void filtros_Cambio(object sender, EventArgs e)
        {
            if (cargando == false)
            {
                AplicarFiltros();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
        private void ucPaginador_PaginaCambiada(object sender, EventArgs e)
        {
            PrepararNuevo();
        }

    }
}
