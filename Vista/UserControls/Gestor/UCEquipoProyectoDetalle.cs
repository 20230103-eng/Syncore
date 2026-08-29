using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class UCEquipoProyectoDetalle : UserControl
    {
        private EquipoProyecto equipoModelo;

        public int IdProyecto { get; set; }

        public UCEquipoProyectoDetalle()
        {
            InitializeComponent();
            equipoModelo = new EquipoProyecto();
        }

        public void CargarProyecto(int idProyecto)
        {
            IdProyecto = idProyecto;
            CargarEquipo();
        }

        public void CargarEquipo()
        {
            DataTable equipo;

            pnlFilas.Controls.Clear();

            if (IdProyecto <= 0)
            {
                lblCantidad.Text = "0 integrante(s)";
                return;
            }

            equipo = equipoModelo.ObtenerEquipoProyecto(IdProyecto);
            lblCantidad.Text = equipo.Rows.Count.ToString() + " integrante(s)";

            for (int indice = equipo.Rows.Count - 1; indice >= 0; indice = indice - 1)
            {
                DataRow fila;
                UCFilaEquipoTrabajo control;

                fila = equipo.Rows[indice];
                control = new UCFilaEquipoTrabajo();
                control.NombreCompleto = fila["NombreCompleto"].ToString();
                control.Area = fila["Area"].ToString();
                control.RolProyecto = fila["RolProyecto"].ToString();
                control.TareasAsignadas = fila["TareasAsignadas"].ToString();
                control.TareasCompletadas = fila["TareasCompletadas"].ToString();
                control.TareasVencidas = fila["TareasVencidas"].ToString();
                control.OcultarAcciones();
                control.Dock = DockStyle.Top;
                pnlFilas.Controls.Add(control);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarIntegrante formulario;
            DialogResult resultado;

            if (IdProyecto <= 0)
            {
                MessageBox.Show("No se recibió un proyecto válido.");
                return;
            }

            formulario = new frmAgregarIntegrante();
            formulario.IdProyecto = IdProyecto;
            resultado = formulario.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CargarEquipo();
            }

            formulario.Dispose();
        }
    }
}
