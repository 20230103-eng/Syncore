using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Infraestructura;

using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmMiProductividad : Form
    {
        private Proyecto proyectoModelo;
        private IndicadorUsuario indicadorUsuario;
        private SeguimientoProyectoUsuario seguimientoProyectoUsuario;
        private TableroTarea tableroTarea;
        private Avance avanceModelo;
        private Productividad productividadModelo;

        public frmMiProductividad()
        {
            InitializeComponent();
            lblFecha.Text = System.DateTime.Today.ToString("dd/MM/yyyy");
            proyectoModelo = new Proyecto();
            indicadorUsuario = new IndicadorUsuario();
            seguimientoProyectoUsuario = new SeguimientoProyectoUsuario();
            tableroTarea = new TableroTarea();
            avanceModelo = new Avance();
            productividadModelo = new Productividad();
            this.Load += frmMiProductividad_Load;
            cboPeriodo.SelectedIndexChanged += cboPeriodo_SelectedIndexChanged;
        }

        private void frmMiProductividad_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            cboPeriodo.SelectedIndex = 0;
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductividad();
        }

        private int ObtenerDiasPeriodo()
        {
            int dias = 30;

            if (cboPeriodo.SelectedIndex == 1)
            {
                dias = 60;
            }
            else if (cboPeriodo.SelectedIndex == 2)
            {
                dias = 365;
            }

            return dias;
        }

        private void CargarProductividad()
        {
            if (Sesion.UsuarioActual == null)
            {
                return;
            }

            int idUsuario = Sesion.UsuarioActual.IdUsuario;
            int dias = ObtenerDiasPeriodo();
            CargarTarjetas(idUsuario, dias);
            CargarAvanceProyectos(idUsuario);
            CargarTareasCompletadas(idUsuario, dias);
            CargarEstadoTareas(idUsuario);
            CargarHistorial(idUsuario, dias);
        }

        private void CargarTarjetas(int idUsuario, int dias)
        {
            int completadas = productividadModelo.ContarTareasCompletadasUsuario(idUsuario, dias);
            int pendientes = indicadorUsuario.ContarTareasAbiertasUsuario(idUsuario);
            int vencidas = indicadorUsuario.ContarTareasUsuarioEstado(idUsuario, "Vencida");
            int cumplimiento = productividadModelo.CalcularCumplimientoUsuario(idUsuario);
            tarjeta1.Valor = completadas.ToString();
            tarjeta1.Detalle = "Últimos " + dias + " días";
            tarjeta2.Valor = pendientes.ToString();
            tarjeta2.Detalle = "Por cerrar o en espera";
            tarjeta3.Valor = vencidas.ToString();
            tarjeta3.Detalle = "Requieren atención";
            tarjeta4.Valor = cumplimiento + "%";
            tarjeta4.Detalle = "Completadas del total asignado";
        }

        private void CargarAvanceProyectos(int idUsuario)
        {
            DataTable proyectos = proyectoModelo.ObtenerProyectosUsuario(idUsuario);
            UCProductividadProyecto[] controles = new UCProductividadProyecto[] { avanceProyecto1, avanceProyecto2, avanceProyecto3 };

            foreach (UCProductividadProyecto control in controles)
            {
                control.Visible = false;
            }

            int indice = 0;

            foreach (DataRow fila in proyectos.Rows)
            {
                if (indice >= controles.Length)
                {
                    break;
                }

                int idProyecto = Convert.ToInt32(fila["IdProyecto"]);
                UCProductividadProyecto control = controles[indice];
                control.NombreProyecto = fila["Proyecto"].ToString();
                control.Tareas = seguimientoProyectoUsuario.ContarTareasUsuarioProyecto(idUsuario, idProyecto);
                control.Avance = Convert.ToInt32(seguimientoProyectoUsuario.ObtenerAvanceUsuarioProyecto(idUsuario, idProyecto));

                if (indice == 0)
                {
                    control.ColorBarra = Color.FromArgb(52, 99, 171);
                }
                else if (indice == 1)
                {
                    control.ColorBarra = Color.FromArgb(240, 128, 49);
                }
                else
                {
                    control.ColorBarra = Color.FromArgb(32, 169, 87);
                }

                control.Visible = true;
                indice = indice + 1;
            }
        }

        private void CargarTareasCompletadas(int idUsuario, int dias)
        {
            DataTable tareas = tableroTarea.ObtenerTareasCompletadasUsuario(idUsuario, dias, 4);
            UCFilaTareaCompletada[] controles = new UCFilaTareaCompletada[] { tareaCompletada1, tareaCompletada2, tareaCompletada3, tareaCompletada4 };

            foreach (UCFilaTareaCompletada control in controles)
            {
                control.Visible = false;
            }

            int indice = 0;

            foreach (DataRow fila in tareas.Rows)
            {
                UCFilaTareaCompletada control = controles[indice];
                control.NombreTarea = fila["Tarea"].ToString();
                control.Visible = true;
                indice = indice + 1;
            }
        }

        private void CargarEstadoTareas(int idUsuario)
        {
            int pendientes = indicadorUsuario.ContarTareasPendientesAgrupadasUsuario(idUsuario);
            int progreso = indicadorUsuario.ContarTareasUsuarioEstado(idUsuario, "En progreso");
            int revision = indicadorUsuario.ContarTareasUsuarioEstado(idUsuario, "En revisión");
            int completadas = indicadorUsuario.ContarTareasUsuarioEstado(idUsuario, "Completada");
            int total = pendientes + progreso + revision + completadas;
            lblPendiente.Text = "Pendiente\r\n" + pendientes;
            lblProgreso.Text = "En progreso\r\n" + progreso;
            lblRevision.Text = "En revisión\r\n" + revision;
            lblCompletada.Text = "Completada\r\n" + completadas;

            pnlBarraPendiente.BackColor = Color.FromArgb(52, 99, 171);
            pnlBarraProgreso.BackColor = Color.FromArgb(240, 128, 49);
            pnlBarraRevision.BackColor = Color.FromArgb(137, 93, 238);
            pnlBarraCompletada.BackColor = Color.FromArgb(32, 169, 87);

            ActualizarBarraEstado(pnlBarraPendiente, pendientes, total);
            ActualizarBarraEstado(pnlBarraProgreso, progreso, total);
            ActualizarBarraEstado(pnlBarraRevision, revision, total);
            ActualizarBarraEstado(pnlBarraCompletada, completadas, total);
        }

        private void ActualizarBarraEstado(Panel barra, int cantidad, int total)
        {
            int alturaMaxima = 200;
            int altura = 0;
            int parteInferior = barra.Top + barra.Height;

            if (total > 0)
            {
                altura = cantidad * alturaMaxima / total;
            }

            if (cantidad > 0 && altura < 12)
            {
                altura = 12;
            }

            if (cantidad == 0)
            {
                barra.Visible = false;
            }
            else
            {
                barra.Visible = true;
                barra.Height = altura;
                barra.Top = parteInferior - altura;
            }
        }

        private void CargarHistorial(int idUsuario, int dias)
        {
            DataTable avances = avanceModelo.ObtenerAvancesUsuario(idUsuario, dias, 3);
            UCFilaAvanceRegistrado[] controles = new UCFilaAvanceRegistrado[] { avance1, avance2, avance3 };

            foreach (UCFilaAvanceRegistrado control in controles)
            {
                control.Visible = false;
            }

            int indice = 0;

            foreach (DataRow fila in avances.Rows)
            {
                UCFilaAvanceRegistrado control = controles[indice];
                control.Fecha = Convert.ToDateTime(fila["FechaRegistro"]).ToString("dd/MM");
                control.Tarea = fila["Tarea"].ToString();
                control.Proyecto = fila["Proyecto"].ToString();
                control.Avance = Convert.ToInt32(fila["Porcentaje"]) + "%";
                control.Visible = true;
                indice = indice + 1;
            }
        }
    }
}
