using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmTableroTareasGestor : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        private Proyecto proyectoModelo;
        private TableroTarea tableroTarea;
        private Usuario usuarioModelo;
        private TextBox txtBuscar;
        private bool cargando;
        private DataTable tareasFiltradas;

        public event EventHandler DetalleTareaSolicitado;
        public event EventHandler NuevaTareaSolicitada;

        public int IdTareaSeleccionada { get; private set; }

        public frmTableroTareasGestor()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(cboProyecto, "Seleccione proyecto.");
            toolTipAyuda.SetToolTip(cboResponsable, "Seleccione responsable.");
            toolTipAyuda.SetToolTip(btnNuevaTarea, "Crear una nueva tarea.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            proyectoModelo = new Proyecto();
            tableroTarea = new TableroTarea();
            usuarioModelo = new Usuario();
            ConfigurarBusqueda();
            cboProyecto.SelectedIndexChanged += filtro_SelectedIndexChanged;
            cboResponsable.SelectedIndexChanged += filtro_SelectedIndexChanged;
            btnNuevaTarea.Click += btnNuevaTarea_Click;
            this.Load += frmTableroTareasGestor_Load;
            paginadorTarjetas.PaginaCambiada += paginadorTarjetas_PaginaCambiada;
        }

        private void ConfigurarBusqueda()
        {
            txtBuscar = new TextBox();
            txtBuscar.Font = new Font("Segoe UI", 9F);
            txtBuscar.MaxLength = 150;
            txtBuscar.ShortcutsEnabled = false;
            txtBuscar.Size = new Size(160, 28);
            txtBuscar.Margin = new Padding(8, 6, 0, 0);
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            flpFiltros.Controls.Add(txtBuscar);
        }

        private void frmTableroTareasGestor_Load(object sender, EventArgs e)
        {
            CargarTablero();
        }

        private void CargarTablero()
        {
            cargando = true;
            CargarProyectos();
            CargarResponsables();
            cargando = false;
            CargarTareas();
        }

        private void CargarProyectos()
        {
            DataTable proyectos;
            DataRow fila;

            proyectos = proyectoModelo.ObtenerCatalogoProyectos();
            fila = proyectos.NewRow();
            fila["IdProyecto"] = 0;
            fila["Proyecto"] = "Todos los proyectos";
            proyectos.Rows.InsertAt(fila, 0);

            cboProyecto.DataSource = proyectos;
            cboProyecto.DisplayMember = "Proyecto";
            cboProyecto.ValueMember = "IdProyecto";
            cboProyecto.SelectedIndex = 0;
        }

        private void CargarResponsables()
        {
            DataTable usuarios;
            DataRow fila;

            usuarios = usuarioModelo.ObtenerUsuariosActivos();
            fila = usuarios.NewRow();
            fila["IdUsuario"] = 0;
            fila["NombreCompleto"] = "Todos los responsables";
            usuarios.Rows.InsertAt(fila, 0);

            cboResponsable.DataSource = usuarios;
            cboResponsable.DisplayMember = "NombreCompleto";
            cboResponsable.ValueMember = "IdUsuario";
            cboResponsable.SelectedIndex = 0;
        }

        private void CargarTareas()
        {
            int idProyecto = 0;
            int idResponsable = 0;
            if (cboProyecto.SelectedValue != null)
            {
                int.TryParse(cboProyecto.SelectedValue.ToString(), out idProyecto);
            }
            if (cboResponsable.SelectedValue != null)
            {
                int.TryParse(cboResponsable.SelectedValue.ToString(), out idResponsable);
            }
            int pagina = paginadorTarjetas.Inicio / UCPaginadorTarjetas.RegistrosPorPagina;
            tareasFiltradas = tableroTarea.ObtenerTareasTableroGestorPagina(
                idProyecto, idResponsable, txtBuscar.Text.Trim(), pagina);
            int total = 0;
            int pendientes = 0;
            int progreso = 0;
            int revision = 0;
            int vencidas = 0;
            int completadas = 0;
            if (tareasFiltradas.Rows.Count > 0)
            {
                DataRow primera = tareasFiltradas.Rows[0];
                total = Convert.ToInt32(primera["TotalRegistros"]);
                pendientes = Convert.ToInt32(primera["Conteo1"]);
                progreso = Convert.ToInt32(primera["Conteo2"]);
                revision = Convert.ToInt32(primera["Conteo3"]);
                vencidas = Convert.ToInt32(primera["Conteo4"]);
                completadas = Convert.ToInt32(primera["Conteo5"]);
            }
            if (pagina > 0 && tareasFiltradas.Rows.Count == 0)
            {
                paginadorTarjetas.Configurar(0, true);
                CargarTareas();
                return;
            }
            paginadorTarjetas.Configurar(total, false);
            MostrarPagina();
            lblCantidad1.Text = pendientes.ToString();
            lblCantidad2.Text = progreso.ToString();
            lblCantidad3.Text = revision.ToString();
            lblCantidad4.Text = vencidas.ToString();
            lblCantidad5.Text = completadas.ToString();
        }

        private void MostrarPagina()
        {
            LimpiarColumnas();
            if (tareasFiltradas == null)
            {
                return;
            }
            for (int indice = 0; indice < tareasFiltradas.Rows.Count; indice++)
            {
                DataRow fila = tareasFiltradas.Rows[indice];
                UCTarjetaTarea tarjeta = CrearTarjeta(fila);
                string estado = fila["Estado"].ToString();
                if (estado == "Pendiente" || estado == "Devuelta") AgregarTarjeta(flpEstado1, tarjeta);
                else if (estado == "En progreso") AgregarTarjeta(flpEstado2, tarjeta);
                else if (estado == "En revisión") AgregarTarjeta(flpEstado3, tarjeta);
                else if (estado == "Vencida") AgregarTarjeta(flpEstado4, tarjeta);
                else if (estado == "Completada") AgregarTarjeta(flpEstado5, tarjeta);
            }
        }

        private void paginadorTarjetas_PaginaCambiada(object sender, EventArgs e)
        {
            CargarTareas();
        }

        private UCTarjetaTarea CrearTarjeta(DataRow fila)
        {
            UCTarjetaTarea tarjeta;

            tarjeta = new UCTarjetaTarea();
            tarjeta.IdTarea = Convert.ToInt32(fila["IdTarea"]);
            tarjeta.Proyecto = fila["Proyecto"].ToString();
            tarjeta.NombreTarea = fila["Tarea"].ToString();
            tarjeta.Fecha = Convert.ToDateTime(fila["FechaLimite"]).ToString("dd/MM/yyyy");
            tarjeta.Estado = fila["Estado"].ToString();
            tarjeta.MostrarBoton = true;
            tarjeta.VerSolicitado += tarjeta_VerSolicitado;
            AplicarColor(tarjeta);
            return tarjeta;
        }

        private void AplicarColor(UCTarjetaTarea tarjeta)
        {
            if (tarjeta.Estado == "Completada")
            {
                tarjeta.ColorEstado = Color.FromArgb(31, 175, 91);
                tarjeta.FondoEstado = Color.FromArgb(221, 245, 230);
            }
            else if (tarjeta.Estado == "En progreso")
            {
                tarjeta.ColorEstado = Color.FromArgb(232, 145, 0);
                tarjeta.FondoEstado = Color.FromArgb(255, 243, 214);
            }
            else if (tarjeta.Estado == "Vencida" || tarjeta.Estado == "Devuelta")
            {
                tarjeta.ColorEstado = Color.FromArgb(230, 57, 70);
                tarjeta.FondoEstado = Color.FromArgb(253, 228, 232);
            }
            else
            {
                tarjeta.ColorEstado = Color.FromArgb(0, 105, 240);
                tarjeta.FondoEstado = Color.FromArgb(232, 241, 255);
            }
        }

        private void AgregarTarjeta(Panel panel, UCTarjetaTarea tarjeta)
        {
            tarjeta.Dock = DockStyle.Top;
            tarjeta.Height = 122;
            panel.Controls.Add(tarjeta);
            tarjeta.SendToBack();
        }

        private void LimpiarColumnas()
        {
            flpEstado1.Controls.Clear();
            flpEstado2.Controls.Clear();
            flpEstado3.Controls.Clear();
            flpEstado4.Controls.Clear();
            flpEstado5.Controls.Clear();
        }

        private void filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando == false)
            {
                paginadorTarjetas.Configurar(0, true);
                CargarTareas();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cargando == false)
            {
                paginadorTarjetas.Configurar(0, true);
                CargarTareas();
            }
        }

        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            if (NuevaTareaSolicitada != null)
            {
                NuevaTareaSolicitada(this, EventArgs.Empty);
            }
        }

        private void tarjeta_VerSolicitado(object sender, EventArgs e)
        {
            UCTarjetaTarea tarjeta;

            tarjeta = sender as UCTarjetaTarea;

            if (tarjeta == null)
            {
                return;
            }

            IdTareaSeleccionada = tarjeta.IdTarea;

            if (DetalleTareaSolicitado != null)
            {
                DetalleTareaSolicitado(this, EventArgs.Empty);
            }
        }
    }
}
