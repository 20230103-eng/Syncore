using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCBarraProyecto : UserControl
    {
        private int avance;

        public UCBarraProyecto()
        {
            InitializeComponent();
            this.Resize += UCBarraProyecto_Resize;
            AjustarPosiciones();
        }

        private void UCBarraProyecto_Resize(object sender, System.EventArgs e)
        {
            AjustarPosiciones();
        }

        public string NombreProyecto
        {
            get { return lblProyecto.Text; }
            set
            {
                lblProyecto.Text = value;
            }
        }

        public int Avance
        {
            get { return avance; }
            set
            {
                avance = value;

                if (avance < 0)
                    avance = 0;

                if (avance > 100)
                    avance = 100;

                lblPorcentaje.Text = avance + "%";
                pnlBarra.Height = 108 * avance / 100;
                pnlBarra.Top = 130 - pnlBarra.Height;
                AjustarPosiciones();
            }
        }

        public Color ColorBarra
        {
            get { return pnlBarra.BackColor; }
            set { pnlBarra.BackColor = value; }
        }

        private void AjustarPosiciones()
        {
            int izquierdaBarra = (this.Width - pnlBarra.Width) / 2;
            int izquierdaPorcentaje = (this.Width - lblPorcentaje.Width) / 2;
            int anchoProyecto = this.Width - 10;

            if (izquierdaBarra < 0)
            {
                izquierdaBarra = 0;
            }

            if (izquierdaPorcentaje < 0)
            {
                izquierdaPorcentaje = 0;
            }

            if (anchoProyecto < 40)
            {
                anchoProyecto = 40;
            }

            pnlBarra.Left = izquierdaBarra;
            lblPorcentaje.Left = izquierdaPorcentaje;
            lblProyecto.Left = 5;
            lblProyecto.Width = anchoProyecto;
        }
    }
}
