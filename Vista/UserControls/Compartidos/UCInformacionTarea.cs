using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCInformacionTarea : UserControl
    {
        public UCInformacionTarea()
        {
            InitializeComponent();
        }

        public string Proyecto { get { return lblValor0.Text; } set { lblValor0.Text = value; } }
        public string Responsable { get { return lblValor1.Text; } set { lblValor1.Text = value; } }
        public string FechaInicio { get { return lblValor2.Text; } set { lblValor2.Text = value; } }
        public string FechaLimite { get { return lblValor3.Text; } set { lblValor3.Text = value; } }
        public string Prioridad { get { return lblValor4.Text; } set { lblValor4.Text = value; } }
        public string HitoRelacionado { get { return lblValor5.Text; } set { lblValor5.Text = value; } }
        public string Descripcion { get { return lblValor6.Text; } set { lblValor6.Text = value; } }
        public string Observaciones { get { return lblValor7.Text; } set { lblValor7.Text = value; } }
    }
}
