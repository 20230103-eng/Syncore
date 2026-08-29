using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCBarraSemana : UserControl
    {
        private int valor;
        private int valorMaximo = 50;

        public UCBarraSemana()
        {
            InitializeComponent();
            this.Resize += UCBarraSemana_Resize;
            AjustarPosiciones();
        }

        private void UCBarraSemana_Resize(object sender, System.EventArgs e)
        {
            AjustarPosiciones();
        }

        public string Semana
        {
            get { return lblSemana.Text; }
            set
            {
                lblSemana.Text = value;
            }
        }

        public int Valor
        {
            get { return valor; }
            set
            {
                valor = value;

                if (valor < 0)
                    valor = 0;

                lblValor.Text = valor.ToString();
                CambiarBarra();
            }
        }

        public int ValorMaximo
        {
            get { return valorMaximo; }
            set
            {
                valorMaximo = value;

                if (valorMaximo < 1)
                    valorMaximo = 1;

                CambiarBarra();
            }
        }

        private void CambiarBarra()
        {
            int altura = 120 * valor / valorMaximo;

            if (altura > 120)
                altura = 120;

            pnlBarra.Height = altura;
            pnlBarra.Top = 150 - altura;
            AjustarPosiciones();
        }

        private void AjustarPosiciones()
        {
            int izquierdaBarra = (this.Width - pnlBarra.Width) / 2;
            int izquierdaSemana = (this.Width - lblSemana.Width) / 2;
            int izquierdaValor = (this.Width - lblValor.Width) / 2;

            if (izquierdaBarra < 0)
            {
                izquierdaBarra = 0;
            }

            if (izquierdaSemana < 0)
            {
                izquierdaSemana = 0;
            }

            if (izquierdaValor < 0)
            {
                izquierdaValor = 0;
            }

            pnlBarra.Left = izquierdaBarra;
            lblSemana.Left = izquierdaSemana;
            lblValor.Left = izquierdaValor;
        }

        public Color ColorBarra
        {
            get { return pnlBarra.BackColor; }
            set { pnlBarra.BackColor = value; }
        }
    }
}
