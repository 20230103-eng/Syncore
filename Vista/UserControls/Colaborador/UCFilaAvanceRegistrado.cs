using System.Windows.Forms;

namespace Vista
{
    public partial class UCFilaAvanceRegistrado : UserControl
    {
        public UCFilaAvanceRegistrado()
        {
            InitializeComponent();
        }

        public string Fecha
        {
            get { return lblFecha.Text; }
            set { lblFecha.Text = value; }
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

        public string Avance
        {
            get { return lblAvance.Text; }
            set { lblAvance.Text = value; }
        }
    }
}
