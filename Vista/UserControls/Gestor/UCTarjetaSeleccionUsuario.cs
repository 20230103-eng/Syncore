using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCTarjetaSeleccionUsuario : UserControl
    {
        public UCTarjetaSeleccionUsuario()
        {
            InitializeComponent();
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
    }
}
