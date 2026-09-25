using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCPaginadorGrid : UserControl
    {
        private const int RegistrosPorPagina = 20;
        private DataTable datosOriginales;
        private int paginaActual;
        private bool actualizandoSelector;

        public event EventHandler PaginaCambiada;

        public DataGridView Tabla { get; set; }

        public UCPaginadorGrid()
        {
            InitializeComponent();
            datosOriginales = new DataTable();
            paginaActual = 0;
        }

        public void Mostrar(DataTable datos)
        {
            if (datos == null)
            {
                datosOriginales = new DataTable();
            }
            else
            {
                datosOriginales = datos;
            }

            paginaActual = 0;
            ActualizarPagina(false);
        }

        private void ActualizarPagina(bool porNavegacion)
        {
            if (Tabla == null)
            {
                return;
            }

            int cantidad = datosOriginales.Rows.Count;
            int paginas = Math.Max(1, (cantidad + RegistrosPorPagina - 1) / RegistrosPorPagina);
            int inicio = paginaActual * RegistrosPorPagina;
            int final = Math.Min(inicio + RegistrosPorPagina, cantidad);
            DataTable pagina = datosOriginales.Clone();

            for (int indice = inicio; indice < final; indice = indice + 1)
            {
                pagina.ImportRow(datosOriginales.Rows[indice]);
            }

            Tabla.DataSource = pagina;
            Tabla.ClearSelection();

            actualizandoSelector = true;
            cboPagina.Items.Clear();
            for (int numero = 1; numero <= paginas; numero = numero + 1)
            {
                cboPagina.Items.Add(numero.ToString());
            }
            cboPagina.SelectedIndex = paginaActual;
            actualizandoSelector = false;

            btnAnterior.Enabled = paginaActual > 0;
            btnSiguiente.Enabled = paginaActual + 1 < paginas;
            Visible = cantidad > RegistrosPorPagina;

            if (cantidad == 0)
            {
                lblRegistros.Text = "Sin registros";
            }
            else
            {
                lblRegistros.Text = "Registros " + (inicio + 1) + " a " + final + " de " + cantidad;
            }

            if (porNavegacion == true && PaginaCambiada != null)
            {
                PaginaCambiada(this, EventArgs.Empty);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 0)
            {
                paginaActual = paginaActual - 1;
                ActualizarPagina(true);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int paginas = Math.Max(1, (datosOriginales.Rows.Count + RegistrosPorPagina - 1) / RegistrosPorPagina);
            if (paginaActual + 1 < paginas)
            {
                paginaActual = paginaActual + 1;
                ActualizarPagina(true);
            }
        }

        private void cboPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actualizandoSelector == false && cboPagina.SelectedIndex >= 0)
            {
                paginaActual = cboPagina.SelectedIndex;
                ActualizarPagina(true);
            }
        }
    }
}
