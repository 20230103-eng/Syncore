using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmProductividad : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        private Proyecto proyectoModelo;
        private IndicadorTarea indicadorTarea;
        private TableroTarea tableroTarea;
        private Productividad productividadModelo;

        public frmProductividad()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(cboPeriodo, "Seleccione período.");
            toolTipAyuda.SetToolTip(btnReportes, "Consultar y exportar los tres reportes de gestión.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            lblFecha.Text = System.DateTime.Today.ToString("dd/MM/yyyy");
            proyectoModelo = new Proyecto();
            indicadorTarea = new IndicadorTarea();
            tableroTarea = new TableroTarea();
            productividadModelo = new Productividad();
            this.Load += frmProductividad_Load;
            cboPeriodo.SelectedIndexChanged += cboPeriodo_SelectedIndexChanged;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            using (frmReportes reportes = new frmReportes())
            {
                reportes.ShowDialog();
            }
        }

        private void frmProductividad_Load(object sender, EventArgs e)
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
                dias = 90;
            }

            return dias;
        }

        private void CargarProductividad()
        {
            int dias = ObtenerDiasPeriodo();
            lblSubtitulo.Text = "Desempeño operativo - últimos " + dias + " días";
            CargarTarjetas(dias);
            CargarColaboradores(dias);
            CargarProyectos();
            CargarTendenciaSemanal(dias);
        }

        private void CargarTarjetas(int dias)
        {
            int completadas = productividadModelo.ContarTareasCompletadas(dias);
            int porcentajeATiempo = productividadModelo.CalcularPorcentajeATiempo(dias);
            decimal diasPromedio = productividadModelo.CalcularDiasPromedioCierre(dias);
            DataTable resumenVencidas = tableroTarea.ObtenerResumenTareasVencidas();
            int vencidas = Convert.ToInt32(resumenVencidas.Rows[0]["TareasVencidas"]);
            tarjeta1.Valor = completadas.ToString();
            tarjeta1.Detalle = "Últimos " + dias + " días";
            tarjeta2.Valor = porcentajeATiempo + "%";
            tarjeta2.Detalle = "Completadas dentro del plazo";
            tarjeta3.Valor = vencidas.ToString();
            tarjeta3.Detalle = "Requieren atención";
            tarjeta4.Valor = diasPromedio.ToString("0.0") + " d";
            tarjeta4.Detalle = "Desde inicio hasta cierre";
        }

        private void CargarColaboradores(int dias)
        {
            DataTable colaboradores = productividadModelo.ObtenerProductividadColaboradores(dias);
            UCProductividadColaborador[] controles = new UCProductividadColaborador[] { colaborador1, colaborador2, colaborador3, colaborador4, colaborador5, colaborador6 };

            foreach (UCProductividadColaborador control in controles)
            {
                control.Visible = false;
            }

            int indice = 0;

            foreach (DataRow fila in colaboradores.Rows)
            {
                if (indice >= controles.Length)
                {
                    break;
                }

                UCProductividadColaborador control = controles[indice];
                control.Nombre = fila["NombreCompleto"].ToString();
                control.Tareas = Convert.ToInt32(fila["Tareas"]);
                control.PorcentajeATiempo = Convert.ToInt32(fila["PorcentajeATiempo"]);
                control.Cumplimiento = Convert.ToInt32(fila["Cumplimiento"]);
                control.Tendencia = fila["Tendencia"].ToString();
                control.Visible = true;
                indice = indice + 1;
            }
        }

        private void CargarProyectos()
        {
            DataTable proyectos = proyectoModelo.ObtenerAvancesProyectos();
            UCProductividadProyecto[] controles = new UCProductividadProyecto[] { productividadProyecto1, productividadProyecto2, productividadProyecto3 };

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
                control.Tareas = indicadorTarea.ContarTareasProyecto(idProyecto);
                control.Avance = Convert.ToInt32(fila["AvanceReal"]);

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

        private void CargarTendenciaSemanal(int dias)
        {
            DataTable semanas = productividadModelo.ObtenerTendenciaSemanal(dias);
            UCBarraSemana[] controles = new UCBarraSemana[] { barraSemana1, barraSemana2, barraSemana3, barraSemana4 };
            int valorMaximo = 1;

            foreach (UCBarraSemana control in controles)
            {
                control.Visible = false;
            }

            foreach (DataRow fila in semanas.Rows)
            {
                int cantidad = Convert.ToInt32(fila["Cantidad"]);

                if (cantidad > valorMaximo)
                {
                    valorMaximo = cantidad;
                }
            }

            int indice = 0;

            foreach (DataRow fila in semanas.Rows)
            {
                if (indice >= controles.Length)
                {
                    break;
                }

                UCBarraSemana control = controles[indice];
                control.Semana = fila["Semana"].ToString();
                control.ValorMaximo = valorMaximo;
                control.Valor = Convert.ToInt32(fila["Cantidad"]);

                if (indice == 0)
                {
                    control.ColorBarra = Color.FromArgb(52, 99, 171);
                }
                else if (indice == 1)
                {
                    control.ColorBarra = Color.FromArgb(240, 128, 49);
                }
                else if (indice == 2)
                {
                    control.ColorBarra = Color.FromArgb(137, 93, 238);
                }
                else
                {
                    control.ColorBarra = Color.FromArgb(32, 169, 87);
                }

                control.Visible = true;
                indice = indice + 1;
            }
        }
    }
}
