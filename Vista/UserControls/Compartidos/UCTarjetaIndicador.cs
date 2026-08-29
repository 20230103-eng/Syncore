using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCTarjetaIndicador : UserControl
    {
        public UCTarjetaIndicador()
        {
            InitializeComponent();
        }

        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        public string Valor
        {
            get { return lblValor.Text; }
            set { lblValor.Text = value; }
        }

        public string Detalle
        {
            get { return lblDetalle.Text; }
            set { lblDetalle.Text = value; }
        }

        public Color ColorValor
        {
            get { return lblValor.ForeColor; }
            set { lblValor.ForeColor = value; }
        }

        public Color ColorLinea
        {
            get { return pnlLinea.BackColor; }
            set { pnlLinea.BackColor = value; }
        }
    }
}
