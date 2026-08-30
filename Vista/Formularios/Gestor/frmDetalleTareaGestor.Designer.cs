namespace Vista
{
    partial class frmDetalleTareaGestor
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
            this.ucInformacion = new Vista.UCInformacionTarea();
            this.pnlTituloInfo = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.sepInfo = new System.Windows.Forms.Panel();
            this.pnlHistorial = new System.Windows.Forms.Panel();
            this.pnlFilasHistorial = new System.Windows.Forms.Panel();
            this.historial3 = new Vista.UCFilaHistorialTarea();
            this.historial2 = new Vista.UCFilaHistorialTarea();
            this.historial1 = new Vista.UCFilaHistorialTarea();
            this.pnlTituloHistorial = new System.Windows.Forms.Panel();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.sepHistorial = new System.Windows.Forms.Panel();
            this.pnlComentarios = new System.Windows.Forms.Panel();
            this.pnlNuevoComentario = new System.Windows.Forms.Panel();
            this.tlpNuevoComentario = new System.Windows.Forms.TableLayoutPanel();
            this.txtNuevoComentario = new System.Windows.Forms.TextBox();
            this.btnEnviarComentario = new System.Windows.Forms.Button();
            this.comentario1 = new Vista.UCComentarioTarea();
            this.pnlTituloComentarios = new System.Windows.Forms.Panel();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.sepComentarios = new System.Windows.Forms.Panel();
            this.tlpDerecha = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEstado = new System.Windows.Forms.Panel();
            this.ucEstado = new Vista.UCEstadoTarea();
            this.pnlTituloEstado = new System.Windows.Forms.Panel();
            this.lblEstadoSeccion = new System.Windows.Forms.Label();
            this.sepEstado = new System.Windows.Forms.Panel();
            this.pnlEvidencias = new System.Windows.Forms.Panel();
            this.pnlFilasEvidencia = new System.Windows.Forms.Panel();
            this.evidencia1 = new Vista.UCEvidenciaTarea();
            this.pnlTituloEvidencias = new System.Windows.Forms.Panel();
            this.lblEvidencias = new System.Windows.Forms.Label();
            this.sepEvidencias = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlViewport.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            this.tlpContenido.SuspendLayout();
            this.tlpIzquierda.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlTituloInfo.SuspendLayout();
            this.pnlHistorial.SuspendLayout();
            this.pnlFilasHistorial.SuspendLayout();
            this.pnlTituloHistorial.SuspendLayout();
            this.pnlComentarios.SuspendLayout();
            this.pnlNuevoComentario.SuspendLayout();
            this.tlpNuevoComentario.SuspendLayout();
            this.pnlTituloComentarios.SuspendLayout();
            this.tlpDerecha.SuspendLayout();
            this.pnlEstado.SuspendLayout();
            this.pnlTituloEstado.SuspendLayout();
            this.pnlEvidencias.SuspendLayout();
            this.pnlFilasEvidencia.SuspendLayout();
            this.pnlTituloEvidencias.SuspendLayout();
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
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(2088, 53);
            this.pnlTop.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblFecha.Location = new System.Drawing.Point(3849, 14);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 20);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // lblBreadcrumbActual
            // 
            this.lblBreadcrumbActual.AutoSize = true;
            this.lblBreadcrumbActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreadcrumbActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(209, 14);
            this.lblBreadcrumbActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Size = new System.Drawing.Size(119, 20);
            this.lblBreadcrumbActual.TabIndex = 1;
            this.lblBreadcrumbActual.Text = "Detalle de tarea";
            // 
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 14);
            this.lblBreadcrumbBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.Size = new System.Drawing.Size(64, 20);
            this.lblBreadcrumbBase.TabIndex = 2;
            this.lblBreadcrumbBase.Text = "Tareas > Tablero de tareas >";
            // 
            // pnlViewport
            // 
            this.pnlViewport.AutoScroll = true;
            this.pnlViewport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlViewport.Controls.Add(this.tlpMain);
            this.pnlViewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewport.Location = new System.Drawing.Point(0, 53);
            this.pnlViewport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlViewport.Name = "pnlViewport";
            this.pnlViewport.Size = new System.Drawing.Size(2088, 1297);
            this.pnlViewport.TabIndex = 1;
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlCabecera, 0, 0);
            this.tlpMain.Controls.Add(this.tlpContenido, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(30, 22, 30, 30);
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 900F));
            this.tlpMain.Size = new System.Drawing.Size(2088, 1042);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Controls.Add(this.lblSubtitulo);
            this.pnlCabecera.Controls.Add(this.btnVolver);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCabecera.Location = new System.Drawing.Point(34, 26);
            this.pnlCabecera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(2020, 82);
            this.pnlCabecera.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(320, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "“Nombre de la tarea”";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(2, 49);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(438, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Proyecto: “Nombre de proyecto 1”  |  Responsable: Juan Menjívar";
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.btnVolver.Location = new System.Drawing.Point(3562, 10);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(188, 42);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "← Volver al tablero";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // tlpContenido
            // 
            this.tlpContenido.ColumnCount = 2;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tlpContenido.Controls.Add(this.tlpIzquierda, 0, 0);
            this.tlpContenido.Controls.Add(this.tlpDerecha, 1, 0);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(30, 112);
            this.tlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.RowCount = 1;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Size = new System.Drawing.Size(2028, 900);
            this.tlpContenido.TabIndex = 1;
            // 
            // tlpIzquierda
            // 
            this.tlpIzquierda.ColumnCount = 1;
            this.tlpIzquierda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIzquierda.Controls.Add(this.pnlInfo, 0, 0);
            this.tlpIzquierda.Controls.Add(this.pnlHistorial, 0, 1);
            this.tlpIzquierda.Controls.Add(this.pnlComentarios, 0, 2);
            this.tlpIzquierda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIzquierda.Location = new System.Drawing.Point(0, 0);
            this.tlpIzquierda.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tlpIzquierda.Name = "tlpIzquierda";
            this.tlpIzquierda.RowCount = 3;
            this.tlpIzquierda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 365F));
            this.tlpIzquierda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.tlpIzquierda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tlpIzquierda.Size = new System.Drawing.Size(1490, 900);
            this.tlpIzquierda.TabIndex = 0;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.ucInformacion);
            this.pnlInfo.Controls.Add(this.pnlTituloInfo);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1490, 355);
            this.pnlInfo.TabIndex = 0;
            // 
            // ucInformacion
            // 
            this.ucInformacion.BackColor = System.Drawing.Color.White;
            this.ucInformacion.Descripcion = "Elaborar el informe mensual de avance del proyecto, incluyendo datos de campo de " +
            "los sectores A, B y C.";
            this.ucInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInformacion.FechaInicio = "1 de mayo de 2026";
            this.ucInformacion.FechaLimite = "30 de mayo de 2026";
            this.ucInformacion.HitoRelacionado = "Levantamiento de datos";
            this.ucInformacion.Location = new System.Drawing.Point(0, 52);
            this.ucInformacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucInformacion.Name = "ucInformacion";
            this.ucInformacion.Observaciones = "Usar la plantilla del mes anterior como base.";
            this.ucInformacion.Prioridad = "Alta";
            this.ucInformacion.Proyecto = "Programa Comunitario Norte";
            this.ucInformacion.Responsable = "Juan Menjívar";
            this.ucInformacion.Size = new System.Drawing.Size(1488, 301);
            this.ucInformacion.TabIndex = 0;
            // 
            // pnlTituloInfo
            // 
            this.pnlTituloInfo.Controls.Add(this.lblInfo);
            this.pnlTituloInfo.Controls.Add(this.sepInfo);
            this.pnlTituloInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTituloInfo.Name = "pnlTituloInfo";
            this.pnlTituloInfo.Size = new System.Drawing.Size(1488, 52);
            this.pnlTituloInfo.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblInfo.Location = new System.Drawing.Point(18, 14);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(197, 23);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Información de la tarea";
            // 
            // sepInfo
            // 
            this.sepInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.sepInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sepInfo.Location = new System.Drawing.Point(0, 51);
            this.sepInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sepInfo.Name = "sepInfo";
            this.sepInfo.Size = new System.Drawing.Size(1488, 1);
            this.sepInfo.TabIndex = 1;
            // 
            // pnlHistorial
            // 
            this.pnlHistorial.BackColor = System.Drawing.Color.White;
            this.pnlHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHistorial.Controls.Add(this.pnlFilasHistorial);
            this.pnlHistorial.Controls.Add(this.pnlTituloHistorial);
            this.pnlHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistorial.Location = new System.Drawing.Point(0, 365);
            this.pnlHistorial.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlHistorial.Name = "pnlHistorial";
            this.pnlHistorial.Size = new System.Drawing.Size(1490, 332);
            this.pnlHistorial.TabIndex = 1;
            // 
            // pnlFilasHistorial
            // 
            this.pnlFilasHistorial.Controls.Add(this.historial3);
            this.pnlFilasHistorial.Controls.Add(this.historial2);
            this.pnlFilasHistorial.Controls.Add(this.historial1);
            this.pnlFilasHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilasHistorial.Location = new System.Drawing.Point(0, 52);
            this.pnlFilasHistorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFilasHistorial.Name = "pnlFilasHistorial";
            this.pnlFilasHistorial.Size = new System.Drawing.Size(1488, 278);
            this.pnlFilasHistorial.TabIndex = 0;
            // 
            // historial3
            // 
            this.historial3.BackColor = System.Drawing.Color.White;
            this.historial3.Cabecera = "15%  -  14 abr 2026";
            this.historial3.ColorIndicador = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.historial3.Detalle = "Inicio de tarea. Revisión de plantilla anterior.";
            this.historial3.Dock = System.Windows.Forms.DockStyle.Top;
            this.historial3.Evidencia = "Evidencia: —";
            this.historial3.Location = new System.Drawing.Point(0, 184);
            this.historial3.Margin = new System.Windows.Forms.Padding(0);
            this.historial3.Name = "historial3";
            this.historial3.Size = new System.Drawing.Size(1488, 92);
            this.historial3.TabIndex = 0;
            // 
            // historial2
            // 
            this.historial2.BackColor = System.Drawing.Color.White;
            this.historial2.Cabecera = "40%  -  21 abr 2026";
            this.historial2.ColorIndicador = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.historial2.Detalle = "Estructura del informe definida. Inicio de recopilación de datos.";
            this.historial2.Dock = System.Windows.Forms.DockStyle.Top;
            this.historial2.Evidencia = "Evidencia: —";
            this.historial2.Location = new System.Drawing.Point(0, 92);
            this.historial2.Margin = new System.Windows.Forms.Padding(0);
            this.historial2.Name = "historial2";
            this.historial2.Size = new System.Drawing.Size(1488, 92);
            this.historial2.TabIndex = 1;
            // 
            // historial1
            // 
            this.historial1.BackColor = System.Drawing.Color.White;
            this.historial1.Cabecera = "60%  -  28 abr 2026";
            this.historial1.ColorIndicador = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.historial1.Detalle = "Secciones 1 y 2 completadas. Pendiente sección 3.";
            this.historial1.Dock = System.Windows.Forms.DockStyle.Top;
            this.historial1.Evidencia = "Evidencia: 1 archivo";
            this.historial1.Location = new System.Drawing.Point(0, 0);
            this.historial1.Margin = new System.Windows.Forms.Padding(0);
            this.historial1.Name = "historial1";
            this.historial1.Size = new System.Drawing.Size(1488, 92);
            this.historial1.TabIndex = 2;
            // 
            // pnlTituloHistorial
            // 
            this.pnlTituloHistorial.Controls.Add(this.lblHistorial);
            this.pnlTituloHistorial.Controls.Add(this.sepHistorial);
            this.pnlTituloHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloHistorial.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloHistorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTituloHistorial.Name = "pnlTituloHistorial";
            this.pnlTituloHistorial.Size = new System.Drawing.Size(1488, 52);
            this.pnlTituloHistorial.TabIndex = 1;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblHistorial.Location = new System.Drawing.Point(18, 14);
            this.lblHistorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(276, 23);
            this.lblHistorial.TabIndex = 0;
            this.lblHistorial.Text = "Historial de avances en esta tarea";
            // 
            // sepHistorial
            // 
            this.sepHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.sepHistorial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sepHistorial.Location = new System.Drawing.Point(0, 51);
            this.sepHistorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sepHistorial.Name = "sepHistorial";
            this.sepHistorial.Size = new System.Drawing.Size(1488, 1);
            this.sepHistorial.TabIndex = 1;
            // 
            // pnlComentarios
            // 
            this.pnlComentarios.BackColor = System.Drawing.Color.White;
            this.pnlComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlComentarios.Controls.Add(this.pnlNuevoComentario);
            this.pnlComentarios.Controls.Add(this.comentario1);
            this.pnlComentarios.Controls.Add(this.pnlTituloComentarios);
            this.pnlComentarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlComentarios.Location = new System.Drawing.Point(4, 711);
            this.pnlComentarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlComentarios.Name = "pnlComentarios";
            this.pnlComentarios.Size = new System.Drawing.Size(1482, 185);
            this.pnlComentarios.TabIndex = 2;
            // 
            // pnlNuevoComentario
            // 
            this.pnlNuevoComentario.Controls.Add(this.tlpNuevoComentario);
            this.pnlNuevoComentario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNuevoComentario.Location = new System.Drawing.Point(0, 128);
            this.pnlNuevoComentario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNuevoComentario.Name = "pnlNuevoComentario";
            this.pnlNuevoComentario.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pnlNuevoComentario.Size = new System.Drawing.Size(1480, 55);
            this.pnlNuevoComentario.TabIndex = 0;
            // 
            // tlpNuevoComentario
            // 
            this.tlpNuevoComentario.ColumnCount = 2;
            this.tlpNuevoComentario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tlpNuevoComentario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpNuevoComentario.Controls.Add(this.txtNuevoComentario, 0, 0);
            this.tlpNuevoComentario.Controls.Add(this.btnEnviarComentario, 1, 0);
            this.tlpNuevoComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNuevoComentario.Location = new System.Drawing.Point(8, 8);
            this.tlpNuevoComentario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpNuevoComentario.Name = "tlpNuevoComentario";
            this.tlpNuevoComentario.RowCount = 1;
            this.tlpNuevoComentario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNuevoComentario.Size = new System.Drawing.Size(1464, 39);
            this.tlpNuevoComentario.TabIndex = 0;
            // 
            // txtNuevoComentario
            // 
            this.txtNuevoComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNuevoComentario.Location = new System.Drawing.Point(0, 5);
            this.txtNuevoComentario.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.txtNuevoComentario.MaxLength = 500;
            this.txtNuevoComentario.Name = "txtNuevoComentario";
            this.txtNuevoComentario.ShortcutsEnabled = false;
            this.txtNuevoComentario.Size = new System.Drawing.Size(1278, 27);
            this.txtNuevoComentario.TabIndex = 0;
            // 
            // btnEnviarComentario
            // 
            this.btnEnviarComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.btnEnviarComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnviarComentario.FlatAppearance.BorderSize = 0;
            this.btnEnviarComentario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarComentario.ForeColor = System.Drawing.Color.White;
            this.btnEnviarComentario.Location = new System.Drawing.Point(1288, 0);
            this.btnEnviarComentario.Margin = new System.Windows.Forms.Padding(0);
            this.btnEnviarComentario.Name = "btnEnviarComentario";
            this.btnEnviarComentario.Size = new System.Drawing.Size(176, 39);
            this.btnEnviarComentario.TabIndex = 1;
            this.btnEnviarComentario.Text = "Enviar";
            this.btnEnviarComentario.UseVisualStyleBackColor = false;
            // 
            // comentario1
            // 
            this.comentario1.BackColor = System.Drawing.Color.White;
            this.comentario1.Comentario = "Asegúrate de incluir los datos del sector B. Es clave para el hito del 30 de abri" +
            "l.";
            this.comentario1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comentario1.Fecha = "28 abr 2026";
            this.comentario1.ImagenPerfil = global::Vista.Properties.Recursos.AvatarUsuario;
            this.comentario1.Location = new System.Drawing.Point(0, 52);
            this.comentario1.Margin = new System.Windows.Forms.Padding(0);
            this.comentario1.Name = "comentario1";
            this.comentario1.Size = new System.Drawing.Size(1480, 80);
            this.comentario1.TabIndex = 1;
            this.comentario1.Usuario = "Juan Pérez";
            // 
            // pnlTituloComentarios
            // 
            this.pnlTituloComentarios.Controls.Add(this.lblComentarios);
            this.pnlTituloComentarios.Controls.Add(this.sepComentarios);
            this.pnlTituloComentarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloComentarios.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloComentarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTituloComentarios.Name = "pnlTituloComentarios";
            this.pnlTituloComentarios.Size = new System.Drawing.Size(1480, 52);
            this.pnlTituloComentarios.TabIndex = 2;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblComentarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblComentarios.Location = new System.Drawing.Point(18, 14);
            this.lblComentarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(244, 23);
            this.lblComentarios.TabIndex = 0;
            this.lblComentarios.Text = "Comentarios del coordinador";
            // 
            // sepComentarios
            // 
            this.sepComentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.sepComentarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sepComentarios.Location = new System.Drawing.Point(0, 51);
            this.sepComentarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sepComentarios.Name = "sepComentarios";
            this.sepComentarios.Size = new System.Drawing.Size(1480, 1);
            this.sepComentarios.TabIndex = 1;
            // 
            // tlpDerecha
            // 
            this.tlpDerecha.ColumnCount = 1;
            this.tlpDerecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDerecha.Controls.Add(this.pnlEstado, 0, 0);
            this.tlpDerecha.Controls.Add(this.pnlEvidencias, 0, 1);
            this.tlpDerecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDerecha.Location = new System.Drawing.Point(1510, 0);
            this.tlpDerecha.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tlpDerecha.Name = "tlpDerecha";
            this.tlpDerecha.RowCount = 3;
            this.tlpDerecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpDerecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpDerecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDerecha.Size = new System.Drawing.Size(518, 900);
            this.tlpDerecha.TabIndex = 1;
            // 
            // pnlEstado
            // 
            this.pnlEstado.BackColor = System.Drawing.Color.White;
            this.pnlEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEstado.Controls.Add(this.ucEstado);
            this.pnlEstado.Controls.Add(this.pnlTituloEstado);
            this.pnlEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstado.Location = new System.Drawing.Point(0, 0);
            this.pnlEstado.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Size = new System.Drawing.Size(518, 240);
            this.pnlEstado.TabIndex = 0;
            // 
            // ucEstado
            // 
            this.ucEstado.Avance = 60;
            this.ucEstado.BackColor = System.Drawing.Color.White;
            this.ucEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEstado.Estado = "En proceso";
            this.ucEstado.Evidencias = "1 archivo";
            this.ucEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ucEstado.Location = new System.Drawing.Point(0, 52);
            this.ucEstado.Margin = new System.Windows.Forms.Padding(0);
            this.ucEstado.Name = "ucEstado";
            this.ucEstado.Prioridad = "Alta";
            this.ucEstado.Size = new System.Drawing.Size(516, 186);
            this.ucEstado.TabIndex = 0;
            this.ucEstado.TextoBoton = "";
            this.ucEstado.Vencimiento = "Hoy";
            // 
            // pnlTituloEstado
            // 
            this.pnlTituloEstado.Controls.Add(this.lblEstadoSeccion);
            this.pnlTituloEstado.Controls.Add(this.sepEstado);
            this.pnlTituloEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloEstado.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTituloEstado.Name = "pnlTituloEstado";
            this.pnlTituloEstado.Size = new System.Drawing.Size(516, 52);
            this.pnlTituloEstado.TabIndex = 1;
            // 
            // lblEstadoSeccion
            // 
            this.lblEstadoSeccion.AutoSize = true;
            this.lblEstadoSeccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstadoSeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblEstadoSeccion.Location = new System.Drawing.Point(18, 14);
            this.lblEstadoSeccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoSeccion.Name = "lblEstadoSeccion";
            this.lblEstadoSeccion.Size = new System.Drawing.Size(63, 23);
            this.lblEstadoSeccion.TabIndex = 0;
            this.lblEstadoSeccion.Text = "Estado";
            // 
            // sepEstado
            // 
            this.sepEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.sepEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sepEstado.Location = new System.Drawing.Point(0, 51);
            this.sepEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sepEstado.Name = "sepEstado";
            this.sepEstado.Size = new System.Drawing.Size(516, 1);
            this.sepEstado.TabIndex = 1;
            // 
            // pnlEvidencias
            // 
            this.pnlEvidencias.BackColor = System.Drawing.Color.White;
            this.pnlEvidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEvidencias.Controls.Add(this.pnlFilasEvidencia);
            this.pnlEvidencias.Controls.Add(this.pnlTituloEvidencias);
            this.pnlEvidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEvidencias.Location = new System.Drawing.Point(0, 250);
            this.pnlEvidencias.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEvidencias.Name = "pnlEvidencias";
            this.pnlEvidencias.Size = new System.Drawing.Size(518, 165);
            this.pnlEvidencias.TabIndex = 1;
            // 
            // pnlFilasEvidencia
            // 
            this.pnlFilasEvidencia.Controls.Add(this.evidencia1);
            this.pnlFilasEvidencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilasEvidencia.Location = new System.Drawing.Point(0, 52);
            this.pnlFilasEvidencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFilasEvidencia.Name = "pnlFilasEvidencia";
            this.pnlFilasEvidencia.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pnlFilasEvidencia.Size = new System.Drawing.Size(516, 111);
            this.pnlFilasEvidencia.TabIndex = 0;
            // 
            // evidencia1
            // 
            this.evidencia1.BackColor = System.Drawing.Color.White;
            this.evidencia1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.evidencia1.DetalleArchivo = "28 abr 2026  ·  250 KB";
            this.evidencia1.Dock = System.Windows.Forms.DockStyle.Top;
            this.evidencia1.Location = new System.Drawing.Point(10, 10);
            this.evidencia1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.evidencia1.Name = "evidencia1";
            this.evidencia1.NombreArchivo = "informe_avance.pdf";
            this.evidencia1.Size = new System.Drawing.Size(496, 84);
            this.evidencia1.TabIndex = 0;
            // 
            // pnlTituloEvidencias
            // 
            this.pnlTituloEvidencias.Controls.Add(this.lblEvidencias);
            this.pnlTituloEvidencias.Controls.Add(this.sepEvidencias);
            this.pnlTituloEvidencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloEvidencias.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloEvidencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTituloEvidencias.Name = "pnlTituloEvidencias";
            this.pnlTituloEvidencias.Size = new System.Drawing.Size(516, 52);
            this.pnlTituloEvidencias.TabIndex = 1;
            // 
            // lblEvidencias
            // 
            this.lblEvidencias.AutoSize = true;
            this.lblEvidencias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEvidencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblEvidencias.Location = new System.Drawing.Point(18, 14);
            this.lblEvidencias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvidencias.Name = "lblEvidencias";
            this.lblEvidencias.Size = new System.Drawing.Size(151, 23);
            this.lblEvidencias.TabIndex = 0;
            this.lblEvidencias.Text = "Evidencia adjunta";
            // 
            // sepEvidencias
            // 
            this.sepEvidencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.sepEvidencias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sepEvidencias.Location = new System.Drawing.Point(0, 51);
            this.sepEvidencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sepEvidencias.Name = "sepEvidencias";
            this.sepEvidencias.Size = new System.Drawing.Size(516, 1);
            this.sepEvidencias.TabIndex = 1;
            // 
            // frmDetalleTareaGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2088, 1350);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.pnlViewport);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDetalleTareaGestor";
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
            this.pnlFilasHistorial.ResumeLayout(false);
            this.pnlTituloHistorial.ResumeLayout(false);
            this.pnlTituloHistorial.PerformLayout();
            this.pnlComentarios.ResumeLayout(false);
            this.pnlNuevoComentario.ResumeLayout(false);
            this.tlpNuevoComentario.ResumeLayout(false);
            this.tlpNuevoComentario.PerformLayout();
            this.pnlTituloComentarios.ResumeLayout(false);
            this.pnlTituloComentarios.PerformLayout();
            this.tlpDerecha.ResumeLayout(false);
            this.pnlEstado.ResumeLayout(false);
            this.pnlTituloEstado.ResumeLayout(false);
            this.pnlTituloEstado.PerformLayout();
            this.pnlEvidencias.ResumeLayout(false);
            this.pnlFilasEvidencia.ResumeLayout(false);
            this.pnlTituloEvidencias.ResumeLayout(false);
            this.pnlTituloEvidencias.PerformLayout();
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
        private System.Windows.Forms.Panel pnlNuevoComentario;
        private System.Windows.Forms.TableLayoutPanel tlpNuevoComentario;
        private System.Windows.Forms.TextBox txtNuevoComentario;
        private System.Windows.Forms.Button btnEnviarComentario;
    }
}
