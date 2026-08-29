namespace Vista
{
    partial class frmRevisionTareas
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
            System.Windows.Forms.DataGridViewCellStyle estiloEncabezado = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloFila = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblBreadcrumbActual = new System.Windows.Forms.Label();
            this.lblBreadcrumbBase = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.dgvRevisiones = new System.Windows.Forms.DataGridView();
            this.lblListaTitulo = new System.Windows.Forms.Label();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.tlpDetalle = new System.Windows.Forms.TableLayoutPanel();
            this.lblTareaTitulo = new System.Windows.Forms.Label();
            this.lblTareaValor = new System.Windows.Forms.Label();
            this.lblProyectoTitulo = new System.Windows.Forms.Label();
            this.lblProyectoValor = new System.Windows.Forms.Label();
            this.lblResponsableTitulo = new System.Windows.Forms.Label();
            this.lblResponsableValor = new System.Windows.Forms.Label();
            this.lblEnvioTitulo = new System.Windows.Forms.Label();
            this.lblEnvioValor = new System.Windows.Forms.Label();
            this.lblLimiteTitulo = new System.Windows.Forms.Label();
            this.lblLimiteValor = new System.Windows.Forms.Label();
            this.lblPrioridadTitulo = new System.Windows.Forms.Label();
            this.lblPrioridadValor = new System.Windows.Forms.Label();
            this.lblAvanceTitulo = new System.Windows.Forms.Label();
            this.lblAvanceValor = new System.Windows.Forms.Label();
            this.lblEvidenciasTitulo = new System.Windows.Forms.Label();
            this.lblEvidenciasValor = new System.Windows.Forms.Label();
            this.lblDescripcionTitulo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblObservacionesTitulo = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblUltimoAvanceTitulo = new System.Windows.Forms.Label();
            this.txtUltimoAvance = new System.Windows.Forms.TextBox();
            this.lblComentarioTitulo = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnSolicitarCorreccion = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.lblDetalleTitulo = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.tlpContenido.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevisiones)).BeginInit();
            this.pnlDetalle.SuspendLayout();
            this.tlpDetalle.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
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
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblFecha.Location = new System.Drawing.Point(1588, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblBreadcrumbActual
            // 
            this.lblBreadcrumbActual.AutoSize = true;
            this.lblBreadcrumbActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreadcrumbActual.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(82, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Size = new System.Drawing.Size(127, 20);
            this.lblBreadcrumbActual.TabIndex = 1;
            this.lblBreadcrumbActual.Text = "Revisión de tareas";
            // 
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(145, 151, 160);
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.Size = new System.Drawing.Size(61, 20);
            this.lblBreadcrumbBase.TabIndex = 0;
            this.lblBreadcrumbBase.Text = "Tareas >";
            // 
            // pnlContenido
            // 
            this.pnlContenido.AutoScroll = true;
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlContenido.Controls.Add(this.tlpContenido);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 43);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(28, 22, 28, 28);
            this.pnlContenido.Size = new System.Drawing.Size(1670, 1037);
            this.pnlContenido.TabIndex = 1;
            // 
            // tlpContenido
            // 
            this.tlpContenido.ColumnCount = 1;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Controls.Add(this.pnlCabecera, 0, 0);
            this.tlpContenido.Controls.Add(this.pnlBusqueda, 0, 1);
            this.tlpContenido.Controls.Add(this.tlpPrincipal, 0, 2);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpContenido.Location = new System.Drawing.Point(28, 22);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.RowCount = 3;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 790F));
            this.tlpContenido.Size = new System.Drawing.Size(1614, 942);
            this.tlpContenido.TabIndex = 0;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Controls.Add(this.lblCantidad);
            this.pnlCabecera.Controls.Add(this.lblSubtitulo);
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1614, 90);
            this.pnlCabecera.TabIndex = 0;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.FromArgb(255, 244, 220);
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(197, 120, 35);
            this.lblCantidad.Location = new System.Drawing.Point(1478, 14);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.lblCantidad.Size = new System.Drawing.Size(110, 28);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "0 pendiente(s)";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(89, 105, 123);
            this.lblSubtitulo.Location = new System.Drawing.Point(3, 53);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(455, 21);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Revise las tareas enviadas por los colaboradores y apruebe o solicite correcciones.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(0, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(253, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Revisión de tareas";
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.Color.White;
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBusqueda.Controls.Add(this.txtBuscar);
            this.pnlBusqueda.Controls.Add(this.lblBuscar);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBusqueda.Location = new System.Drawing.Point(0, 90);
            this.pnlBusqueda.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(1614, 52);
            this.pnlBusqueda.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(82, 11);
            this.txtBuscar.MaxLength = 150;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ShortcutsEnabled = false;
            this.txtBuscar.Size = new System.Drawing.Size(1508, 27);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblBuscar.Location = new System.Drawing.Point(13, 14);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(55, 20);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar";
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tlpPrincipal.Controls.Add(this.pnlLista, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnlDetalle, 1, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 152);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1614, 790);
            this.tlpPrincipal.TabIndex = 2;
            // 
            // pnlLista
            // 
            this.pnlLista.BackColor = System.Drawing.Color.White;
            this.pnlLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLista.Controls.Add(this.dgvRevisiones);
            this.pnlLista.Controls.Add(this.lblListaTitulo);
            this.pnlLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLista.Location = new System.Drawing.Point(0, 0);
            this.pnlLista.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Size = new System.Drawing.Size(896, 790);
            this.pnlLista.TabIndex = 0;
            // 
            // dgvRevisiones
            // 
            this.dgvRevisiones.AllowUserToAddRows = false;
            this.dgvRevisiones.AllowUserToDeleteRows = false;
            this.dgvRevisiones.AllowUserToResizeRows = false;
            this.dgvRevisiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevisiones.BackgroundColor = System.Drawing.Color.White;
            this.dgvRevisiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRevisiones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            estiloEncabezado.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            estiloEncabezado.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            estiloEncabezado.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            estiloEncabezado.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            estiloEncabezado.SelectionBackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            estiloEncabezado.SelectionForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.dgvRevisiones.ColumnHeadersDefaultCellStyle = estiloEncabezado;
            this.dgvRevisiones.ColumnHeadersHeight = 38;
            this.dgvRevisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRevisiones.EnableHeadersVisualStyles = false;
            this.dgvRevisiones.GridColor = System.Drawing.Color.FromArgb(226, 232, 239);
            this.dgvRevisiones.Location = new System.Drawing.Point(0, 38);
            this.dgvRevisiones.MultiSelect = false;
            this.dgvRevisiones.Name = "dgvRevisiones";
            this.dgvRevisiones.ReadOnly = true;
            this.dgvRevisiones.RowHeadersVisible = false;
            estiloFila.BackColor = System.Drawing.Color.White;
            estiloFila.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            estiloFila.ForeColor = System.Drawing.Color.FromArgb(61, 74, 89);
            estiloFila.SelectionBackColor = System.Drawing.Color.FromArgb(230, 241, 255);
            estiloFila.SelectionForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.dgvRevisiones.RowsDefaultCellStyle = estiloFila;
            this.dgvRevisiones.RowTemplate.Height = 36;
            this.dgvRevisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRevisiones.Size = new System.Drawing.Size(894, 750);
            this.dgvRevisiones.TabIndex = 1;
            this.dgvRevisiones.SelectionChanged += new System.EventHandler(this.dgvRevisiones_SelectionChanged);
            // 
            // lblListaTitulo
            // 
            this.lblListaTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblListaTitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblListaTitulo.ForeColor = System.Drawing.Color.FromArgb(54, 70, 88);
            this.lblListaTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblListaTitulo.Name = "lblListaTitulo";
            this.lblListaTitulo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblListaTitulo.Size = new System.Drawing.Size(894, 38);
            this.lblListaTitulo.TabIndex = 0;
            this.lblListaTitulo.Text = "Tareas pendientes de revisión";
            this.lblListaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.BackColor = System.Drawing.Color.White;
            this.pnlDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetalle.Controls.Add(this.tlpDetalle);
            this.pnlDetalle.Controls.Add(this.pnlAcciones);
            this.pnlDetalle.Controls.Add(this.lblDetalleTitulo);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalle.Location = new System.Drawing.Point(910, 0);
            this.pnlDetalle.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(704, 790);
            this.pnlDetalle.TabIndex = 1;
            // 
            // tlpDetalle
            // 
            this.tlpDetalle.ColumnCount = 2;
            this.tlpDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tlpDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetalle.Controls.Add(this.lblTareaTitulo, 0, 0);
            this.tlpDetalle.Controls.Add(this.lblTareaValor, 1, 0);
            this.tlpDetalle.Controls.Add(this.lblProyectoTitulo, 0, 1);
            this.tlpDetalle.Controls.Add(this.lblProyectoValor, 1, 1);
            this.tlpDetalle.Controls.Add(this.lblResponsableTitulo, 0, 2);
            this.tlpDetalle.Controls.Add(this.lblResponsableValor, 1, 2);
            this.tlpDetalle.Controls.Add(this.lblEnvioTitulo, 0, 3);
            this.tlpDetalle.Controls.Add(this.lblEnvioValor, 1, 3);
            this.tlpDetalle.Controls.Add(this.lblLimiteTitulo, 0, 4);
            this.tlpDetalle.Controls.Add(this.lblLimiteValor, 1, 4);
            this.tlpDetalle.Controls.Add(this.lblPrioridadTitulo, 0, 5);
            this.tlpDetalle.Controls.Add(this.lblPrioridadValor, 1, 5);
            this.tlpDetalle.Controls.Add(this.lblAvanceTitulo, 0, 6);
            this.tlpDetalle.Controls.Add(this.lblAvanceValor, 1, 6);
            this.tlpDetalle.Controls.Add(this.lblEvidenciasTitulo, 0, 7);
            this.tlpDetalle.Controls.Add(this.lblEvidenciasValor, 1, 7);
            this.tlpDetalle.Controls.Add(this.lblDescripcionTitulo, 0, 8);
            this.tlpDetalle.Controls.Add(this.txtDescripcion, 1, 8);
            this.tlpDetalle.Controls.Add(this.lblObservacionesTitulo, 0, 9);
            this.tlpDetalle.Controls.Add(this.txtObservaciones, 1, 9);
            this.tlpDetalle.Controls.Add(this.lblUltimoAvanceTitulo, 0, 10);
            this.tlpDetalle.Controls.Add(this.txtUltimoAvance, 1, 10);
            this.tlpDetalle.Controls.Add(this.lblComentarioTitulo, 0, 11);
            this.tlpDetalle.Controls.Add(this.txtComentario, 1, 11);
            this.tlpDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetalle.Location = new System.Drawing.Point(0, 38);
            this.tlpDetalle.Name = "tlpDetalle";
            this.tlpDetalle.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.tlpDetalle.RowCount = 12;
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetalle.Size = new System.Drawing.Size(702, 682);
            this.tlpDetalle.TabIndex = 1;
            // labels and value labels
            // 
            // lblTareaTitulo
            // 
            this.lblTareaTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTareaTitulo.Font = new System.Drawing.Font("Segoe UI", 8.7F, System.Drawing.FontStyle.Bold);
            this.lblTareaTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblTareaTitulo.Name = "lblTareaTitulo";
            this.lblTareaTitulo.TabIndex = 0;
            this.lblTareaTitulo.Text = "Tarea:";
            this.lblTareaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProyectoTitulo
            // 
            this.lblProyectoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProyectoTitulo.Font = new System.Drawing.Font("Segoe UI", 8.7F, System.Drawing.FontStyle.Bold);
            this.lblProyectoTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblProyectoTitulo.Name = "lblProyectoTitulo";
            this.lblProyectoTitulo.TabIndex = 0;
            this.lblProyectoTitulo.Text = "Proyecto:";
            this.lblProyectoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResponsableTitulo
            // 
            this.lblResponsableTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResponsableTitulo.Font = new System.Drawing.Font("Segoe UI", 8.7F, System.Drawing.FontStyle.Bold);
            this.lblResponsableTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblResponsableTitulo.Name = "lblResponsableTitulo";
            this.lblResponsableTitulo.TabIndex = 0;
            this.lblResponsableTitulo.Text = "Responsable:";
            this.lblResponsableTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnvioTitulo
            // 
            this.lblEnvioTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnvioTitulo.Font = new System.Drawing.Font("Segoe UI", 8.7F, System.Drawing.FontStyle.Bold);
            this.lblEnvioTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblEnvioTitulo.Name = "lblEnvioTitulo";
            this.lblEnvioTitulo.TabIndex = 0;
            this.lblEnvioTitulo.Text = "Enviada:";
            this.lblEnvioTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLimiteTitulo
            // 
            this.lblLimiteTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLimiteTitulo.Font = new System.Drawing.Font("Segoe UI", 8.7F, System.Drawing.FontStyle.Bold);
            this.lblLimiteTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblLimiteTitulo.Name = "lblLimiteTitulo";
            this.lblLimiteTitulo.TabIndex = 0;
            this.lblLimiteTitulo.Text = "Fecha límite:";
            this.lblLimiteTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrioridadTitulo
            // 
            this.lblPrioridadTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrioridadTitulo.Font = new System.Drawing.Font("Segoe UI", 8.7F, System.Drawing.FontStyle.Bold);
            this.lblPrioridadTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblPrioridadTitulo.Name = "lblPrioridadTitulo";
            this.lblPrioridadTitulo.TabIndex = 0;
            this.lblPrioridadTitulo.Text = "Prioridad:";
            this.lblPrioridadTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAvanceTitulo
            // 
            this.lblAvanceTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvanceTitulo.Font = new System.Drawing.Font("Segoe UI", 8.7F, System.Drawing.FontStyle.Bold);
            this.lblAvanceTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblAvanceTitulo.Name = "lblAvanceTitulo";
            this.lblAvanceTitulo.TabIndex = 0;
            this.lblAvanceTitulo.Text = "Avance:";
            this.lblAvanceTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEvidenciasTitulo
            // 
            this.lblEvidenciasTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEvidenciasTitulo.Font = new System.Drawing.Font("Segoe UI", 8.7F, System.Drawing.FontStyle.Bold);
            this.lblEvidenciasTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblEvidenciasTitulo.Name = "lblEvidenciasTitulo";
            this.lblEvidenciasTitulo.TabIndex = 0;
            this.lblEvidenciasTitulo.Text = "Evidencias:";
            this.lblEvidenciasTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcionTitulo
            // 
            this.lblDescripcionTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcionTitulo.Font = new System.Drawing.Font("Segoe UI", 8.7F, System.Drawing.FontStyle.Bold);
            this.lblDescripcionTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblDescripcionTitulo.Name = "lblDescripcionTitulo";
            this.lblDescripcionTitulo.TabIndex = 0;
            this.lblDescripcionTitulo.Text = "Descripción:";
            this.lblDescripcionTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObservacionesTitulo
            // 
            this.lblObservacionesTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObservacionesTitulo.Font = new System.Drawing.Font("Segoe UI", 8.7F, System.Drawing.FontStyle.Bold);
            this.lblObservacionesTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblObservacionesTitulo.Name = "lblObservacionesTitulo";
            this.lblObservacionesTitulo.TabIndex = 0;
            this.lblObservacionesTitulo.Text = "Observaciones:";
            this.lblObservacionesTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUltimoAvanceTitulo
            // 
            this.lblUltimoAvanceTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUltimoAvanceTitulo.Font = new System.Drawing.Font("Segoe UI", 8.7F, System.Drawing.FontStyle.Bold);
            this.lblUltimoAvanceTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblUltimoAvanceTitulo.Name = "lblUltimoAvanceTitulo";
            this.lblUltimoAvanceTitulo.TabIndex = 0;
            this.lblUltimoAvanceTitulo.Text = "Último avance:";
            this.lblUltimoAvanceTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComentarioTitulo
            // 
            this.lblComentarioTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblComentarioTitulo.Font = new System.Drawing.Font("Segoe UI", 8.7F, System.Drawing.FontStyle.Bold);
            this.lblComentarioTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblComentarioTitulo.Name = "lblComentarioTitulo";
            this.lblComentarioTitulo.TabIndex = 0;
            this.lblComentarioTitulo.Text = "Comentario:";
            this.lblComentarioTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTareaValor
            // 
            this.lblTareaValor.AutoEllipsis = true;
            this.lblTareaValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTareaValor.Font = new System.Drawing.Font("Segoe UI", 8.7F);
            this.lblTareaValor.ForeColor = System.Drawing.Color.FromArgb(61, 74, 89);
            this.lblTareaValor.Name = "lblTareaValor";
            this.lblTareaValor.TabIndex = 0;
            this.lblTareaValor.Text = "Seleccione una tarea";
            this.lblTareaValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProyectoValor
            // 
            this.lblProyectoValor.AutoEllipsis = true;
            this.lblProyectoValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProyectoValor.Font = new System.Drawing.Font("Segoe UI", 8.7F);
            this.lblProyectoValor.ForeColor = System.Drawing.Color.FromArgb(61, 74, 89);
            this.lblProyectoValor.Name = "lblProyectoValor";
            this.lblProyectoValor.TabIndex = 0;
            this.lblProyectoValor.Text = "—";
            this.lblProyectoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResponsableValor
            // 
            this.lblResponsableValor.AutoEllipsis = true;
            this.lblResponsableValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResponsableValor.Font = new System.Drawing.Font("Segoe UI", 8.7F);
            this.lblResponsableValor.ForeColor = System.Drawing.Color.FromArgb(61, 74, 89);
            this.lblResponsableValor.Name = "lblResponsableValor";
            this.lblResponsableValor.TabIndex = 0;
            this.lblResponsableValor.Text = "—";
            this.lblResponsableValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnvioValor
            // 
            this.lblEnvioValor.AutoEllipsis = true;
            this.lblEnvioValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnvioValor.Font = new System.Drawing.Font("Segoe UI", 8.7F);
            this.lblEnvioValor.ForeColor = System.Drawing.Color.FromArgb(61, 74, 89);
            this.lblEnvioValor.Name = "lblEnvioValor";
            this.lblEnvioValor.TabIndex = 0;
            this.lblEnvioValor.Text = "—";
            this.lblEnvioValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLimiteValor
            // 
            this.lblLimiteValor.AutoEllipsis = true;
            this.lblLimiteValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLimiteValor.Font = new System.Drawing.Font("Segoe UI", 8.7F);
            this.lblLimiteValor.ForeColor = System.Drawing.Color.FromArgb(61, 74, 89);
            this.lblLimiteValor.Name = "lblLimiteValor";
            this.lblLimiteValor.TabIndex = 0;
            this.lblLimiteValor.Text = "—";
            this.lblLimiteValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrioridadValor
            // 
            this.lblPrioridadValor.AutoEllipsis = true;
            this.lblPrioridadValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrioridadValor.Font = new System.Drawing.Font("Segoe UI", 8.7F);
            this.lblPrioridadValor.ForeColor = System.Drawing.Color.FromArgb(61, 74, 89);
            this.lblPrioridadValor.Name = "lblPrioridadValor";
            this.lblPrioridadValor.TabIndex = 0;
            this.lblPrioridadValor.Text = "—";
            this.lblPrioridadValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAvanceValor
            // 
            this.lblAvanceValor.AutoEllipsis = true;
            this.lblAvanceValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvanceValor.Font = new System.Drawing.Font("Segoe UI", 8.7F);
            this.lblAvanceValor.ForeColor = System.Drawing.Color.FromArgb(61, 74, 89);
            this.lblAvanceValor.Name = "lblAvanceValor";
            this.lblAvanceValor.TabIndex = 0;
            this.lblAvanceValor.Text = "—";
            this.lblAvanceValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEvidenciasValor
            // 
            this.lblEvidenciasValor.AutoEllipsis = true;
            this.lblEvidenciasValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEvidenciasValor.Font = new System.Drawing.Font("Segoe UI", 8.7F);
            this.lblEvidenciasValor.ForeColor = System.Drawing.Color.FromArgb(61, 74, 89);
            this.lblEvidenciasValor.Name = "lblEvidenciasValor";
            this.lblEvidenciasValor.TabIndex = 0;
            this.lblEvidenciasValor.Text = "—";
            this.lblEvidenciasValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(250, 251, 253);
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.TabStop = false;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(250, 251, 253);
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.TabStop = false;
            // 
            // txtUltimoAvance
            // 
            this.txtUltimoAvance.BackColor = System.Drawing.Color.FromArgb(250, 251, 253);
            this.txtUltimoAvance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUltimoAvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUltimoAvance.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtUltimoAvance.Multiline = true;
            this.txtUltimoAvance.Name = "txtUltimoAvance";
            this.txtUltimoAvance.ReadOnly = true;
            this.txtUltimoAvance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUltimoAvance.TabStop = false;
            // 
            // txtComentario
            // 
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComentario.Font = new System.Drawing.Font("Segoe UI", 8.7F);
            this.txtComentario.MaxLength = 500;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.ShortcutsEnabled = false;
            this.txtComentario.TabIndex = 2;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnAprobar);
            this.pnlAcciones.Controls.Add(this.btnSolicitarCorreccion);
            this.pnlAcciones.Controls.Add(this.btnVerDetalle);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAcciones.Location = new System.Drawing.Point(0, 720);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.pnlAcciones.Size = new System.Drawing.Size(702, 68);
            this.pnlAcciones.TabIndex = 2;
            // 
            // btnAprobar
            // 
            this.btnAprobar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAprobar.BackColor = System.Drawing.Color.FromArgb(35, 145, 72);
            this.btnAprobar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAprobar.FlatAppearance.BorderSize = 0;
            this.btnAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprobar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAprobar.ForeColor = System.Drawing.Color.White;
            this.btnAprobar.Location = new System.Drawing.Point(561, 14);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(126, 38);
            this.btnAprobar.TabIndex = 5;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = false;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnSolicitarCorreccion
            // 
            this.btnSolicitarCorreccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolicitarCorreccion.BackColor = System.Drawing.Color.FromArgb(226, 132, 50);
            this.btnSolicitarCorreccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolicitarCorreccion.FlatAppearance.BorderSize = 0;
            this.btnSolicitarCorreccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitarCorreccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSolicitarCorreccion.ForeColor = System.Drawing.Color.White;
            this.btnSolicitarCorreccion.Location = new System.Drawing.Point(361, 14);
            this.btnSolicitarCorreccion.Name = "btnSolicitarCorreccion";
            this.btnSolicitarCorreccion.Size = new System.Drawing.Size(192, 38);
            this.btnSolicitarCorreccion.TabIndex = 4;
            this.btnSolicitarCorreccion.Text = "Solicitar corrección";
            this.btnSolicitarCorreccion.UseVisualStyleBackColor = false;
            this.btnSolicitarCorreccion.Click += new System.EventHandler(this.btnSolicitarCorreccion_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.Color.White;
            this.btnVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerDetalle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVerDetalle.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnVerDetalle.Location = new System.Drawing.Point(14, 14);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(144, 38);
            this.btnVerDetalle.TabIndex = 3;
            this.btnVerDetalle.Text = "Ver detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // lblDetalleTitulo
            // 
            this.lblDetalleTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetalleTitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDetalleTitulo.ForeColor = System.Drawing.Color.FromArgb(54, 70, 88);
            this.lblDetalleTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblDetalleTitulo.Name = "lblDetalleTitulo";
            this.lblDetalleTitulo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblDetalleTitulo.Size = new System.Drawing.Size(702, 38);
            this.lblDetalleTitulo.TabIndex = 0;
            this.lblDetalleTitulo.Text = "Detalle de la revisión";
            this.lblDetalleTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmRevisionTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1050, 700);
            this.Name = "frmRevisionTareas";
            this.Text = "Revisión de tareas";
            this.Load += new System.EventHandler(this.frmRevisionTareas_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.tlpContenido.ResumeLayout(false);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevisiones)).EndInit();
            this.pnlDetalle.ResumeLayout(false);
            this.tlpDetalle.ResumeLayout(false);
            this.tlpDetalle.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblBreadcrumbActual;
        private System.Windows.Forms.Label lblBreadcrumbBase;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Label lblListaTitulo;
        private System.Windows.Forms.DataGridView dgvRevisiones;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.Label lblDetalleTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpDetalle;
        private System.Windows.Forms.Label lblTareaTitulo;
        private System.Windows.Forms.Label lblTareaValor;
        private System.Windows.Forms.Label lblProyectoTitulo;
        private System.Windows.Forms.Label lblProyectoValor;
        private System.Windows.Forms.Label lblResponsableTitulo;
        private System.Windows.Forms.Label lblResponsableValor;
        private System.Windows.Forms.Label lblEnvioTitulo;
        private System.Windows.Forms.Label lblEnvioValor;
        private System.Windows.Forms.Label lblLimiteTitulo;
        private System.Windows.Forms.Label lblLimiteValor;
        private System.Windows.Forms.Label lblPrioridadTitulo;
        private System.Windows.Forms.Label lblPrioridadValor;
        private System.Windows.Forms.Label lblAvanceTitulo;
        private System.Windows.Forms.Label lblAvanceValor;
        private System.Windows.Forms.Label lblEvidenciasTitulo;
        private System.Windows.Forms.Label lblEvidenciasValor;
        private System.Windows.Forms.Label lblDescripcionTitulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblObservacionesTitulo;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblUltimoAvanceTitulo;
        private System.Windows.Forms.TextBox txtUltimoAvance;
        private System.Windows.Forms.Label lblComentarioTitulo;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button btnSolicitarCorreccion;
        private System.Windows.Forms.Button btnAprobar;
    }
}
