using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Infraestructura;

using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmTableroTareasColaborador : Form
    {
        private Proyecto proyectoModelo;
        private TableroTarea tableroTarea;
        private bool cargando;

        public event EventHandler DetalleTareaSolicitado;

        public int IdTareaSeleccionada { get; private set; }

        public int IdProyectoInicial { get; set; }

        public frmTableroTareasColaborador()
        {
            InitializeComponent();
            lblFecha.Text = System.DateTime.Today.ToString("dd/MM/yyyy");
            proyectoModelo = new Proyecto();
            tableroTarea = new TableroTarea();
            cboProyecto.SelectedIndexChanged += cboProyecto_SelectedIndexChanged;
            this.Load += frmTableroTareasColaborador_Load;
        }

        private void frmTableroTareasColaborador_Load(object sender, EventArgs e)
        {
            CargarTablero();
        }

        private void CargarTablero()
        {
            if (Sesion.UsuarioActual == null)
            {
                return;
            }

            CargarProyectos();
            CargarTareas();
        }

        private void CargarProyectos()
        {
            int idUsuario = Sesion.UsuarioActual.IdUsuario;
            DataTable proyectos = proyectoModelo.ObtenerCatalogoProyectosUsuario(idUsuario);
            DataRow fila = proyectos.NewRow();
            fila["IdProyecto"] = 0;
            fila["Proyecto"] = "Todos los proyectos";
            proyectos.Rows.InsertAt(fila, 0);

            cargando = true;
            cboProyecto.Items.Clear();
            cboProyecto.DataSource = proyectos;
            cboProyecto.DisplayMember = "Proyecto";
            cboProyecto.ValueMember = "IdProyecto";
            cboProyecto.SelectedIndex = 0;

            if (IdProyectoInicial > 0)
            {
                cboProyecto.SelectedValue = IdProyectoInicial;
            }

            cargando = false;
        }

        private void CargarTareas()
        {
            if (Sesion.UsuarioActual == null)
            {
                return;
            }

            int idProyecto = 0;

            if (cboProyecto.SelectedValue != null)
            {
                int.TryParse(cboProyecto.SelectedValue.ToString(), out idProyecto);
            }

            int idUsuario = Sesion.UsuarioActual.IdUsuario;
            DataTable tareas = tableroTarea.ObtenerTareasTableroUsuario(idUsuario, idProyecto);

            LimpiarColumnas();

            int pendientes = 0;
            int progreso = 0;
            int revision = 0;
            int devueltas = 0;
            int completadas = 0;

            foreach (DataRow fila in tareas.Rows)
            {
                UCTarjetaTarea tarjeta = CrearTarjeta(fila);
                string estado = fila["Estado"].ToString();

                if (estado == "Pendiente" || estado == "Vencida")
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
                else if (estado == "Devuelta")
                {
                    AgregarTarjeta(flpEstado4, tarjeta);
                    devueltas = devueltas + 1;
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
            lblCantidad4.Text = devueltas.ToString();
            lblCantidad5.Text = completadas.ToString();
        }

        private UCTarjetaTarea CrearTarjeta(DataRow fila)
        {
            UCTarjetaTarea tarjeta = new UCTarjetaTarea();
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

        private void cboProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando == false)
            {
                CargarTareas();
            }
        }

        private void tarjeta_VerSolicitado(object sender, EventArgs e)
        {
            UCTarjetaTarea tarjeta = sender as UCTarjetaTarea;

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
