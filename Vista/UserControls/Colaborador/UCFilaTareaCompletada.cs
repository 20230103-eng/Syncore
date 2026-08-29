using System.Windows.Forms;

namespace Vista
{
    public partial class UCFilaTareaCompletada : UserControl
    {
        public UCFilaTareaCompletada()
        {
            InitializeComponent();
        }

        public string NombreTarea
        {
            get { return lblTarea.Text; }
            set { lblTarea.Text = value; }
        }
    }
}
