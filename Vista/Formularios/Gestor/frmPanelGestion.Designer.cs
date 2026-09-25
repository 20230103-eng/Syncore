namespace Vista
{
    partial class frmPanelGestion
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblBreadcrumbActual = new System.Windows.Forms.Label();
            this.lblBreadcrumbBase = new System.Windows.Forms.Label();
            this.pnlViewport = new System.Windows.Forms.Panel();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.tlpDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCabeceraDashboard = new System.Windows.Forms.Panel();
            this.btnNuevoProyecto = new System.Windows.Forms.Button();
            this.btnProductividad = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.flpTarjetas = new System.Windows.Forms.TableLayoutPanel();
            this.tarjeta1 = new Vista.UCTarjetaIndicador();
            this.tarjeta2 = new Vista.UCTarjetaIndicador();
            this.tarjeta3 = new Vista.UCTarjetaIndicador();
            this.tarjeta4 = new Vista.UCTarjetaIndicador();
            this.tlpFilaSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.pnlProyectosCriticos = new System.Windows.Forms.Panel();
            this.flpProyectosCriticos = new System.Windows.Forms.Panel();
            this.proyecto4 = new Vista.UCProyectoCritico();
            this.proyecto3 = new Vista.UCProyectoCritico();
            this.proyecto2 = new Vista.UCProyectoCritico();
            this.proyecto1 = new Vista.UCProyectoCritico();
            this.pnlEncabezadoProyectos = new System.Windows.Forms.TableLayoutPanel();
            this.lblHProyecto = new System.Windows.Forms.Label();
            this.lblHArea = new System.Windows.Forms.Label();
            this.lblHAvance = new System.Windows.Forms.Label();
            this.lblHTareas = new System.Windows.Forms.Label();
            this.lblHEstado = new System.Windows.Forms.Label();
            this.lblHAccion = new System.Windows.Forms.Label();
            this.pnlSeparadorProyectos = new System.Windows.Forms.Panel();
            this.lblProyectosCriticos = new System.Windows.Forms.Label();
            this.pnlAlertas = new System.Windows.Forms.Panel();
            this.flpAlertas = new System.Windows.Forms.Panel();
            this.alerta3 = new Vista.UCAlertaGestion();
            this.alerta2 = new Vista.UCAlertaGestion();
            this.alerta1 = new Vista.UCAlertaGestion();
            this.pnlSeparadorAlertas = new System.Windows.Forms.Panel();
            this.lblAlertas = new System.Windows.Forms.Label();
            this.tlpFilaInferior = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAvanceProyecto = new System.Windows.Forms.Panel();
            this.flpBarrasProyecto = new System.Windows.Forms.FlowLayoutPanel();
            this.barraProyecto1 = new Vista.UCBarraProyecto();
            this.barraProyecto2 = new Vista.UCBarraProyecto();
            this.barraProyecto3 = new Vista.UCBarraProyecto();
            this.barraProyecto4 = new Vista.UCBarraProyecto();
            this.pnlSeparadorAvance = new System.Windows.Forms.Panel();
            this.lblAvanceProyecto = new System.Windows.Forms.Label();
            this.pnlAvancesRecientes = new System.Windows.Forms.Panel();
            this.flpAvancesRecientes = new System.Windows.Forms.Panel();
            this.avanceReciente3 = new Vista.UCAvanceReciente();
            this.avanceReciente2 = new Vista.UCAvanceReciente();
            this.avanceReciente1 = new Vista.UCAvanceReciente();
            this.pnlSeparadorAvances = new System.Windows.Forms.Panel();
            this.lblAvancesRecientes = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlViewport.SuspendLayout();
            this.pnlCanvas.SuspendLayout();
            this.tlpDashboard.SuspendLayout();
            this.pnlCabeceraDashboard.SuspendLayout();
            this.flpTarjetas.SuspendLayout();
            this.tlpFilaSuperior.SuspendLayout();
            this.pnlProyectosCriticos.SuspendLayout();
            this.flpProyectosCriticos.SuspendLayout();
            this.pnlEncabezadoProyectos.SuspendLayout();
            this.pnlAlertas.SuspendLayout();
            this.flpAlertas.SuspendLayout();
            this.tlpFilaInferior.SuspendLayout();
            this.pnlAvanceProyecto.SuspendLayout();
            this.flpBarrasProyecto.SuspendLayout();
            this.pnlAvancesRecientes.SuspendLayout();
            this.flpAvancesRecientes.SuspendLayout();
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
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.lblFecha.Location = new System.Drawing.Point(1610, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblBreadcrumbActual
            // 
            this.lblBreadcrumbActual.AutoSize = true;
            this.lblBreadcrumbActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreadcrumbActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(74, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Size = new System.Drawing.Size(98, 15);
            this.lblBreadcrumbActual.TabIndex = 1;
            this.lblBreadcrumbActual.Text = "Panel de gestión";
            // 
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.Size = new System.Drawing.Size(47, 15);
            this.lblBreadcrumbBase.TabIndex = 0;
            this.lblBreadcrumbBase.Text = "Inicio >";
            // 
            // pnlViewport
            // 
            this.pnlViewport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlViewport.Controls.Add(this.pnlCanvas);
            this.pnlViewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewport.Location = new System.Drawing.Point(0, 43);
            this.pnlViewport.Name = "pnlViewport";
            this.pnlViewport.Size = new System.Drawing.Size(1670, 1037);
            this.pnlViewport.TabIndex = 1;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.AutoScroll = true;
            this.pnlCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlCanvas.Controls.Add(this.tlpDashboard);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1670, 1037);
            this.pnlCanvas.TabIndex = 0;
            // 
            // tlpDashboard
            // 
            this.tlpDashboard.AutoSize = true;
            this.tlpDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpDashboard.ColumnCount = 1;
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDashboard.Controls.Add(this.pnlCabeceraDashboard, 0, 0);
            this.tlpDashboard.Controls.Add(this.flpTarjetas, 0, 1);
            this.tlpDashboard.Controls.Add(this.tlpFilaSuperior, 0, 2);
            this.tlpDashboard.Controls.Add(this.tlpFilaInferior, 0, 3);
            this.tlpDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpDashboard.Location = new System.Drawing.Point(0, 0);
            this.tlpDashboard.Name = "tlpDashboard";
            this.tlpDashboard.Padding = new System.Windows.Forms.Padding(24, 18, 24, 24);
            this.tlpDashboard.RowCount = 4;
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpDashboard.Size = new System.Drawing.Size(1670, 882);
            this.tlpDashboard.TabIndex = 0;
            // 
            // pnlCabeceraDashboard
            // 
            this.pnlCabeceraDashboard.Controls.Add(this.btnNuevoProyecto);
            this.pnlCabeceraDashboard.Controls.Add(this.btnProductividad);
            this.pnlCabeceraDashboard.Controls.Add(this.lblTitulo);
            this.pnlCabeceraDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCabeceraDashboard.Location = new System.Drawing.Point(27, 21);
            this.pnlCabeceraDashboard.Name = "pnlCabeceraDashboard";
            this.pnlCabeceraDashboard.Size = new System.Drawing.Size(1616, 54);
            this.pnlCabeceraDashboard.TabIndex = 0;
            // 
            // btnNuevoProyecto
            // 
            this.btnNuevoProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.btnNuevoProyecto.Click += new System.EventHandler(this.btnNuevoProyecto_Click);
            this.btnNuevoProyecto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProyecto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevoProyecto.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProyecto.Location = new System.Drawing.Point(1450, 8);
            this.btnNuevoProyecto.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnNuevoProyecto.Name = "btnNuevoProyecto";
            this.btnNuevoProyecto.Size = new System.Drawing.Size(164, 38);
            this.btnNuevoProyecto.TabIndex = 2;
            this.btnNuevoProyecto.Text = "+ Nuevo proyecto";
            this.btnNuevoProyecto.UseVisualStyleBackColor = false;
            // 
            // btnProductividad
            // 
            this.btnProductividad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductividad.BackColor = System.Drawing.Color.White;
            this.btnProductividad.Click += new System.EventHandler(this.btnProductividad_Click);
            this.btnProductividad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.btnProductividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductividad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProductividad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.btnProductividad.Location = new System.Drawing.Point(1305, 8);
            this.btnProductividad.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnProductividad.Name = "btnProductividad";
            this.btnProductividad.Size = new System.Drawing.Size(130, 38);
            this.btnProductividad.TabIndex = 1;
            this.btnProductividad.Text = "▥ Productividad";
            this.btnProductividad.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(203, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Panel de gestión";
            // 
            // flpTarjetas
            // 
            this.flpTarjetas.ColumnCount = 4;
            this.flpTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.flpTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.flpTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.flpTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.flpTarjetas.Controls.Add(this.tarjeta1, 0, 0);
            this.flpTarjetas.Controls.Add(this.tarjeta2, 1, 0);
            this.flpTarjetas.Controls.Add(this.tarjeta3, 2, 0);
            this.flpTarjetas.Controls.Add(this.tarjeta4, 3, 0);
            this.flpTarjetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTarjetas.Location = new System.Drawing.Point(27, 81);
            this.flpTarjetas.Name = "flpTarjetas";
            this.flpTarjetas.RowCount = 1;
            this.flpTarjetas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flpTarjetas.Size = new System.Drawing.Size(1616, 124);
            this.flpTarjetas.TabIndex = 1;
            // 
            // tarjeta1
            // 
            this.tarjeta1.BackColor = System.Drawing.Color.White;
            this.tarjeta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tarjeta1.ColorLinea = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.tarjeta1.ColorValor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.tarjeta1.Detalle = "2 en revisión";
            this.tarjeta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjeta1.Location = new System.Drawing.Point(0, 0);
            this.tarjeta1.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.tarjeta1.MinimumSize = new System.Drawing.Size(180, 116);
            this.tarjeta1.Name = "tarjeta1";
            this.tarjeta1.Size = new System.Drawing.Size(388, 124);
            this.tarjeta1.TabIndex = 0;
            this.tarjeta1.Titulo = "Proyectos activos";
            this.tarjeta1.Valor = "7";
            // 
            // tarjeta2
            // 
            this.tarjeta2.BackColor = System.Drawing.Color.White;
            this.tarjeta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tarjeta2.ColorLinea = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(49)))));
            this.tarjeta2.ColorValor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(49)))));
            this.tarjeta2.Detalle = "Requieren intervención";
            this.tarjeta2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjeta2.Location = new System.Drawing.Point(404, 0);
            this.tarjeta2.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.tarjeta2.MinimumSize = new System.Drawing.Size(180, 116);
            this.tarjeta2.Name = "tarjeta2";
            this.tarjeta2.Size = new System.Drawing.Size(388, 124);
            this.tarjeta2.TabIndex = 1;
            this.tarjeta2.Titulo = "Proyectos atrasados";
            this.tarjeta2.Valor = "3";
            // 
            // tarjeta3
            // 
            this.tarjeta3.BackColor = System.Drawing.Color.White;
            this.tarjeta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tarjeta3.ColorLinea = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.tarjeta3.ColorValor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.tarjeta3.Detalle = "En 4 proyectos";
            this.tarjeta3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjeta3.Location = new System.Drawing.Point(808, 0);
            this.tarjeta3.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.tarjeta3.MinimumSize = new System.Drawing.Size(180, 116);
            this.tarjeta3.Name = "tarjeta3";
            this.tarjeta3.Size = new System.Drawing.Size(388, 124);
            this.tarjeta3.TabIndex = 2;
            this.tarjeta3.Titulo = "Tareas vencidas";
            this.tarjeta3.Valor = "3";
            // 
            // tarjeta4
            // 
            this.tarjeta4.BackColor = System.Drawing.Color.White;
            this.tarjeta4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tarjeta4.ColorLinea = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(99)))), ((int)(((byte)(171)))));
            this.tarjeta4.ColorValor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.tarjeta4.Detalle = "Plan: 70%";
            this.tarjeta4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjeta4.Location = new System.Drawing.Point(1212, 0);
            this.tarjeta4.Margin = new System.Windows.Forms.Padding(0);
            this.tarjeta4.MinimumSize = new System.Drawing.Size(180, 116);
            this.tarjeta4.Name = "tarjeta4";
            this.tarjeta4.Size = new System.Drawing.Size(404, 124);
            this.tarjeta4.TabIndex = 3;
            this.tarjeta4.Titulo = "Avance promedio";
            this.tarjeta4.Valor = "58%";
            // 
            // tlpFilaSuperior
            // 
            this.tlpFilaSuperior.ColumnCount = 2;
            this.tlpFilaSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tlpFilaSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpFilaSuperior.Controls.Add(this.pnlProyectosCriticos, 0, 0);
            this.tlpFilaSuperior.Controls.Add(this.pnlAlertas, 1, 0);
            this.tlpFilaSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFilaSuperior.Location = new System.Drawing.Point(27, 211);
            this.tlpFilaSuperior.Name = "tlpFilaSuperior";
            this.tlpFilaSuperior.RowCount = 1;
            this.tlpFilaSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilaSuperior.Size = new System.Drawing.Size(1616, 344);
            this.tlpFilaSuperior.TabIndex = 2;
            // 
            // pnlProyectosCriticos
            // 
            this.pnlProyectosCriticos.BackColor = System.Drawing.Color.White;
            this.pnlProyectosCriticos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProyectosCriticos.Controls.Add(this.flpProyectosCriticos);
            this.pnlProyectosCriticos.Controls.Add(this.pnlEncabezadoProyectos);
            this.pnlProyectosCriticos.Controls.Add(this.pnlSeparadorProyectos);
            this.pnlProyectosCriticos.Controls.Add(this.lblProyectosCriticos);
            this.pnlProyectosCriticos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProyectosCriticos.Location = new System.Drawing.Point(3, 3);
            this.pnlProyectosCriticos.Name = "pnlProyectosCriticos";
            this.pnlProyectosCriticos.Size = new System.Drawing.Size(1157, 338);
            this.pnlProyectosCriticos.TabIndex = 7;
            // 
            // flpProyectosCriticos
            // 
            this.flpProyectosCriticos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpProyectosCriticos.AutoScroll = true;
            this.flpProyectosCriticos.Controls.Add(this.proyecto4);
            this.flpProyectosCriticos.Controls.Add(this.proyecto3);
            this.flpProyectosCriticos.Controls.Add(this.proyecto2);
            this.flpProyectosCriticos.Controls.Add(this.proyecto1);
            this.flpProyectosCriticos.Location = new System.Drawing.Point(10, 88);
            this.flpProyectosCriticos.Name = "flpProyectosCriticos";
            this.flpProyectosCriticos.Size = new System.Drawing.Size(1135, 238);
            this.flpProyectosCriticos.TabIndex = 3;
            // 
            // proyecto4
            // 
            this.proyecto4.Area = "Administración";
            this.proyecto4.Avance = 45;
            this.proyecto4.BackColor = System.Drawing.Color.White;
            this.proyecto4.ColorAvance = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(99)))), ((int)(((byte)(171)))));
            this.proyecto4.ColorEstado = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(169)))), ((int)(((byte)(87)))));
            this.proyecto4.Dock = System.Windows.Forms.DockStyle.Top;
            this.proyecto4.Estado = "Activo";
            this.proyecto4.FondoEstado = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(231)))));
            this.proyecto4.Location = new System.Drawing.Point(0, 144);
            this.proyecto4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.proyecto4.MaximumSize = new System.Drawing.Size(0, 48);
            this.proyecto4.MinimumSize = new System.Drawing.Size(600, 48);
            this.proyecto4.Name = "proyecto4";
            this.proyecto4.NombreProyecto = "Proyecto 4";
            this.proyecto4.Size = new System.Drawing.Size(1135, 48);
            this.proyecto4.TabIndex = 3;
            this.proyecto4.TareasVencidas = 2;
            this.proyecto4.TextoBoton = "Ver";
            // 
            // proyecto3
            // 
            this.proyecto3.Area = "Administración";
            this.proyecto3.Avance = 45;
            this.proyecto3.BackColor = System.Drawing.Color.White;
            this.proyecto3.ColorAvance = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(99)))), ((int)(((byte)(171)))));
            this.proyecto3.ColorEstado = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(49)))));
            this.proyecto3.Dock = System.Windows.Forms.DockStyle.Top;
            this.proyecto3.Estado = "Observación";
            this.proyecto3.FondoEstado = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(221)))));
            this.proyecto3.Location = new System.Drawing.Point(0, 96);
            this.proyecto3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.proyecto3.MaximumSize = new System.Drawing.Size(0, 48);
            this.proyecto3.MinimumSize = new System.Drawing.Size(600, 48);
            this.proyecto3.Name = "proyecto3";
            this.proyecto3.NombreProyecto = "Proyecto 3";
            this.proyecto3.Size = new System.Drawing.Size(1135, 48);
            this.proyecto3.TabIndex = 2;
            this.proyecto3.TareasVencidas = 2;
            this.proyecto3.TextoBoton = "Ver";
            // 
            // proyecto2
            // 
            this.proyecto2.Area = "Social";
            this.proyecto2.Avance = 45;
            this.proyecto2.BackColor = System.Drawing.Color.White;
            this.proyecto2.ColorAvance = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(99)))), ((int)(((byte)(171)))));
            this.proyecto2.ColorEstado = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.proyecto2.Dock = System.Windows.Forms.DockStyle.Top;
            this.proyecto2.Estado = "Crítico";
            this.proyecto2.FondoEstado = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.proyecto2.Location = new System.Drawing.Point(0, 48);
            this.proyecto2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.proyecto2.MaximumSize = new System.Drawing.Size(0, 48);
            this.proyecto2.MinimumSize = new System.Drawing.Size(600, 48);
            this.proyecto2.Name = "proyecto2";
            this.proyecto2.NombreProyecto = "Proyecto 2";
            this.proyecto2.Size = new System.Drawing.Size(1135, 48);
            this.proyecto2.TabIndex = 1;
            this.proyecto2.TareasVencidas = 2;
            this.proyecto2.TextoBoton = "Ver";
            // 
            // proyecto1
            // 
            this.proyecto1.Area = "Social";
            this.proyecto1.Avance = 45;
            this.proyecto1.BackColor = System.Drawing.Color.White;
            this.proyecto1.ColorAvance = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(99)))), ((int)(((byte)(171)))));
            this.proyecto1.ColorEstado = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.proyecto1.Dock = System.Windows.Forms.DockStyle.Top;
            this.proyecto1.Estado = "Crítico";
            this.proyecto1.FondoEstado = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.proyecto1.Location = new System.Drawing.Point(0, 0);
            this.proyecto1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.proyecto1.MaximumSize = new System.Drawing.Size(0, 48);
            this.proyecto1.MinimumSize = new System.Drawing.Size(600, 48);
            this.proyecto1.Name = "proyecto1";
            this.proyecto1.NombreProyecto = "Proyecto 1";
            this.proyecto1.Size = new System.Drawing.Size(1135, 48);
            this.proyecto1.TabIndex = 0;
            this.proyecto1.TareasVencidas = 2;
            this.proyecto1.TextoBoton = "Ver";
            // 
            // pnlEncabezadoProyectos
            // 
            this.pnlEncabezadoProyectos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEncabezadoProyectos.ColumnCount = 6;
            this.pnlEncabezadoProyectos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.pnlEncabezadoProyectos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlEncabezadoProyectos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.pnlEncabezadoProyectos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.pnlEncabezadoProyectos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.pnlEncabezadoProyectos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlEncabezadoProyectos.Controls.Add(this.lblHProyecto, 0, 0);
            this.pnlEncabezadoProyectos.Controls.Add(this.lblHArea, 1, 0);
            this.pnlEncabezadoProyectos.Controls.Add(this.lblHAvance, 2, 0);
            this.pnlEncabezadoProyectos.Controls.Add(this.lblHTareas, 3, 0);
            this.pnlEncabezadoProyectos.Controls.Add(this.lblHEstado, 4, 0);
            this.pnlEncabezadoProyectos.Controls.Add(this.lblHAccion, 5, 0);
            this.pnlEncabezadoProyectos.Location = new System.Drawing.Point(10, 50);
            this.pnlEncabezadoProyectos.Name = "pnlEncabezadoProyectos";
            this.pnlEncabezadoProyectos.RowCount = 1;
            this.pnlEncabezadoProyectos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlEncabezadoProyectos.Size = new System.Drawing.Size(1135, 38);
            this.pnlEncabezadoProyectos.TabIndex = 2;
            // 
            // lblHProyecto
            // 
            this.lblHProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHProyecto.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblHProyecto.Location = new System.Drawing.Point(10, 0);
            this.lblHProyecto.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.lblHProyecto.Name = "lblHProyecto";
            this.lblHProyecto.Size = new System.Drawing.Size(337, 38);
            this.lblHProyecto.TabIndex = 0;
            this.lblHProyecto.Text = "PROYECTO";
            this.lblHProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHArea
            // 
            this.lblHArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHArea.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblHArea.Location = new System.Drawing.Point(355, 0);
            this.lblHArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHArea.Name = "lblHArea";
            this.lblHArea.Size = new System.Drawing.Size(173, 38);
            this.lblHArea.TabIndex = 1;
            this.lblHArea.Text = "ÁREA";
            this.lblHArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHAvance
            // 
            this.lblHAvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHAvance.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHAvance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblHAvance.Location = new System.Drawing.Point(536, 0);
            this.lblHAvance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHAvance.Name = "lblHAvance";
            this.lblHAvance.Size = new System.Drawing.Size(241, 38);
            this.lblHAvance.TabIndex = 2;
            this.lblHAvance.Text = "AVANCE";
            this.lblHAvance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHTareas
            // 
            this.lblHTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHTareas.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHTareas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblHTareas.Location = new System.Drawing.Point(781, 0);
            this.lblHTareas.Margin = new System.Windows.Forms.Padding(0);
            this.lblHTareas.Name = "lblHTareas";
            this.lblHTareas.Size = new System.Drawing.Size(102, 38);
            this.lblHTareas.TabIndex = 3;
            this.lblHTareas.Text = "TAREAS VENC.";
            this.lblHTareas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHEstado
            // 
            this.lblHEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHEstado.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblHEstado.Location = new System.Drawing.Point(883, 0);
            this.lblHEstado.Margin = new System.Windows.Forms.Padding(0);
            this.lblHEstado.Name = "lblHEstado";
            this.lblHEstado.Size = new System.Drawing.Size(136, 38);
            this.lblHEstado.TabIndex = 4;
            this.lblHEstado.Text = "ESTADO";
            this.lblHEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHAccion
            // 
            this.lblHAccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHAccion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHAccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblHAccion.Location = new System.Drawing.Point(1019, 0);
            this.lblHAccion.Margin = new System.Windows.Forms.Padding(0);
            this.lblHAccion.Name = "lblHAccion";
            this.lblHAccion.Size = new System.Drawing.Size(116, 38);
            this.lblHAccion.TabIndex = 5;
            this.lblHAccion.Text = "ACCIÓN";
            this.lblHAccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSeparadorProyectos
            // 
            this.pnlSeparadorProyectos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeparadorProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.pnlSeparadorProyectos.Location = new System.Drawing.Point(10, 46);
            this.pnlSeparadorProyectos.Name = "pnlSeparadorProyectos";
            this.pnlSeparadorProyectos.Size = new System.Drawing.Size(1135, 1);
            this.pnlSeparadorProyectos.TabIndex = 1;
            // 
            // lblProyectosCriticos
            // 
            this.lblProyectosCriticos.AutoSize = true;
            this.lblProyectosCriticos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProyectosCriticos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblProyectosCriticos.Location = new System.Drawing.Point(12, 14);
            this.lblProyectosCriticos.Name = "lblProyectosCriticos";
            this.lblProyectosCriticos.Size = new System.Drawing.Size(115, 19);
            this.lblProyectosCriticos.TabIndex = 0;
            this.lblProyectosCriticos.Text = "Proyectos que requieren atención";
            // 
            // pnlAlertas
            // 
            this.pnlAlertas.BackColor = System.Drawing.Color.White;
            this.pnlAlertas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlertas.Controls.Add(this.flpAlertas);
            this.pnlAlertas.Controls.Add(this.pnlSeparadorAlertas);
            this.pnlAlertas.Controls.Add(this.lblAlertas);
            this.pnlAlertas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlertas.Location = new System.Drawing.Point(1166, 3);
            this.pnlAlertas.Name = "pnlAlertas";
            this.pnlAlertas.Size = new System.Drawing.Size(447, 338);
            this.pnlAlertas.TabIndex = 8;
            // 
            // flpAlertas
            // 
            this.flpAlertas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpAlertas.AutoScroll = true;
            this.flpAlertas.Controls.Add(this.alerta3);
            this.flpAlertas.Controls.Add(this.alerta2);
            this.flpAlertas.Controls.Add(this.alerta1);
            this.flpAlertas.Location = new System.Drawing.Point(10, 55);
            this.flpAlertas.Name = "flpAlertas";
            this.flpAlertas.Size = new System.Drawing.Size(425, 268);
            this.flpAlertas.TabIndex = 2;
            // 
            // alerta3
            // 
            this.alerta3.BackColor = System.Drawing.Color.White;
            this.alerta3.ColorPunto = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(99)))), ((int)(((byte)(171)))));
            this.alerta3.Detalle = "M. Pérez (2), E. Silva (1), A. Zometa (1)";
            this.alerta3.Dock = System.Windows.Forms.DockStyle.Top;
            this.alerta3.Fecha = "Ayer";
            this.alerta3.Location = new System.Drawing.Point(0, 184);
            this.alerta3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.alerta3.MaximumSize = new System.Drawing.Size(0, 92);
            this.alerta3.MinimumSize = new System.Drawing.Size(260, 92);
            this.alerta3.Name = "alerta3";
            this.alerta3.Size = new System.Drawing.Size(408, 92);
            this.alerta3.TabIndex = 2;
            this.alerta3.TextoBoton = "Revisar";
            this.alerta3.TipoAlerta = "Información";
            this.alerta3.Titulo = "4 tareas para revisión";
            // 
            // alerta2
            // 
            this.alerta2.BackColor = System.Drawing.Color.White;
            this.alerta2.ColorPunto = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(49)))));
            this.alerta2.Detalle = "Diseño materiales - Plan mejora";
            this.alerta2.Dock = System.Windows.Forms.DockStyle.Top;
            this.alerta2.Fecha = "Ayer";
            this.alerta2.Location = new System.Drawing.Point(0, 92);
            this.alerta2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.alerta2.MaximumSize = new System.Drawing.Size(0, 92);
            this.alerta2.MinimumSize = new System.Drawing.Size(260, 92);
            this.alerta2.Name = "alerta2";
            this.alerta2.Size = new System.Drawing.Size(408, 92);
            this.alerta2.TabIndex = 1;
            this.alerta2.TextoBoton = "Asignar";
            this.alerta2.TipoAlerta = "Advertencia";
            this.alerta2.Titulo = "Tarea sin responsable";
            // 
            // alerta1
            // 
            this.alerta1.BackColor = System.Drawing.Color.White;
            this.alerta1.ColorPunto = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.alerta1.Detalle = "PCN: 4 tareas vencidas sin actualizar";
            this.alerta1.Dock = System.Windows.Forms.DockStyle.Top;
            this.alerta1.Fecha = "Hace 30 min";
            this.alerta1.Location = new System.Drawing.Point(0, 0);
            this.alerta1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.alerta1.MaximumSize = new System.Drawing.Size(0, 92);
            this.alerta1.MinimumSize = new System.Drawing.Size(260, 92);
            this.alerta1.Name = "alerta1";
            this.alerta1.Size = new System.Drawing.Size(408, 92);
            this.alerta1.TabIndex = 0;
            this.alerta1.TextoBoton = "Ver proyecto";
            this.alerta1.TipoAlerta = "Crítica";
            this.alerta1.Titulo = "Proyecto atrasado";
            // 
            // pnlSeparadorAlertas
            // 
            this.pnlSeparadorAlertas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeparadorAlertas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.pnlSeparadorAlertas.Location = new System.Drawing.Point(10, 46);
            this.pnlSeparadorAlertas.Name = "pnlSeparadorAlertas";
            this.pnlSeparadorAlertas.Size = new System.Drawing.Size(425, 1);
            this.pnlSeparadorAlertas.TabIndex = 1;
            // 
            // lblAlertas
            // 
            this.lblAlertas.AutoSize = true;
            this.lblAlertas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAlertas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblAlertas.Location = new System.Drawing.Point(12, 14);
            this.lblAlertas.Name = "lblAlertas";
            this.lblAlertas.Size = new System.Drawing.Size(142, 19);
            this.lblAlertas.TabIndex = 0;
            this.lblAlertas.Text = "⚠ Alertas de gestión";
            // 
            // tlpFilaInferior
            // 
            this.tlpFilaInferior.ColumnCount = 2;
            this.tlpFilaInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tlpFilaInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpFilaInferior.Controls.Add(this.pnlAvanceProyecto, 0, 0);
            this.tlpFilaInferior.Controls.Add(this.pnlAvancesRecientes, 1, 0);
            this.tlpFilaInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFilaInferior.Location = new System.Drawing.Point(27, 561);
            this.tlpFilaInferior.Name = "tlpFilaInferior";
            this.tlpFilaInferior.RowCount = 1;
            this.tlpFilaInferior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilaInferior.Size = new System.Drawing.Size(1616, 294);
            this.tlpFilaInferior.TabIndex = 3;
            // 
            // pnlAvanceProyecto
            // 
            this.pnlAvanceProyecto.BackColor = System.Drawing.Color.White;
            this.pnlAvanceProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAvanceProyecto.Controls.Add(this.flpBarrasProyecto);
            this.pnlAvanceProyecto.Controls.Add(this.pnlSeparadorAvance);
            this.pnlAvanceProyecto.Controls.Add(this.lblAvanceProyecto);
            this.pnlAvanceProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAvanceProyecto.Location = new System.Drawing.Point(3, 3);
            this.pnlAvanceProyecto.Name = "pnlAvanceProyecto";
            this.pnlAvanceProyecto.Size = new System.Drawing.Size(1157, 288);
            this.pnlAvanceProyecto.TabIndex = 9;
            // 
            // flpBarrasProyecto
            // 
            this.flpBarrasProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBarrasProyecto.AutoScroll = true;
            this.flpBarrasProyecto.Controls.Add(this.barraProyecto1);
            this.flpBarrasProyecto.Controls.Add(this.barraProyecto2);
            this.flpBarrasProyecto.Controls.Add(this.barraProyecto3);
            this.flpBarrasProyecto.Controls.Add(this.barraProyecto4);
            this.flpBarrasProyecto.Location = new System.Drawing.Point(10, 52);
            this.flpBarrasProyecto.Name = "flpBarrasProyecto";
            this.flpBarrasProyecto.Size = new System.Drawing.Size(1135, 223);
            this.flpBarrasProyecto.TabIndex = 2;
            this.flpBarrasProyecto.WrapContents = false;
            // 
            // barraProyecto1
            // 
            this.barraProyecto1.Avance = 45;
            this.barraProyecto1.BackColor = System.Drawing.Color.White;
            this.barraProyecto1.ColorBarra = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.barraProyecto1.Location = new System.Drawing.Point(0, 0);
            this.barraProyecto1.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.barraProyecto1.Name = "barraProyecto1";
            this.barraProyecto1.NombreProyecto = "P1";
            this.barraProyecto1.Size = new System.Drawing.Size(125, 175);
            this.barraProyecto1.TabIndex = 0;
            // 
            // barraProyecto2
            // 
            this.barraProyecto2.Avance = 45;
            this.barraProyecto2.BackColor = System.Drawing.Color.White;
            this.barraProyecto2.ColorBarra = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.barraProyecto2.Location = new System.Drawing.Point(141, 0);
            this.barraProyecto2.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.barraProyecto2.Name = "barraProyecto2";
            this.barraProyecto2.NombreProyecto = "P2";
            this.barraProyecto2.Size = new System.Drawing.Size(125, 175);
            this.barraProyecto2.TabIndex = 1;
            // 
            // barraProyecto3
            // 
            this.barraProyecto3.Avance = 45;
            this.barraProyecto3.BackColor = System.Drawing.Color.White;
            this.barraProyecto3.ColorBarra = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.barraProyecto3.Location = new System.Drawing.Point(282, 0);
            this.barraProyecto3.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.barraProyecto3.Name = "barraProyecto3";
            this.barraProyecto3.NombreProyecto = "P3";
            this.barraProyecto3.Size = new System.Drawing.Size(125, 175);
            this.barraProyecto3.TabIndex = 2;
            // 
            // barraProyecto4
            // 
            this.barraProyecto4.Avance = 45;
            this.barraProyecto4.BackColor = System.Drawing.Color.White;
            this.barraProyecto4.ColorBarra = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.barraProyecto4.Location = new System.Drawing.Point(423, 0);
            this.barraProyecto4.Margin = new System.Windows.Forms.Padding(0);
            this.barraProyecto4.Name = "barraProyecto4";
            this.barraProyecto4.NombreProyecto = "P4";
            this.barraProyecto4.Size = new System.Drawing.Size(125, 175);
            this.barraProyecto4.TabIndex = 3;
            // 
            // pnlSeparadorAvance
            // 
            this.pnlSeparadorAvance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeparadorAvance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.pnlSeparadorAvance.Location = new System.Drawing.Point(10, 46);
            this.pnlSeparadorAvance.Name = "pnlSeparadorAvance";
            this.pnlSeparadorAvance.Size = new System.Drawing.Size(1135, 1);
            this.pnlSeparadorAvance.TabIndex = 1;
            // 
            // lblAvanceProyecto
            // 
            this.lblAvanceProyecto.AutoSize = true;
            this.lblAvanceProyecto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAvanceProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblAvanceProyecto.Location = new System.Drawing.Point(12, 14);
            this.lblAvanceProyecto.Name = "lblAvanceProyecto";
            this.lblAvanceProyecto.Size = new System.Drawing.Size(136, 19);
            this.lblAvanceProyecto.TabIndex = 0;
            this.lblAvanceProyecto.Text = "Avance por proyecto";
            // 
            // pnlAvancesRecientes
            // 
            this.pnlAvancesRecientes.BackColor = System.Drawing.Color.White;
            this.pnlAvancesRecientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAvancesRecientes.Controls.Add(this.flpAvancesRecientes);
            this.pnlAvancesRecientes.Controls.Add(this.pnlSeparadorAvances);
            this.pnlAvancesRecientes.Controls.Add(this.lblAvancesRecientes);
            this.pnlAvancesRecientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAvancesRecientes.Location = new System.Drawing.Point(1166, 3);
            this.pnlAvancesRecientes.Name = "pnlAvancesRecientes";
            this.pnlAvancesRecientes.Size = new System.Drawing.Size(447, 288);
            this.pnlAvancesRecientes.TabIndex = 10;
            // 
            // flpAvancesRecientes
            // 
            this.flpAvancesRecientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpAvancesRecientes.AutoScroll = true;
            this.flpAvancesRecientes.Controls.Add(this.avanceReciente3);
            this.flpAvancesRecientes.Controls.Add(this.avanceReciente2);
            this.flpAvancesRecientes.Controls.Add(this.avanceReciente1);
            this.flpAvancesRecientes.Location = new System.Drawing.Point(10, 50);
            this.flpAvancesRecientes.Name = "flpAvancesRecientes";
            this.flpAvancesRecientes.Size = new System.Drawing.Size(425, 225);
            this.flpAvancesRecientes.TabIndex = 3;
            // 
            // avanceReciente3
            // 
            this.avanceReciente3.BackColor = System.Drawing.Color.White;
            this.avanceReciente3.ColorPorcentaje = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(49)))));
            this.avanceReciente3.Dock = System.Windows.Forms.DockStyle.Top;
            this.avanceReciente3.ImagenPerfil = global::Vista.Properties.Recursos.AvatarUsuario;
            this.avanceReciente3.Location = new System.Drawing.Point(0, 136);
            this.avanceReciente3.Margin = new System.Windows.Forms.Padding(0);
            this.avanceReciente3.MaximumSize = new System.Drawing.Size(0, 68);
            this.avanceReciente3.MinimumSize = new System.Drawing.Size(260, 68);
            this.avanceReciente3.ModoImagen = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avanceReciente3.Name = "avanceReciente3";
            this.avanceReciente3.Nombre = "Elmer Silva";
            this.avanceReciente3.Porcentaje = 33;
            this.avanceReciente3.Size = new System.Drawing.Size(425, 68);
            this.avanceReciente3.TabIndex = 2;
            this.avanceReciente3.Tarea = "Tarea 3";
            // 
            // avanceReciente2
            // 
            this.avanceReciente2.BackColor = System.Drawing.Color.White;
            this.avanceReciente2.ColorPorcentaje = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(49)))));
            this.avanceReciente2.Dock = System.Windows.Forms.DockStyle.Top;
            this.avanceReciente2.ImagenPerfil = global::Vista.Properties.Recursos.AvatarUsuario;
            this.avanceReciente2.Location = new System.Drawing.Point(0, 68);
            this.avanceReciente2.Margin = new System.Windows.Forms.Padding(0);
            this.avanceReciente2.MaximumSize = new System.Drawing.Size(0, 68);
            this.avanceReciente2.MinimumSize = new System.Drawing.Size(260, 68);
            this.avanceReciente2.ModoImagen = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avanceReciente2.Name = "avanceReciente2";
            this.avanceReciente2.Nombre = "Erick Mercado";
            this.avanceReciente2.Porcentaje = 33;
            this.avanceReciente2.Size = new System.Drawing.Size(425, 68);
            this.avanceReciente2.TabIndex = 1;
            this.avanceReciente2.Tarea = "Tarea 2";
            // 
            // avanceReciente1
            // 
            this.avanceReciente1.BackColor = System.Drawing.Color.White;
            this.avanceReciente1.ColorPorcentaje = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(49)))));
            this.avanceReciente1.Dock = System.Windows.Forms.DockStyle.Top;
            this.avanceReciente1.ImagenPerfil = global::Vista.Properties.Recursos.AvatarUsuario;
            this.avanceReciente1.Location = new System.Drawing.Point(0, 0);
            this.avanceReciente1.Margin = new System.Windows.Forms.Padding(0);
            this.avanceReciente1.MaximumSize = new System.Drawing.Size(0, 68);
            this.avanceReciente1.MinimumSize = new System.Drawing.Size(260, 68);
            this.avanceReciente1.ModoImagen = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avanceReciente1.Name = "avanceReciente1";
            this.avanceReciente1.Nombre = "Alex Zometa";
            this.avanceReciente1.Porcentaje = 33;
            this.avanceReciente1.Size = new System.Drawing.Size(425, 68);
            this.avanceReciente1.TabIndex = 0;
            this.avanceReciente1.Tarea = "Tarea 1";
            // 
            // pnlSeparadorAvances
            // 
            this.pnlSeparadorAvances.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeparadorAvances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.pnlSeparadorAvances.Location = new System.Drawing.Point(10, 46);
            this.pnlSeparadorAvances.Name = "pnlSeparadorAvances";
            this.pnlSeparadorAvances.Size = new System.Drawing.Size(425, 1);
            this.pnlSeparadorAvances.TabIndex = 1;
            // 
            // lblAvancesRecientes
            // 
            this.lblAvancesRecientes.AutoSize = true;
            this.lblAvancesRecientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAvancesRecientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblAvancesRecientes.Location = new System.Drawing.Point(12, 14);
            this.lblAvancesRecientes.Name = "lblAvancesRecientes";
            this.lblAvancesRecientes.Size = new System.Drawing.Size(117, 19);
            this.lblAvancesRecientes.TabIndex = 0;
            this.lblAvancesRecientes.Text = "Historial de avances recientes";
            // 
            // frmPanelGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.Activated += new System.EventHandler(this.frmPanelGestion_Activated);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.pnlViewport);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPanelGestion";
            this.Shown += new System.EventHandler(this.frmPanelGestion_Shown);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de gestión";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlViewport.ResumeLayout(false);
            this.pnlCanvas.ResumeLayout(false);
            this.pnlCanvas.PerformLayout();
            this.tlpDashboard.ResumeLayout(false);
            this.pnlCabeceraDashboard.ResumeLayout(false);
            this.pnlCabeceraDashboard.PerformLayout();
            this.flpTarjetas.ResumeLayout(false);
            this.tlpFilaSuperior.ResumeLayout(false);
            this.pnlProyectosCriticos.ResumeLayout(false);
            this.pnlProyectosCriticos.PerformLayout();
            this.flpProyectosCriticos.ResumeLayout(false);
            this.pnlEncabezadoProyectos.ResumeLayout(false);
            this.pnlAlertas.ResumeLayout(false);
            this.pnlAlertas.PerformLayout();
            this.flpAlertas.ResumeLayout(false);
            this.tlpFilaInferior.ResumeLayout(false);
            this.pnlAvanceProyecto.ResumeLayout(false);
            this.pnlAvanceProyecto.PerformLayout();
            this.flpBarrasProyecto.ResumeLayout(false);
            this.pnlAvancesRecientes.ResumeLayout(false);
            this.pnlAvancesRecientes.PerformLayout();
            this.flpAvancesRecientes.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblBreadcrumbActual;
        private System.Windows.Forms.Label lblBreadcrumbBase;
        private System.Windows.Forms.Panel pnlViewport;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.TableLayoutPanel tlpDashboard;
        private System.Windows.Forms.Panel pnlCabeceraDashboard;
        private System.Windows.Forms.TableLayoutPanel tlpFilaSuperior;
        private System.Windows.Forms.TableLayoutPanel tlpFilaInferior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnProductividad;
        private System.Windows.Forms.Button btnNuevoProyecto;
        private System.Windows.Forms.TableLayoutPanel flpTarjetas;
        private System.Windows.Forms.Panel pnlProyectosCriticos;
        private System.Windows.Forms.Label lblProyectosCriticos;
        private System.Windows.Forms.Panel pnlSeparadorProyectos;
        private System.Windows.Forms.TableLayoutPanel pnlEncabezadoProyectos;
        private System.Windows.Forms.Label lblHProyecto;
        private System.Windows.Forms.Label lblHArea;
        private System.Windows.Forms.Label lblHAvance;
        private System.Windows.Forms.Label lblHTareas;
        private System.Windows.Forms.Label lblHEstado;
        private System.Windows.Forms.Label lblHAccion;
        private System.Windows.Forms.Panel flpProyectosCriticos;
        private System.Windows.Forms.Panel pnlAlertas;
        private System.Windows.Forms.Label lblAlertas;
        private System.Windows.Forms.Panel pnlSeparadorAlertas;
        private System.Windows.Forms.Panel flpAlertas;
        private System.Windows.Forms.Panel pnlAvanceProyecto;
        private System.Windows.Forms.Label lblAvanceProyecto;
        private System.Windows.Forms.Panel pnlSeparadorAvance;
        private System.Windows.Forms.FlowLayoutPanel flpBarrasProyecto;
        private System.Windows.Forms.Panel pnlAvancesRecientes;
        private System.Windows.Forms.Label lblAvancesRecientes;
        private System.Windows.Forms.Panel pnlSeparadorAvances;
        private System.Windows.Forms.Panel flpAvancesRecientes;
        private Vista.UCTarjetaIndicador tarjeta1;
        private Vista.UCTarjetaIndicador tarjeta2;
        private Vista.UCTarjetaIndicador tarjeta3;
        private Vista.UCTarjetaIndicador tarjeta4;
        private Vista.UCProyectoCritico proyecto1;
        private Vista.UCProyectoCritico proyecto2;
        private Vista.UCProyectoCritico proyecto3;
        private Vista.UCProyectoCritico proyecto4;
        private Vista.UCAlertaGestion alerta1;
        private Vista.UCAlertaGestion alerta2;
        private Vista.UCAlertaGestion alerta3;
        private Vista.UCBarraProyecto barraProyecto1;
        private Vista.UCBarraProyecto barraProyecto2;
        private Vista.UCBarraProyecto barraProyecto3;
        private Vista.UCBarraProyecto barraProyecto4;
        private Vista.UCAvanceReciente avanceReciente1;
        private Vista.UCAvanceReciente avanceReciente2;
        private Vista.UCAvanceReciente avanceReciente3;
    }
}
