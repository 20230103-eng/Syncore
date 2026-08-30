namespace Vista
{
    partial class frmListadoProyectos
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblBreadcrumbActual = new System.Windows.Forms.Label();
            this.lblBreadcrumbBase = new System.Windows.Forms.Label();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlViewport = new System.Windows.Forms.Panel();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnNuevoProyecto = new System.Windows.Forms.Button();
            this.tlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.tlpEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFilas = new System.Windows.Forms.Panel();
            this.lblH0 = new System.Windows.Forms.Label();
            this.lblH1 = new System.Windows.Forms.Label();
            this.lblH2 = new System.Windows.Forms.Label();
            this.lblH3 = new System.Windows.Forms.Label();
            this.lblH4 = new System.Windows.Forms.Label();
            this.lblH5 = new System.Windows.Forms.Label();
            this.lblH6 = new System.Windows.Forms.Label();
            this.lblH7 = new System.Windows.Forms.Label();
            this.lblH8 = new System.Windows.Forms.Label();
            this.lblH9 = new System.Windows.Forms.Label();
            this.proyecto1 = new Vista.UCFilaProyectoListado();
            this.proyecto2 = new Vista.UCFilaProyectoListado();
            this.proyecto3 = new Vista.UCFilaProyectoListado();
            this.proyecto4 = new Vista.UCFilaProyectoListado();
            this.pnlTop.SuspendLayout();
            this.pnlViewport.SuspendLayout();
            this.pnlCanvas.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            this.pnlTabla.SuspendLayout();
            this.tlpEncabezado.SuspendLayout();
            this.pnlFilas.SuspendLayout();
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
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblFecha.Location = new System.Drawing.Point(1610, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Text = "Fecha";
            // 
            // lblBreadcrumbActual
            // 
            this.lblBreadcrumbActual.AutoSize = true;
            this.lblBreadcrumbActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreadcrumbActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(100, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Text = "Listado de proyectos";
            // 
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.Text = "Proyectos >";
            // 
            // pnlViewport
            // 
            this.pnlViewport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlViewport.Controls.Add(this.pnlCanvas);
            this.pnlViewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewport.Location = new System.Drawing.Point(0, 43);
            this.pnlViewport.Name = "pnlViewport";
            this.pnlViewport.Size = new System.Drawing.Size(1670, 1037);
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.AutoScroll = true;
            this.pnlCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlCanvas.Controls.Add(this.tlpMain);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Name = "pnlCanvas";
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlCabecera, 0, 0);
            this.tlpMain.Controls.Add(this.tlpFiltros, 0, 1);
            this.tlpMain.Controls.Add(this.pnlTabla, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(24, 18, 24, 24);
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.tlpMain.Size = new System.Drawing.Size(1670, 646);
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Controls.Add(this.lblSubtitulo);
            this.pnlCabecera.Controls.Add(this.btnNuevoProyecto);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCabecera.Name = "pnlCabecera";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Proyectos";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(2, 38);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Proyectos activos bajo tu cargo";
            // 
            // btnNuevoProyecto
            // 
            this.btnNuevoProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.btnNuevoProyecto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProyecto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevoProyecto.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProyecto.Location = new System.Drawing.Point(1452, 8);
            this.btnNuevoProyecto.Name = "btnNuevoProyecto";
            this.btnNuevoProyecto.Size = new System.Drawing.Size(164, 36);
            this.btnNuevoProyecto.Text = "+ Nuevo proyecto";
            this.btnNuevoProyecto.UseVisualStyleBackColor = false;
            // 
            // tlpFiltros
            // 
            this.tlpFiltros.ColumnCount = 6;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpFiltros.Controls.Add(this.txtBuscar, 0, 0);
            this.tlpFiltros.Controls.Add(this.cmbEstado, 1, 0);
            this.tlpFiltros.Controls.Add(this.cmbArea, 2, 0);
            this.tlpFiltros.Controls.Add(this.cmbResponsable, 3, 0);
            this.tlpFiltros.Controls.Add(this.cmbPrioridad, 4, 0);
            this.tlpFiltros.Controls.Add(this.cmbTipo, 5, 0);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 1;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            // 
            // txtBuscar
            // 
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(0, 9, 10, 9);
            this.txtBuscar.MaxLength = 150;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ShortcutsEnabled = false;
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.Text = "";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(0, 8, 10, 8);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.filtro_SelectedIndexChanged);
            this.cmbEstado.TabIndex = 1;
            // 
            // cmbArea
            // 
            this.cmbArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Margin = new System.Windows.Forms.Padding(0, 8, 10, 8);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.filtro_SelectedIndexChanged);
            this.cmbArea.TabIndex = 2;
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Margin = new System.Windows.Forms.Padding(0, 8, 10, 8);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.SelectedIndexChanged += new System.EventHandler(this.filtro_SelectedIndexChanged);
            this.cmbResponsable.TabIndex = 3;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Margin = new System.Windows.Forms.Padding(0, 8, 10, 8);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.SelectedIndexChanged += new System.EventHandler(this.filtro_SelectedIndexChanged);
            this.cmbPrioridad.TabIndex = 4;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(0, 8, 10, 8);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.filtro_SelectedIndexChanged);
            this.cmbTipo.TabIndex = 5;
            // 
            // pnlTabla
            // 
            this.pnlTabla.BackColor = System.Drawing.Color.White;
            this.pnlTabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTabla.Controls.Add(this.pnlFilas);
            this.pnlTabla.Controls.Add(this.tlpEncabezado);
            this.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabla.Name = "pnlTabla";
            // 
            // tlpEncabezado
            // 
            this.tlpEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.tlpEncabezado.ColumnCount = 10;
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpEncabezado.Controls.Add(this.lblH0, 0, 0);
            this.tlpEncabezado.Controls.Add(this.lblH1, 1, 0);
            this.tlpEncabezado.Controls.Add(this.lblH2, 2, 0);
            this.tlpEncabezado.Controls.Add(this.lblH3, 3, 0);
            this.tlpEncabezado.Controls.Add(this.lblH4, 4, 0);
            this.tlpEncabezado.Controls.Add(this.lblH5, 5, 0);
            this.tlpEncabezado.Controls.Add(this.lblH6, 6, 0);
            this.tlpEncabezado.Controls.Add(this.lblH7, 7, 0);
            this.tlpEncabezado.Controls.Add(this.lblH8, 8, 0);
            this.tlpEncabezado.Controls.Add(this.lblH9, 9, 0);
            this.tlpEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpEncabezado.Name = "tlpEncabezado";
            this.tlpEncabezado.RowCount = 1;
            this.tlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncabezado.Size = new System.Drawing.Size(1616, 40);
            // 
            // lblH0
            // 
            this.lblH0.AutoSize = true;
            this.lblH0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH0.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblH0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblH0.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.lblH0.Name = "lblH0";
            this.lblH0.Text = "CÓDIGO";
            this.lblH0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblH1
            // 
            this.lblH1.AutoSize = true;
            this.lblH1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblH1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblH1.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.lblH1.Name = "lblH1";
            this.lblH1.Text = "NOMBRE";
            this.lblH1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblH2
            // 
            this.lblH2.AutoSize = true;
            this.lblH2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblH2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblH2.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.lblH2.Name = "lblH2";
            this.lblH2.Text = "TIPO";
            this.lblH2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblH3
            // 
            this.lblH3.AutoSize = true;
            this.lblH3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblH3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblH3.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.lblH3.Name = "lblH3";
            this.lblH3.Text = "ÁREA";
            this.lblH3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblH4
            // 
            this.lblH4.AutoSize = true;
            this.lblH4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblH4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblH4.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.lblH4.Name = "lblH4";
            this.lblH4.Text = "RESPONSABLE";
            this.lblH4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblH5
            // 
            this.lblH5.AutoSize = true;
            this.lblH5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblH5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblH5.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.lblH5.Name = "lblH5";
            this.lblH5.Text = "ESTADO";
            this.lblH5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblH6
            // 
            this.lblH6.AutoSize = true;
            this.lblH6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblH6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblH6.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.lblH6.Name = "lblH6";
            this.lblH6.Text = "AVANCE";
            this.lblH6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblH7
            // 
            this.lblH7.AutoSize = true;
            this.lblH7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblH7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblH7.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.lblH7.Name = "lblH7";
            this.lblH7.Text = "PRIORIDAD";
            this.lblH7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblH8
            // 
            this.lblH8.AutoSize = true;
            this.lblH8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblH8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblH8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblH8.Name = "lblH8";
            this.lblH8.Text = "EDITAR";
            this.lblH8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblH9
            // 
            this.lblH9.AutoSize = true;
            this.lblH9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblH9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblH9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblH9.Name = "lblH9";
            this.lblH9.Text = "VER";
            this.lblH9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFilas
            // 
            this.pnlFilas.AutoScroll = true;
            this.pnlFilas.Controls.Add(this.proyecto4);
            this.pnlFilas.Controls.Add(this.proyecto3);
            this.pnlFilas.Controls.Add(this.proyecto2);
            this.pnlFilas.Controls.Add(this.proyecto1);
            this.pnlFilas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilas.Location = new System.Drawing.Point(0, 40);
            this.pnlFilas.Name = "pnlFilas";
            this.pnlFilas.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            // 
            // proyecto1
            // 
            this.proyecto1.Area = "Tecnología";
            this.proyecto1.Avance = 45;
            this.proyecto1.Codigo = "PRY-2026-01";
            this.proyecto1.Dock = System.Windows.Forms.DockStyle.Top;
            this.proyecto1.Estado = "Activo";
            this.proyecto1.Name = "proyecto1";
            this.proyecto1.NombreProyecto = "Plataforma de gestión";
            this.proyecto1.Prioridad = "Alta";
            this.proyecto1.Responsable = "Juan Pérez";
            this.proyecto1.Size = new System.Drawing.Size(1614, 54);
            this.proyecto1.TipoProyecto = "Interno";
            // 
            // proyecto2
            // 
            this.proyecto2.Area = "Comunicaciones";
            this.proyecto2.Avance = 62;
            this.proyecto2.Codigo = "PRY-2026-02";
            this.proyecto2.Dock = System.Windows.Forms.DockStyle.Top;
            this.proyecto2.Estado = "Activo";
            this.proyecto2.Name = "proyecto2";
            this.proyecto2.NombreProyecto = "Campaña institucional";
            this.proyecto2.Prioridad = "Media";
            this.proyecto2.Responsable = "Ana Mejía";
            this.proyecto2.Size = new System.Drawing.Size(1614, 54);
            this.proyecto2.TipoProyecto = "Social";
            // 
            // proyecto3
            // 
            this.proyecto3.Area = "Planificación";
            this.proyecto3.Avance = 38;
            this.proyecto3.Codigo = "PRY-2026-03";
            this.proyecto3.Dock = System.Windows.Forms.DockStyle.Top;
            this.proyecto3.Estado = "Observación";
            this.proyecto3.Name = "proyecto3";
            this.proyecto3.NombreProyecto = "Mejora de procesos";
            this.proyecto3.Prioridad = "Alta";
            this.proyecto3.Responsable = "Carlos Ruiz";
            this.proyecto3.Size = new System.Drawing.Size(1614, 54);
            this.proyecto3.TipoProyecto = "Administrativo";
            // 
            // proyecto4
            // 
            this.proyecto4.Area = "Tecnología";
            this.proyecto4.Avance = 29;
            this.proyecto4.Codigo = "PRY-2026-04";
            this.proyecto4.Dock = System.Windows.Forms.DockStyle.Top;
            this.proyecto4.Estado = "Crítico";
            this.proyecto4.Name = "proyecto4";
            this.proyecto4.NombreProyecto = "Portal de servicios";
            this.proyecto4.Prioridad = "Alta";
            this.proyecto4.Responsable = "Juan Pérez";
            this.proyecto4.Size = new System.Drawing.Size(1614, 54);
            this.proyecto4.TipoProyecto = "Interno";
            // 
            // frmListadoProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.pnlViewport);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.frmListadoProyectos_Load);
            this.Name = "frmListadoProyectos";
            this.Text = "frmListadoProyectos";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlViewport.ResumeLayout(false);
            this.pnlCanvas.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.tlpFiltros.ResumeLayout(false);
            this.tlpFiltros.PerformLayout();
            this.pnlTabla.ResumeLayout(false);
            this.tlpEncabezado.ResumeLayout(false);
            this.tlpEncabezado.PerformLayout();
            this.pnlFilas.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblBreadcrumbActual;
        private System.Windows.Forms.Label lblBreadcrumbBase;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlViewport;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnNuevoProyecto;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.TableLayoutPanel tlpEncabezado;
        private System.Windows.Forms.Panel pnlFilas;
        private System.Windows.Forms.Label lblH0;
        private System.Windows.Forms.Label lblH1;
        private System.Windows.Forms.Label lblH2;
        private System.Windows.Forms.Label lblH3;
        private System.Windows.Forms.Label lblH4;
        private System.Windows.Forms.Label lblH5;
        private System.Windows.Forms.Label lblH6;
        private System.Windows.Forms.Label lblH7;
        private System.Windows.Forms.Label lblH8;
        private System.Windows.Forms.Label lblH9;
        private Vista.UCFilaProyectoListado proyecto1;
        private Vista.UCFilaProyectoListado proyecto2;
        private Vista.UCFilaProyectoListado proyecto3;
        private Vista.UCFilaProyectoListado proyecto4;
    }
}
