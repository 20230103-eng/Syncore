namespace Vista
{
    partial class frmNuevoProyecto
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
            this.tlpPagina = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitulos = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.tlpFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.cboResponsable = new System.Windows.Forms.ComboBox();
            this.lblPlanificacion = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpCierre = new System.Windows.Forms.DateTimePicker();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cboPrioridad = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            this.lblJustificacion = new System.Windows.Forms.Label();
            this.txtJustificacion = new System.Windows.Forms.TextBox();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.txtAlcance = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnCrearProyecto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlViewport.SuspendLayout();
            this.tlpPagina.SuspendLayout();
            this.pnlTitulos.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.tlpFormulario.SuspendLayout();
            this.pnlBotones.SuspendLayout();
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
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(105, 118, 135);
            this.lblFecha.Location = new System.Drawing.Point(1610, 11);
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
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(291, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Size = new System.Drawing.Size(108, 20);
            this.lblBreadcrumbActual.TabIndex = 1;
            this.lblBreadcrumbActual.Text = "Nuevo proyecto";
            // 
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(145, 151, 160);
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.Size = new System.Drawing.Size(271, 20);
            this.lblBreadcrumbBase.TabIndex = 0;
            this.lblBreadcrumbBase.Text = "Proyectos >";
            // 
            // pnlViewport
            // 
            this.pnlViewport.AutoScroll = true;
            this.pnlViewport.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlViewport.Controls.Add(this.tlpPagina);
            this.pnlViewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewport.Location = new System.Drawing.Point(0, 43);
            this.pnlViewport.Name = "pnlViewport";
            this.pnlViewport.Size = new System.Drawing.Size(1670, 1037);
            this.pnlViewport.TabIndex = 1;
            // 
            // tlpPagina
            // 
            this.tlpPagina.AutoSize = true;
            this.tlpPagina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpPagina.ColumnCount = 1;
            this.tlpPagina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagina.Controls.Add(this.pnlTitulos, 0, 0);
            this.tlpPagina.Controls.Add(this.pnlFormulario, 0, 1);
            this.tlpPagina.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPagina.Location = new System.Drawing.Point(0, 0);
            this.tlpPagina.Name = "tlpPagina";
            this.tlpPagina.Padding = new System.Windows.Forms.Padding(24, 18, 24, 24);
            this.tlpPagina.RowCount = 2;
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tlpPagina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpPagina.Size = new System.Drawing.Size(1670, 1050);
            this.tlpPagina.TabIndex = 0;
            // 
            // pnlTitulos
            // 
            this.pnlTitulos.Controls.Add(this.lblSubtitulo);
            this.pnlTitulos.Controls.Add(this.lblTitulo);
            this.pnlTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitulos.Location = new System.Drawing.Point(24, 18);
            this.pnlTitulos.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitulos.Name = "pnlTitulos";
            this.pnlTitulos.Size = new System.Drawing.Size(1622, 78);
            this.pnlTitulos.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblSubtitulo.Location = new System.Drawing.Point(3, 45);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(337, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Completa la información para registrar el proyecto";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(242, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nuevo Proyecto";
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.AutoSize = true;
            this.pnlFormulario.BackColor = System.Drawing.Color.White;
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormulario.Controls.Add(this.tlpFormulario);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormulario.Location = new System.Drawing.Point(24, 96);
            this.pnlFormulario.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(1622, 930);
            this.pnlFormulario.TabIndex = 1;
            // 
            // tlpFormulario
            // 
            this.tlpFormulario.AutoSize = true;
            this.tlpFormulario.ColumnCount = 2;
            this.tlpFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFormulario.Controls.Add(this.lblSeccion, 0, 0);
            this.tlpFormulario.Controls.Add(this.lblIdentificacion, 0, 1);
            this.tlpFormulario.Controls.Add(this.lblNombre, 0, 2);
            this.tlpFormulario.Controls.Add(this.txtNombre, 0, 3);
            this.tlpFormulario.Controls.Add(this.lblCodigo, 0, 4);
            this.tlpFormulario.Controls.Add(this.lblTipo, 1, 4);
            this.tlpFormulario.Controls.Add(this.txtCodigo, 0, 5);
            this.tlpFormulario.Controls.Add(this.cboTipo, 1, 5);
            this.tlpFormulario.Controls.Add(this.lblArea, 0, 6);
            this.tlpFormulario.Controls.Add(this.lblResponsable, 1, 6);
            this.tlpFormulario.Controls.Add(this.cboArea, 0, 7);
            this.tlpFormulario.Controls.Add(this.cboResponsable, 1, 7);
            this.tlpFormulario.Controls.Add(this.lblPlanificacion, 0, 8);
            this.tlpFormulario.Controls.Add(this.lblFechaInicio, 0, 9);
            this.tlpFormulario.Controls.Add(this.lblFechaCierre, 1, 9);
            this.tlpFormulario.Controls.Add(this.dtpInicio, 0, 10);
            this.tlpFormulario.Controls.Add(this.dtpCierre, 1, 10);
            this.tlpFormulario.Controls.Add(this.lblPrioridad, 0, 11);
            this.tlpFormulario.Controls.Add(this.cboPrioridad, 0, 12);
            this.tlpFormulario.Controls.Add(this.lblDescripcion, 0, 13);
            this.tlpFormulario.Controls.Add(this.lblObjetivo, 0, 14);
            this.tlpFormulario.Controls.Add(this.txtObjetivo, 0, 15);
            this.tlpFormulario.Controls.Add(this.lblJustificacion, 0, 16);
            this.tlpFormulario.Controls.Add(this.txtJustificacion, 0, 17);
            this.tlpFormulario.Controls.Add(this.lblAlcance, 0, 18);
            this.tlpFormulario.Controls.Add(this.txtAlcance, 0, 19);
            this.tlpFormulario.Controls.Add(this.lblResultado, 0, 20);
            this.tlpFormulario.Controls.Add(this.txtResultado, 0, 21);
            this.tlpFormulario.Controls.Add(this.lblObservaciones, 0, 22);
            this.tlpFormulario.Controls.Add(this.txtObservaciones, 0, 23);
            this.tlpFormulario.Controls.Add(this.pnlBotones, 0, 24);
            this.tlpFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpFormulario.Location = new System.Drawing.Point(0, 0);
            this.tlpFormulario.Name = "tlpFormulario";
            this.tlpFormulario.Padding = new System.Windows.Forms.Padding(10);
            this.tlpFormulario.RowCount = 25;
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpFormulario.SetColumnSpan(this.lblSeccion, 2);
            this.tlpFormulario.SetColumnSpan(this.lblIdentificacion, 2);
            this.tlpFormulario.SetColumnSpan(this.lblNombre, 2);
            this.tlpFormulario.SetColumnSpan(this.txtNombre, 2);
            this.tlpFormulario.SetColumnSpan(this.lblPlanificacion, 2);
            this.tlpFormulario.SetColumnSpan(this.lblDescripcion, 2);
            this.tlpFormulario.SetColumnSpan(this.lblObjetivo, 2);
            this.tlpFormulario.SetColumnSpan(this.txtObjetivo, 2);
            this.tlpFormulario.SetColumnSpan(this.lblJustificacion, 2);
            this.tlpFormulario.SetColumnSpan(this.txtJustificacion, 2);
            this.tlpFormulario.SetColumnSpan(this.lblAlcance, 2);
            this.tlpFormulario.SetColumnSpan(this.txtAlcance, 2);
            this.tlpFormulario.SetColumnSpan(this.lblResultado, 2);
            this.tlpFormulario.SetColumnSpan(this.txtResultado, 2);
            this.tlpFormulario.SetColumnSpan(this.lblObservaciones, 2);
            this.tlpFormulario.SetColumnSpan(this.txtObservaciones, 2);
            this.tlpFormulario.SetColumnSpan(this.pnlBotones, 2);
            this.tlpFormulario.Size = new System.Drawing.Size(1620, 928);
            this.tlpFormulario.TabIndex = 0;
            // 
            // lblSeccion
            // 
            this.lblSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSeccion.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblSeccion.Location = new System.Drawing.Point(10, 10);
            this.lblSeccion.Margin = new System.Windows.Forms.Padding(0);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(1600, 36);
            this.lblSeccion.TabIndex = 0;
            this.lblSeccion.Text = "Información General";
            this.lblSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdentificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIdentificacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIdentificacion.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblIdentificacion.Location = new System.Drawing.Point(10, 46);
            this.lblIdentificacion.Margin = new System.Windows.Forms.Padding(0);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(1600, 32);
            this.lblIdentificacion.TabIndex = 1;
            this.lblIdentificacion.Text = "IDENTIFICACIÓN";
            this.lblIdentificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del proyecto *";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.txtNombre.MaxLength = 150;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código del proyecto *";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTipo
            // 
            this.lblTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo del proyecto *";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ShortcutsEnabled = false;
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Text = "";
            // 
            // cboTipo
            // 
            this.cboTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblArea.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Área solicitante *";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblResponsable
            // 
            this.lblResponsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResponsable.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblResponsable.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblResponsable.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.TabIndex = 0;
            this.lblResponsable.Text = "Responsable principal *";
            this.lblResponsable.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboArea
            // 
            this.cboArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.cboArea.Name = "cboArea";
            this.cboArea.TabIndex = 3;
            // 
            // cboResponsable
            // 
            this.cboResponsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResponsable.Enabled = false;
            this.cboResponsable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboResponsable.FormattingEnabled = true;
            this.cboResponsable.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.cboResponsable.Name = "cboResponsable";
            this.cboResponsable.TabIndex = 4;
            this.cboResponsable.TabStop = false;
            // 
            // lblPlanificacion
            // 
            this.lblPlanificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlanificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlanificacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPlanificacion.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblPlanificacion.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlanificacion.Name = "lblPlanificacion";
            this.lblPlanificacion.TabIndex = 0;
            this.lblPlanificacion.Text = "PLANIFICACIÓN";
            this.lblPlanificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaInicio.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.TabIndex = 0;
            this.lblFechaInicio.Text = "Fecha de inicio *";
            this.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaCierre.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFechaCierre.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblFechaCierre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.TabIndex = 0;
            this.lblFechaCierre.Text = "Fecha estimada de cierre *";
            this.lblFechaCierre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.TabIndex = 5;
            // 
            // dtpCierre
            // 
            this.dtpCierre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpCierre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCierre.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.dtpCierre.Name = "dtpCierre";
            this.dtpCierre.TabIndex = 6;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrioridad.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPrioridad.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblPrioridad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.TabIndex = 0;
            this.lblPrioridad.Text = "Prioridad *";
            this.lblPrioridad.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboPrioridad
            // 
            this.cboPrioridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrioridad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPrioridad.FormattingEnabled = true;
            this.cboPrioridad.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.cboPrioridad.Name = "cboPrioridad";
            this.cboPrioridad.TabIndex = 7;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "DESCRIPCIÓN";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObjetivo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblObjetivo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblObjetivo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.TabIndex = 0;
            this.lblObjetivo.Text = "Objetivo *";
            this.lblObjetivo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObjetivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObjetivo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.txtObjetivo.MaxLength = 500;
            this.txtObjetivo.Multiline = true;
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObjetivo.ShortcutsEnabled = false;
            this.txtObjetivo.TabIndex = 8;
            this.txtObjetivo.Text = "";
            // 
            // lblJustificacion
            // 
            this.lblJustificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJustificacion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblJustificacion.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblJustificacion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblJustificacion.Name = "lblJustificacion";
            this.lblJustificacion.TabIndex = 0;
            this.lblJustificacion.Text = "Justificación";
            this.lblJustificacion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtJustificacion
            // 
            this.txtJustificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJustificacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJustificacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.txtJustificacion.MaxLength = 500;
            this.txtJustificacion.Multiline = true;
            this.txtJustificacion.Name = "txtJustificacion";
            this.txtJustificacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJustificacion.ShortcutsEnabled = false;
            this.txtJustificacion.TabIndex = 9;
            this.txtJustificacion.Text = "";
            // 
            // lblAlcance
            // 
            this.lblAlcance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlcance.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAlcance.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblAlcance.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.TabIndex = 0;
            this.lblAlcance.Text = "Alcance";
            this.lblAlcance.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtAlcance
            // 
            this.txtAlcance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAlcance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAlcance.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.txtAlcance.MaxLength = 500;
            this.txtAlcance.Multiline = true;
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAlcance.ShortcutsEnabled = false;
            this.txtAlcance.TabIndex = 10;
            this.txtAlcance.Text = "";
            // 
            // lblResultado
            // 
            this.lblResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado esperado *";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtResultado
            // 
            this.txtResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.txtResultado.MaxLength = 500;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.ShortcutsEnabled = false;
            this.txtResultado.TabIndex = 11;
            this.txtResultado.Text = "";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.TabIndex = 0;
            this.lblObservaciones.Text = "Observaciones";
            this.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.txtObservaciones.MaxLength = 500;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.ShortcutsEnabled = false;
            this.txtObservaciones.TabIndex = 12;
            this.txtObservaciones.Text = "";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnCrearProyecto);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.TabIndex = 13;
            // 
            // btnCrearProyecto
            // 
            this.btnCrearProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearProyecto.BackColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnCrearProyecto.Click += new System.EventHandler(this.btnCrearProyecto_Click);
            this.btnCrearProyecto.FlatAppearance.BorderSize = 0;
            this.btnCrearProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearProyecto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCrearProyecto.ForeColor = System.Drawing.Color.White;
            this.btnCrearProyecto.Location = new System.Drawing.Point(1460, 12);
            this.btnCrearProyecto.Name = "btnCrearProyecto";
            this.btnCrearProyecto.Size = new System.Drawing.Size(140, 36);
            this.btnCrearProyecto.TabIndex = 0;
            this.btnCrearProyecto.Text = "Crear proyecto";
            this.btnCrearProyecto.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnCancelar.Location = new System.Drawing.Point(1295, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 36);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "← Volver al listado";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmNuevoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.Controls.Add(this.pnlViewport);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.frmNuevoProyecto_Load);
            this.Name = "frmNuevoProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo proyecto";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlViewport.ResumeLayout(false);
            this.pnlViewport.PerformLayout();
            this.tlpPagina.ResumeLayout(false);
            this.tlpPagina.PerformLayout();
            this.pnlTitulos.ResumeLayout(false);
            this.pnlTitulos.PerformLayout();
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            this.tlpFormulario.ResumeLayout(false);
            this.tlpFormulario.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblBreadcrumbActual;
        private System.Windows.Forms.Label lblBreadcrumbBase;
        private System.Windows.Forms.Panel pnlViewport;
        private System.Windows.Forms.TableLayoutPanel tlpPagina;
        private System.Windows.Forms.Panel pnlTitulos;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.TableLayoutPanel tlpFormulario;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.ComboBox cboResponsable;
        private System.Windows.Forms.Label lblPlanificacion;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpCierre;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cboPrioridad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.TextBox txtObjetivo;
        private System.Windows.Forms.Label lblJustificacion;
        private System.Windows.Forms.TextBox txtJustificacion;
        private System.Windows.Forms.Label lblAlcance;
        private System.Windows.Forms.TextBox txtAlcance;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnCrearProyecto;
        private System.Windows.Forms.Button btnCancelar;
    }
}
