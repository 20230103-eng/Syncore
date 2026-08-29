using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Infraestructura;

using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmPanelPersonal : Form
    {
        private Proyecto proyectoModelo;
        private IndicadorUsuario indicadorUsuario;
        private SeguimientoProyectoUsuario seguimientoProyectoUsuario;
        private TableroTarea tableroTarea;
        private Notificacion notificacionModelo;
        private Agenda agendaModelo;

        public event EventHandler RegistrarAvanceSolicitado;
        public event EventHandler NotificacionesSolicitadas;
        public event EventHandler ProyectosSolicitados;
        public event EventHandler TareasSolicitadas;

        public frmPanelPersonal()
        {
            InitializeComponent();
            lblFecha.Text = System.DateTime.Today.ToString("dd/MM/yyyy");
            proyectoModelo = new Proyecto();
            indicadorUsuario = new IndicadorUsuario();
            seguimientoProyectoUsuario = new SeguimientoProyectoUsuario();
            tableroTarea = new TableroTarea();
            notificacionModelo = new Notificacion();
            agendaModelo = new Agenda();
            this.Load += frmPanelPersonal_Load;
        }

        private void frmPanelPersonal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            CargarPanel();
        }

        private void CargarPanel()
        {
            if (Sesion.UsuarioActual == null)
            {
                return;
            }

            int idUsuario = Sesion.UsuarioActual.IdUsuario;
            CargarTarjetas(idUsuario);
            CargarTareasProximas(idUsuario);
            CargarProyectos(idUsuario);
            CargarNotificaciones(idUsuario);
            CargarAgenda(idUsuario);
            CargarAvancePorProyecto(idUsuario);
        }

        private void CargarTarjetas(int idUsuario)
        {
            int pendientes = indicadorUsuario.ContarTareasUsuarioEstado(idUsuario, "Pendiente");
            int vencidas = indicadorUsuario.ContarTareasUsuarioEstado(idUsuario, "Vencida");
            int revision = indicadorUsuario.ContarTareasUsuarioEstado(idUsuario, "En revisión");
            int vencenSemana = indicadorUsuario.ContarTareasQueVencenSemanaUsuario(idUsuario);
            decimal avance = indicadorUsuario.ObtenerAvancePromedioUsuario(idUsuario);
            tarjetaPendientes.Valor = pendientes.ToString();
            tarjetaPendientes.Detalle = vencenSemana + " vencen esta semana";
            tarjetaVencidas.Valor = vencidas.ToString();
            tarjetaVencidas.Detalle = "Requieren atención";
            tarjetaRevision.Valor = revision.ToString();
            tarjetaRevision.Detalle = "Esperando aprobación";
            tarjetaAvance.Valor = Convert.ToInt32(avance) + "%";
            tarjetaAvance.Detalle = "Promedio de tus tareas";
        }

        private void CargarTareasProximas(int idUsuario)
        {
            DataTable tareas = tableroTarea.ObtenerTareasProximasUsuario(idUsuario, 4);
            UCFilaTareaProxima[] controles = new UCFilaTareaProxima[] { tareaProxima1, tareaProxima2, tareaProxima3, tareaProxima4 };

            foreach (UCFilaTareaProxima control in controles)
            {
                control.Visible = false;
            }

            int indice = 0;

            foreach (DataRow fila in tareas.Rows)
            {
                UCFilaTareaProxima control = controles[indice];
                string prioridad = fila["Prioridad"].ToString();
                string estado = fila["Estado"].ToString();
                control.Tarea = fila["Tarea"].ToString();
                control.Proyecto = fila["Proyecto"].ToString();
                control.Fecha = Convert.ToDateTime(fila["FechaLimite"]).ToString("dd/MM");
                control.Prioridad = prioridad;
                control.Estado = estado;
                control.Avance = Convert.ToInt32(fila["AvanceActual"]);
                control.TextoBoton = "Ver";
                CambiarColorPrioridad(control, prioridad);
                CambiarColorEstadoTarea(control, estado);
                control.Visible = true;
                indice = indice + 1;
            }
        }

        private void CambiarColorPrioridad(UCFilaTareaProxima control, string prioridad)
        {
            if (prioridad == "Alta")
            {
                control.ColorPrioridad = Color.FromArgb(185, 28, 28);
                control.FondoPrioridad = Color.FromArgb(254, 226, 226);
            }
            else if (prioridad == "Media")
            {
                control.ColorPrioridad = Color.FromArgb(217, 119, 6);
                control.FondoPrioridad = Color.FromArgb(254, 243, 199);
            }
            else
            {
                control.ColorPrioridad = Color.FromArgb(52, 99, 171);
                control.FondoPrioridad = Color.FromArgb(232, 242, 255);
            }
        }

        private void CambiarColorEstadoTarea(UCFilaTareaProxima control, string estado)
        {
            if (estado == "Vencida" || estado == "Devuelta")
            {
                control.ColorEstado = Color.FromArgb(185, 28, 28);
                control.FondoEstado = Color.FromArgb(254, 226, 226);
                control.ColorBarra = Color.FromArgb(229, 37, 42);
            }
            else if (estado == "En revisión")
            {
                control.ColorEstado = Color.FromArgb(0, 105, 240);
                control.FondoEstado = Color.FromArgb(232, 242, 255);
                control.ColorBarra = Color.FromArgb(0, 105, 240);
            }
            else
            {
                control.ColorEstado = Color.FromArgb(217, 119, 6);
                control.FondoEstado = Color.FromArgb(254, 243, 199);
                control.ColorBarra = Color.FromArgb(240, 128, 49);
            }
        }

        private void CargarProyectos(int idUsuario)
        {
            DataTable proyectos = proyectoModelo.ObtenerProyectosUsuario(idUsuario);
            UCFilaProyectoAsignado[] controles = new UCFilaProyectoAsignado[] { proyecto1, proyecto2, proyecto3 };

            foreach (UCFilaProyectoAsignado control in controles)
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
                int tareas = seguimientoProyectoUsuario.ContarTareasUsuarioProyecto(idUsuario, idProyecto);
                int vencidas = seguimientoProyectoUsuario.ContarTareasVencidasUsuarioProyecto(idUsuario, idProyecto);
                decimal avance = proyectoModelo.ObtenerAvanceRealProyecto(idProyecto);
                DateTime? proximaFecha = seguimientoProyectoUsuario.ObtenerProximaFechaUsuarioProyecto(idUsuario, idProyecto);
                UCFilaProyectoAsignado control = controles[indice];
                string estado = fila["Estado"].ToString();
                control.NombreProyecto = fila["Proyecto"].ToString();
                control.Responsable = fila["Responsable"].ToString();
                control.Estado = estado;
                control.Avance = Convert.ToInt32(avance);
                control.MisTareas = tareas + " tareas - " + vencidas + " vencidas";

                if (proximaFecha.HasValue == true)
                {
                    control.ProximaFecha = proximaFecha.Value.ToString("dd/MM");
                }
                else
                {
                    control.ProximaFecha = Convert.ToDateTime(fila["FechaCierreEstimada"]).ToString("dd/MM");
                }

                CambiarColorEstadoProyecto(control, estado);
                control.Visible = true;
                indice = indice + 1;
            }
        }

        private void CambiarColorEstadoProyecto(UCFilaProyectoAsignado control, string estado)
        {
            if (estado == "Crítico")
            {
                control.ColorEstado = Color.FromArgb(185, 28, 28);
                control.FondoEstado = Color.FromArgb(254, 226, 226);
            }
            else if (estado == "Observación")
            {
                control.ColorEstado = Color.FromArgb(217, 119, 6);
                control.FondoEstado = Color.FromArgb(254, 243, 199);
            }
            else
            {
                control.ColorEstado = Color.FromArgb(34, 171, 88);
                control.FondoEstado = Color.FromArgb(220, 252, 231);
            }
        }

        private void CargarNotificaciones(int idUsuario)
        {
            DataTable notificaciones = notificacionModelo.ObtenerNotificacionesRecientes(idUsuario, 3);
            UCAlertaGestion[] controles = new UCAlertaGestion[] { alerta1, alerta2, alerta3 };

            foreach (UCAlertaGestion control in controles)
            {
                control.Visible = false;
            }

            int indice = 0;

            foreach (DataRow fila in notificaciones.Rows)
            {
                UCAlertaGestion control = controles[indice];
                string prioridad = fila["Prioridad"].ToString();
                control.Titulo = fila["Titulo"].ToString();
                control.Detalle = fila["Mensaje"].ToString();
                control.Fecha = Convert.ToDateTime(fila["FechaCreacion"]).ToString("dd/MM/yyyy");
                control.TextoBoton = "Ver";

                if (prioridad == "Alta")
                {
                    control.TipoAlerta = "Crítica";
                }
                else if (prioridad == "Media")
                {
                    control.TipoAlerta = "Advertencia";
                }
                else
                {
                    control.TipoAlerta = "Información";
                }

                control.Visible = true;
                indice = indice + 1;
            }
        }

        private void CargarAgenda(int idUsuario)
        {
            DataTable agenda = agendaModelo.ObtenerAgendaSemanalUsuario(idUsuario, 5);
            UCFilaAgendaSemanal[] controles = new UCFilaAgendaSemanal[] { agenda1, agenda2, agenda3, agenda4, agenda5 };

            foreach (UCFilaAgendaSemanal control in controles)
            {
                control.Visible = false;
            }

            int indice = 0;

            foreach (DataRow fila in agenda.Rows)
            {
                UCFilaAgendaSemanal control = controles[indice];
                string tipo = fila["Tipo"].ToString();
                control.Dia = Convert.ToDateTime(fila["Fecha"]).ToString("dd/MM");
                control.Actividad = fila["Actividad"].ToString();
                control.Hora = tipo;

                if (tipo == "Hito")
                {
                    control.ColorIndicador = Color.FromArgb(0, 105, 240);
                }
                else
                {
                    control.ColorIndicador = Color.FromArgb(240, 128, 49);
                }

                control.Visible = true;
                indice = indice + 1;
            }
        }

        private void CargarAvancePorProyecto(int idUsuario)
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
                control.Visible = true;
                indice = indice + 1;
            }
        }

        private void btnActualizarAvance_Click(object sender, EventArgs e)
        {
            if (RegistrarAvanceSolicitado != null)
            {
                RegistrarAvanceSolicitado(this, EventArgs.Empty);
            }
        }

        private void btnVerNotificaciones_Click(object sender, EventArgs e)
        {
            if (NotificacionesSolicitadas != null)
            {
                NotificacionesSolicitadas(this, EventArgs.Empty);
            }
        }

        private void btnVerProyectos_Click(object sender, EventArgs e)
        {
            if (ProyectosSolicitados != null)
            {
                ProyectosSolicitados(this, EventArgs.Empty);
            }
        }

        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            if (TareasSolicitadas != null)
            {
                TareasSolicitadas(this, EventArgs.Empty);
            }
        }
    }
}
