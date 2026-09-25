using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmReportes : Form
    {
        private readonly Proyecto proyectoModelo;
        private readonly Productividad productividadModelo;
        private readonly Hito hitoModelo;
        private readonly ToolTip toolTipAyuda;
        private DataTable reporteActual;

        public frmReportes()
        {
            InitializeComponent();
            proyectoModelo = new Proyecto();
            productividadModelo = new Productividad();
            hitoModelo = new Hito();
            toolTipAyuda = new ToolTip(components);
            toolTipAyuda.SetToolTip(cboReporte, "Seleccione el tipo de reporte.");
            toolTipAyuda.SetToolTip(cboPeriodo, "Seleccione el periodo para productividad.");
            toolTipAyuda.SetToolTip(btnActualizar, "Actualizar la vista con los datos actuales.");
            toolTipAyuda.SetToolTip(btnExportar, "Guardar el reporte completo en formato Excel .xlsx.");
            toolTipAyuda.SetToolTip(btnCerrar, "Cerrar la ventana de reportes.");
            toolTipAyuda.SetToolTip(dgvReporte, "Vista previa del reporte. Se muestran hasta 20 filas por página.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual == null || Sesion.UsuarioActual.TipoUsuario != "Gestor")
            {
                MessageBox.Show("Solo un gestor puede generar reportes.");
                Close();
                return;
            }

            ucPaginador.Tabla = dgvReporte;
            cboReporte.Items.Add("Portafolio de proyectos");
            cboReporte.Items.Add("Productividad por colaborador");
            cboReporte.Items.Add("Hitos y entregables");
            cboPeriodo.Items.Add("Últimos 30 días");
            cboPeriodo.Items.Add("Últimos 60 días");
            cboPeriodo.Items.Add("Últimos 90 días");
            cboPeriodo.SelectedIndex = 0;
            cboReporte.SelectedIndex = 0;
        }

        private void cboReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPeriodo.Enabled = cboReporte.SelectedIndex == 1;
            CargarReporte();
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboReporte.SelectedIndex == 1)
            {
                CargarReporte();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void CargarReporte()
        {
            if (Sesion.UsuarioActual == null)
            {
                return;
            }

            if (cboReporte.SelectedIndex == 0)
            {
                reporteActual = PrepararProyectos(proyectoModelo.ObtenerListadoProyectos());
                lblDescripcion.Text = "Estado, prioridad, responsable y avance real de todos los proyectos.";
            }
            else if (cboReporte.SelectedIndex == 1)
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

                reporteActual = PrepararProductividad(productividadModelo.ObtenerProductividadColaboradores(dias));
                lblDescripcion.Text = "Tareas asignadas (total), porcentaje a tiempo y tendencia de los últimos " + dias + " días.";
            }
            else if (cboReporte.SelectedIndex == 2)
            {
                reporteActual = PrepararHitos(hitoModelo.ObtenerHitosGestor(Sesion.UsuarioActual.IdUsuario));
                lblDescripcion.Text = "Hitos de los proyectos bajo responsabilidad del gestor que inició sesión.";
            }
            else
            {
                return;
            }

            ucPaginador.Mostrar(reporteActual);
            lblTotal.Text = reporteActual.Rows.Count.ToString() + " registro(s) en el reporte";
            btnExportar.Enabled = reporteActual.Rows.Count > 0;
        }

        private DataTable PrepararProyectos(DataTable origen)
        {
            DataTable resultado = new DataTable();
            resultado.Columns.Add("Código");
            resultado.Columns.Add("Proyecto");
            resultado.Columns.Add("Tipo");
            resultado.Columns.Add("Área");
            resultado.Columns.Add("Responsable");
            resultado.Columns.Add("Estado");
            resultado.Columns.Add("Prioridad");
            resultado.Columns.Add("Avance (%)", typeof(decimal));

            foreach (DataRow fila in origen.Rows)
            {
                resultado.Rows.Add(fila["Codigo"], fila["Proyecto"], fila["Tipo"], fila["Area"],
                    fila["Responsable"], fila["Estado"], fila["Prioridad"], fila["Avance"]);
            }
            return resultado;
        }

        private DataTable PrepararProductividad(DataTable origen)
        {
            DataTable resultado = new DataTable();
            resultado.Columns.Add("Colaborador");
            resultado.Columns.Add("Tareas asignadas (total)", typeof(int));
            resultado.Columns.Add("A tiempo (%)", typeof(int));
            resultado.Columns.Add("Tendencia");

            foreach (DataRow fila in origen.Rows)
            {
                resultado.Rows.Add(fila["NombreCompleto"], fila["Tareas"],
                    fila["PorcentajeATiempo"], fila["Tendencia"]);
            }
            return resultado;
        }

        private DataTable PrepararHitos(DataTable origen)
        {
            DataTable resultado = new DataTable();
            resultado.Columns.Add("Proyecto");
            resultado.Columns.Add("Hito");
            resultado.Columns.Add("Descripción");
            resultado.Columns.Add("Responsable");
            resultado.Columns.Add("Estado");
            resultado.Columns.Add("Fecha objetivo", typeof(DateTime));
            resultado.Columns.Add("Fecha cumplimiento", typeof(DateTime));

            foreach (DataRow fila in origen.Rows)
            {
                resultado.Rows.Add(fila["Proyecto"], fila["Hito"], fila["Descripcion"],
                    fila["Responsable"], fila["Estado"], fila["FechaObjetivo"], fila["FechaCumplimiento"]);
            }
            return resultado;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (reporteActual == null || reporteActual.Rows.Count == 0)
            {
                MessageBox.Show("No hay información para exportar.");
                return;
            }

            using (SaveFileDialog guardar = new SaveFileDialog())
            {
                guardar.Filter = "Excel (*.xlsx)|*.xlsx";
                guardar.DefaultExt = "xlsx";
                guardar.AddExtension = true;
                guardar.FileName = "Syncore_" + (cboReporte.SelectedIndex + 1) + "_" + DateTime.Today.ToString("yyyyMMdd") + ".xlsx";

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    ExportadorExcel.Guardar(reporteActual, cboReporte.Text, lblDescripcion.Text, guardar.FileName);
                    MessageBox.Show("Reporte guardado: " + guardar.FileName, "Reportes", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
