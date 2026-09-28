using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmEditarProyecto : Form
    {
        private bool validacionEnTiempoRealHabilitada;
        private System.Windows.Forms.ToolTip toolTipAyuda;
        private System.Windows.Forms.ErrorProvider errorProviderValidacion;

        private Proyecto proyectoModelo;
        private Usuario usuarioModelo;
        private Area areaModelo;
        private TipoProyecto tipoProyectoModelo;
        private Prioridad prioridadModelo;

        public event EventHandler ProyectoActualizado;
        public event EventHandler ProyectoCerrado;
        public event EventHandler ProyectoEliminado;
        public event EventHandler VolverSolicitado;

        public int IdProyecto { get; set; }
        private string estadoActual;

        public frmEditarProyecto()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            errorProviderValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            errorProviderValidacion.ContainerControl = this;
            errorProviderValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            toolTipAyuda.SetToolTip(txtNombre, "Ingrese nombre.");
            toolTipAyuda.SetToolTip(txtCodigo, "Ingrese código.");
            toolTipAyuda.SetToolTip(cboTipo, "Seleccione tipo.");
            toolTipAyuda.SetToolTip(cboArea, "Seleccione área.");
            toolTipAyuda.SetToolTip(cboResponsable, "Seleccione responsable.");
            toolTipAyuda.SetToolTip(dtpInicio, "Seleccione fecha de inicio.");
            toolTipAyuda.SetToolTip(dtpCierre, "Seleccione fecha de cierre.");
            toolTipAyuda.SetToolTip(cboPrioridad, "Seleccione prioridad.");
            toolTipAyuda.SetToolTip(txtObjetivo, "Ingrese objetivo.");
            toolTipAyuda.SetToolTip(txtJustificacion, "Ingrese justificación.");
            toolTipAyuda.SetToolTip(txtAlcance, "Ingrese alcance.");
            toolTipAyuda.SetToolTip(txtResultado, "Ingrese resultado esperado.");
            toolTipAyuda.SetToolTip(txtObservaciones, "Ingrese observaciones.");
            toolTipAyuda.SetToolTip(btnGuardar, "Guardar la información ingresada.");
            toolTipAyuda.SetToolTip(btnCerrarProyecto, "Cerrar el proyecto.");
            toolTipAyuda.SetToolTip(btnCancelar, "Cancelar la operación actual.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);

            txtNombre.TextChanged += CamposEnTiempoReal;
            txtNombre.Leave += CamposEnTiempoReal;
            txtCodigo.TextChanged += CamposEnTiempoReal;
            txtCodigo.Leave += CamposEnTiempoReal;
            txtObjetivo.TextChanged += CamposEnTiempoReal;
            txtObjetivo.Leave += CamposEnTiempoReal;
            txtResultado.TextChanged += CamposEnTiempoReal;
            txtResultado.Leave += CamposEnTiempoReal;
            cboTipo.SelectedIndexChanged += CamposEnTiempoReal;
            cboTipo.Leave += CamposEnTiempoReal;
            cboArea.SelectedIndexChanged += CamposEnTiempoReal;
            cboArea.Leave += CamposEnTiempoReal;
            cboResponsable.SelectedIndexChanged += CamposEnTiempoReal;
            cboResponsable.Leave += CamposEnTiempoReal;
            cboPrioridad.SelectedIndexChanged += CamposEnTiempoReal;
            cboPrioridad.Leave += CamposEnTiempoReal;
            dtpCierre.ValueChanged += CamposEnTiempoReal;
            dtpInicio.ValueChanged += CamposEnTiempoReal;
            txtCodigo.Leave += Codigo_Leave;
        }

        private void frmEditarProyecto_Load(object sender, EventArgs e)
        {
            proyectoModelo = new Proyecto();
            usuarioModelo = new Usuario();
            areaModelo = new Area();
            tipoProyectoModelo = new TipoProyecto();
            prioridadModelo = new Prioridad();
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            AjustarBreadcrumb();
            CargarCombos();
            CargarProyecto();
        
            validacionEnTiempoRealHabilitada = true;
        }

        private void AjustarBreadcrumb()
        {
            lblBreadcrumbActual.Left = lblBreadcrumbBase.Right + 8;
        }

        private void CargarCombos()
        {
            DataTable tiposProyecto;
            DataTable areas;
            DataTable responsables;
            DataTable prioridades;

            tiposProyecto = tipoProyectoModelo.ObtenerTiposProyecto();
            areas = areaModelo.ObtenerAreas();
            responsables = usuarioModelo.ObtenerGestoresActivos();
            prioridades = prioridadModelo.ObtenerPrioridades();

            cboTipo.DisplayMember = "Nombre";
            cboTipo.ValueMember = "IdTipoProyecto";
            cboTipo.DataSource = tiposProyecto;
            cboArea.DisplayMember = "Nombre";
            cboArea.ValueMember = "IdArea";
            cboArea.DataSource = areas;
            cboResponsable.DisplayMember = "NombreCompleto";
            cboResponsable.ValueMember = "IdUsuario";
            cboResponsable.DataSource = responsables;
            cboPrioridad.DisplayMember = "Nombre";
            cboPrioridad.ValueMember = "IdPrioridad";
            cboPrioridad.DataSource = prioridades;
        }

        private void CargarProyecto()
        {
            DataTable datos;
            DataRow fila;
            DateTime fechaModificacion;

            if (IdProyecto <= 0)
            {
                CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Editar proyecto", "No se recibió un proyecto válido.");
                pnlFormulario.Enabled = false;
                return;
            }

            datos = proyectoModelo.ObtenerProyectoPorId(IdProyecto);

            if (datos.Rows.Count == 0)
            {
                CatalogoErrores.MostrarDetalle("ERR-NEG-004", "Syncore", "No se encontró el proyecto.");
                pnlFormulario.Enabled = false;
                return;
            }

            fila = datos.Rows[0];
            estadoActual = fila["Estado"].ToString();
            txtNombre.Text = fila["Nombre"].ToString();
            txtCodigo.Text = fila["Codigo"].ToString();
            cboTipo.SelectedValue = Convert.ToInt32(fila["IdTipoProyecto"]);
            cboArea.SelectedValue = Convert.ToInt32(fila["IdArea"]);
            cboResponsable.SelectedValue = Convert.ToInt32(fila["IdResponsable"]);
            cboPrioridad.SelectedValue = Convert.ToInt32(fila["IdPrioridad"]);
            dtpInicio.Value = Convert.ToDateTime(fila["FechaInicio"]);
            dtpCierre.Value = Convert.ToDateTime(fila["FechaCierreEstimada"]);
            txtObjetivo.Text = fila["Objetivo"].ToString();
            txtJustificacion.Text = ObtenerTexto(fila["Justificacion"]);
            txtAlcance.Text = ObtenerTexto(fila["Alcance"]);
            txtResultado.Text = fila["ResultadoEsperado"].ToString();
            txtObservaciones.Text = ObtenerTexto(fila["Observaciones"]);

            fechaModificacion = Convert.ToDateTime(fila["FechaCreacion"]);

            if (fila["UltimaModificacion"] != DBNull.Value)
            {
                fechaModificacion = Convert.ToDateTime(fila["UltimaModificacion"]);
            }

            lblModificacion.Text = "Última modificación: " + fechaModificacion.ToString("dd/MM/yyyy");
            PrepararBotonCerrar();
        }


        private void PrepararBotonCerrar()
        {
            btnCerrarProyecto.Enabled = true;
            btnCerrarProyecto.Text = "Cerrar proyecto";

            if (estadoActual == "Cerrado")
            {
                btnCerrarProyecto.Text = "Eliminar proyecto";
            }
        }

        private string ObtenerTexto(object valor)
        {
            if (valor == DBNull.Value)
            {
                return "";
            }

            return valor.ToString();
        }

        private bool ValidarDatos()
        {
            bool codigoExiste;
            errorProviderValidacion.Clear();

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtNombre, "ERR-VAL-001", "Ingrese el nombre del proyecto.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-001", "Syncore", "Ingrese el nombre del proyecto.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCodigo.Text.Trim()) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtCodigo, "ERR-VAL-001", "Ingrese el código del proyecto.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-001", "Syncore", "Ingrese el código del proyecto.");
                txtCodigo.Focus();
                return false;
            }

            foreach (char caracter in txtCodigo.Text)
            {
                if (char.IsLetterOrDigit(caracter) == false && caracter != '-')
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtCodigo, "ERR-VAL-002", "El código solo admite letras, números y guiones.");
                    CatalogoErrores.MostrarDetalle("ERR-VAL-002", "Syncore", "El código solo admite letras, números y guiones.");
                    txtCodigo.Focus();
                    return false;
                }
            }

            codigoExiste = proyectoModelo.ExisteCodigoProyectoEnOtroProyecto(txtCodigo.Text.Trim(), IdProyecto);

            if (codigoExiste == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtCodigo, "ERR-VAL-005", "El código ya pertenece a otro proyecto.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-005", "Syncore", "El código ya pertenece a otro proyecto.");
                txtCodigo.Focus();
                return false;
            }

            if (cboTipo.SelectedValue == null)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, cboTipo, "ERR-VAL-007", "Seleccione el tipo de proyecto.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Syncore", "Seleccione el tipo de proyecto.");
                cboTipo.Focus();
                return false;
            }

            if (cboArea.SelectedValue == null)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, cboArea, "ERR-VAL-007", "Seleccione el área solicitante.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Syncore", "Seleccione el área solicitante.");
                cboArea.Focus();
                return false;
            }

            if (cboResponsable.SelectedValue == null)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, cboResponsable, "ERR-VAL-007", "Seleccione el responsable.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Syncore", "Seleccione el responsable principal.");
                cboResponsable.Focus();
                return false;
            }

            if (cboPrioridad.SelectedIndex < 0)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, cboPrioridad, "ERR-VAL-007", "Seleccione la prioridad.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Syncore", "Seleccione la prioridad.");
                cboPrioridad.Focus();
                return false;
            }

            if (dtpCierre.Value.Date < dtpInicio.Value.Date)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, dtpCierre, "ERR-VAL-004", "Revise la fecha de cierre.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-004", "Syncore", "La fecha de cierre no puede ser anterior a la fecha de inicio.");
                dtpCierre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtObjetivo.Text.Trim()) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtObjetivo, "ERR-VAL-001", "Ingrese el objetivo.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-001", "Syncore", "Ingrese el objetivo del proyecto.");
                txtObjetivo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtResultado.Text.Trim()) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtResultado, "ERR-VAL-001", "Ingrese el resultado esperado.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-001", "Syncore", "Ingrese el resultado esperado.");
                txtResultado.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool datosCorrectos;
            bool actualizado;
            Proyecto proyecto;

            datosCorrectos = ValidarDatos();

            if (datosCorrectos == false)
            {
                return;
            }

            proyecto = new Proyecto();
            proyecto.IdProyecto = IdProyecto;
            proyecto.Codigo = txtCodigo.Text.Trim();
            proyecto.Nombre = txtNombre.Text.Trim();
            proyecto.Objetivo = txtObjetivo.Text.Trim();
            proyecto.Justificacion = txtJustificacion.Text.Trim();
            proyecto.Alcance = txtAlcance.Text.Trim();
            proyecto.ResultadoEsperado = txtResultado.Text.Trim();
            proyecto.Observaciones = txtObservaciones.Text.Trim();
            proyecto.IdArea = Convert.ToInt32(cboArea.SelectedValue);
            proyecto.IdTipoProyecto = Convert.ToInt32(cboTipo.SelectedValue);
            proyecto.IdResponsable = Convert.ToInt32(cboResponsable.SelectedValue);
            proyecto.IdPrioridad = Convert.ToInt32(cboPrioridad.SelectedValue);
            proyecto.FechaInicio = dtpInicio.Value.Date;
            proyecto.FechaCierreEstimada = dtpCierre.Value.Date;

            if (Sesion.UsuarioActual == null)
            {
                CatalogoErrores.MostrarDetalle("ERR-NEG-001", "Syncore", "No hay una sesión activa.");
                return;
            }

            actualizado = proyecto.ActualizarProyecto(Sesion.UsuarioActual.IdUsuario);

            if (actualizado == true)
            {
                MessageBox.Show("Los cambios fueron guardados correctamente.");

                if (ProyectoActualizado != null)
                {
                    ProyectoActualizado(this, EventArgs.Empty);
                }
            }
        }

        private void btnCerrarProyecto_Click(object sender, EventArgs e)
        {
            if (estadoActual == "Cerrado")
            {
                EliminarProyecto();
                return;
            }

            CerrarProyecto();
        }

        private void CerrarProyecto()
        {
            bool cerrado;
            DialogResult respuesta;
            Proyecto proyecto;

            respuesta = MessageBox.Show("¿Desea cerrar este proyecto? La información no se eliminará. El proyecto quedará oculto de las vistas activas y podrá consultarse con el filtro Cerrado.", "Cerrar proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            proyecto = new Proyecto();
            proyecto.IdProyecto = IdProyecto;
            cerrado = proyecto.CerrarProyecto();

            if (cerrado == true)
            {
                MessageBox.Show("El proyecto fue cerrado y archivado correctamente.");

                if (ProyectoCerrado != null)
                {
                    ProyectoCerrado(this, EventArgs.Empty);
                }
            }
        }

        private void EliminarProyecto()
        {
            bool eliminado;
            DialogResult respuesta;
            Proyecto proyecto;

            respuesta = MessageBox.Show("¿Desea eliminar definitivamente este proyecto cerrado? Se eliminarán también sus tareas, avances, evidencias, revisiones, comentarios, integrantes, hitos y notificaciones. Esta acción no se puede deshacer.", "Eliminar proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            proyecto = new Proyecto();
            proyecto.IdProyecto = IdProyecto;
            eliminado = proyecto.EliminarProyectoCerrado();

            if (eliminado == true)
            {
                MessageBox.Show("El proyecto cerrado fue eliminado definitivamente.");

                if (ProyectoEliminado != null)
                {
                    ProyectoEliminado(this, EventArgs.Empty);
                }
            }
            else
            {
                CatalogoErrores.MostrarDetalle("ERR-NEG-003", "Syncore", "El proyecto no pudo eliminarse. Verifique que esté cerrado.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (VolverSolicitado != null)
            {
                VolverSolicitado(this, EventArgs.Empty);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool permitido;

            permitido = false;

            if (char.IsControl(e.KeyChar) == true)
            {
                permitido = true;
            }
            else if (char.IsLetterOrDigit(e.KeyChar) == true)
            {
                permitido = true;
            }
            else if (e.KeyChar == '-')
            {
                permitido = true;
            }

            if (permitido == false)
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

            if (sender == txtNombre)
            {
                if (string.IsNullOrEmpty(txtNombre.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtNombre, "ERR-VAL-001", "Ingrese el nombre del proyecto.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtNombre, "");
                }
            }
            if (sender == txtCodigo)
            {
                bool formatoCorrecto;
                formatoCorrecto = true;
                foreach (char caracter in txtCodigo.Text)
                {
                    if (char.IsLetterOrDigit(caracter) == false && caracter != '-')
                    {
                        formatoCorrecto = false;
                    }
                }
                if (string.IsNullOrEmpty(txtCodigo.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtCodigo, "ERR-VAL-001", "Ingrese el código del proyecto.");
                }
                else if (formatoCorrecto == false)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtCodigo, "ERR-VAL-002", "El código solo admite letras, números y guiones.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtCodigo, "");
                }
            }
            if (sender == txtObjetivo)
            {
                if (string.IsNullOrEmpty(txtObjetivo.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtObjetivo, "ERR-VAL-001", "Ingrese el objetivo del proyecto.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtObjetivo, "");
                }
            }
            if (sender == txtResultado)
            {
                if (string.IsNullOrEmpty(txtResultado.Text.Trim()) == true)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, txtResultado, "ERR-VAL-001", "Ingrese el resultado esperado.");
                }
                else
                {
                    errorProviderValidacion.SetError(txtResultado, "");
                }
            }
            if (sender == cboTipo)
            {
                if (cboTipo.SelectedIndex < 0)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, cboTipo, "ERR-VAL-007", "Seleccione el tipo de proyecto.");
                }
                else
                {
                    errorProviderValidacion.SetError(cboTipo, "");
                }
            }
            if (sender == cboArea)
            {
                if (cboArea.SelectedIndex < 0)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, cboArea, "ERR-VAL-007", "Seleccione el área solicitante.");
                }
                else
                {
                    errorProviderValidacion.SetError(cboArea, "");
                }
            }
            if (sender == cboResponsable)
            {
                if (cboResponsable.SelectedIndex < 0)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, cboResponsable, "ERR-VAL-007", "Seleccione el responsable.");
                }
                else
                {
                    errorProviderValidacion.SetError(cboResponsable, "");
                }
            }
            if (sender == cboPrioridad)
            {
                if (cboPrioridad.SelectedIndex < 0)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, cboPrioridad, "ERR-VAL-007", "Seleccione la prioridad.");
                }
                else
                {
                    errorProviderValidacion.SetError(cboPrioridad, "");
                }
            }
            if (sender == dtpCierre || sender == dtpInicio)
            {
                if (dtpCierre.Value.Date < dtpInicio.Value.Date)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, dtpCierre, "ERR-VAL-004", "La fecha de cierre no puede ser anterior al inicio.");
                }
                else
                {
                    errorProviderValidacion.SetError(dtpCierre, "");
                }
            }
        }

        private void Codigo_Leave(object sender, EventArgs e)
        {
            if (validacionEnTiempoRealHabilitada == false || proyectoModelo == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtCodigo.Text.Trim()) == true)
            {
                return;
            }
            if (errorProviderValidacion.GetError(txtCodigo) != "")
            {
                return;
            }
            if (proyectoModelo.ExisteCodigoProyectoEnOtroProyecto(txtCodigo.Text.Trim(), IdProyecto) == true)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, txtCodigo, "ERR-VAL-005", "El código del proyecto ya existe.");
            }
        }

    }
}
