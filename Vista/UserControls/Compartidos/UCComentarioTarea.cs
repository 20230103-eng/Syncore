using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCComentarioTarea : UserControl
    {
        public UCComentarioTarea()
        {
            InitializeComponent();
        }

        public System.Drawing.Image ImagenPerfil { get { return picUsuario.Image; } set { picUsuario.Image = value; } }
        public string Usuario { get { return lblUsuario.Text; } set { lblUsuario.Text = value; } }
        public string Fecha { get { return lblFecha.Text; } set { lblFecha.Text = value; } }
        public string Comentario { get { return lblComentario.Text; } set { lblComentario.Text = value; } }
    }
}
