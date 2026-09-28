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
        private bool validacionEnTiempoRealHabilitada;
        private System.Windows.Forms.ToolTip toolTipAyuda;
        private System.Windows.Forms.ErrorProvider errorProviderValidacion;

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
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            errorProviderValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            errorProviderValidacion.ContainerControl = this;
            errorProviderValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            toolTipAyuda.SetToolTip(cboProyecto, "Seleccione proyecto.");
            toolTipAyuda.SetToolTip(cboTarea, "Seleccione tarea.");
            toolTipAyuda.SetToolTip(txtPorcentaje, "Ingrese porcentaje de avance.");
            toolTipAyuda.SetToolTip(dtpFecha, "Seleccione fecha.");
            toolTipAyuda.SetToolTip(txtDescripcion, "Ingrese descripción.");
            toolTipAyuda.SetToolTip(txtDificultades, "Ingrese dificultades encontradas.");
            toolTipAyuda.SetToolTip(txtProximos, "Ingrese próximos pasos.");
            toolTipAyuda.SetToolTip(btnAdjuntar, "Adjuntar una evidencia al avance.");
            toolTipAyuda.SetToolTip(btnGuardar, "Guardar la información ingresada.");
            toolTipAyuda.SetToolTip(btnCancelar, "Cancelar la operación actual.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            ucPaginadorHistorial.PaginaCambiada += ucPaginadorHistorial_PaginaCambiada;

            txtPorcentaje.TextChanged += CamposEnTiempoReal;
            txtPorcentaje.Leave += CamposEnTiempoReal;
            txtDescripcion.TextChanged += CamposEnTiempoReal;
            txtDescripcion.Leave += CamposEnTiempoReal;
            cboProyecto.SelectedIndexChanged += CamposEnTiempoReal;
            cboProyecto.Leave += CamposEnTiempoReal;
            cboTarea.SelectedIndexChanged += CamposEnTiempoReal;
            cboTarea.Leave += CamposEnTiempoReal;
            dtpFecha.ValueChanged += CamposEnTiempoReal;
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
                CatalogoErrores.MostrarDetalle("ERR-NEG-001", "Syncore", "No hay una sesión activa.");
                pnlFormulario.Enabled = false;
                return;
            }

            dtpFecha.Value = DateTime.Today;
            CargarProyectos();
            SeleccionarTareaInicial();
            CargarHistorial();
            ActualizarAvance();
        
            validacionEnTiempoRealHabilitada = true;
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
            errorProviderValidacion.Clear();

            if (Sesion.UsuarioActual == null)
            {
                CatalogoErrores.MostrarDetalle("ERR-NEG-001", "Syncore", "No hay una sesión activa.");
                return false;
            }

            if (cboProyecto.SelectedValue == null)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, cboProyecto, "ERR-VAL-007", "Seleccione el proyecto.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Syncore", "Seleccione el proyecto.");
                cboProyecto.Focus();
                return false;
            }

            if (cboTarea.SelectedValue == null)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, cboTarea, "ERR-VAL-007", "Seleccione la tarea.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Syncore", "Seleccione la tarea.");
                cboTarea.Focus();
                return false;
            }

            foreach (char caracter in txtPorcentaje.Text)
            {
                if (char.IsDigit(caracter) == false)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtPorcentaje, "ERR-VAL-002", "El porcentaje solo admite números enteros.");
                    CatalogoErrores.MostrarDetalle("ERR-VAL-002", "Syncore", "El porcentaje solo admite números enteros.");
                    txtPorcentaje.Focus();
                    return false;
                }
            }
            if (int.TryParse(txtPorcentaje.Text, out porcentaje) == false)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtPorcentaje, "ERR-VAL-002", "Ingrese un porcentaje válido.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-002", "Syncore", "Ingrese un porcentaje válido.");
                txtPorcentaje.Focus();
                return false;
            }

            if (porcentaje < 0 || porcentaje > 100)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtPorcentaje, "ERR-VAL-003", "El porcentaje debe estar entre 0 y 100.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-003", "Syncore", "El porcentaje debe estar entre 0 y 100.");
                txtPorcentaje.Focus();
                return false;
            }

            if (porcentaje < avanceActualTarea)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtPorcentaje, "ERR-VAL-004", "El porcentaje no puede ser inferior al avance actual de " + avanceActualTarea + "%. ");
                CatalogoErrores.MostrarDetalle("ERR-VAL-004", "Registrar avance", "El nuevo porcentaje no puede ser menor que el avance actual de " + avanceActualTarea + "%.");
                txtPorcentaje.Focus();
                return false;
            }

            if (dtpFecha.Value.Date > DateTime.Today)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, dtpFecha, "ERR-VAL-004", "La fecha no puede ser futura.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-004", "Syncore", "La fecha de registro no puede ser futura.");
                dtpFecha.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtDescripcion, "ERR-VAL-001", "Ingrese la descripción del avance.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-001", "Syncore", "Ingrese la descripción del avance.");
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
                CatalogoErrores.MostrarDetalle("ERR-APP-002", "Evidencia", "El avance fue registrado, pero no se pudo guardar la evidencia.");
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
            int total;
            int pagina = ucPaginadorHistorial.Inicio / ucPaginadorHistorial.TamanoPagina;
            avances = avanceModelo.ObtenerAvancesUsuarioPagina(idUsuario, 30, pagina,
                ucPaginadorHistorial.TamanoPagina, out total);
            ucPaginadorHistorial.Configurar(total, false);
            if (pagina != ucPaginadorHistorial.Inicio / ucPaginadorHistorial.TamanoPagina)
            {
                CargarHistorial();
                return;
            }

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

        private void ucPaginadorHistorial_PaginaCambiada(object sender, EventArgs e)
        {
            CargarHistorial();
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
        private void CamposEnTiempoReal(object sender, EventArgs e)
        {
            if (validacionEnTiempoRealHabilitada == false)
            {
                return;
            }

            if (sender == txtPorcentaje)
            {
                int porcentaje;
                bool soloDigitos;
                soloDigitos = txtPorcentaje.Text.Length > 0;
                foreach (char caracter in txtPorcentaje.Text)
                {
                    if (char.IsDigit(caracter) == false)
                    {
                        soloDigitos = false;
                    }
                }
                if (soloDigitos == false || int.TryParse(txtPorcentaje.Text, out porcentaje) == false)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtPorcentaje, "ERR-VAL-002", "Ingrese un porcentaje válido.");
                }
                else if (porcentaje < 0 || porcentaje > 100)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtPorcentaje, "ERR-VAL-003", "El porcentaje debe estar entre 0 y 100.");
                }
                else if (porcentaje < avanceActualTarea)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtPorcentaje, "ERR-VAL-004", "El porcentaje no puede ser inferior al avance actual de " + avanceActualTarea + "%.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtPorcentaje, "");
                }
            }
            if (sender == txtDescripcion)
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtDescripcion, "ERR-VAL-001", "Ingrese la descripción del avance.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtDescripcion, "");
                }
            }
            if (sender == cboProyecto)
            {
                if (cboProyecto.SelectedIndex < 0)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, cboProyecto, "ERR-VAL-007", "Seleccione el proyecto.");
                }
                else
                {
                    errorProviderValidacion.SetError(cboProyecto, "");
                }
            }
            if (sender == cboTarea)
            {
                if (cboTarea.SelectedIndex < 0)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, cboTarea, "ERR-VAL-007", "Seleccione la tarea.");
                }
                else
                {
                    errorProviderValidacion.SetError(cboTarea, "");
                }
            }
            if (sender == dtpFecha)
            {
                if (dtpFecha.Value.Date > DateTime.Today)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, dtpFecha, "ERR-VAL-004", "La fecha de registro no puede ser futura.");
                }
                else
                {
                    errorProviderValidacion.SetError(dtpFecha, "");
                }
            }
        }

    }
}
