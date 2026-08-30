using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmEditarIntegranteProyecto : Form
    {
        private RolProyecto rolProyectoModelo;

        public int IdEquipo { get; set; }
        public int IdRolProyectoActual { get; set; }
        public string NombreIntegrante { get; set; }

        public frmEditarIntegranteProyecto()
        {
            InitializeComponent();
        }

        private void frmEditarIntegranteProyecto_Load(object sender, EventArgs e)
        {
            rolProyectoModelo = new RolProyecto();
            lblNombreValor.Text = NombreIntegrante;
            CargarRoles();
        }

        private void CargarRoles()
        {
            DataTable roles;

            roles = rolProyectoModelo.ObtenerRolesActivos();
            cboRol.DisplayMember = "Nombre";
            cboRol.ValueMember = "IdRolProyecto";
            cboRol.DataSource = roles;
            cboRol.SelectedValue = IdRolProyectoActual;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EquipoProyecto integrante;
            bool actualizado;

            if (cboRol.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el rol del integrante.");
                cboRol.Focus();
                return;
            }

            integrante = new EquipoProyecto();
            integrante.IdEquipo = IdEquipo;
            integrante.IdRolProyecto = Convert.ToInt32(cboRol.SelectedValue);
            actualizado = integrante.ActualizarRol();

            if (actualizado == true)
            {
                MessageBox.Show("El rol del integrante fue actualizado correctamente.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
