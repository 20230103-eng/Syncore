namespace Vista
{
    partial class frmMiProductividad
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
            this.pnlViewport = new System.Windows.Forms.Panel();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCabecera = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitulos = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.tlpTarjetas = new System.Windows.Forms.TableLayoutPanel();
            this.tarjeta1 = new Vista.UCTarjetaIndicador();
            this.tarjeta2 = new Vista.UCTarjetaIndicador();
            this.tarjeta3 = new Vista.UCTarjetaIndicador();
            this.tarjeta4 = new Vista.UCTarjetaIndicador();
            this.tlpSecciones = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAvanceProyectos = new System.Windows.Forms.Panel();
            this.flpAvanceProyectos = new System.Windows.Forms.Panel();
            this.avanceProyecto1 = new Vista.UCProductividadProyecto();
            this.avanceProyecto2 = new Vista.UCProductividadProyecto();
            this.avanceProyecto3 = new Vista.UCProductividadProyecto();
            this.pnlHeaderAvance = new System.Windows.Forms.Panel();
            this.lblAvanceProyectos = new System.Windows.Forms.Label();
            this.pnlTareasCompletadas = new System.Windows.Forms.Panel();
            this.flpTareasCompletadas = new System.Windows.Forms.Panel();
            this.tareaCompletada1 = new Vista.UCFilaTareaCompletada();
            this.tareaCompletada2 = new Vista.UCFilaTareaCompletada();
            this.tareaCompletada3 = new Vista.UCFilaTareaCompletada();
            this.tareaCompletada4 = new Vista.UCFilaTareaCompletada();
            this.pnlHeaderTareas = new System.Windows.Forms.Panel();
            this.lblTareasCompletadas = new System.Windows.Forms.Label();
            this.pnlEstadoTareas = new System.Windows.Forms.Panel();
            this.tlpEstado = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPendiente = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBarraPendiente = new System.Windows.Forms.Panel();
            this.lblPendiente = new System.Windows.Forms.Label();
            this.tlpProgreso = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBarraProgreso = new System.Windows.Forms.Panel();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.tlpRevision = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBarraRevision = new System.Windows.Forms.Panel();
            this.lblRevision = new System.Windows.Forms.Label();
            this.tlpCompletada = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBarraCompletada = new System.Windows.Forms.Panel();
            this.lblCompletada = new System.Windows.Forms.Label();
            this.pnlHeaderEstado = new System.Windows.Forms.Panel();
            this.lblEstadoTareas = new System.Windows.Forms.Label();
            this.pnlHistorial = new System.Windows.Forms.Panel();
            this.pnlCuerpoHistorial = new System.Windows.Forms.Panel();
            this.flpHistorial = new System.Windows.Forms.Panel();
            this.avance1 = new Vista.UCFilaAvanceRegistrado();
            this.avance2 = new Vista.UCFilaAvanceRegistrado();
            this.avance3 = new Vista.UCFilaAvanceRegistrado();
            this.tlpEncabezadoHistorial = new System.Windows.Forms.TableLayoutPanel();
            this.lblHFecha = new System.Windows.Forms.Label();
            this.lblHTarea = new System.Windows.Forms.Label();
            this.lblHProyecto = new System.Windows.Forms.Label();
            this.lblHAvance = new System.Windows.Forms.Label();
            this.pnlHeaderHistorial = new System.Windows.Forms.Panel();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlViewport.SuspendLayout();
            this.pnlCanvas.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.tlpCabecera.SuspendLayout();
            this.pnlTitulos.SuspendLayout();
            this.tlpTarjetas.SuspendLayout();
            this.tlpSecciones.SuspendLayout();
            this.pnlAvanceProyectos.SuspendLayout();
            this.flpAvanceProyectos.SuspendLayout();
            this.pnlHeaderAvance.SuspendLayout();
            this.pnlTareasCompletadas.SuspendLayout();
            this.flpTareasCompletadas.SuspendLayout();
            this.pnlHeaderTareas.SuspendLayout();
            this.pnlEstadoTareas.SuspendLayout();
            this.tlpEstado.SuspendLayout();
            this.tlpPendiente.SuspendLayout();
            this.tlpProgreso.SuspendLayout();
            this.tlpRevision.SuspendLayout();
            this.tlpCompletada.SuspendLayout();
            this.pnlHeaderEstado.SuspendLayout();
            this.pnlHistorial.SuspendLayout();
            this.pnlCuerpoHistorial.SuspendLayout();
            this.flpHistorial.SuspendLayout();
            this.tlpEncabezadoHistorial.SuspendLayout();
            this.pnlHeaderHistorial.SuspendLayout();
            this.SuspendLayout();
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
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.lblFecha.Location = new System.Drawing.Point(1590, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // lblBreadcrumbActual
            // 
            this.lblBreadcrumbActual.AutoSize = true;
            this.lblBreadcrumbActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreadcrumbActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(101, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Size = new System.Drawing.Size(101, 15);
            this.lblBreadcrumbActual.TabIndex = 1;
            this.lblBreadcrumbActual.Text = "Mi productividad";
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.Size = new System.Drawing.Size(82, 15);
            this.lblBreadcrumbBase.TabIndex = 0;
            this.lblBreadcrumbBase.Text = "Mi avance >";
            // pnlViewport
            // 
            this.pnlViewport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlViewport.Controls.Add(this.pnlCanvas);
            this.pnlViewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewport.Location = new System.Drawing.Point(0, 43);
            this.pnlViewport.Name = "pnlViewport";
            this.pnlViewport.Size = new System.Drawing.Size(1670, 1037);
            this.pnlViewport.TabIndex = 1;
            // pnlCanvas
            // 
            this.pnlCanvas.AutoScroll = true;
            this.pnlCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlCanvas.Controls.Add(this.tlpPrincipal);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1670, 1037);
            this.pnlCanvas.TabIndex = 0;
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tlpCabecera, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpTarjetas, 0, 1);
            this.tlpPrincipal.Controls.Add(this.tlpSecciones, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(24);
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 570F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1670, 820);
            this.tlpPrincipal.TabIndex = 0;
            // tlpCabecera
            // 
            this.tlpCabecera.ColumnCount = 2;
            this.tlpCabecera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpCabecera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpCabecera.Controls.Add(this.pnlTitulos, 0, 0);
            this.tlpCabecera.Controls.Add(this.cboPeriodo, 1, 0);
            this.tlpCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCabecera.Location = new System.Drawing.Point(24, 24);
            this.tlpCabecera.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCabecera.Name = "tlpCabecera";
            this.tlpCabecera.RowCount = 1;
            this.tlpCabecera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCabecera.Size = new System.Drawing.Size(1622, 70);
            this.tlpCabecera.TabIndex = 0;
            // pnlTitulos
            // 
            this.pnlTitulos.Controls.Add(this.lblSubtitulo);
            this.pnlTitulos.Controls.Add(this.lblTitulo);
            this.pnlTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitulos.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulos.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitulos.Name = "pnlTitulos";
            this.pnlTitulos.Size = new System.Drawing.Size(1135, 70);
            this.pnlTitulos.TabIndex = 0;
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(3, 44);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(187, 15);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Tu desempeño operativo personal";
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mi productividad";
            // cboPeriodo
            // 
            this.cboPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Items.AddRange(new object[] {
            "Últimos 30 días",
            "Últimos 60 días",
            "Este año"});
            this.cboPeriodo.Location = new System.Drawing.Point(1428, 8);
            this.cboPeriodo.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(194, 23);
            this.cboPeriodo.TabIndex = 1;
            // tlpTarjetas
            // 
            this.tlpTarjetas.ColumnCount = 4;
            this.tlpTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTarjetas.Controls.Add(this.tarjeta1, 0, 0);
            this.tlpTarjetas.Controls.Add(this.tarjeta2, 1, 0);
            this.tlpTarjetas.Controls.Add(this.tarjeta3, 2, 0);
            this.tlpTarjetas.Controls.Add(this.tarjeta4, 3, 0);
            this.tlpTarjetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTarjetas.Location = new System.Drawing.Point(24, 94);
            this.tlpTarjetas.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTarjetas.Name = "tlpTarjetas";
            this.tlpTarjetas.RowCount = 1;
            this.tlpTarjetas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTarjetas.Size = new System.Drawing.Size(1622, 132);
            this.tlpTarjetas.TabIndex = 1;
            // tarjeta1
            // 
            this.tarjeta1.BackColor = System.Drawing.Color.White;
            this.tarjeta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tarjeta1.ColorLinea = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(169)))), ((int)(((byte)(87)))));
            this.tarjeta1.ColorValor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(169)))), ((int)(((byte)(87)))));
            this.tarjeta1.Detalle = "Este mes";
            this.tarjeta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjeta1.Location = new System.Drawing.Point(0, 0);
            this.tarjeta1.Margin = new System.Windows.Forms.Padding(0, 0, 12, 16);
            this.tarjeta1.MinimumSize = new System.Drawing.Size(180, 116);
            this.tarjeta1.Name = "tarjeta1";
            this.tarjeta1.Size = new System.Drawing.Size(393, 116);
            this.tarjeta1.TabIndex = 0;
            this.tarjeta1.Titulo = "Completadas";
            this.tarjeta1.Valor = "12";
            // tarjeta2
            // 
            this.tarjeta2.BackColor = System.Drawing.Color.White;
            this.tarjeta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tarjeta2.ColorLinea = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(49)))));
            this.tarjeta2.ColorValor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(49)))));
            this.tarjeta2.Detalle = "Por cerrar o en espera";
            this.tarjeta2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjeta2.Location = new System.Drawing.Point(405, 0);
            this.tarjeta2.Margin = new System.Windows.Forms.Padding(0, 0, 12, 16);
            this.tarjeta2.MinimumSize = new System.Drawing.Size(180, 116);
            this.tarjeta2.Name = "tarjeta2";
            this.tarjeta2.Size = new System.Drawing.Size(393, 116);
            this.tarjeta2.TabIndex = 1;
            this.tarjeta2.Titulo = "Pendientes";
            this.tarjeta2.Valor = "8";
            // tarjeta3
            // 
            this.tarjeta3.BackColor = System.Drawing.Color.White;
            this.tarjeta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tarjeta3.ColorLinea = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.tarjeta3.ColorValor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.tarjeta3.Detalle = "Requieren atención";
            this.tarjeta3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjeta3.Location = new System.Drawing.Point(810, 0);
            this.tarjeta3.Margin = new System.Windows.Forms.Padding(0, 0, 12, 16);
            this.tarjeta3.MinimumSize = new System.Drawing.Size(180, 116);
            this.tarjeta3.Name = "tarjeta3";
            this.tarjeta3.Size = new System.Drawing.Size(393, 116);
            this.tarjeta3.TabIndex = 2;
            this.tarjeta3.Titulo = "Vencidas";
            this.tarjeta3.Valor = "2";
            // tarjeta4
            // 
            this.tarjeta4.BackColor = System.Drawing.Color.White;
            this.tarjeta4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tarjeta4.ColorLinea = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.tarjeta4.ColorValor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.tarjeta4.Detalle = "+5% vs. mes anterior";
            this.tarjeta4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjeta4.Location = new System.Drawing.Point(1215, 0);
            this.tarjeta4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.tarjeta4.MinimumSize = new System.Drawing.Size(180, 116);
            this.tarjeta4.Name = "tarjeta4";
            this.tarjeta4.Size = new System.Drawing.Size(407, 116);
            this.tarjeta4.TabIndex = 3;
            this.tarjeta4.Titulo = "Cumplimiento";
            this.tarjeta4.Valor = "75%";
            // tlpSecciones
            // 
            this.tlpSecciones.ColumnCount = 2;
            this.tlpSecciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tlpSecciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tlpSecciones.Controls.Add(this.pnlAvanceProyectos, 0, 0);
            this.tlpSecciones.Controls.Add(this.pnlTareasCompletadas, 1, 0);
            this.tlpSecciones.Controls.Add(this.pnlEstadoTareas, 0, 1);
            this.tlpSecciones.Controls.Add(this.pnlHistorial, 1, 1);
            this.tlpSecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSecciones.Location = new System.Drawing.Point(24, 226);
            this.tlpSecciones.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSecciones.Name = "tlpSecciones";
            this.tlpSecciones.RowCount = 2;
            this.tlpSecciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpSecciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpSecciones.Size = new System.Drawing.Size(1622, 550);
            this.tlpSecciones.TabIndex = 2;
            // pnlAvanceProyectos
            // 
            this.pnlAvanceProyectos.BackColor = System.Drawing.Color.White;
            this.pnlAvanceProyectos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAvanceProyectos.Controls.Add(this.flpAvanceProyectos);
            this.pnlAvanceProyectos.Controls.Add(this.pnlHeaderAvance);
            this.pnlAvanceProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAvanceProyectos.Location = new System.Drawing.Point(0, 0);
            this.pnlAvanceProyectos.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.pnlAvanceProyectos.Name = "pnlAvanceProyectos";
            this.pnlAvanceProyectos.Size = new System.Drawing.Size(1092, 240);
            this.pnlAvanceProyectos.TabIndex = 0;
            // flpAvanceProyectos
            // 
            this.flpAvanceProyectos.AutoScroll = true;
            this.flpAvanceProyectos.Controls.Add(this.avanceProyecto3);
            this.flpAvanceProyectos.Controls.Add(this.avanceProyecto2);
            this.flpAvanceProyectos.Controls.Add(this.avanceProyecto1);
            this.flpAvanceProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAvanceProyectos.Location = new System.Drawing.Point(0, 48);
            this.flpAvanceProyectos.Name = "flpAvanceProyectos";
            this.flpAvanceProyectos.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.flpAvanceProyectos.Size = new System.Drawing.Size(1090, 220);
            this.flpAvanceProyectos.TabIndex = 1;
            // avanceProyecto1
            // 
            this.avanceProyecto1.Avance = 45;
            this.avanceProyecto1.BackColor = System.Drawing.Color.White;
            this.avanceProyecto1.ColorBarra = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(49)))));
            this.avanceProyecto1.Dock = System.Windows.Forms.DockStyle.Top;
            this.avanceProyecto1.Location = new System.Drawing.Point(14, 12);
            this.avanceProyecto1.Margin = new System.Windows.Forms.Padding(0);
            this.avanceProyecto1.MinimumSize = new System.Drawing.Size(300, 48);
            this.avanceProyecto1.Name = "avanceProyecto1";
            this.avanceProyecto1.NombreProyecto = "Proyecto 1";
            this.avanceProyecto1.Size = new System.Drawing.Size(1045, 48);
            this.avanceProyecto1.TabIndex = 0;
            this.avanceProyecto1.Tareas = 5;
            // avanceProyecto2
            // 
            this.avanceProyecto2.Avance = 50;
            this.avanceProyecto2.BackColor = System.Drawing.Color.White;
            this.avanceProyecto2.ColorBarra = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(49)))));
            this.avanceProyecto2.Dock = System.Windows.Forms.DockStyle.Top;
            this.avanceProyecto2.Location = new System.Drawing.Point(14, 64);
            this.avanceProyecto2.Margin = new System.Windows.Forms.Padding(0);
            this.avanceProyecto2.MinimumSize = new System.Drawing.Size(300, 48);
            this.avanceProyecto2.Name = "avanceProyecto2";
            this.avanceProyecto2.NombreProyecto = "Proyecto 2";
            this.avanceProyecto2.Size = new System.Drawing.Size(1045, 48);
            this.avanceProyecto2.TabIndex = 1;
            this.avanceProyecto2.Tareas = 6;
            // avanceProyecto3
            // 
            this.avanceProyecto3.Avance = 70;
            this.avanceProyecto3.BackColor = System.Drawing.Color.White;
            this.avanceProyecto3.ColorBarra = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(49)))));
            this.avanceProyecto3.Dock = System.Windows.Forms.DockStyle.Top;
            this.avanceProyecto3.Location = new System.Drawing.Point(14, 116);
            this.avanceProyecto3.Margin = new System.Windows.Forms.Padding(0);
            this.avanceProyecto3.MinimumSize = new System.Drawing.Size(300, 48);
            this.avanceProyecto3.Name = "avanceProyecto3";
            this.avanceProyecto3.NombreProyecto = "Proyecto 3";
            this.avanceProyecto3.Size = new System.Drawing.Size(1045, 48);
            this.avanceProyecto3.TabIndex = 2;
            this.avanceProyecto3.Tareas = 7;
            // pnlHeaderAvance
            // 
            this.pnlHeaderAvance.BackColor = System.Drawing.Color.White;
            this.pnlHeaderAvance.Controls.Add(this.lblAvanceProyectos);
            this.pnlHeaderAvance.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderAvance.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderAvance.Name = "pnlHeaderAvance";
            this.pnlHeaderAvance.Size = new System.Drawing.Size(1090, 48);
            this.pnlHeaderAvance.TabIndex = 0;
            // lblAvanceProyectos
            // 
            this.lblAvanceProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvanceProyectos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAvanceProyectos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblAvanceProyectos.Location = new System.Drawing.Point(0, 0);
            this.lblAvanceProyectos.Name = "lblAvanceProyectos";
            this.lblAvanceProyectos.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblAvanceProyectos.Size = new System.Drawing.Size(1090, 48);
            this.lblAvanceProyectos.TabIndex = 0;
            this.lblAvanceProyectos.Text = "Avance por proyecto asignado";
            this.lblAvanceProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // pnlTareasCompletadas
            // 
            this.pnlTareasCompletadas.BackColor = System.Drawing.Color.White;
            this.pnlTareasCompletadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTareasCompletadas.Controls.Add(this.flpTareasCompletadas);
            this.pnlTareasCompletadas.Controls.Add(this.pnlHeaderTareas);
            this.pnlTareasCompletadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTareasCompletadas.Location = new System.Drawing.Point(1102, 0);
            this.pnlTareasCompletadas.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlTareasCompletadas.Name = "pnlTareasCompletadas";
            this.pnlTareasCompletadas.Size = new System.Drawing.Size(520, 240);
            this.pnlTareasCompletadas.TabIndex = 1;
            // flpTareasCompletadas
            // 
            this.flpTareasCompletadas.AutoScroll = true;
            this.flpTareasCompletadas.Controls.Add(this.tareaCompletada4);
            this.flpTareasCompletadas.Controls.Add(this.tareaCompletada3);
            this.flpTareasCompletadas.Controls.Add(this.tareaCompletada2);
            this.flpTareasCompletadas.Controls.Add(this.tareaCompletada1);
            this.flpTareasCompletadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTareasCompletadas.Location = new System.Drawing.Point(0, 48);
            this.flpTareasCompletadas.Name = "flpTareasCompletadas";
            this.flpTareasCompletadas.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.flpTareasCompletadas.Size = new System.Drawing.Size(518, 220);
            this.flpTareasCompletadas.TabIndex = 1;
            // tareaCompletada1
            // 
            this.tareaCompletada1.BackColor = System.Drawing.Color.White;
            this.tareaCompletada1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tareaCompletada1.Location = new System.Drawing.Point(14, 12);
            this.tareaCompletada1.Margin = new System.Windows.Forms.Padding(0);
            this.tareaCompletada1.MinimumSize = new System.Drawing.Size(180, 37);
            this.tareaCompletada1.Name = "tareaCompletada1";
            this.tareaCompletada1.NombreTarea = "Nombre de tarea 1";
            this.tareaCompletada1.Size = new System.Drawing.Size(478, 37);
            this.tareaCompletada1.TabIndex = 0;
            // tareaCompletada2
            // 
            this.tareaCompletada2.BackColor = System.Drawing.Color.White;
            this.tareaCompletada2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tareaCompletada2.Location = new System.Drawing.Point(14, 49);
            this.tareaCompletada2.Margin = new System.Windows.Forms.Padding(0);
            this.tareaCompletada2.MinimumSize = new System.Drawing.Size(180, 37);
            this.tareaCompletada2.Name = "tareaCompletada2";
            this.tareaCompletada2.NombreTarea = "Nombre de tarea 2";
            this.tareaCompletada2.Size = new System.Drawing.Size(478, 37);
            this.tareaCompletada2.TabIndex = 1;
            // tareaCompletada3
            // 
            this.tareaCompletada3.BackColor = System.Drawing.Color.White;
            this.tareaCompletada3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tareaCompletada3.Location = new System.Drawing.Point(14, 86);
            this.tareaCompletada3.Margin = new System.Windows.Forms.Padding(0);
            this.tareaCompletada3.MinimumSize = new System.Drawing.Size(180, 37);
            this.tareaCompletada3.Name = "tareaCompletada3";
            this.tareaCompletada3.NombreTarea = "Nombre de tarea 3";
            this.tareaCompletada3.Size = new System.Drawing.Size(478, 37);
            this.tareaCompletada3.TabIndex = 2;
            // tareaCompletada4
            // 
            this.tareaCompletada4.BackColor = System.Drawing.Color.White;
            this.tareaCompletada4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tareaCompletada4.Location = new System.Drawing.Point(14, 123);
            this.tareaCompletada4.Margin = new System.Windows.Forms.Padding(0);
            this.tareaCompletada4.MinimumSize = new System.Drawing.Size(180, 37);
            this.tareaCompletada4.Name = "tareaCompletada4";
            this.tareaCompletada4.NombreTarea = "Nombre de tarea 4";
            this.tareaCompletada4.Size = new System.Drawing.Size(478, 37);
            this.tareaCompletada4.TabIndex = 3;
            // pnlHeaderTareas
            // 
            this.pnlHeaderTareas.BackColor = System.Drawing.Color.White;
            this.pnlHeaderTareas.Controls.Add(this.lblTareasCompletadas);
            this.pnlHeaderTareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderTareas.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderTareas.Name = "pnlHeaderTareas";
            this.pnlHeaderTareas.Size = new System.Drawing.Size(518, 48);
            this.pnlHeaderTareas.TabIndex = 0;
            // lblTareasCompletadas
            // 
            this.lblTareasCompletadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTareasCompletadas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTareasCompletadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblTareasCompletadas.Location = new System.Drawing.Point(0, 0);
            this.lblTareasCompletadas.Name = "lblTareasCompletadas";
            this.lblTareasCompletadas.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblTareasCompletadas.Size = new System.Drawing.Size(518, 48);
            this.lblTareasCompletadas.TabIndex = 0;
            this.lblTareasCompletadas.Text = "Mis tareas completadas";
            this.lblTareasCompletadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // pnlEstadoTareas
            // 
            this.pnlEstadoTareas.BackColor = System.Drawing.Color.White;
            this.pnlEstadoTareas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEstadoTareas.Controls.Add(this.tlpEstado);
            this.pnlEstadoTareas.Controls.Add(this.pnlHeaderEstado);
            this.pnlEstadoTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstadoTareas.Location = new System.Drawing.Point(0, 280);
            this.pnlEstadoTareas.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlEstadoTareas.Name = "pnlEstadoTareas";
            this.pnlEstadoTareas.Size = new System.Drawing.Size(1092, 300);
            this.pnlEstadoTareas.TabIndex = 2;
            // tlpEstado
            // 
            this.tlpEstado.ColumnCount = 4;
            this.tlpEstado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEstado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEstado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEstado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEstado.Controls.Add(this.tlpPendiente, 0, 0);
            this.tlpEstado.Controls.Add(this.tlpProgreso, 1, 0);
            this.tlpEstado.Controls.Add(this.tlpRevision, 2, 0);
            this.tlpEstado.Controls.Add(this.tlpCompletada, 3, 0);
            this.tlpEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEstado.Location = new System.Drawing.Point(0, 48);
            this.tlpEstado.Name = "tlpEstado";
            this.tlpEstado.Padding = new System.Windows.Forms.Padding(14, 12, 14, 14);
            this.tlpEstado.RowCount = 1;
            this.tlpEstado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEstado.Size = new System.Drawing.Size(1090, 350);
            this.tlpEstado.TabIndex = 1;
            // tlpPendiente
            // 
            this.tlpPendiente.ColumnCount = 1;
            this.tlpPendiente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPendiente.Controls.Add(this.pnlBarraPendiente, 0, 0);
            this.tlpPendiente.Controls.Add(this.lblPendiente, 0, 1);
            this.tlpPendiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPendiente.Location = new System.Drawing.Point(14, 12);
            this.tlpPendiente.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPendiente.Name = "tlpPendiente";
            this.tlpPendiente.RowCount = 2;
            this.tlpPendiente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPendiente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpPendiente.Size = new System.Drawing.Size(265, 324);
            this.tlpPendiente.TabIndex = 0;
            // pnlBarraPendiente
            // 
            this.pnlBarraPendiente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlBarraPendiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.pnlBarraPendiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarraPendiente.Location = new System.Drawing.Point(72, 126);
            this.pnlBarraPendiente.Name = "pnlBarraPendiente";
            this.pnlBarraPendiente.Size = new System.Drawing.Size(120, 150);
            this.pnlBarraPendiente.TabIndex = 0;
            // lblPendiente
            // 
            this.lblPendiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPendiente.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPendiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblPendiente.Location = new System.Drawing.Point(3, 279);
            this.lblPendiente.Name = "lblPendiente";
            this.lblPendiente.Size = new System.Drawing.Size(259, 45);
            this.lblPendiente.TabIndex = 1;
            this.lblPendiente.Text = "Pendiente\r\n8";
            this.lblPendiente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // tlpProgreso
            // 
            this.tlpProgreso.ColumnCount = 1;
            this.tlpProgreso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProgreso.Controls.Add(this.pnlBarraProgreso, 0, 0);
            this.tlpProgreso.Controls.Add(this.lblProgreso, 0, 1);
            this.tlpProgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProgreso.Location = new System.Drawing.Point(279, 12);
            this.tlpProgreso.Margin = new System.Windows.Forms.Padding(0);
            this.tlpProgreso.Name = "tlpProgreso";
            this.tlpProgreso.RowCount = 2;
            this.tlpProgreso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProgreso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpProgreso.Size = new System.Drawing.Size(265, 324);
            this.tlpProgreso.TabIndex = 1;
            // pnlBarraProgreso
            // 
            this.pnlBarraProgreso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlBarraProgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.pnlBarraProgreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarraProgreso.Location = new System.Drawing.Point(72, 96);
            this.pnlBarraProgreso.Name = "pnlBarraProgreso";
            this.pnlBarraProgreso.Size = new System.Drawing.Size(120, 180);
            this.pnlBarraProgreso.TabIndex = 0;
            // lblProgreso
            // 
            this.lblProgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgreso.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblProgreso.Location = new System.Drawing.Point(3, 279);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(259, 45);
            this.lblProgreso.TabIndex = 1;
            this.lblProgreso.Text = "En progreso\r\n5";
            this.lblProgreso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // tlpRevision
            // 
            this.tlpRevision.ColumnCount = 1;
            this.tlpRevision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRevision.Controls.Add(this.pnlBarraRevision, 0, 0);
            this.tlpRevision.Controls.Add(this.lblRevision, 0, 1);
            this.tlpRevision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRevision.Location = new System.Drawing.Point(544, 12);
            this.tlpRevision.Margin = new System.Windows.Forms.Padding(0);
            this.tlpRevision.Name = "tlpRevision";
            this.tlpRevision.RowCount = 2;
            this.tlpRevision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRevision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpRevision.Size = new System.Drawing.Size(265, 324);
            this.tlpRevision.TabIndex = 2;
            // pnlBarraRevision
            // 
            this.pnlBarraRevision.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlBarraRevision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.pnlBarraRevision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarraRevision.Location = new System.Drawing.Point(72, 56);
            this.pnlBarraRevision.Name = "pnlBarraRevision";
            this.pnlBarraRevision.Size = new System.Drawing.Size(120, 220);
            this.pnlBarraRevision.TabIndex = 0;
            // lblRevision
            // 
            this.lblRevision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRevision.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRevision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblRevision.Location = new System.Drawing.Point(3, 279);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(259, 45);
            this.lblRevision.TabIndex = 1;
            this.lblRevision.Text = "En revisión\r\n3";
            this.lblRevision.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // tlpCompletada
            // 
            this.tlpCompletada.ColumnCount = 1;
            this.tlpCompletada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCompletada.Controls.Add(this.pnlBarraCompletada, 0, 0);
            this.tlpCompletada.Controls.Add(this.lblCompletada, 0, 1);
            this.tlpCompletada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCompletada.Location = new System.Drawing.Point(809, 12);
            this.tlpCompletada.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCompletada.Name = "tlpCompletada";
            this.tlpCompletada.RowCount = 2;
            this.tlpCompletada.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCompletada.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpCompletada.Size = new System.Drawing.Size(267, 324);
            this.tlpCompletada.TabIndex = 3;
            // pnlBarraCompletada
            // 
            this.pnlBarraCompletada.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlBarraCompletada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.pnlBarraCompletada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarraCompletada.Location = new System.Drawing.Point(73, 26);
            this.pnlBarraCompletada.Name = "pnlBarraCompletada";
            this.pnlBarraCompletada.Size = new System.Drawing.Size(120, 250);
            this.pnlBarraCompletada.TabIndex = 0;
            // lblCompletada
            // 
            this.lblCompletada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompletada.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCompletada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblCompletada.Location = new System.Drawing.Point(3, 279);
            this.lblCompletada.Name = "lblCompletada";
            this.lblCompletada.Size = new System.Drawing.Size(261, 45);
            this.lblCompletada.TabIndex = 1;
            this.lblCompletada.Text = "Completada\r\n12";
            this.lblCompletada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // pnlHeaderEstado
            // 
            this.pnlHeaderEstado.BackColor = System.Drawing.Color.White;
            this.pnlHeaderEstado.Controls.Add(this.lblEstadoTareas);
            this.pnlHeaderEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderEstado.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderEstado.Name = "pnlHeaderEstado";
            this.pnlHeaderEstado.Size = new System.Drawing.Size(1090, 48);
            this.pnlHeaderEstado.TabIndex = 0;
            // lblEstadoTareas
            // 
            this.lblEstadoTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstadoTareas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEstadoTareas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblEstadoTareas.Location = new System.Drawing.Point(0, 0);
            this.lblEstadoTareas.Name = "lblEstadoTareas";
            this.lblEstadoTareas.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblEstadoTareas.Size = new System.Drawing.Size(1090, 48);
            this.lblEstadoTareas.TabIndex = 0;
            this.lblEstadoTareas.Text = "Tareas por estado - este mes";
            this.lblEstadoTareas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // pnlHistorial
            // 
            this.pnlHistorial.BackColor = System.Drawing.Color.White;
            this.pnlHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHistorial.Controls.Add(this.pnlCuerpoHistorial);
            this.pnlHistorial.Controls.Add(this.pnlHeaderHistorial);
            this.pnlHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistorial.Location = new System.Drawing.Point(1102, 280);
            this.pnlHistorial.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistorial.Name = "pnlHistorial";
            this.pnlHistorial.Size = new System.Drawing.Size(520, 300);
            this.pnlHistorial.TabIndex = 3;
            // pnlCuerpoHistorial
            // 
            this.pnlCuerpoHistorial.BackColor = System.Drawing.Color.White;
            this.pnlCuerpoHistorial.Controls.Add(this.flpHistorial);
            this.pnlCuerpoHistorial.Controls.Add(this.tlpEncabezadoHistorial);
            this.pnlCuerpoHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpoHistorial.Location = new System.Drawing.Point(0, 48);
            this.pnlCuerpoHistorial.Name = "pnlCuerpoHistorial";
            this.pnlCuerpoHistorial.Padding = new System.Windows.Forms.Padding(14, 0, 14, 14);
            this.pnlCuerpoHistorial.Size = new System.Drawing.Size(518, 250);
            this.pnlCuerpoHistorial.TabIndex = 1;
            // flpHistorial
            // 
            this.flpHistorial.AutoScroll = true;
            this.flpHistorial.Controls.Add(this.avance3);
            this.flpHistorial.Controls.Add(this.avance2);
            this.flpHistorial.Controls.Add(this.avance1);
            this.flpHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHistorial.Location = new System.Drawing.Point(14, 38);
            this.flpHistorial.Name = "flpHistorial";
            this.flpHistorial.Size = new System.Drawing.Size(490, 198);
            this.flpHistorial.TabIndex = 2;
            // avance1
            // 
            this.avance1.Avance = "60%";
            this.avance1.BackColor = System.Drawing.Color.White;
            this.avance1.Fecha = "28 abr";
            this.avance1.Dock = System.Windows.Forms.DockStyle.Top;
            this.avance1.Location = new System.Drawing.Point(0, 0);
            this.avance1.Margin = new System.Windows.Forms.Padding(0);
            this.avance1.MinimumSize = new System.Drawing.Size(300, 41);
            this.avance1.Name = "avance1";
            this.avance1.Proyecto = "Proyecto 1";
            this.avance1.Size = new System.Drawing.Size(464, 41);
            this.avance1.TabIndex = 0;
            this.avance1.Tarea = "Tarea 1";
            // avance2
            // 
            this.avance2.Avance = "35%";
            this.avance2.BackColor = System.Drawing.Color.White;
            this.avance2.Fecha = "21 abr";
            this.avance2.Dock = System.Windows.Forms.DockStyle.Top;
            this.avance2.Location = new System.Drawing.Point(0, 41);
            this.avance2.Margin = new System.Windows.Forms.Padding(0);
            this.avance2.MinimumSize = new System.Drawing.Size(300, 41);
            this.avance2.Name = "avance2";
            this.avance2.Proyecto = "Proyecto 2";
            this.avance2.Size = new System.Drawing.Size(464, 41);
            this.avance2.TabIndex = 1;
            this.avance2.Tarea = "Tarea 2";
            // avance3
            // 
            this.avance3.Avance = "100%";
            this.avance3.BackColor = System.Drawing.Color.White;
            this.avance3.Fecha = "18 abr";
            this.avance3.Dock = System.Windows.Forms.DockStyle.Top;
            this.avance3.Location = new System.Drawing.Point(0, 82);
            this.avance3.Margin = new System.Windows.Forms.Padding(0);
            this.avance3.MinimumSize = new System.Drawing.Size(300, 41);
            this.avance3.Name = "avance3";
            this.avance3.Proyecto = "Proyecto 3";
            this.avance3.Size = new System.Drawing.Size(464, 41);
            this.avance3.TabIndex = 2;
            this.avance3.Tarea = "Tarea 3";
            // tlpEncabezadoHistorial
            // 
            this.tlpEncabezadoHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.tlpEncabezadoHistorial.ColumnCount = 4;
            this.tlpEncabezadoHistorial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpEncabezadoHistorial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpEncabezadoHistorial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpEncabezadoHistorial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpEncabezadoHistorial.Controls.Add(this.lblHFecha, 0, 0);
            this.tlpEncabezadoHistorial.Controls.Add(this.lblHTarea, 1, 0);
            this.tlpEncabezadoHistorial.Controls.Add(this.lblHProyecto, 2, 0);
            this.tlpEncabezadoHistorial.Controls.Add(this.lblHAvance, 3, 0);
            this.tlpEncabezadoHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpEncabezadoHistorial.Location = new System.Drawing.Point(14, 0);
            this.tlpEncabezadoHistorial.Name = "tlpEncabezadoHistorial";
            this.tlpEncabezadoHistorial.RowCount = 1;
            this.tlpEncabezadoHistorial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncabezadoHistorial.Size = new System.Drawing.Size(490, 38);
            this.tlpEncabezadoHistorial.TabIndex = 1;
            // lblHFecha
            // 
            this.lblHFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHFecha.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblHFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblHFecha.Location = new System.Drawing.Point(3, 0);
            this.lblHFecha.Name = "lblHFecha";
            this.lblHFecha.Size = new System.Drawing.Size(92, 38);
            this.lblHFecha.TabIndex = 0;
            this.lblHFecha.Text = "FECHA";
            this.lblHFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblHTarea
            // 
            this.lblHTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHTarea.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblHTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblHTarea.Location = new System.Drawing.Point(101, 0);
            this.lblHTarea.Name = "lblHTarea";
            this.lblHTarea.Size = new System.Drawing.Size(141, 38);
            this.lblHTarea.TabIndex = 1;
            this.lblHTarea.Text = "TAREA";
            this.lblHTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblHProyecto
            // 
            this.lblHProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHProyecto.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblHProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblHProyecto.Location = new System.Drawing.Point(248, 0);
            this.lblHProyecto.Name = "lblHProyecto";
            this.lblHProyecto.Size = new System.Drawing.Size(141, 38);
            this.lblHProyecto.TabIndex = 2;
            this.lblHProyecto.Text = "PROYECTO";
            this.lblHProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblHAvance
            // 
            this.lblHAvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHAvance.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblHAvance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblHAvance.Location = new System.Drawing.Point(395, 0);
            this.lblHAvance.Name = "lblHAvance";
            this.lblHAvance.Size = new System.Drawing.Size(92, 38);
            this.lblHAvance.TabIndex = 3;
            this.lblHAvance.Text = "AVANCE";
            this.lblHAvance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // pnlHeaderHistorial
            // 
            this.pnlHeaderHistorial.BackColor = System.Drawing.Color.White;
            this.pnlHeaderHistorial.Controls.Add(this.lblHistorial);
            this.pnlHeaderHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderHistorial.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderHistorial.Name = "pnlHeaderHistorial";
            this.pnlHeaderHistorial.Size = new System.Drawing.Size(518, 48);
            this.pnlHeaderHistorial.TabIndex = 0;
            // lblHistorial
            // 
            this.lblHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblHistorial.Location = new System.Drawing.Point(0, 0);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblHistorial.Size = new System.Drawing.Size(518, 48);
            this.lblHistorial.TabIndex = 0;
            this.lblHistorial.Text = "Historial de avances registrados";
            this.lblHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // frmMiProductividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.Controls.Add(this.pnlViewport);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMiProductividad";
            this.Text = "Mi productividad";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlViewport.ResumeLayout(false);
            this.pnlCanvas.ResumeLayout(false);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpCabecera.ResumeLayout(false);
            this.pnlTitulos.ResumeLayout(false);
            this.pnlTitulos.PerformLayout();
            this.tlpTarjetas.ResumeLayout(false);
            this.tlpSecciones.ResumeLayout(false);
            this.pnlAvanceProyectos.ResumeLayout(false);
            this.flpAvanceProyectos.ResumeLayout(false);
            this.pnlHeaderAvance.ResumeLayout(false);
            this.pnlTareasCompletadas.ResumeLayout(false);
            this.flpTareasCompletadas.ResumeLayout(false);
            this.pnlHeaderTareas.ResumeLayout(false);
            this.pnlEstadoTareas.ResumeLayout(false);
            this.tlpEstado.ResumeLayout(false);
            this.tlpPendiente.ResumeLayout(false);
            this.tlpProgreso.ResumeLayout(false);
            this.tlpRevision.ResumeLayout(false);
            this.tlpCompletada.ResumeLayout(false);
            this.pnlHeaderEstado.ResumeLayout(false);
            this.pnlHistorial.ResumeLayout(false);
            this.pnlCuerpoHistorial.ResumeLayout(false);
            this.flpHistorial.ResumeLayout(false);
            this.tlpEncabezadoHistorial.ResumeLayout(false);
            this.pnlHeaderHistorial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblBreadcrumbActual;
        private System.Windows.Forms.Label lblBreadcrumbBase;
        private System.Windows.Forms.Panel pnlViewport;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpCabecera;
        private System.Windows.Forms.Panel pnlTitulos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.TableLayoutPanel tlpTarjetas;
        private Vista.UCTarjetaIndicador tarjeta1;
        private Vista.UCTarjetaIndicador tarjeta2;
        private Vista.UCTarjetaIndicador tarjeta3;
        private Vista.UCTarjetaIndicador tarjeta4;
        private System.Windows.Forms.TableLayoutPanel tlpSecciones;
        private System.Windows.Forms.Panel pnlAvanceProyectos;
        private System.Windows.Forms.Panel pnlHeaderAvance;
        private System.Windows.Forms.Label lblAvanceProyectos;
        private System.Windows.Forms.Panel flpAvanceProyectos;
        private Vista.UCProductividadProyecto avanceProyecto1;
        private Vista.UCProductividadProyecto avanceProyecto2;
        private Vista.UCProductividadProyecto avanceProyecto3;
        private System.Windows.Forms.Panel pnlTareasCompletadas;
        private System.Windows.Forms.Panel pnlHeaderTareas;
        private System.Windows.Forms.Label lblTareasCompletadas;
        private System.Windows.Forms.Panel flpTareasCompletadas;
        private Vista.UCFilaTareaCompletada tareaCompletada1;
        private Vista.UCFilaTareaCompletada tareaCompletada2;
        private Vista.UCFilaTareaCompletada tareaCompletada3;
        private Vista.UCFilaTareaCompletada tareaCompletada4;
        private System.Windows.Forms.Panel pnlEstadoTareas;
        private System.Windows.Forms.Panel pnlHeaderEstado;
        private System.Windows.Forms.Label lblEstadoTareas;
        private System.Windows.Forms.TableLayoutPanel tlpEstado;
        private System.Windows.Forms.TableLayoutPanel tlpPendiente;
        private System.Windows.Forms.Panel pnlBarraPendiente;
        private System.Windows.Forms.Label lblPendiente;
        private System.Windows.Forms.TableLayoutPanel tlpProgreso;
        private System.Windows.Forms.Panel pnlBarraProgreso;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.TableLayoutPanel tlpRevision;
        private System.Windows.Forms.Panel pnlBarraRevision;
        private System.Windows.Forms.Label lblRevision;
        private System.Windows.Forms.TableLayoutPanel tlpCompletada;
        private System.Windows.Forms.Panel pnlBarraCompletada;
        private System.Windows.Forms.Label lblCompletada;
        private System.Windows.Forms.Panel pnlHistorial;
        private System.Windows.Forms.Panel pnlHeaderHistorial;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Panel pnlCuerpoHistorial;
        private System.Windows.Forms.TableLayoutPanel tlpEncabezadoHistorial;
        private System.Windows.Forms.Label lblHFecha;
        private System.Windows.Forms.Label lblHTarea;
        private System.Windows.Forms.Label lblHProyecto;
        private System.Windows.Forms.Label lblHAvance;
        private System.Windows.Forms.Panel flpHistorial;
        private Vista.UCFilaAvanceRegistrado avance1;
        private Vista.UCFilaAvanceRegistrado avance2;
        private Vista.UCFilaAvanceRegistrado avance3;
    }
}
