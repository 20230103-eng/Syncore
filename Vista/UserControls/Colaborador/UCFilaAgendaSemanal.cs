using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCFilaAgendaSemanal : UserControl
    {
        public UCFilaAgendaSemanal()
        {
            InitializeComponent();
        }

        public string Dia
        {
            get { return lblDia.Text; }
            set { lblDia.Text = value; }
        }

        public string Actividad
        {
            get { return lblActividad.Text; }
            set { lblActividad.Text = value; }
        }

        public string Hora
        {
            get { return lblHora.Text; }
            set { lblHora.Text = value; }
        }

        public Color ColorIndicador
        {
            get { return pnlIndicador.BackColor; }
            set { pnlIndicador.BackColor = value; }
        }
    }
}
