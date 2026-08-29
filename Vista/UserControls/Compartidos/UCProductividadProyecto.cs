using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCProductividadProyecto : UserControl
    {
        private int tareas;
        private int avance;

        public UCProductividadProyecto()
        {
            InitializeComponent();
        }

        public string NombreProyecto
        {
            get { return lblProyecto.Text; }
            set { lblProyecto.Text = value; }
        }

        public int Tareas
        {
            get { return tareas; }
            set
            {
                tareas = value;
                ActualizarDetalle();
            }
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

                pnlBarraFondo.ColumnStyles[0].Width = avance;
                pnlBarraFondo.ColumnStyles[1].Width = 100 - avance;

                ActualizarDetalle();
            }
        }

        private void ActualizarDetalle()
        {
            lblDetalle.Text = tareas + " tareas - " + avance + "%";
        }

        public Color ColorBarra
        {
            get { return pnlBarra.BackColor; }
            set { pnlBarra.BackColor = value; }
        }
    }
}
