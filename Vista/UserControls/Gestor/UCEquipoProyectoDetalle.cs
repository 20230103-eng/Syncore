using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class UCEquipoProyectoDetalle : UserControl
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        private EquipoProyecto equipoModelo;

        public int IdProyecto { get; set; }

        public UCEquipoProyectoDetalle()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(btnAgregar, "Agregar el elemento seleccionado.");
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
                control.IdEquipo = Convert.ToInt32(fila["IdEquipo"]);
                control.IdUsuario = Convert.ToInt32(fila["IdUsuario"]);
                control.IdRolProyecto = Convert.ToInt32(fila["IdRolProyecto"]);
                control.NombreCompleto = fila["NombreCompleto"].ToString();
                control.Area = fila["Area"].ToString();
                control.RolProyecto = fila["RolProyecto"].ToString();
                control.TareasAsignadas = fila["TareasAsignadas"].ToString();
                control.TareasCompletadas = fila["TareasCompletadas"].ToString();
                control.TareasVencidas = fila["TareasVencidas"].ToString();
                control.EditarSolicitado += control_EditarSolicitado;
                control.RetirarSolicitado += control_RetirarSolicitado;
                control.Dock = DockStyle.Top;
                pnlFilas.Controls.Add(control);
            }
        }

        private void control_EditarSolicitado(object sender, EventArgs e)
        {
            UCFilaEquipoTrabajo control;
            frmEditarIntegranteProyecto formulario;
            DialogResult resultado;

            control = sender as UCFilaEquipoTrabajo;

            if (control == null)
            {
                return;
            }

            formulario = new frmEditarIntegranteProyecto();
            formulario.IdEquipo = control.IdEquipo;
            formulario.IdRolProyectoActual = control.IdRolProyecto;
            formulario.NombreIntegrante = control.NombreCompleto;
            resultado = formulario.ShowDialog();
            formulario.Dispose();

            if (resultado == DialogResult.OK)
            {
                CargarEquipo();
            }
        }

        private void control_RetirarSolicitado(object sender, EventArgs e)
        {
            UCFilaEquipoTrabajo control;
            EquipoProyecto integrante;
            DialogResult respuesta;
            bool retirado;

            control = sender as UCFilaEquipoTrabajo;

            if (control == null)
            {
                return;
            }

            integrante = new EquipoProyecto();
            integrante.IdEquipo = control.IdEquipo;
            integrante.IdProyecto = IdProyecto;
            integrante.IdUsuario = control.IdUsuario;

            if (integrante.TieneTareasActivasAsignadas() == true)
            {
                MessageBox.Show("No puede retirar al integrante porque todavía tiene tareas activas asignadas en este proyecto.");
                return;
            }

            respuesta = MessageBox.Show("¿Desea retirar a " + control.NombreCompleto + " del proyecto? El registro se conservará como inactivo.", "Retirar integrante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            retirado = integrante.RetirarIntegrante();

            if (retirado == true)
            {
                MessageBox.Show("El integrante fue retirado correctamente.");
                CargarEquipo();
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
