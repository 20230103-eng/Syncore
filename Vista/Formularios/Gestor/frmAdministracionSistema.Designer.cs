namespace Vista
{
    partial class frmAdministracionSistema
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
            System.Windows.Forms.DataGridViewCellStyle encabezado = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle filas = new System.Windows.Forms.DataGridViewCellStyle();
            encabezado.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            encabezado.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            encabezado.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            encabezado.SelectionBackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            encabezado.SelectionForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            filas.BackColor = System.Drawing.Color.White;
            filas.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            filas.ForeColor = System.Drawing.Color.FromArgb(62, 75, 91);
            filas.SelectionBackColor = System.Drawing.Color.FromArgb(230, 239, 251);
            filas.SelectionForeColor = System.Drawing.Color.FromArgb(43, 95, 173);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblBreadcrumbActual = new System.Windows.Forms.Label();
            this.lblBreadcrumbBase = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnClaveTemporal = new System.Windows.Forms.Button();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTipoArea = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblAyudaContrasena = new System.Windows.Forms.Label();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblModo = new System.Windows.Forms.Label();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.pnlListado = new System.Windows.Forms.Panel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.ucPaginador = new Vista.UCPaginadorGrid();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblTituloListado = new System.Windows.Forms.Label();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.tlpTipoArea.SuspendLayout();
            this.pnlListado.SuspendLayout();
            this.pnlBuscar.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
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
            this.lblFecha.Location = new System.Drawing.Point(1585, 11);
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
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(132, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Size = new System.Drawing.Size(69, 20);
            this.lblBreadcrumbActual.TabIndex = 1;
            this.lblBreadcrumbActual.Text = "Usuarios";
            // 
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(145, 151, 160);
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.Size = new System.Drawing.Size(107, 20);
            this.lblBreadcrumbBase.TabIndex = 0;
            this.lblBreadcrumbBase.Text = "Administración >";
            // 
            // pnlContenido
            // 
            this.pnlContenido.AutoScroll = true;
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlContenido.Controls.Add(this.tlpPrincipal);
            this.pnlContenido.Controls.Add(this.pnlEncabezado);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 43);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(26, 18, 26, 26);
            this.pnlContenido.Size = new System.Drawing.Size(1670, 1037);
            this.pnlContenido.TabIndex = 1;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(26, 18);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1618, 78);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(306, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Administración de usuarios";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(89, 105, 123);
            this.lblSubtitulo.Location = new System.Drawing.Point(3, 45);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(389, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Cree, edite, busque y elimine usuarios del sistema.";
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpPrincipal.Controls.Add(this.pnlFormulario, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnlListado, 1, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPrincipal.Location = new System.Drawing.Point(26, 96);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 760F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1618, 760);
            this.tlpPrincipal.TabIndex = 1;
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BackColor = System.Drawing.Color.White;
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormulario.Controls.Add(this.tlpBotones);
            this.pnlFormulario.Controls.Add(this.tlpTipoArea);
            this.pnlFormulario.Controls.Add(this.chkActivo);
            this.pnlFormulario.Controls.Add(this.lblActivo);
            this.pnlFormulario.Controls.Add(this.lblAyudaContrasena);
            this.pnlFormulario.Controls.Add(this.txtConfirmarContrasena);
            this.pnlFormulario.Controls.Add(this.lblConfirmarContrasena);
            this.pnlFormulario.Controls.Add(this.txtContrasena);
            this.pnlFormulario.Controls.Add(this.lblContrasena);
            this.pnlFormulario.Controls.Add(this.txtUsuario);
            this.pnlFormulario.Controls.Add(this.lblUsuario);
            this.pnlFormulario.Controls.Add(this.txtNombreCompleto);
            this.pnlFormulario.Controls.Add(this.lblNombreCompleto);
            this.pnlFormulario.Controls.Add(this.lblModo);
            this.pnlFormulario.Controls.Add(this.lblTituloFormulario);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Location = new System.Drawing.Point(3, 3);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(576, 754);
            this.pnlFormulario.TabIndex = 0;
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.AutoSize = true;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloFormulario.ForeColor = System.Drawing.Color.FromArgb(54, 70, 88);
            this.lblTituloFormulario.Location = new System.Drawing.Point(28, 20);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(176, 25);
            this.lblTituloFormulario.TabIndex = 0;
            this.lblTituloFormulario.Text = "Datos del usuario";
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblModo.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblModo.Location = new System.Drawing.Point(28, 52);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(97, 20);
            this.lblModo.TabIndex = 1;
            this.lblModo.Text = "Nuevo usuario";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblNombreCompleto.Location = new System.Drawing.Point(28, 93);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(132, 20);
            this.lblNombreCompleto.TabIndex = 2;
            this.lblNombreCompleto.Text = "Nombre completo";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCompleto_KeyPress);
            this.txtNombreCompleto.Location = new System.Drawing.Point(28, 118);
            this.txtNombreCompleto.MaxLength = 150;
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.ShortcutsEnabled = false;
            this.txtNombreCompleto.Size = new System.Drawing.Size(518, 30);
            this.txtNombreCompleto.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblUsuario.Location = new System.Drawing.Point(28, 166);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Location = new System.Drawing.Point(28, 191);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ShortcutsEnabled = false;
            this.txtUsuario.Size = new System.Drawing.Size(518, 30);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblContrasena.Location = new System.Drawing.Point(28, 239);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(86, 20);
            this.lblContrasena.TabIndex = 6;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContrasena.Location = new System.Drawing.Point(28, 264);
            this.txtContrasena.MaxLength = 72;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.ShortcutsEnabled = false;
            this.txtContrasena.Size = new System.Drawing.Size(518, 30);
            this.txtContrasena.TabIndex = 2;
            // 
            // lblConfirmarContrasena
            // 
            this.lblConfirmarContrasena.AutoSize = true;
            this.lblConfirmarContrasena.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmarContrasena.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblConfirmarContrasena.Location = new System.Drawing.Point(28, 312);
            this.lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            this.lblConfirmarContrasena.Size = new System.Drawing.Size(148, 20);
            this.lblConfirmarContrasena.TabIndex = 8;
            this.lblConfirmarContrasena.Text = "Confirmar contraseña";
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmarContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(28, 337);
            this.txtConfirmarContrasena.MaxLength = 72;
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.PasswordChar = '*';
            this.txtConfirmarContrasena.ShortcutsEnabled = false;
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(518, 30);
            this.txtConfirmarContrasena.TabIndex = 3;
            // 
            // lblAyudaContrasena
            // 
            this.lblAyudaContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAyudaContrasena.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAyudaContrasena.ForeColor = System.Drawing.Color.FromArgb(110, 121, 134);
            this.lblAyudaContrasena.Location = new System.Drawing.Point(28, 372);
            this.lblAyudaContrasena.Name = "lblAyudaContrasena";
            this.lblAyudaContrasena.Size = new System.Drawing.Size(518, 22);
            this.lblAyudaContrasena.TabIndex = 10;
            this.lblAyudaContrasena.Text = "Contraseña obligatoria para usuarios nuevos.";
            // 
            // tlpTipoArea
            // 
            this.tlpTipoArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTipoArea.ColumnCount = 2;
            this.tlpTipoArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTipoArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTipoArea.Controls.Add(this.lblTipoUsuario, 0, 0);
            this.tlpTipoArea.Controls.Add(this.lblArea, 1, 0);
            this.tlpTipoArea.Controls.Add(this.cboTipoUsuario, 0, 1);
            this.tlpTipoArea.Controls.Add(this.cboArea, 1, 1);
            this.tlpTipoArea.Location = new System.Drawing.Point(24, 405);
            this.tlpTipoArea.Name = "tlpTipoArea";
            this.tlpTipoArea.RowCount = 2;
            this.tlpTipoArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpTipoArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpTipoArea.Size = new System.Drawing.Size(526, 64);
            this.tlpTipoArea.TabIndex = 4;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.TabIndex = 11;
            this.lblTipoUsuario.Text = "Tipo de usuario";
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 8, 2);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.TabIndex = 4;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblArea.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.TabIndex = 13;
            this.lblArea.Text = "Área";
            // 
            // cboArea
            // 
            this.cboArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboArea.Margin = new System.Windows.Forms.Padding(8, 2, 4, 2);
            this.cboArea.Name = "cboArea";
            this.cboArea.TabIndex = 5;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblActivo.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblActivo.Location = new System.Drawing.Point(28, 484);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(51, 20);
            this.lblActivo.TabIndex = 15;
            this.lblActivo.Text = "Estado";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkActivo.Location = new System.Drawing.Point(28, 512);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(70, 24);
            this.chkActivo.TabIndex = 6;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // tlpBotones
            // 
            this.tlpBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.btnNuevo, 0, 0);
            this.tlpBotones.Controls.Add(this.btnGuardar, 1, 0);
            this.tlpBotones.Controls.Add(this.btnActualizar, 0, 1);
            this.tlpBotones.Controls.Add(this.btnEliminar, 1, 1);
            this.tlpBotones.Controls.Add(this.btnClaveTemporal, 0, 2);
            this.tlpBotones.SetColumnSpan(this.btnClaveTemporal, 2);
            this.tlpBotones.Location = new System.Drawing.Point(24, 565);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 3;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpBotones.Size = new System.Drawing.Size(526, 138);
            this.tlpBotones.TabIndex = 7;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 64, 64);
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(190, 52, 52);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // 
            this.btnClaveTemporal.BackColor = System.Drawing.Color.White;
            this.btnClaveTemporal.Click += new System.EventHandler(this.btnClaveTemporal_Click);
            this.btnClaveTemporal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClaveTemporal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnClaveTemporal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClaveTemporal.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnClaveTemporal.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnClaveTemporal.Margin = new System.Windows.Forms.Padding(4);
            this.btnClaveTemporal.Name = "btnClaveTemporal";
            this.btnClaveTemporal.TabIndex = 11;
            this.btnClaveTemporal.Text = "Clave temporal";
            this.btnClaveTemporal.UseVisualStyleBackColor = false;
            // 
            // 
            // pnlListado
            // 
            this.pnlListado.BackColor = System.Drawing.Color.White;
            this.pnlListado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListado.Controls.Add(this.dgvUsuarios);
            this.pnlListado.Controls.Add(this.ucPaginador);
            this.pnlListado.Controls.Add(this.pnlBuscar);
            this.pnlListado.Controls.Add(this.lblTituloListado);
            this.pnlListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListado.Location = new System.Drawing.Point(588, 3);
            this.pnlListado.Name = "pnlListado";
            this.pnlListado.Size = new System.Drawing.Size(1027, 754);
            this.pnlListado.TabIndex = 1;
            // 
            // lblTituloListado
            // 
            this.lblTituloListado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloListado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloListado.ForeColor = System.Drawing.Color.FromArgb(54, 70, 88);
            this.lblTituloListado.Location = new System.Drawing.Point(0, 0);
            this.lblTituloListado.Name = "lblTituloListado";
            this.lblTituloListado.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.lblTituloListado.Size = new System.Drawing.Size(1025, 48);
            this.lblTituloListado.TabIndex = 0;
            this.lblTituloListado.Text = "Usuarios registrados";
            this.lblTituloListado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.txtBuscar);
            this.pnlBuscar.Controls.Add(this.lblBuscar);
            this.pnlBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscar.Location = new System.Drawing.Point(0, 48);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Padding = new System.Windows.Forms.Padding(18, 8, 18, 8);
            this.pnlBuscar.Size = new System.Drawing.Size(1025, 62);
            this.pnlBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblBuscar.Location = new System.Drawing.Point(18, 20);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(52, 20);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(85, 15);
            this.txtBuscar.MaxLength = 150;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ShortcutsEnabled = false;
            this.txtBuscar.Size = new System.Drawing.Size(920, 30);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = encabezado;
            this.dgvUsuarios.ColumnHeadersHeight = 38;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 110);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowTemplate.Height = 36;
            this.dgvUsuarios.RowsDefaultCellStyle = filas;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1025, 642);
            this.dgvUsuarios.TabIndex = 1;
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
            // frmAdministracionSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.frmAdministracionSistema_Load);
            this.MinimumSize = new System.Drawing.Size(1050, 700);
            this.Name = "frmAdministracionSistema";
            this.Text = "Administración de usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.tlpTipoArea.ResumeLayout(false);
            this.tlpTipoArea.PerformLayout();
            this.pnlListado.ResumeLayout(false);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblBreadcrumbActual;
        private System.Windows.Forms.Label lblBreadcrumbBase;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblConfirmarContrasena;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.Label lblAyudaContrasena;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.ComboBox cboTipoUsuario;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnClaveTemporal;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.TableLayoutPanel tlpTipoArea;
        private System.Windows.Forms.Panel pnlListado;
        private System.Windows.Forms.Label lblTituloListado;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private Vista.UCPaginadorGrid ucPaginador;
    }
}
