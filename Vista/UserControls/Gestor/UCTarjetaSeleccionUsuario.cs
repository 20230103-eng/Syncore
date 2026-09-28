using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCTarjetaSeleccionUsuario : UserControl
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;
        public event System.EventHandler SeleccionCambiada;

        public UCTarjetaSeleccionUsuario()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(cboRol, "Seleccione rol.");
            toolTipAyuda.SetToolTip(chkSeleccionar, "Seleccione este usuario.");
            chkSeleccionar.CheckedChanged += Control_SeleccionCambiada;
            cboRol.SelectedIndexChanged += Control_SeleccionCambiada;
        }

        public int IdUsuario { get; set; }

        public int IdRolProyecto
        {
            get
            {
                int idRol;

                idRol = 0;

                if (cboRol.SelectedValue != null)
                {
                    int.TryParse(cboRol.SelectedValue.ToString(), out idRol);
                }

                return idRol;
            }
        }

        public void SeleccionarRol(int idRol)
        {
            cboRol.SelectedValue = idRol;
        }

        public string Usuario
        {
            get { return lblUsuario.Text; }
            set { lblUsuario.Text = value; }
        }

        public string NombreCompleto
        {
            get { return lblNombreCompleto.Text; }
            set { lblNombreCompleto.Text = value; }
        }

        public string RolAsignado
        {
            get { return cboRol.Text; }
            set { cboRol.Text = value; }
        }

        public bool Seleccionado
        {
            get { return chkSeleccionar.Checked; }
            set { chkSeleccionar.Checked = value; }
        }

        public Image ImagenPerfil
        {
            get { return picUsuario.Image; }
            set { picUsuario.Image = value; }
        }

        public void CargarRoles(DataTable roles)
        {
            DataTable copiaRoles;

            copiaRoles = roles.Copy();
            cboRol.DisplayMember = "Nombre";
            cboRol.ValueMember = "IdRolProyecto";
            cboRol.DataSource = copiaRoles;
            cboRol.SelectedIndex = -1;
        }
        private void Control_SeleccionCambiada(object sender, System.EventArgs e)
        {
            if (SeleccionCambiada != null)
            {
                SeleccionCambiada(this, System.EventArgs.Empty);
            }
        }

    }
}
