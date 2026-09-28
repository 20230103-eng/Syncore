using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Infraestructura;

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
        private TableroTarea tableroTarea;
        private Avance avanceModelo;
        private bool primeraActivacion = true;

        public frmPanelGestion()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(btnProductividad, "Abrir la sección de productividad.");
            toolTipAyuda.SetToolTip(btnNuevoProyecto, "Crear un nuevo proyecto.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            lblFecha.Text = System.DateTime.Today.ToString("dd/MM/yyyy");
            proyectoModelo = new Proyecto();
            tableroTarea = new TableroTarea();
            avanceModelo = new Avance();
            ucPaginadorCriticos.PaginaCambiada += ucPaginadorCriticos_PaginaCambiada;
            ucPaginadorAvance.PaginaCambiada += ucPaginadorAvance_PaginaCambiada;
            ucPaginadorAlertas.PaginaCambiada += ucPaginadorAlertas_PaginaCambiada;
            ucPaginadorRecientes.PaginaCambiada += ucPaginadorRecientes_PaginaCambiada;
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

        private void frmPanelGestion_Load(object sender, EventArgs e)
        {
            CargarPanel();
        }

        private void frmPanelGestion_Activated(object sender, EventArgs e)
        {
            if (primeraActivacion == true)
            {
                primeraActivacion = false;
                return;
            }
            CargarPanel();
        }

        private void CargarPanel()
        {
            if (Sesion.UsuarioActual == null)
            {
                return;
            }

            DataTable resumenProyectos = proyectoModelo.ObtenerResumenDashboard();
            DataTable resumenTareas = tableroTarea.ObtenerResumenTareasVencidas();

            ucPaginadorCriticos.Configurar(0, true);
            ucPaginadorAvance.Configurar(0, true);
            ucPaginadorAlertas.Configurar(0, true);
            ucPaginadorRecientes.Configurar(0, true);
            cargarTarjetas(resumenProyectos, resumenTareas);
            cargarProyectosCriticos();
            cargarAvancePorProyecto();
            cargarAlertasGestion();
            cargarAvancesRecientes();
        }

        private DataTable cargarProyectosCriticos()
        {
            flpProyectosCriticos.Controls.Clear();
            int total;
            int pagina = ucPaginadorCriticos.Inicio / UCPaginadorTarjetas.RegistrosPorPagina;
            DataTable proyectos = proyectoModelo.ObtenerProyectosConAlertaPagina(pagina, out total);
            ucPaginadorCriticos.Configurar(total, false);
            if (pagina != ucPaginadorCriticos.Inicio / UCPaginadorTarjetas.RegistrosPorPagina)
            {
                return cargarProyectosCriticos();
            }

            foreach (DataRow filaProyecto in proyectos.Rows)
            {
                int idProyecto = Convert.ToInt32(filaProyecto["IdProyecto"]);
                decimal avanceReal = Convert.ToDecimal(filaProyecto["AvanceReal"]);
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
            return proyectos;
        }

        private void ucPaginadorCriticos_PaginaCambiada(object sender, EventArgs e)
        {
            cargarProyectosCriticos();
        }

        private void ucPaginadorAvance_PaginaCambiada(object sender, EventArgs e)
        {
            cargarAvancePorProyecto();
        }

        private void cargarTarjetas(DataTable resumenProyectos, DataTable resumenTareas)
        {
            int proyectosActivos = 0;
            int proyectosAtrasados = 0;
            decimal avancePromedio = 0;
            if (resumenProyectos.Rows.Count > 0)
            {
                proyectosActivos = Convert.ToInt32(resumenProyectos.Rows[0]["ProyectosActivos"]);
                proyectosAtrasados = Convert.ToInt32(resumenProyectos.Rows[0]["ProyectosAtrasados"]);
                avancePromedio = Convert.ToDecimal(resumenProyectos.Rows[0]["AvancePromedio"]);
            }
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

        private void ucPaginadorAlertas_PaginaCambiada(object sender, EventArgs e)
        {
            cargarAlertasGestion();
        }

        private void cargarAlertasGestion()
        {
            flpAlertas.Controls.Clear();
            int total;
            int pagina = ucPaginadorAlertas.Inicio / ucPaginadorAlertas.TamanoPagina;
            DataTable alertas = tableroTarea.ObtenerAlertasGestionPagina(pagina,
                ucPaginadorAlertas.TamanoPagina, out total);
            ucPaginadorAlertas.Configurar(total, false);
            if (pagina != ucPaginadorAlertas.Inicio / ucPaginadorAlertas.TamanoPagina)
            {
                cargarAlertasGestion();
                return;
            }
            foreach (DataRow fila in alertas.Rows)
            {
                UCAlertaGestion alerta = new UCAlertaGestion();
                int idProyecto = Convert.ToInt32(fila["IdProyecto"]);
                int idTarea = Convert.ToInt32(fila["IdTarea"]);
                alerta.IdProyecto = idProyecto;
                alerta.IdTarea = idTarea;
                if (idProyecto > 0)
                {
                    string estado = fila["Categoria"].ToString();
                    if (estado == "Crítico")
                    {
                        alerta.Titulo = "Proyecto crítico";
                        alerta.TipoAlerta = "Crítica";
                    }
                    else
                    {
                        alerta.Titulo = "Proyecto en observación";
                        alerta.TipoAlerta = "Advertencia";
                    }
                    int vencidas = Convert.ToInt32(fila["TareasVencidas"]);
                    if (vencidas > 0)
                    {
                        alerta.Detalle = fila["Nombre"] + " tiene " + vencidas + " tareas vencidas.";
                    }
                    else
                    {
                        alerta.Detalle = fila["Nombre"] + " superó su fecha estimada de cierre.";
                    }
                    alerta.Fecha = "Cierre: " + Convert.ToDateTime(fila["Fecha"]).ToString("dd/MM/yyyy");
                    alerta.TextoBoton = "Ver proyecto";
                }
                else
                {
                    alerta.Titulo = "Responsable inactivo";
                    alerta.TipoAlerta = "Advertencia";
                    alerta.Detalle = "La tarea " + fila["Nombre"] + " está asignada a " + fila["Responsable"] + ".";
                    alerta.Fecha = "Vence: " + Convert.ToDateTime(fila["Fecha"]).ToString("dd/MM/yyyy");
                    alerta.TextoBoton = "Ver tarea";
                }
                alerta.AccionSolicitada += alertaGestion_AccionSolicitada;
                flpAlertas.Controls.Add(alerta);
            }
        }

        private void cargarAvancePorProyecto()
        {
            flpBarrasProyecto.Controls.Clear();
            int total;
            int pagina = ucPaginadorAvance.Inicio / UCPaginadorTarjetas.RegistrosPorPagina;
            DataTable proyectos = proyectoModelo.ObtenerAvancesProyectosPagina(pagina, out total);
            ucPaginadorAvance.Configurar(total, false);
            if (pagina != ucPaginadorAvance.Inicio / UCPaginadorTarjetas.RegistrosPorPagina)
            {
                cargarAvancePorProyecto();
                return;
            }

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

        private void ucPaginadorRecientes_PaginaCambiada(object sender, EventArgs e)
        {
            cargarAvancesRecientes();
        }

        private void cargarAvancesRecientes()
        {
            flpAvancesRecientes.Controls.Clear();
            int total;
            int pagina = ucPaginadorRecientes.Inicio / ucPaginadorRecientes.TamanoPagina;
            DataTable avances = avanceModelo.ObtenerAvancesRecientesPagina(
                Sesion.UsuarioActual.IdUsuario, pagina, ucPaginadorRecientes.TamanoPagina, out total);
            ucPaginadorRecientes.Configurar(total, false);
            if (pagina != ucPaginadorRecientes.Inicio / ucPaginadorRecientes.TamanoPagina)
            {
                cargarAvancesRecientes();
                return;
            }

            foreach (DataRow filaAvance in avances.Rows)
            {
                string nombreUsuario = filaAvance["Usuario"].ToString();
                string nombreTarea = filaAvance["Tarea"].ToString();
                int porcentaje = Convert.ToInt32(filaAvance["Porcentaje"]);
                UCAvanceReciente nuevoAvance = new UCAvanceReciente();

                nuevoAvance.IdTarea = Convert.ToInt32(filaAvance["IdTarea"]);
                nuevoAvance.Nombre = nombreUsuario;
                nuevoAvance.Tarea = nombreTarea;
                nuevoAvance.Porcentaje = porcentaje;
                nuevoAvance.ConfigurarAyuda(toolTipAyuda);
                nuevoAvance.VerSolicitado += avanceReciente_VerSolicitado;
                flpAvancesRecientes.Controls.Add(nuevoAvance);
                nuevoAvance.SendToBack();
            }
        }

        private void avanceReciente_VerSolicitado(object sender, EventArgs e)
        {
            UCAvanceReciente avance;

            avance = sender as UCAvanceReciente;

            if (avance == null || avance.IdTarea <= 0)
            {
                return;
            }

            IdTareaSeleccionada = avance.IdTarea;

            if (DetalleTareaSolicitada != null)
            {
                DetalleTareaSolicitada(this, EventArgs.Empty);
            }
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
