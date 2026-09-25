namespace Vista
{
    partial class frmDetalleTareaColaborador
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblBreadcrumbActual = new System.Windows.Forms.Label();
            this.lblBreadcrumbBase = new System.Windows.Forms.Label();
            this.pnlViewport = new System.Windows.Forms.Panel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.tlpIzquierda = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlTituloInfo = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.sepInfo = new System.Windows.Forms.Panel();
            this.ucInformacion = new Vista.UCInformacionTarea();
            this.pnlHistorial = new System.Windows.Forms.Panel();
            this.pnlTituloHistorial = new System.Windows.Forms.Panel();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.sepHistorial = new System.Windows.Forms.Panel();
            this.pnlFilasHistorial = new System.Windows.Forms.Panel();
            this.historial1 = new Vista.UCFilaHistorialTarea();
            this.historial2 = new Vista.UCFilaHistorialTarea();
            this.historial3 = new Vista.UCFilaHistorialTarea();
            this.pnlComentarios = new System.Windows.Forms.Panel();
            this.pnlTituloComentarios = new System.Windows.Forms.Panel();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.sepComentarios = new System.Windows.Forms.Panel();
            this.comentario1 = new Vista.UCComentarioTarea();
            this.tlpDerecha = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEstado = new System.Windows.Forms.Panel();
            this.pnlTituloEstado = new System.Windows.Forms.Panel();
            this.lblEstadoSeccion = new System.Windows.Forms.Label();
            this.sepEstado = new System.Windows.Forms.Panel();
            this.ucEstado = new Vista.UCEstadoTarea();
            this.pnlEvidencias = new System.Windows.Forms.Panel();
            this.pnlTituloEvidencias = new System.Windows.Forms.Panel();
            this.lblEvidencias = new System.Windows.Forms.Label();
            this.sepEvidencias = new System.Windows.Forms.Panel();
            this.pnlFilasEvidencia = new System.Windows.Forms.Panel();
            this.evidencia1 = new Vista.UCEvidenciaTarea();
            this.pnlTop.SuspendLayout();
            this.pnlViewport.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            this.tlpContenido.SuspendLayout();
            this.tlpIzquierda.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlTituloInfo.SuspendLayout();
            this.pnlHistorial.SuspendLayout();
            this.pnlTituloHistorial.SuspendLayout();
            this.pnlFilasHistorial.SuspendLayout();
            this.pnlComentarios.SuspendLayout();
            this.pnlTituloComentarios.SuspendLayout();
            this.tlpDerecha.SuspendLayout();
            this.pnlEstado.SuspendLayout();
            this.pnlTituloEstado.SuspendLayout();
            this.pnlEvidencias.SuspendLayout();
            this.pnlTituloEvidencias.SuspendLayout();
            this.pnlFilasEvidencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblFecha);
            this.pnlTop.Controls.Add(this.lblBreadcrumbActual);
            this.pnlTop.Controls.Add(this.lblBreadcrumbBase);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1670, 43);
            this.pnlTop.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblFecha.Location = new System.Drawing.Point(1610, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Text = "Fecha";
            // 
            // lblBreadcrumbActual
            // 
            this.lblBreadcrumbActual.AutoSize = true;
            this.lblBreadcrumbActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreadcrumbActual.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(222, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Text = "Detalle de tarea";
            // 
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.Text = "Mis tareas > Tablero de tareas >";
            // 
            // pnlViewport
            // 
            this.pnlViewport.AutoScroll = true;
            this.pnlViewport.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlViewport.Controls.Add(this.tlpMain);
            this.pnlViewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewport.Location = new System.Drawing.Point(0, 43);
            this.pnlViewport.Name = "pnlViewport";
            this.pnlViewport.Size = new System.Drawing.Size(1670, 1037);
            this.pnlViewport.TabIndex = 1;
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = false;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlCabecera, 0, 0);
            this.tlpMain.Controls.Add(this.tlpContenido, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(24, 18, 24, 24);
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 566F));
            this.tlpMain.Size = new System.Drawing.Size(1670, 680);
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Controls.Add(this.lblSubtitulo);
            this.pnlCabecera.Controls.Add(this.btnVolver);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCabecera.Name = "pnlCabecera";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "“Nombre de la tarea”";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblSubtitulo.Location = new System.Drawing.Point(2, 39);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Proyecto: “Nombre de proyecto 1”  |  Responsable: Juan Menjívar";
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.btnVolver.Location = new System.Drawing.Point(1434, 8);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 34);
            this.btnVolver.Text = "← Volver a mis tareas";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // tlpContenido
            // 
            this.tlpContenido.AutoSize = false;
            this.tlpContenido.ColumnCount = 2;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tlpContenido.Controls.Add(this.tlpIzquierda, 0, 0);
            this.tlpContenido.Controls.Add(this.tlpDerecha, 1, 0);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.RowCount = 1;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            // 
            // tlpIzquierda
            // 
            this.tlpIzquierda.ColumnCount = 1;
            this.tlpIzquierda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIzquierda.Controls.Add(this.pnlInfo, 0, 0);
            this.tlpIzquierda.Controls.Add(this.pnlHistorial, 0, 1);
            this.tlpIzquierda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIzquierda.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.tlpIzquierda.Name = "tlpIzquierda";
            this.tlpIzquierda.RowCount = 2;
            this.tlpIzquierda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.tlpIzquierda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 274F));
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.ucInformacion);
            this.pnlInfo.Controls.Add(this.pnlTituloInfo);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlInfo.Name = "pnlInfo";
            // 
            // pnlTituloInfo
            // 
            this.pnlTituloInfo.Controls.Add(this.lblInfo);
            this.pnlTituloInfo.Controls.Add(this.sepInfo);
            this.pnlTituloInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloInfo.Name = "pnlTituloInfo";
            this.pnlTituloInfo.Size = new System.Drawing.Size(100, 42);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblInfo.Location = new System.Drawing.Point(14, 11);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Text = "Información de la tarea";
            // 
            // sepInfo
            // 
            this.sepInfo.BackColor = System.Drawing.Color.FromArgb(164, 177, 193);
            this.sepInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sepInfo.Name = "sepInfo";
            this.sepInfo.Size = new System.Drawing.Size(100, 1);
            // 
            // ucInformacion
            // 
            this.ucInformacion.BackColor = System.Drawing.Color.White;
            this.ucInformacion.Descripcion = "Elaborar el informe mensual de avance del proyecto, incluyendo datos de campo de los sectores A, B y C.";
            this.ucInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInformacion.FechaInicio = "1 de mayo de 2026";
            this.ucInformacion.FechaLimite = "30 de mayo de 2026";
            this.ucInformacion.HitoRelacionado = "Levantamiento de datos";
            this.ucInformacion.Name = "ucInformacion";
            this.ucInformacion.Observaciones = "Usar la plantilla del mes anterior como base.";
            this.ucInformacion.Prioridad = "Alta";
            this.ucInformacion.Proyecto = "Programa Comunitario Norte";
            this.ucInformacion.Responsable = "Juan Menjívar";
            // 
            // pnlHistorial
            // 
            this.pnlHistorial.BackColor = System.Drawing.Color.White;
            this.pnlHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHistorial.Controls.Add(this.pnlFilasHistorial);
            this.pnlHistorial.Controls.Add(this.pnlTituloHistorial);
            this.pnlHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistorial.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlHistorial.Name = "pnlHistorial";
            // 
            // pnlTituloHistorial
            // 
            this.pnlTituloHistorial.Controls.Add(this.lblHistorial);
            this.pnlTituloHistorial.Controls.Add(this.sepHistorial);
            this.pnlTituloHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloHistorial.Name = "pnlTituloHistorial";
            this.pnlTituloHistorial.Size = new System.Drawing.Size(100, 42);
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHistorial.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblHistorial.Location = new System.Drawing.Point(14, 11);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Text = "Historial de avances en esta tarea";
            // 
            // sepHistorial
            // 
            this.sepHistorial.BackColor = System.Drawing.Color.FromArgb(164, 177, 193);
            this.sepHistorial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sepHistorial.Name = "sepHistorial";
            this.sepHistorial.Size = new System.Drawing.Size(100, 1);
            // 
            // pnlFilasHistorial
            // 
            this.pnlFilasHistorial.AutoScroll = false;
            this.pnlFilasHistorial.Controls.Add(this.historial3);
            this.pnlFilasHistorial.Controls.Add(this.historial2);
            this.pnlFilasHistorial.Controls.Add(this.historial1);
            this.pnlFilasHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilasHistorial.Name = "pnlFilasHistorial";
            // 
            // historial1
            // 
            this.historial1.BackColor = System.Drawing.Color.White;
            this.historial1.Cabecera = "60%  -  28 abr 2026";
            this.historial1.ColorIndicador = System.Drawing.Color.FromArgb(0, 105, 240);
            this.historial1.Detalle = "Secciones 1 y 2 completadas. Pendiente sección 3.";
            this.historial1.Dock = System.Windows.Forms.DockStyle.Top;
            this.historial1.Evidencia = "Evidencia: 1 archivo";
            this.historial1.Margin = new System.Windows.Forms.Padding(0);
            this.historial1.Name = "historial1";
            this.historial1.Size = new System.Drawing.Size(1000, 74);
            // 
            // historial2
            // 
            this.historial2.BackColor = System.Drawing.Color.White;
            this.historial2.Cabecera = "40%  -  21 abr 2026";
            this.historial2.ColorIndicador = System.Drawing.Color.FromArgb(0, 105, 240);
            this.historial2.Detalle = "Estructura del informe definida. Inicio de recopilación de datos.";
            this.historial2.Dock = System.Windows.Forms.DockStyle.Top;
            this.historial2.Evidencia = "Evidencia: —";
            this.historial2.Margin = new System.Windows.Forms.Padding(0);
            this.historial2.Name = "historial2";
            this.historial2.Size = new System.Drawing.Size(1000, 74);
            // 
            // historial3
            // 
            this.historial3.BackColor = System.Drawing.Color.White;
            this.historial3.Cabecera = "15%  -  14 abr 2026";
            this.historial3.ColorIndicador = System.Drawing.Color.FromArgb(0, 105, 240);
            this.historial3.Detalle = "Inicio de tarea. Revisión de plantilla anterior.";
            this.historial3.Dock = System.Windows.Forms.DockStyle.Top;
            this.historial3.Evidencia = "Evidencia: —";
            this.historial3.Margin = new System.Windows.Forms.Padding(0);
            this.historial3.Name = "historial3";
            this.historial3.Size = new System.Drawing.Size(1000, 74);
            // 
            // pnlComentarios
            // 
            this.pnlComentarios.BackColor = System.Drawing.Color.White;
            this.pnlComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlComentarios.Controls.Add(this.comentario1);
            this.pnlComentarios.Controls.Add(this.pnlTituloComentarios);
            this.pnlComentarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlComentarios.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlComentarios.Name = "pnlComentarios";
            // 
            // pnlTituloComentarios
            // 
            this.pnlTituloComentarios.Controls.Add(this.lblComentarios);
            this.pnlTituloComentarios.Controls.Add(this.sepComentarios);
            this.pnlTituloComentarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloComentarios.Name = "pnlTituloComentarios";
            this.pnlTituloComentarios.Size = new System.Drawing.Size(100, 42);
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblComentarios.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblComentarios.Location = new System.Drawing.Point(14, 11);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Text = "Comentarios del coordinador";
            // 
            // sepComentarios
            // 
            this.sepComentarios.BackColor = System.Drawing.Color.FromArgb(164, 177, 193);
            this.sepComentarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sepComentarios.Name = "sepComentarios";
            this.sepComentarios.Size = new System.Drawing.Size(100, 1);
            // 
            // comentario1
            // 
            this.comentario1.BackColor = System.Drawing.Color.White;
            this.comentario1.Comentario = "Asegúrate de incluir los datos del sector B. Es clave para el hito del 30 de abril.";
            this.comentario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comentario1.Fecha = "28 abr 2026";
            this.comentario1.ImagenPerfil = global::Vista.Properties.Recursos.AvatarUsuario;
            this.comentario1.Margin = new System.Windows.Forms.Padding(0);
            this.comentario1.Name = "comentario1";
            this.comentario1.Size = new System.Drawing.Size(1000, 72);
            this.comentario1.Usuario = "Juan Pérez";
            // 
            // tlpDerecha
            // 
            this.tlpDerecha.ColumnCount = 1;
            this.tlpDerecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDerecha.Controls.Add(this.pnlEstado, 0, 0);
            this.tlpDerecha.Controls.Add(this.pnlComentarios, 0, 1);
            this.tlpDerecha.Controls.Add(this.pnlEvidencias, 0, 2);
            this.tlpDerecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDerecha.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.tlpDerecha.Name = "tlpDerecha";
            this.tlpDerecha.RowCount = 4;
            this.tlpDerecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.tlpDerecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tlpDerecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tlpDerecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            // 
            // pnlEstado
            // 
            this.pnlEstado.BackColor = System.Drawing.Color.White;
            this.pnlEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEstado.Controls.Add(this.ucEstado);
            this.pnlEstado.Controls.Add(this.pnlTituloEstado);
            this.pnlEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstado.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlEstado.Name = "pnlEstado";
            // 
            // pnlTituloEstado
            // 
            this.pnlTituloEstado.Controls.Add(this.lblEstadoSeccion);
            this.pnlTituloEstado.Controls.Add(this.sepEstado);
            this.pnlTituloEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloEstado.Name = "pnlTituloEstado";
            this.pnlTituloEstado.Size = new System.Drawing.Size(100, 42);
            // 
            // lblEstadoSeccion
            // 
            this.lblEstadoSeccion.AutoSize = true;
            this.lblEstadoSeccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstadoSeccion.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblEstadoSeccion.Location = new System.Drawing.Point(14, 11);
            this.lblEstadoSeccion.Name = "lblEstadoSeccion";
            this.lblEstadoSeccion.Text = "Estado";
            // 
            // sepEstado
            // 
            this.sepEstado.BackColor = System.Drawing.Color.FromArgb(164, 177, 193);
            this.sepEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sepEstado.Name = "sepEstado";
            this.sepEstado.Size = new System.Drawing.Size(100, 1);
            // 
            // ucEstado
            // 
            this.ucEstado.Avance = 60;
            this.ucEstado.BackColor = System.Drawing.Color.White;
            this.ucEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEstado.Estado = "En proceso";
            this.ucEstado.Evidencias = "1 archivo";
            this.ucEstado.Name = "ucEstado";
            this.ucEstado.Prioridad = "Alta";
            this.ucEstado.TextoBoton = "Actualizar avance";
            this.ucEstado.Vencimiento = "Hoy";
            // 
            // pnlEvidencias
            // 
            this.pnlEvidencias.BackColor = System.Drawing.Color.White;
            this.pnlEvidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEvidencias.Controls.Add(this.pnlFilasEvidencia);
            this.pnlEvidencias.Controls.Add(this.pnlTituloEvidencias);
            this.pnlEvidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEvidencias.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEvidencias.Name = "pnlEvidencias";
            // 
            // pnlTituloEvidencias
            // 
            this.pnlTituloEvidencias.Controls.Add(this.lblEvidencias);
            this.pnlTituloEvidencias.Controls.Add(this.sepEvidencias);
            this.pnlTituloEvidencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloEvidencias.Name = "pnlTituloEvidencias";
            this.pnlTituloEvidencias.Size = new System.Drawing.Size(100, 42);
            // 
            // lblEvidencias
            // 
            this.lblEvidencias.AutoSize = true;
            this.lblEvidencias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEvidencias.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblEvidencias.Location = new System.Drawing.Point(14, 11);
            this.lblEvidencias.Name = "lblEvidencias";
            this.lblEvidencias.Text = "Evidencia adjunta";
            // 
            // sepEvidencias
            // 
            this.sepEvidencias.BackColor = System.Drawing.Color.FromArgb(164, 177, 193);
            this.sepEvidencias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sepEvidencias.Name = "sepEvidencias";
            this.sepEvidencias.Size = new System.Drawing.Size(100, 1);
            // 
            // pnlFilasEvidencia
            // 
            this.pnlFilasEvidencia.AutoScroll = false;
            this.pnlFilasEvidencia.Controls.Add(this.evidencia1);
            this.pnlFilasEvidencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilasEvidencia.Name = "pnlFilasEvidencia";
            this.pnlFilasEvidencia.Padding = new System.Windows.Forms.Padding(8);
            // 
            // evidencia1
            // 
            this.evidencia1.BackColor = System.Drawing.Color.White;
            this.evidencia1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.evidencia1.DetalleArchivo = "28 abr 2026  ·  250 KB";
            this.evidencia1.Dock = System.Windows.Forms.DockStyle.Top;
            this.evidencia1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.evidencia1.Name = "evidencia1";
            this.evidencia1.NombreArchivo = "informe_avance.pdf";
            this.evidencia1.Size = new System.Drawing.Size(360, 68);
            // 
            // frmDetalleTareaColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.Controls.Add(this.pnlViewport);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetalleTareaColaborador";
            this.Text = "Detalle de tarea";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlViewport.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.tlpContenido.ResumeLayout(false);
            this.tlpIzquierda.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlTituloInfo.ResumeLayout(false);
            this.pnlTituloInfo.PerformLayout();
            this.pnlHistorial.ResumeLayout(false);
            this.pnlTituloHistorial.ResumeLayout(false);
            this.pnlTituloHistorial.PerformLayout();
            this.pnlFilasHistorial.ResumeLayout(false);
            this.pnlComentarios.ResumeLayout(false);
            this.pnlTituloComentarios.ResumeLayout(false);
            this.pnlTituloComentarios.PerformLayout();
            this.tlpDerecha.ResumeLayout(false);
            this.pnlEstado.ResumeLayout(false);
            this.pnlTituloEstado.ResumeLayout(false);
            this.pnlTituloEstado.PerformLayout();
            this.pnlEvidencias.ResumeLayout(false);
            this.pnlTituloEvidencias.ResumeLayout(false);
            this.pnlTituloEvidencias.PerformLayout();
            this.pnlFilasEvidencia.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblBreadcrumbActual;
        private System.Windows.Forms.Label lblBreadcrumbBase;
        private System.Windows.Forms.Panel pnlViewport;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.TableLayoutPanel tlpIzquierda;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlTituloInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel sepInfo;
        private Vista.UCInformacionTarea ucInformacion;
        private System.Windows.Forms.Panel pnlHistorial;
        private System.Windows.Forms.Panel pnlTituloHistorial;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Panel sepHistorial;
        private System.Windows.Forms.Panel pnlFilasHistorial;
        private Vista.UCFilaHistorialTarea historial1;
        private Vista.UCFilaHistorialTarea historial2;
        private Vista.UCFilaHistorialTarea historial3;
        private System.Windows.Forms.Panel pnlComentarios;
        private System.Windows.Forms.Panel pnlTituloComentarios;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Panel sepComentarios;
        private Vista.UCComentarioTarea comentario1;
        private System.Windows.Forms.TableLayoutPanel tlpDerecha;
        private System.Windows.Forms.Panel pnlEstado;
        private System.Windows.Forms.Panel pnlTituloEstado;
        private System.Windows.Forms.Label lblEstadoSeccion;
        private System.Windows.Forms.Panel sepEstado;
        private Vista.UCEstadoTarea ucEstado;
        private System.Windows.Forms.Panel pnlEvidencias;
        private System.Windows.Forms.Panel pnlTituloEvidencias;
        private System.Windows.Forms.Label lblEvidencias;
        private System.Windows.Forms.Panel sepEvidencias;
        private System.Windows.Forms.Panel pnlFilasEvidencia;
        private Vista.UCEvidenciaTarea evidencia1;
    }
}
