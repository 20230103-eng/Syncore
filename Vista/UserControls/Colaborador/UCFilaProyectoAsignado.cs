using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCFilaProyectoAsignado : UserControl
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        private int avance;

        public event EventHandler MisTareasSolicitadas;

        public int IdProyecto { get; set; }

        public UCFilaProyectoAsignado()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(btnMisTareas, "Abrir las tareas de este proyecto.");
            pnlAvanceFondo.SizeChanged += pnlAvanceFondo_SizeChanged;
        }

        public string NombreProyecto
        {
            get { return lblProyecto.Text; }
            set { lblProyecto.Text = value; }
        }

        public string Responsable
        {
            get { return lblResponsable.Text; }
            set { lblResponsable.Text = value; }
        }

        public string Estado
        {
            get { return lblEstado.Text; }
            set { lblEstado.Text = value; }
        }

        public Color ColorEstado
        {
            get { return lblEstado.ForeColor; }
            set { lblEstado.ForeColor = value; }
        }

        public Color FondoEstado
        {
            get { return lblEstado.BackColor; }
            set { lblEstado.BackColor = value; }
        }

        public int Avance
        {
            get { return avance; }
            set
            {
                avance = value;

                if (avance < 0)
                {
                    avance = 0;
                }

                if (avance > 100)
                {
                    avance = 100;
                }

                lblAvance.Text = avance + "%";
                ActualizarBarra();
            }
        }

        private void ActualizarBarra()
        {
            int ancho;

            ancho = Convert.ToInt32(pnlAvanceFondo.ClientSize.Width * avance / 100.0);

            if (ancho < 0)
            {
                ancho = 0;
            }

            if (ancho > pnlAvanceFondo.ClientSize.Width)
            {
                ancho = pnlAvanceFondo.ClientSize.Width;
            }

            pnlAvance.Width = ancho;
            pnlAvance.Height = pnlAvanceFondo.ClientSize.Height;
        }

        private void pnlAvanceFondo_SizeChanged(object sender, EventArgs e)
        {
            ActualizarBarra();
        }

        private void btnMisTareas_Click(object sender, EventArgs e)
        {
            if (MisTareasSolicitadas != null)
            {
                MisTareasSolicitadas(this, EventArgs.Empty);
            }
        }

        public string MisTareas
        {
            get { return lblTareas.Text; }
            set { lblTareas.Text = value; }
        }

        public string ProximaFecha
        {
            get { return lblFecha.Text; }
            set { lblFecha.Text = value; }
        }
    }
}
