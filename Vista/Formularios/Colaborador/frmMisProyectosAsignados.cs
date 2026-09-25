using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmMisProyectosAsignados : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        private Proyecto proyectoModelo;
        private SeguimientoProyectoUsuario seguimientoModelo;
        private DataTable proyectosOriginales;

        public event EventHandler MisTareasSolicitadas;

        public int IdProyectoSeleccionado { get; private set; }

        public int IdProyectoInicial { get; set; }

        public frmMisProyectosAsignados()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(txtBuscar, "Escriba el texto que desea buscar.");
            toolTipAyuda.SetToolTip(cboEstado, "Seleccione estado.");
            toolTipAyuda.SetToolTip(cboFecha, "Seleccione fecha.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            proyectoModelo = new Proyecto();
            seguimientoModelo = new SeguimientoProyectoUsuario();
            proyectosOriginales = new DataTable();
            IdProyectoSeleccionado = 0;
        }

        private void frmMisProyectosAsignados_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("No hay una sesión activa.");
                return;
            }

            txtBuscar.Text = "";
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Todos los estados");
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Observación");
            cboEstado.Items.Add("Crítico");
            cboEstado.SelectedIndex = 0;
            cboFecha.SelectedIndex = 0;
            CargarProyectos();
        }

        private void CargarProyectos()
        {
            proyectosOriginales = proyectoModelo.ObtenerProyectosUsuario(Sesion.UsuarioActual.IdUsuario);

            if (IdProyectoInicial > 0)
            {
                foreach (DataRow fila in proyectosOriginales.Rows)
                {
                    if (Convert.ToInt32(fila["IdProyecto"]) == IdProyectoInicial)
                    {
                        txtBuscar.Text = fila["Proyecto"].ToString();
                        break;
                    }
                }
            }

            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            string texto;
            string estado;
            int filtroFecha;
            int idUsuario;

            texto = txtBuscar.Text.Trim().ToLower();
            estado = "Todos los estados";
            filtroFecha = cboFecha.SelectedIndex;
            idUsuario = Sesion.UsuarioActual.IdUsuario;
            flpProyectos.Controls.Clear();

            if (cboEstado.SelectedItem != null)
            {
                estado = cboEstado.SelectedItem.ToString();
            }

            foreach (DataRow fila in proyectosOriginales.Rows)
            {
                bool mostrar;
                DateTime fechaCierre;

                mostrar = true;
                fechaCierre = Convert.ToDateTime(fila["FechaCierreEstimada"]);

                if (string.IsNullOrEmpty(texto) == false)
                {
                    bool coincide;

                    coincide = false;

                    if (fila["Proyecto"].ToString().ToLower().Contains(texto) == true)
                    {
                        coincide = true;
                    }
                    else if (fila["Responsable"].ToString().ToLower().Contains(texto) == true)
                    {
                        coincide = true;
                    }

                    if (coincide == false)
                    {
                        mostrar = false;
                    }
                }

                if (estado != "Todos los estados" && fila["Estado"].ToString() != estado)
                {
                    mostrar = false;
                }

                if (filtroFecha == 1)
                {
                    if (fechaCierre.Date < DateTime.Today || fechaCierre.Date > DateTime.Today.AddDays(7))
                    {
                        mostrar = false;
                    }
                }
                else if (filtroFecha == 2)
                {
                    if (fechaCierre.Date < DateTime.Today || fechaCierre.Date > DateTime.Today.AddDays(30))
                    {
                        mostrar = false;
                    }
                }

                if (mostrar == true)
                {
                    AgregarProyecto(fila, idUsuario);
                }
            }
        }

        private void AgregarProyecto(DataRow fila, int idUsuario)
        {
            UCFilaProyectoAsignado control;
            int idProyecto;
            int tareas;
            int vencidas;
            DateTime? proximaFecha;
            decimal avance;

            idProyecto = Convert.ToInt32(fila["IdProyecto"]);
            tareas = seguimientoModelo.ContarTareasUsuarioProyecto(idUsuario, idProyecto);
            vencidas = seguimientoModelo.ContarTareasVencidasUsuarioProyecto(idUsuario, idProyecto);
            proximaFecha = seguimientoModelo.ObtenerProximaFechaUsuarioProyecto(idUsuario, idProyecto);
            avance = seguimientoModelo.ObtenerAvanceUsuarioProyecto(idUsuario, idProyecto);

            control = new UCFilaProyectoAsignado();
            control.IdProyecto = idProyecto;
            control.NombreProyecto = fila["Proyecto"].ToString();
            control.Responsable = fila["Responsable"].ToString();
            control.Estado = fila["Estado"].ToString();
            control.Avance = Convert.ToInt32(avance);
            control.MisTareas = tareas.ToString() + " tareas - " + vencidas.ToString() + " vencidas";

            if (proximaFecha.HasValue == true)
            {
                control.ProximaFecha = proximaFecha.Value.ToString("dd/MM/yyyy");
            }
            else
            {
                control.ProximaFecha = "Sin fecha";
            }

            AplicarColorEstado(control);
            control.MisTareasSolicitadas += control_MisTareasSolicitadas;
            control.Dock = DockStyle.Top;
            flpProyectos.Controls.Add(control);
            control.SendToBack();
        }

        private void AplicarColorEstado(UCFilaProyectoAsignado control)
        {
            if (control.Estado == "Crítico")
            {
                control.ColorEstado = Color.FromArgb(210, 52, 61);
                control.FondoEstado = Color.FromArgb(253, 228, 232);
            }
            else if (control.Estado == "Observación")
            {
                control.ColorEstado = Color.FromArgb(197, 120, 35);
                control.FondoEstado = Color.FromArgb(255, 243, 214);
            }
            else
            {
                control.ColorEstado = Color.FromArgb(31, 145, 72);
                control.FondoEstado = Color.FromArgb(221, 245, 230);
            }
        }

        private void control_MisTareasSolicitadas(object sender, EventArgs e)
        {
            UCFilaProyectoAsignado control;

            control = sender as UCFilaProyectoAsignado;

            if (control == null)
            {
                return;
            }

            IdProyectoSeleccionado = control.IdProyecto;

            if (MisTareasSolicitadas != null)
            {
                MisTareasSolicitadas(this, EventArgs.Empty);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void filtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual != null)
            {
                AplicarFiltros();
            }
        }
    }
}
