using System;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmSeleccionRol : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        public frmSeleccionRol()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(btnGestor, "Ingresar al sistema como Gestor.");
            toolTipAyuda.SetToolTip(btnColaborador, "Ingresar al sistema como Colaborador.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            CargarEmpresa();
        }


        private void CargarEmpresa()
        {
            ConfiguracionEmpresa modelo;
            ConfiguracionEmpresa configuracion;

            modelo = new ConfiguracionEmpresa();
            configuracion = modelo.ObtenerConfiguracion();

            if (configuracion != null && string.IsNullOrEmpty(configuracion.NombreEmpresa) == false)
            {
                lblBienvenido.Text = "Bienvenido a " + configuracion.NombreEmpresa;
            }
        }

        private void btnGestor_Click(object sender, EventArgs e)
        {
            frmLoginGestor formulario = new frmLoginGestor();

            this.Hide();
            formulario.ShowDialog();

            if (this.IsDisposed == false)
            {
                this.Show();
            }
        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            frmLoginColaborador formulario = new frmLoginColaborador();

            this.Hide();
            formulario.ShowDialog();

            if (this.IsDisposed == false)
            {
                this.Show();
            }
        }
    }
}
