using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCCeldaCalendario : UserControl
    {
        public event EventHandler EventoSolicitado;

        public DateTime Fecha { get; set; }
        public int IdTarea { get; set; }
        public int IdProyecto { get; set; }

        public UCCeldaCalendario()
        {
            InitializeComponent();
            pnlEvento.Cursor = Cursors.Hand;
            lblEvento.Cursor = Cursors.Hand;
            pnlEvento.Click += pnlEvento_Click;
            lblEvento.Click += pnlEvento_Click;
        }

        public string Dia
        {
            get { return lblDia.Text; }
            set { lblDia.Text = value; }
        }

        public Color ColorDia
        {
            get { return lblDia.ForeColor; }
            set { lblDia.ForeColor = value; }
        }

        public string Evento
        {
            get { return lblEvento.Text; }
            set { lblEvento.Text = value; }
        }

        public Color ColorEvento
        {
            get { return pnlEvento.BackColor; }
            set
            {
                pnlEvento.BackColor = value;
                lblEvento.BackColor = value;
            }
        }

        public Color ColorTextoEvento
        {
            get { return lblEvento.ForeColor; }
            set { lblEvento.ForeColor = value; }
        }

        public bool MostrarEvento
        {
            get { return pnlEvento.Visible; }
            set { pnlEvento.Visible = value; }
        }

        private void pnlEvento_Click(object sender, EventArgs e)
        {
            if (IdTarea <= 0)
            {
                return;
            }

            if (EventoSolicitado != null)
            {
                EventoSolicitado(this, EventArgs.Empty);
            }
        }
    }
}
