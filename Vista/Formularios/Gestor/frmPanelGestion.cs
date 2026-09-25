using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmPanelGestion : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        public event EventHandler ProductividadSolicitada;
        public event EventHandler NuevoProyectoSolicitado;
        public event EventHandler DetalleProyectoSolicitado;
        public event EventHandler DetalleTareaSolicitada;

        public int IdProyectoSeleccionado { get; set; }

        public int IdTareaSeleccionada { get; set; }
        private Proyecto proyectoModelo;
        private ResumenProyecto resumenProyecto;
        private TableroTarea tableroTarea;
        private IndicadorTarea indicadorTarea;
        private Avance avanceModelo;

        public frmPanelGestion()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(btnProductividad, "Abrir la sección de productividad.");
            toolTipAyuda.SetToolTip(btnNuevoProyecto, "Crear un nuevo proyecto.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            lblFecha.Text = System.DateTime.Today.ToString("dd/MM/yyyy");
            proyectoModelo = new Proyecto();
            resumenProyecto = new ResumenProyecto();
            tableroTarea = new TableroTarea();
            indicadorTarea = new IndicadorTarea();
            avanceModelo = new Avance();
        }

        private void btnProductividad_Click(object sender, EventArgs e)
        {
            if (ProductividadSolicitada != null)
            {
                ProductividadSolicitada(this, EventArgs.Empty);
            }
        }

        private void btnNuevoProyecto_Click(object sender, EventArgs e)
        {
            if (NuevoProyectoSolicitado != null)
            {
                NuevoProyectoSolicitado(this, EventArgs.Empty);
            }
        }

        private void frmPanelGestion_Activated(object sender, EventArgs e)
        {
            CargarPanel();
        }

        private void CargarPanel()
        {
            DataTable avancesProyectos = proyectoModelo.ObtenerAvancesProyectos();
            DataTable resumenTareas = tableroTarea.ObtenerResumenTareasVencidas();
            DataTable proyectosConAlerta = proyectoModelo.ObtenerProyectosConAlerta();
            proyectosConAlerta = indicadorTarea.AgregarTareasVencidas(proyectosConAlerta);
            DataTable tareasResponsableInactivo = tableroTarea.ObtenerTareasConResponsableInactivo();
            DataTable avancesRecientes = avanceModelo.ObtenerAvancesRecientes(8);

            cargarTarjetas(avancesProyectos, resumenTareas);
            cargarProyectosCriticos(proyectosConAlerta, avancesProyectos);
            cargarAvancePorProyecto(avancesProyectos);
            cargarAlertasGestion(proyectosConAlerta, tareasResponsableInactivo);
            cargarAvancesRecientes(avancesRecientes);
        }

        private void cargarProyectosCriticos(DataTable proyectos, DataTable avancesProyectos)
        {
            flpProyectosCriticos.Controls.Clear();

            foreach (DataRow filaProyecto in proyectos.Rows)
            {
                int idProyecto = Convert.ToInt32(filaProyecto["IdProyecto"]);
                decimal avanceReal = resumenProyecto.BuscarAvanceReal(avancesProyectos, idProyecto);
                int tareasVencidas = Convert.ToInt32(filaProyecto["TareasVencidas"]);
                UCProyectoCritico nuevoProyecto = new UCProyectoCritico();

                nuevoProyecto.IdProyecto = idProyecto;
                nuevoProyecto.NombreProyecto = filaProyecto["Proyecto"].ToString();
                nuevoProyecto.Area = filaProyecto["Area"].ToString();
                nuevoProyecto.Avance = Convert.ToInt32(avanceReal);
                nuevoProyecto.Estado = filaProyecto["Estado"].ToString();
                nuevoProyecto.TareasVencidas = tareasVencidas;
                nuevoProyecto.VerSolicitado += proyectoCritico_VerSolicitado;
                flpProyectosCriticos.Controls.Add(nuevoProyecto);
            }
        }

        private void cargarTarjetas(DataTable avancesProyectos, DataTable resumenTareas)
        {
            int proyectosActivos = resumenProyecto.ContarProyectosActivos(avancesProyectos);
            int proyectosAtrasados = resumenProyecto.ContarProyectosAtrasados(avancesProyectos);
            decimal avancePromedio = resumenProyecto.CalcularAvancePromedio(avancesProyectos);
            int tareasVencidas = 0;
            int proyectosAfectados = 0;

            if (resumenTareas.Rows.Count > 0)
            {
                tareasVencidas = Convert.ToInt32(resumenTareas.Rows[0]["TareasVencidas"]);
                proyectosAfectados = Convert.ToInt32(resumenTareas.Rows[0]["ProyectosAfectados"]);
            }

            tarjeta1.Valor = proyectosActivos.ToString();
            tarjeta1.Detalle = "Proyectos activos";
            tarjeta2.Valor = proyectosAtrasados.ToString();
            tarjeta2.Detalle = "Con avance atrasado";
            tarjeta3.Valor = tareasVencidas.ToString();
            tarjeta3.Detalle = $"En {proyectosAfectados} proyectos";
            tarjeta4.Valor = Convert.ToInt32(avancePromedio).ToString() + "%";
            tarjeta4.Detalle = "Avance promedio";
        }

        private void cargarAlertasGestion(DataTable proyectos, DataTable tareas)
        {
            flpAlertas.Controls.Clear();
            int cantidadAlertas = 0;

            foreach (DataRow filaProyecto in proyectos.Rows)
            {
                if (cantidadAlertas == 5)
                {
                    break;
                }

                string nombreProyecto = filaProyecto["Proyecto"].ToString();
                string estadoProyecto = filaProyecto["Estado"].ToString();
                DateTime fechaCierre = Convert.ToDateTime(filaProyecto["FechaCierreEstimada"]);
                int tareasVencidas = Convert.ToInt32(filaProyecto["TareasVencidas"]);
                UCAlertaGestion nuevaAlerta = new UCAlertaGestion();

                if (estadoProyecto == "Crítico")
                {
                    nuevaAlerta.Titulo = "Proyecto crítico";
                    nuevaAlerta.TipoAlerta = "Crítica";
                }
                else
                {
                    nuevaAlerta.Titulo = "Proyecto en observación";
                    nuevaAlerta.TipoAlerta = "Advertencia";
                }

                if (tareasVencidas > 0)
                {
                    nuevaAlerta.Detalle = $"{nombreProyecto} tiene {tareasVencidas} tareas vencidas.";
                }
                else
                {
                    nuevaAlerta.Detalle = $"{nombreProyecto} superó su fecha estimada de cierre.";
                }

                nuevaAlerta.IdProyecto = Convert.ToInt32(filaProyecto["IdProyecto"]);
                nuevaAlerta.IdTarea = 0;
                nuevaAlerta.Fecha = "Cierre: " + fechaCierre.ToString("dd/MM/yyyy");
                nuevaAlerta.TextoBoton = "Ver proyecto";
                nuevaAlerta.AccionSolicitada += alertaGestion_AccionSolicitada;
                flpAlertas.Controls.Add(nuevaAlerta);
                cantidadAlertas = cantidadAlertas + 1;
            }

            foreach (DataRow filaTarea in tareas.Rows)
            {
                if (cantidadAlertas == 5)
                {
                    break;
                }

                string nombreTarea = filaTarea["Tarea"].ToString();
                string responsable = filaTarea["Responsable"].ToString();
                DateTime fechaLimite = Convert.ToDateTime(filaTarea["FechaLimite"]);
                UCAlertaGestion nuevaAlerta = new UCAlertaGestion();

                nuevaAlerta.IdProyecto = 0;
                nuevaAlerta.IdTarea = Convert.ToInt32(filaTarea["IdTarea"]);
                nuevaAlerta.Titulo = "Responsable inactivo";
                nuevaAlerta.Detalle = $"La tarea {nombreTarea} está asignada a {responsable}.";
                nuevaAlerta.Fecha = "Vence: " + fechaLimite.ToString("dd/MM/yyyy");
                nuevaAlerta.TextoBoton = "Ver tarea";
                nuevaAlerta.TipoAlerta = "Advertencia";
                nuevaAlerta.AccionSolicitada += alertaGestion_AccionSolicitada;
                flpAlertas.Controls.Add(nuevaAlerta);
                cantidadAlertas = cantidadAlertas + 1;
            }
        }

        private void cargarAvancePorProyecto(DataTable proyectos)
        {
            flpBarrasProyecto.Controls.Clear();

            foreach (DataRow filaProyecto in proyectos.Rows)
            {
                string nombreProyecto = filaProyecto["Proyecto"].ToString();
                int avanceReal = Convert.ToInt32(filaProyecto["AvanceReal"]);
                string estadoProyecto = filaProyecto["Estado"].ToString();
                UCBarraProyecto nuevaBarra = new UCBarraProyecto();

                nuevaBarra.NombreProyecto = nombreProyecto;
                nuevaBarra.Avance = avanceReal;

                if (estadoProyecto == "Crítico")
                {
                    nuevaBarra.ColorBarra = Color.FromArgb(229, 37, 42);
                }
                else if (estadoProyecto == "Observación")
                {
                    nuevaBarra.ColorBarra = Color.FromArgb(240, 128, 49);
                }
                else
                {
                    nuevaBarra.ColorBarra = Color.FromArgb(52, 99, 171);
                }

                flpBarrasProyecto.Controls.Add(nuevaBarra);
            }
        }

        private void cargarAvancesRecientes(DataTable avances)
        {
            flpAvancesRecientes.Controls.Clear();

            foreach (DataRow filaAvance in avances.Rows)
            {
                string nombreUsuario = filaAvance["Usuario"].ToString();
                string nombreTarea = filaAvance["Tarea"].ToString();
                int porcentaje = Convert.ToInt32(filaAvance["Porcentaje"]);
                UCAvanceReciente nuevoAvance = new UCAvanceReciente();

                nuevoAvance.Nombre = nombreUsuario;
                nuevoAvance.Tarea = nombreTarea;
                nuevoAvance.Porcentaje = porcentaje;
                flpAvancesRecientes.Controls.Add(nuevoAvance);
            }
        }

        private void frmPanelGestion_Shown(object sender, EventArgs e)
        {
            CargarPanel();
        }

        private void proyectoCritico_VerSolicitado(object sender, EventArgs e)
        {
            UCProyectoCritico proyecto;

            proyecto = sender as UCProyectoCritico;

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

        private void alertaGestion_AccionSolicitada(object sender, EventArgs e)
        {
            UCAlertaGestion alerta;

            alerta = sender as UCAlertaGestion;

            if (alerta == null)
            {
                return;
            }

            if (alerta.IdTarea > 0)
            {
                IdTareaSeleccionada = alerta.IdTarea;

                if (DetalleTareaSolicitada != null)
                {
                    DetalleTareaSolicitada(this, EventArgs.Empty);
                }

                return;
            }

            if (alerta.IdProyecto > 0)
            {
                IdProyectoSeleccionado = alerta.IdProyecto;

                if (DetalleProyectoSolicitado != null)
                {
                    DetalleProyectoSolicitado(this, EventArgs.Empty);
                }
            }
        }


    }
}
