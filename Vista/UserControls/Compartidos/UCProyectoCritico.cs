using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCProyectoCritico : UserControl
    {
        private int avance;
        private int tareasVencidas;
        private string estado;

        public event EventHandler VerSolicitado;

        public int IdProyecto { get; set; }

        public UCProyectoCritico()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }

        public string NombreProyecto
        {
            get { return lblProyecto.Text; }
            set { lblProyecto.Text = value; }
        }

        public string Area
        {
            get { return lblArea.Text; }
            set { lblArea.Text = value; }
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
            tlpProgreso.ColumnStyles[0].Width = avance;
            tlpProgreso.ColumnStyles[1].Width = 100 - avance;
        }

        public int TareasVencidas
        {
            get { return tareasVencidas; }
            set
            {
                tareasVencidas = value;
                lblTareas.Text = tareasVencidas.ToString();
            }
        }

        public string Estado
        {
            get { return estado; }
            set
            {
                estado = value;
                lblEstado.Text = value;
                CambiarEstado();
            }
        }

        private void CambiarEstado()
        {
            if (estado == "Crítico")
            {
                lblEstado.BackColor = Color.FromArgb(255, 232, 232);
                lblEstado.ForeColor = Color.FromArgb(229, 37, 42);
            }
            else if (estado == "Observación")
            {
                lblEstado.BackColor = Color.FromArgb(255, 244, 221);
                lblEstado.ForeColor = Color.FromArgb(240, 128, 49);
            }
            else
            {
                lblEstado.BackColor = Color.FromArgb(223, 246, 231);
                lblEstado.ForeColor = Color.FromArgb(32, 169, 87);
            }
        }

        public Color ColorAvance
        {
            get { return pnlProgreso.BackColor; }
            set
            {
                pnlProgreso.BackColor = value;
                lblAvance.ForeColor = value;
            }
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

        public string TextoBoton
        {
            get { return btnVer.Text; }
            set { btnVer.Text = value; }
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
