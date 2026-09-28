using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Modelo.Modelo.Entidades;
using Modelo.Modelo.Infraestructura;

namespace Vista
{
    public partial class frmDetalleTareaColaborador : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        private int idTarea;
        private Tarea tareaModelo;
        private Avance avanceModelo;
        private Evidencia evidenciaModelo;
        private ComentarioTarea comentarioModelo;
        private UCComentarioTarea comentarioActual;
        private int paginaComentario;
        private int totalComentarios;

        public event EventHandler VolverSolicitado;
        public event EventHandler RegistrarAvanceSolicitado;

        public int IdTarea
        {
            get
            {
                return idTarea;
            }
        }

        public frmDetalleTareaColaborador()
            : this(0)
        {
        }

        public frmDetalleTareaColaborador(int idTarea)
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(btnVolver, "Volver a la pantalla anterior.");
            toolTipAyuda.SetToolTip(btnAnteriorComentario, "Ver el comentario anterior.");
            toolTipAyuda.SetToolTip(btnSiguienteComentario, "Ver el siguiente comentario.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            lblFecha.Text = System.DateTime.Today.ToString("dd/MM/yyyy");
            this.idTarea = idTarea;
            tareaModelo = new Tarea();
            avanceModelo = new Avance();
            evidenciaModelo = new Evidencia();
            ucPaginadorHistorial.PaginaCambiada += ucPaginadorHistorial_PaginaCambiada;
            ucPaginadorEvidencias.PaginaCambiada += ucPaginadorEvidencias_PaginaCambiada;
            comentarioModelo = new ComentarioTarea();
            btnVolver.Click += btnVolver_Click;
            ucEstado.AccionSolicitada += ucEstado_AccionSolicitada;

            if (idTarea > 0)
            {
                CargarDetalle();
            }
        }

        private void CargarDetalle()
        {
            DataTable datos = tareaModelo.ObtenerDetalleTarea(idTarea);

            if (datos.Rows.Count == 0)
            {
                CatalogoErrores.MostrarDetalle("ERR-NEG-004", "Detalle de tarea", "No se encontró la tarea.");
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
            ucEstado.TextoBoton = "Actualizar avance";

            CargarHistorial();
            CargarEvidencias();
            CargarComentario();
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
            int total;
            int pagina = ucPaginadorHistorial.Inicio / ucPaginadorHistorial.TamanoPagina;
            DataTable historial = avanceModelo.ObtenerHistorialTareaPagina(idTarea, pagina,
                ucPaginadorHistorial.TamanoPagina, out total);
            ucPaginadorHistorial.Configurar(total, false);
            if (pagina != ucPaginadorHistorial.Inicio / ucPaginadorHistorial.TamanoPagina)
            {
                CargarHistorial();
                return;
            }
            if (historial.Rows.Count == 0)
            {
                AgregarMensaje(pnlFilasHistorial, "Todavía no hay avances registrados.");
                return;
            }
            for (int indice = historial.Rows.Count - 1; indice >= 0; indice = indice - 1)
            {
                DataRow fila = historial.Rows[indice];
                UCFilaHistorialTarea control = new UCFilaHistorialTarea();
                control.Cabecera = Convert.ToDecimal(fila["Porcentaje"]).ToString("0") +
                    "%  -  " + Convert.ToDateTime(fila["FechaRegistro"]).ToString("dd/MM/yyyy");
                control.Detalle = fila["Descripcion"].ToString();
                control.Evidencia = "Evidencia: " + fila["CantidadEvidencias"] + " archivo(s)";
                control.ColorIndicador = Color.FromArgb(0, 105, 240);
                control.Dock = DockStyle.Top;
                pnlFilasHistorial.Controls.Add(control);
                control.BringToFront();
            }
        }

        private void ucPaginadorHistorial_PaginaCambiada(object sender, EventArgs e)
        {
            CargarHistorial();
        }


        private void CargarEvidencias()
        {
            pnlFilasEvidencia.Controls.Clear();
            int total;
            int pagina = ucPaginadorEvidencias.Inicio / ucPaginadorEvidencias.TamanoPagina;
            DataTable evidencias = evidenciaModelo.ObtenerEvidenciasTareaPagina(idTarea, pagina,
                ucPaginadorEvidencias.TamanoPagina, out total);
            ucPaginadorEvidencias.Configurar(total, false);
            if (pagina != ucPaginadorEvidencias.Inicio / ucPaginadorEvidencias.TamanoPagina)
            {
                CargarEvidencias();
                return;
            }
            if (evidencias.Rows.Count == 0)
            {
                AgregarMensaje(pnlFilasEvidencia, "No hay evidencias adjuntas.");
                return;
            }
            for (int indice = evidencias.Rows.Count - 1; indice >= 0; indice = indice - 1)
            {
                DataRow fila = evidencias.Rows[indice];
                UCEvidenciaTarea control = new UCEvidenciaTarea();
                control.IdEvidencia = Convert.ToInt32(fila["IdEvidencia"]);
                control.NombreArchivo = fila["NombreArchivo"].ToString();
                control.RutaArchivo = fila["RutaArchivo"].ToString();
                control.DetalleArchivo = Convert.ToDateTime(fila["FechaSubida"]).ToString("dd/MM/yyyy") +
                    "  ·  " + ObtenerTipoArchivo(fila["TipoArchivo"]);
                control.Dock = DockStyle.Top;
                pnlFilasEvidencia.Controls.Add(control);
                control.BringToFront();
            }
        }

        private void ucPaginadorEvidencias_PaginaCambiada(object sender, EventArgs e)
        {
            CargarEvidencias();
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

            int total;
            DataTable comentarios = comentarioModelo.ObtenerComentariosTareaPagina(idTarea, paginaComentario, out total);
            if (comentarios.Rows.Count == 0 && paginaComentario > 0)
            {
                paginaComentario = 0;
                CargarComentario();
                return;
            }
            totalComentarios = total;
            pnlNavegacionComentario.Visible = true;
            btnAnteriorComentario.Enabled = paginaComentario > 0;
            btnSiguienteComentario.Enabled = paginaComentario + 1 < totalComentarios;
            if (totalComentarios == 0)
            {
                lblPaginaComentario.Text = "0 de 0";
            }
            else
            {
                lblPaginaComentario.Text = (paginaComentario + 1) + " de " + totalComentarios;
            }

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
            comentarioActual.Location = new Point(0, 42);
            comentarioActual.Width = pnlComentarios.ClientSize.Width;
            comentarioActual.Height = pnlComentarios.ClientSize.Height - 42;
            comentarioActual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlComentarios.Controls.Add(comentarioActual);
            pnlTituloComentarios.BringToFront();
        }

        private void btnAnteriorComentario_Click(object sender, EventArgs e)
        {
            if (paginaComentario > 0)
            {
                paginaComentario = paginaComentario - 1;
                CargarComentario();
            }
        }

        private void btnSiguienteComentario_Click(object sender, EventArgs e)
        {
            if (paginaComentario + 1 < totalComentarios)
            {
                paginaComentario = paginaComentario + 1;
                CargarComentario();
            }
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (VolverSolicitado != null)
            {
                VolverSolicitado(this, EventArgs.Empty);
            }
        }

        private void ucEstado_AccionSolicitada(object sender, EventArgs e)
        {
            if (RegistrarAvanceSolicitado != null)
            {
                RegistrarAvanceSolicitado(this, EventArgs.Empty);
            }
        }
    }
}
