namespace Vista
{
    partial class frmNotificaciones
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
            this.lblFechaSuperior = new System.Windows.Forms.Label();
            this.lblBreadcrumbActual = new System.Windows.Forms.Label();
            this.lblBreadcrumbBase = new System.Windows.Forms.Label();
            this.pnlViewport = new System.Windows.Forms.Panel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCabecera = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitulos = new System.Windows.Forms.Panel();
            this.lblSinLeer = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMarcarTodas = new System.Windows.Forms.Button();
            this.tlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboPrioridad = new System.Windows.Forms.ComboBox();
            this.tlpNotificaciones = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTop.SuspendLayout();
            this.pnlViewport.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.tlpCabecera.SuspendLayout();
            this.pnlTitulos.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            this.tlpNotificaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblFechaSuperior);
            this.pnlTop.Controls.Add(this.lblBreadcrumbActual);
            this.pnlTop.Controls.Add(this.lblBreadcrumbBase);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1670, 43);
            this.pnlTop.TabIndex = 0;
            // 
            // lblFechaSuperior
            // 
            this.lblFechaSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaSuperior.AutoSize = true;
            this.lblFechaSuperior.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaSuperior.ForeColor = System.Drawing.Color.FromArgb(105, 118, 135);
            this.lblFechaSuperior.Location = new System.Drawing.Point(1610, 11);
            this.lblFechaSuperior.Name = "lblFechaSuperior";
            this.lblFechaSuperior.Size = new System.Drawing.Size(48, 20);
            this.lblFechaSuperior.TabIndex = 2;
            this.lblFechaSuperior.Text = "Fecha";
            // 
            // lblBreadcrumbActual
            // 
            this.lblBreadcrumbActual.AutoSize = true;
            this.lblBreadcrumbActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreadcrumbActual.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(74, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Size = new System.Drawing.Size(106, 20);
            this.lblBreadcrumbActual.TabIndex = 1;
            this.lblBreadcrumbActual.Text = "Notificaciones";
            // 
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(145, 151, 160);
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.Size = new System.Drawing.Size(54, 20);
            this.lblBreadcrumbBase.TabIndex = 0;
            this.lblBreadcrumbBase.Text = "Inicio >";
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
            this.tlpPrincipal.AutoSize = false;
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tlpCabecera, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpFiltros, 0, 1);
            this.tlpPrincipal.Controls.Add(this.tlpNotificaciones, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPrincipal.Location = new System.Drawing.Point(24, 24);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1622, 196);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // tlpCabecera
            // 
            this.tlpCabecera.ColumnCount = 2;
            this.tlpCabecera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpCabecera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpCabecera.Controls.Add(this.pnlTitulos, 0, 0);
            this.tlpCabecera.Controls.Add(this.btnMarcarTodas, 1, 0);
            this.tlpCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCabecera.Location = new System.Drawing.Point(0, 0);
            this.tlpCabecera.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCabecera.Name = "tlpCabecera";
            this.tlpCabecera.RowCount = 1;
            this.tlpCabecera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCabecera.Size = new System.Drawing.Size(1622, 76);
            this.tlpCabecera.TabIndex = 0;
            // 
            // pnlTitulos
            // 
            this.pnlTitulos.Controls.Add(this.lblSinLeer);
            this.pnlTitulos.Controls.Add(this.lblTitulo);
            this.pnlTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitulos.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulos.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitulos.Name = "pnlTitulos";
            this.pnlTitulos.Size = new System.Drawing.Size(1135, 76);
            this.pnlTitulos.TabIndex = 0;
            // 
            // lblSinLeer
            // 
            this.lblSinLeer.AutoSize = true;
            this.lblSinLeer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSinLeer.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblSinLeer.Location = new System.Drawing.Point(3, 47);
            this.lblSinLeer.Name = "lblSinLeer";
            this.lblSinLeer.Size = new System.Drawing.Size(76, 20);
            this.lblSinLeer.TabIndex = 1;
            this.lblSinLeer.Text = "3 sin leer";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Notificaciones";
            // 
            // btnMarcarTodas
            // 
            this.btnMarcarTodas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMarcarTodas.BackColor = System.Drawing.Color.White;
            this.btnMarcarTodas.Click += new System.EventHandler(this.btnMarcarTodas_Click);
            this.btnMarcarTodas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnMarcarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarTodas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMarcarTodas.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnMarcarTodas.Location = new System.Drawing.Point(1240, 20);
            this.btnMarcarTodas.Name = "btnMarcarTodas";
            this.btnMarcarTodas.Size = new System.Drawing.Size(200, 38);
            this.btnMarcarTodas.TabIndex = 1;
            this.btnMarcarTodas.Text = "Marcar todas como leídas";
            this.btnMarcarTodas.UseVisualStyleBackColor = false;
            // 
            // tlpFiltros
            // 
            this.tlpFiltros.ColumnCount = 4;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Controls.Add(this.lblFiltrar, 0, 0);
            this.tlpFiltros.Controls.Add(this.cboTipo, 1, 0);
            this.tlpFiltros.Controls.Add(this.cboPrioridad, 2, 0);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Location = new System.Drawing.Point(0, 76);
            this.tlpFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 1;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Size = new System.Drawing.Size(1622, 50);
            this.tlpFiltros.TabIndex = 1;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltrar.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblFiltrar.Location = new System.Drawing.Point(0, 15);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(49, 20);
            this.lblFiltrar.TabIndex = 0;
            this.lblFiltrar.Text = "Filtrar:";
            // 
            // cboTipo
            // 
            this.cboTipo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Todos los tipos",
            "Tarea vencida",
            "Tarea devuelta",
            "Información"});
            this.cboTipo.Location = new System.Drawing.Point(70, 11);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(0);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.filtros_SelectedIndexChanged);
            this.cboTipo.Size = new System.Drawing.Size(210, 28);
            this.cboTipo.TabIndex = 1;
            // 
            // cboPrioridad
            // 
            this.cboPrioridad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrioridad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPrioridad.FormattingEnabled = true;
            this.cboPrioridad.Items.AddRange(new object[] {
            "Todas las prioridades",
            "Alta",
            "Media",
            "Baja"});
            this.cboPrioridad.Location = new System.Drawing.Point(300, 11);
            this.cboPrioridad.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cboPrioridad.Name = "cboPrioridad";
            this.cboPrioridad.SelectedIndexChanged += new System.EventHandler(this.filtros_SelectedIndexChanged);
            this.cboPrioridad.Size = new System.Drawing.Size(230, 28);
            this.cboPrioridad.TabIndex = 2;
            // 
            // 
            this.tlpNotificaciones.AutoSize = false;
            this.tlpNotificaciones.BackColor = System.Drawing.Color.Transparent;
            this.tlpNotificaciones.ColumnCount = 1;
            this.tlpNotificaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNotificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNotificaciones.Location = new System.Drawing.Point(0, 126);
            this.tlpNotificaciones.Margin = new System.Windows.Forms.Padding(0);
            this.tlpNotificaciones.Name = "tlpNotificaciones";
            this.tlpNotificaciones.RowCount = 1;
            this.tlpNotificaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpNotificaciones.Size = new System.Drawing.Size(1622, 70);
            this.tlpNotificaciones.TabIndex = 2;
            // 
            // frmNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.Controls.Add(this.pnlViewport);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.frmNotificaciones_Load);
            this.Name = "frmNotificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificaciones";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlViewport.ResumeLayout(false);
            this.pnlViewport.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.tlpCabecera.ResumeLayout(false);
            this.pnlTitulos.ResumeLayout(false);
            this.pnlTitulos.PerformLayout();
            this.tlpFiltros.ResumeLayout(false);
            this.tlpFiltros.PerformLayout();
            this.tlpNotificaciones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFechaSuperior;
        private System.Windows.Forms.Label lblBreadcrumbActual;
        private System.Windows.Forms.Label lblBreadcrumbBase;
        private System.Windows.Forms.Panel pnlViewport;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpCabecera;
        private System.Windows.Forms.Panel pnlTitulos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSinLeer;
        private System.Windows.Forms.Button btnMarcarTodas;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboPrioridad;
        private System.Windows.Forms.TableLayoutPanel tlpNotificaciones;
    }
}
