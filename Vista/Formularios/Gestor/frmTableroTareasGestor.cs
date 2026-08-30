using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmTableroTareasGestor : Form
    {
        private Proyecto proyectoModelo;
        private TableroTarea tableroTarea;
        private Usuario usuarioModelo;
        private TextBox txtBuscar;
        private bool cargando;

        public event EventHandler DetalleTareaSolicitado;
        public event EventHandler NuevaTareaSolicitada;

        public int IdTareaSeleccionada { get; private set; }

        public frmTableroTareasGestor()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            proyectoModelo = new Proyecto();
            tableroTarea = new TableroTarea();
            usuarioModelo = new Usuario();
            ConfigurarBusqueda();
            cboProyecto.SelectedIndexChanged += filtro_SelectedIndexChanged;
            cboResponsable.SelectedIndexChanged += filtro_SelectedIndexChanged;
            btnNuevaTarea.Click += btnNuevaTarea_Click;
            this.Load += frmTableroTareasGestor_Load;
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
            int idProyecto;
            int idResponsable;
            string texto;
            DataTable tareas;
            int pendientes;
            int progreso;
            int revision;
            int vencidas;
            int completadas;

            idProyecto = 0;
            idResponsable = 0;
            texto = txtBuscar.Text.Trim().ToLower();

            if (cboProyecto.SelectedValue != null)
            {
                int.TryParse(cboProyecto.SelectedValue.ToString(), out idProyecto);
            }

            if (cboResponsable.SelectedValue != null)
            {
                int.TryParse(cboResponsable.SelectedValue.ToString(), out idResponsable);
            }

            tareas = tableroTarea.ObtenerTareasTableroGestor(idProyecto);
            LimpiarColumnas();
            pendientes = 0;
            progreso = 0;
            revision = 0;
            vencidas = 0;
            completadas = 0;

            foreach (DataRow fila in tareas.Rows)
            {
                string estado;
                string nombreTarea;
                string proyecto;
                bool mostrar;

                mostrar = true;
                nombreTarea = fila["Tarea"].ToString().ToLower();
                proyecto = fila["Proyecto"].ToString().ToLower();

                if (idResponsable > 0 && Convert.ToInt32(fila["IdResponsable"]) != idResponsable)
                {
                    mostrar = false;
                }

                if (mostrar == true && string.IsNullOrEmpty(texto) == false)
                {
                    if (nombreTarea.Contains(texto) == false && proyecto.Contains(texto) == false)
                    {
                        mostrar = false;
                    }
                }

                if (mostrar == false)
                {
                    continue;
                }

                UCTarjetaTarea tarjeta;

                tarjeta = CrearTarjeta(fila);
                estado = fila["Estado"].ToString();

                if (estado == "Pendiente" || estado == "Devuelta")
                {
                    AgregarTarjeta(flpEstado1, tarjeta);
                    pendientes = pendientes + 1;
                }
                else if (estado == "En progreso")
                {
                    AgregarTarjeta(flpEstado2, tarjeta);
                    progreso = progreso + 1;
                }
                else if (estado == "En revisión")
                {
                    AgregarTarjeta(flpEstado3, tarjeta);
                    revision = revision + 1;
                }
                else if (estado == "Vencida")
                {
                    AgregarTarjeta(flpEstado4, tarjeta);
                    vencidas = vencidas + 1;
                }
                else if (estado == "Completada")
                {
                    AgregarTarjeta(flpEstado5, tarjeta);
                    completadas = completadas + 1;
                }
            }

            lblCantidad1.Text = pendientes.ToString();
            lblCantidad2.Text = progreso.ToString();
            lblCantidad3.Text = revision.ToString();
            lblCantidad4.Text = vencidas.ToString();
            lblCantidad5.Text = completadas.ToString();
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
                CargarTareas();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cargando == false)
            {
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
