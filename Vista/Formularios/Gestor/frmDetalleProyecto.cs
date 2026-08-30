using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmDetalleProyecto : Form
    {
        private Proyecto proyectoModelo;
        private IndicadorTarea indicadorTareaModelo;
        private Hito hitoModelo;
        private Notificacion notificacionModelo;
        private decimal avancePlanificado;
        private decimal avanceReal;
        private string estadoProyecto;
        private TabControl tabDetalle;
        private TabPage tabResumen;
        private TabPage tabEquipoTrabajo;
        private UCEquipoProyectoDetalle ucEquipoProyecto;

        public event EventHandler EditarProyectoSolicitado;
        public event EventHandler VolverSolicitado;
        public event EventHandler ProyectoCerrado;

        public int IdProyecto { get; set; }

        public frmDetalleProyecto()
        {
            InitializeComponent();
        }

        private void frmDetalleProyecto_Load(object sender, EventArgs e)
        {
            proyectoModelo = new Proyecto();
            indicadorTareaModelo = new IndicadorTarea();
            hitoModelo = new Hito();
            notificacionModelo = new Notificacion();
            avancePlanificado = 0;
            avanceReal = 0;
            estadoProyecto = "";
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            ConfigurarPestanas();
            ConfigurarTablaHitos();
            CargarDetalle();
        }


        private void ConfigurarPestanas()
        {
            tabDetalle = new TabControl();
            tabResumen = new TabPage();
            tabEquipoTrabajo = new TabPage();
            ucEquipoProyecto = new UCEquipoProyectoDetalle();

            tlpContenido.Controls.Remove(tlpPrincipal);

            tabDetalle.Dock = DockStyle.Fill;
            tabDetalle.Font = new Font("Segoe UI", 9F);
            tabDetalle.Padding = new Point(18, 6);
            tabDetalle.SelectedIndexChanged += new EventHandler(tabDetalle_SelectedIndexChanged);

            tabResumen.Text = "Resumen";
            tabResumen.BackColor = Color.FromArgb(247, 249, 252);
            tabResumen.Padding = new Padding(6);
            tabResumen.AutoScroll = true;

            tabEquipoTrabajo.Text = "Equipo de trabajo";
            tabEquipoTrabajo.BackColor = Color.White;
            tabEquipoTrabajo.Padding = new Padding(6);

            tlpPrincipal.Dock = DockStyle.Top;
            tlpPrincipal.Height = 590;
            tabResumen.Controls.Add(tlpPrincipal);

            ucEquipoProyecto.Dock = DockStyle.Fill;
            tabEquipoTrabajo.Controls.Add(ucEquipoProyecto);

            tabDetalle.TabPages.Add(tabResumen);
            tabDetalle.TabPages.Add(tabEquipoTrabajo);
            tlpContenido.Controls.Add(tabDetalle, 0, 3);
        }

        private void tabDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDetalle.SelectedTab == tabEquipoTrabajo)
            {
                ucEquipoProyecto.CargarProyecto(IdProyecto);
            }
        }

        private void ConfigurarTablaHitos()
        {
            dgvHitos.AutoGenerateColumns = true;
            dgvHitos.DataSource = null;
        }

        private void CargarDetalle()
        {
            DataTable datos;
            DataRow fila;
            DateTime fechaInicio;
            DateTime fechaCierre;
            int tareasTotales;
            int tareasCompletadas;
            int tareasVencidas;
            int diasRestantes;

            if (IdProyecto <= 0)
            {
                MostrarProyectoNoDisponible("No se recibió un proyecto válido.");
                return;
            }

            datos = proyectoModelo.ObtenerDetalleProyecto(IdProyecto);

            if (datos.Rows.Count == 0)
            {
                MostrarProyectoNoDisponible("No se encontró información del proyecto seleccionado.");
                return;
            }

            fila = datos.Rows[0];
            fechaInicio = Convert.ToDateTime(fila["FechaInicio"]);
            fechaCierre = Convert.ToDateTime(fila["FechaCierreEstimada"]);
            avancePlanificado = Convert.ToDecimal(fila["AvancePlanificado"]);
            avanceReal = proyectoModelo.ObtenerAvanceRealProyecto(IdProyecto);
            estadoProyecto = fila["Estado"].ToString();
            tareasTotales = indicadorTareaModelo.ContarTareasProyecto(IdProyecto);
            tareasCompletadas = indicadorTareaModelo.ContarTareasProyectoPorEstado(IdProyecto, "Completada");
            tareasVencidas = indicadorTareaModelo.ContarTareasVencidasProyecto(IdProyecto);
            diasRestantes = Convert.ToInt32((fechaCierre.Date - DateTime.Today).TotalDays);

            if (diasRestantes < 0)
            {
                diasRestantes = 0;
            }

            lblTitulo.Text = "\"" + fila["Proyecto"].ToString() + "\"";
            lblSubtitulo.Text = "Proyecto: \"" + fila["Proyecto"].ToString() + "\" | Responsable: " + fila["Responsable"].ToString();
            lblObjetivoValor.Text = fila["Objetivo"].ToString();
            lblFechasValor.Text = fechaInicio.ToString("dd MMMM yyyy") + " — " + fechaCierre.ToString("dd MMMM yyyy");
            lblPrioridadValor.Text = fila["Prioridad"].ToString();
            lblResultadoValor.Text = fila["ResultadoEsperado"].ToString();
            lblKpiAvanceValor.Text = Math.Round(avanceReal, 0).ToString("0") + "%";
            lblKpiTareasValor.Text = tareasTotales.ToString();
            lblKpiCompletadasValor.Text = tareasCompletadas.ToString();
            lblKpiVencidasValor.Text = tareasVencidas.ToString();
            lblKpiDiasValor.Text = diasRestantes.ToString();
            lblPlanPorcentaje.Text = Math.Round(avancePlanificado, 0).ToString("0") + "%";
            lblRealPorcentaje.Text = Math.Round(avanceReal, 0).ToString("0") + "%";

            AplicarEstiloPrioridad();
            AplicarEstiloEstado();
            PrepararBotonCerrar();
            CargarHitos();
            CargarAlertas();
            ActualizarBarrasSalud();
            ucEquipoProyecto.CargarProyecto(IdProyecto);
        }

        private void MostrarProyectoNoDisponible(string mensaje)
        {
            lblTitulo.Text = "Detalle de proyecto";
            lblSubtitulo.Text = mensaje;
            btnEquipoTrabajo.Enabled = false;
            btnEditarProyecto.Enabled = false;
            btnCerrarProyecto.Enabled = false;
        }

        private void AplicarEstiloPrioridad()
        {
            lblPrioridadValor.BackColor = Color.FromArgb(238, 242, 247);
            lblPrioridadValor.ForeColor = Color.FromArgb(79, 93, 109);

            if (lblPrioridadValor.Text == "Alta")
            {
                lblPrioridadValor.BackColor = Color.FromArgb(255, 232, 232);
                lblPrioridadValor.ForeColor = Color.FromArgb(207, 48, 57);
            }
            else if (lblPrioridadValor.Text == "Media")
            {
                lblPrioridadValor.BackColor = Color.FromArgb(255, 244, 220);
                lblPrioridadValor.ForeColor = Color.FromArgb(197, 120, 35);
            }
        }

        private void AplicarEstiloEstado()
        {
            lblEstadoSalud.Text = estadoProyecto;
            pnlEstadoSalud.BackColor = Color.FromArgb(232, 245, 235);
            lblEstadoSalud.ForeColor = Color.FromArgb(35, 145, 72);
            pnlRellenoReal.BackColor = Color.FromArgb(35, 145, 72);

            if (estadoProyecto == "Crítico")
            {
                pnlEstadoSalud.BackColor = Color.FromArgb(255, 232, 232);
                lblEstadoSalud.ForeColor = Color.FromArgb(207, 48, 57);
                pnlRellenoReal.BackColor = Color.FromArgb(207, 48, 57);
            }
            else if (estadoProyecto == "Observación")
            {
                pnlEstadoSalud.BackColor = Color.FromArgb(255, 244, 220);
                lblEstadoSalud.ForeColor = Color.FromArgb(197, 120, 35);
                pnlRellenoReal.BackColor = Color.FromArgb(226, 132, 50);
            }
            else if (estadoProyecto == "Cerrado")
            {
                pnlEstadoSalud.BackColor = Color.FromArgb(238, 242, 247);
                lblEstadoSalud.ForeColor = Color.FromArgb(92, 104, 118);
                pnlRellenoReal.BackColor = Color.FromArgb(92, 104, 118);
            }
        }

        private void PrepararBotonCerrar()
        {
            btnCerrarProyecto.Enabled = true;
            btnCerrarProyecto.Text = "Cerrar proyecto";

            if (estadoProyecto == "Cerrado")
            {
                btnCerrarProyecto.Enabled = false;
                btnCerrarProyecto.Text = "Proyecto cerrado";
            }
        }

        private void CargarHitos()
        {
            DataTable hitos;

            hitos = hitoModelo.ObtenerHitosProximosProyecto(IdProyecto, 4);
            dgvHitos.DataSource = hitos;

            if (dgvHitos.Columns.Contains("IdHito") == true)
            {
                dgvHitos.Columns["IdHito"].Visible = false;
            }

            if (dgvHitos.Columns.Contains("Hito") == true)
            {
                dgvHitos.Columns["Hito"].HeaderText = "HITO";
                dgvHitos.Columns["Hito"].FillWeight = 38;
            }

            if (dgvHitos.Columns.Contains("FechaObjetivo") == true)
            {
                dgvHitos.Columns["FechaObjetivo"].HeaderText = "FECHA OBJETIVO";
                dgvHitos.Columns["FechaObjetivo"].DefaultCellStyle.Format = "dd MMM";
                dgvHitos.Columns["FechaObjetivo"].FillWeight = 20;
            }

            if (dgvHitos.Columns.Contains("Responsable") == true)
            {
                dgvHitos.Columns["Responsable"].HeaderText = "RESPONSABLE";
                dgvHitos.Columns["Responsable"].FillWeight = 25;
            }

            if (dgvHitos.Columns.Contains("Estado") == true)
            {
                dgvHitos.Columns["Estado"].HeaderText = "ESTADO";
                dgvHitos.Columns["Estado"].FillWeight = 17;
            }

            if (hitos.Rows.Count > 0)
            {
                lblKpiHitoValor.Text = Convert.ToDateTime(hitos.Rows[0]["FechaObjetivo"]).ToString("dd MMM");
            }
            else
            {
                lblKpiHitoValor.Text = "Sin hitos";
            }

            dgvHitos.ClearSelection();
        }

        private void CargarAlertas()
        {
            DataTable alertas;

            alertas = notificacionModelo.ObtenerAlertasProyecto(IdProyecto, 4);
            flpAlertas.Controls.Clear();

            if (alertas.Rows.Count == 0)
            {
                AgregarMensajeSinAlertas();
                return;
            }

            foreach (DataRow fila in alertas.Rows)
            {
                AgregarAlerta(fila);
            }
        }

        private void AgregarMensajeSinAlertas()
        {
            Label mensaje;

            mensaje = new Label();
            mensaje.AutoSize = false;
            mensaje.Font = new Font("Segoe UI", 9F);
            mensaje.ForeColor = Color.FromArgb(109, 120, 134);
            mensaje.Size = new Size(320, 45);
            mensaje.Text = "No hay alertas activas para este proyecto.";
            mensaje.TextAlign = ContentAlignment.MiddleLeft;
            flpAlertas.Controls.Add(mensaje);
        }

        private void AgregarAlerta(DataRow fila)
        {
            Panel tarjeta;
            Label punto;
            Label titulo;
            Label mensaje;
            Color colorAlerta;
            int ancho;

            colorAlerta = Color.FromArgb(226, 132, 50);

            if (fila["Prioridad"].ToString() == "Alta")
            {
                colorAlerta = Color.FromArgb(220, 53, 69);
            }
            else if (fila["Prioridad"].ToString() == "Normal")
            {
                colorAlerta = Color.FromArgb(32, 105, 185);
            }

            ancho = flpAlertas.ClientSize.Width - 24;

            if (ancho < 250)
            {
                ancho = 250;
            }

            tarjeta = new Panel();
            tarjeta.BackColor = Color.White;
            tarjeta.Margin = new Padding(0, 0, 0, 6);
            tarjeta.Size = new Size(ancho, 58);

            punto = new Label();
            punto.AutoSize = true;
            punto.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            punto.ForeColor = colorAlerta;
            punto.Location = new Point(2, 6);
            punto.Text = "●";

            titulo = new Label();
            titulo.AutoEllipsis = true;
            titulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            titulo.ForeColor = Color.FromArgb(61, 74, 89);
            titulo.Location = new Point(27, 5);
            titulo.Size = new Size(ancho - 35, 20);
            titulo.Text = fila["Titulo"].ToString();

            mensaje = new Label();
            mensaje.AutoEllipsis = true;
            mensaje.Font = new Font("Segoe UI", 8F);
            mensaje.ForeColor = Color.FromArgb(95, 106, 120);
            mensaje.Location = new Point(27, 27);
            mensaje.Size = new Size(ancho - 35, 25);
            mensaje.Text = fila["Mensaje"].ToString();

            tarjeta.Controls.Add(punto);
            tarjeta.Controls.Add(titulo);
            tarjeta.Controls.Add(mensaje);
            flpAlertas.Controls.Add(tarjeta);
        }

        private void ActualizarBarrasSalud()
        {
            AjustarBarra(pnlBarraPlan, pnlRellenoPlan, avancePlanificado);
            AjustarBarra(pnlBarraReal, pnlRellenoReal, avanceReal);
        }

        private void AjustarBarra(Panel fondo, Panel relleno, decimal porcentaje)
        {
            int ancho;

            if (porcentaje < 0)
            {
                porcentaje = 0;
            }

            if (porcentaje > 100)
            {
                porcentaje = 100;
            }

            ancho = Convert.ToInt32(fondo.ClientSize.Width * porcentaje / 100);

            if (ancho < 0)
            {
                ancho = 0;
            }

            if (ancho > fondo.ClientSize.Width)
            {
                ancho = fondo.ClientSize.Width;
            }

            relleno.Width = ancho;
            relleno.Height = fondo.ClientSize.Height;
        }

        private void pnlBarrasSalud_SizeChanged(object sender, EventArgs e)
        {
            ActualizarBarrasSalud();
        }

        private void btnVolverListado_Click(object sender, EventArgs e)
        {
            if (VolverSolicitado != null)
            {
                VolverSolicitado(this, EventArgs.Empty);
            }
        }

        private void btnEquipoTrabajo_Click(object sender, EventArgs e)
        {
            tabDetalle.SelectedTab = tabEquipoTrabajo;
            ucEquipoProyecto.CargarProyecto(IdProyecto);
        }

        private void btnEditarProyecto_Click(object sender, EventArgs e)
        {
            if (EditarProyectoSolicitado != null)
            {
                EditarProyectoSolicitado(this, EventArgs.Empty);
            }
        }

        private void btnCerrarProyecto_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            Proyecto proyecto;
            bool cerrado;

            if (estadoProyecto == "Cerrado")
            {
                MessageBox.Show("El proyecto ya se encuentra cerrado.");
                return;
            }

            respuesta = MessageBox.Show("¿Desea cerrar este proyecto?\n\nLa información no se eliminará y el proyecto podrá consultarse desde el filtro Cerrado.", "Cerrar proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            proyecto = new Proyecto();
            proyecto.IdProyecto = IdProyecto;
            cerrado = proyecto.CerrarProyecto();

            if (cerrado == false)
            {
                return;
            }

            MessageBox.Show("El proyecto fue cerrado y archivado correctamente.");

            if (ProyectoCerrado != null)
            {
                ProyectoCerrado(this, EventArgs.Empty);
            }
        }
    }
}
