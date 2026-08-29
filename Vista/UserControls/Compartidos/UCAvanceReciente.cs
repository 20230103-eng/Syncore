using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCAvanceReciente : UserControl
    {
        private int porcentaje;

        public UCAvanceReciente()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
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
