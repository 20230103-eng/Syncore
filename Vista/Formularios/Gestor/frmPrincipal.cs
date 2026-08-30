using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmPrincipal : Form
    {
        private Form formularioActivo;

        public bool CerrarSesionSolicitada { get; private set; }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual != null)
            {
                lblNombreUsuario.Text = Sesion.UsuarioActual.NombreCompleto;

                if (Sesion.UsuarioActual.TipoUsuario == "Colaborador")
                {
                    lblRolUsuario.Text = "Colaborador";
                }
                else
                {
                    lblRolUsuario.Text = "Gestor";
                }
            }

            MostrarPanelGestion();
        }

        private void btnPanelGestion_Click(object sender, EventArgs e)
        {
            MostrarPanelGestion();
        }

        private void btnProductividad_Click(object sender, EventArgs e)
        {
            MostrarProductividad();
        }

        private void MostrarPanelGestion()
        {
            frmPanelGestion formulario = new frmPanelGestion();
            formulario.ProductividadSolicitada += frmPanelGestion_ProductividadSolicitada;
            formulario.NuevoProyectoSolicitado += frmPanelGestion_NuevoProyectoSolicitado;
            formulario.DetalleProyectoSolicitado += frmPanelGestion_DetalleProyectoSolicitado;
            formulario.DetalleTareaSolicitada += frmPanelGestion_DetalleTareaSolicitada;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnPanelGestion);
        }

        private void frmPanelGestion_ProductividadSolicitada(object sender, EventArgs e)
        {
            MostrarProductividad();
        }

        private void frmPanelGestion_NuevoProyectoSolicitado(object sender, EventArgs e)
        {
            MostrarNuevoProyecto();
        }


        private void frmPanelGestion_DetalleProyectoSolicitado(object sender, EventArgs e)
        {
            frmPanelGestion formulario;

            formulario = sender as frmPanelGestion;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleProyecto(formulario.IdProyectoSeleccionado);
        }

        private void frmPanelGestion_DetalleTareaSolicitada(object sender, EventArgs e)
        {
            frmPanelGestion formulario;

            formulario = sender as frmPanelGestion;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleTarea(formulario.IdTareaSeleccionada);
        }

        private void MostrarProductividad()
        {
            AbrirFormulario(new frmProductividad());
            SeleccionarBoton(btnProductividad);
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
            RestablecerBoton(btnPanelGestion, Properties.Recursos.IconoPanel);
            RestablecerBoton(btnListadoProyectos, Properties.Recursos.IconoProyectos);
            RestablecerBoton(btnNuevoProyecto, Properties.Recursos.IconoAgregar);
            RestablecerBoton(btnHitosEntregables, Properties.Recursos.IconoHitos);
            RestablecerBoton(btnCronograma, Properties.Recursos.IconoCalendario);
            RestablecerBoton(btnTableroTareas, Properties.Recursos.IconoTablero);
            RestablecerBoton(btnNuevaTarea, Properties.Recursos.IconoAgregar);
            RestablecerBoton(btnRevisionTareas, Properties.Recursos.IconoRevision);
            RestablecerBoton(btnProductividad, Properties.Recursos.IconoProductividad);
            RestablecerBoton(btnAdministracion, Properties.Recursos.IconoEquipo);
            RestablecerBoton(btnNotificacionesGestion, Properties.Recursos.IconoRevision);

            botonActivo.BackColor = Color.FromArgb(230, 239, 251);
            botonActivo.ForeColor = Color.FromArgb(43, 95, 173);
            botonActivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 235, 250);
            botonActivo.FlatAppearance.MouseDownBackColor = Color.FromArgb(214, 228, 247);

            if (botonActivo == btnPanelGestion)
            {
                botonActivo.Image = Properties.Recursos.IconoPanelSeleccionado;
            }
            else if (botonActivo == btnListadoProyectos)
            {
                botonActivo.Image = Properties.Recursos.IconoProyectosSeleccionado;
            }
            else if (botonActivo == btnNuevoProyecto || botonActivo == btnNuevaTarea)
            {
                botonActivo.Image = Properties.Recursos.IconoAgregarSeleccionado;
            }
            else if (botonActivo == btnHitosEntregables)
            {
                botonActivo.Image = Properties.Recursos.IconoHitosSeleccionado;
            }
            else if (botonActivo == btnCronograma)
            {
                botonActivo.Image = Properties.Recursos.IconoCalendarioSeleccionado;
            }
            else if (botonActivo == btnTableroTareas)
            {
                botonActivo.Image = Properties.Recursos.IconoTableroSeleccionado;
            }
            else if (botonActivo == btnRevisionTareas)
            {
                botonActivo.Image = Properties.Recursos.IconoRevisionSeleccionado;
            }
            else if (botonActivo == btnProductividad)
            {
                botonActivo.Image = Properties.Recursos.IconoProductividadSeleccionado;
            }
            else if (botonActivo == btnAdministracion)
            {
                botonActivo.Image = Properties.Recursos.IconoEquipoSeleccionado;
            }
            else if (botonActivo == btnNotificacionesGestion)
            {
                botonActivo.Image = Properties.Recursos.IconoRevisionSeleccionado;
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

        private void pnlTarjetaUsuario_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rectangulo = new Rectangle(0, 0, pnlTarjetaUsuario.Width - 1, pnlTarjetaUsuario.Height - 1);
            using (GraphicsPath ruta = CrearRectanguloRedondeado(rectangulo, 10))
            using (Pen lapiz = new Pen(Color.FromArgb(56, 126, 188)))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(lapiz, ruta);
            }
        }

        private static GraphicsPath CrearRectanguloRedondeado(Rectangle rectangulo, int radio)
        {
            GraphicsPath ruta = new GraphicsPath();
            int diametro = radio * 2;

            ruta.AddArc(rectangulo.X, rectangulo.Y, diametro, diametro, 180, 90);
            ruta.AddArc(rectangulo.Right - diametro, rectangulo.Y, diametro, diametro, 270, 90);
            ruta.AddArc(rectangulo.Right - diametro, rectangulo.Bottom - diametro, diametro, diametro, 0, 90);
            ruta.AddArc(rectangulo.X, rectangulo.Bottom - diametro, diametro, diametro, 90, 90);
            ruta.CloseFigure();

            return ruta;
        }


        private void btnNotificacionesGestion_Click(object sender, EventArgs e)
        {
            MostrarNotificacionesGestor();
        }

        private void MostrarNotificacionesGestor()
        {
            frmNotificaciones formulario;

            formulario = new frmNotificaciones();
            formulario.ConfigurarComoGestor();
            formulario.TareaSolicitada += formularioNotificacionesGestor_TareaSolicitada;
            formulario.ProyectoSolicitado += formularioNotificacionesGestor_ProyectoSolicitado;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnNotificacionesGestion);
        }

        private void formularioNotificacionesGestor_TareaSolicitada(object sender, EventArgs e)
        {
            frmNotificaciones formulario;

            formulario = sender as frmNotificaciones;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleTarea(formulario.IdTareaSeleccionada);
        }

        private void formularioNotificacionesGestor_ProyectoSolicitado(object sender, EventArgs e)
        {
            frmNotificaciones formulario;

            formulario = sender as frmNotificaciones;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleProyecto(formulario.IdProyectoSeleccionado);
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            MostrarAdministracionUsuarios();
        }

        private void MostrarAdministracionUsuarios()
        {
            frmAdministracionSistema formulario;

            formulario = new frmAdministracionSistema();
            AbrirFormulario(formulario);
            SeleccionarBoton(btnAdministracion);
        }

        private void btnListadoProyectos_Click(object sender, EventArgs e)
        {
            MostrarListadoProyectos();
        }

        private void MostrarListadoProyectos()
        {
            frmListadoProyectos formulario = new frmListadoProyectos();
            formulario.DetalleProyectoSolicitado += formularioListado_DetalleProyectoSolicitado;
            formulario.EditarProyectoSolicitado += formularioListado_EditarProyectoSolicitado;
            formulario.NuevoProyectoSolicitado += formularioListado_NuevoProyectoSolicitado;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnListadoProyectos);
        }



        private void formularioListado_NuevoProyectoSolicitado(object sender, EventArgs e)
        {
            MostrarNuevoProyecto();
        }

        private void formularioListado_EditarProyectoSolicitado(object sender, EventArgs e)
        {
            frmListadoProyectos formulario;

            formulario = sender as frmListadoProyectos;

            if (formulario == null)
            {
                return;
            }

            MostrarEditarProyecto(formulario.IdProyectoSeleccionado);
        }

        private void formularioListado_DetalleProyectoSolicitado(object sender, EventArgs e)
        {
            frmListadoProyectos formulario = sender as frmListadoProyectos;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleProyecto(formulario.IdProyectoSeleccionado);
        }

        private void MostrarDetalleProyecto(int idProyecto)
        {
            frmDetalleProyecto formulario = new frmDetalleProyecto();
            formulario.IdProyecto = idProyecto;
            formulario.EditarProyectoSolicitado += formularioDetalleProyecto_EditarProyectoSolicitado;
            formulario.VolverSolicitado += formularioDetalleProyecto_VolverSolicitado;
            formulario.ProyectoCerrado += formularioDetalleProyecto_ProyectoCerrado;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnListadoProyectos);
        }


        private void formularioDetalleProyecto_ProyectoCerrado(object sender, EventArgs e)
        {
            MostrarListadoProyectos();
        }

        private void formularioDetalleProyecto_VolverSolicitado(object sender, EventArgs e)
        {
            MostrarListadoProyectos();
        }

        private void formularioDetalleProyecto_EditarProyectoSolicitado(object sender, EventArgs e)
        {
            frmDetalleProyecto formularioDetalle;

            formularioDetalle = sender as frmDetalleProyecto;

            if (formularioDetalle == null)
            {
                return;
            }

            MostrarEditarProyecto(formularioDetalle.IdProyecto);
        }

        private void MostrarEditarProyecto(int idProyecto)
        {
            frmEditarProyecto formulario;

            formulario = new frmEditarProyecto();
            formulario.IdProyecto = idProyecto;
            formulario.ProyectoActualizado += formularioEditar_ProyectoActualizado;
            formulario.ProyectoCerrado += formularioEditar_ProyectoCerrado;
            formulario.ProyectoEliminado += formularioEditar_ProyectoEliminado;
            formulario.VolverSolicitado += formularioEditar_VolverSolicitado;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnListadoProyectos);
        }

        private void formularioEditar_ProyectoActualizado(object sender, EventArgs e)
        {
            frmEditarProyecto formulario;

            formulario = sender as frmEditarProyecto;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleProyecto(formulario.IdProyecto);
        }

        private void formularioEditar_ProyectoCerrado(object sender, EventArgs e)
        {
            MostrarListadoProyectos();
        }

        private void formularioEditar_ProyectoEliminado(object sender, EventArgs e)
        {
            MostrarListadoProyectos();
        }

        private void formularioEditar_VolverSolicitado(object sender, EventArgs e)
        {
            frmEditarProyecto formulario;

            formulario = sender as frmEditarProyecto;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleProyecto(formulario.IdProyecto);
        }

        private void btnNuevoProyecto_Click(object sender, EventArgs e)
        {
            MostrarNuevoProyecto();
        }

        private void MostrarNuevoProyecto()
        {
            frmNuevoProyecto formulario;

            formulario = new frmNuevoProyecto();
            formulario.VolverSolicitado += formularioNuevoProyecto_VolverSolicitado;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnNuevoProyecto);
        }

        private void formularioNuevoProyecto_VolverSolicitado(object sender, EventArgs e)
        {
            MostrarListadoProyectos();
        }

        private void btnCronograma_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCronograma());
            SeleccionarBoton(btnCronograma);
        }

        private void btnRevisionTareas_Click(object sender, EventArgs e)
        {
            MostrarRevisionTareas();
        }

        private void MostrarRevisionTareas()
        {
            frmRevisionTareas formulario;

            formulario = new frmRevisionTareas();
            formulario.VerDetalleSolicitado += formularioRevision_VerDetalleSolicitado;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnRevisionTareas);
        }

        private void formularioRevision_VerDetalleSolicitado(object sender, EventArgs e)
        {
            frmRevisionTareas formulario;

            formulario = sender as frmRevisionTareas;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleTareaDesdeRevision(formulario.IdTareaSeleccionada);
        }

        private void MostrarDetalleTareaDesdeRevision(int idTarea)
        {
            frmDetalleTareaGestor formulario;

            formulario = new frmDetalleTareaGestor(idTarea);
            formulario.ConfigurarOrigenRevision();
            formulario.VolverSolicitado += formularioDetalleDesdeRevision_VolverSolicitado;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnRevisionTareas);
        }

        private void formularioDetalleDesdeRevision_VolverSolicitado(object sender, EventArgs e)
        {
            MostrarRevisionTareas();
        }

        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            MostrarNuevaTarea();
        }

        private void MostrarNuevaTarea()
        {
            frmNuevaTarea formulario;

            formulario = new frmNuevaTarea();
            formulario.VolverSolicitado += formularioNuevaTarea_VolverSolicitado;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnNuevaTarea);
        }

        private void formularioNuevaTarea_VolverSolicitado(object sender, EventArgs e)
        {
            MostrarTableroTareas();
        }

        private void btnHitosEntregables_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmHitosEntregables());
            SeleccionarBoton(btnHitosEntregables);
        }

        private void btnTableroTareas_Click(object sender, EventArgs e)
        {
            MostrarTableroTareas();
        }

        private void MostrarTableroTareas()
        {
            frmTableroTareasGestor formulario = new frmTableroTareasGestor();
            formulario.DetalleTareaSolicitado += formulario_DetalleTareaSolicitado;
            formulario.NuevaTareaSolicitada += formularioTablero_NuevaTareaSolicitada;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnTableroTareas);
        }


        private void formularioTablero_NuevaTareaSolicitada(object sender, EventArgs e)
        {
            MostrarNuevaTarea();
        }

        private void formulario_DetalleTareaSolicitado(object sender, EventArgs e)
        {
            frmTableroTareasGestor formulario = sender as frmTableroTareasGestor;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleTarea(formulario.IdTareaSeleccionada);
        }

        private void MostrarDetalleTarea(int idTarea)
        {
            frmDetalleTareaGestor formulario = new frmDetalleTareaGestor(idTarea);
            formulario.VolverSolicitado += formularioDetalle_VolverSolicitado;
            formulario.EditarTareaSolicitado += formularioDetalle_EditarTareaSolicitado;
            formulario.TareaEliminada += formularioDetalle_TareaEliminada;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnTableroTareas);
        }


        private void formularioDetalle_EditarTareaSolicitado(object sender, EventArgs e)
        {
            frmDetalleTareaGestor formulario;

            formulario = sender as frmDetalleTareaGestor;

            if (formulario == null)
            {
                return;
            }

            MostrarEditarTarea(formulario.IdTarea);
        }

        private void formularioDetalle_TareaEliminada(object sender, EventArgs e)
        {
            MostrarTableroTareas();
        }

        private void MostrarEditarTarea(int idTarea)
        {
            frmNuevaTarea formulario;

            formulario = new frmNuevaTarea();
            formulario.IdTarea = idTarea;
            formulario.TareaGuardada += formularioEditarTarea_TareaGuardada;
            formulario.VolverSolicitado += formularioEditarTarea_VolverSolicitado;
            AbrirFormulario(formulario);
            SeleccionarBoton(btnTableroTareas);
        }

        private void formularioEditarTarea_TareaGuardada(object sender, EventArgs e)
        {
            frmNuevaTarea formulario;

            formulario = sender as frmNuevaTarea;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleTarea(formulario.IdTarea);
        }

        private void formularioEditarTarea_VolverSolicitado(object sender, EventArgs e)
        {
            frmNuevaTarea formulario;

            formulario = sender as frmNuevaTarea;

            if (formulario == null)
            {
                return;
            }

            MostrarDetalleTarea(formulario.IdTarea);
        }

        private void formularioDetalle_VolverSolicitado(object sender, EventArgs e)
        {
            MostrarTableroTareas();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesionSolicitada = true;
            Sesion.CerrarSesion();
            this.Close();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CerrarSesionSolicitada == false)
            {
                Application.Exit();
            }
        }
    }
}
