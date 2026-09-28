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
        private bool validacionEnTiempoRealHabilitada;
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
        
            txtNombre.TextChanged += CamposEnTiempoReal;
            txtNombre.Leave += CamposEnTiempoReal;
            cboProyecto.SelectedIndexChanged += CamposEnTiempoReal;
            cboProyecto.Leave += CamposEnTiempoReal;
            cboEstado.SelectedIndexChanged += CamposEnTiempoReal;
            cboEstado.Leave += CamposEnTiempoReal;
            dtpFechaObjetivo.ValueChanged += CamposEnTiempoReal;
        }

        private void frmHitosEntregables_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");

            if (Sesion.UsuarioActual == null)
            {
                CatalogoErrores.MostrarDetalle("ERR-NEG-001", "Syncore", "No hay una sesión activa.");
                return;
            }

            if (Sesion.UsuarioActual.TipoUsuario != "Gestor")
            {
                CatalogoErrores.MostrarDetalle("ERR-NEG-001", "Syncore", "Solo un gestor puede administrar hitos.");
                return;
            }

            CargarCatalogos();
            CargarHitos();
            PrepararNuevo();
        
            validacionEnTiempoRealHabilitada = true;
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
            ucPaginador.ReiniciarRemoto();
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            int idProyectoFiltro = 0;
            int idEstadoFiltro = 0;
            int total;
            if (Sesion.UsuarioActual == null || cargando)
            {
                return;
            }
            if (cboProyectoFiltro.SelectedValue != null)
            {
                int.TryParse(cboProyectoFiltro.SelectedValue.ToString(), out idProyectoFiltro);
            }
            if (cboEstadoFiltro.SelectedValue != null)
            {
                int.TryParse(cboEstadoFiltro.SelectedValue.ToString(), out idEstadoFiltro);
            }
            int paginaAnterior = ucPaginador.PaginaActual;
            hitosOriginales = hitoModelo.ObtenerHitosGestorPagina(Sesion.UsuarioActual.IdUsuario,
                txtBuscar.Text.Trim(), idProyectoFiltro, idEstadoFiltro,
                paginaAnterior, out total);
            cargando = true;
            ucPaginador.MostrarRemoto(hitosOriginales, total);
            cargando = false;
            if (paginaAnterior != ucPaginador.PaginaActual)
            {
                AplicarFiltros();
                return;
            }
            ConfigurarTabla();
            lblCantidad.Text = total.ToString() + " hito(s)";
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

            if (dgvHitos.Columns.Contains("TareasVencidas") == true)
            {
                dgvHitos.Columns["TareasVencidas"].Visible = false;
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
            errorProviderValidacion.Clear();
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
                CatalogoErrores.MarcarCampo(errorProviderValidacion, cboProyecto, "ERR-VAL-007", "Seleccione el proyecto.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Syncore", "Seleccione el proyecto.");
                cboProyecto.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtNombre, "ERR-VAL-001", "Ingrese el nombre del hito o entregable.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-001", "Syncore", "Ingrese el nombre del hito o entregable.");
                txtNombre.Focus();
                return false;
            }

            if (cboEstado.SelectedValue == null)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, cboEstado, "ERR-VAL-007", "Seleccione el estado.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Syncore", "Seleccione el estado.");
                cboEstado.Focus();
                return false;
            }

            idProyecto = Convert.ToInt32(cboProyecto.SelectedValue);
            proyecto = proyectoModelo.ObtenerProyectoPorId(idProyecto);

            if (proyecto.Rows.Count == 0)
            {
                CatalogoErrores.MostrarDetalle("ERR-NEG-004", "Syncore", "No se encontró el proyecto seleccionado.");
                return false;
            }

            fechaInicio = Convert.ToDateTime(proyecto.Rows[0]["FechaInicio"]);
            fechaCierre = Convert.ToDateTime(proyecto.Rows[0]["FechaCierreEstimada"]);

            if (dtpFechaObjetivo.Value.Date < fechaInicio.Date || dtpFechaObjetivo.Value.Date > fechaCierre.Date)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, dtpFechaObjetivo, "ERR-VAL-004", "La fecha objetivo debe estar dentro de las fechas del proyecto.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-004", "Syncore", "La fecha objetivo debe estar dentro de las fechas del proyecto.");
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
                CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Syncore", "Seleccione un hito para actualizar.");
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
            ucPaginador.ReiniciarRemoto();
            if (cargando == false)
            {
                AplicarFiltros();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ucPaginador.ReiniciarRemoto();
            AplicarFiltros();
        }
        private void ucPaginador_PaginaCambiada(object sender, EventArgs e)
        {
            AplicarFiltros();
            PrepararNuevo();
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
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtNombre, "ERR-VAL-001", "Ingrese el nombre del hito o entregable.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtNombre, "");
                }
            }
            if (sender == cboProyecto)
            {
                if (cboProyecto.SelectedIndex < 0)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, cboProyecto, "ERR-VAL-007", "Seleccione el proyecto.");
                }
                else
                {
                    errorProviderValidacion.SetError(cboProyecto, "");
                }
            }
            if (sender == cboEstado)
            {
                if (cboEstado.SelectedIndex < 0)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, cboEstado, "ERR-VAL-007", "Seleccione el estado.");
                }
                else
                {
                    errorProviderValidacion.SetError(cboEstado, "");
                }
            }
            if (sender == cboProyecto || sender == dtpFechaObjetivo)
            {
                ValidarFechaObjetivoEnTiempoReal();
            }
        }

        private void ValidarFechaObjetivoEnTiempoReal()
        {
            int idProyecto;
            DataTable datos;
            DateTime inicio;
            DateTime cierre;
            if (validacionEnTiempoRealHabilitada == false || proyectoModelo == null)
            {
                return;
            }
            if (cboProyecto.SelectedValue == null)
            {
                errorProviderValidacion.SetError(dtpFechaObjetivo, "");
                return;
            }
            if (int.TryParse(cboProyecto.SelectedValue.ToString(), out idProyecto) == false)
            {
                return;
            }
            datos = proyectoModelo.ObtenerProyectoPorId(idProyecto);
            if (datos.Rows.Count == 0)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, dtpFechaObjetivo, "ERR-NEG-004", "No se encontró el proyecto seleccionado.");
                return;
            }
            inicio = Convert.ToDateTime(datos.Rows[0]["FechaInicio"]);
            cierre = Convert.ToDateTime(datos.Rows[0]["FechaCierreEstimada"]);
            if (dtpFechaObjetivo.Value.Date < inicio.Date || dtpFechaObjetivo.Value.Date > cierre.Date)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, dtpFechaObjetivo, "ERR-VAL-004", "La fecha debe estar dentro del período del proyecto.");
            }
            else
            {
                errorProviderValidacion.SetError(dtpFechaObjetivo, "");
            }
        }

    }
}
