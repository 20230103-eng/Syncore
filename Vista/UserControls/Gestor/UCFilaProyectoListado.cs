using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCFilaProyectoListado : UserControl
    {
        public event EventHandler VerProyectoSolicitado;
        public event EventHandler EditarProyectoSolicitado;

        public UCFilaProyectoListado()
        {
            InitializeComponent();
        }

        public int IdProyecto { get; set; }
        public string Codigo { get { return lblCodigo.Text; } set { lblCodigo.Text = value; } }
        public string NombreProyecto { get { return lblNombre.Text; } set { lblNombre.Text = value; } }
        public string TipoProyecto { get { return lblTipo.Text; } set { lblTipo.Text = value; } }
        public string Area { get { return lblArea.Text; } set { lblArea.Text = value; } }
        public string Responsable { get { return lblResponsable.Text; } set { lblResponsable.Text = value; } }
        public string Estado { get { return lblEstado.Text; } set { lblEstado.Text = value; AplicarEstado(); } }
        public string Prioridad { get { return lblPrioridad.Text; } set { lblPrioridad.Text = value; } }
        public int Avance
        {
            get { return avance; }
            set
            {
                avance = value;
                if (avance < 0) avance = 0;
                if (avance > 100) avance = 100;
                lblAvance.Text = avance + "%";
                ActualizarBarra();
            }
        }

        private int avance = 45;

        private void ActualizarBarra()
        {
            tlpBarraPorcentaje.ColumnStyles[0].Width = avance;
            tlpBarraPorcentaje.ColumnStyles[1].Width = 100 - avance;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (EditarProyectoSolicitado != null)
            {
                EditarProyectoSolicitado(this, EventArgs.Empty);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (VerProyectoSolicitado != null)
            {
                VerProyectoSolicitado(this, EventArgs.Empty);
            }
        }

        private void AplicarEstado()
        {
            lblEstado.BackColor = System.Drawing.Color.FromArgb(232, 248, 239);
            lblEstado.ForeColor = System.Drawing.Color.FromArgb(32, 169, 87);

            if (Estado == "Crítico")
            {
                lblEstado.BackColor = System.Drawing.Color.FromArgb(255, 232, 233);
                lblEstado.ForeColor = System.Drawing.Color.FromArgb(229, 37, 42);
            }
            else if (Estado == "Observación")
            {
                lblEstado.BackColor = System.Drawing.Color.FromArgb(255, 246, 219);
                lblEstado.ForeColor = System.Drawing.Color.FromArgb(210, 126, 0);
            }
            else if (Estado == "Cerrado")
            {
                lblEstado.BackColor = System.Drawing.Color.FromArgb(238, 241, 245);
                lblEstado.ForeColor = System.Drawing.Color.FromArgb(105, 118, 135);
            }
        }
    }
}
