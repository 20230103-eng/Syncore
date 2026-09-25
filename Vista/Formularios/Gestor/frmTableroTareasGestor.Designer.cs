namespace Vista
{
    partial class frmTableroTareasGestor
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
            this.lblBreadcrumbBase = new System.Windows.Forms.Label();
            this.lblBreadcrumbActual = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlViewport = new System.Windows.Forms.Panel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCabecera = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitulos = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.flpFiltros = new System.Windows.Forms.FlowLayoutPanel();
            this.cboProyecto = new System.Windows.Forms.ComboBox();
            this.cboResponsable = new System.Windows.Forms.ComboBox();
            this.btnNuevaTarea = new System.Windows.Forms.Button();
            this.pnlColumnas = new System.Windows.Forms.TableLayoutPanel();
            this.pnlColumna1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEncabezado1 = new System.Windows.Forms.Panel();
            this.lblEstado1 = new System.Windows.Forms.Label();
            this.lblCantidad1 = new System.Windows.Forms.Label();
            this.flpEstado1 = new System.Windows.Forms.Panel();
            this.pnlColumna2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEncabezado2 = new System.Windows.Forms.Panel();
            this.lblEstado2 = new System.Windows.Forms.Label();
            this.lblCantidad2 = new System.Windows.Forms.Label();
            this.flpEstado2 = new System.Windows.Forms.Panel();
            this.pnlColumna3 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEncabezado3 = new System.Windows.Forms.Panel();
            this.lblEstado3 = new System.Windows.Forms.Label();
            this.lblCantidad3 = new System.Windows.Forms.Label();
            this.flpEstado3 = new System.Windows.Forms.Panel();
            this.pnlColumna4 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEncabezado4 = new System.Windows.Forms.Panel();
            this.lblEstado4 = new System.Windows.Forms.Label();
            this.lblCantidad4 = new System.Windows.Forms.Label();
            this.flpEstado4 = new System.Windows.Forms.Panel();
            this.pnlColumna5 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEncabezado5 = new System.Windows.Forms.Panel();
            this.lblEstado5 = new System.Windows.Forms.Label();
            this.lblCantidad5 = new System.Windows.Forms.Label();
            this.flpEstado5 = new System.Windows.Forms.Panel();
            this.tarea1_1 = new Vista.UCTarjetaTarea();
            this.tarea1_2 = new Vista.UCTarjetaTarea();
            this.tarea1_3 = new Vista.UCTarjetaTarea();
            this.tarea2_1 = new Vista.UCTarjetaTarea();
            this.tarea2_2 = new Vista.UCTarjetaTarea();
            this.tarea3_1 = new Vista.UCTarjetaTarea();
            this.tarea3_2 = new Vista.UCTarjetaTarea();
            this.tarea4_1 = new Vista.UCTarjetaTarea();
            this.tarea5_1 = new Vista.UCTarjetaTarea();
            this.tarea5_2 = new Vista.UCTarjetaTarea();
            this.pnlTop.SuspendLayout();
            this.pnlViewport.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.tlpCabecera.SuspendLayout();
            this.pnlTitulos.SuspendLayout();
            this.flpFiltros.SuspendLayout();
            this.pnlColumnas.SuspendLayout();
            this.pnlColumna1.SuspendLayout();
            this.pnlEncabezado1.SuspendLayout();
            this.flpEstado1.SuspendLayout();
            this.pnlColumna2.SuspendLayout();
            this.pnlEncabezado2.SuspendLayout();
            this.flpEstado2.SuspendLayout();
            this.pnlColumna3.SuspendLayout();
            this.pnlEncabezado3.SuspendLayout();
            this.flpEstado3.SuspendLayout();
            this.pnlColumna4.SuspendLayout();
            this.pnlEncabezado4.SuspendLayout();
            this.flpEstado4.SuspendLayout();
            this.pnlColumna5.SuspendLayout();
            this.pnlEncabezado5.SuspendLayout();
            this.flpEstado5.SuspendLayout();
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
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(145, 151, 160);
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.Size = new System.Drawing.Size(58, 20);
            this.lblBreadcrumbBase.TabIndex = 0;
            this.lblBreadcrumbBase.Text = "Tareas >";
            // 
            // lblBreadcrumbActual
            // 
            this.lblBreadcrumbActual.AutoSize = true;
            this.lblBreadcrumbActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreadcrumbActual.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(78, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Size = new System.Drawing.Size(130, 20);
            this.lblBreadcrumbActual.TabIndex = 1;
            this.lblBreadcrumbActual.Text = "Tablero de tareas";
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
            // pnlViewport
            // 
            this.pnlViewport.AutoScroll = true;
            this.pnlViewport.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlViewport.Controls.Add(this.tlpPrincipal);
            this.pnlViewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewport.Location = new System.Drawing.Point(0, 43);
            this.pnlViewport.Name = "pnlViewport";
            this.pnlViewport.Padding = new System.Windows.Forms.Padding(24);
            this.pnlViewport.Size = new System.Drawing.Size(1670, 1037);
            this.pnlViewport.TabIndex = 1;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.AutoSize = true;
            this.tlpPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tlpCabecera, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnlColumnas, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPrincipal.Location = new System.Drawing.Point(24, 24);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpPrincipal.Size = new System.Drawing.Size(1622, 503);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // tlpCabecera
            // 
            this.tlpCabecera.ColumnCount = 2;
            this.tlpCabecera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tlpCabecera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tlpCabecera.Controls.Add(this.pnlTitulos, 0, 0);
            this.tlpCabecera.Controls.Add(this.flpFiltros, 1, 0);
            this.tlpCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCabecera.Location = new System.Drawing.Point(0, 0);
            this.tlpCabecera.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCabecera.Name = "tlpCabecera";
            this.tlpCabecera.RowCount = 1;
            this.tlpCabecera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCabecera.Size = new System.Drawing.Size(1622, 80);
            this.tlpCabecera.TabIndex = 0;
            // 
            // pnlTitulos
            // 
            this.pnlTitulos.Controls.Add(this.lblSubtitulo);
            this.pnlTitulos.Controls.Add(this.lblTitulo);
            this.pnlTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitulos.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulos.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitulos.Name = "pnlTitulos";
            this.pnlTitulos.Size = new System.Drawing.Size(778, 80);
            this.pnlTitulos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(275, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Tablero de tareas";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblSubtitulo.Location = new System.Drawing.Point(3, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(260, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Todos los proyectos";
            // 
            // flpFiltros
            // 
            this.flpFiltros.AutoSize = true;
            this.flpFiltros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpFiltros.Controls.Add(this.btnNuevaTarea);
            this.flpFiltros.Controls.Add(this.cboResponsable);
            this.flpFiltros.Controls.Add(this.cboProyecto);
            this.flpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFiltros.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpFiltros.Location = new System.Drawing.Point(778, 0);
            this.flpFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.flpFiltros.Name = "flpFiltros";
            this.flpFiltros.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.flpFiltros.Size = new System.Drawing.Size(844, 80);
            this.flpFiltros.TabIndex = 1;
            this.flpFiltros.WrapContents = false;
            // 
            // cboProyecto
            // 
            this.cboProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProyecto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboProyecto.FormattingEnabled = true;
            this.cboProyecto.Items.AddRange(new object[] {
            "Todos los proyectos",
            "Proyecto 1",
            "Proyecto 2",
            "Proyecto 3"});
            this.cboProyecto.Margin = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.cboProyecto.Name = "cboProyecto";
            this.cboProyecto.Size = new System.Drawing.Size(190, 28);
            this.cboProyecto.TabIndex = 0;
            // 
            // cboResponsable
            // 
            this.cboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResponsable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboResponsable.FormattingEnabled = true;
            this.cboResponsable.Items.AddRange(new object[] {
            "Todos los responsables",
            "Juan Pérez",
            "Alex Zometa",
            "Erick Mercado"});
            this.cboResponsable.Margin = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.cboResponsable.Name = "cboResponsable";
            this.cboResponsable.Size = new System.Drawing.Size(190, 28);
            this.cboResponsable.TabIndex = 1;
            // 
            // btnNuevaTarea
            // 
            this.btnNuevaTarea.BackColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnNuevaTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaTarea.FlatAppearance.BorderSize = 0;
            this.btnNuevaTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaTarea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevaTarea.ForeColor = System.Drawing.Color.White;
            this.btnNuevaTarea.Margin = new System.Windows.Forms.Padding(8, 3, 0, 0);
            this.btnNuevaTarea.Name = "btnNuevaTarea";
            this.btnNuevaTarea.Size = new System.Drawing.Size(145, 34);
            this.btnNuevaTarea.TabIndex = 2;
            this.btnNuevaTarea.Text = "+ Nueva tarea";
            this.btnNuevaTarea.UseVisualStyleBackColor = false;
            // 
            // pnlColumnas
            // 
            this.pnlColumnas.AutoSize = false;
            this.pnlColumnas.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlColumnas.ColumnCount = 5;
            this.pnlColumnas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlColumnas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlColumnas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlColumnas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlColumnas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlColumnas.Controls.Add(this.pnlColumna1, 0, 0);
            this.pnlColumnas.Controls.Add(this.pnlColumna2, 1, 0);
            this.pnlColumnas.Controls.Add(this.pnlColumna3, 2, 0);
            this.pnlColumnas.Controls.Add(this.pnlColumna4, 3, 0);
            this.pnlColumnas.Controls.Add(this.pnlColumna5, 4, 0);
            this.pnlColumnas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlColumnas.Location = new System.Drawing.Point(0, 80);
            this.pnlColumnas.Margin = new System.Windows.Forms.Padding(0);
            this.pnlColumnas.Name = "pnlColumnas";
            this.pnlColumnas.RowCount = 1;
            this.pnlColumnas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlColumnas.Size = new System.Drawing.Size(1622, 399);
            this.pnlColumnas.TabIndex = 1;
            // 
            // pnlColumna1
            // 
            this.pnlColumna1.AutoSize = false;
            this.pnlColumna1.BackColor = System.Drawing.Color.White;
            this.pnlColumna1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlColumna1.ColumnCount = 1;
            this.pnlColumna1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlColumna1.Controls.Add(this.pnlEncabezado1, 0, 0);
            this.pnlColumna1.Controls.Add(this.flpEstado1, 0, 1);
            this.pnlColumna1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColumna1.Location = new System.Drawing.Point(0, 0);
            this.pnlColumna1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnlColumna1.Name = "pnlColumna1";
            this.pnlColumna1.RowCount = 2;
            this.pnlColumna1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.pnlColumna1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlColumna1.Size = new System.Drawing.Size(312, 398);
            this.pnlColumna1.TabIndex = 0;
            // 
            // pnlEncabezado1
            // 
            this.pnlEncabezado1.BackColor = System.Drawing.Color.FromArgb(238, 240, 243);
            this.pnlEncabezado1.Controls.Add(this.lblCantidad1);
            this.pnlEncabezado1.Controls.Add(this.lblEstado1);
            this.pnlEncabezado1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEncabezado1.Location = new System.Drawing.Point(1, 1);
            this.pnlEncabezado1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEncabezado1.Name = "pnlEncabezado1";
            this.pnlEncabezado1.Size = new System.Drawing.Size(310, 47);
            this.pnlEncabezado1.TabIndex = 0;
            // 
            // lblEstado1
            // 
            this.lblEstado1.AutoSize = true;
            this.lblEstado1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado1.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblEstado1.Location = new System.Drawing.Point(12, 13);
            this.lblEstado1.Name = "lblEstado1";
            this.lblEstado1.Size = new System.Drawing.Size(80, 20);
            this.lblEstado1.TabIndex = 0;
            this.lblEstado1.Text = "Pendiente";
            // 
            // lblCantidad1
            // 
            this.lblCantidad1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad1.AutoSize = true;
            this.lblCantidad1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad1.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblCantidad1.Location = new System.Drawing.Point(286, 13);
            this.lblCantidad1.Name = "lblCantidad1";
            this.lblCantidad1.Size = new System.Drawing.Size(17, 20);
            this.lblCantidad1.TabIndex = 1;
            this.lblCantidad1.Text = "3";
            // 
            // flpEstado1
            // 
            this.flpEstado1.AutoScroll = true;
            this.flpEstado1.BackColor = System.Drawing.Color.White;
            this.flpEstado1.Controls.Add(this.tarea1_3);
            this.flpEstado1.Controls.Add(this.tarea1_2);
            this.flpEstado1.Controls.Add(this.tarea1_1);
            this.flpEstado1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEstado1.Location = new System.Drawing.Point(1, 48);
            this.flpEstado1.Margin = new System.Windows.Forms.Padding(0);
            this.flpEstado1.Name = "flpEstado1";
            this.flpEstado1.Padding = new System.Windows.Forms.Padding(6);
            this.flpEstado1.Size = new System.Drawing.Size(310, 350);
            this.flpEstado1.TabIndex = 1;
            // 
            // pnlColumna2
            // 
            this.pnlColumna2.AutoSize = false;
            this.pnlColumna2.BackColor = System.Drawing.Color.White;
            this.pnlColumna2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlColumna2.ColumnCount = 1;
            this.pnlColumna2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlColumna2.Controls.Add(this.pnlEncabezado2, 0, 0);
            this.pnlColumna2.Controls.Add(this.flpEstado2, 0, 1);
            this.pnlColumna2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColumna2.Location = new System.Drawing.Point(320, 0);
            this.pnlColumna2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlColumna2.Name = "pnlColumna2";
            this.pnlColumna2.RowCount = 2;
            this.pnlColumna2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.pnlColumna2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlColumna2.Size = new System.Drawing.Size(312, 285);
            this.pnlColumna2.TabIndex = 1;
            // 
            // pnlEncabezado2
            // 
            this.pnlEncabezado2.BackColor = System.Drawing.Color.FromArgb(255, 246, 218);
            this.pnlEncabezado2.Controls.Add(this.lblCantidad2);
            this.pnlEncabezado2.Controls.Add(this.lblEstado2);
            this.pnlEncabezado2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEncabezado2.Location = new System.Drawing.Point(1, 1);
            this.pnlEncabezado2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEncabezado2.Name = "pnlEncabezado2";
            this.pnlEncabezado2.Size = new System.Drawing.Size(310, 47);
            this.pnlEncabezado2.TabIndex = 0;
            // 
            // lblEstado2
            // 
            this.lblEstado2.AutoSize = true;
            this.lblEstado2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado2.ForeColor = System.Drawing.Color.FromArgb(215, 145, 0);
            this.lblEstado2.Location = new System.Drawing.Point(12, 13);
            this.lblEstado2.Name = "lblEstado2";
            this.lblEstado2.Size = new System.Drawing.Size(80, 20);
            this.lblEstado2.TabIndex = 0;
            this.lblEstado2.Text = "En progreso";
            // 
            // lblCantidad2
            // 
            this.lblCantidad2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad2.AutoSize = true;
            this.lblCantidad2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad2.ForeColor = System.Drawing.Color.FromArgb(215, 145, 0);
            this.lblCantidad2.Location = new System.Drawing.Point(286, 13);
            this.lblCantidad2.Name = "lblCantidad2";
            this.lblCantidad2.Size = new System.Drawing.Size(17, 20);
            this.lblCantidad2.TabIndex = 1;
            this.lblCantidad2.Text = "2";
            // 
            // flpEstado2
            // 
            this.flpEstado2.AutoScroll = true;
            this.flpEstado2.BackColor = System.Drawing.Color.White;
            this.flpEstado2.Controls.Add(this.tarea2_2);
            this.flpEstado2.Controls.Add(this.tarea2_1);
            this.flpEstado2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEstado2.Location = new System.Drawing.Point(1, 48);
            this.flpEstado2.Margin = new System.Windows.Forms.Padding(0);
            this.flpEstado2.Name = "flpEstado2";
            this.flpEstado2.Padding = new System.Windows.Forms.Padding(6);
            this.flpEstado2.Size = new System.Drawing.Size(310, 350);
            this.flpEstado2.TabIndex = 1;
            // 
            // pnlColumna3
            // 
            this.pnlColumna3.AutoSize = false;
            this.pnlColumna3.BackColor = System.Drawing.Color.White;
            this.pnlColumna3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlColumna3.ColumnCount = 1;
            this.pnlColumna3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlColumna3.Controls.Add(this.pnlEncabezado3, 0, 0);
            this.pnlColumna3.Controls.Add(this.flpEstado3, 0, 1);
            this.pnlColumna3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColumna3.Location = new System.Drawing.Point(640, 0);
            this.pnlColumna3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlColumna3.Name = "pnlColumna3";
            this.pnlColumna3.RowCount = 2;
            this.pnlColumna3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.pnlColumna3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlColumna3.Size = new System.Drawing.Size(312, 285);
            this.pnlColumna3.TabIndex = 2;
            // 
            // pnlEncabezado3
            // 
            this.pnlEncabezado3.BackColor = System.Drawing.Color.FromArgb(232, 242, 255);
            this.pnlEncabezado3.Controls.Add(this.lblCantidad3);
            this.pnlEncabezado3.Controls.Add(this.lblEstado3);
            this.pnlEncabezado3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEncabezado3.Location = new System.Drawing.Point(1, 1);
            this.pnlEncabezado3.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEncabezado3.Name = "pnlEncabezado3";
            this.pnlEncabezado3.Size = new System.Drawing.Size(310, 47);
            this.pnlEncabezado3.TabIndex = 0;
            // 
            // lblEstado3
            // 
            this.lblEstado3.AutoSize = true;
            this.lblEstado3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado3.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblEstado3.Location = new System.Drawing.Point(12, 13);
            this.lblEstado3.Name = "lblEstado3";
            this.lblEstado3.Size = new System.Drawing.Size(80, 20);
            this.lblEstado3.TabIndex = 0;
            this.lblEstado3.Text = "En revisión";
            // 
            // lblCantidad3
            // 
            this.lblCantidad3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad3.AutoSize = true;
            this.lblCantidad3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad3.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblCantidad3.Location = new System.Drawing.Point(286, 13);
            this.lblCantidad3.Name = "lblCantidad3";
            this.lblCantidad3.Size = new System.Drawing.Size(17, 20);
            this.lblCantidad3.TabIndex = 1;
            this.lblCantidad3.Text = "2";
            // 
            // flpEstado3
            // 
            this.flpEstado3.AutoScroll = true;
            this.flpEstado3.BackColor = System.Drawing.Color.White;
            this.flpEstado3.Controls.Add(this.tarea3_2);
            this.flpEstado3.Controls.Add(this.tarea3_1);
            this.flpEstado3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEstado3.Location = new System.Drawing.Point(1, 48);
            this.flpEstado3.Margin = new System.Windows.Forms.Padding(0);
            this.flpEstado3.Name = "flpEstado3";
            this.flpEstado3.Padding = new System.Windows.Forms.Padding(6);
            this.flpEstado3.Size = new System.Drawing.Size(310, 350);
            this.flpEstado3.TabIndex = 1;
            // 
            // pnlColumna4
            // 
            this.pnlColumna4.AutoSize = false;
            this.pnlColumna4.BackColor = System.Drawing.Color.White;
            this.pnlColumna4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlColumna4.ColumnCount = 1;
            this.pnlColumna4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlColumna4.Controls.Add(this.pnlEncabezado4, 0, 0);
            this.pnlColumna4.Controls.Add(this.flpEstado4, 0, 1);
            this.pnlColumna4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColumna4.Location = new System.Drawing.Point(960, 0);
            this.pnlColumna4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlColumna4.Name = "pnlColumna4";
            this.pnlColumna4.RowCount = 2;
            this.pnlColumna4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.pnlColumna4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlColumna4.Size = new System.Drawing.Size(312, 172);
            this.pnlColumna4.TabIndex = 3;
            // 
            // pnlEncabezado4
            // 
            this.pnlEncabezado4.BackColor = System.Drawing.Color.FromArgb(255, 232, 232);
            this.pnlEncabezado4.Controls.Add(this.lblCantidad4);
            this.pnlEncabezado4.Controls.Add(this.lblEstado4);
            this.pnlEncabezado4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEncabezado4.Location = new System.Drawing.Point(1, 1);
            this.pnlEncabezado4.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEncabezado4.Name = "pnlEncabezado4";
            this.pnlEncabezado4.Size = new System.Drawing.Size(310, 47);
            this.pnlEncabezado4.TabIndex = 0;
            // 
            // lblEstado4
            // 
            this.lblEstado4.AutoSize = true;
            this.lblEstado4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado4.ForeColor = System.Drawing.Color.FromArgb(229, 37, 42);
            this.lblEstado4.Location = new System.Drawing.Point(12, 13);
            this.lblEstado4.Name = "lblEstado4";
            this.lblEstado4.Size = new System.Drawing.Size(80, 20);
            this.lblEstado4.TabIndex = 0;
            this.lblEstado4.Text = "Vencida";
            // 
            // lblCantidad4
            // 
            this.lblCantidad4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad4.AutoSize = true;
            this.lblCantidad4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad4.ForeColor = System.Drawing.Color.FromArgb(229, 37, 42);
            this.lblCantidad4.Location = new System.Drawing.Point(286, 13);
            this.lblCantidad4.Name = "lblCantidad4";
            this.lblCantidad4.Size = new System.Drawing.Size(17, 20);
            this.lblCantidad4.TabIndex = 1;
            this.lblCantidad4.Text = "1";
            // 
            // flpEstado4
            // 
            this.flpEstado4.AutoScroll = true;
            this.flpEstado4.BackColor = System.Drawing.Color.White;
            this.flpEstado4.Controls.Add(this.tarea4_1);
            this.flpEstado4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEstado4.Location = new System.Drawing.Point(1, 48);
            this.flpEstado4.Margin = new System.Windows.Forms.Padding(0);
            this.flpEstado4.Name = "flpEstado4";
            this.flpEstado4.Padding = new System.Windows.Forms.Padding(6);
            this.flpEstado4.Size = new System.Drawing.Size(310, 350);
            this.flpEstado4.TabIndex = 1;
            // 
            // pnlColumna5
            // 
            this.pnlColumna5.AutoSize = false;
            this.pnlColumna5.BackColor = System.Drawing.Color.White;
            this.pnlColumna5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlColumna5.ColumnCount = 1;
            this.pnlColumna5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlColumna5.Controls.Add(this.pnlEncabezado5, 0, 0);
            this.pnlColumna5.Controls.Add(this.flpEstado5, 0, 1);
            this.pnlColumna5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColumna5.Location = new System.Drawing.Point(1280, 0);
            this.pnlColumna5.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlColumna5.Name = "pnlColumna5";
            this.pnlColumna5.RowCount = 2;
            this.pnlColumna5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.pnlColumna5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlColumna5.Size = new System.Drawing.Size(312, 285);
            this.pnlColumna5.TabIndex = 4;
            // 
            // pnlEncabezado5
            // 
            this.pnlEncabezado5.BackColor = System.Drawing.Color.FromArgb(223, 246, 231);
            this.pnlEncabezado5.Controls.Add(this.lblCantidad5);
            this.pnlEncabezado5.Controls.Add(this.lblEstado5);
            this.pnlEncabezado5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEncabezado5.Location = new System.Drawing.Point(1, 1);
            this.pnlEncabezado5.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEncabezado5.Name = "pnlEncabezado5";
            this.pnlEncabezado5.Size = new System.Drawing.Size(310, 47);
            this.pnlEncabezado5.TabIndex = 0;
            // 
            // lblEstado5
            // 
            this.lblEstado5.AutoSize = true;
            this.lblEstado5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado5.ForeColor = System.Drawing.Color.FromArgb(32, 169, 87);
            this.lblEstado5.Location = new System.Drawing.Point(12, 13);
            this.lblEstado5.Name = "lblEstado5";
            this.lblEstado5.Size = new System.Drawing.Size(80, 20);
            this.lblEstado5.TabIndex = 0;
            this.lblEstado5.Text = "Completada";
            // 
            // lblCantidad5
            // 
            this.lblCantidad5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad5.AutoSize = true;
            this.lblCantidad5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad5.ForeColor = System.Drawing.Color.FromArgb(32, 169, 87);
            this.lblCantidad5.Location = new System.Drawing.Point(286, 13);
            this.lblCantidad5.Name = "lblCantidad5";
            this.lblCantidad5.Size = new System.Drawing.Size(17, 20);
            this.lblCantidad5.TabIndex = 1;
            this.lblCantidad5.Text = "2";
            // 
            // flpEstado5
            // 
            this.flpEstado5.AutoScroll = true;
            this.flpEstado5.BackColor = System.Drawing.Color.White;
            this.flpEstado5.Controls.Add(this.tarea5_2);
            this.flpEstado5.Controls.Add(this.tarea5_1);
            this.flpEstado5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEstado5.Location = new System.Drawing.Point(1, 48);
            this.flpEstado5.Margin = new System.Windows.Forms.Padding(0);
            this.flpEstado5.Name = "flpEstado5";
            this.flpEstado5.Padding = new System.Windows.Forms.Padding(6);
            this.flpEstado5.Size = new System.Drawing.Size(310, 350);
            this.flpEstado5.TabIndex = 1;
            // 
            // tarea1_1
            // 
            this.tarea1_1.ColorEstado = System.Drawing.Color.FromArgb(11, 55, 104);
            this.tarea1_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tarea1_1.Estado = "Pendiente";
            this.tarea1_1.Fecha = "28 abr";
            this.tarea1_1.FondoEstado = System.Drawing.Color.FromArgb(238, 240, 243);
            this.tarea1_1.Location = new System.Drawing.Point(6, 6);
            this.tarea1_1.Margin = new System.Windows.Forms.Padding(0);
            this.tarea1_1.MostrarBoton = true;
            this.tarea1_1.Name = "tarea1_1";
            this.tarea1_1.NombreTarea = "Tarea 1 por pendiente";
            this.tarea1_1.Proyecto = "Proyecto 1";
            this.tarea1_1.Size = new System.Drawing.Size(298, 105);
            this.tarea1_1.TabIndex = 0;
            // 
            // tarea1_2
            // 
            this.tarea1_2.ColorEstado = System.Drawing.Color.FromArgb(11, 55, 104);
            this.tarea1_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tarea1_2.Estado = "Pendiente";
            this.tarea1_2.Fecha = "29 abr";
            this.tarea1_2.FondoEstado = System.Drawing.Color.FromArgb(238, 240, 243);
            this.tarea1_2.Location = new System.Drawing.Point(6, 119);
            this.tarea1_2.Margin = new System.Windows.Forms.Padding(0);
            this.tarea1_2.MostrarBoton = true;
            this.tarea1_2.Name = "tarea1_2";
            this.tarea1_2.NombreTarea = "Tarea 2 por pendiente";
            this.tarea1_2.Proyecto = "Proyecto 2";
            this.tarea1_2.Size = new System.Drawing.Size(298, 105);
            this.tarea1_2.TabIndex = 1;
            // 
            // tarea1_3
            // 
            this.tarea1_3.ColorEstado = System.Drawing.Color.FromArgb(11, 55, 104);
            this.tarea1_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tarea1_3.Estado = "Pendiente";
            this.tarea1_3.Fecha = "30 abr";
            this.tarea1_3.FondoEstado = System.Drawing.Color.FromArgb(238, 240, 243);
            this.tarea1_3.Location = new System.Drawing.Point(6, 232);
            this.tarea1_3.Margin = new System.Windows.Forms.Padding(0);
            this.tarea1_3.MostrarBoton = true;
            this.tarea1_3.Name = "tarea1_3";
            this.tarea1_3.NombreTarea = "Tarea 3 por pendiente";
            this.tarea1_3.Proyecto = "Proyecto 3";
            this.tarea1_3.Size = new System.Drawing.Size(298, 105);
            this.tarea1_3.TabIndex = 2;
            // 
            // tarea2_1
            // 
            this.tarea2_1.ColorEstado = System.Drawing.Color.FromArgb(215, 145, 0);
            this.tarea2_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tarea2_1.Estado = "En progreso";
            this.tarea2_1.Fecha = "28 abr";
            this.tarea2_1.FondoEstado = System.Drawing.Color.FromArgb(255, 246, 218);
            this.tarea2_1.Location = new System.Drawing.Point(6, 6);
            this.tarea2_1.Margin = new System.Windows.Forms.Padding(0);
            this.tarea2_1.MostrarBoton = true;
            this.tarea2_1.Name = "tarea2_1";
            this.tarea2_1.NombreTarea = "Tarea 1 por en progreso";
            this.tarea2_1.Proyecto = "Proyecto 1";
            this.tarea2_1.Size = new System.Drawing.Size(298, 105);
            this.tarea2_1.TabIndex = 0;
            // 
            // tarea2_2
            // 
            this.tarea2_2.ColorEstado = System.Drawing.Color.FromArgb(215, 145, 0);
            this.tarea2_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tarea2_2.Estado = "En progreso";
            this.tarea2_2.Fecha = "29 abr";
            this.tarea2_2.FondoEstado = System.Drawing.Color.FromArgb(255, 246, 218);
            this.tarea2_2.Location = new System.Drawing.Point(6, 119);
            this.tarea2_2.Margin = new System.Windows.Forms.Padding(0);
            this.tarea2_2.MostrarBoton = true;
            this.tarea2_2.Name = "tarea2_2";
            this.tarea2_2.NombreTarea = "Tarea 2 por en progreso";
            this.tarea2_2.Proyecto = "Proyecto 2";
            this.tarea2_2.Size = new System.Drawing.Size(298, 105);
            this.tarea2_2.TabIndex = 1;
            // 
            // tarea3_1
            // 
            this.tarea3_1.ColorEstado = System.Drawing.Color.FromArgb(0, 105, 240);
            this.tarea3_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tarea3_1.Estado = "En revisión";
            this.tarea3_1.Fecha = "28 abr";
            this.tarea3_1.FondoEstado = System.Drawing.Color.FromArgb(232, 242, 255);
            this.tarea3_1.Location = new System.Drawing.Point(6, 6);
            this.tarea3_1.Margin = new System.Windows.Forms.Padding(0);
            this.tarea3_1.MostrarBoton = true;
            this.tarea3_1.Name = "tarea3_1";
            this.tarea3_1.NombreTarea = "Tarea 1 por en revisión";
            this.tarea3_1.Proyecto = "Proyecto 3";
            this.tarea3_1.Size = new System.Drawing.Size(298, 105);
            this.tarea3_1.TabIndex = 0;
            // 
            // tarea3_2
            // 
            this.tarea3_2.ColorEstado = System.Drawing.Color.FromArgb(0, 105, 240);
            this.tarea3_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tarea3_2.Estado = "En revisión";
            this.tarea3_2.Fecha = "29 abr";
            this.tarea3_2.FondoEstado = System.Drawing.Color.FromArgb(232, 242, 255);
            this.tarea3_2.Location = new System.Drawing.Point(6, 119);
            this.tarea3_2.Margin = new System.Windows.Forms.Padding(0);
            this.tarea3_2.MostrarBoton = true;
            this.tarea3_2.Name = "tarea3_2";
            this.tarea3_2.NombreTarea = "Tarea 2 por en revisión";
            this.tarea3_2.Proyecto = "Proyecto 1";
            this.tarea3_2.Size = new System.Drawing.Size(298, 105);
            this.tarea3_2.TabIndex = 1;
            // 
            // tarea4_1
            // 
            this.tarea4_1.ColorEstado = System.Drawing.Color.FromArgb(229, 37, 42);
            this.tarea4_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tarea4_1.Estado = "Vencida";
            this.tarea4_1.Fecha = "28 abr";
            this.tarea4_1.FondoEstado = System.Drawing.Color.FromArgb(255, 232, 232);
            this.tarea4_1.Location = new System.Drawing.Point(6, 6);
            this.tarea4_1.Margin = new System.Windows.Forms.Padding(0);
            this.tarea4_1.MostrarBoton = true;
            this.tarea4_1.Name = "tarea4_1";
            this.tarea4_1.NombreTarea = "Tarea 1 por vencida";
            this.tarea4_1.Proyecto = "Proyecto 2";
            this.tarea4_1.Size = new System.Drawing.Size(298, 105);
            this.tarea4_1.TabIndex = 0;
            // 
            // tarea5_1
            // 
            this.tarea5_1.ColorEstado = System.Drawing.Color.FromArgb(32, 169, 87);
            this.tarea5_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tarea5_1.Estado = "Completada";
            this.tarea5_1.Fecha = "28 abr";
            this.tarea5_1.FondoEstado = System.Drawing.Color.FromArgb(223, 246, 231);
            this.tarea5_1.Location = new System.Drawing.Point(6, 6);
            this.tarea5_1.Margin = new System.Windows.Forms.Padding(0);
            this.tarea5_1.MostrarBoton = true;
            this.tarea5_1.Name = "tarea5_1";
            this.tarea5_1.NombreTarea = "Tarea 1 por completada";
            this.tarea5_1.Proyecto = "Proyecto 3";
            this.tarea5_1.Size = new System.Drawing.Size(298, 105);
            this.tarea5_1.TabIndex = 0;
            // 
            // tarea5_2
            // 
            this.tarea5_2.ColorEstado = System.Drawing.Color.FromArgb(32, 169, 87);
            this.tarea5_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tarea5_2.Estado = "Completada";
            this.tarea5_2.Fecha = "29 abr";
            this.tarea5_2.FondoEstado = System.Drawing.Color.FromArgb(223, 246, 231);
            this.tarea5_2.Location = new System.Drawing.Point(6, 119);
            this.tarea5_2.Margin = new System.Windows.Forms.Padding(0);
            this.tarea5_2.MostrarBoton = true;
            this.tarea5_2.Name = "tarea5_2";
            this.tarea5_2.NombreTarea = "Tarea 2 por completada";
            this.tarea5_2.Proyecto = "Proyecto 1";
            this.tarea5_2.Size = new System.Drawing.Size(298, 105);
            this.tarea5_2.TabIndex = 1;
            // 
            // frmTableroTareasGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.Controls.Add(this.pnlViewport);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTableroTareasGestor";
            this.Text = "Tablero de tareas";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlViewport.ResumeLayout(false);
            this.pnlViewport.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.tlpCabecera.ResumeLayout(false);
            this.pnlTitulos.ResumeLayout(false);
            this.pnlTitulos.PerformLayout();
            this.flpFiltros.ResumeLayout(false);
            this.pnlColumnas.ResumeLayout(false);
            this.pnlColumna1.ResumeLayout(false);
            this.pnlColumna1.PerformLayout();
            this.pnlEncabezado1.ResumeLayout(false);
            this.pnlEncabezado1.PerformLayout();
            this.flpEstado1.ResumeLayout(false);
            this.pnlColumna2.ResumeLayout(false);
            this.pnlColumna2.PerformLayout();
            this.pnlEncabezado2.ResumeLayout(false);
            this.pnlEncabezado2.PerformLayout();
            this.flpEstado2.ResumeLayout(false);
            this.pnlColumna3.ResumeLayout(false);
            this.pnlColumna3.PerformLayout();
            this.pnlEncabezado3.ResumeLayout(false);
            this.pnlEncabezado3.PerformLayout();
            this.flpEstado3.ResumeLayout(false);
            this.pnlColumna4.ResumeLayout(false);
            this.pnlColumna4.PerformLayout();
            this.pnlEncabezado4.ResumeLayout(false);
            this.pnlEncabezado4.PerformLayout();
            this.flpEstado4.ResumeLayout(false);
            this.pnlColumna5.ResumeLayout(false);
            this.pnlColumna5.PerformLayout();
            this.pnlEncabezado5.ResumeLayout(false);
            this.pnlEncabezado5.PerformLayout();
            this.flpEstado5.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblBreadcrumbBase;
        private System.Windows.Forms.Label lblBreadcrumbActual;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlViewport;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpCabecera;
        private System.Windows.Forms.Panel pnlTitulos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.FlowLayoutPanel flpFiltros;
        private System.Windows.Forms.ComboBox cboProyecto;
        private System.Windows.Forms.ComboBox cboResponsable;
        private System.Windows.Forms.Button btnNuevaTarea;
        private System.Windows.Forms.TableLayoutPanel pnlColumnas;
        private System.Windows.Forms.TableLayoutPanel pnlColumna1;
        private System.Windows.Forms.Panel pnlEncabezado1;
        private System.Windows.Forms.Label lblEstado1;
        private System.Windows.Forms.Label lblCantidad1;
        private System.Windows.Forms.Panel flpEstado1;
        private System.Windows.Forms.TableLayoutPanel pnlColumna2;
        private System.Windows.Forms.Panel pnlEncabezado2;
        private System.Windows.Forms.Label lblEstado2;
        private System.Windows.Forms.Label lblCantidad2;
        private System.Windows.Forms.Panel flpEstado2;
        private System.Windows.Forms.TableLayoutPanel pnlColumna3;
        private System.Windows.Forms.Panel pnlEncabezado3;
        private System.Windows.Forms.Label lblEstado3;
        private System.Windows.Forms.Label lblCantidad3;
        private System.Windows.Forms.Panel flpEstado3;
        private System.Windows.Forms.TableLayoutPanel pnlColumna4;
        private System.Windows.Forms.Panel pnlEncabezado4;
        private System.Windows.Forms.Label lblEstado4;
        private System.Windows.Forms.Label lblCantidad4;
        private System.Windows.Forms.Panel flpEstado4;
        private System.Windows.Forms.TableLayoutPanel pnlColumna5;
        private System.Windows.Forms.Panel pnlEncabezado5;
        private System.Windows.Forms.Label lblEstado5;
        private System.Windows.Forms.Label lblCantidad5;
        private System.Windows.Forms.Panel flpEstado5;
        private Vista.UCTarjetaTarea tarea1_1;
        private Vista.UCTarjetaTarea tarea1_2;
        private Vista.UCTarjetaTarea tarea1_3;
        private Vista.UCTarjetaTarea tarea2_1;
        private Vista.UCTarjetaTarea tarea2_2;
        private Vista.UCTarjetaTarea tarea3_1;
        private Vista.UCTarjetaTarea tarea3_2;
        private Vista.UCTarjetaTarea tarea4_1;
        private Vista.UCTarjetaTarea tarea5_1;
        private Vista.UCTarjetaTarea tarea5_2;
    }
}
