using System;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Infraestructura;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmPrincipalColaborador : Form
    {
        private Form formularioActivo;

        public bool CerrarSesionSolicitada { get; private set; }

        public frmPrincipalColaborador()
        {
            InitializeComponent();
        }

        private void frmPrincipalColaborador_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual != null)
            {
                lblNombreUsuario.Text = Sesion.UsuarioActual.NombreCompleto;
            }

            lblRolUsuario.Text = "Colaborador";
            ActualizarBadgeNotificaciones();
            MostrarPanelPersonal();
        }

        private void btnPanelPersonal_Click(object sender, EventArgs e)
        {
            MostrarPanelPersonal();
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            MostrarNotificaciones();
        }

        private void btnProyectosAsignados_Click(object sender, EventArgs e)
        {
            MostrarProyectosAsignados();
        }

        private void btnTableroTareas_Click(object sender, EventArgs e)
        {
            MostrarTableroTareas();
        }

        private void btnRegistrarAvance_Click(object sender, EventArgs e)
        {
            MostrarRegistrarAvance();
        }

        private void btnMiProductividad_Click(object sender, EventArgs e)
        {
            MostrarMiProductividad();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            MostrarCalendario();
        }

        private void MostrarPanelPersonal()
        {
            frmPanelPersonal formulario = new frmPanelPersonal();
            formulario.RegistrarAvanceSolicitado += formulario_RegistrarAvanceSolicitado;
            formulario.NotificacionesSolicitadas += formulario_NotificacionesSolicitadas;
            formulario.ProyectosSolicitados += formulario_ProyectosSolicitados;
            formulario.TareasSolicitadas += formulario_TareasSolicitadas;
            formulario.DetalleTareaSolicitado += formularioPanel_DetalleTareaSolicitado;
            formulario.TareasProyectoSolicitadas += formularioPanel_TareasProyectoSolicitadas;
            formulario.DetalleProyectoSolicitado += formularioPanel_DetalleProyectoSolicitado;

            AbrirFormulario(formulario);
            SeleccionarBoton(btnPanelPersonal);
        }



        private void formularioPanel_TareasProyectoSolicitadas(object sender, EventArgs e)
        {
            frmPanelPersonal formulario;

            formulario = sender as frmPanelPersonal;

            if (formulario == null)
            {
                return;
            }

            MostrarTableroTareasProyecto(formulario.IdProyectoSeleccionado);
        }

        private void formularioPanel_DetalleProyectoSolicitado(object sender, EventArgs e)
        {
            frmPanelPersonal formulario;

            formulario = sender as frmPanelPersonal;

            if (formulario == null)
            {
                return;
            }

            MostrarProyectosAsignadosProyecto(formulario.IdProyectoSeleccionado);
        }

        private void formularioPanel_DetalleTareaSolicitado(object sender, EventArgs e)
        {
            frmPanelPersonal formulario;

            formulario = sender as frmPanelPersonal;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleTarea(formulario.IdTareaSeleccionada);
        }

        private void formulario_RegistrarAvanceSolicitado(object sender, EventArgs e)
        {
            MostrarRegistrarAvance();
        }

        private void formulario_NotificacionesSolicitadas(object sender, EventArgs e)
        {
            MostrarNotificaciones();
        }

        private void formulario_ProyectosSolicitados(object sender, EventArgs e)
        {
            MostrarProyectosAsignados();
        }

        private void formulario_TareasSolicitadas(object sender, EventArgs e)
        {
            MostrarTableroTareas();
        }

        private void MostrarNotificaciones()
        {
            frmNotificaciones formulario;

            formulario = new frmNotificaciones();
            formulario.TareaSolicitada += formularioNotificaciones_TareaSolicitada;
            formulario.ProyectoSolicitado += formularioNotificaciones_ProyectoSolicitado;
            formulario.NotificacionesActualizadas += formularioNotificaciones_NotificacionesActualizadas;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnNotificaciones);
        }

        private void formularioNotificaciones_NotificacionesActualizadas(object sender, EventArgs e)
        {
            frmNotificaciones formulario;

            formulario = sender as frmNotificaciones;

            if (formulario == null)
            {
                return;
            }

            MostrarBadgeNotificaciones(formulario.CantidadSinLeer);
        }

        private void ActualizarBadgeNotificaciones()
        {
            Notificacion notificacion;
            int cantidad;

            if (Sesion.UsuarioActual == null)
            {
                return;
            }

            notificacion = new Notificacion();
            cantidad = notificacion.ContarNotificacionesNoLeidas(Sesion.UsuarioActual.IdUsuario);
            MostrarBadgeNotificaciones(cantidad);
        }

        private void MostrarBadgeNotificaciones(int cantidad)
        {
            lblBadgeNotificaciones.Text = cantidad.ToString();
            lblBadgeNotificaciones.Visible = cantidad > 0;
        }

        private void formularioNotificaciones_TareaSolicitada(object sender, EventArgs e)
        {
            frmNotificaciones formulario;

            formulario = sender as frmNotificaciones;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleTarea(formulario.IdTareaSeleccionada);
        }

        private void formularioNotificaciones_ProyectoSolicitado(object sender, EventArgs e)
        {
            frmNotificaciones formulario;

            formulario = sender as frmNotificaciones;

            if (formulario == null)
            {
                return;
            }

            MostrarProyectosAsignadosProyecto(formulario.IdProyectoSeleccionado);
        }

        private void MostrarProyectosAsignados()
        {
            MostrarProyectosAsignadosProyecto(0);
        }

        private void MostrarProyectosAsignadosProyecto(int idProyecto)
        {
            frmMisProyectosAsignados formulario;

            formulario = new frmMisProyectosAsignados();
            formulario.IdProyectoInicial = idProyecto;
            formulario.MisTareasSolicitadas += formularioProyectos_MisTareasSolicitadas;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnProyectosAsignados);
        }

        private void formularioProyectos_MisTareasSolicitadas(object sender, EventArgs e)
        {
            frmMisProyectosAsignados formulario;

            formulario = sender as frmMisProyectosAsignados;

            if (formulario == null)
            {
                return;
            }

            MostrarTableroTareasProyecto(formulario.IdProyectoSeleccionado);
        }

        private void MostrarTableroTareas()
        {
            MostrarTableroTareasProyecto(0);
        }

        private void MostrarTableroTareasProyecto(int idProyecto)
        {
            frmTableroTareasColaborador formulario;

            formulario = new frmTableroTareasColaborador();
            formulario.IdProyectoInicial = idProyecto;
            formulario.DetalleTareaSolicitado += formulario_DetalleTareaSolicitado;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnTableroTareas);
        }

        private void formulario_DetalleTareaSolicitado(object sender, EventArgs e)
        {
            frmTableroTareasColaborador formulario = sender as frmTableroTareasColaborador;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleTarea(formulario.IdTareaSeleccionada);
        }

        private void MostrarDetalleTarea(int idTarea)
        {
            frmDetalleTareaColaborador formulario = new frmDetalleTareaColaborador(idTarea);
            formulario.VolverSolicitado += formularioDetalle_VolverSolicitado;
            formulario.RegistrarAvanceSolicitado += formularioDetalle_RegistrarAvanceSolicitado;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnTableroTareas);
        }

        private void formularioDetalle_VolverSolicitado(object sender, EventArgs e)
        {
            MostrarTableroTareas();
        }

        private void formularioDetalle_RegistrarAvanceSolicitado(object sender, EventArgs e)
        {
            frmDetalleTareaColaborador formulario;

            formulario = sender as frmDetalleTareaColaborador;

            if (formulario == null)
            {
                return;
            }

            MostrarRegistrarAvanceDesdeDetalle(formulario.IdTarea);
        }

        private void MostrarRegistrarAvanceDesdeDetalle(int idTarea)
        {
            frmRegistrarAvance formulario;

            formulario = new frmRegistrarAvance();
            formulario.IdTareaInicial = idTarea;
            formulario.VolverSolicitado += formularioRegistrarAvance_VolverSolicitado;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnRegistrarAvance);
        }

        private void formularioRegistrarAvance_VolverSolicitado(object sender, EventArgs e)
        {
            frmRegistrarAvance formulario;

            formulario = sender as frmRegistrarAvance;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleTarea(formulario.IdTareaInicial);
        }

        private void MostrarRegistrarAvance()
        {
            AbrirFormulario(new frmRegistrarAvance());
            SeleccionarBoton(btnRegistrarAvance);
        }

        private void MostrarMiProductividad()
        {
            AbrirFormulario(new frmMiProductividad());
            SeleccionarBoton(btnMiProductividad);
        }

        private void MostrarCalendario()
        {
            frmCalendario formulario;

            formulario = new frmCalendario();
            formulario.TareaSolicitada += formularioCalendario_TareaSolicitada;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnCalendario);
        }

        private void formularioCalendario_TareaSolicitada(object sender, EventArgs e)
        {
            frmCalendario formulario;

            formulario = sender as frmCalendario;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleTarea(formulario.IdTareaSeleccionada);
        }

        private void AbrirFormulario(Form formulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo.Dispose();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlContenido.Controls.Clear();
            pnlContenido.Controls.Add(formulario);
            formulario.Show();
            ActualizarFechaFormulario(formulario);
        }

        private void ActualizarFechaFormulario(Form formulario)
        {
            string fecha = DateTime.Today.ToString("dd/MM/yyyy");
            Control[] controlesFecha = formulario.Controls.Find("lblFecha", true);
            Control[] controlesFechaSuperior = formulario.Controls.Find("lblFechaSuperior", true);

            foreach (Control control in controlesFecha)
            {
                control.Text = fecha;
                AjustarPosicionFecha(control);
            }

            foreach (Control control in controlesFechaSuperior)
            {
                control.Text = fecha;
                AjustarPosicionFecha(control);
            }
        }

        private void AjustarPosicionFecha(Control control)
        {
            if (control.Parent == null)
            {
                return;
            }

            control.Left = control.Parent.ClientSize.Width - control.Width - 20;
            control.Top = (control.Parent.ClientSize.Height - control.Height) / 2;
        }

        private void SeleccionarBoton(Button botonActivo)
        {
            RestablecerBoton(btnPanelPersonal, Properties.Recursos.IconoPanel);
            RestablecerBoton(btnNotificaciones, Properties.Recursos.IconoRevision);
            RestablecerBoton(btnProyectosAsignados, Properties.Recursos.IconoProyectos);
            RestablecerBoton(btnTableroTareas, Properties.Recursos.IconoTablero);
            RestablecerBoton(btnRegistrarAvance, Properties.Recursos.IconoAgregar);
            RestablecerBoton(btnMiProductividad, Properties.Recursos.IconoProductividad);
            RestablecerBoton(btnCalendario, Properties.Recursos.IconoCalendario);

            botonActivo.BackColor = Color.FromArgb(230, 239, 251);
            botonActivo.ForeColor = Color.FromArgb(43, 95, 173);
            botonActivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 235, 250);
            botonActivo.FlatAppearance.MouseDownBackColor = Color.FromArgb(214, 228, 247);

            if (botonActivo == btnPanelPersonal)
            {
                botonActivo.Image = Properties.Recursos.IconoPanelSeleccionado;
            }
            else if (botonActivo == btnNotificaciones)
            {
                botonActivo.Image = Properties.Recursos.IconoRevisionSeleccionado;
            }
            else if (botonActivo == btnProyectosAsignados)
            {
                botonActivo.Image = Properties.Recursos.IconoProyectosSeleccionado;
            }
            else if (botonActivo == btnTableroTareas)
            {
                botonActivo.Image = Properties.Recursos.IconoTableroSeleccionado;
            }
            else if (botonActivo == btnRegistrarAvance)
            {
                botonActivo.Image = Properties.Recursos.IconoAgregarSeleccionado;
            }
            else if (botonActivo == btnMiProductividad)
            {
                botonActivo.Image = Properties.Recursos.IconoProductividadSeleccionado;
            }
            else if (botonActivo == btnCalendario)
            {
                botonActivo.Image = Properties.Recursos.IconoCalendarioSeleccionado;
            }
        }

        private static void RestablecerBoton(Button boton, Image imagen)
        {
            boton.BackColor = Color.FromArgb(0, 47, 99);
            boton.ForeColor = Color.FromArgb(238, 245, 255);
            boton.Image = imagen;
            boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(8, 57, 112);
            boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 57, 112);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesionSolicitada = true;
            Sesion.CerrarSesion();
            this.Close();
        }

        private void frmPrincipalColaborador_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CerrarSesionSolicitada == false)
            {
                Application.Exit();
            }
        }
    }
}
