using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCAlertaGestion : UserControl
    {
        private string tipoAlerta;

        public event EventHandler AccionSolicitada;

        public int IdProyecto { get; set; }

        public int IdTarea { get; set; }

        public UCAlertaGestion()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }

        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        public string Detalle
        {
            get { return lblDetalle.Text; }
            set { lblDetalle.Text = value; }
        }

        public string Fecha
        {
            get { return lblFecha.Text; }
            set { lblFecha.Text = value; }
        }

        public string TextoBoton
        {
            get { return btnAccion.Text; }
            set { btnAccion.Text = value; }
        }

        public string TipoAlerta
        {
            get { return tipoAlerta; }
            set
            {
                tipoAlerta = value;
                CambiarColorAlerta();
            }
        }

        private void CambiarColorAlerta()
        {
            if (tipoAlerta == "Crítica")
            {
                lblPunto.ForeColor = Color.FromArgb(229, 37, 42);
            }
            else if (tipoAlerta == "Advertencia")
            {
                lblPunto.ForeColor = Color.FromArgb(240, 128, 49);
            }
            else
            {
                lblPunto.ForeColor = Color.FromArgb(52, 99, 171);
            }
        }

        public Color ColorPunto
        {
            get { return lblPunto.ForeColor; }
            set { lblPunto.ForeColor = value; }
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
