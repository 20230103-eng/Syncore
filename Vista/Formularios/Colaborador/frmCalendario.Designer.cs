namespace Vista
{
    partial class frmCalendario
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
            this.lblBreadcrumbBase = new System.Windows.Forms.Label();
            this.lblBreadcrumbActual = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlViewport = new System.Windows.Forms.Panel();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTituloMes = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.cboVista = new System.Windows.Forms.ComboBox();
            this.cboProyecto = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.tlpDias = new System.Windows.Forms.TableLayoutPanel();
            this.lblDom = new System.Windows.Forms.Label();
            this.lblLun = new System.Windows.Forms.Label();
            this.lblMar = new System.Windows.Forms.Label();
            this.lblMie = new System.Windows.Forms.Label();
            this.lblJue = new System.Windows.Forms.Label();
            this.lblVie = new System.Windows.Forms.Label();
            this.lblSab = new System.Windows.Forms.Label();
            this.tlpCalendario = new System.Windows.Forms.TableLayoutPanel();
            this.flpLeyenda = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLeyendaTarea = new System.Windows.Forms.Label();
            this.lblLeyendaHito = new System.Windows.Forms.Label();
            this.lblLeyendaVencida = new System.Windows.Forms.Label();
            this.dia1 = new Vista.UCCeldaCalendario();
            this.dia2 = new Vista.UCCeldaCalendario();
            this.dia3 = new Vista.UCCeldaCalendario();
            this.dia4 = new Vista.UCCeldaCalendario();
            this.dia5 = new Vista.UCCeldaCalendario();
            this.dia6 = new Vista.UCCeldaCalendario();
            this.dia7 = new Vista.UCCeldaCalendario();
            this.dia8 = new Vista.UCCeldaCalendario();
            this.dia9 = new Vista.UCCeldaCalendario();
            this.dia10 = new Vista.UCCeldaCalendario();
            this.dia11 = new Vista.UCCeldaCalendario();
            this.dia12 = new Vista.UCCeldaCalendario();
            this.dia13 = new Vista.UCCeldaCalendario();
            this.dia14 = new Vista.UCCeldaCalendario();
            this.dia15 = new Vista.UCCeldaCalendario();
            this.dia16 = new Vista.UCCeldaCalendario();
            this.dia17 = new Vista.UCCeldaCalendario();
            this.dia18 = new Vista.UCCeldaCalendario();
            this.dia19 = new Vista.UCCeldaCalendario();
            this.dia20 = new Vista.UCCeldaCalendario();
            this.dia21 = new Vista.UCCeldaCalendario();
            this.dia22 = new Vista.UCCeldaCalendario();
            this.dia23 = new Vista.UCCeldaCalendario();
            this.dia24 = new Vista.UCCeldaCalendario();
            this.dia25 = new Vista.UCCeldaCalendario();
            this.dia26 = new Vista.UCCeldaCalendario();
            this.dia27 = new Vista.UCCeldaCalendario();
            this.dia28 = new Vista.UCCeldaCalendario();
            this.dia29 = new Vista.UCCeldaCalendario();
            this.dia30 = new Vista.UCCeldaCalendario();
            this.dia31 = new Vista.UCCeldaCalendario();
            this.dia32 = new Vista.UCCeldaCalendario();
            this.dia33 = new Vista.UCCeldaCalendario();
            this.dia34 = new Vista.UCCeldaCalendario();
            this.dia35 = new Vista.UCCeldaCalendario();
            this.pnlTop.SuspendLayout();
            this.pnlViewport.SuspendLayout();
            this.pnlCanvas.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.tlpEncabezado.SuspendLayout();
            this.pnlTituloMes.SuspendLayout();
            this.tlpDias.SuspendLayout();
            this.tlpCalendario.SuspendLayout();
            this.flpLeyenda.SuspendLayout();
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
            this.lblBreadcrumbBase.Size = new System.Drawing.Size(80, 20);
            this.lblBreadcrumbBase.TabIndex = 0;
            this.lblBreadcrumbBase.Text = "Calendario >";
            // 
            // lblBreadcrumbActual
            // 
            this.lblBreadcrumbActual.AutoSize = true;
            this.lblBreadcrumbActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreadcrumbActual.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(112, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Size = new System.Drawing.Size(80, 20);
            this.lblBreadcrumbActual.TabIndex = 0;
            this.lblBreadcrumbActual.Text = "Mi calendario";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(145, 151, 160);
            this.lblFecha.Location = new System.Drawing.Point(1590, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
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
            this.pnlCanvas.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlCanvas.Controls.Add(this.tlpPrincipal);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Padding = new System.Windows.Forms.Padding(22, 18, 22, 16);
            this.pnlCanvas.Size = new System.Drawing.Size(1670, 1037);
            this.pnlCanvas.TabIndex = 0;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tlpEncabezado, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpDias, 0, 1);
            this.tlpPrincipal.Controls.Add(this.tlpCalendario, 0, 2);
            this.tlpPrincipal.Controls.Add(this.flpLeyenda, 0, 3);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(22, 18);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1626, 1003);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // tlpEncabezado
            // 
            this.tlpEncabezado.ColumnCount = 6;
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tlpEncabezado.Controls.Add(this.pnlTituloMes, 0, 0);
            this.tlpEncabezado.Controls.Add(this.btnAnterior, 1, 0);
            this.tlpEncabezado.Controls.Add(this.btnSiguiente, 2, 0);
            this.tlpEncabezado.Controls.Add(this.cboVista, 3, 0);
            this.tlpEncabezado.Controls.Add(this.cboProyecto, 4, 0);
            this.tlpEncabezado.Controls.Add(this.cboTipo, 5, 0);
            this.tlpEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEncabezado.Location = new System.Drawing.Point(0, 0);
            this.tlpEncabezado.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEncabezado.Name = "tlpEncabezado";
            this.tlpEncabezado.RowCount = 1;
            this.tlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncabezado.Size = new System.Drawing.Size(1626, 82);
            this.tlpEncabezado.TabIndex = 0;
            // 
            // pnlTituloMes
            // 
            this.pnlTituloMes.Controls.Add(this.lblMes);
            this.pnlTituloMes.Controls.Add(this.lblTitulo);
            this.pnlTituloMes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTituloMes.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloMes.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTituloMes.Name = "pnlTituloMes";
            this.pnlTituloMes.Size = new System.Drawing.Size(552, 82);
            this.pnlTituloMes.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(4, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(191, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mi calendario";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMes.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblMes.Location = new System.Drawing.Point(7, 50);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(81, 20);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "Mayo 2026";
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.White;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            this.btnAnterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(142, 160, 181);
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAnterior.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.btnAnterior.Location = new System.Drawing.Point(3, 19);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 19, 4, 25);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(105, 38);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "< Abril";
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.White;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            this.btnSiguiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(142, 160, 181);
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.btnSiguiente.Location = new System.Drawing.Point(3, 19);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 19, 4, 25);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(105, 38);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Junio >";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // cboVista
            // 
            this.cboVista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboVista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVista.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboVista.FormattingEnabled = true;
            this.cboVista.Items.AddRange(new object[] {
            "Vista mensual",
            "Vista semanal"
            });
            this.cboVista.Location = new System.Drawing.Point(3, 25);
            this.cboVista.Margin = new System.Windows.Forms.Padding(5, 25, 5, 28);
            this.cboVista.Name = "cboVista";
            this.cboVista.SelectedIndex = 0;
            this.cboVista.SelectedIndexChanged += new System.EventHandler(this.filtros_SelectedIndexChanged);
            this.cboVista.Size = new System.Drawing.Size(200, 28);
            this.cboVista.TabIndex = 4;
            // 
            // cboProyecto
            // 
            this.cboProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProyecto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboProyecto.FormattingEnabled = true;
            this.cboProyecto.Items.AddRange(new object[] {
            "Todos los proyectos",
            "Proyecto 1",
            "Proyecto 2"
            });
            this.cboProyecto.Location = new System.Drawing.Point(3, 25);
            this.cboProyecto.Margin = new System.Windows.Forms.Padding(5, 25, 5, 28);
            this.cboProyecto.Name = "cboProyecto";
            this.cboProyecto.SelectedIndex = 0;
            this.cboProyecto.SelectedIndexChanged += new System.EventHandler(this.filtros_SelectedIndexChanged);
            this.cboProyecto.Size = new System.Drawing.Size(200, 28);
            this.cboProyecto.TabIndex = 5;
            // 
            // cboTipo
            // 
            this.cboTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Mis tareas e hitos",
            "Solo tareas",
            "Solo hitos"
            });
            this.cboTipo.Location = new System.Drawing.Point(3, 25);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(5, 25, 5, 28);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.SelectedIndex = 0;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.filtros_SelectedIndexChanged);
            this.cboTipo.Size = new System.Drawing.Size(200, 28);
            this.cboTipo.TabIndex = 6;
            // 
            // tlpDias
            // 
            this.tlpDias.BackColor = System.Drawing.Color.White;
            this.tlpDias.ColumnCount = 7;
            this.tlpDias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDias.Controls.Add(this.lblDom, 0, 0);
            this.tlpDias.Controls.Add(this.lblLun, 1, 0);
            this.tlpDias.Controls.Add(this.lblMar, 2, 0);
            this.tlpDias.Controls.Add(this.lblMie, 3, 0);
            this.tlpDias.Controls.Add(this.lblJue, 4, 0);
            this.tlpDias.Controls.Add(this.lblVie, 5, 0);
            this.tlpDias.Controls.Add(this.lblSab, 6, 0);
            this.tlpDias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDias.Location = new System.Drawing.Point(0, 82);
            this.tlpDias.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDias.Name = "tlpDias";
            this.tlpDias.RowCount = 1;
            this.tlpDias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDias.Size = new System.Drawing.Size(1626, 42);
            this.tlpDias.TabIndex = 1;
            // 
            // lblDom
            // 
            this.lblDom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDom.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblDom.Location = new System.Drawing.Point(0, 0);
            this.lblDom.Margin = new System.Windows.Forms.Padding(0);
            this.lblDom.Name = "lblDom";
            this.lblDom.Size = new System.Drawing.Size(232, 42);
            this.lblDom.TabIndex = 0;
            this.lblDom.Text = "Dom";
            this.lblDom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLun
            // 
            this.lblLun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLun.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblLun.Location = new System.Drawing.Point(0, 0);
            this.lblLun.Margin = new System.Windows.Forms.Padding(0);
            this.lblLun.Name = "lblLun";
            this.lblLun.Size = new System.Drawing.Size(232, 42);
            this.lblLun.TabIndex = 0;
            this.lblLun.Text = "Lun";
            this.lblLun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMar
            // 
            this.lblMar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMar.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblMar.Location = new System.Drawing.Point(0, 0);
            this.lblMar.Margin = new System.Windows.Forms.Padding(0);
            this.lblMar.Name = "lblMar";
            this.lblMar.Size = new System.Drawing.Size(232, 42);
            this.lblMar.TabIndex = 0;
            this.lblMar.Text = "Mar";
            this.lblMar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMie
            // 
            this.lblMie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMie.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblMie.Location = new System.Drawing.Point(0, 0);
            this.lblMie.Margin = new System.Windows.Forms.Padding(0);
            this.lblMie.Name = "lblMie";
            this.lblMie.Size = new System.Drawing.Size(232, 42);
            this.lblMie.TabIndex = 0;
            this.lblMie.Text = "Mié";
            this.lblMie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJue
            // 
            this.lblJue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblJue.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblJue.Location = new System.Drawing.Point(0, 0);
            this.lblJue.Margin = new System.Windows.Forms.Padding(0);
            this.lblJue.Name = "lblJue";
            this.lblJue.Size = new System.Drawing.Size(232, 42);
            this.lblJue.TabIndex = 0;
            this.lblJue.Text = "Jue";
            this.lblJue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVie
            // 
            this.lblVie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVie.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblVie.Location = new System.Drawing.Point(0, 0);
            this.lblVie.Margin = new System.Windows.Forms.Padding(0);
            this.lblVie.Name = "lblVie";
            this.lblVie.Size = new System.Drawing.Size(232, 42);
            this.lblVie.TabIndex = 0;
            this.lblVie.Text = "Vie";
            this.lblVie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSab
            // 
            this.lblSab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSab.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblSab.Location = new System.Drawing.Point(0, 0);
            this.lblSab.Margin = new System.Windows.Forms.Padding(0);
            this.lblSab.Name = "lblSab";
            this.lblSab.Size = new System.Drawing.Size(232, 42);
            this.lblSab.TabIndex = 0;
            this.lblSab.Text = "Sáb";
            this.lblSab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpCalendario
            // 
            this.tlpCalendario.BackColor = System.Drawing.Color.White;
            this.tlpCalendario.ColumnCount = 7;
            this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpCalendario.Controls.Add(this.dia1, 0, 0);
            this.tlpCalendario.Controls.Add(this.dia2, 1, 0);
            this.tlpCalendario.Controls.Add(this.dia3, 2, 0);
            this.tlpCalendario.Controls.Add(this.dia4, 3, 0);
            this.tlpCalendario.Controls.Add(this.dia5, 4, 0);
            this.tlpCalendario.Controls.Add(this.dia6, 5, 0);
            this.tlpCalendario.Controls.Add(this.dia7, 6, 0);
            this.tlpCalendario.Controls.Add(this.dia8, 0, 1);
            this.tlpCalendario.Controls.Add(this.dia9, 1, 1);
            this.tlpCalendario.Controls.Add(this.dia10, 2, 1);
            this.tlpCalendario.Controls.Add(this.dia11, 3, 1);
            this.tlpCalendario.Controls.Add(this.dia12, 4, 1);
            this.tlpCalendario.Controls.Add(this.dia13, 5, 1);
            this.tlpCalendario.Controls.Add(this.dia14, 6, 1);
            this.tlpCalendario.Controls.Add(this.dia15, 0, 2);
            this.tlpCalendario.Controls.Add(this.dia16, 1, 2);
            this.tlpCalendario.Controls.Add(this.dia17, 2, 2);
            this.tlpCalendario.Controls.Add(this.dia18, 3, 2);
            this.tlpCalendario.Controls.Add(this.dia19, 4, 2);
            this.tlpCalendario.Controls.Add(this.dia20, 5, 2);
            this.tlpCalendario.Controls.Add(this.dia21, 6, 2);
            this.tlpCalendario.Controls.Add(this.dia22, 0, 3);
            this.tlpCalendario.Controls.Add(this.dia23, 1, 3);
            this.tlpCalendario.Controls.Add(this.dia24, 2, 3);
            this.tlpCalendario.Controls.Add(this.dia25, 3, 3);
            this.tlpCalendario.Controls.Add(this.dia26, 4, 3);
            this.tlpCalendario.Controls.Add(this.dia27, 5, 3);
            this.tlpCalendario.Controls.Add(this.dia28, 6, 3);
            this.tlpCalendario.Controls.Add(this.dia29, 0, 4);
            this.tlpCalendario.Controls.Add(this.dia30, 1, 4);
            this.tlpCalendario.Controls.Add(this.dia31, 2, 4);
            this.tlpCalendario.Controls.Add(this.dia32, 3, 4);
            this.tlpCalendario.Controls.Add(this.dia33, 4, 4);
            this.tlpCalendario.Controls.Add(this.dia34, 5, 4);
            this.tlpCalendario.Controls.Add(this.dia35, 6, 4);
            this.tlpCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCalendario.Location = new System.Drawing.Point(0, 124);
            this.tlpCalendario.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCalendario.Name = "tlpCalendario";
            this.tlpCalendario.RowCount = 5;
            this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCalendario.Size = new System.Drawing.Size(1626, 847);
            this.tlpCalendario.TabIndex = 2;
            // 
            // dia1
            // 
            this.dia1.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia1.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia1.Dia = "26";
            this.dia1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia1.Evento = "";
            this.dia1.Location = new System.Drawing.Point(0, 0);
            this.dia1.Margin = new System.Windows.Forms.Padding(0);
            this.dia1.MostrarEvento = false;
            this.dia1.Name = "dia1";
            this.dia1.Size = new System.Drawing.Size(210, 100);
            this.dia1.TabIndex = 0;
            // 
            // dia2
            // 
            this.dia2.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia2.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia2.Dia = "27";
            this.dia2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia2.Evento = "";
            this.dia2.Location = new System.Drawing.Point(0, 0);
            this.dia2.Margin = new System.Windows.Forms.Padding(0);
            this.dia2.MostrarEvento = false;
            this.dia2.Name = "dia2";
            this.dia2.Size = new System.Drawing.Size(210, 100);
            this.dia2.TabIndex = 1;
            // 
            // dia3
            // 
            this.dia3.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia3.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia3.Dia = "28";
            this.dia3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia3.Evento = "";
            this.dia3.Location = new System.Drawing.Point(0, 0);
            this.dia3.Margin = new System.Windows.Forms.Padding(0);
            this.dia3.MostrarEvento = false;
            this.dia3.Name = "dia3";
            this.dia3.Size = new System.Drawing.Size(210, 100);
            this.dia3.TabIndex = 2;
            // 
            // dia4
            // 
            this.dia4.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia4.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia4.Dia = "29";
            this.dia4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia4.Evento = "";
            this.dia4.Location = new System.Drawing.Point(0, 0);
            this.dia4.Margin = new System.Windows.Forms.Padding(0);
            this.dia4.MostrarEvento = false;
            this.dia4.Name = "dia4";
            this.dia4.Size = new System.Drawing.Size(210, 100);
            this.dia4.TabIndex = 3;
            // 
            // dia5
            // 
            this.dia5.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia5.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia5.Dia = "30";
            this.dia5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia5.Evento = "";
            this.dia5.Location = new System.Drawing.Point(0, 0);
            this.dia5.Margin = new System.Windows.Forms.Padding(0);
            this.dia5.MostrarEvento = false;
            this.dia5.Name = "dia5";
            this.dia5.Size = new System.Drawing.Size(210, 100);
            this.dia5.TabIndex = 4;
            // 
            // dia6
            // 
            this.dia6.ColorEvento = System.Drawing.Color.FromArgb(255, 232, 232);
            this.dia6.ColorTextoEvento = System.Drawing.Color.FromArgb(229, 37, 42);
            this.dia6.Dia = "1";
            this.dia6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia6.Evento = "Informe mensual vence";
            this.dia6.Location = new System.Drawing.Point(0, 0);
            this.dia6.Margin = new System.Windows.Forms.Padding(0);
            this.dia6.MostrarEvento = true;
            this.dia6.Name = "dia6";
            this.dia6.Size = new System.Drawing.Size(210, 100);
            this.dia6.TabIndex = 5;
            // 
            // dia7
            // 
            this.dia7.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia7.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia7.Dia = "2";
            this.dia7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia7.Evento = "";
            this.dia7.Location = new System.Drawing.Point(0, 0);
            this.dia7.Margin = new System.Windows.Forms.Padding(0);
            this.dia7.MostrarEvento = false;
            this.dia7.Name = "dia7";
            this.dia7.Size = new System.Drawing.Size(210, 100);
            this.dia7.TabIndex = 6;
            // 
            // dia8
            // 
            this.dia8.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia8.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia8.Dia = "3";
            this.dia8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia8.Evento = "";
            this.dia8.Location = new System.Drawing.Point(0, 0);
            this.dia8.Margin = new System.Windows.Forms.Padding(0);
            this.dia8.MostrarEvento = false;
            this.dia8.Name = "dia8";
            this.dia8.Size = new System.Drawing.Size(210, 100);
            this.dia8.TabIndex = 7;
            // 
            // dia9
            // 
            this.dia9.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia9.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia9.Dia = "4";
            this.dia9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia9.Evento = "Realizar tarea 1";
            this.dia9.Location = new System.Drawing.Point(0, 0);
            this.dia9.Margin = new System.Windows.Forms.Padding(0);
            this.dia9.MostrarEvento = true;
            this.dia9.Name = "dia9";
            this.dia9.Size = new System.Drawing.Size(210, 100);
            this.dia9.TabIndex = 8;
            // 
            // dia10
            // 
            this.dia10.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia10.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia10.Dia = "5";
            this.dia10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia10.Evento = "";
            this.dia10.Location = new System.Drawing.Point(0, 0);
            this.dia10.Margin = new System.Windows.Forms.Padding(0);
            this.dia10.MostrarEvento = false;
            this.dia10.Name = "dia10";
            this.dia10.Size = new System.Drawing.Size(210, 100);
            this.dia10.TabIndex = 9;
            // 
            // dia11
            // 
            this.dia11.ColorEvento = System.Drawing.Color.FromArgb(255, 246, 218);
            this.dia11.ColorTextoEvento = System.Drawing.Color.FromArgb(215, 145, 0);
            this.dia11.Dia = "6";
            this.dia11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia11.Evento = "Reunión";
            this.dia11.Location = new System.Drawing.Point(0, 0);
            this.dia11.Margin = new System.Windows.Forms.Padding(0);
            this.dia11.MostrarEvento = true;
            this.dia11.Name = "dia11";
            this.dia11.Size = new System.Drawing.Size(210, 100);
            this.dia11.TabIndex = 10;
            // 
            // dia12
            // 
            this.dia12.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia12.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia12.Dia = "7";
            this.dia12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia12.Evento = "";
            this.dia12.Location = new System.Drawing.Point(0, 0);
            this.dia12.Margin = new System.Windows.Forms.Padding(0);
            this.dia12.MostrarEvento = false;
            this.dia12.Name = "dia12";
            this.dia12.Size = new System.Drawing.Size(210, 100);
            this.dia12.TabIndex = 11;
            // 
            // dia13
            // 
            this.dia13.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia13.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia13.Dia = "8";
            this.dia13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia13.Evento = "Realizar tarea 2";
            this.dia13.Location = new System.Drawing.Point(0, 0);
            this.dia13.Margin = new System.Windows.Forms.Padding(0);
            this.dia13.MostrarEvento = true;
            this.dia13.Name = "dia13";
            this.dia13.Size = new System.Drawing.Size(210, 100);
            this.dia13.TabIndex = 12;
            // 
            // dia14
            // 
            this.dia14.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia14.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia14.Dia = "9";
            this.dia14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia14.Evento = "Realizar tarea 3";
            this.dia14.Location = new System.Drawing.Point(0, 0);
            this.dia14.Margin = new System.Windows.Forms.Padding(0);
            this.dia14.MostrarEvento = true;
            this.dia14.Name = "dia14";
            this.dia14.Size = new System.Drawing.Size(210, 100);
            this.dia14.TabIndex = 13;
            // 
            // dia15
            // 
            this.dia15.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia15.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia15.Dia = "10";
            this.dia15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia15.Evento = "";
            this.dia15.Location = new System.Drawing.Point(0, 0);
            this.dia15.Margin = new System.Windows.Forms.Padding(0);
            this.dia15.MostrarEvento = false;
            this.dia15.Name = "dia15";
            this.dia15.Size = new System.Drawing.Size(210, 100);
            this.dia15.TabIndex = 14;
            // 
            // dia16
            // 
            this.dia16.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia16.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia16.Dia = "11";
            this.dia16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia16.Evento = "";
            this.dia16.Location = new System.Drawing.Point(0, 0);
            this.dia16.Margin = new System.Windows.Forms.Padding(0);
            this.dia16.MostrarEvento = false;
            this.dia16.Name = "dia16";
            this.dia16.Size = new System.Drawing.Size(210, 100);
            this.dia16.TabIndex = 15;
            // 
            // dia17
            // 
            this.dia17.ColorEvento = System.Drawing.Color.FromArgb(255, 246, 218);
            this.dia17.ColorTextoEvento = System.Drawing.Color.FromArgb(215, 145, 0);
            this.dia17.Dia = "12";
            this.dia17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia17.Evento = "Reunión";
            this.dia17.Location = new System.Drawing.Point(0, 0);
            this.dia17.Margin = new System.Windows.Forms.Padding(0);
            this.dia17.MostrarEvento = true;
            this.dia17.Name = "dia17";
            this.dia17.Size = new System.Drawing.Size(210, 100);
            this.dia17.TabIndex = 16;
            // 
            // dia18
            // 
            this.dia18.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia18.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia18.Dia = "13";
            this.dia18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia18.Evento = "";
            this.dia18.Location = new System.Drawing.Point(0, 0);
            this.dia18.Margin = new System.Windows.Forms.Padding(0);
            this.dia18.MostrarEvento = false;
            this.dia18.Name = "dia18";
            this.dia18.Size = new System.Drawing.Size(210, 100);
            this.dia18.TabIndex = 17;
            // 
            // dia19
            // 
            this.dia19.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia19.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia19.Dia = "14";
            this.dia19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia19.Evento = "";
            this.dia19.Location = new System.Drawing.Point(0, 0);
            this.dia19.Margin = new System.Windows.Forms.Padding(0);
            this.dia19.MostrarEvento = false;
            this.dia19.Name = "dia19";
            this.dia19.Size = new System.Drawing.Size(210, 100);
            this.dia19.TabIndex = 18;
            // 
            // dia20
            // 
            this.dia20.ColorEvento = System.Drawing.Color.FromArgb(255, 246, 218);
            this.dia20.ColorTextoEvento = System.Drawing.Color.FromArgb(215, 145, 0);
            this.dia20.Dia = "15";
            this.dia20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia20.Evento = "Hito 1";
            this.dia20.Location = new System.Drawing.Point(0, 0);
            this.dia20.Margin = new System.Windows.Forms.Padding(0);
            this.dia20.MostrarEvento = true;
            this.dia20.Name = "dia20";
            this.dia20.Size = new System.Drawing.Size(210, 100);
            this.dia20.TabIndex = 19;
            // 
            // dia21
            // 
            this.dia21.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia21.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia21.Dia = "16";
            this.dia21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia21.Evento = "";
            this.dia21.Location = new System.Drawing.Point(0, 0);
            this.dia21.Margin = new System.Windows.Forms.Padding(0);
            this.dia21.MostrarEvento = false;
            this.dia21.Name = "dia21";
            this.dia21.Size = new System.Drawing.Size(210, 100);
            this.dia21.TabIndex = 20;
            // 
            // dia22
            // 
            this.dia22.ColorEvento = System.Drawing.Color.FromArgb(255, 246, 218);
            this.dia22.ColorTextoEvento = System.Drawing.Color.FromArgb(215, 145, 0);
            this.dia22.Dia = "17";
            this.dia22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia22.Evento = "Hito 2";
            this.dia22.Location = new System.Drawing.Point(0, 0);
            this.dia22.Margin = new System.Windows.Forms.Padding(0);
            this.dia22.MostrarEvento = true;
            this.dia22.Name = "dia22";
            this.dia22.Size = new System.Drawing.Size(210, 100);
            this.dia22.TabIndex = 21;
            // 
            // dia23
            // 
            this.dia23.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia23.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia23.Dia = "18";
            this.dia23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia23.Evento = "";
            this.dia23.Location = new System.Drawing.Point(0, 0);
            this.dia23.Margin = new System.Windows.Forms.Padding(0);
            this.dia23.MostrarEvento = false;
            this.dia23.Name = "dia23";
            this.dia23.Size = new System.Drawing.Size(210, 100);
            this.dia23.TabIndex = 22;
            // 
            // dia24
            // 
            this.dia24.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia24.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia24.Dia = "19";
            this.dia24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia24.Evento = "";
            this.dia24.Location = new System.Drawing.Point(0, 0);
            this.dia24.Margin = new System.Windows.Forms.Padding(0);
            this.dia24.MostrarEvento = false;
            this.dia24.Name = "dia24";
            this.dia24.Size = new System.Drawing.Size(210, 100);
            this.dia24.TabIndex = 23;
            // 
            // dia25
            // 
            this.dia25.ColorEvento = System.Drawing.Color.FromArgb(255, 246, 218);
            this.dia25.ColorTextoEvento = System.Drawing.Color.FromArgb(215, 145, 0);
            this.dia25.Dia = "20";
            this.dia25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia25.Evento = "Enviar evidencia";
            this.dia25.Location = new System.Drawing.Point(0, 0);
            this.dia25.Margin = new System.Windows.Forms.Padding(0);
            this.dia25.MostrarEvento = true;
            this.dia25.Name = "dia25";
            this.dia25.Size = new System.Drawing.Size(210, 100);
            this.dia25.TabIndex = 24;
            // 
            // dia26
            // 
            this.dia26.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia26.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia26.Dia = "21";
            this.dia26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia26.Evento = "";
            this.dia26.Location = new System.Drawing.Point(0, 0);
            this.dia26.Margin = new System.Windows.Forms.Padding(0);
            this.dia26.MostrarEvento = false;
            this.dia26.Name = "dia26";
            this.dia26.Size = new System.Drawing.Size(210, 100);
            this.dia26.TabIndex = 25;
            // 
            // dia27
            // 
            this.dia27.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia27.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia27.Dia = "22";
            this.dia27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia27.Evento = "";
            this.dia27.Location = new System.Drawing.Point(0, 0);
            this.dia27.Margin = new System.Windows.Forms.Padding(0);
            this.dia27.MostrarEvento = false;
            this.dia27.Name = "dia27";
            this.dia27.Size = new System.Drawing.Size(210, 100);
            this.dia27.TabIndex = 26;
            // 
            // dia28
            // 
            this.dia28.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia28.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia28.Dia = "23";
            this.dia28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia28.Evento = "";
            this.dia28.Location = new System.Drawing.Point(0, 0);
            this.dia28.Margin = new System.Windows.Forms.Padding(0);
            this.dia28.MostrarEvento = false;
            this.dia28.Name = "dia28";
            this.dia28.Size = new System.Drawing.Size(210, 100);
            this.dia28.TabIndex = 27;
            // 
            // dia29
            // 
            this.dia29.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia29.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia29.Dia = "24";
            this.dia29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia29.Evento = "";
            this.dia29.Location = new System.Drawing.Point(0, 0);
            this.dia29.Margin = new System.Windows.Forms.Padding(0);
            this.dia29.MostrarEvento = false;
            this.dia29.Name = "dia29";
            this.dia29.Size = new System.Drawing.Size(210, 100);
            this.dia29.TabIndex = 28;
            // 
            // dia30
            // 
            this.dia30.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia30.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia30.Dia = "25";
            this.dia30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia30.Evento = "";
            this.dia30.Location = new System.Drawing.Point(0, 0);
            this.dia30.Margin = new System.Windows.Forms.Padding(0);
            this.dia30.MostrarEvento = false;
            this.dia30.Name = "dia30";
            this.dia30.Size = new System.Drawing.Size(210, 100);
            this.dia30.TabIndex = 29;
            // 
            // dia31
            // 
            this.dia31.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia31.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia31.Dia = "26";
            this.dia31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia31.Evento = "";
            this.dia31.Location = new System.Drawing.Point(0, 0);
            this.dia31.Margin = new System.Windows.Forms.Padding(0);
            this.dia31.MostrarEvento = false;
            this.dia31.Name = "dia31";
            this.dia31.Size = new System.Drawing.Size(210, 100);
            this.dia31.TabIndex = 30;
            // 
            // dia32
            // 
            this.dia32.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia32.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia32.Dia = "27";
            this.dia32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia32.Evento = "";
            this.dia32.Location = new System.Drawing.Point(0, 0);
            this.dia32.Margin = new System.Windows.Forms.Padding(0);
            this.dia32.MostrarEvento = false;
            this.dia32.Name = "dia32";
            this.dia32.Size = new System.Drawing.Size(210, 100);
            this.dia32.TabIndex = 31;
            // 
            // dia33
            // 
            this.dia33.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia33.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia33.Dia = "28";
            this.dia33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia33.Evento = "";
            this.dia33.Location = new System.Drawing.Point(0, 0);
            this.dia33.Margin = new System.Windows.Forms.Padding(0);
            this.dia33.MostrarEvento = false;
            this.dia33.Name = "dia33";
            this.dia33.Size = new System.Drawing.Size(210, 100);
            this.dia33.TabIndex = 32;
            // 
            // dia34
            // 
            this.dia34.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia34.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia34.Dia = "29";
            this.dia34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia34.Evento = "";
            this.dia34.Location = new System.Drawing.Point(0, 0);
            this.dia34.Margin = new System.Windows.Forms.Padding(0);
            this.dia34.MostrarEvento = false;
            this.dia34.Name = "dia34";
            this.dia34.Size = new System.Drawing.Size(210, 100);
            this.dia34.TabIndex = 33;
            // 
            // dia35
            // 
            this.dia35.ColorEvento = System.Drawing.Color.FromArgb(232, 242, 255);
            this.dia35.ColorTextoEvento = System.Drawing.Color.FromArgb(0, 105, 240);
            this.dia35.Dia = "30";
            this.dia35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dia35.Evento = "";
            this.dia35.Location = new System.Drawing.Point(0, 0);
            this.dia35.Margin = new System.Windows.Forms.Padding(0);
            this.dia35.MostrarEvento = false;
            this.dia35.Name = "dia35";
            this.dia35.Size = new System.Drawing.Size(210, 100);
            this.dia35.TabIndex = 34;
            // 
            // flpLeyenda
            // 
            this.flpLeyenda.Controls.Add(this.lblLeyendaTarea);
            this.flpLeyenda.Controls.Add(this.lblLeyendaHito);
            this.flpLeyenda.Controls.Add(this.lblLeyendaVencida);
            this.flpLeyenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLeyenda.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpLeyenda.Location = new System.Drawing.Point(0, 971);
            this.flpLeyenda.Margin = new System.Windows.Forms.Padding(0);
            this.flpLeyenda.Name = "flpLeyenda";
            this.flpLeyenda.Padding = new System.Windows.Forms.Padding(4, 6, 0, 0);
            this.flpLeyenda.Size = new System.Drawing.Size(1626, 32);
            this.flpLeyenda.TabIndex = 3;
            // 
            // lblLeyendaTarea
            // 
            this.lblLeyendaTarea.AutoSize = true;
            this.lblLeyendaTarea.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLeyendaTarea.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblLeyendaTarea.Location = new System.Drawing.Point(7, 6);
            this.lblLeyendaTarea.Margin = new System.Windows.Forms.Padding(3, 0, 18, 0);
            this.lblLeyendaTarea.Name = "lblLeyendaTarea";
            this.lblLeyendaTarea.Size = new System.Drawing.Size(70, 20);
            this.lblLeyendaTarea.TabIndex = 0;
            this.lblLeyendaTarea.Text = "■ Tarea";
            // 
            // lblLeyendaHito
            // 
            this.lblLeyendaHito.AutoSize = true;
            this.lblLeyendaHito.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLeyendaHito.ForeColor = System.Drawing.Color.FromArgb(215, 145, 0);
            this.lblLeyendaHito.Location = new System.Drawing.Point(7, 6);
            this.lblLeyendaHito.Margin = new System.Windows.Forms.Padding(3, 0, 18, 0);
            this.lblLeyendaHito.Name = "lblLeyendaHito";
            this.lblLeyendaHito.Size = new System.Drawing.Size(70, 20);
            this.lblLeyendaHito.TabIndex = 0;
            this.lblLeyendaHito.Text = "■ Hito / Reunión";
            // 
            // lblLeyendaVencida
            // 
            this.lblLeyendaVencida.AutoSize = true;
            this.lblLeyendaVencida.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLeyendaVencida.ForeColor = System.Drawing.Color.FromArgb(229, 37, 42);
            this.lblLeyendaVencida.Location = new System.Drawing.Point(7, 6);
            this.lblLeyendaVencida.Margin = new System.Windows.Forms.Padding(3, 0, 18, 0);
            this.lblLeyendaVencida.Name = "lblLeyendaVencida";
            this.lblLeyendaVencida.Size = new System.Drawing.Size(70, 20);
            this.lblLeyendaVencida.TabIndex = 0;
            this.lblLeyendaVencida.Text = "■ Vencida";
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.Controls.Add(this.pnlViewport);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.frmCalendario_Load);
            this.Name = "frmCalendario";
            this.Text = "Mi calendario";
            this.flpLeyenda.ResumeLayout(false);
            this.flpLeyenda.PerformLayout();
            this.tlpCalendario.ResumeLayout(false);
            this.tlpDias.ResumeLayout(false);
            this.pnlTituloMes.ResumeLayout(false);
            this.pnlTituloMes.PerformLayout();
            this.tlpEncabezado.ResumeLayout(false);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnlCanvas.ResumeLayout(false);
            this.pnlViewport.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblBreadcrumbBase;
        private System.Windows.Forms.Label lblBreadcrumbActual;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlViewport;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpEncabezado;
        private System.Windows.Forms.Panel pnlTituloMes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ComboBox cboVista;
        private System.Windows.Forms.ComboBox cboProyecto;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TableLayoutPanel tlpDias;
        private System.Windows.Forms.Label lblDom;
        private System.Windows.Forms.Label lblLun;
        private System.Windows.Forms.Label lblMar;
        private System.Windows.Forms.Label lblMie;
        private System.Windows.Forms.Label lblJue;
        private System.Windows.Forms.Label lblVie;
        private System.Windows.Forms.Label lblSab;
        private System.Windows.Forms.TableLayoutPanel tlpCalendario;
        private System.Windows.Forms.FlowLayoutPanel flpLeyenda;
        private System.Windows.Forms.Label lblLeyendaTarea;
        private System.Windows.Forms.Label lblLeyendaHito;
        private System.Windows.Forms.Label lblLeyendaVencida;
        private Vista.UCCeldaCalendario dia1;
        private Vista.UCCeldaCalendario dia2;
        private Vista.UCCeldaCalendario dia3;
        private Vista.UCCeldaCalendario dia4;
        private Vista.UCCeldaCalendario dia5;
        private Vista.UCCeldaCalendario dia6;
        private Vista.UCCeldaCalendario dia7;
        private Vista.UCCeldaCalendario dia8;
        private Vista.UCCeldaCalendario dia9;
        private Vista.UCCeldaCalendario dia10;
        private Vista.UCCeldaCalendario dia11;
        private Vista.UCCeldaCalendario dia12;
        private Vista.UCCeldaCalendario dia13;
        private Vista.UCCeldaCalendario dia14;
        private Vista.UCCeldaCalendario dia15;
        private Vista.UCCeldaCalendario dia16;
        private Vista.UCCeldaCalendario dia17;
        private Vista.UCCeldaCalendario dia18;
        private Vista.UCCeldaCalendario dia19;
        private Vista.UCCeldaCalendario dia20;
        private Vista.UCCeldaCalendario dia21;
        private Vista.UCCeldaCalendario dia22;
        private Vista.UCCeldaCalendario dia23;
        private Vista.UCCeldaCalendario dia24;
        private Vista.UCCeldaCalendario dia25;
        private Vista.UCCeldaCalendario dia26;
        private Vista.UCCeldaCalendario dia27;
        private Vista.UCCeldaCalendario dia28;
        private Vista.UCCeldaCalendario dia29;
        private Vista.UCCeldaCalendario dia30;
        private Vista.UCCeldaCalendario dia31;
        private Vista.UCCeldaCalendario dia32;
        private Vista.UCCeldaCalendario dia33;
        private Vista.UCCeldaCalendario dia34;
        private Vista.UCCeldaCalendario dia35;
    }
}
