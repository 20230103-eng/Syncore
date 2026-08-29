using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmSeleccionRol : Form
    {
        public frmSeleccionRol()
        {
            InitializeComponent();
        }

        private void btnGestor_Click(object sender, EventArgs e)
        {
            frmLoginGestor formulario = new frmLoginGestor();

            this.Hide();
            formulario.ShowDialog();

            if (this.IsDisposed == false)
            {
                this.Show();
            }
        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            frmLoginColaborador formulario = new frmLoginColaborador();

            this.Hide();
            formulario.ShowDialog();

            if (this.IsDisposed == false)
            {
                this.Show();
            }
        }
    }
}
