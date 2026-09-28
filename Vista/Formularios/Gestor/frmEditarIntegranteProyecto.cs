using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Infraestructura;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmEditarIntegranteProyecto : Form
    {
        private bool validacionEnTiempoRealHabilitada;
        private System.Windows.Forms.ToolTip toolTipAyuda;
        private System.Windows.Forms.ErrorProvider errorProviderValidacion;

        private RolProyecto rolProyectoModelo;

        public int IdEquipo { get; set; }
        public int IdRolProyectoActual { get; set; }
        public string NombreIntegrante { get; set; }

        public frmEditarIntegranteProyecto()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            errorProviderValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            errorProviderValidacion.ContainerControl = this;
            errorProviderValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            toolTipAyuda.SetToolTip(cboRol, "Seleccione rol.");
            toolTipAyuda.SetToolTip(btnCancelar, "Cancelar la operación actual.");
            toolTipAyuda.SetToolTip(btnGuardar, "Guardar la información ingresada.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);

            cboRol.SelectedIndexChanged += CamposEnTiempoReal;
            cboRol.Leave += CamposEnTiempoReal;
        }

        private void frmEditarIntegranteProyecto_Load(object sender, EventArgs e)
        {
            rolProyectoModelo = new RolProyecto();
            lblNombreValor.Text = NombreIntegrante;
            CargarRoles();
        
            validacionEnTiempoRealHabilitada = true;
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

            errorProviderValidacion.Clear();

            if (cboRol.SelectedValue == null)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, cboRol, "ERR-VAL-007", "Seleccione el rol del integrante.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Syncore", "Seleccione el rol del integrante.");
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
        private void CamposEnTiempoReal(object sender, EventArgs e)
        {
            if (validacionEnTiempoRealHabilitada == false)
            {
                return;
            }

            if (sender == cboRol)
            {
                if (cboRol.SelectedIndex < 0)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, cboRol, "ERR-VAL-007", "Seleccione el rol del integrante.");
                }
                else
                {
                    errorProviderValidacion.SetError(cboRol, "");
                }
            }
        }

    }
}
