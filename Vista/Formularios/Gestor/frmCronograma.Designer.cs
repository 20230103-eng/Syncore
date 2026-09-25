namespace Vista
{
    partial class frmCronograma
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle encabezado = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle filas = new System.Windows.Forms.DataGridViewCellStyle();
            encabezado.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            encabezado.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            encabezado.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            encabezado.SelectionBackColor = encabezado.BackColor;
            encabezado.SelectionForeColor = encabezado.ForeColor;
            filas.BackColor = System.Drawing.Color.White;
            filas.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            filas.ForeColor = System.Drawing.Color.FromArgb(55, 70, 88);
            filas.SelectionBackColor = System.Drawing.Color.FromArgb(232, 242, 255);
            filas.SelectionForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblBreadcrumbActual = new System.Windows.Forms.Label();
            this.lblBreadcrumbBase = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.cboProyecto = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.dgvCronograma = new System.Windows.Forms.DataGridView();
            this.ucPaginador = new Vista.UCPaginadorGrid();
            this.pnlTop.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            this.pnlTabla.SuspendLayout();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCronograma)).BeginInit();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblFecha);
            this.pnlTop.Controls.Add(this.lblBreadcrumbActual);
            this.pnlTop.Controls.Add(this.lblBreadcrumbBase);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(1670, 43);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblFecha.Location = new System.Drawing.Point(1587, 11);
            this.lblFecha.Text = "Fecha";
            // 
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(145, 151, 160);
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Text = "Planificación >";
            // 
            // lblBreadcrumbActual
            // 
            this.lblBreadcrumbActual.AutoSize = true;
            this.lblBreadcrumbActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreadcrumbActual.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(118, 11);
            this.lblBreadcrumbActual.Text = "Cronograma";
            // 
            // pnlContenido
            // 
            this.pnlContenido.AutoScroll = true;
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlContenido.Controls.Add(this.tlpPrincipal);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(24, 18, 24, 24);
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.pnlCabecera, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpFiltros, 0, 1);
            this.tlpPrincipal.Controls.Add(this.pnlTabla, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 720F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1622, 880);
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Controls.Add(this.lblSubtitulo);
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Text = "Cronograma";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(89, 105, 123);
            this.lblSubtitulo.Location = new System.Drawing.Point(2, 45);
            this.lblSubtitulo.Text = "Consulta tareas e hitos programados de los proyectos que administras.";
            // 
            // tlpFiltros
            // 
            this.tlpFiltros.ColumnCount = 10;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpFiltros.Controls.Add(this.lblProyecto, 0, 0);
            this.tlpFiltros.Controls.Add(this.cboProyecto, 1, 0);
            this.tlpFiltros.Controls.Add(this.lblDesde, 2, 0);
            this.tlpFiltros.Controls.Add(this.dtpDesde, 3, 0);
            this.tlpFiltros.Controls.Add(this.lblHasta, 4, 0);
            this.tlpFiltros.Controls.Add(this.dtpHasta, 5, 0);
            this.tlpFiltros.Controls.Add(this.lblTipo, 6, 0);
            this.tlpFiltros.Controls.Add(this.cboTipo, 7, 0);
            this.tlpFiltros.Controls.Add(this.btnActualizar, 8, 0);
            this.tlpFiltros.Controls.Add(this.lblCantidad, 9, 0);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            // 
            // lblProyecto
            // 
            this.lblProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProyecto.Text = "Proyecto:";
            this.lblProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboProyecto
            // 
            this.cboProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProyecto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboProyecto.SelectedIndexChanged += new System.EventHandler(this.filtros_Cambio);
            this.cboProyecto.TabIndex = 0;
            // 
            // lblDesde
            // 
            this.lblDesde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.TabIndex = 1;
            // 
            // lblHasta
            // 
            this.lblHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTipo
            // 
            this.cboTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Items.AddRange(new object[] { "Todos", "Solo tareas", "Solo hitos" });
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            this.cboTipo.TabIndex = 3;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblCantidad.Text = "0 elemento(s)";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTabla
            // 
            this.pnlTabla.BackColor = System.Drawing.Color.White;
            this.pnlTabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTabla.Controls.Add(this.dgvCronograma);
            this.pnlTabla.Controls.Add(this.ucPaginador);
            this.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // dgvCronograma
            // 
            this.dgvCronograma.AllowUserToAddRows = false;
            this.dgvCronograma.AllowUserToDeleteRows = false;
            this.dgvCronograma.AllowUserToResizeRows = false;
            this.dgvCronograma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCronograma.BackgroundColor = System.Drawing.Color.White;
            this.dgvCronograma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCronograma.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCronograma.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCronograma_CellFormatting);
            this.dgvCronograma.ColumnHeadersDefaultCellStyle = encabezado;
            this.dgvCronograma.ColumnHeadersHeight = 40;
            this.dgvCronograma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCronograma.EnableHeadersVisualStyles = false;
            this.dgvCronograma.ReadOnly = true;
            this.dgvCronograma.RowHeadersVisible = false;
            this.dgvCronograma.RowsDefaultCellStyle = filas;
            this.dgvCronograma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            //
            //
            this.ucPaginador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPaginador.Location = new System.Drawing.Point(0, 0);
            this.ucPaginador.Margin = new System.Windows.Forms.Padding(0);
            this.ucPaginador.Name = "ucPaginador";
            this.ucPaginador.Size = new System.Drawing.Size(800, 42);
            this.ucPaginador.TabIndex = 20;
            this.ucPaginador.Visible = false;
            // frmCronograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.frmCronograma_Load);
            this.MinimumSize = new System.Drawing.Size(1050, 700);
            this.Name = "frmCronograma";
            this.Text = "Cronograma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCronograma)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.tlpFiltros.ResumeLayout(false);
            this.pnlTabla.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblBreadcrumbActual;
        private System.Windows.Forms.Label lblBreadcrumbBase;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.ComboBox cboProyecto;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.DataGridView dgvCronograma;
        private Vista.UCPaginadorGrid ucPaginador;
    }
}
