using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCFilaEquipoTrabajo : UserControl
    {
        public event EventHandler EditarSolicitado;
        public event EventHandler RetirarSolicitado;

        public int IdEquipo { get; set; }
        public int IdUsuario { get; set; }
        public int IdRolProyecto { get; set; }

        public UCFilaEquipoTrabajo()
        {
            InitializeComponent();
            btnEditar.Click += btnEditar_Click;
            btnRetirar.Click += btnRetirar_Click;
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
            btnRetirar.Visible = false;
            tlpFila.ColumnStyles[7].SizeType = SizeType.Absolute;
            tlpFila.ColumnStyles[7].Width = 0;
            tlpFila.ColumnStyles[8].SizeType = SizeType.Absolute;
            tlpFila.ColumnStyles[8].Width = 0;
        }

        public void MostrarAcciones()
        {
            btnEditar.Visible = true;
            btnRetirar.Visible = true;
            tlpFila.ColumnStyles[7].SizeType = SizeType.Percent;
            tlpFila.ColumnStyles[7].Width = 6.5F;
            tlpFila.ColumnStyles[8].SizeType = SizeType.Percent;
            tlpFila.ColumnStyles[8].Width = 6.5F;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (EditarSolicitado != null)
            {
                EditarSolicitado(this, EventArgs.Empty);
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (RetirarSolicitado != null)
            {
                RetirarSolicitado(this, EventArgs.Empty);
            }
        }
    }
}
