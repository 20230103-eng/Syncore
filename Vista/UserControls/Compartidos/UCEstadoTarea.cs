using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCEstadoTarea : UserControl
    {
        private int avance = 60;

        public event EventHandler AccionSolicitada;

        public UCEstadoTarea()
        {
            InitializeComponent();
            btnAccion.Click += btnAccion_Click;
        }

        public string Estado
        {
            get
            {
                return lblEstado.Text;
            }
            set
            {
                lblEstado.Text = value;
                AplicarColorEstado();
            }
        }

        public int Avance
        {
            get
            {
                return avance;
            }
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
            }
        }

        public string Vencimiento
        {
            get
            {
                return lblVencimiento.Text;
            }
            set
            {
                lblVencimiento.Text = value;

                if (value == "Hoy" || value == "Vencida")
                {
                    lblVencimiento.ForeColor = Color.FromArgb(230, 57, 70);
                }
                else
                {
                    lblVencimiento.ForeColor = Color.FromArgb(11, 55, 104);
                }
            }
        }

        public string Prioridad
        {
            get
            {
                return lblPrioridad.Text;
            }
            set
            {
                lblPrioridad.Text = value;
                AplicarColorPrioridad();
            }
        }

        public string Evidencias
        {
            get
            {
                return lblEvidencia.Text;
            }
            set
            {
                lblEvidencia.Text = value;
            }
        }

        public string TextoBoton
        {
            get
            {
                return btnAccion.Text;
            }
            set
            {
                btnAccion.Text = value;

                if (string.IsNullOrEmpty(value) == true)
                {
                    btnAccion.Visible = false;
                    tlpEstado.RowStyles[5].Height = 0;
                }
                else
                {
                    btnAccion.Visible = true;
                    tlpEstado.RowStyles[5].Height = 42;
                }
            }
        }

        private void AplicarColorEstado()
        {
            if (lblEstado.Text == "En progreso" || lblEstado.Text == "En proceso")
            {
                lblEstado.BackColor = Color.FromArgb(255, 243, 214);
                lblEstado.ForeColor = Color.FromArgb(232, 145, 0);
            }
            else if (lblEstado.Text == "Completada" || lblEstado.Text == "Activo")
            {
                lblEstado.BackColor = Color.FromArgb(221, 245, 230);
                lblEstado.ForeColor = Color.FromArgb(31, 175, 91);
            }
            else if (lblEstado.Text == "Vencida" || lblEstado.Text == "Crítico" || lblEstado.Text == "Devuelta")
            {
                lblEstado.BackColor = Color.FromArgb(253, 228, 232);
                lblEstado.ForeColor = Color.FromArgb(230, 57, 70);
            }
            else
            {
                lblEstado.BackColor = Color.FromArgb(232, 241, 255);
                lblEstado.ForeColor = Color.FromArgb(0, 105, 240);
            }
        }

        private void AplicarColorPrioridad()
        {
            if (lblPrioridad.Text == "Alta")
            {
                lblPrioridad.BackColor = Color.FromArgb(253, 228, 232);
                lblPrioridad.ForeColor = Color.FromArgb(230, 57, 70);
            }
            else if (lblPrioridad.Text == "Media")
            {
                lblPrioridad.BackColor = Color.FromArgb(255, 243, 214);
                lblPrioridad.ForeColor = Color.FromArgb(232, 145, 0);
            }
            else
            {
                lblPrioridad.BackColor = Color.FromArgb(221, 245, 230);
                lblPrioridad.ForeColor = Color.FromArgb(31, 175, 91);
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (AccionSolicitada != null)
            {
                AccionSolicitada(this, EventArgs.Empty);
            }
        }
    }
}
