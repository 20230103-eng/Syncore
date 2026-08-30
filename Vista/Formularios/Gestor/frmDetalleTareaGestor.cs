using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo.Modelo.Infraestructura;

using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmDetalleTareaGestor : Form
    {
        private int idTarea;
        private Tarea tareaModelo;
        private Avance avanceModelo;
        private Evidencia evidenciaModelo;
        private ComentarioTarea comentarioModelo;
        private UCComentarioTarea comentarioActual;
        private FlowLayoutPanel flpAcciones;
        private Button btnEditarTarea;
        private Button btnEliminarTarea;

        public event EventHandler VolverSolicitado;
        public event EventHandler EditarTareaSolicitado;
        public event EventHandler TareaEliminada;

        public int IdTarea
        {
            get
            {
                return idTarea;
            }
        }

        public frmDetalleTareaGestor()
            : this(0)
        {
        }

        public frmDetalleTareaGestor(int idTarea)
        {
            InitializeComponent();
            lblFecha.Text = System.DateTime.Today.ToString("dd/MM/yyyy");
            this.idTarea = idTarea;
            tareaModelo = new Tarea();
            avanceModelo = new Avance();
            evidenciaModelo = new Evidencia();
            comentarioModelo = new ComentarioTarea();
            btnVolver.Click += btnVolver_Click;
            btnEnviarComentario.Click += btnEnviarComentario_Click;
            ConfigurarAcciones();

            if (idTarea > 0)
            {
                CargarDetalle();
            }
        }


        private void ConfigurarAcciones()
        {
            flpAcciones = new FlowLayoutPanel();
            btnEditarTarea = new Button();
            btnEliminarTarea = new Button();

            pnlCabecera.Controls.Remove(btnVolver);

            flpAcciones.Dock = DockStyle.Right;
            flpAcciones.Width = 510;
            flpAcciones.FlowDirection = FlowDirection.RightToLeft;
            flpAcciones.WrapContents = false;
            flpAcciones.Padding = new Padding(0, 8, 0, 0);

            btnVolver.Size = new Size(170, 38);
            btnVolver.Margin = new Padding(8, 0, 0, 0);

            btnEditarTarea.Text = "Editar tarea";
            btnEditarTarea.Size = new Size(145, 38);
            btnEditarTarea.BackColor = Color.White;
            btnEditarTarea.ForeColor = Color.FromArgb(0, 105, 240);
            btnEditarTarea.FlatStyle = FlatStyle.Flat;
            btnEditarTarea.FlatAppearance.BorderColor = Color.FromArgb(0, 105, 240);
            btnEditarTarea.Margin = new Padding(8, 0, 0, 0);
            btnEditarTarea.Click += btnEditarTarea_Click;

            btnEliminarTarea.Text = "Eliminar";
            btnEliminarTarea.Size = new Size(120, 38);
            btnEliminarTarea.BackColor = Color.White;
            btnEliminarTarea.ForeColor = Color.FromArgb(200, 45, 55);
            btnEliminarTarea.FlatStyle = FlatStyle.Flat;
            btnEliminarTarea.FlatAppearance.BorderColor = Color.FromArgb(200, 45, 55);
            btnEliminarTarea.Margin = new Padding(8, 0, 0, 0);
            btnEliminarTarea.Click += btnEliminarTarea_Click;

            flpAcciones.Controls.Add(btnVolver);
            flpAcciones.Controls.Add(btnEditarTarea);
            flpAcciones.Controls.Add(btnEliminarTarea);
            pnlCabecera.Controls.Add(flpAcciones);
            flpAcciones.BringToFront();
        }

        private void CargarDetalle()
        {
            DataTable datos = tareaModelo.ObtenerDetalleTarea(idTarea);

            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró la tarea.", "Detalle de tarea", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataRow fila = datos.Rows[0];
            string nombreTarea = fila["Tarea"].ToString();
            string proyecto = fila["Proyecto"].ToString();
            string responsable = fila["Responsable"].ToString();
            string hito = "Sin hito relacionado";

            if (fila["Hito"] != DBNull.Value)
            {
                hito = fila["Hito"].ToString();
            }

            lblTitulo.Text = nombreTarea;
            lblSubtitulo.Text = "Proyecto: " + proyecto + "  |  Responsable: " + responsable;
            ucInformacion.Proyecto = proyecto;
            ucInformacion.Responsable = responsable;
            ucInformacion.FechaInicio = Convert.ToDateTime(fila["FechaInicio"]).ToString("dd/MM/yyyy");
            ucInformacion.FechaLimite = Convert.ToDateTime(fila["FechaLimite"]).ToString("dd/MM/yyyy");
            ucInformacion.Prioridad = fila["Prioridad"].ToString();
            ucInformacion.HitoRelacionado = hito;
            ucInformacion.Descripcion = fila["Descripcion"].ToString();
            ucInformacion.Observaciones = ObtenerTexto(fila["Observaciones"]);

            int avance = Convert.ToInt32(Convert.ToDecimal(fila["AvanceActual"]));
            DateTime fechaLimite = Convert.ToDateTime(fila["FechaLimite"]);
            int evidencias = evidenciaModelo.ContarEvidenciasTarea(idTarea);

            ucEstado.Estado = fila["Estado"].ToString();
            ucEstado.Avance = avance;
            ucEstado.Vencimiento = ObtenerVencimiento(fechaLimite, fila["Estado"].ToString());
            ucEstado.Prioridad = fila["Prioridad"].ToString();
            ucEstado.Evidencias = evidencias + " archivo(s)";
            ucEstado.TextoBoton = "";
            ConfigurarAccionesEstado(fila["Estado"].ToString(), avance, Convert.ToInt32(fila["IdResponsableProyecto"]));

            CargarHistorial();
            CargarEvidencias();
            CargarComentario();
        }


        private void ConfigurarAccionesEstado(string estado, int avance, int idResponsableProyecto)
        {
            btnEditarTarea.Enabled = true;
            btnEliminarTarea.Enabled = true;

            if (Sesion.UsuarioActual == null || Sesion.UsuarioActual.IdUsuario != idResponsableProyecto)
            {
                btnEditarTarea.Enabled = false;
                btnEliminarTarea.Enabled = false;
                return;
            }

            if (estado == "En revisión" || estado == "Completada")
            {
                btnEditarTarea.Enabled = false;
            }

            if (avance > 0)
            {
                btnEliminarTarea.Enabled = false;
            }
        }

        private void btnEditarTarea_Click(object sender, EventArgs e)
        {
            if (EditarTareaSolicitado != null)
            {
                EditarTareaSolicitado(this, EventArgs.Empty);
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            Tarea tarea;
            bool eliminada;

            respuesta = MessageBox.Show("¿Desea eliminar esta tarea? Esta acción solo se permite cuando la tarea todavía no tiene avances ni historial asociado.", "Eliminar tarea", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            tarea = new Tarea();
            tarea.IdTarea = idTarea;

            if (Sesion.UsuarioActual != null)
            {
                tarea.IdCreador = Sesion.UsuarioActual.IdUsuario;
            }

            eliminada = tarea.EliminarTarea();

            if (eliminada == true)
            {
                MessageBox.Show("La tarea fue eliminada correctamente.");

                if (TareaEliminada != null)
                {
                    TareaEliminada(this, EventArgs.Empty);
                }
            }
        }

        private string ObtenerTexto(object valor)
        {
            string texto = "Sin observaciones";

            if (valor != DBNull.Value)
            {
                if (string.IsNullOrEmpty(valor.ToString().Trim()) == false)
                {
                    texto = valor.ToString();
                }
            }

            return texto;
        }

        private string ObtenerVencimiento(DateTime fechaLimite, string estado)
        {
            if (estado == "Completada")
            {
                return "Completada";
            }

            if (fechaLimite.Date < DateTime.Today)
            {
                return "Vencida";
            }

            if (fechaLimite.Date == DateTime.Today)
            {
                return "Hoy";
            }

            return fechaLimite.ToString("dd/MM/yyyy");
        }

        private void CargarHistorial()
        {
            pnlFilasHistorial.Controls.Clear();
            DataTable historial = avanceModelo.ObtenerHistorialTarea(idTarea);

            if (historial.Rows.Count == 0)
            {
                AgregarMensaje(pnlFilasHistorial, "Todavía no hay avances registrados.");
                return;
            }

            int inicio = historial.Rows.Count - 3;

            if (inicio < 0)
            {
                inicio = 0;
            }

            int contador = 0;

            foreach (DataRow fila in historial.Rows)
            {
                if (contador >= inicio)
                {
                    int idAvance = Convert.ToInt32(fila["IdAvance"]);
                    int cantidadEvidencias = evidenciaModelo.ContarEvidenciasAvance(idAvance);
                    UCFilaHistorialTarea control = new UCFilaHistorialTarea();
                    control.Cabecera = Convert.ToDecimal(fila["Porcentaje"]).ToString("0") + "%  -  " + Convert.ToDateTime(fila["FechaRegistro"]).ToString("dd/MM/yyyy");
                    control.Detalle = fila["Descripcion"].ToString();
                    control.Evidencia = "Evidencia: " + cantidadEvidencias + " archivo(s)";
                    control.ColorIndicador = Color.FromArgb(0, 105, 240);
                    control.Dock = DockStyle.Top;
                    pnlFilasHistorial.Controls.Add(control);
                    control.BringToFront();
                }

                contador = contador + 1;
            }
        }

        private void CargarEvidencias()
        {
            pnlFilasEvidencia.Controls.Clear();
            DataTable evidencias = evidenciaModelo.ObtenerEvidenciasTarea(idTarea);

            if (evidencias.Rows.Count == 0)
            {
                AgregarMensaje(pnlFilasEvidencia, "No hay evidencias adjuntas.");
                return;
            }

            int inicio = evidencias.Rows.Count - 2;

            if (inicio < 0)
            {
                inicio = 0;
            }

            int contador = 0;

            foreach (DataRow fila in evidencias.Rows)
            {
                if (contador >= inicio)
                {
                    UCEvidenciaTarea control = new UCEvidenciaTarea();
                    control.IdEvidencia = Convert.ToInt32(fila["IdEvidencia"]);
                    control.NombreArchivo = fila["NombreArchivo"].ToString();
                    control.RutaArchivo = fila["RutaArchivo"].ToString();
                    control.DetalleArchivo = Convert.ToDateTime(fila["FechaSubida"]).ToString("dd/MM/yyyy") + "  ·  " + ObtenerTipoArchivo(fila["TipoArchivo"]);
                    control.Dock = DockStyle.Top;
                    pnlFilasEvidencia.Controls.Add(control);
                    control.BringToFront();
                }

                contador = contador + 1;
            }
        }

        private string ObtenerTipoArchivo(object valor)
        {
            if (valor == DBNull.Value)
            {
                return "Archivo";
            }

            if (string.IsNullOrEmpty(valor.ToString().Trim()) == true)
            {
                return "Archivo";
            }

            return valor.ToString();
        }

        private void CargarComentario()
        {
            comentario1.Visible = false;

            if (comentarioActual != null)
            {
                pnlComentarios.Controls.Remove(comentarioActual);
                comentarioActual.Dispose();
                comentarioActual = null;
            }

            DataTable comentarios = comentarioModelo.ObtenerComentariosTarea(idTarea);

            if (comentarios.Rows.Count == 0)
            {
                comentarioActual = new UCComentarioTarea();
                comentarioActual.Usuario = "Sin comentarios";
                comentarioActual.Fecha = "";
                comentarioActual.Comentario = "Todavía no se han agregado comentarios a esta tarea.";
            }
            else
            {
                DataRow fila = comentarios.Rows[0];
                comentarioActual = new UCComentarioTarea();
                comentarioActual.Usuario = fila["NombreCompleto"].ToString();
                comentarioActual.Fecha = Convert.ToDateTime(fila["FechaComentario"]).ToString("dd/MM/yyyy");
                comentarioActual.Comentario = fila["Comentario"].ToString();
            }

            comentarioActual.ImagenPerfil = Properties.Recursos.AvatarUsuario;
            comentarioActual.Location = new Point(0, 52);
            comentarioActual.Width = pnlComentarios.ClientSize.Width;
            comentarioActual.Height = 76;
            comentarioActual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlComentarios.Controls.Add(comentarioActual);
            pnlTituloComentarios.BringToFront();
            pnlNuevoComentario.BringToFront();
        }

        private void AgregarMensaje(Panel panel, string texto)
        {
            Label etiqueta = new Label();
            etiqueta.Text = texto;
            etiqueta.ForeColor = Color.FromArgb(102, 118, 138);
            etiqueta.TextAlign = ContentAlignment.MiddleCenter;
            etiqueta.Dock = DockStyle.Fill;
            panel.Controls.Add(etiqueta);
        }

        private void btnEnviarComentario_Click(object sender, EventArgs e)
        {
            string comentario = txtNuevoComentario.Text.Trim();

            if (string.IsNullOrEmpty(comentario) == true)
            {
                MessageBox.Show("Escribe un comentario.", "Comentario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Sesion.UsuarioActual == null)
            {
                return;
            }

            int idUsuario = Sesion.UsuarioActual.IdUsuario;
            comentarioModelo.AgregarComentario(idTarea, idUsuario, comentario);
            txtNuevoComentario.Clear();
            CargarComentario();
        }

        public void ConfigurarOrigenRevision()
        {
            lblBreadcrumbBase.Text = "Tareas > Revisión de tareas >";
            btnVolver.Text = "← Volver a revisión";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (VolverSolicitado != null)
            {
                VolverSolicitado(this, EventArgs.Empty);
            }
        }
    }
}
