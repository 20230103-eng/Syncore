using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCFilaTareaProxima : UserControl
    {
        private int avance;

        public UCFilaTareaProxima()
        {
            InitializeComponent();
        }

        public string Tarea
        {
            get { return lblTarea.Text; }
            set { lblTarea.Text = value; }
        }

        public string Proyecto
        {
            get { return lblProyecto.Text; }
            set { lblProyecto.Text = value; }
        }

        public string Fecha
        {
            get { return lblFecha.Text; }
            set { lblFecha.Text = value; }
        }

        public string Prioridad
        {
            get { return lblPrioridad.Text; }
            set { lblPrioridad.Text = value; }
        }

        public string Estado
        {
            get { return lblEstado.Text; }
            set { lblEstado.Text = value; }
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
                tlpBarra.ColumnStyles[0].Width = avance;
                tlpBarra.ColumnStyles[1].Width = 100 - avance;
            }
        }

        public Color ColorPrioridad
        {
            get { return lblPrioridad.ForeColor; }
            set { lblPrioridad.ForeColor = value; }
        }

        public Color FondoPrioridad
        {
            get { return lblPrioridad.BackColor; }
            set { lblPrioridad.BackColor = value; }
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

        public Color ColorBarra
        {
            get { return pnlBarra.BackColor; }
            set { pnlBarra.BackColor = value; }
        }

        public string TextoBoton
        {
            get { return btnVer.Text; }
            set { btnVer.Text = value; }
        }
    }
}
