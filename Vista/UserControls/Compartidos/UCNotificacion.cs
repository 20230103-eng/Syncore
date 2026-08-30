using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCNotificacion : UserControl
    {
        private string tipoNotificacion;
        private bool leida;

        public event EventHandler AccionPrincipalSolicitada;
        public event EventHandler MarcarLeidaSolicitada;

        public int IdNotificacion { get; set; }
        public int IdTarea { get; set; }
        public int IdProyecto { get; set; }

        public UCNotificacion()
        {
            InitializeComponent();
        }

        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
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

        public string TextoBotonPrincipal
        {
            get { return btnIrTarea.Text; }
            set { btnIrTarea.Text = value; }
        }

        public bool MostrarBotonPrincipal
        {
            get { return btnIrTarea.Visible; }
            set { btnIrTarea.Visible = value; }
        }

        public string TextoBotonSecundario
        {
            get { return btnMarcarLeida.Text; }
            set { btnMarcarLeida.Text = value; }
        }

        public string TipoNotificacion
        {
            get { return tipoNotificacion; }
            set
            {
                tipoNotificacion = value;
                CambiarColorNotificacion();
            }
        }

        private void CambiarColorNotificacion()
        {
            if (tipoNotificacion == "Tarea vencida")
            {
                lblPunto.ForeColor = Color.FromArgb(229, 37, 42);
            }
            else if (tipoNotificacion == "Tarea devuelta")
            {
                lblPunto.ForeColor = Color.FromArgb(240, 128, 49);
            }
            else if (tipoNotificacion == "Alerta proyecto")
            {
                lblPunto.ForeColor = Color.FromArgb(137, 93, 238);
            }
            else
            {
                lblPunto.ForeColor = Color.FromArgb(52, 99, 171);
            }
        }

        public bool Leida
        {
            get { return leida; }
            set
            {
                leida = value;

                if (leida == true)
                {
                    btnMarcarLeida.Visible = false;
                    lblLeida.Visible = true;
                    BackColor = Color.FromArgb(250, 251, 253);
                }
                else
                {
                    lblLeida.Visible = false;
                    btnMarcarLeida.Visible = true;
                    btnMarcarLeida.Enabled = true;
                    btnMarcarLeida.Text = "Marcar leída";
                    BackColor = Color.White;
                }
            }
        }

        public Color ColorPunto
        {
            get { return lblPunto.ForeColor; }
            set { lblPunto.ForeColor = value; }
        }

        private void btnIrTarea_Click(object sender, EventArgs e)
        {
            if (AccionPrincipalSolicitada != null)
            {
                AccionPrincipalSolicitada(this, EventArgs.Empty);
            }
        }

        private void btnMarcarLeida_Click(object sender, EventArgs e)
        {
            if (MarcarLeidaSolicitada != null)
            {
                MarcarLeidaSolicitada(this, EventArgs.Empty);
            }
        }
    }
}
