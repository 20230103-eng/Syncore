using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCAvanceReciente : UserControl
    {
        private int porcentaje;

        public int IdTarea { get; set; }
        public event EventHandler VerSolicitado;

        public UCAvanceReciente()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            this.Click += avance_Click;
            tlpPrincipal.Click += avance_Click;
            pnlTexto.Click += avance_Click;
            picAvatar.Click += avance_Click;
            lblNombre.Click += avance_Click;
            lblTarea.Click += avance_Click;
            lblPorcentaje.Click += avance_Click;
        }

        public void ConfigurarAyuda(ToolTip ayuda)
        {
            ayuda.SetToolTip(this, "Abrir el detalle de la tarea.");
            ayuda.SetToolTip(tlpPrincipal, "Abrir el detalle de la tarea.");
            ayuda.SetToolTip(pnlTexto, "Abrir el detalle de la tarea.");
            ayuda.SetToolTip(picAvatar, "Abrir el detalle de la tarea.");
            ayuda.SetToolTip(lblNombre, "Abrir el detalle de la tarea.");
            ayuda.SetToolTip(lblTarea, "Abrir el detalle de la tarea.");
            ayuda.SetToolTip(lblPorcentaje, "Abrir el detalle de la tarea.");
        }

        private void avance_Click(object sender, EventArgs e)
        {
            if (IdTarea > 0 && VerSolicitado != null)
            {
                VerSolicitado(this, EventArgs.Empty);
            }
        }

        public string Nombre
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }

        public string Tarea
        {
            get { return lblTarea.Text; }
            set { lblTarea.Text = value; }
        }

        public int Porcentaje
        {
            get { return porcentaje; }
            set
            {
                porcentaje = value;

                if (porcentaje < 0)
                    porcentaje = 0;

                if (porcentaje > 100)
                    porcentaje = 100;

                lblPorcentaje.Text = porcentaje + "%";
            }
        }

        public Color ColorPorcentaje
        {
            get { return lblPorcentaje.ForeColor; }
            set { lblPorcentaje.ForeColor = value; }
        }

        public Image ImagenPerfil
        {
            get { return picAvatar.Image; }
            set { picAvatar.Image = value; }
        }

        public PictureBoxSizeMode ModoImagen
        {
            get { return picAvatar.SizeMode; }
            set { picAvatar.SizeMode = value; }
        }
    }
}
