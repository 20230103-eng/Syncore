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
        private DataTable proyectosFiltrados;
        private bool cargandoFiltros;

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
            paginadorTarjetas.PaginaCambiada += paginadorTarjetas_PaginaCambiada;
        }

        private void frmMisProyectosAsignados_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual == null)
            {
                CatalogoErrores.MostrarDetalle("ERR-NEG-001", "Syncore", "No hay una sesión activa.");
                return;
            }

            cargandoFiltros = true;
            txtBuscar.Text = "";
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Todos los estados");
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Observación");
            cboEstado.Items.Add("Crítico");
            cboEstado.SelectedIndex = 0;
            cboFecha.SelectedIndex = 0;
            cargandoFiltros = false;
            CargarProyectos();
        }

        private void CargarProyectos()
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            if (cargandoFiltros || Sesion.UsuarioActual == null)
            {
                return;
            }
            string estado = "Todos los estados";
            if (cboEstado.SelectedItem != null)
            {
                estado = cboEstado.SelectedItem.ToString();
            }
            int pagina = paginadorTarjetas.Inicio / UCPaginadorTarjetas.RegistrosPorPagina;
            int inicial = IdProyectoInicial;
            proyectosFiltrados = proyectoModelo.ObtenerProyectosUsuarioPagina(
                Sesion.UsuarioActual.IdUsuario, txtBuscar.Text.Trim(), estado,
                cboFecha.SelectedIndex, pagina, inicial);
            IdProyectoInicial = 0;
            int total = 0;
            if (proyectosFiltrados.Rows.Count > 0)
            {
                total = Convert.ToInt32(proyectosFiltrados.Rows[0]["TotalRegistros"]);
            }
            if (pagina > 0 && proyectosFiltrados.Rows.Count == 0)
            {
                paginadorTarjetas.Configurar(0, true);
                AplicarFiltros();
                return;
            }
            paginadorTarjetas.Configurar(total, false);
            MostrarPagina();
        }

        private void MostrarPagina()
        {
            flpProyectos.Controls.Clear();
            if (proyectosFiltrados == null || Sesion.UsuarioActual == null)
            {
                return;
            }
            for (int indice = 0; indice < proyectosFiltrados.Rows.Count; indice++)
            {
                AgregarProyecto(proyectosFiltrados.Rows[indice], Sesion.UsuarioActual.IdUsuario);
            }
        }

        private void paginadorTarjetas_PaginaCambiada(object sender, EventArgs e)
        {
            AplicarFiltros();
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
            if (cargandoFiltros) return;
            paginadorTarjetas.Configurar(0, true);
            AplicarFiltros();
        }

        private void filtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual != null && cargandoFiltros == false)
            {
                paginadorTarjetas.Configurar(0, true);
                AplicarFiltros();
            }
        }
    }
}
