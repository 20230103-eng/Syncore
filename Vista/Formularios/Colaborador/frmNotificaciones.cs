using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmNotificaciones : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        private Notificacion notificacionModelo;
        private DataTable notificacionesOriginales;
        private bool cargandoFiltros;
        private bool modoGestor;

        public event EventHandler TareaSolicitada;
        public event EventHandler ProyectoSolicitado;
        public event EventHandler NotificacionesActualizadas;

        public int IdTareaSeleccionada { get; private set; }
        public int IdProyectoSeleccionado { get; private set; }
        public int CantidadSinLeer { get; private set; }

        public frmNotificaciones()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(btnMarcarTodas, "Marcar todas las notificaciones como leídas.");
            toolTipAyuda.SetToolTip(cboTipo, "Seleccione tipo.");
            toolTipAyuda.SetToolTip(cboPrioridad, "Seleccione prioridad.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            lblFechaSuperior.Text = DateTime.Today.ToString("dd/MM/yyyy");
            notificacionModelo = new Notificacion();
            notificacionesOriginales = new DataTable();
            cargandoFiltros = false;
            modoGestor = false;
            IdTareaSeleccionada = 0;
            IdProyectoSeleccionado = 0;
        }

        public void ConfigurarComoGestor()
        {
            modoGestor = true;
            lblBreadcrumbBase.Text = "Gestión >";
            lblBreadcrumbActual.Text = "Notificaciones";
            lblTitulo.Text = "Notificaciones de gestión";
        }

        private void frmNotificaciones_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("No hay una sesión activa.");
                return;
            }

            if (modoGestor == true && Sesion.UsuarioActual.TipoUsuario != "Gestor")
            {
                MessageBox.Show("Esta vista corresponde al gestor.");
                return;
            }

            CargarNotificaciones();
        }

        private void CargarNotificaciones()
        {
            int idUsuario;

            idUsuario = Sesion.UsuarioActual.IdUsuario;
            notificacionModelo.EliminarLeidasAntiguas(idUsuario, 90);
            notificacionesOriginales = notificacionModelo.ObtenerNotificacionesUsuario(idUsuario);
            CargarFiltros();
            AplicarFiltros();
            ActualizarCantidadSinLeer();
        }

        private void CargarFiltros()
        {
            cargandoFiltros = true;
            cboTipo.Items.Clear();
            cboPrioridad.Items.Clear();
            cboTipo.Items.Add("Todos los tipos");
            cboPrioridad.Items.Add("Todas las prioridades");

            foreach (DataRow fila in notificacionesOriginales.Rows)
            {
                string tipo;
                string prioridad;
                bool existeTipo;
                bool existePrioridad;

                tipo = fila["Tipo"].ToString();
                prioridad = fila["Prioridad"].ToString();
                existeTipo = false;
                existePrioridad = false;

                foreach (object item in cboTipo.Items)
                {
                    if (item.ToString() == tipo)
                    {
                        existeTipo = true;
                        break;
                    }
                }

                foreach (object item in cboPrioridad.Items)
                {
                    if (item.ToString() == prioridad)
                    {
                        existePrioridad = true;
                        break;
                    }
                }

                if (existeTipo == false)
                {
                    cboTipo.Items.Add(tipo);
                }

                if (existePrioridad == false)
                {
                    cboPrioridad.Items.Add(prioridad);
                }
            }

            cboTipo.SelectedIndex = 0;
            cboPrioridad.SelectedIndex = 0;
            cargandoFiltros = false;
        }

        private void AplicarFiltros()
        {
            string tipo;
            string prioridad;
            DataTable resultado;

            tipo = "Todos los tipos";
            prioridad = "Todas las prioridades";
            resultado = notificacionesOriginales.Clone();

            if (cboTipo.SelectedItem != null)
            {
                tipo = cboTipo.SelectedItem.ToString();
            }

            if (cboPrioridad.SelectedItem != null)
            {
                prioridad = cboPrioridad.SelectedItem.ToString();
            }

            foreach (DataRow fila in notificacionesOriginales.Rows)
            {
                bool mostrar;

                mostrar = true;

                if (tipo != "Todos los tipos" && fila["Tipo"].ToString() != tipo)
                {
                    mostrar = false;
                }

                if (prioridad != "Todas las prioridades" && fila["Prioridad"].ToString() != prioridad)
                {
                    mostrar = false;
                }

                if (mostrar == true)
                {
                    resultado.ImportRow(fila);
                }
            }

            MostrarNotificaciones(resultado);
        }

        private void MostrarNotificaciones(DataTable datos)
        {
            int indice;
            int filaVisual;
            int altoNotificacion;

            altoNotificacion = 134;
            tlpNotificaciones.SuspendLayout();
            tlpNotificaciones.Controls.Clear();
            tlpNotificaciones.RowStyles.Clear();
            tlpNotificaciones.RowCount = Math.Max(1, datos.Rows.Count);
            filaVisual = 0;

            for (indice = datos.Rows.Count - 1; indice >= 0; indice = indice - 1)
            {
                DataRow fila;
                UCNotificacion control;
                int idTarea;
                int idProyecto;

                fila = datos.Rows[indice];
                control = new UCNotificacion();
                control.IdNotificacion = Convert.ToInt32(fila["IdNotificacion"]);
                control.Titulo = fila["Titulo"].ToString();
                control.Descripcion = fila["Mensaje"].ToString();
                control.Fecha = Convert.ToDateTime(fila["FechaCreacion"]).ToString("dd/MM/yyyy HH:mm");
                control.TipoNotificacion = fila["Tipo"].ToString();
                control.Leida = Convert.ToBoolean(fila["Leida"]);
                idTarea = 0;
                idProyecto = 0;

                if (fila["IdTarea"] != DBNull.Value)
                {
                    idTarea = Convert.ToInt32(fila["IdTarea"]);
                }

                if (fila["IdProyecto"] != DBNull.Value)
                {
                    idProyecto = Convert.ToInt32(fila["IdProyecto"]);
                }

                control.IdTarea = idTarea;
                control.IdProyecto = idProyecto;

                if (idTarea > 0)
                {
                    control.TextoBotonPrincipal = "Ir a tarea";
                    control.MostrarBotonPrincipal = true;
                }
                else if (idProyecto > 0)
                {
                    control.TextoBotonPrincipal = "Ir a proyecto";
                    control.MostrarBotonPrincipal = true;
                }
                else
                {
                    control.MostrarBotonPrincipal = false;
                }

                control.AccionPrincipalSolicitada += control_AccionPrincipalSolicitada;
                control.MarcarLeidaSolicitada += control_MarcarLeidaSolicitada;
                control.Dock = DockStyle.Fill;
                control.Margin = new Padding(0, 0, 0, 6);
                tlpNotificaciones.RowStyles.Add(new RowStyle(SizeType.Absolute, altoNotificacion));
                tlpNotificaciones.Controls.Add(control, 0, filaVisual);
                filaVisual = filaVisual + 1;
            }

            if (datos.Rows.Count == 0)
            {
                Label mensaje;

                mensaje = new Label();
                mensaje.Dock = DockStyle.Fill;
                mensaje.Font = new System.Drawing.Font("Segoe UI", 9F);
                mensaje.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
                mensaje.Text = "No hay notificaciones con los filtros seleccionados.";
                mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                tlpNotificaciones.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
                tlpNotificaciones.Controls.Add(mensaje, 0, 0);
                tlpNotificaciones.RowCount = 1;
                tlpPrincipal.Height = 126 + 70;
            }
            else
            {
                tlpNotificaciones.RowCount = datos.Rows.Count;
                tlpPrincipal.Height = 126 + datos.Rows.Count * altoNotificacion;
            }

            tlpNotificaciones.ResumeLayout(true);
        }

        private void ActualizarCantidadSinLeer()
        {
            int cantidad;

            cantidad = notificacionModelo.ContarNotificacionesNoLeidas(Sesion.UsuarioActual.IdUsuario);
            CantidadSinLeer = cantidad;
            lblSinLeer.Text = cantidad.ToString() + " sin leer";
            btnMarcarTodas.Enabled = cantidad > 0;

            if (NotificacionesActualizadas != null)
            {
                NotificacionesActualizadas(this, EventArgs.Empty);
            }
        }

        private void control_MarcarLeidaSolicitada(object sender, EventArgs e)
        {
            UCNotificacion control;
            Notificacion notificacion;

            control = sender as UCNotificacion;

            if (control == null)
            {
                return;
            }

            notificacion = new Notificacion();
            notificacion.IdNotificacion = control.IdNotificacion;

            if (notificacion.MarcarLeida() == true)
            {
                CargarNotificaciones();
            }
            else
            {
                MessageBox.Show("No se pudo marcar la notificación como leída.");
            }
        }

        private void control_AccionPrincipalSolicitada(object sender, EventArgs e)
        {
            UCNotificacion control;
            Notificacion notificacion;

            control = sender as UCNotificacion;

            if (control == null)
            {
                return;
            }

            if (control.Leida == false)
            {
                notificacion = new Notificacion();
                notificacion.IdNotificacion = control.IdNotificacion;
                notificacion.MarcarLeida();
            }

            if (control.IdTarea > 0)
            {
                IdTareaSeleccionada = control.IdTarea;

                if (TareaSolicitada != null)
                {
                    TareaSolicitada(this, EventArgs.Empty);
                }
            }
            else if (control.IdProyecto > 0)
            {
                IdProyectoSeleccionado = control.IdProyecto;

                if (ProyectoSolicitado != null)
                {
                    ProyectoSolicitado(this, EventArgs.Empty);
                }
            }
        }

        private void btnMarcarTodas_Click(object sender, EventArgs e)
        {
            if (notificacionModelo.MarcarTodasLeidas(Sesion.UsuarioActual.IdUsuario) == true)
            {
                CargarNotificaciones();
            }
        }

        private void filtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoFiltros == false)
            {
                AplicarFiltros();
            }
        }
    }
}
