namespace Vista
{
    partial class frmRegistrarAvance
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblBreadcrumbActual = new System.Windows.Forms.Label();
            this.lblBreadcrumbBase = new System.Windows.Forms.Label();
            this.pnlViewport = new System.Windows.Forms.Panel();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.tlpFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.cboProyecto = new System.Windows.Forms.ComboBox();
            this.lblTarea = new System.Windows.Forms.Label();
            this.cboTarea = new System.Windows.Forms.ComboBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.tlpPorcentaje = new System.Windows.Forms.TableLayoutPanel();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.pnlAvanceFondo = new System.Windows.Forms.Panel();
            this.tlpBarraPorcentaje = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAvance = new System.Windows.Forms.Panel();
            this.lblPorcentajeValor = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDificultades = new System.Windows.Forms.Label();
            this.txtDificultades = new System.Windows.Forms.TextBox();
            this.lblProximos = new System.Windows.Forms.Label();
            this.txtProximos = new System.Windows.Forms.TextBox();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.flpAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlHistorial = new System.Windows.Forms.Panel();
            this.pnlHeaderHistorial = new System.Windows.Forms.Panel();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.flpHistorial = new System.Windows.Forms.Panel();
            this.historial1 = new Vista.UCHistorialAvance();
            this.historial2 = new Vista.UCHistorialAvance();
            this.historial3 = new Vista.UCHistorialAvance();
            this.pnlTop.SuspendLayout();
            this.pnlViewport.SuspendLayout();
            this.pnlCanvas.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            this.tlpContenido.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.tlpFormulario.SuspendLayout();
            this.tlpPorcentaje.SuspendLayout();
            this.pnlAvanceFondo.SuspendLayout();
            this.tlpBarraPorcentaje.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.flpAcciones.SuspendLayout();
            this.pnlHistorial.SuspendLayout();
            this.pnlHeaderHistorial.SuspendLayout();
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
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(145, 151, 160);
            this.lblFecha.Location = new System.Drawing.Point(1590, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblBreadcrumbActual
            // 
            this.lblBreadcrumbActual.AutoSize = true;
            this.lblBreadcrumbActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreadcrumbActual.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(101, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Size = new System.Drawing.Size(124, 20);
            this.lblBreadcrumbActual.TabIndex = 1;
            this.lblBreadcrumbActual.Text = "Registrar avance";
            // 
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(145, 151, 160);
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.Size = new System.Drawing.Size(100, 20);
            this.lblBreadcrumbBase.TabIndex = 0;
            this.lblBreadcrumbBase.Text = "Mi avance >";
            // 
            // pnlViewport
            // 
            this.pnlViewport.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlViewport.Controls.Add(this.pnlCanvas);
            this.pnlViewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewport.Location = new System.Drawing.Point(0, 43);
            this.pnlViewport.Name = "pnlViewport";
            this.pnlViewport.Size = new System.Drawing.Size(1670, 1037);
            this.pnlViewport.TabIndex = 1;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.AutoScroll = true;
            this.pnlCanvas.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlCanvas.Controls.Add(this.tlpPrincipal);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1670, 1037);
            this.pnlCanvas.TabIndex = 0;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.pnlCabecera, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpContenido, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(24);
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 700F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1653, 818);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Controls.Add(this.lblSubtitulo);
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCabecera.Location = new System.Drawing.Point(24, 24);
            this.pnlCabecera.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1605, 70);
            this.pnlCabecera.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(244, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar avance";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblSubtitulo.Location = new System.Drawing.Point(3, 43);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(335, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Actualiza el progreso de tus tareas asignadas";
            // 
            // tlpContenido
            // 
            this.tlpContenido.ColumnCount = 2;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpContenido.Controls.Add(this.pnlFormulario, 0, 0);
            this.tlpContenido.Controls.Add(this.pnlHistorial, 1, 0);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(24, 94);
            this.tlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.RowCount = 1;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Size = new System.Drawing.Size(1605, 700);
            this.tlpContenido.TabIndex = 1;
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BackColor = System.Drawing.Color.White;
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormulario.Controls.Add(this.tlpFormulario);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlFormulario.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(1143, 700);
            this.pnlFormulario.TabIndex = 0;
            // 
            // tlpFormulario
            // 
            this.tlpFormulario.ColumnCount = 2;
            this.tlpFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFormulario.Controls.Add(this.lblSeccion, 0, 0);
            this.tlpFormulario.Controls.Add(this.lblProyecto, 0, 1);
            this.tlpFormulario.Controls.Add(this.cboProyecto, 0, 2);
            this.tlpFormulario.Controls.Add(this.lblTarea, 0, 3);
            this.tlpFormulario.Controls.Add(this.cboTarea, 0, 4);
            this.tlpFormulario.Controls.Add(this.lblPorcentaje, 0, 5);
            this.tlpFormulario.Controls.Add(this.lblFechaRegistro, 1, 5);
            this.tlpFormulario.Controls.Add(this.tlpPorcentaje, 0, 6);
            this.tlpFormulario.Controls.Add(this.dtpFecha, 1, 6);
            this.tlpFormulario.Controls.Add(this.lblDescripcion, 0, 7);
            this.tlpFormulario.Controls.Add(this.txtDescripcion, 0, 8);
            this.tlpFormulario.Controls.Add(this.lblDificultades, 0, 9);
            this.tlpFormulario.Controls.Add(this.txtDificultades, 0, 10);
            this.tlpFormulario.Controls.Add(this.lblProximos, 0, 11);
            this.tlpFormulario.Controls.Add(this.txtProximos, 0, 12);
            this.tlpFormulario.Controls.Add(this.tlpBotones, 0, 13);
            this.tlpFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFormulario.Location = new System.Drawing.Point(0, 0);
            this.tlpFormulario.Name = "tlpFormulario";
            this.tlpFormulario.Padding = new System.Windows.Forms.Padding(20);
            this.tlpFormulario.RowCount = 14;
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFormulario.SetColumnSpan(this.lblSeccion, 2);
            this.tlpFormulario.SetColumnSpan(this.lblProyecto, 2);
            this.tlpFormulario.SetColumnSpan(this.cboProyecto, 2);
            this.tlpFormulario.SetColumnSpan(this.lblTarea, 2);
            this.tlpFormulario.SetColumnSpan(this.cboTarea, 2);
            this.tlpFormulario.SetColumnSpan(this.lblDescripcion, 2);
            this.tlpFormulario.SetColumnSpan(this.txtDescripcion, 2);
            this.tlpFormulario.SetColumnSpan(this.lblDificultades, 2);
            this.tlpFormulario.SetColumnSpan(this.txtDificultades, 2);
            this.tlpFormulario.SetColumnSpan(this.lblProximos, 2);
            this.tlpFormulario.SetColumnSpan(this.txtProximos, 2);
            this.tlpFormulario.SetColumnSpan(this.tlpBotones, 2);
            this.tlpFormulario.Size = new System.Drawing.Size(1141, 698);
            this.tlpFormulario.TabIndex = 0;
            // 
            // lblSeccion
            // 
            this.lblSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSeccion.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblSeccion.Location = new System.Drawing.Point(20, 20);
            this.lblSeccion.Margin = new System.Windows.Forms.Padding(0);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(1101, 42);
            this.lblSeccion.TabIndex = 0;
            this.lblSeccion.Text = "Nuevo registro de avance";
            this.lblSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProyecto
            // 
            this.lblProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProyecto.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProyecto.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblProyecto.Location = new System.Drawing.Point(20, 62);
            this.lblProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(1101, 24);
            this.lblProyecto.TabIndex = 1;
            this.lblProyecto.Text = "Proyecto *";
            this.lblProyecto.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboProyecto
            // 
            this.cboProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProyecto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboProyecto.FormattingEnabled = true;
            this.cboProyecto.Location = new System.Drawing.Point(20, 86);
            this.cboProyecto.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.cboProyecto.Name = "cboProyecto";
            this.cboProyecto.SelectedIndexChanged += new System.EventHandler(this.cboProyecto_SelectedIndexChanged);
            this.cboProyecto.Size = new System.Drawing.Size(1101, 28);
            this.cboProyecto.TabIndex = 0;
            // 
            // lblTarea
            // 
            this.lblTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTarea.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTarea.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTarea.Location = new System.Drawing.Point(20, 126);
            this.lblTarea.Margin = new System.Windows.Forms.Padding(0);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(1101, 24);
            this.lblTarea.TabIndex = 3;
            this.lblTarea.Text = "Tarea asignada *";
            this.lblTarea.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboTarea
            // 
            this.cboTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTarea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTarea.FormattingEnabled = true;
            this.cboTarea.Location = new System.Drawing.Point(20, 150);
            this.cboTarea.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.cboTarea.Name = "cboTarea";
            this.cboTarea.SelectedIndexChanged += new System.EventHandler(this.cboTarea_SelectedIndexChanged);
            this.cboTarea.Size = new System.Drawing.Size(1101, 28);
            this.cboTarea.TabIndex = 1;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPorcentaje.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPorcentaje.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblPorcentaje.Location = new System.Drawing.Point(20, 190);
            this.lblPorcentaje.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(540, 24);
            this.lblPorcentaje.TabIndex = 5;
            this.lblPorcentaje.Text = "Porcentaje de avance *";
            this.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFechaRegistro.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblFechaRegistro.Location = new System.Drawing.Point(580, 190);
            this.lblFechaRegistro.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(541, 24);
            this.lblFechaRegistro.TabIndex = 6;
            this.lblFechaRegistro.Text = "Fecha de registro *";
            this.lblFechaRegistro.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tlpPorcentaje
            // 
            this.tlpPorcentaje.ColumnCount = 3;
            this.tlpPorcentaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpPorcentaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPorcentaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpPorcentaje.Controls.Add(this.txtPorcentaje, 0, 0);
            this.tlpPorcentaje.Controls.Add(this.pnlAvanceFondo, 1, 0);
            this.tlpPorcentaje.Controls.Add(this.lblPorcentajeValor, 2, 0);
            this.tlpPorcentaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPorcentaje.Location = new System.Drawing.Point(20, 214);
            this.tlpPorcentaje.Margin = new System.Windows.Forms.Padding(0, 0, 10, 4);
            this.tlpPorcentaje.Name = "tlpPorcentaje";
            this.tlpPorcentaje.RowCount = 1;
            this.tlpPorcentaje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPorcentaje.Size = new System.Drawing.Size(540, 38);
            this.tlpPorcentaje.TabIndex = 7;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPorcentaje.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentaje_KeyPress);
            this.txtPorcentaje.Location = new System.Drawing.Point(0, 4);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(0, 4, 0, 7);
            this.txtPorcentaje.MaxLength = 3;
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.ShortcutsEnabled = false;
            this.txtPorcentaje.Size = new System.Drawing.Size(80, 27);
            this.txtPorcentaje.TabIndex = 2;
            this.txtPorcentaje.Text = "0";
            this.txtPorcentaje.TextChanged += new System.EventHandler(this.txtPorcentaje_TextChanged);
            // 
            // pnlAvanceFondo
            // 
            this.pnlAvanceFondo.BackColor = System.Drawing.Color.FromArgb(225, 230, 236);
            this.pnlAvanceFondo.Controls.Add(this.tlpBarraPorcentaje);
            this.pnlAvanceFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAvanceFondo.Location = new System.Drawing.Point(92, 15);
            this.pnlAvanceFondo.Margin = new System.Windows.Forms.Padding(12, 15, 12, 15);
            this.pnlAvanceFondo.Name = "pnlAvanceFondo";
            this.pnlAvanceFondo.Size = new System.Drawing.Size(384, 8);
            this.pnlAvanceFondo.TabIndex = 1;
            // 
            // tlpBarraPorcentaje
            // 
            this.tlpBarraPorcentaje.ColumnCount = 2;
            this.tlpBarraPorcentaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpBarraPorcentaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpBarraPorcentaje.Controls.Add(this.pnlAvance, 0, 0);
            this.tlpBarraPorcentaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBarraPorcentaje.Location = new System.Drawing.Point(0, 0);
            this.tlpBarraPorcentaje.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBarraPorcentaje.Name = "tlpBarraPorcentaje";
            this.tlpBarraPorcentaje.RowCount = 1;
            this.tlpBarraPorcentaje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBarraPorcentaje.Size = new System.Drawing.Size(384, 8);
            this.tlpBarraPorcentaje.TabIndex = 0;
            // 
            // pnlAvance
            // 
            this.pnlAvance.BackColor = System.Drawing.Color.FromArgb(240, 128, 49);
            this.pnlAvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAvance.Location = new System.Drawing.Point(0, 0);
            this.pnlAvance.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAvance.Name = "pnlAvance";
            this.pnlAvance.Size = new System.Drawing.Size(230, 8);
            this.pnlAvance.TabIndex = 0;
            // 
            // lblPorcentajeValor
            // 
            this.lblPorcentajeValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPorcentajeValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPorcentajeValor.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblPorcentajeValor.Location = new System.Drawing.Point(488, 0);
            this.lblPorcentajeValor.Margin = new System.Windows.Forms.Padding(0);
            this.lblPorcentajeValor.Name = "lblPorcentajeValor";
            this.lblPorcentajeValor.Size = new System.Drawing.Size(52, 38);
            this.lblPorcentajeValor.TabIndex = 2;
            this.lblPorcentajeValor.Text = "60%";
            this.lblPorcentajeValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(580, 218);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(10, 4, 0, 7);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(541, 27);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblDescripcion.Location = new System.Drawing.Point(20, 256);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(1101, 24);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripción del avance *";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.Location = new System.Drawing.Point(20, 280);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtDescripcion.MaxLength = 1000;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.ShortcutsEnabled = false;
            this.txtDescripcion.Size = new System.Drawing.Size(1101, 90);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblDificultades
            // 
            this.lblDificultades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDificultades.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDificultades.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblDificultades.Location = new System.Drawing.Point(20, 380);
            this.lblDificultades.Margin = new System.Windows.Forms.Padding(0);
            this.lblDificultades.Name = "lblDificultades";
            this.lblDificultades.Size = new System.Drawing.Size(1101, 24);
            this.lblDificultades.TabIndex = 11;
            this.lblDificultades.Text = "Dificultades encontradas";
            this.lblDificultades.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDificultades
            // 
            this.txtDificultades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDificultades.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDificultades.Location = new System.Drawing.Point(20, 404);
            this.txtDificultades.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtDificultades.MaxLength = 500;
            this.txtDificultades.Multiline = true;
            this.txtDificultades.Name = "txtDificultades";
            this.txtDificultades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDificultades.ShortcutsEnabled = false;
            this.txtDificultades.Size = new System.Drawing.Size(1101, 90);
            this.txtDificultades.TabIndex = 5;
            // 
            // lblProximos
            // 
            this.lblProximos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProximos.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProximos.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblProximos.Location = new System.Drawing.Point(20, 504);
            this.lblProximos.Margin = new System.Windows.Forms.Padding(0);
            this.lblProximos.Name = "lblProximos";
            this.lblProximos.Size = new System.Drawing.Size(1101, 24);
            this.lblProximos.TabIndex = 13;
            this.lblProximos.Text = "Próximos pasos";
            this.lblProximos.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtProximos
            // 
            this.txtProximos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProximos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProximos.Location = new System.Drawing.Point(20, 528);
            this.txtProximos.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtProximos.MaxLength = 500;
            this.txtProximos.Multiline = true;
            this.txtProximos.Name = "txtProximos";
            this.txtProximos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProximos.ShortcutsEnabled = false;
            this.txtProximos.Size = new System.Drawing.Size(1101, 90);
            this.txtProximos.TabIndex = 6;
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.btnAdjuntar, 0, 0);
            this.tlpBotones.Controls.Add(this.flpAcciones, 1, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpBotones.Location = new System.Drawing.Point(20, 750);
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(1101, 38);
            this.tlpBotones.TabIndex = 15;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdjuntar.BackColor = System.Drawing.Color.White;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            this.btnAdjuntar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(142, 160, 181);
            this.btnAdjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjuntar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdjuntar.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.btnAdjuntar.Location = new System.Drawing.Point(0, 2);
            this.btnAdjuntar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdjuntar.MinimumSize = new System.Drawing.Size(140, 34);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(150, 34);
            this.btnAdjuntar.TabIndex = 7;
            this.btnAdjuntar.Text = "Adjuntar evidencia";
            this.btnAdjuntar.UseVisualStyleBackColor = false;
            // 
            // flpAcciones
            // 
            this.flpAcciones.Controls.Add(this.btnGuardar);
            this.flpAcciones.Controls.Add(this.btnCancelar);
            this.flpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAcciones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpAcciones.Location = new System.Drawing.Point(550, 0);
            this.flpAcciones.Margin = new System.Windows.Forms.Padding(0);
            this.flpAcciones.Name = "flpAcciones";
            this.flpAcciones.Size = new System.Drawing.Size(551, 38);
            this.flpAcciones.TabIndex = 1;
            this.flpAcciones.WrapContents = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(421, 1);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(8, 1, 0, 1);
            this.btnGuardar.MinimumSize = new System.Drawing.Size(130, 36);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 36);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar avance";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(142, 160, 181);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.btnCancelar.Location = new System.Drawing.Point(303, 1);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(8, 1, 0, 1);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(160, 36);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pnlHistorial
            // 
            this.pnlHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHistorial.BackColor = System.Drawing.Color.White;
            this.pnlHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHistorial.Controls.Add(this.flpHistorial);
            this.pnlHistorial.Controls.Add(this.pnlHeaderHistorial);
            this.pnlHistorial.Location = new System.Drawing.Point(1155, 0);
            this.pnlHistorial.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistorial.Name = "pnlHistorial";
            this.pnlHistorial.Size = new System.Drawing.Size(450, 330);
            this.pnlHistorial.TabIndex = 1;
            // 
            // pnlHeaderHistorial
            // 
            this.pnlHeaderHistorial.BackColor = System.Drawing.Color.White;
            this.pnlHeaderHistorial.Controls.Add(this.lblHistorial);
            this.pnlHeaderHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderHistorial.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderHistorial.Name = "pnlHeaderHistorial";
            this.pnlHeaderHistorial.Size = new System.Drawing.Size(448, 48);
            this.pnlHeaderHistorial.TabIndex = 0;
            // 
            // lblHistorial
            // 
            this.lblHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHistorial.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblHistorial.Location = new System.Drawing.Point(0, 0);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblHistorial.Size = new System.Drawing.Size(448, 48);
            this.lblHistorial.TabIndex = 0;
            this.lblHistorial.Text = "Historial de mis avances";
            this.lblHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpHistorial
            // 
            this.flpHistorial.AutoScroll = true;
            this.flpHistorial.Controls.Add(this.historial3);
            this.flpHistorial.Controls.Add(this.historial2);
            this.flpHistorial.Controls.Add(this.historial1);
            this.flpHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHistorial.Location = new System.Drawing.Point(0, 48);
            this.flpHistorial.Name = "flpHistorial";
            this.flpHistorial.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.flpHistorial.Size = new System.Drawing.Size(448, 280);
            this.flpHistorial.TabIndex = 1;
            // 
            // historial1
            // 
            this.historial1.ColorPunto = System.Drawing.Color.FromArgb(0, 105, 240);
            this.historial1.Descripcion = "Secciones 1 y 2 completadas";
            this.historial1.Dock = System.Windows.Forms.DockStyle.Top;
            this.historial1.Fecha = "28 abr";
            this.historial1.Location = new System.Drawing.Point(14, 12);
            this.historial1.Margin = new System.Windows.Forms.Padding(0);
            this.historial1.Name = "historial1";
            this.historial1.Porcentaje = "60%";
            this.historial1.Proyecto = "Proyecto 1";
            this.historial1.Size = new System.Drawing.Size(400, 86);
            this.historial1.TabIndex = 0;
            this.historial1.Tarea = "Tarea 1";
            // 
            // historial2
            // 
            this.historial2.ColorPunto = System.Drawing.Color.FromArgb(0, 105, 240);
            this.historial2.Descripcion = "Inicio de recuperación de datos";
            this.historial2.Dock = System.Windows.Forms.DockStyle.Top;
            this.historial2.Fecha = "21 abr";
            this.historial2.Location = new System.Drawing.Point(14, 98);
            this.historial2.Margin = new System.Windows.Forms.Padding(0);
            this.historial2.Name = "historial2";
            this.historial2.Porcentaje = "35%";
            this.historial2.Proyecto = "Proyecto 1";
            this.historial2.Size = new System.Drawing.Size(400, 86);
            this.historial2.TabIndex = 1;
            this.historial2.Tarea = "Tarea 2";
            // 
            // historial3
            // 
            this.historial3.ColorPunto = System.Drawing.Color.FromArgb(0, 105, 240);
            this.historial3.Descripcion = "Inicio de tarea";
            this.historial3.Dock = System.Windows.Forms.DockStyle.Top;
            this.historial3.Fecha = "18 abr";
            this.historial3.Location = new System.Drawing.Point(14, 184);
            this.historial3.Margin = new System.Windows.Forms.Padding(0);
            this.historial3.Name = "historial3";
            this.historial3.Porcentaje = "20%";
            this.historial3.Proyecto = "Proyecto 2";
            this.historial3.Size = new System.Drawing.Size(400, 86);
            this.historial3.TabIndex = 2;
            this.historial3.Tarea = "Tarea 3";
            // 
            // frmRegistrarAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.Controls.Add(this.pnlViewport);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.frmRegistrarAvance_Load);
            this.Name = "frmRegistrarAvance";
            this.Text = "Registrar avance";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlViewport.ResumeLayout(false);
            this.pnlCanvas.ResumeLayout(false);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.tlpContenido.ResumeLayout(false);
            this.pnlFormulario.ResumeLayout(false);
            this.tlpFormulario.ResumeLayout(false);
            this.tlpFormulario.PerformLayout();
            this.tlpPorcentaje.ResumeLayout(false);
            this.tlpPorcentaje.PerformLayout();
            this.pnlAvanceFondo.ResumeLayout(false);
            this.tlpBarraPorcentaje.ResumeLayout(false);
            this.tlpBotones.ResumeLayout(false);
            this.flpAcciones.ResumeLayout(false);
            this.pnlHeaderHistorial.ResumeLayout(false);
            this.pnlHistorial.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblBreadcrumbActual;
        private System.Windows.Forms.Label lblBreadcrumbBase;
        private System.Windows.Forms.Panel pnlViewport;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.TableLayoutPanel tlpFormulario;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.ComboBox cboProyecto;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.ComboBox cboTarea;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.TableLayoutPanel tlpPorcentaje;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Panel pnlAvanceFondo;
        private System.Windows.Forms.TableLayoutPanel tlpBarraPorcentaje;
        private System.Windows.Forms.Panel pnlAvance;
        private System.Windows.Forms.Label lblPorcentajeValor;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDificultades;
        private System.Windows.Forms.TextBox txtDificultades;
        private System.Windows.Forms.Label lblProximos;
        private System.Windows.Forms.TextBox txtProximos;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.FlowLayoutPanel flpAcciones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlHistorial;
        private System.Windows.Forms.Panel pnlHeaderHistorial;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Panel flpHistorial;
        private Vista.UCHistorialAvance historial1;
        private Vista.UCHistorialAvance historial2;
        private Vista.UCHistorialAvance historial3;
    }
}
