using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCHistorialAvance : UserControl
    {
        public UCHistorialAvance()
        {
            InitializeComponent();
        }

        public string Porcentaje
        {
            get { return lblPorcentaje.Text; }
            set { lblPorcentaje.Text = value; }
        }

        public string Tarea
        {
            get { return lblTarea.Text; }
            set { lblTarea.Text = value; }
        }

        public string Proyecto
        {
            get { return lblProyecto.Text; }
            set { lblProyecto.Text = value; }
        }

        public string Descripcion
        {
            get { return lblDescripcion.Text; }
            set { lblDescripcion.Text = value; }
        }

        public string Fecha
        {
            get { return lblFecha.Text; }
            set { lblFecha.Text = value; }
        }

        public Color ColorPunto
        {
            get { return pnlPunto.BackColor; }
            set { pnlPunto.BackColor = value; }
        }
    }
}
