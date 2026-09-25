using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmCronograma : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        private Proyecto proyectoModelo;
        private Cronograma cronogramaModelo;
        private DataTable cronogramaOriginal;
        private bool cargando;

        public frmCronograma()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(cboProyecto, "Seleccione proyecto.");
            toolTipAyuda.SetToolTip(dtpDesde, "Seleccione fecha inicial.");
            toolTipAyuda.SetToolTip(dtpHasta, "Seleccione fecha final.");
            toolTipAyuda.SetToolTip(cboTipo, "Seleccione tipo.");
            toolTipAyuda.SetToolTip(btnActualizar, "Actualizar la información.");
            toolTipAyuda.SetToolTip(dgvCronograma, "Muestra los registros del cronograma.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);

            ucPaginador.Tabla = dgvCronograma;
            proyectoModelo = new Proyecto();
            cronogramaModelo = new Cronograma();
            cronogramaOriginal = new DataTable();
            cargando = false;
        }

        private void frmCronograma_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");

            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("No hay una sesión activa.");
                return;
            }

            if (Sesion.UsuarioActual.TipoUsuario != "Gestor")
            {
                MessageBox.Show("Solo un gestor puede consultar el cronograma general.");
                return;
            }

            dtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpHasta.Value = dtpDesde.Value.AddMonths(1).AddDays(-1);
            CargarProyectos();
            CargarCronograma();
        }

        private void CargarProyectos()
        {
            DataTable proyectos;
            DataRow fila;

            proyectos = proyectoModelo.ObtenerCatalogoProyectosResponsable(Sesion.UsuarioActual.IdUsuario);
            fila = proyectos.NewRow();
            fila["IdProyecto"] = 0;
            fila["Proyecto"] = "Todos mis proyectos";
            proyectos.Rows.InsertAt(fila, 0);

            cargando = true;
            cboProyecto.DataSource = proyectos;
            cboProyecto.DisplayMember = "Proyecto";
            cboProyecto.ValueMember = "IdProyecto";
            cboProyecto.SelectedIndex = 0;
            cboTipo.SelectedIndex = 0;
            cargando = false;
        }

        private void CargarCronograma()
        {
            int idProyecto;

            if (Sesion.UsuarioActual == null)
            {
                return;
            }

            if (dtpHasta.Value.Date < dtpDesde.Value.Date)
            {
                MessageBox.Show("La fecha hasta no puede ser anterior a la fecha desde.");
                return;
            }

            idProyecto = 0;

            if (cboProyecto.SelectedValue != null)
            {
                int.TryParse(cboProyecto.SelectedValue.ToString(), out idProyecto);
            }

            cronogramaOriginal = cronogramaModelo.ObtenerCronogramaGestor(Sesion.UsuarioActual.IdUsuario, idProyecto, dtpDesde.Value.Date, dtpHasta.Value.Date);
            AplicarFiltroTipo();
        }

        private void AplicarFiltroTipo()
        {
            DataTable resultado;
            string tipo;

            resultado = cronogramaOriginal.Clone();
            tipo = "Todos";

            if (cboTipo.SelectedItem != null)
            {
                tipo = cboTipo.SelectedItem.ToString();
            }

            foreach (DataRow fila in cronogramaOriginal.Rows)
            {
                bool mostrar;

                mostrar = true;

                if (tipo == "Solo tareas" && fila["Tipo"].ToString() != "Tarea")
                {
                    mostrar = false;
                }
                else if (tipo == "Solo hitos" && fila["Tipo"].ToString() != "Hito")
                {
                    mostrar = false;
                }

                if (mostrar == true)
                {
                    resultado.ImportRow(fila);
                }
            }

            ucPaginador.Mostrar(resultado);
            ConfigurarTabla();
            lblCantidad.Text = resultado.Rows.Count.ToString() + " elemento(s)";
        }

        private void ConfigurarTabla()
        {
            if (dgvCronograma.Columns.Contains("Tipo") == true)
            {
                dgvCronograma.Columns["Tipo"].HeaderText = "TIPO";
                dgvCronograma.Columns["Tipo"].FillWeight = 10;
            }

            if (dgvCronograma.Columns.Contains("Actividad") == true)
            {
                dgvCronograma.Columns["Actividad"].HeaderText = "ACTIVIDAD";
                dgvCronograma.Columns["Actividad"].FillWeight = 25;
            }

            if (dgvCronograma.Columns.Contains("Proyecto") == true)
            {
                dgvCronograma.Columns["Proyecto"].HeaderText = "PROYECTO";
                dgvCronograma.Columns["Proyecto"].FillWeight = 20;
            }

            if (dgvCronograma.Columns.Contains("Responsable") == true)
            {
                dgvCronograma.Columns["Responsable"].HeaderText = "RESPONSABLE";
                dgvCronograma.Columns["Responsable"].FillWeight = 18;
            }

            if (dgvCronograma.Columns.Contains("FechaInicio") == true)
            {
                dgvCronograma.Columns["FechaInicio"].HeaderText = "INICIO / FECHA";
                dgvCronograma.Columns["FechaInicio"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvCronograma.Columns["FechaInicio"].FillWeight = 12;
            }

            if (dgvCronograma.Columns.Contains("FechaFin") == true)
            {
                dgvCronograma.Columns["FechaFin"].HeaderText = "FIN";
                dgvCronograma.Columns["FechaFin"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvCronograma.Columns["FechaFin"].FillWeight = 12;
            }

            if (dgvCronograma.Columns.Contains("Estado") == true)
            {
                dgvCronograma.Columns["Estado"].HeaderText = "ESTADO";
                dgvCronograma.Columns["Estado"].FillWeight = 14;
            }

            if (dgvCronograma.Columns.Contains("Avance") == true)
            {
                dgvCronograma.Columns["Avance"].HeaderText = "AVANCE";
                dgvCronograma.Columns["Avance"].DefaultCellStyle.Format = "0'%'";
                dgvCronograma.Columns["Avance"].FillWeight = 9;
            }

            dgvCronograma.ClearSelection();
        }

        private void dgvCronograma_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCronograma.Columns[e.ColumnIndex].Name != "Estado")
            {
                return;
            }

            if (e.Value == null)
            {
                return;
            }

            string estado;

            estado = e.Value.ToString();

            if (estado == "Completada" || estado == "Cumplido")
            {
                e.CellStyle.BackColor = Color.FromArgb(221, 245, 230);
                e.CellStyle.ForeColor = Color.FromArgb(31, 145, 72);
            }
            else if (estado == "Vencida" || estado == "Crítico")
            {
                e.CellStyle.BackColor = Color.FromArgb(253, 228, 232);
                e.CellStyle.ForeColor = Color.FromArgb(210, 52, 61);
            }
            else if (estado == "En progreso" || estado == "En proceso" || estado == "Observación")
            {
                e.CellStyle.BackColor = Color.FromArgb(255, 243, 214);
                e.CellStyle.ForeColor = Color.FromArgb(197, 120, 35);
            }
            else
            {
                e.CellStyle.BackColor = Color.FromArgb(232, 242, 255);
                e.CellStyle.ForeColor = Color.FromArgb(0, 105, 240);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarCronograma();
        }

        private void filtros_Cambio(object sender, EventArgs e)
        {
            if (cargando == false)
            {
                CargarCronograma();
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando == false)
            {
                AplicarFiltroTipo();
            }
        }
    }
}
