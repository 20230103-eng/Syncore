using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCFilaEquipoTrabajo : UserControl
    {
        public UCFilaEquipoTrabajo()
        {
            InitializeComponent();
        }

        public System.Drawing.Image ImagenPerfil { get { return picUsuario.Image; } set { picUsuario.Image = value; } }
        public string NombreCompleto { get { return lblNombre.Text; } set { lblNombre.Text = value; } }
        public string Area { get { return lblArea.Text; } set { lblArea.Text = value; } }
        public string RolProyecto { get { return lblRol.Text; } set { lblRol.Text = value; } }
        public string TareasAsignadas { get { return lblAsignadas.Text; } set { lblAsignadas.Text = value; } }
        public string TareasCompletadas { get { return lblCompletadas.Text; } set { lblCompletadas.Text = value; } }
        public string TareasVencidas { get { return lblVencidas.Text; } set { lblVencidas.Text = value; } }

        public void OcultarAcciones()
        {
            btnEditar.Visible = false;
            btnVer.Visible = false;
            tlpFila.ColumnStyles[7].SizeType = SizeType.Absolute;
            tlpFila.ColumnStyles[7].Width = 0;
            tlpFila.ColumnStyles[8].SizeType = SizeType.Absolute;
            tlpFila.ColumnStyles[8].Width = 0;
        }

    }
}
