namespace Vista
{
    partial class frmHitosEntregables
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
            this.lblFiltroProyecto = new System.Windows.Forms.Label();
            this.cboProyectoFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.cboEstadoFiltro = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tlpCuerpo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.tlpEditor = new System.Windows.Forms.TableLayoutPanel();
            this.lblModo = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.cboProyecto = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblFechaObjetivo = new System.Windows.Forms.Label();
            this.dtpFechaObjetivo = new System.Windows.Forms.DateTimePicker();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.cboResponsable = new System.Windows.Forms.ComboBox();
            this.lblEstadoEditor = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCumplir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlListado = new System.Windows.Forms.Panel();
            this.dgvHitos = new System.Windows.Forms.DataGridView();
            this.ucPaginador = new Vista.UCPaginadorGrid();
            this.lblListado = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            this.tlpCuerpo.SuspendLayout();
            this.pnlEditor.SuspendLayout();
            this.tlpEditor.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.pnlListado.SuspendLayout();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHitos)).BeginInit();
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
            this.lblFecha.Location = new System.Drawing.Point(1587, 11);
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
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(118, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Size = new System.Drawing.Size(143, 20);
            this.lblBreadcrumbActual.TabIndex = 1;
            this.lblBreadcrumbActual.Text = "Hitos y entregables";
            // 
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(145, 151, 160);
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.Size = new System.Drawing.Size(92, 20);
            this.lblBreadcrumbBase.TabIndex = 0;
            this.lblBreadcrumbBase.Text = "Planificación >";
            // 
            // pnlContenido
            // 
            this.pnlContenido.AutoScroll = true;
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlContenido.Controls.Add(this.tlpPrincipal);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 43);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(24, 18, 24, 24);
            this.pnlContenido.Size = new System.Drawing.Size(1670, 1037);
            this.pnlContenido.TabIndex = 1;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.pnlCabecera, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpFiltros, 0, 1);
            this.tlpPrincipal.Controls.Add(this.tlpCuerpo, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPrincipal.Location = new System.Drawing.Point(24, 18);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 760F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1622, 910);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Controls.Add(this.lblSubtitulo);
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1622, 78);
            this.pnlCabecera.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(89, 105, 123);
            this.lblSubtitulo.Location = new System.Drawing.Point(2, 45);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(503, 21);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Administra los hitos y compromisos entregables de los proyectos a tu cargo.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(301, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Hitos y entregables";
            // 
            // tlpFiltros
            // 
            this.tlpFiltros.ColumnCount = 7;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFiltros.Controls.Add(this.lblFiltroProyecto, 0, 0);
            this.tlpFiltros.Controls.Add(this.cboProyectoFiltro, 1, 0);
            this.tlpFiltros.Controls.Add(this.lblFiltroEstado, 2, 0);
            this.tlpFiltros.Controls.Add(this.cboEstadoFiltro, 3, 0);
            this.tlpFiltros.Controls.Add(this.lblBuscar, 4, 0);
            this.tlpFiltros.Controls.Add(this.txtBuscar, 5, 0);
            this.tlpFiltros.Controls.Add(this.lblCantidad, 6, 0);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Location = new System.Drawing.Point(0, 78);
            this.tlpFiltros.Margin = new System.Windows.Forms.Padding(0, 4, 0, 8);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 1;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Size = new System.Drawing.Size(1622, 60);
            this.tlpFiltros.TabIndex = 1;
            // 
            // lblFiltroProyecto
            // 
            this.lblFiltroProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFiltroProyecto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltroProyecto.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblFiltroProyecto.Text = "Proyecto:";
            this.lblFiltroProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboProyectoFiltro
            // 
            this.cboProyectoFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProyectoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProyectoFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboProyectoFiltro.SelectedIndexChanged += new System.EventHandler(this.filtros_Cambio);
            this.cboProyectoFiltro.TabIndex = 0;
            // 
            // lblFiltroEstado
            // 
            this.lblFiltroEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltroEstado.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblFiltroEstado.Text = "Estado:";
            this.lblFiltroEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboEstadoFiltro
            // 
            this.cboEstadoFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEstadoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboEstadoFiltro.SelectedIndexChanged += new System.EventHandler(this.filtros_Cambio);
            this.cboEstadoFiltro.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblBuscar.Text = "Buscar:";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.MaxLength = 150;
            this.txtBuscar.ShortcutsEnabled = false;
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblCantidad.Text = "0 hito(s)";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlpCuerpo
            // 
            this.tlpCuerpo.ColumnCount = 2;
            this.tlpCuerpo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tlpCuerpo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tlpCuerpo.Controls.Add(this.pnlEditor, 0, 0);
            this.tlpCuerpo.Controls.Add(this.pnlListado, 1, 0);
            this.tlpCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCuerpo.Location = new System.Drawing.Point(0, 150);
            this.tlpCuerpo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCuerpo.Name = "tlpCuerpo";
            this.tlpCuerpo.RowCount = 1;
            this.tlpCuerpo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCuerpo.Size = new System.Drawing.Size(1622, 760);
            this.tlpCuerpo.TabIndex = 2;
            // 
            // pnlEditor
            // 
            this.pnlEditor.BackColor = System.Drawing.Color.White;
            this.pnlEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditor.Controls.Add(this.tlpEditor);
            this.pnlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditor.Location = new System.Drawing.Point(0, 0);
            this.pnlEditor.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Padding = new System.Windows.Forms.Padding(20);
            this.pnlEditor.Size = new System.Drawing.Size(606, 760);
            this.pnlEditor.TabIndex = 0;
            // 
            // tlpEditor
            // 
            this.tlpEditor.ColumnCount = 1;
            this.tlpEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEditor.Controls.Add(this.lblModo, 0, 0);
            this.tlpEditor.Controls.Add(this.lblProyecto, 0, 1);
            this.tlpEditor.Controls.Add(this.cboProyecto, 0, 2);
            this.tlpEditor.Controls.Add(this.lblNombre, 0, 3);
            this.tlpEditor.Controls.Add(this.txtNombre, 0, 4);
            this.tlpEditor.Controls.Add(this.lblDescripcion, 0, 5);
            this.tlpEditor.Controls.Add(this.txtDescripcion, 0, 6);
            this.tlpEditor.Controls.Add(this.lblFechaObjetivo, 0, 7);
            this.tlpEditor.Controls.Add(this.dtpFechaObjetivo, 0, 8);
            this.tlpEditor.Controls.Add(this.lblResponsable, 0, 9);
            this.tlpEditor.Controls.Add(this.cboResponsable, 0, 10);
            this.tlpEditor.Controls.Add(this.lblEstadoEditor, 0, 11);
            this.tlpEditor.Controls.Add(this.cboEstado, 0, 12);
            this.tlpEditor.Controls.Add(this.tlpBotones, 0, 13);
            this.tlpEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpEditor.Location = new System.Drawing.Point(20, 20);
            this.tlpEditor.Name = "tlpEditor";
            this.tlpEditor.RowCount = 14;
            this.tlpEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tlpEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpEditor.Size = new System.Drawing.Size(564, 598);
            this.tlpEditor.TabIndex = 0;
            // 
            // lblModo
            // 
            this.lblModo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblModo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblModo.Text = "Nuevo hito / entregable";
            this.lblModo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProyecto
            // 
            this.lblProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProyecto.Text = "Proyecto";
            this.lblProyecto.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboProyecto
            // 
            this.cboProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProyecto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboProyecto.SelectedIndexChanged += new System.EventHandler(this.cboProyecto_SelectedIndexChanged);
            this.cboProyecto.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Text = "Nombre del hito / entregable";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.MaxLength = 150;
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.MaxLength = 500;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.ShortcutsEnabled = false;
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblFechaObjetivo
            // 
            this.lblFechaObjetivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaObjetivo.Text = "Fecha objetivo";
            this.lblFechaObjetivo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpFechaObjetivo
            // 
            this.dtpFechaObjetivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaObjetivo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaObjetivo.TabIndex = 6;
            // 
            // lblResponsable
            // 
            this.lblResponsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResponsable.Text = "Responsable";
            this.lblResponsable.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboResponsable
            // 
            this.cboResponsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResponsable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboResponsable.TabIndex = 7;
            // 
            // lblEstadoEditor
            // 
            this.lblEstadoEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstadoEditor.Text = "Estado";
            this.lblEstadoEditor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboEstado
            // 
            this.cboEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboEstado.TabIndex = 8;
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 5;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotones.Controls.Add(this.btnNuevo, 0, 0);
            this.tlpBotones.Controls.Add(this.btnGuardar, 1, 0);
            this.tlpBotones.Controls.Add(this.btnActualizar, 2, 0);
            this.tlpBotones.Controls.Add(this.btnCumplir, 3, 0);
            this.tlpBotones.Controls.Add(this.btnEliminar, 4, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotones.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnNuevo.Text = "Nuevo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Text = "Guardar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnActualizar.Text = "Actualizar";
            // 
            // btnCumplir
            // 
            this.btnCumplir.Click += new System.EventHandler(this.btnCumplir_Click);
            this.btnCumplir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCumplir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCumplir.ForeColor = System.Drawing.Color.FromArgb(31, 145, 72);
            this.btnCumplir.Text = "Cumplir";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(210, 52, 61);
            this.btnEliminar.Text = "Eliminar";
            // 
            // pnlListado
            // 
            this.pnlListado.BackColor = System.Drawing.Color.White;
            this.pnlListado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListado.Controls.Add(this.dgvHitos);
            this.pnlListado.Controls.Add(this.ucPaginador);
            this.pnlListado.Controls.Add(this.lblListado);
            this.pnlListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListado.Location = new System.Drawing.Point(626, 0);
            this.pnlListado.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlListado.Name = "pnlListado";
            this.pnlListado.Size = new System.Drawing.Size(996, 760);
            this.pnlListado.TabIndex = 1;
            // 
            // lblListado
            // 
            this.lblListado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblListado.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblListado.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblListado.Size = new System.Drawing.Size(994, 42);
            this.lblListado.Text = "Hitos registrados";
            this.lblListado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvHitos
            // 
            this.dgvHitos.AllowUserToAddRows = false;
            this.dgvHitos.AllowUserToDeleteRows = false;
            this.dgvHitos.AllowUserToResizeRows = false;
            this.dgvHitos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHitos.BackgroundColor = System.Drawing.Color.White;
            this.dgvHitos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHitos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHitos.ColumnHeadersDefaultCellStyle = encabezado;
            this.dgvHitos.ColumnHeadersHeight = 38;
            this.dgvHitos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHitos.EnableHeadersVisualStyles = false;
            this.dgvHitos.MultiSelect = false;
            this.dgvHitos.ReadOnly = true;
            this.dgvHitos.RowHeadersVisible = false;
            this.dgvHitos.RowsDefaultCellStyle = filas;
            this.dgvHitos.SelectionChanged += new System.EventHandler(this.dgvHitos_SelectionChanged);
            this.dgvHitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHitos.TabIndex = 9;
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
            // frmHitosEntregables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.frmHitosEntregables_Load);
            this.MinimumSize = new System.Drawing.Size(1050, 700);
            this.Name = "frmHitosEntregables";
            this.Text = "Hitos y entregables";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHitos)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.tlpFiltros.ResumeLayout(false);
            this.tlpFiltros.PerformLayout();
            this.tlpCuerpo.ResumeLayout(false);
            this.pnlEditor.ResumeLayout(false);
            this.tlpEditor.ResumeLayout(false);
            this.tlpBotones.ResumeLayout(false);
            this.pnlListado.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblFiltroProyecto;
        private System.Windows.Forms.ComboBox cboProyectoFiltro;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.ComboBox cboEstadoFiltro;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TableLayoutPanel tlpCuerpo;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.TableLayoutPanel tlpEditor;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.ComboBox cboProyecto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblFechaObjetivo;
        private System.Windows.Forms.DateTimePicker dtpFechaObjetivo;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.ComboBox cboResponsable;
        private System.Windows.Forms.Label lblEstadoEditor;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCumplir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlListado;
        private System.Windows.Forms.DataGridView dgvHitos;
        private Vista.UCPaginadorGrid ucPaginador;
        private System.Windows.Forms.Label lblListado;
    }
}
