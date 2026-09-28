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
        private bool paginacionRemota;
        private int cantidadRemota;

        public event EventHandler PaginaCambiada;

        public DataGridView Tabla { get; set; }

        public int PaginaActual
        {
            get { return paginaActual; }
        }

        public void ReiniciarRemoto()
        {
            paginaActual = 0;
            paginacionRemota = true;
        }

        public void MostrarRemoto(DataTable pagina, int total)
        {
            paginacionRemota = true;
            cantidadRemota = Math.Max(0, total);
            int paginas = Math.Max(1, (cantidadRemota + RegistrosPorPagina - 1) / RegistrosPorPagina);
            if (paginaActual >= paginas)
            {
                paginaActual = 0;
                if (PaginaCambiada != null)
                {
                    PaginaCambiada(this, EventArgs.Empty);
                }
                return;
            }
            if (pagina == null)
            {
                pagina = new DataTable();
            }
            Tabla.DataSource = pagina;
            Tabla.ClearSelection();
            ActualizarSelector(cantidadRemota);
        }

        private void ActualizarSelector(int cantidad)
        {
            int paginas = Math.Max(1, (cantidad + RegistrosPorPagina - 1) / RegistrosPorPagina);
            int inicio = paginaActual * RegistrosPorPagina;
            int final = Math.Min(inicio + RegistrosPorPagina, cantidad);
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
            Visible = true;
            if (cantidad == 0)
            {
                lblRegistros.Text = "Sin registros";
            }
            else
            {
                lblRegistros.Text = "Registros " + (inicio + 1) + " a " + final + " de " + cantidad;
            }
        }

        public UCPaginadorGrid()
        {
            InitializeComponent();
            datosOriginales = new DataTable();
            paginaActual = 0;
        }

        public void Mostrar(DataTable datos)
        {
            paginacionRemota = false;
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
            Visible = true;

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
                if (paginacionRemota)
                {
                    if (PaginaCambiada != null) PaginaCambiada(this, EventArgs.Empty);
                }
                else
                {
                    ActualizarPagina(true);
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int total = paginacionRemota ? cantidadRemota : datosOriginales.Rows.Count;
            int paginas = Math.Max(1, (total + RegistrosPorPagina - 1) / RegistrosPorPagina);
            if (paginaActual + 1 < paginas)
            {
                paginaActual = paginaActual + 1;
                if (paginacionRemota)
                {
                    if (PaginaCambiada != null) PaginaCambiada(this, EventArgs.Empty);
                }
                else
                {
                    ActualizarPagina(true);
                }
            }
        }

        private void cboPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actualizandoSelector == false && cboPagina.SelectedIndex >= 0)
            {
                paginaActual = cboPagina.SelectedIndex;
                if (paginacionRemota)
                {
                    if (PaginaCambiada != null) PaginaCambiada(this, EventArgs.Empty);
                }
                else
                {
                    ActualizarPagina(true);
                }
            }
        }
    }
}
