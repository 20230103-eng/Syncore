namespace Vista
{
    partial class frmNuevaTarea
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
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.tlpFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTituloFormulario = new System.Windows.Forms.Panel();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.sepTituloFormulario = new System.Windows.Forms.Panel();
            this.pnlSeccionAsignacion = new System.Windows.Forms.Panel();
            this.lblSeccionAsignacion = new System.Windows.Forms.Label();
            this.sepAsignacion = new System.Windows.Forms.Panel();
            this.pnlCampoNombre = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tlpAsignacion = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCampoProyecto = new System.Windows.Forms.Panel();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.cmbProyecto = new System.Windows.Forms.ComboBox();
            this.pnlCampoResponsable = new System.Windows.Forms.Panel();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.pnlSeccionFechas = new System.Windows.Forms.Panel();
            this.lblSeccionFechas = new System.Windows.Forms.Label();
            this.sepFechas = new System.Windows.Forms.Panel();
            this.tlpFechas = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCampoInicio = new System.Windows.Forms.Panel();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.pnlCampoLimite = new System.Windows.Forms.Panel();
            this.lblLimite = new System.Windows.Forms.Label();
            this.dtpLimite = new System.Windows.Forms.DateTimePicker();
            this.tlpPrioridad = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCampoPrioridad = new System.Windows.Forms.Panel();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.pnlCampoEstado = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.pnlSeccionDescripcion = new System.Windows.Forms.Panel();
            this.lblSeccionDescripcion = new System.Windows.Forms.Label();
            this.sepDescripcion = new System.Windows.Forms.Panel();
            this.pnlCampoDescripcion = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pnlCampoObservaciones = new System.Windows.Forms.Panel();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlViewport.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.tlpFormulario.SuspendLayout();
            this.pnlTituloFormulario.SuspendLayout();
            this.pnlSeccionAsignacion.SuspendLayout();
            this.pnlCampoNombre.SuspendLayout();
            this.tlpAsignacion.SuspendLayout();
            this.pnlCampoProyecto.SuspendLayout();
            this.pnlCampoResponsable.SuspendLayout();
            this.pnlSeccionFechas.SuspendLayout();
            this.tlpFechas.SuspendLayout();
            this.pnlCampoInicio.SuspendLayout();
            this.pnlCampoLimite.SuspendLayout();
            this.tlpPrioridad.SuspendLayout();
            this.pnlCampoPrioridad.SuspendLayout();
            this.pnlCampoEstado.SuspendLayout();
            this.pnlSeccionDescripcion.SuspendLayout();
            this.pnlCampoDescripcion.SuspendLayout();
            this.pnlCampoObservaciones.SuspendLayout();
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
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblFecha.Location = new System.Drawing.Point(1610, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(36, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblBreadcrumbActual
            // 
            this.lblBreadcrumbActual.AutoSize = true;
            this.lblBreadcrumbActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreadcrumbActual.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(80, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Size = new System.Drawing.Size(76, 15);
            this.lblBreadcrumbActual.TabIndex = 1;
            this.lblBreadcrumbActual.Text = "Nueva tarea";
            // 
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.Size = new System.Drawing.Size(54, 15);
            this.lblBreadcrumbBase.TabIndex = 0;
            this.lblBreadcrumbBase.Text = "Tareas >";
            // 
            // pnlViewport
            // 
            this.pnlViewport.AutoScroll = true;
            this.pnlViewport.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlViewport.Controls.Add(this.tlpMain);
            this.pnlViewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewport.Location = new System.Drawing.Point(0, 43);
            this.pnlViewport.Name = "pnlViewport";
            this.pnlViewport.Size = new System.Drawing.Size(1670, 1037);
            this.pnlViewport.TabIndex = 1;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlCabecera, 0, 0);
            this.tlpMain.Controls.Add(this.pnlFormulario, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(24, 18, 24, 24);
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 642F));
            this.tlpMain.Size = new System.Drawing.Size(1670, 756);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Controls.Add(this.lblSubtitulo);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCabecera.Location = new System.Drawing.Point(27, 21);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1616, 66);
            this.pnlCabecera.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(143, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nueva tarea";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblSubtitulo.Location = new System.Drawing.Point(2, 39);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(245, 15);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Completa la información para asignar la tarea";
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BackColor = System.Drawing.Color.White;
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormulario.Controls.Add(this.tlpFormulario);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Location = new System.Drawing.Point(27, 93);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(1616, 636);
            this.pnlFormulario.TabIndex = 1;
            // 
            // tlpFormulario
            // 
            this.tlpFormulario.ColumnCount = 1;
            this.tlpFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFormulario.Controls.Add(this.pnlTituloFormulario, 0, 0);
            this.tlpFormulario.Controls.Add(this.pnlSeccionAsignacion, 0, 1);
            this.tlpFormulario.Controls.Add(this.pnlCampoNombre, 0, 2);
            this.tlpFormulario.Controls.Add(this.tlpAsignacion, 0, 3);
            this.tlpFormulario.Controls.Add(this.pnlSeccionFechas, 0, 4);
            this.tlpFormulario.Controls.Add(this.tlpFechas, 0, 5);
            this.tlpFormulario.Controls.Add(this.tlpPrioridad, 0, 6);
            this.tlpFormulario.Controls.Add(this.pnlSeccionDescripcion, 0, 7);
            this.tlpFormulario.Controls.Add(this.pnlCampoDescripcion, 0, 8);
            this.tlpFormulario.Controls.Add(this.pnlCampoObservaciones, 0, 9);
            this.tlpFormulario.Controls.Add(this.pnlBotones, 0, 10);
            this.tlpFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFormulario.Location = new System.Drawing.Point(0, 0);
            this.tlpFormulario.Name = "tlpFormulario";
            this.tlpFormulario.Padding = new System.Windows.Forms.Padding(12, 0, 12, 8);
            this.tlpFormulario.RowCount = 11;
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpFormulario.Size = new System.Drawing.Size(1614, 634);
            this.tlpFormulario.TabIndex = 0;
            // 
            // pnlTituloFormulario
            // 
            this.pnlTituloFormulario.Controls.Add(this.lblTituloFormulario);
            this.pnlTituloFormulario.Controls.Add(this.sepTituloFormulario);
            this.pnlTituloFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTituloFormulario.Location = new System.Drawing.Point(15, 3);
            this.pnlTituloFormulario.Name = "pnlTituloFormulario";
            this.pnlTituloFormulario.Size = new System.Drawing.Size(1584, 30);
            this.pnlTituloFormulario.TabIndex = 0;
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.AutoSize = true;
            this.lblTituloFormulario.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTituloFormulario.Location = new System.Drawing.Point(0, 8);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(116, 15);
            this.lblTituloFormulario.TabIndex = 0;
            this.lblTituloFormulario.Text = "Información General";
            // 
            // sepTituloFormulario
            // 
            this.sepTituloFormulario.BackColor = System.Drawing.Color.FromArgb(142, 160, 181);
            this.sepTituloFormulario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sepTituloFormulario.Location = new System.Drawing.Point(0, 29);
            this.sepTituloFormulario.Name = "sepTituloFormulario";
            this.sepTituloFormulario.Size = new System.Drawing.Size(1584, 1);
            this.sepTituloFormulario.TabIndex = 1;
            // 
            // pnlSeccionAsignacion
            // 
            this.pnlSeccionAsignacion.Controls.Add(this.lblSeccionAsignacion);
            this.pnlSeccionAsignacion.Controls.Add(this.sepAsignacion);
            this.pnlSeccionAsignacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeccionAsignacion.Location = new System.Drawing.Point(15, 39);
            this.pnlSeccionAsignacion.Name = "pnlSeccionAsignacion";
            this.pnlSeccionAsignacion.Size = new System.Drawing.Size(1584, 26);
            this.pnlSeccionAsignacion.TabIndex = 1;
            // 
            // lblSeccionAsignacion
            // 
            this.lblSeccionAsignacion.AutoSize = true;
            this.lblSeccionAsignacion.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblSeccionAsignacion.Location = new System.Drawing.Point(0, 7);
            this.lblSeccionAsignacion.Name = "lblSeccionAsignacion";
            this.lblSeccionAsignacion.Size = new System.Drawing.Size(170, 15);
            this.lblSeccionAsignacion.TabIndex = 0;
            this.lblSeccionAsignacion.Text = "IDENTIFICACIÓN Y ASIGNACIÓN";
            // 
            // sepAsignacion
            // 
            this.sepAsignacion.BackColor = System.Drawing.Color.FromArgb(180, 190, 202);
            this.sepAsignacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sepAsignacion.Location = new System.Drawing.Point(0, 25);
            this.sepAsignacion.Name = "sepAsignacion";
            this.sepAsignacion.Size = new System.Drawing.Size(1584, 1);
            this.sepAsignacion.TabIndex = 1;
            // 
            // pnlCampoNombre
            // 
            this.pnlCampoNombre.Controls.Add(this.txtNombre);
            this.pnlCampoNombre.Controls.Add(this.lblNombre);
            this.pnlCampoNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCampoNombre.Location = new System.Drawing.Point(15, 71);
            this.pnlCampoNombre.Name = "pnlCampoNombre";
            this.pnlCampoNombre.Size = new System.Drawing.Size(1584, 50);
            this.pnlCampoNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblNombre.Location = new System.Drawing.Point(0, 5);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(111, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de la tarea *";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Location = new System.Drawing.Point(0, 25);
            this.txtNombre.MaxLength = 150;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(1584, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // tlpAsignacion
            // 
            this.tlpAsignacion.ColumnCount = 2;
            this.tlpAsignacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAsignacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAsignacion.Controls.Add(this.pnlCampoProyecto, 0, 0);
            this.tlpAsignacion.Controls.Add(this.pnlCampoResponsable, 1, 0);
            this.tlpAsignacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAsignacion.Location = new System.Drawing.Point(15, 127);
            this.tlpAsignacion.Name = "tlpAsignacion";
            this.tlpAsignacion.RowCount = 1;
            this.tlpAsignacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAsignacion.Size = new System.Drawing.Size(1584, 52);
            this.tlpAsignacion.TabIndex = 3;
            // 
            // pnlCampoProyecto
            // 
            this.pnlCampoProyecto.Controls.Add(this.cmbProyecto);
            this.pnlCampoProyecto.Controls.Add(this.lblProyecto);
            this.pnlCampoProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCampoProyecto.Location = new System.Drawing.Point(0, 0);
            this.pnlCampoProyecto.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlCampoProyecto.Name = "pnlCampoProyecto";
            this.pnlCampoProyecto.Size = new System.Drawing.Size(784, 52);
            this.pnlCampoProyecto.TabIndex = 0;
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblProyecto.Location = new System.Drawing.Point(0, 5);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(65, 15);
            this.lblProyecto.TabIndex = 0;
            this.lblProyecto.Text = "Proyecto *";
            // 
            // cmbProyecto
            // 
            this.cmbProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProyecto.FormattingEnabled = true;
            this.cmbProyecto.Location = new System.Drawing.Point(0, 25);
            this.cmbProyecto.Name = "cmbProyecto";
            this.cmbProyecto.SelectedIndexChanged += new System.EventHandler(this.cmbProyecto_SelectedIndexChanged);
            this.cmbProyecto.Size = new System.Drawing.Size(784, 23);
            this.cmbProyecto.TabIndex = 1;
            // 
            // pnlCampoResponsable
            // 
            this.pnlCampoResponsable.Controls.Add(this.cmbResponsable);
            this.pnlCampoResponsable.Controls.Add(this.lblResponsable);
            this.pnlCampoResponsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCampoResponsable.Location = new System.Drawing.Point(800, 0);
            this.pnlCampoResponsable.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlCampoResponsable.Name = "pnlCampoResponsable";
            this.pnlCampoResponsable.Size = new System.Drawing.Size(784, 52);
            this.pnlCampoResponsable.TabIndex = 1;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblResponsable.Location = new System.Drawing.Point(0, 5);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(132, 15);
            this.lblResponsable.TabIndex = 0;
            this.lblResponsable.Text = "Responsable principal *";
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsable.Enabled = false;
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(0, 25);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(784, 23);
            this.cmbResponsable.TabIndex = 2;
            // 
            // pnlSeccionFechas
            // 
            this.pnlSeccionFechas.Controls.Add(this.lblSeccionFechas);
            this.pnlSeccionFechas.Controls.Add(this.sepFechas);
            this.pnlSeccionFechas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeccionFechas.Location = new System.Drawing.Point(15, 185);
            this.pnlSeccionFechas.Name = "pnlSeccionFechas";
            this.pnlSeccionFechas.Size = new System.Drawing.Size(1584, 26);
            this.pnlSeccionFechas.TabIndex = 4;
            // 
            // lblSeccionFechas
            // 
            this.lblSeccionFechas.AutoSize = true;
            this.lblSeccionFechas.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblSeccionFechas.Location = new System.Drawing.Point(0, 7);
            this.lblSeccionFechas.Name = "lblSeccionFechas";
            this.lblSeccionFechas.Size = new System.Drawing.Size(126, 15);
            this.lblSeccionFechas.TabIndex = 0;
            this.lblSeccionFechas.Text = "FECHAS Y PRIORIDAD";
            // 
            // sepFechas
            // 
            this.sepFechas.BackColor = System.Drawing.Color.FromArgb(180, 190, 202);
            this.sepFechas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sepFechas.Location = new System.Drawing.Point(0, 25);
            this.sepFechas.Name = "sepFechas";
            this.sepFechas.Size = new System.Drawing.Size(1584, 1);
            this.sepFechas.TabIndex = 1;
            // 
            // tlpFechas
            // 
            this.tlpFechas.ColumnCount = 2;
            this.tlpFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFechas.Controls.Add(this.pnlCampoInicio, 0, 0);
            this.tlpFechas.Controls.Add(this.pnlCampoLimite, 1, 0);
            this.tlpFechas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFechas.Location = new System.Drawing.Point(15, 217);
            this.tlpFechas.Name = "tlpFechas";
            this.tlpFechas.RowCount = 1;
            this.tlpFechas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFechas.Size = new System.Drawing.Size(1584, 52);
            this.tlpFechas.TabIndex = 5;
            // 
            // pnlCampoInicio
            // 
            this.pnlCampoInicio.Controls.Add(this.dtpInicio);
            this.pnlCampoInicio.Controls.Add(this.lblInicio);
            this.pnlCampoInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCampoInicio.Location = new System.Drawing.Point(0, 0);
            this.pnlCampoInicio.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlCampoInicio.Name = "pnlCampoInicio";
            this.pnlCampoInicio.Size = new System.Drawing.Size(784, 52);
            this.pnlCampoInicio.TabIndex = 0;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblInicio.Location = new System.Drawing.Point(0, 5);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(91, 15);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Fecha de inicio *";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(0, 25);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(784, 23);
            this.dtpInicio.TabIndex = 3;
            // 
            // pnlCampoLimite
            // 
            this.pnlCampoLimite.Controls.Add(this.dtpLimite);
            this.pnlCampoLimite.Controls.Add(this.lblLimite);
            this.pnlCampoLimite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCampoLimite.Location = new System.Drawing.Point(800, 0);
            this.pnlCampoLimite.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlCampoLimite.Name = "pnlCampoLimite";
            this.pnlCampoLimite.Size = new System.Drawing.Size(784, 52);
            this.pnlCampoLimite.TabIndex = 1;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblLimite.Location = new System.Drawing.Point(0, 5);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(76, 15);
            this.lblLimite.TabIndex = 0;
            this.lblLimite.Text = "Fecha límite *";
            // 
            // dtpLimite
            // 
            this.dtpLimite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpLimite.CustomFormat = "dd/MM/yyyy";
            this.dtpLimite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLimite.Location = new System.Drawing.Point(0, 25);
            this.dtpLimite.Name = "dtpLimite";
            this.dtpLimite.Size = new System.Drawing.Size(784, 23);
            this.dtpLimite.TabIndex = 4;
            // 
            // tlpPrioridad
            // 
            this.tlpPrioridad.ColumnCount = 2;
            this.tlpPrioridad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrioridad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrioridad.Controls.Add(this.pnlCampoPrioridad, 0, 0);
            this.tlpPrioridad.Controls.Add(this.pnlCampoEstado, 1, 0);
            this.tlpPrioridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrioridad.Location = new System.Drawing.Point(15, 275);
            this.tlpPrioridad.Name = "tlpPrioridad";
            this.tlpPrioridad.RowCount = 1;
            this.tlpPrioridad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrioridad.Size = new System.Drawing.Size(1584, 52);
            this.tlpPrioridad.TabIndex = 6;
            // 
            // pnlCampoPrioridad
            // 
            this.pnlCampoPrioridad.Controls.Add(this.cmbPrioridad);
            this.pnlCampoPrioridad.Controls.Add(this.lblPrioridad);
            this.pnlCampoPrioridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCampoPrioridad.Location = new System.Drawing.Point(0, 0);
            this.pnlCampoPrioridad.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlCampoPrioridad.Name = "pnlCampoPrioridad";
            this.pnlCampoPrioridad.Size = new System.Drawing.Size(784, 52);
            this.pnlCampoPrioridad.TabIndex = 0;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblPrioridad.Location = new System.Drawing.Point(0, 5);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(66, 15);
            this.lblPrioridad.TabIndex = 0;
            this.lblPrioridad.Text = "Prioridad *";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(0, 25);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(784, 23);
            this.cmbPrioridad.TabIndex = 5;
            // 
            // pnlCampoEstado
            // 
            this.pnlCampoEstado.Controls.Add(this.cmbEstado);
            this.pnlCampoEstado.Controls.Add(this.lblEstado);
            this.pnlCampoEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCampoEstado.Location = new System.Drawing.Point(800, 0);
            this.pnlCampoEstado.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlCampoEstado.Name = "pnlCampoEstado";
            this.pnlCampoEstado.Size = new System.Drawing.Size(784, 52);
            this.pnlCampoEstado.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblEstado.Location = new System.Drawing.Point(0, 5);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(80, 15);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado inicial *";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(0, 25);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(784, 23);
            this.cmbEstado.TabIndex = 6;
            // 
            // pnlSeccionDescripcion
            // 
            this.pnlSeccionDescripcion.Controls.Add(this.lblSeccionDescripcion);
            this.pnlSeccionDescripcion.Controls.Add(this.sepDescripcion);
            this.pnlSeccionDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeccionDescripcion.Location = new System.Drawing.Point(15, 333);
            this.pnlSeccionDescripcion.Name = "pnlSeccionDescripcion";
            this.pnlSeccionDescripcion.Size = new System.Drawing.Size(1584, 26);
            this.pnlSeccionDescripcion.TabIndex = 7;
            // 
            // lblSeccionDescripcion
            // 
            this.lblSeccionDescripcion.AutoSize = true;
            this.lblSeccionDescripcion.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblSeccionDescripcion.Location = new System.Drawing.Point(0, 7);
            this.lblSeccionDescripcion.Name = "lblSeccionDescripcion";
            this.lblSeccionDescripcion.Size = new System.Drawing.Size(79, 15);
            this.lblSeccionDescripcion.TabIndex = 0;
            this.lblSeccionDescripcion.Text = "DESCRIPCIÓN";
            // 
            // sepDescripcion
            // 
            this.sepDescripcion.BackColor = System.Drawing.Color.FromArgb(180, 190, 202);
            this.sepDescripcion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sepDescripcion.Location = new System.Drawing.Point(0, 25);
            this.sepDescripcion.Name = "sepDescripcion";
            this.sepDescripcion.Size = new System.Drawing.Size(1584, 1);
            this.sepDescripcion.TabIndex = 1;
            // 
            // pnlCampoDescripcion
            // 
            this.pnlCampoDescripcion.Controls.Add(this.txtDescripcion);
            this.pnlCampoDescripcion.Controls.Add(this.lblDescripcion);
            this.pnlCampoDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCampoDescripcion.Location = new System.Drawing.Point(15, 365);
            this.pnlCampoDescripcion.Name = "pnlCampoDescripcion";
            this.pnlCampoDescripcion.Size = new System.Drawing.Size(1584, 82);
            this.pnlCampoDescripcion.TabIndex = 8;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblDescripcion.Location = new System.Drawing.Point(0, 5);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(153, 15);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción / instrucciones *";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(0, 25);
            this.txtDescripcion.MaxLength = 1000;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.ShortcutsEnabled = false;
            this.txtDescripcion.Size = new System.Drawing.Size(1584, 54);
            this.txtDescripcion.TabIndex = 7;
            // 
            // pnlCampoObservaciones
            // 
            this.pnlCampoObservaciones.Controls.Add(this.txtObservaciones);
            this.pnlCampoObservaciones.Controls.Add(this.lblObservaciones);
            this.pnlCampoObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCampoObservaciones.Location = new System.Drawing.Point(15, 453);
            this.pnlCampoObservaciones.Name = "pnlCampoObservaciones";
            this.pnlCampoObservaciones.Size = new System.Drawing.Size(1584, 76);
            this.pnlCampoObservaciones.TabIndex = 9;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblObservaciones.Location = new System.Drawing.Point(0, 5);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(142, 15);
            this.lblObservaciones.TabIndex = 0;
            this.lblObservaciones.Text = "Observaciones adicionales";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.Location = new System.Drawing.Point(0, 25);
            this.txtObservaciones.MaxLength = 500;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.ShortcutsEnabled = false;
            this.txtObservaciones.Size = new System.Drawing.Size(1584, 46);
            this.txtObservaciones.TabIndex = 8;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnCrear);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.Location = new System.Drawing.Point(15, 535);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1584, 58);
            this.pnlBotones.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.btnCancelar.Location = new System.Drawing.Point(1284, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 34);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "← Volver al tablero";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(1456, 12);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(128, 34);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Crear tarea";
            this.btnCrear.UseVisualStyleBackColor = false;
            // 
            // frmNuevaTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.Controls.Add(this.pnlViewport);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.frmNuevaTarea_Load);
            this.Name = "frmNuevaTarea";
            this.Text = "Nueva tarea";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlViewport.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.pnlFormulario.ResumeLayout(false);
            this.tlpFormulario.ResumeLayout(false);
            this.pnlTituloFormulario.ResumeLayout(false);
            this.pnlTituloFormulario.PerformLayout();
            this.pnlSeccionAsignacion.ResumeLayout(false);
            this.pnlSeccionAsignacion.PerformLayout();
            this.pnlCampoNombre.ResumeLayout(false);
            this.pnlCampoNombre.PerformLayout();
            this.tlpAsignacion.ResumeLayout(false);
            this.pnlCampoProyecto.ResumeLayout(false);
            this.pnlCampoProyecto.PerformLayout();
            this.pnlCampoResponsable.ResumeLayout(false);
            this.pnlCampoResponsable.PerformLayout();
            this.pnlSeccionFechas.ResumeLayout(false);
            this.pnlSeccionFechas.PerformLayout();
            this.tlpFechas.ResumeLayout(false);
            this.pnlCampoInicio.ResumeLayout(false);
            this.pnlCampoInicio.PerformLayout();
            this.pnlCampoLimite.ResumeLayout(false);
            this.pnlCampoLimite.PerformLayout();
            this.tlpPrioridad.ResumeLayout(false);
            this.pnlCampoPrioridad.ResumeLayout(false);
            this.pnlCampoPrioridad.PerformLayout();
            this.pnlCampoEstado.ResumeLayout(false);
            this.pnlCampoEstado.PerformLayout();
            this.pnlSeccionDescripcion.ResumeLayout(false);
            this.pnlSeccionDescripcion.PerformLayout();
            this.pnlCampoDescripcion.ResumeLayout(false);
            this.pnlCampoDescripcion.PerformLayout();
            this.pnlCampoObservaciones.ResumeLayout(false);
            this.pnlCampoObservaciones.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.TableLayoutPanel tlpFormulario;
        private System.Windows.Forms.Panel pnlTituloFormulario;
        private System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.Panel sepTituloFormulario;
        private System.Windows.Forms.Panel pnlSeccionAsignacion;
        private System.Windows.Forms.Label lblSeccionAsignacion;
        private System.Windows.Forms.Panel sepAsignacion;
        private System.Windows.Forms.Panel pnlCampoNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TableLayoutPanel tlpAsignacion;
        private System.Windows.Forms.Panel pnlCampoProyecto;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.ComboBox cmbProyecto;
        private System.Windows.Forms.Panel pnlCampoResponsable;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.Panel pnlSeccionFechas;
        private System.Windows.Forms.Label lblSeccionFechas;
        private System.Windows.Forms.Panel sepFechas;
        private System.Windows.Forms.TableLayoutPanel tlpFechas;
        private System.Windows.Forms.Panel pnlCampoInicio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Panel pnlCampoLimite;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.DateTimePicker dtpLimite;
        private System.Windows.Forms.TableLayoutPanel tlpPrioridad;
        private System.Windows.Forms.Panel pnlCampoPrioridad;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Panel pnlCampoEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Panel pnlSeccionDescripcion;
        private System.Windows.Forms.Label lblSeccionDescripcion;
        private System.Windows.Forms.Panel sepDescripcion;
        private System.Windows.Forms.Panel pnlCampoDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel pnlCampoObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrear;
    }
}
