using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmRegistrarAvance : Form
    {
        private Proyecto proyectoModelo;
        private Tarea tareaModelo;
        private Avance avanceModelo;
        private int avanceActualTarea;
        private string rutaEvidencia;

        public event EventHandler VolverSolicitado;

        public int IdTareaInicial { get; set; }

        public frmRegistrarAvance()
        {
            InitializeComponent();
        }

        private void frmRegistrarAvance_Load(object sender, EventArgs e)
        {
            proyectoModelo = new Proyecto();
            tareaModelo = new Tarea();
            avanceModelo = new Avance();
            avanceActualTarea = 0;
            rutaEvidencia = "";
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");

            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("No hay una sesión activa.");
                pnlFormulario.Enabled = false;
                return;
            }

            dtpFecha.Value = DateTime.Today;
            CargarProyectos();
            SeleccionarTareaInicial();
            CargarHistorial();
            ActualizarAvance();
        }

        private void CargarProyectos()
        {
            DataTable proyectos;
            int idUsuario;

            idUsuario = Sesion.UsuarioActual.IdUsuario;
            proyectos = proyectoModelo.ObtenerCatalogoProyectosUsuario(idUsuario);

            cboProyecto.DisplayMember = "Proyecto";
            cboProyecto.ValueMember = "IdProyecto";
            cboProyecto.DataSource = proyectos;
            cboProyecto.SelectedIndex = -1;
            cboTarea.DataSource = null;
        }

        private void SeleccionarTareaInicial()
        {
            DataTable datos;
            int idProyecto;

            if (IdTareaInicial <= 0)
            {
                return;
            }

            datos = tareaModelo.ObtenerDetalleTarea(IdTareaInicial);

            if (datos.Rows.Count == 0)
            {
                return;
            }

            idProyecto = Convert.ToInt32(datos.Rows[0]["IdProyecto"]);
            cboProyecto.SelectedValue = idProyecto;
            CargarTareas();
            cboTarea.SelectedValue = IdTareaInicial;
            btnCancelar.Text = "← Volver al detalle";
        }

        private void cboProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTareas();
        }

        private void CargarTareas()
        {
            DataTable tareas;
            int idUsuario;
            int idProyecto;

            cboTarea.DataSource = null;
            avanceActualTarea = 0;
            txtPorcentaje.Text = "0";

            if (cboProyecto.SelectedValue == null)
            {
                return;
            }

            if (int.TryParse(cboProyecto.SelectedValue.ToString(), out idProyecto) == false)
            {
                return;
            }

            idUsuario = Sesion.UsuarioActual.IdUsuario;
            tareas = tareaModelo.ObtenerTareasUsuarioProyecto(idUsuario, idProyecto);

            cboTarea.DisplayMember = "Tarea";
            cboTarea.ValueMember = "IdTarea";
            cboTarea.DataSource = tareas;
            cboTarea.SelectedIndex = -1;
        }

        private void cboTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idTarea;

            if (cboTarea.SelectedValue == null)
            {
                avanceActualTarea = 0;
                txtPorcentaje.Text = "0";
                return;
            }

            if (int.TryParse(cboTarea.SelectedValue.ToString(), out idTarea) == false)
            {
                return;
            }

            avanceActualTarea = tareaModelo.ObtenerAvanceActualTarea(idTarea);
            txtPorcentaje.Text = avanceActualTarea.ToString();
        }

        private void txtPorcentaje_TextChanged(object sender, EventArgs e)
        {
            ActualizarAvance();
        }

        private void ActualizarAvance()
        {
            int porcentaje;

            if (int.TryParse(txtPorcentaje.Text, out porcentaje) == false)
            {
                porcentaje = 0;
            }

            if (porcentaje < 0)
            {
                porcentaje = 0;
            }

            if (porcentaje > 100)
            {
                porcentaje = 100;
            }

            lblPorcentajeValor.Text = porcentaje.ToString() + "%";

            if (tlpBarraPorcentaje.ColumnStyles.Count < 2)
            {
                return;
            }

            tlpBarraPorcentaje.ColumnStyles[0].Width = porcentaje;
            tlpBarraPorcentaje.ColumnStyles[1].Width = 100 - porcentaje;

            if (porcentaje == 0)
            {
                pnlAvance.Visible = false;
            }
            else
            {
                pnlAvance.Visible = true;
            }
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorArchivo;
            DialogResult resultado;

            selectorArchivo = new OpenFileDialog();
            selectorArchivo.Title = "Seleccionar evidencia";
            selectorArchivo.Filter = "Todos los archivos|*.*";
            selectorArchivo.Multiselect = false;
            resultado = selectorArchivo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                rutaEvidencia = selectorArchivo.FileName;
                btnAdjuntar.Text = "Evidencia lista";
                MessageBox.Show("Se seleccionó el archivo: " + Path.GetFileName(rutaEvidencia));
            }

            selectorArchivo.Dispose();
        }

        private bool ValidarDatos()
        {
            int porcentaje;

            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("No hay una sesión activa.");
                return false;
            }

            if (cboProyecto.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el proyecto.");
                cboProyecto.Focus();
                return false;
            }

            if (cboTarea.SelectedValue == null)
            {
                MessageBox.Show("Seleccione la tarea.");
                cboTarea.Focus();
                return false;
            }

            if (int.TryParse(txtPorcentaje.Text, out porcentaje) == false)
            {
                MessageBox.Show("Ingrese un porcentaje válido.");
                txtPorcentaje.Focus();
                return false;
            }

            if (porcentaje < 0 || porcentaje > 100)
            {
                MessageBox.Show("El porcentaje debe estar entre 0 y 100.");
                txtPorcentaje.Focus();
                return false;
            }

            if (porcentaje < avanceActualTarea)
            {
                MessageBox.Show("El nuevo porcentaje no puede ser menor que el avance actual de " + avanceActualTarea + "%.");
                txtPorcentaje.Focus();
                return false;
            }

            if (dtpFecha.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de registro no puede ser futura.");
                dtpFecha.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()) == true)
            {
                MessageBox.Show("Ingrese la descripción del avance.");
                txtDescripcion.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool datosCorrectos;
            Avance avance;
            int idAvance;
            bool evidenciaGuardada;

            datosCorrectos = ValidarDatos();

            if (datosCorrectos == false)
            {
                return;
            }

            avance = new Avance();
            avance.IdTarea = Convert.ToInt32(cboTarea.SelectedValue);
            avance.IdUsuario = Sesion.UsuarioActual.IdUsuario;
            avance.Porcentaje = Convert.ToInt32(txtPorcentaje.Text);
            avance.FechaRegistro = dtpFecha.Value;
            avance.Descripcion = txtDescripcion.Text.Trim();
            avance.Dificultades = txtDificultades.Text.Trim();
            avance.ProximosPasos = txtProximos.Text.Trim();
            idAvance = avance.RegistrarAvance();

            if (idAvance == 0)
            {
                return;
            }

            evidenciaGuardada = true;

            if (string.IsNullOrEmpty(rutaEvidencia) == false)
            {
                evidenciaGuardada = GuardarEvidencia(idAvance);
            }

            if (evidenciaGuardada == true)
            {
                MessageBox.Show("El avance fue registrado correctamente.");
            }
            else
            {
                MessageBox.Show("El avance fue registrado, pero no se pudo guardar la evidencia.");
            }

            LimpiarCampos();
            CargarTareas();
            CargarHistorial();
        }

        private bool GuardarEvidencia(int idAvance)
        {
            Evidencia evidencia;
            bool guardada;

            evidencia = new Evidencia();
            evidencia.IdAvance = idAvance;
            evidencia.NombreArchivo = Path.GetFileName(rutaEvidencia);
            evidencia.RutaArchivo = rutaEvidencia;
            evidencia.TipoArchivo = Path.GetExtension(rutaEvidencia);
            evidencia.FechaSubida = DateTime.Now;
            guardada = evidencia.GuardarEvidencia();
            return guardada;
        }

        private void CargarHistorial()
        {
            DataTable avances;
            int idUsuario;
            int indice;

            flpHistorial.Controls.Clear();
            idUsuario = Sesion.UsuarioActual.IdUsuario;
            avances = avanceModelo.ObtenerAvancesUsuario(idUsuario, 30, 10);

            if (avances.Rows.Count == 0)
            {
                MostrarHistorialVacio();
                return;
            }

            for (indice = avances.Rows.Count - 1; indice >= 0; indice = indice - 1)
            {
                DataRow fila;
                UCHistorialAvance control;

                fila = avances.Rows[indice];
                control = new UCHistorialAvance();
                control.Porcentaje = Convert.ToInt32(fila["Porcentaje"]) + "%";
                control.Tarea = fila["Tarea"].ToString();
                control.Proyecto = fila["Proyecto"].ToString();
                control.Descripcion = fila["Descripcion"].ToString();
                control.Fecha = Convert.ToDateTime(fila["FechaRegistro"]).ToString("dd MMM");
                control.ColorPunto = Color.FromArgb(0, 105, 240);
                control.Width = flpHistorial.ClientSize.Width - 28;
                flpHistorial.Controls.Add(control);
                control.BringToFront();
            }
        }

        private void MostrarHistorialVacio()
        {
            Label mensaje;

            mensaje = new Label();
            mensaje.AutoSize = false;
            mensaje.Dock = DockStyle.Top;
            mensaje.Height = 50;
            mensaje.Text = "No hay avances registrados.";
            mensaje.TextAlign = ContentAlignment.MiddleCenter;
            mensaje.ForeColor = Color.FromArgb(102, 118, 138);
            flpHistorial.Controls.Add(mensaje);
        }

        private void LimpiarCampos()
        {
            cboTarea.SelectedIndex = -1;
            avanceActualTarea = 0;
            txtPorcentaje.Text = "0";
            dtpFecha.Value = DateTime.Today;
            txtDescripcion.Clear();
            txtDificultades.Clear();
            txtProximos.Clear();
            rutaEvidencia = "";
            btnAdjuntar.Text = "Adjuntar evidencia";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (IdTareaInicial > 0 && VolverSolicitado != null)
            {
                VolverSolicitado(this, EventArgs.Empty);
                return;
            }

            LimpiarCampos();
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
