using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCEvidenciaTarea : UserControl
    {
        public UCEvidenciaTarea()
        {
            InitializeComponent();
        }

        public string NombreArchivo { get { return lblArchivo.Text; } set { lblArchivo.Text = value; } }
        public string DetalleArchivo { get { return lblDetalle.Text; } set { lblDetalle.Text = value; } }
    }
}
