using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCProductividadColaborador : UserControl
    {
        private int tareas;
        private int porcentajeATiempo;
        private int cumplimiento;
        private string tendencia;

        public UCProductividadColaborador()
        {
            InitializeComponent();
        }

        public string Nombre
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }

        public int Tareas
        {
            get { return tareas; }
            set
            {
                tareas = value;
                lblTareas.Text = tareas.ToString();
            }
        }

        public int PorcentajeATiempo
        {
            get { return porcentajeATiempo; }
            set
            {
                porcentajeATiempo = value;

                if (porcentajeATiempo < 0)
                    porcentajeATiempo = 0;

                if (porcentajeATiempo > 100)
                    porcentajeATiempo = 100;

                lblATiempo.Text = porcentajeATiempo + "%";
            }
        }

        public int Cumplimiento
        {
            get { return cumplimiento; }
            set
            {
                cumplimiento = value;

                if (cumplimiento < 0)
                    cumplimiento = 0;

                if (cumplimiento > 100)
                    cumplimiento = 100;

                ActualizarBarra();
            }
        }

        private void ActualizarBarra()
        {
            tlpCumplimiento.ColumnStyles[0].Width = cumplimiento;
            tlpCumplimiento.ColumnStyles[1].Width = 100 - cumplimiento;
        }

        public string Tendencia
        {
            get { return tendencia; }
            set
            {
                tendencia = value;
                lblTendencia.Text = value;
                CambiarTendencia();
            }
        }

        private void CambiarTendencia()
        {
            if (tendencia == "Alta")
            {
                lblTendencia.BackColor = Color.FromArgb(223, 246, 231);
                lblTendencia.ForeColor = Color.FromArgb(32, 169, 87);
            }
            else if (tendencia == "Baja")
            {
                lblTendencia.BackColor = Color.FromArgb(255, 232, 232);
                lblTendencia.ForeColor = Color.FromArgb(229, 37, 42);
            }
            else
            {
                lblTendencia.BackColor = Color.FromArgb(238, 240, 243);
                lblTendencia.ForeColor = Color.FromArgb(105, 118, 135);
            }
        }

        public Color ColorBarra
        {
            get { return pnlCumplimiento.BackColor; }
            set { pnlCumplimiento.BackColor = value; }
        }

        public Color ColorTendencia
        {
            get { return lblTendencia.ForeColor; }
            set { lblTendencia.ForeColor = value; }
        }

        public Color FondoTendencia
        {
            get { return lblTendencia.BackColor; }
            set { lblTendencia.BackColor = value; }
        }
    }
}
