namespace Vista
{
    partial class frmProductividad
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.tlpTarjetas = new System.Windows.Forms.TableLayoutPanel();
            this.tarjeta1 = new Vista.UCTarjetaIndicador();
            this.tarjeta2 = new Vista.UCTarjetaIndicador();
            this.tarjeta3 = new Vista.UCTarjetaIndicador();
            this.tarjeta4 = new Vista.UCTarjetaIndicador();
            this.tlpSecciones = new System.Windows.Forms.TableLayoutPanel();
            this.pnlProductividadColaborador = new System.Windows.Forms.Panel();
            this.lblProductividadColaborador = new System.Windows.Forms.Label();
            this.pnlSeparadorColaborador = new System.Windows.Forms.Panel();
            this.tlpEncabezadoColaborador = new System.Windows.Forms.TableLayoutPanel();
            this.lblHPersona = new System.Windows.Forms.Label();
            this.lblHTareas = new System.Windows.Forms.Label();
            this.lblHATiempo = new System.Windows.Forms.Label();
            this.lblHCumplimiento = new System.Windows.Forms.Label();
            this.lblHTendencia = new System.Windows.Forms.Label();
            this.flpColaboradores = new System.Windows.Forms.Panel();
            this.colaborador1 = new Vista.UCProductividadColaborador();
            this.colaborador2 = new Vista.UCProductividadColaborador();
            this.colaborador3 = new Vista.UCProductividadColaborador();
            this.colaborador4 = new Vista.UCProductividadColaborador();
            this.colaborador5 = new Vista.UCProductividadColaborador();
            this.colaborador6 = new Vista.UCProductividadColaborador();
            this.pnlProductividadProyecto = new System.Windows.Forms.Panel();
            this.lblProductividadProyecto = new System.Windows.Forms.Label();
            this.pnlSeparadorProyecto = new System.Windows.Forms.Panel();
            this.flpProductividadProyecto = new System.Windows.Forms.Panel();
            this.productividadProyecto1 = new Vista.UCProductividadProyecto();
            this.productividadProyecto2 = new Vista.UCProductividadProyecto();
            this.productividadProyecto3 = new Vista.UCProductividadProyecto();
            this.pnlTendenciaSemanal = new System.Windows.Forms.Panel();
            this.lblTendenciaSemanal = new System.Windows.Forms.Label();
            this.pnlSeparadorTendencia = new System.Windows.Forms.Panel();
            this.flpSemanas = new System.Windows.Forms.FlowLayoutPanel();
            this.barraSemana1 = new Vista.UCBarraSemana();
            this.barraSemana2 = new Vista.UCBarraSemana();
            this.barraSemana3 = new Vista.UCBarraSemana();
            this.barraSemana4 = new Vista.UCBarraSemana();
            this.pnlTop.SuspendLayout();
            this.pnlViewport.SuspendLayout();
            this.pnlCanvas.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.tlpCabecera.SuspendLayout();
            this.pnlTitulos.SuspendLayout();
            this.tlpTarjetas.SuspendLayout();
            this.tlpSecciones.SuspendLayout();
            this.pnlProductividadColaborador.SuspendLayout();
            this.tlpEncabezadoColaborador.SuspendLayout();
            this.pnlProductividadProyecto.SuspendLayout();
            this.pnlTendenciaSemanal.SuspendLayout();
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
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(105, 118, 135);
            this.lblFecha.Location = new System.Drawing.Point(1590, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // lblBreadcrumbActual
            // 
            this.lblBreadcrumbActual.AutoSize = true;
            this.lblBreadcrumbActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreadcrumbActual.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(128, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Size = new System.Drawing.Size(133, 20);
            this.lblBreadcrumbActual.TabIndex = 1;
            this.lblBreadcrumbActual.Text = "Productividad general";
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(145, 151, 160);
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.Size = new System.Drawing.Size(58, 20);
            this.lblBreadcrumbBase.TabIndex = 0;
            this.lblBreadcrumbBase.Text = "Productividad >";
            // pnlViewport
            // 
            this.pnlViewport.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlViewport.Controls.Add(this.pnlCanvas);
            this.pnlViewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewport.Location = new System.Drawing.Point(0, 43);
            this.pnlViewport.Name = "pnlViewport";
            this.pnlViewport.Size = new System.Drawing.Size(1670, 1037);
            this.pnlViewport.TabIndex = 1;
            // pnlCanvas
            // 
            this.pnlCanvas.AutoScroll = true;
            this.pnlCanvas.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
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
            this.tlpPrincipal.Controls.Add(this.pnlTendenciaSemanal, 0, 3);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(24);
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1653, 910);
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
            this.tlpCabecera.Size = new System.Drawing.Size(1605, 70);
            this.tlpCabecera.TabIndex = 0;
            // pnlTitulos
            // 
            this.pnlTitulos.Controls.Add(this.lblSubtitulo);
            this.pnlTitulos.Controls.Add(this.lblTitulo);
            this.pnlTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitulos.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulos.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitulos.Name = "pnlTitulos";
            this.pnlTitulos.Size = new System.Drawing.Size(1123, 70);
            this.pnlTitulos.TabIndex = 0;
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(321, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Productividad general";
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblSubtitulo.Location = new System.Drawing.Point(3, 44);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(244, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Desempeño operativo - últimos 30 días";
            // cboPeriodo
            // 
            this.cboPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Items.AddRange(new object[] {
            "Últimos 30 días",
            "Últimos 60 días",
            "Últimos 90 días"});
            this.cboPeriodo.Location = new System.Drawing.Point(1431, 8);
            this.cboPeriodo.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(174, 28);
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
            this.tlpTarjetas.Size = new System.Drawing.Size(1605, 132);
            this.tlpTarjetas.TabIndex = 1;
            // tarjeta1
            // 
            this.tarjeta1.ColorLinea = System.Drawing.Color.FromArgb(32, 169, 87);
            this.tarjeta1.ColorValor = System.Drawing.Color.FromArgb(32, 169, 87);
            this.tarjeta1.Detalle = "+12% vs. mes ant.";
            this.tarjeta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjeta1.Location = new System.Drawing.Point(0, 0);
            this.tarjeta1.Margin = new System.Windows.Forms.Padding(0, 0, 12, 16);
            this.tarjeta1.Name = "tarjeta1";
            this.tarjeta1.Size = new System.Drawing.Size(389, 116);
            this.tarjeta1.TabIndex = 0;
            this.tarjeta1.Titulo = "Tareas completadas";
            this.tarjeta1.Valor = "20";
            // tarjeta2
            // 
            this.tarjeta2.ColorLinea = System.Drawing.Color.FromArgb(52, 99, 171);
            this.tarjeta2.ColorValor = System.Drawing.Color.FromArgb(52, 99, 171);
            this.tarjeta2.Detalle = "+4 pp";
            this.tarjeta2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjeta2.Location = new System.Drawing.Point(401, 0);
            this.tarjeta2.Margin = new System.Windows.Forms.Padding(0, 0, 12, 16);
            this.tarjeta2.Name = "tarjeta2";
            this.tarjeta2.Size = new System.Drawing.Size(389, 116);
            this.tarjeta2.TabIndex = 1;
            this.tarjeta2.Titulo = "% a tiempo";
            this.tarjeta2.Valor = "82%";
            // tarjeta3
            // 
            this.tarjeta3.ColorLinea = System.Drawing.Color.FromArgb(229, 37, 42);
            this.tarjeta3.ColorValor = System.Drawing.Color.FromArgb(229, 37, 42);
            this.tarjeta3.Detalle = "+2 pp";
            this.tarjeta3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjeta3.Location = new System.Drawing.Point(802, 0);
            this.tarjeta3.Margin = new System.Windows.Forms.Padding(0, 0, 12, 16);
            this.tarjeta3.Name = "tarjeta3";
            this.tarjeta3.Size = new System.Drawing.Size(389, 116);
            this.tarjeta3.TabIndex = 2;
            this.tarjeta3.Titulo = "Vencidas";
            this.tarjeta3.Valor = "87%";
            // tarjeta4
            // 
            this.tarjeta4.ColorLinea = System.Drawing.Color.FromArgb(240, 128, 49);
            this.tarjeta4.ColorValor = System.Drawing.Color.FromArgb(240, 128, 49);
            this.tarjeta4.Detalle = "-0.6 d";
            this.tarjeta4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjeta4.Location = new System.Drawing.Point(1203, 0);
            this.tarjeta4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.tarjeta4.Name = "tarjeta4";
            this.tarjeta4.Size = new System.Drawing.Size(402, 116);
            this.tarjeta4.TabIndex = 3;
            this.tarjeta4.Titulo = "Días promedio cierre";
            this.tarjeta4.Valor = "3.4 d";
            // tlpSecciones
            // 
            this.tlpSecciones.ColumnCount = 2;
            this.tlpSecciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSecciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSecciones.Controls.Add(this.pnlProductividadColaborador, 0, 0);
            this.tlpSecciones.Controls.Add(this.pnlProductividadProyecto, 1, 0);
            this.tlpSecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSecciones.Location = new System.Drawing.Point(24, 226);
            this.tlpSecciones.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSecciones.Name = "tlpSecciones";
            this.tlpSecciones.RowCount = 1;
            this.tlpSecciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSecciones.Size = new System.Drawing.Size(1605, 340);
            this.tlpSecciones.TabIndex = 2;
            // pnlProductividadColaborador
            // 
            this.pnlProductividadColaborador.BackColor = System.Drawing.Color.White;
            this.pnlProductividadColaborador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProductividadColaborador.Controls.Add(this.flpColaboradores);
            this.pnlProductividadColaborador.Controls.Add(this.tlpEncabezadoColaborador);
            this.pnlProductividadColaborador.Controls.Add(this.pnlSeparadorColaborador);
            this.pnlProductividadColaborador.Controls.Add(this.lblProductividadColaborador);
            this.pnlProductividadColaborador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductividadColaborador.Location = new System.Drawing.Point(0, 0);
            this.pnlProductividadColaborador.Margin = new System.Windows.Forms.Padding(0, 0, 6, 10);
            this.pnlProductividadColaborador.Name = "pnlProductividadColaborador";
            this.pnlProductividadColaborador.Size = new System.Drawing.Size(796, 330);
            this.pnlProductividadColaborador.TabIndex = 0;
            // lblProductividadColaborador
            // 
            this.lblProductividadColaborador.AutoSize = true;
            this.lblProductividadColaborador.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProductividadColaborador.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblProductividadColaborador.Location = new System.Drawing.Point(10, 12);
            this.lblProductividadColaborador.Name = "lblProductividadColaborador";
            this.lblProductividadColaborador.Size = new System.Drawing.Size(242, 23);
            this.lblProductividadColaborador.TabIndex = 0;
            this.lblProductividadColaborador.Text = "Productividad por colaborador";
            // pnlSeparadorColaborador
            // 
            this.pnlSeparadorColaborador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeparadorColaborador.BackColor = System.Drawing.Color.FromArgb(180, 190, 202);
            this.pnlSeparadorColaborador.Location = new System.Drawing.Point(10, 43);
            this.pnlSeparadorColaborador.Name = "pnlSeparadorColaborador";
            this.pnlSeparadorColaborador.Size = new System.Drawing.Size(774, 1);
            this.pnlSeparadorColaborador.TabIndex = 1;
            // tlpEncabezadoColaborador
            // 
            this.tlpEncabezadoColaborador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEncabezadoColaborador.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.tlpEncabezadoColaborador.ColumnCount = 5;
            this.tlpEncabezadoColaborador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpEncabezadoColaborador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpEncabezadoColaborador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpEncabezadoColaborador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tlpEncabezadoColaborador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpEncabezadoColaborador.Controls.Add(this.lblHPersona, 0, 0);
            this.tlpEncabezadoColaborador.Controls.Add(this.lblHTareas, 1, 0);
            this.tlpEncabezadoColaborador.Controls.Add(this.lblHATiempo, 2, 0);
            this.tlpEncabezadoColaborador.Controls.Add(this.lblHCumplimiento, 3, 0);
            this.tlpEncabezadoColaborador.Controls.Add(this.lblHTendencia, 4, 0);
            this.tlpEncabezadoColaborador.Location = new System.Drawing.Point(8, 48);
            this.tlpEncabezadoColaborador.Name = "tlpEncabezadoColaborador";
            this.tlpEncabezadoColaborador.RowCount = 1;
            this.tlpEncabezadoColaborador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncabezadoColaborador.Size = new System.Drawing.Size(778, 38);
            this.tlpEncabezadoColaborador.TabIndex = 1;
            // lblHPersona
            // 
            this.lblHPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHPersona.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblHPersona.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblHPersona.Location = new System.Drawing.Point(8, 0);
            this.lblHPersona.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.lblHPersona.Name = "lblHPersona";
            this.lblHPersona.Size = new System.Drawing.Size(222, 38);
            this.lblHPersona.TabIndex = 0;
            this.lblHPersona.Text = "PERSONA";
            this.lblHPersona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblHTareas
            // 
            this.lblHTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHTareas.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblHTareas.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblHTareas.Location = new System.Drawing.Point(236, 0);
            this.lblHTareas.Name = "lblHTareas";
            this.lblHTareas.Size = new System.Drawing.Size(87, 38);
            this.lblHTareas.TabIndex = 1;
            this.lblHTareas.Text = "TAREAS";
            this.lblHTareas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblHATiempo
            // 
            this.lblHATiempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHATiempo.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblHATiempo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblHATiempo.Location = new System.Drawing.Point(329, 0);
            this.lblHATiempo.Name = "lblHATiempo";
            this.lblHATiempo.Size = new System.Drawing.Size(118, 38);
            this.lblHATiempo.TabIndex = 2;
            this.lblHATiempo.Text = "% A TIEMPO";
            this.lblHATiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblHCumplimiento
            // 
            this.lblHCumplimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHCumplimiento.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblHCumplimiento.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblHCumplimiento.Location = new System.Drawing.Point(453, 0);
            this.lblHCumplimiento.Name = "lblHCumplimiento";
            this.lblHCumplimiento.Size = new System.Drawing.Size(204, 38);
            this.lblHCumplimiento.TabIndex = 3;
            this.lblHCumplimiento.Text = "CUMPLIMIENTO";
            this.lblHCumplimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblHTendencia
            // 
            this.lblHTendencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHTendencia.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblHTendencia.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblHTendencia.Location = new System.Drawing.Point(663, 0);
            this.lblHTendencia.Name = "lblHTendencia";
            this.lblHTendencia.Size = new System.Drawing.Size(112, 38);
            this.lblHTendencia.TabIndex = 4;
            this.lblHTendencia.Text = "TENDENCIA";
            this.lblHTendencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // flpColaboradores
            // 
            this.flpColaboradores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.flpColaboradores.AutoScroll = true;
            this.flpColaboradores.Controls.Add(this.colaborador6);
            this.flpColaboradores.Controls.Add(this.colaborador5);
            this.flpColaboradores.Controls.Add(this.colaborador4);
            this.flpColaboradores.Controls.Add(this.colaborador3);
            this.flpColaboradores.Controls.Add(this.colaborador2);
            this.flpColaboradores.Controls.Add(this.colaborador1);
            this.flpColaboradores.Location = new System.Drawing.Point(8, 86);
            this.flpColaboradores.Name = "flpColaboradores";
            this.flpColaboradores.Size = new System.Drawing.Size(778, 226);
            this.flpColaboradores.TabIndex = 2;
            // colaborador1
            // 
            this.colaborador1.Cumplimiento = 100;
            this.colaborador1.Dock = System.Windows.Forms.DockStyle.Top;
            this.colaborador1.Location = new System.Drawing.Point(0, 0);
            this.colaborador1.Margin = new System.Windows.Forms.Padding(0);
            this.colaborador1.Name = "colaborador1";
            this.colaborador1.Nombre = "Nombre P.";
            this.colaborador1.PorcentajeATiempo = 100;
            this.colaborador1.Size = new System.Drawing.Size(758, 42);
            this.colaborador1.TabIndex = 0;
            this.colaborador1.Tareas = 10;
            this.colaborador1.Tendencia = "Alta";
            // colaborador2
            // 
            this.colaborador2.Cumplimiento = 86;
            this.colaborador2.Dock = System.Windows.Forms.DockStyle.Top;
            this.colaborador2.Location = new System.Drawing.Point(0, 42);
            this.colaborador2.Margin = new System.Windows.Forms.Padding(0);
            this.colaborador2.Name = "colaborador2";
            this.colaborador2.Nombre = "Nombre P.";
            this.colaborador2.PorcentajeATiempo = 86;
            this.colaborador2.Size = new System.Drawing.Size(758, 42);
            this.colaborador2.TabIndex = 1;
            this.colaborador2.Tareas = 10;
            this.colaborador2.Tendencia = "Alta";
            // colaborador3
            // 
            this.colaborador3.Cumplimiento = 83;
            this.colaborador3.Dock = System.Windows.Forms.DockStyle.Top;
            this.colaborador3.Location = new System.Drawing.Point(0, 84);
            this.colaborador3.Margin = new System.Windows.Forms.Padding(0);
            this.colaborador3.Name = "colaborador3";
            this.colaborador3.Nombre = "Nombre P.";
            this.colaborador3.PorcentajeATiempo = 83;
            this.colaborador3.Size = new System.Drawing.Size(758, 42);
            this.colaborador3.TabIndex = 2;
            this.colaborador3.Tareas = 10;
            this.colaborador3.Tendencia = "Estable";
            // colaborador4
            // 
            this.colaborador4.Cumplimiento = 77;
            this.colaborador4.Dock = System.Windows.Forms.DockStyle.Top;
            this.colaborador4.Location = new System.Drawing.Point(0, 126);
            this.colaborador4.Margin = new System.Windows.Forms.Padding(0);
            this.colaborador4.Name = "colaborador4";
            this.colaborador4.Nombre = "Nombre P.";
            this.colaborador4.PorcentajeATiempo = 77;
            this.colaborador4.Size = new System.Drawing.Size(758, 42);
            this.colaborador4.TabIndex = 3;
            this.colaborador4.Tareas = 10;
            this.colaborador4.Tendencia = "Estable";
            // colaborador5
            // 
            this.colaborador5.Cumplimiento = 68;
            this.colaborador5.Dock = System.Windows.Forms.DockStyle.Top;
            this.colaborador5.Location = new System.Drawing.Point(0, 168);
            this.colaborador5.Margin = new System.Windows.Forms.Padding(0);
            this.colaborador5.Name = "colaborador5";
            this.colaborador5.Nombre = "Nombre P.";
            this.colaborador5.PorcentajeATiempo = 68;
            this.colaborador5.Size = new System.Drawing.Size(758, 42);
            this.colaborador5.TabIndex = 4;
            this.colaborador5.Tareas = 10;
            this.colaborador5.Tendencia = "Baja";
            // colaborador6
            // 
            this.colaborador6.Cumplimiento = 89;
            this.colaborador6.Dock = System.Windows.Forms.DockStyle.Top;
            this.colaborador6.Location = new System.Drawing.Point(0, 210);
            this.colaborador6.Margin = new System.Windows.Forms.Padding(0);
            this.colaborador6.Name = "colaborador6";
            this.colaborador6.Nombre = "Nombre P.";
            this.colaborador6.PorcentajeATiempo = 89;
            this.colaborador6.Size = new System.Drawing.Size(758, 42);
            this.colaborador6.TabIndex = 5;
            this.colaborador6.Tareas = 10;
            this.colaborador6.Tendencia = "Alta";
            // pnlProductividadProyecto
            // 
            this.pnlProductividadProyecto.BackColor = System.Drawing.Color.White;
            this.pnlProductividadProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProductividadProyecto.Controls.Add(this.flpProductividadProyecto);
            this.pnlProductividadProyecto.Controls.Add(this.pnlSeparadorProyecto);
            this.pnlProductividadProyecto.Controls.Add(this.lblProductividadProyecto);
            this.pnlProductividadProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductividadProyecto.Location = new System.Drawing.Point(808, 0);
            this.pnlProductividadProyecto.Margin = new System.Windows.Forms.Padding(6, 0, 0, 10);
            this.pnlProductividadProyecto.Name = "pnlProductividadProyecto";
            this.pnlProductividadProyecto.Size = new System.Drawing.Size(797, 330);
            this.pnlProductividadProyecto.TabIndex = 1;
            // lblProductividadProyecto
            // 
            this.lblProductividadProyecto.AutoSize = true;
            this.lblProductividadProyecto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProductividadProyecto.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblProductividadProyecto.Location = new System.Drawing.Point(10, 12);
            this.lblProductividadProyecto.Name = "lblProductividadProyecto";
            this.lblProductividadProyecto.Size = new System.Drawing.Size(217, 23);
            this.lblProductividadProyecto.TabIndex = 0;
            this.lblProductividadProyecto.Text = "Productividad por proyecto";
            // pnlSeparadorProyecto
            // 
            this.pnlSeparadorProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeparadorProyecto.BackColor = System.Drawing.Color.FromArgb(180, 190, 202);
            this.pnlSeparadorProyecto.Location = new System.Drawing.Point(10, 43);
            this.pnlSeparadorProyecto.Name = "pnlSeparadorProyecto";
            this.pnlSeparadorProyecto.Size = new System.Drawing.Size(775, 1);
            this.pnlSeparadorProyecto.TabIndex = 1;
            // flpProductividadProyecto
            // 
            this.flpProductividadProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.flpProductividadProyecto.AutoScroll = true;
            this.flpProductividadProyecto.Controls.Add(this.productividadProyecto3);
            this.flpProductividadProyecto.Controls.Add(this.productividadProyecto2);
            this.flpProductividadProyecto.Controls.Add(this.productividadProyecto1);
            this.flpProductividadProyecto.Location = new System.Drawing.Point(8, 48);
            this.flpProductividadProyecto.Name = "flpProductividadProyecto";
            this.flpProductividadProyecto.Size = new System.Drawing.Size(779, 264);
            this.flpProductividadProyecto.TabIndex = 1;
            // productividadProyecto1
            // 
            this.productividadProyecto1.Avance = 88;
            this.productividadProyecto1.Dock = System.Windows.Forms.DockStyle.Top;
            this.productividadProyecto1.Location = new System.Drawing.Point(0, 0);
            this.productividadProyecto1.Margin = new System.Windows.Forms.Padding(0);
            this.productividadProyecto1.Name = "productividadProyecto1";
            this.productividadProyecto1.NombreProyecto = "Proyecto 1";
            this.productividadProyecto1.Size = new System.Drawing.Size(759, 48);
            this.productividadProyecto1.TabIndex = 0;
            this.productividadProyecto1.Tareas = 42;
            // productividadProyecto2
            // 
            this.productividadProyecto2.Avance = 79;
            this.productividadProyecto2.Dock = System.Windows.Forms.DockStyle.Top;
            this.productividadProyecto2.Location = new System.Drawing.Point(0, 48);
            this.productividadProyecto2.Margin = new System.Windows.Forms.Padding(0);
            this.productividadProyecto2.Name = "productividadProyecto2";
            this.productividadProyecto2.NombreProyecto = "Proyecto 2";
            this.productividadProyecto2.Size = new System.Drawing.Size(759, 48);
            this.productividadProyecto2.TabIndex = 1;
            this.productividadProyecto2.Tareas = 38;
            // productividadProyecto3
            // 
            this.productividadProyecto3.Avance = 92;
            this.productividadProyecto3.Dock = System.Windows.Forms.DockStyle.Top;
            this.productividadProyecto3.Location = new System.Drawing.Point(0, 96);
            this.productividadProyecto3.Margin = new System.Windows.Forms.Padding(0);
            this.productividadProyecto3.Name = "productividadProyecto3";
            this.productividadProyecto3.NombreProyecto = "Proyecto 3";
            this.productividadProyecto3.Size = new System.Drawing.Size(759, 48);
            this.productividadProyecto3.TabIndex = 2;
            this.productividadProyecto3.Tareas = 29;
            // pnlTendenciaSemanal
            // 
            this.pnlTendenciaSemanal.BackColor = System.Drawing.Color.White;
            this.pnlTendenciaSemanal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTendenciaSemanal.Controls.Add(this.flpSemanas);
            this.pnlTendenciaSemanal.Controls.Add(this.pnlSeparadorTendencia);
            this.pnlTendenciaSemanal.Controls.Add(this.lblTendenciaSemanal);
            this.pnlTendenciaSemanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTendenciaSemanal.Location = new System.Drawing.Point(24, 566);
            this.pnlTendenciaSemanal.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTendenciaSemanal.Name = "pnlTendenciaSemanal";
            this.pnlTendenciaSemanal.Size = new System.Drawing.Size(1605, 320);
            this.pnlTendenciaSemanal.TabIndex = 3;
            // lblTendenciaSemanal
            // 
            this.lblTendenciaSemanal.AutoSize = true;
            this.lblTendenciaSemanal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTendenciaSemanal.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTendenciaSemanal.Location = new System.Drawing.Point(12, 12);
            this.lblTendenciaSemanal.Name = "lblTendenciaSemanal";
            this.lblTendenciaSemanal.Size = new System.Drawing.Size(324, 23);
            this.lblTendenciaSemanal.TabIndex = 0;
            this.lblTendenciaSemanal.Text = "Tendencia semanal - Tareas completadas";
            // pnlSeparadorTendencia
            // 
            this.pnlSeparadorTendencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeparadorTendencia.BackColor = System.Drawing.Color.FromArgb(180, 190, 202);
            this.pnlSeparadorTendencia.Location = new System.Drawing.Point(12, 43);
            this.pnlSeparadorTendencia.Name = "pnlSeparadorTendencia";
            this.pnlSeparadorTendencia.Size = new System.Drawing.Size(1579, 1);
            this.pnlSeparadorTendencia.TabIndex = 1;
            // flpSemanas
            // 
            this.flpSemanas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.flpSemanas.AutoScroll = true;
            this.flpSemanas.Controls.Add(this.barraSemana1);
            this.flpSemanas.Controls.Add(this.barraSemana2);
            this.flpSemanas.Controls.Add(this.barraSemana3);
            this.flpSemanas.Controls.Add(this.barraSemana4);
            this.flpSemanas.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpSemanas.Location = new System.Drawing.Point(12, 48);
            this.flpSemanas.Name = "flpSemanas";
            this.flpSemanas.Size = new System.Drawing.Size(1579, 258);
            this.flpSemanas.TabIndex = 1;
            this.flpSemanas.WrapContents = false;
            // barraSemana1
            // 
            this.barraSemana1.Location = new System.Drawing.Point(0, 0);
            this.barraSemana1.Margin = new System.Windows.Forms.Padding(0, 0, 46, 0);
            this.barraSemana1.Name = "barraSemana1";
            this.barraSemana1.Semana = "S1";
            this.barraSemana1.Size = new System.Drawing.Size(340, 220);
            this.barraSemana1.TabIndex = 0;
            this.barraSemana1.Valor = 28;
            this.barraSemana1.ValorMaximo = 50;
            // barraSemana2
            // 
            this.barraSemana2.Location = new System.Drawing.Point(386, 0);
            this.barraSemana2.Margin = new System.Windows.Forms.Padding(0, 0, 46, 0);
            this.barraSemana2.Name = "barraSemana2";
            this.barraSemana2.Semana = "S2";
            this.barraSemana2.Size = new System.Drawing.Size(340, 220);
            this.barraSemana2.TabIndex = 1;
            this.barraSemana2.Valor = 34;
            this.barraSemana2.ValorMaximo = 50;
            // barraSemana3
            // 
            this.barraSemana3.Location = new System.Drawing.Point(772, 0);
            this.barraSemana3.Margin = new System.Windows.Forms.Padding(0, 0, 46, 0);
            this.barraSemana3.Name = "barraSemana3";
            this.barraSemana3.Semana = "S3";
            this.barraSemana3.Size = new System.Drawing.Size(340, 220);
            this.barraSemana3.TabIndex = 2;
            this.barraSemana3.Valor = 42;
            this.barraSemana3.ValorMaximo = 50;
            // barraSemana4
            // 
            this.barraSemana4.Location = new System.Drawing.Point(1158, 0);
            this.barraSemana4.Margin = new System.Windows.Forms.Padding(0);
            this.barraSemana4.Name = "barraSemana4";
            this.barraSemana4.Semana = "S4";
            this.barraSemana4.Size = new System.Drawing.Size(340, 220);
            this.barraSemana4.TabIndex = 3;
            this.barraSemana4.Valor = 38;
            this.barraSemana4.ValorMaximo = 50;
            // frmProductividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.Controls.Add(this.pnlViewport);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productividad general";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlViewport.ResumeLayout(false);
            this.pnlCanvas.ResumeLayout(false);
            this.pnlCanvas.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpCabecera.ResumeLayout(false);
            this.pnlTitulos.ResumeLayout(false);
            this.pnlTitulos.PerformLayout();
            this.tlpTarjetas.ResumeLayout(false);
            this.tlpSecciones.ResumeLayout(false);
            this.pnlProductividadColaborador.ResumeLayout(false);
            this.pnlProductividadColaborador.PerformLayout();
            this.tlpEncabezadoColaborador.ResumeLayout(false);
            this.pnlProductividadProyecto.ResumeLayout(false);
            this.pnlProductividadProyecto.PerformLayout();
            this.pnlTendenciaSemanal.ResumeLayout(false);
            this.pnlTendenciaSemanal.PerformLayout();
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
        private System.Windows.Forms.Panel pnlProductividadColaborador;
        private System.Windows.Forms.Label lblProductividadColaborador;
        private System.Windows.Forms.Panel pnlSeparadorColaborador;
        private System.Windows.Forms.TableLayoutPanel tlpEncabezadoColaborador;
        private System.Windows.Forms.Label lblHPersona;
        private System.Windows.Forms.Label lblHTareas;
        private System.Windows.Forms.Label lblHATiempo;
        private System.Windows.Forms.Label lblHCumplimiento;
        private System.Windows.Forms.Label lblHTendencia;
        private System.Windows.Forms.Panel flpColaboradores;
        private Vista.UCProductividadColaborador colaborador1;
        private Vista.UCProductividadColaborador colaborador2;
        private Vista.UCProductividadColaborador colaborador3;
        private Vista.UCProductividadColaborador colaborador4;
        private Vista.UCProductividadColaborador colaborador5;
        private Vista.UCProductividadColaborador colaborador6;
        private System.Windows.Forms.Panel pnlProductividadProyecto;
        private System.Windows.Forms.Label lblProductividadProyecto;
        private System.Windows.Forms.Panel pnlSeparadorProyecto;
        private System.Windows.Forms.Panel flpProductividadProyecto;
        private Vista.UCProductividadProyecto productividadProyecto1;
        private Vista.UCProductividadProyecto productividadProyecto2;
        private Vista.UCProductividadProyecto productividadProyecto3;
        private System.Windows.Forms.Panel pnlTendenciaSemanal;
        private System.Windows.Forms.Label lblTendenciaSemanal;
        private System.Windows.Forms.Panel pnlSeparadorTendencia;
        private System.Windows.Forms.FlowLayoutPanel flpSemanas;
        private Vista.UCBarraSemana barraSemana1;
        private Vista.UCBarraSemana barraSemana2;
        private Vista.UCBarraSemana barraSemana3;
        private Vista.UCBarraSemana barraSemana4;
    }
}
