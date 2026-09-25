using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmCalendario : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        private Agenda agendaModelo;
        private Proyecto proyectoModelo;
        private List<UCCeldaCalendario> celdas;
        private DateTime fechaVista;
        private bool cargando;

        public event EventHandler TareaSolicitada;

        public int IdTareaSeleccionada { get; private set; }

        public frmCalendario()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(btnAnterior, "Mostrar el período anterior.");
            toolTipAyuda.SetToolTip(btnSiguiente, "Mostrar el período siguiente.");
            toolTipAyuda.SetToolTip(cboVista, "Seleccione tipo de vista.");
            toolTipAyuda.SetToolTip(cboProyecto, "Seleccione proyecto.");
            toolTipAyuda.SetToolTip(cboTipo, "Seleccione tipo.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            agendaModelo = new Agenda();
            proyectoModelo = new Proyecto();
            celdas = new List<UCCeldaCalendario>();
            fechaVista = DateTime.Today;
            cargando = false;
            IdTareaSeleccionada = 0;
        }

        private void frmCalendario_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("No hay una sesión activa.");
                return;
            }

            PrepararCeldas();
            CargarProyectos();
            CargarCalendario();
        }

        private void PrepararCeldas()
        {
            UCCeldaCalendario[] existentes;
            int indice;

            existentes = new UCCeldaCalendario[]
            {
                dia1, dia2, dia3, dia4, dia5, dia6, dia7,
                dia8, dia9, dia10, dia11, dia12, dia13, dia14,
                dia15, dia16, dia17, dia18, dia19, dia20, dia21,
                dia22, dia23, dia24, dia25, dia26, dia27, dia28,
                dia29, dia30, dia31, dia32, dia33, dia34, dia35
            };

            celdas.Clear();

            foreach (UCCeldaCalendario celda in existentes)
            {
                celda.EventoSolicitado += celda_EventoSolicitado;
                celdas.Add(celda);
            }

            tlpCalendario.RowCount = 6;
            tlpCalendario.RowStyles.Clear();

            for (indice = 0; indice < 6; indice = indice + 1)
            {
                tlpCalendario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            }

            for (indice = 35; indice < 42; indice = indice + 1)
            {
                UCCeldaCalendario celda;
                int columna;
                int fila;

                celda = new UCCeldaCalendario();
                celda.Dock = DockStyle.Fill;
                celda.Margin = new Padding(0);
                celda.EventoSolicitado += celda_EventoSolicitado;
                columna = indice % 7;
                fila = indice / 7;
                tlpCalendario.Controls.Add(celda, columna, fila);
                celdas.Add(celda);
            }
        }

        private void CargarProyectos()
        {
            DataTable proyectos;
            DataRow fila;

            proyectos = proyectoModelo.ObtenerCatalogoProyectosUsuario(Sesion.UsuarioActual.IdUsuario);
            fila = proyectos.NewRow();
            fila["IdProyecto"] = 0;
            fila["Proyecto"] = "Todos los proyectos";
            proyectos.Rows.InsertAt(fila, 0);

            cargando = true;
            cboProyecto.DataSource = proyectos;
            cboProyecto.DisplayMember = "Proyecto";
            cboProyecto.ValueMember = "IdProyecto";
            cboProyecto.SelectedIndex = 0;
            cboVista.SelectedIndex = 0;
            cboTipo.SelectedIndex = 0;
            cargando = false;
        }

        private void CargarCalendario()
        {
            if (cboVista.SelectedIndex == 1)
            {
                CargarVistaSemanal();
            }
            else
            {
                CargarVistaMensual();
            }
        }

        private void CargarVistaMensual()
        {
            DateTime primerDiaMes;
            DateTime primerDiaVisible;
            DateTime ultimoDiaVisible;
            DataTable eventos;
            int desplazamiento;
            int indice;

            tlpCalendario.RowCount = 6;
            tlpCalendario.RowStyles.Clear();

            for (indice = 0; indice < 6; indice = indice + 1)
            {
                tlpCalendario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            }

            foreach (UCCeldaCalendario celda in celdas)
            {
                celda.Visible = true;
            }

            primerDiaMes = new DateTime(fechaVista.Year, fechaVista.Month, 1);
            desplazamiento = Convert.ToInt32(primerDiaMes.DayOfWeek);
            primerDiaVisible = primerDiaMes.AddDays(-desplazamiento);
            ultimoDiaVisible = primerDiaVisible.AddDays(41);
            eventos = ObtenerEventos(primerDiaVisible, ultimoDiaVisible);
            lblMes.Text = ObtenerNombreMes(fechaVista.Month) + " " + fechaVista.Year.ToString();
            btnAnterior.Text = "< " + ObtenerNombreMes(primerDiaMes.AddMonths(-1).Month);
            btnSiguiente.Text = ObtenerNombreMes(primerDiaMes.AddMonths(1).Month) + " >";

            for (indice = 0; indice < celdas.Count; indice = indice + 1)
            {
                DateTime fechaCelda;

                fechaCelda = primerDiaVisible.AddDays(indice);
                ConfigurarCelda(celdas[indice], fechaCelda, eventos, fechaCelda.Month == fechaVista.Month);
            }
        }

        private void CargarVistaSemanal()
        {
            DateTime inicioSemana;
            DateTime finSemana;
            DataTable eventos;
            int desplazamiento;
            int indice;

            desplazamiento = Convert.ToInt32(fechaVista.DayOfWeek);
            inicioSemana = fechaVista.Date.AddDays(-desplazamiento);
            finSemana = inicioSemana.AddDays(6);
            eventos = ObtenerEventos(inicioSemana, finSemana);
            tlpCalendario.RowCount = 6;
            tlpCalendario.RowStyles.Clear();
            tlpCalendario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCalendario.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tlpCalendario.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tlpCalendario.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tlpCalendario.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tlpCalendario.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            lblMes.Text = "Semana del " + inicioSemana.ToString("dd/MM") + " al " + finSemana.ToString("dd/MM/yyyy");
            btnAnterior.Text = "< Semana anterior";
            btnSiguiente.Text = "Semana siguiente >";

            for (indice = 0; indice < celdas.Count; indice = indice + 1)
            {
                if (indice < 7)
                {
                    DateTime fechaCelda;

                    fechaCelda = inicioSemana.AddDays(indice);
                    celdas[indice].Visible = true;
                    ConfigurarCelda(celdas[indice], fechaCelda, eventos, true);
                }
                else
                {
                    celdas[indice].Visible = false;
                }
            }
        }

        private DataTable ObtenerEventos(DateTime fechaInicio, DateTime fechaFin)
        {
            int idProyecto;
            string tipo;

            idProyecto = 0;
            tipo = "Todos";

            if (cboProyecto.SelectedValue != null)
            {
                int.TryParse(cboProyecto.SelectedValue.ToString(), out idProyecto);
            }

            if (cboTipo.SelectedIndex == 1)
            {
                tipo = "Tarea";
            }
            else if (cboTipo.SelectedIndex == 2)
            {
                tipo = "Hito";
            }

            return agendaModelo.ObtenerCalendarioUsuario(Sesion.UsuarioActual.IdUsuario, idProyecto, fechaInicio, fechaFin, tipo);
        }

        private void ConfigurarCelda(UCCeldaCalendario celda, DateTime fechaCelda, DataTable eventos, bool mesActual)
        {
            DataRow primerEvento;
            int cantidad;

            celda.Fecha = fechaCelda;
            celda.Dia = fechaCelda.Day.ToString();
            celda.MostrarEvento = false;
            celda.Evento = "";
            celda.IdTarea = 0;
            celda.IdProyecto = 0;
            celda.BackColor = Color.White;

            if (mesActual == true)
            {
                celda.ColorDia = Color.FromArgb(11, 55, 104);
            }
            else
            {
                celda.ColorDia = Color.FromArgb(160, 170, 182);
            }

            primerEvento = null;
            cantidad = 0;

            foreach (DataRow fila in eventos.Rows)
            {
                DateTime fechaEvento;

                fechaEvento = Convert.ToDateTime(fila["Fecha"]);

                if (fechaEvento.Date == fechaCelda.Date)
                {
                    cantidad = cantidad + 1;

                    if (primerEvento == null)
                    {
                        primerEvento = fila;
                    }
                }
            }

            if (primerEvento != null)
            {
                string texto;
                string tipo;
                string estado;

                texto = primerEvento["Actividad"].ToString();
                tipo = primerEvento["Tipo"].ToString();
                estado = primerEvento["Estado"].ToString();

                if (cantidad > 1)
                {
                    texto = texto + " (+" + (cantidad - 1).ToString() + ")";
                }

                celda.Evento = texto;
                celda.MostrarEvento = true;
                celda.IdTarea = Convert.ToInt32(primerEvento["IdTarea"]);
                celda.IdProyecto = Convert.ToInt32(primerEvento["IdProyecto"]);

                if (tipo == "Hito")
                {
                    celda.ColorEvento = Color.FromArgb(255, 246, 218);
                    celda.ColorTextoEvento = Color.FromArgb(197, 120, 35);
                }
                else if (estado == "Vencida" || (fechaCelda.Date < DateTime.Today && estado != "Completada"))
                {
                    celda.ColorEvento = Color.FromArgb(253, 228, 232);
                    celda.ColorTextoEvento = Color.FromArgb(210, 52, 61);
                }
                else
                {
                    celda.ColorEvento = Color.FromArgb(232, 242, 255);
                    celda.ColorTextoEvento = Color.FromArgb(0, 105, 240);
                }
            }
        }

        private string ObtenerNombreMes(int mes)
        {
            string[] meses;

            meses = new string[]
            {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            };

            return meses[mes - 1];
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (cboVista.SelectedIndex == 1)
            {
                fechaVista = fechaVista.AddDays(-7);
            }
            else
            {
                fechaVista = fechaVista.AddMonths(-1);
            }

            CargarCalendario();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (cboVista.SelectedIndex == 1)
            {
                fechaVista = fechaVista.AddDays(7);
            }
            else
            {
                fechaVista = fechaVista.AddMonths(1);
            }

            CargarCalendario();
        }

        private void filtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando == false)
            {
                CargarCalendario();
            }
        }

        private void celda_EventoSolicitado(object sender, EventArgs e)
        {
            UCCeldaCalendario celda;

            celda = sender as UCCeldaCalendario;

            if (celda == null || celda.IdTarea <= 0)
            {
                return;
            }

            IdTareaSeleccionada = celda.IdTarea;

            if (TareaSolicitada != null)
            {
                TareaSolicitada(this, EventArgs.Empty);
            }
        }
    }
}
