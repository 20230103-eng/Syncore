using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCFilaHistorialTarea : UserControl
    {
        public UCFilaHistorialTarea()
        {
            InitializeComponent();
        }

        public string Cabecera { get { return lblCabecera.Text; } set { lblCabecera.Text = value; } }
        public string Detalle { get { return lblDetalle.Text; } set { lblDetalle.Text = value; } }
        public string Evidencia { get { return lblEvidencia.Text; } set { lblEvidencia.Text = value; } }
        public System.Drawing.Color ColorIndicador { get { return pnlPunto.BackColor; } set { pnlPunto.BackColor = value; } }
    }
}
