using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmListadoProyectos : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        private Proyecto proyectoModelo;
        private DataTable proyectosOriginales;
        private bool cargandoFiltros;
        private DataTable proyectosFiltrados;

        public event EventHandler DetalleProyectoSolicitado;
        public event EventHandler EditarProyectoSolicitado;
        public event EventHandler NuevoProyectoSolicitado;

        public int IdProyectoSeleccionado { get; private set; }

        public frmListadoProyectos()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(btnNuevoProyecto, "Crear un nuevo proyecto.");
            toolTipAyuda.SetToolTip(txtBuscar, "Escriba el texto que desea buscar.");
            toolTipAyuda.SetToolTip(cmbEstado, "Seleccione estado.");
            toolTipAyuda.SetToolTip(cmbArea, "Seleccione área.");
            toolTipAyuda.SetToolTip(cmbResponsable, "Seleccione responsable.");
            toolTipAyuda.SetToolTip(cmbPrioridad, "Seleccione prioridad.");
            toolTipAyuda.SetToolTip(cmbTipo, "Seleccione tipo.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            btnNuevoProyecto.Click += btnNuevoProyecto_Click;
            paginadorTarjetas.PaginaCambiada += paginadorTarjetas_PaginaCambiada;
        }

        private void frmListadoProyectos_Load(object sender, EventArgs e)
        {
            proyectoModelo = new Proyecto();
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            proyectosOriginales = proyectoModelo.ObtenerFiltrosListadoProyectos();
            CargarFiltros();
            AplicarFiltros();
        }

        private void CargarFiltros()
        {
            cargandoFiltros = true;

            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Todos los visibles");
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Observación");
            cmbEstado.Items.Add("Crítico");
            cmbEstado.Items.Add("Cerrado");

            cmbPrioridad.Items.Clear();
            cmbPrioridad.Items.Add("Todas las prioridades");
            cmbPrioridad.Items.Add("Alta");
            cmbPrioridad.Items.Add("Media");
            cmbPrioridad.Items.Add("Normal");

            cmbArea.Items.Clear();
            cmbArea.Items.Add("Todas las áreas");

            cmbResponsable.Items.Clear();
            cmbResponsable.Items.Add("Todos los responsables");

            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Todos los tipos");

            foreach (DataRow fila in proyectosOriginales.Rows)
            {
                AgregarValorCombo(cmbArea, fila["Area"].ToString());
                AgregarValorCombo(cmbResponsable, fila["Responsable"].ToString());
                AgregarValorCombo(cmbTipo, fila["Tipo"].ToString());
            }

            cmbEstado.SelectedIndex = 0;
            cmbArea.SelectedIndex = 0;
            cmbResponsable.SelectedIndex = 0;
            cmbPrioridad.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;
            txtBuscar.Clear();
            cargandoFiltros = false;
        }

        private void AgregarValorCombo(ComboBox combo, string valor)
        {
            bool existe;

            existe = false;

            foreach (object item in combo.Items)
            {
                if (item.ToString() == valor)
                {
                    existe = true;
                    break;
                }
            }

            if (existe == false)
            {
                combo.Items.Add(valor);
            }
        }

        private void AplicarFiltros()
        {
            if (cargandoFiltros || proyectosOriginales == null)
            {
                return;
            }
            int pagina = paginadorTarjetas.Inicio / UCPaginadorTarjetas.RegistrosPorPagina;
            string estado = "Todos los visibles";
            string area = "";
            string responsable = "";
            string prioridad = "";
            string tipo = "";
            if (cmbEstado.SelectedIndex > 0) estado = cmbEstado.Text;
            if (cmbArea.SelectedIndex > 0) area = cmbArea.Text;
            if (cmbResponsable.SelectedIndex > 0) responsable = cmbResponsable.Text;
            if (cmbPrioridad.SelectedIndex > 0) prioridad = cmbPrioridad.Text;
            if (cmbTipo.SelectedIndex > 0) tipo = cmbTipo.Text;
            proyectosFiltrados = proyectoModelo.ObtenerListadoProyectosPagina(
                txtBuscar.Text.Trim(), estado, area, responsable, prioridad, tipo, pagina);
            int total = 0;
            if (proyectosFiltrados.Rows.Count > 0)
            {
                total = Convert.ToInt32(proyectosFiltrados.Rows[0]["TotalRegistros"]);
            }
            if (pagina > 0 && proyectosFiltrados.Rows.Count == 0)
            {
                paginadorTarjetas.Configurar(0, true);
                AplicarFiltros();
                return;
            }
            paginadorTarjetas.Configurar(total, false);
            MostrarProyectos(proyectosFiltrados);
        }

        private void MostrarProyectos(DataTable proyectos)
        {
            pnlFilas.Controls.Clear();

            if (proyectos.Rows.Count == 0)
            {
                Label mensaje;

                mensaje = new Label();
                mensaje.AutoSize = false;
                mensaje.Dock = DockStyle.Top;
                mensaje.Height = 50;
                mensaje.Text = "No se encontraron proyectos.";
                mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                pnlFilas.Controls.Add(mensaje);
                return;
            }

            for (int indice = proyectos.Rows.Count - 1; indice >= 0; indice = indice - 1)
            {
                DataRow fila;
                UCFilaProyectoListado proyecto;

                fila = proyectos.Rows[indice];
                proyecto = new UCFilaProyectoListado();
                proyecto.IdProyecto = Convert.ToInt32(fila["IdProyecto"]);
                proyecto.Codigo = fila["Codigo"].ToString();
                proyecto.NombreProyecto = fila["Proyecto"].ToString();
                proyecto.TipoProyecto = fila["Tipo"].ToString();
                proyecto.Area = fila["Area"].ToString();
                proyecto.Responsable = fila["Responsable"].ToString();
                proyecto.Estado = fila["Estado"].ToString();
                proyecto.Avance = Convert.ToInt32(fila["Avance"]);
                proyecto.Prioridad = fila["Prioridad"].ToString();
                proyecto.VerProyectoSolicitado += proyecto_VerProyectoSolicitado;
                proyecto.EditarProyectoSolicitado += proyecto_EditarProyectoSolicitado;
                proyecto.Dock = DockStyle.Top;
                pnlFilas.Controls.Add(proyecto);
            }
        }


        private void paginadorTarjetas_PaginaCambiada(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnNuevoProyecto_Click(object sender, EventArgs e)
        {
            if (NuevoProyectoSolicitado != null)
            {
                NuevoProyectoSolicitado(this, EventArgs.Empty);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            paginadorTarjetas.Configurar(0, true);
            AplicarFiltros();
        }

        private void filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            paginadorTarjetas.Configurar(0, true);
            AplicarFiltros();
        }


        private void proyecto_EditarProyectoSolicitado(object sender, EventArgs e)
        {
            UCFilaProyectoListado proyecto;

            proyecto = sender as UCFilaProyectoListado;

            if (proyecto == null)
            {
                return;
            }

            IdProyectoSeleccionado = proyecto.IdProyecto;

            if (EditarProyectoSolicitado != null)
            {
                EditarProyectoSolicitado(this, EventArgs.Empty);
            }
        }

        private void proyecto_VerProyectoSolicitado(object sender, EventArgs e)
        {
            UCFilaProyectoListado proyecto;

            proyecto = sender as UCFilaProyectoListado;

            if (proyecto == null)
            {
                return;
            }

            IdProyectoSeleccionado = proyecto.IdProyecto;

            if (DetalleProyectoSolicitado != null)
            {
                DetalleProyectoSolicitado(this, EventArgs.Empty);
            }
        }
    }
}
