using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCPaginadorTarjetas : UserControl
    {
        public const int RegistrosPorPagina = 20;
        private int cantidad;
        private int tamanoPagina = RegistrosPorPagina;
        private int paginaActual;
        private bool actualizando;

        public event EventHandler PaginaCambiada;

        public int TamanoPagina
        {
            get { return tamanoPagina; }
            set { tamanoPagina = Math.Max(1, Math.Min(20, value)); ActualizarControles(); }
        }

        public int Inicio
        {
            get { return paginaActual * tamanoPagina; }
        }

        public int Fin
        {
            get { return Math.Min(Inicio + tamanoPagina, cantidad); }
        }

        public UCPaginadorTarjetas()
        {
            InitializeComponent();
            paginaActual = 0;
            cantidad = 0;
            ToolTip ayuda = new ToolTip(this.components);
            ayuda.SetToolTip(btnAnterior, "Mostrar la página anterior.");
            ayuda.SetToolTip(btnSiguiente, "Mostrar la página siguiente.");
            ayuda.SetToolTip(cboPagina, "Seleccionar la página de registros.");
        }

        public void Configurar(int registros, bool reiniciar)
        {
            cantidad = Math.Max(0, registros);
            int paginas = Math.Max(1, (cantidad + tamanoPagina - 1) / tamanoPagina);
            if (reiniciar || paginaActual >= paginas)
            {
                paginaActual = 0;
            }
            ActualizarControles();
        }

        private void ActualizarControles()
        {
            int paginas = Math.Max(1, (cantidad + tamanoPagina - 1) / tamanoPagina);
            actualizando = true;
            cboPagina.Items.Clear();
            for (int numero = 1; numero <= paginas; numero++)
            {
                cboPagina.Items.Add(numero.ToString());
            }
            cboPagina.SelectedIndex = paginaActual;
            actualizando = false;
            btnAnterior.Enabled = paginaActual > 0;
            btnSiguiente.Enabled = paginaActual < paginas - 1;
            if (cantidad == 0)
            {
                lblRango.Text = "Sin registros";
            }
            else
            {
                lblRango.Text = (Inicio + 1) + "-" + Fin + " de " + cantidad;
            }
            Visible = true;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 0)
            {
                paginaActual = paginaActual - 1;
                ActualizarControles();
                if (PaginaCambiada != null) PaginaCambiada(this, EventArgs.Empty);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (Fin < cantidad)
            {
                paginaActual = paginaActual + 1;
                ActualizarControles();
                if (PaginaCambiada != null) PaginaCambiada(this, EventArgs.Empty);
            }
        }

        private void cboPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actualizando == false && cboPagina.SelectedIndex >= 0 && paginaActual != cboPagina.SelectedIndex)
            {
                paginaActual = cboPagina.SelectedIndex;
                ActualizarControles();
                if (PaginaCambiada != null) PaginaCambiada(this, EventArgs.Empty);
            }
        }
    }
}
