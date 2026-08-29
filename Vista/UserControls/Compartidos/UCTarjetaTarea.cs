using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCTarjetaTarea : UserControl
    {
        private int idTarea;

        public event EventHandler VerSolicitado;

        public UCTarjetaTarea()
        {
            InitializeComponent();
            btnVer.Click += btnVer_Click;
        }

        public int IdTarea
        {
            get { return idTarea; }
            set { idTarea = value; }
        }

        public string Proyecto
        {
            get { return lblProyecto.Text; }
            set { lblProyecto.Text = value; }
        }

        public string NombreTarea
        {
            get { return lblTarea.Text; }
            set { lblTarea.Text = value; }
        }

        public string Fecha
        {
            get { return lblFecha.Text; }
            set { lblFecha.Text = value; }
        }

        public string Estado
        {
            get { return lblEstado.Text; }
            set { lblEstado.Text = value; }
        }

        public Color ColorEstado
        {
            get { return pnlColor.BackColor; }
            set
            {
                pnlColor.BackColor = value;
                lblEstado.ForeColor = value;
            }
        }

        public Color FondoEstado
        {
            get { return lblEstado.BackColor; }
            set { lblEstado.BackColor = value; }
        }

        public bool MostrarBoton
        {
            get { return btnVer.Visible; }
            set { btnVer.Visible = value; }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (VerSolicitado != null)
            {
                VerSolicitado(this, EventArgs.Empty);
            }
        }
    }
}
