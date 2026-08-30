using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmListadoProyectos : Form
    {
        private Proyecto proyectoModelo;
        private DataTable proyectosOriginales;
        private bool cargandoFiltros;

        public event EventHandler DetalleProyectoSolicitado;
        public event EventHandler EditarProyectoSolicitado;
        public event EventHandler NuevoProyectoSolicitado;

        public int IdProyectoSeleccionado { get; private set; }

        public frmListadoProyectos()
        {
            InitializeComponent();
            btnNuevoProyecto.Click += btnNuevoProyecto_Click;
        }

        private void frmListadoProyectos_Load(object sender, EventArgs e)
        {
            proyectoModelo = new Proyecto();
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            proyectosOriginales = proyectoModelo.ObtenerListadoProyectos();
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
            DataTable proyectosFiltrados;
            string texto;

            if (cargandoFiltros == true)
            {
                return;
            }

            if (proyectosOriginales == null)
            {
                return;
            }

            proyectosFiltrados = proyectosOriginales.Clone();
            texto = txtBuscar.Text.Trim().ToLower();

            foreach (DataRow fila in proyectosOriginales.Rows)
            {
                bool coincide;

                coincide = true;

                if (string.IsNullOrEmpty(texto) == false)
                {
                    string codigo;
                    string proyecto;

                    codigo = fila["Codigo"].ToString().ToLower();
                    proyecto = fila["Proyecto"].ToString().ToLower();

                    if (codigo.Contains(texto) == false && proyecto.Contains(texto) == false)
                    {
                        coincide = false;
                    }
                }

                if (coincide == true && cmbEstado.SelectedIndex == 0)
                {
                    if (fila["Estado"].ToString() == "Cerrado")
                    {
                        coincide = false;
                    }
                }
                else if (coincide == true && cmbEstado.SelectedIndex > 0)
                {
                    if (fila["Estado"].ToString() != cmbEstado.Text)
                    {
                        coincide = false;
                    }
                }

                if (coincide == true && cmbArea.SelectedIndex > 0)
                {
                    if (fila["Area"].ToString() != cmbArea.Text)
                    {
                        coincide = false;
                    }
                }

                if (coincide == true && cmbResponsable.SelectedIndex > 0)
                {
                    if (fila["Responsable"].ToString() != cmbResponsable.Text)
                    {
                        coincide = false;
                    }
                }

                if (coincide == true && cmbPrioridad.SelectedIndex > 0)
                {
                    if (fila["Prioridad"].ToString() != cmbPrioridad.Text)
                    {
                        coincide = false;
                    }
                }

                if (coincide == true && cmbTipo.SelectedIndex > 0)
                {
                    if (fila["Tipo"].ToString() != cmbTipo.Text)
                    {
                        coincide = false;
                    }
                }

                if (coincide == true)
                {
                    proyectosFiltrados.ImportRow(fila);
                }
            }

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


        private void btnNuevoProyecto_Click(object sender, EventArgs e)
        {
            if (NuevoProyectoSolicitado != null)
            {
                NuevoProyectoSolicitado(this, EventArgs.Empty);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
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
