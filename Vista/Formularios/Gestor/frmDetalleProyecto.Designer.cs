namespace Vista
{
    partial class frmDetalleProyecto
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
            System.Windows.Forms.DataGridViewCellStyle encabezadoHitos = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle filasHitos = new System.Windows.Forms.DataGridViewCellStyle();
            encabezadoHitos.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            encabezadoHitos.BackColor = System.Drawing.Color.White;
            encabezadoHitos.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            encabezadoHitos.ForeColor = System.Drawing.Color.FromArgb(78, 91, 107);
            encabezadoHitos.SelectionBackColor = System.Drawing.Color.White;
            encabezadoHitos.SelectionForeColor = System.Drawing.Color.FromArgb(78, 91, 107);
            filasHitos.BackColor = System.Drawing.Color.White;
            filasHitos.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            filasHitos.ForeColor = System.Drawing.Color.FromArgb(62, 75, 91);
            filasHitos.SelectionBackColor = System.Drawing.Color.White;
            filasHitos.SelectionForeColor = System.Drawing.Color.FromArgb(62, 75, 91);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblBreadcrumbBase = new System.Windows.Forms.Label();
            this.lblBreadcrumbActual = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.flpAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCerrarProyecto = new System.Windows.Forms.Button();
            this.btnEquipoTrabajo = new System.Windows.Forms.Button();
            this.btnEditarProyecto = new System.Windows.Forms.Button();
            this.btnVolverListado = new System.Windows.Forms.Button();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tlpIndicadores = new System.Windows.Forms.TableLayoutPanel();
            this.pnlKpiAvance = new System.Windows.Forms.Panel();
            this.lblKpiAvanceValor = new System.Windows.Forms.Label();
            this.lblKpiAvanceTitulo = new System.Windows.Forms.Label();
            this.pnlKpiTareas = new System.Windows.Forms.Panel();
            this.lblKpiTareasValor = new System.Windows.Forms.Label();
            this.lblKpiTareasTitulo = new System.Windows.Forms.Label();
            this.pnlKpiCompletadas = new System.Windows.Forms.Panel();
            this.lblKpiCompletadasValor = new System.Windows.Forms.Label();
            this.lblKpiCompletadasTitulo = new System.Windows.Forms.Label();
            this.pnlKpiVencidas = new System.Windows.Forms.Panel();
            this.lblKpiVencidasValor = new System.Windows.Forms.Label();
            this.lblKpiVencidasTitulo = new System.Windows.Forms.Label();
            this.pnlKpiHito = new System.Windows.Forms.Panel();
            this.lblKpiHitoValor = new System.Windows.Forms.Label();
            this.lblKpiHitoTitulo = new System.Windows.Forms.Label();
            this.pnlKpiDias = new System.Windows.Forms.Panel();
            this.lblKpiDiasValor = new System.Windows.Forms.Label();
            this.lblKpiDiasTitulo = new System.Windows.Forms.Label();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDescripcion = new System.Windows.Forms.Panel();
            this.tlpDescripcion = new System.Windows.Forms.TableLayoutPanel();
            this.lblResultadoValor = new System.Windows.Forms.Label();
            this.lblResultadoTitulo = new System.Windows.Forms.Label();
            this.lblPrioridadValor = new System.Windows.Forms.Label();
            this.lblPrioridadTitulo = new System.Windows.Forms.Label();
            this.lblFechasValor = new System.Windows.Forms.Label();
            this.lblFechasTitulo = new System.Windows.Forms.Label();
            this.lblObjetivoValor = new System.Windows.Forms.Label();
            this.lblObjetivoTitulo = new System.Windows.Forms.Label();
            this.lblDescripcionTitulo = new System.Windows.Forms.Label();
            this.pnlSalud = new System.Windows.Forms.Panel();
            this.tlpSalud = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEstadoSalud = new System.Windows.Forms.Panel();
            this.lblEstadoSalud = new System.Windows.Forms.Label();
            this.pnlBarrasSalud = new System.Windows.Forms.Panel();
            this.lblRealPorcentaje = new System.Windows.Forms.Label();
            this.pnlBarraReal = new System.Windows.Forms.Panel();
            this.pnlRellenoReal = new System.Windows.Forms.Panel();
            this.lblRealTitulo = new System.Windows.Forms.Label();
            this.lblPlanPorcentaje = new System.Windows.Forms.Label();
            this.pnlBarraPlan = new System.Windows.Forms.Panel();
            this.pnlRellenoPlan = new System.Windows.Forms.Panel();
            this.lblPlanTitulo = new System.Windows.Forms.Label();
            this.lblSaludTitulo = new System.Windows.Forms.Label();
            this.pnlHitos = new System.Windows.Forms.Panel();
            this.dgvHitos = new System.Windows.Forms.DataGridView();
            this.lblHitosTitulo = new System.Windows.Forms.Label();
            this.pnlAlertas = new System.Windows.Forms.Panel();
            this.flpAlertas = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAlertasTitulo = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.tlpContenido.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.flpAcciones.SuspendLayout();
            this.tlpIndicadores.SuspendLayout();
            this.pnlKpiAvance.SuspendLayout();
            this.pnlKpiTareas.SuspendLayout();
            this.pnlKpiCompletadas.SuspendLayout();
            this.pnlKpiVencidas.SuspendLayout();
            this.pnlKpiHito.SuspendLayout();
            this.pnlKpiDias.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.pnlDescripcion.SuspendLayout();
            this.tlpDescripcion.SuspendLayout();
            this.pnlSalud.SuspendLayout();
            this.tlpSalud.SuspendLayout();
            this.pnlEstadoSalud.SuspendLayout();
            this.pnlBarrasSalud.SuspendLayout();
            this.pnlBarraReal.SuspendLayout();
            this.pnlBarraPlan.SuspendLayout();
            this.pnlHitos.SuspendLayout();
            this.pnlAlertas.SuspendLayout();
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
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(145, 151, 160);
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.Size = new System.Drawing.Size(80, 20);
            this.lblBreadcrumbBase.TabIndex = 0;
            this.lblBreadcrumbBase.Text = "Proyectos >";
            // 
            // lblBreadcrumbActual
            // 
            this.lblBreadcrumbActual.AutoSize = true;
            this.lblBreadcrumbActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreadcrumbActual.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(105, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.Size = new System.Drawing.Size(139, 20);
            this.lblBreadcrumbActual.TabIndex = 1;
            this.lblBreadcrumbActual.Text = "Detalle de proyecto";
            // 
            // pnlContenido
            // 
            this.pnlContenido.AutoScroll = true;
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlContenido.Controls.Add(this.tlpContenido);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 43);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(26, 20, 26, 26);
            this.pnlContenido.Size = new System.Drawing.Size(1670, 1037);
            this.pnlContenido.TabIndex = 1;
            // 
            // tlpContenido
            // 
            this.tlpContenido.AutoSize = true;
            this.tlpContenido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpContenido.ColumnCount = 1;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Controls.Add(this.pnlEncabezado, 0, 0);
            this.tlpContenido.Controls.Add(this.tlpIndicadores, 0, 1);
            this.tlpContenido.Controls.Add(this.pnlSeparador, 0, 2);
            this.tlpContenido.Controls.Add(this.tlpPrincipal, 0, 3);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpContenido.Location = new System.Drawing.Point(26, 20);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.RowCount = 4;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 660F));
            this.tlpContenido.Size = new System.Drawing.Size(1618, 901);
            this.tlpContenido.TabIndex = 0;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.pnlEncabezado.Controls.Add(this.flpAcciones);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1618, 105);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // flpAcciones
            // 
            this.flpAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flpAcciones.Controls.Add(this.btnCerrarProyecto);
            this.flpAcciones.Controls.Add(this.btnEquipoTrabajo);
            this.flpAcciones.Controls.Add(this.btnEditarProyecto);
            this.flpAcciones.Controls.Add(this.btnVolverListado);
            this.flpAcciones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpAcciones.Location = new System.Drawing.Point(770, 12);
            this.flpAcciones.Name = "flpAcciones";
            this.flpAcciones.Size = new System.Drawing.Size(848, 42);
            this.flpAcciones.TabIndex = 2;
            this.flpAcciones.WrapContents = false;
            // 
            // btnCerrarProyecto
            // 
            this.btnCerrarProyecto.BackColor = System.Drawing.Color.White;
            this.btnCerrarProyecto.Click += new System.EventHandler(this.btnCerrarProyecto_Click);
            this.btnCerrarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(142, 160, 181);
            this.btnCerrarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarProyecto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrarProyecto.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.btnCerrarProyecto.Location = new System.Drawing.Point(692, 3);
            this.btnCerrarProyecto.Name = "btnCerrarProyecto";
            this.btnCerrarProyecto.Size = new System.Drawing.Size(153, 34);
            this.btnCerrarProyecto.TabIndex = 3;
            this.btnCerrarProyecto.Text = "Cerrar proyecto";
            this.btnCerrarProyecto.UseVisualStyleBackColor = false;
            // 
            // btnEquipoTrabajo
            // 
            this.btnEquipoTrabajo.BackColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnEquipoTrabajo.Click += new System.EventHandler(this.btnEquipoTrabajo_Click);
            this.btnEquipoTrabajo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEquipoTrabajo.FlatAppearance.BorderSize = 0;
            this.btnEquipoTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipoTrabajo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEquipoTrabajo.ForeColor = System.Drawing.Color.White;
            this.btnEquipoTrabajo.Location = new System.Drawing.Point(515, 3);
            this.btnEquipoTrabajo.Name = "btnEquipoTrabajo";
            this.btnEquipoTrabajo.Size = new System.Drawing.Size(171, 34);
            this.btnEquipoTrabajo.TabIndex = 2;
            this.btnEquipoTrabajo.Text = "Equipo de trabajo";
            this.btnEquipoTrabajo.UseVisualStyleBackColor = false;
            // 
            // btnEditarProyecto
            // 
            this.btnEditarProyecto.BackColor = System.Drawing.Color.White;
            this.btnEditarProyecto.Click += new System.EventHandler(this.btnEditarProyecto_Click);
            this.btnEditarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnEditarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProyecto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditarProyecto.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnEditarProyecto.Location = new System.Drawing.Point(362, 3);
            this.btnEditarProyecto.Name = "btnEditarProyecto";
            this.btnEditarProyecto.Size = new System.Drawing.Size(147, 34);
            this.btnEditarProyecto.TabIndex = 1;
            this.btnEditarProyecto.Text = "Editar proyecto";
            this.btnEditarProyecto.UseVisualStyleBackColor = false;
            // 
            // btnVolverListado
            // 
            this.btnVolverListado.BackColor = System.Drawing.Color.White;
            this.btnVolverListado.Click += new System.EventHandler(this.btnVolverListado_Click);
            this.btnVolverListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverListado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(142, 160, 181);
            this.btnVolverListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverListado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolverListado.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.btnVolverListado.Location = new System.Drawing.Point(195, 3);
            this.btnVolverListado.Name = "btnVolverListado";
            this.btnVolverListado.Size = new System.Drawing.Size(161, 34);
            this.btnVolverListado.TabIndex = 0;
            this.btnVolverListado.Text = "← Volver al listado";
            this.btnVolverListado.UseVisualStyleBackColor = false;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoEllipsis = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(89, 105, 123);
            this.lblSubtitulo.Location = new System.Drawing.Point(3, 57);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(750, 27);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Proyecto: — | Responsable: —";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(0, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(750, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "\"Nombre de proyecto\"";
            // 
            // tlpIndicadores
            // 
            this.tlpIndicadores.ColumnCount = 6;
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpIndicadores.Controls.Add(this.pnlKpiAvance, 0, 0);
            this.tlpIndicadores.Controls.Add(this.pnlKpiTareas, 1, 0);
            this.tlpIndicadores.Controls.Add(this.pnlKpiCompletadas, 2, 0);
            this.tlpIndicadores.Controls.Add(this.pnlKpiVencidas, 3, 0);
            this.tlpIndicadores.Controls.Add(this.pnlKpiHito, 4, 0);
            this.tlpIndicadores.Controls.Add(this.pnlKpiDias, 5, 0);
            this.tlpIndicadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIndicadores.Location = new System.Drawing.Point(0, 105);
            this.tlpIndicadores.Margin = new System.Windows.Forms.Padding(0);
            this.tlpIndicadores.Name = "tlpIndicadores";
            this.tlpIndicadores.RowCount = 1;
            this.tlpIndicadores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIndicadores.Size = new System.Drawing.Size(1618, 112);
            this.tlpIndicadores.TabIndex = 1;
            // 
            // pnlKpiAvance
            // 
            this.pnlKpiAvance.BackColor = System.Drawing.Color.White;
            this.pnlKpiAvance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiAvance.Controls.Add(this.lblKpiAvanceValor);
            this.pnlKpiAvance.Controls.Add(this.lblKpiAvanceTitulo);
            this.pnlKpiAvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiAvance.Location = new System.Drawing.Point(3, 3);
            this.pnlKpiAvance.Name = "pnlKpiAvance";
            this.pnlKpiAvance.Size = new System.Drawing.Size(263, 106);
            this.pnlKpiAvance.TabIndex = 0;
            // 
            // lblKpiAvanceValor
            // 
            this.lblKpiAvanceValor.AutoSize = true;
            this.lblKpiAvanceValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiAvanceValor.ForeColor = System.Drawing.Color.FromArgb(235, 139, 50);
            this.lblKpiAvanceValor.Location = new System.Drawing.Point(14, 38);
            this.lblKpiAvanceValor.Name = "lblKpiAvanceValor";
            this.lblKpiAvanceValor.Size = new System.Drawing.Size(70, 46);
            this.lblKpiAvanceValor.TabIndex = 1;
            this.lblKpiAvanceValor.Text = "0%";
            // 
            // lblKpiAvanceTitulo
            // 
            this.lblKpiAvanceTitulo.AutoSize = true;
            this.lblKpiAvanceTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpiAvanceTitulo.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblKpiAvanceTitulo.Location = new System.Drawing.Point(14, 12);
            this.lblKpiAvanceTitulo.Name = "lblKpiAvanceTitulo";
            this.lblKpiAvanceTitulo.Size = new System.Drawing.Size(112, 20);
            this.lblKpiAvanceTitulo.TabIndex = 0;
            this.lblKpiAvanceTitulo.Text = "Avance general";
            // 
            // pnlKpiTareas
            // 
            this.pnlKpiTareas.BackColor = System.Drawing.Color.White;
            this.pnlKpiTareas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiTareas.Controls.Add(this.lblKpiTareasValor);
            this.pnlKpiTareas.Controls.Add(this.lblKpiTareasTitulo);
            this.pnlKpiTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiTareas.Location = new System.Drawing.Point(272, 3);
            this.pnlKpiTareas.Name = "pnlKpiTareas";
            this.pnlKpiTareas.Size = new System.Drawing.Size(263, 106);
            this.pnlKpiTareas.TabIndex = 1;
            // 
            // lblKpiTareasValor
            // 
            this.lblKpiTareasValor.AutoSize = true;
            this.lblKpiTareasValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiTareasValor.ForeColor = System.Drawing.Color.FromArgb(45, 55, 68);
            this.lblKpiTareasValor.Location = new System.Drawing.Point(14, 38);
            this.lblKpiTareasValor.Name = "lblKpiTareasValor";
            this.lblKpiTareasValor.Size = new System.Drawing.Size(39, 46);
            this.lblKpiTareasValor.TabIndex = 1;
            this.lblKpiTareasValor.Text = "0";
            // 
            // lblKpiTareasTitulo
            // 
            this.lblKpiTareasTitulo.AutoSize = true;
            this.lblKpiTareasTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpiTareasTitulo.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblKpiTareasTitulo.Location = new System.Drawing.Point(14, 12);
            this.lblKpiTareasTitulo.Name = "lblKpiTareasTitulo";
            this.lblKpiTareasTitulo.Size = new System.Drawing.Size(92, 20);
            this.lblKpiTareasTitulo.TabIndex = 0;
            this.lblKpiTareasTitulo.Text = "Tareas totales";
            // 
            // pnlKpiCompletadas
            // 
            this.pnlKpiCompletadas.BackColor = System.Drawing.Color.White;
            this.pnlKpiCompletadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiCompletadas.Controls.Add(this.lblKpiCompletadasValor);
            this.pnlKpiCompletadas.Controls.Add(this.lblKpiCompletadasTitulo);
            this.pnlKpiCompletadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiCompletadas.Location = new System.Drawing.Point(541, 3);
            this.pnlKpiCompletadas.Name = "pnlKpiCompletadas";
            this.pnlKpiCompletadas.Size = new System.Drawing.Size(263, 106);
            this.pnlKpiCompletadas.TabIndex = 2;
            // 
            // lblKpiCompletadasValor
            // 
            this.lblKpiCompletadasValor.AutoSize = true;
            this.lblKpiCompletadasValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiCompletadasValor.ForeColor = System.Drawing.Color.FromArgb(45, 173, 83);
            this.lblKpiCompletadasValor.Location = new System.Drawing.Point(14, 38);
            this.lblKpiCompletadasValor.Name = "lblKpiCompletadasValor";
            this.lblKpiCompletadasValor.Size = new System.Drawing.Size(39, 46);
            this.lblKpiCompletadasValor.TabIndex = 1;
            this.lblKpiCompletadasValor.Text = "0";
            // 
            // lblKpiCompletadasTitulo
            // 
            this.lblKpiCompletadasTitulo.AutoSize = true;
            this.lblKpiCompletadasTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpiCompletadasTitulo.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblKpiCompletadasTitulo.Location = new System.Drawing.Point(14, 12);
            this.lblKpiCompletadasTitulo.Name = "lblKpiCompletadasTitulo";
            this.lblKpiCompletadasTitulo.Size = new System.Drawing.Size(92, 20);
            this.lblKpiCompletadasTitulo.TabIndex = 0;
            this.lblKpiCompletadasTitulo.Text = "Completadas";
            // 
            // pnlKpiVencidas
            // 
            this.pnlKpiVencidas.BackColor = System.Drawing.Color.White;
            this.pnlKpiVencidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiVencidas.Controls.Add(this.lblKpiVencidasValor);
            this.pnlKpiVencidas.Controls.Add(this.lblKpiVencidasTitulo);
            this.pnlKpiVencidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiVencidas.Location = new System.Drawing.Point(810, 3);
            this.pnlKpiVencidas.Name = "pnlKpiVencidas";
            this.pnlKpiVencidas.Size = new System.Drawing.Size(263, 106);
            this.pnlKpiVencidas.TabIndex = 3;
            // 
            // lblKpiVencidasValor
            // 
            this.lblKpiVencidasValor.AutoSize = true;
            this.lblKpiVencidasValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiVencidasValor.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.lblKpiVencidasValor.Location = new System.Drawing.Point(14, 38);
            this.lblKpiVencidasValor.Name = "lblKpiVencidasValor";
            this.lblKpiVencidasValor.Size = new System.Drawing.Size(39, 46);
            this.lblKpiVencidasValor.TabIndex = 1;
            this.lblKpiVencidasValor.Text = "0";
            // 
            // lblKpiVencidasTitulo
            // 
            this.lblKpiVencidasTitulo.AutoSize = true;
            this.lblKpiVencidasTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpiVencidasTitulo.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblKpiVencidasTitulo.Location = new System.Drawing.Point(14, 12);
            this.lblKpiVencidasTitulo.Name = "lblKpiVencidasTitulo";
            this.lblKpiVencidasTitulo.Size = new System.Drawing.Size(64, 20);
            this.lblKpiVencidasTitulo.TabIndex = 0;
            this.lblKpiVencidasTitulo.Text = "Vencidas";
            // 
            // pnlKpiHito
            // 
            this.pnlKpiHito.BackColor = System.Drawing.Color.White;
            this.pnlKpiHito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiHito.Controls.Add(this.lblKpiHitoValor);
            this.pnlKpiHito.Controls.Add(this.lblKpiHitoTitulo);
            this.pnlKpiHito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiHito.Location = new System.Drawing.Point(1079, 3);
            this.pnlKpiHito.Name = "pnlKpiHito";
            this.pnlKpiHito.Size = new System.Drawing.Size(263, 106);
            this.pnlKpiHito.TabIndex = 4;
            // 
            // lblKpiHitoValor
            // 
            this.lblKpiHitoValor.AutoEllipsis = true;
            this.lblKpiHitoValor.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblKpiHitoValor.ForeColor = System.Drawing.Color.FromArgb(226, 132, 50);
            this.lblKpiHitoValor.Location = new System.Drawing.Point(14, 39);
            this.lblKpiHitoValor.Name = "lblKpiHitoValor";
            this.lblKpiHitoValor.Size = new System.Drawing.Size(225, 43);
            this.lblKpiHitoValor.TabIndex = 1;
            this.lblKpiHitoValor.Text = "—";
            // 
            // lblKpiHitoTitulo
            // 
            this.lblKpiHitoTitulo.AutoSize = true;
            this.lblKpiHitoTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpiHitoTitulo.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblKpiHitoTitulo.Location = new System.Drawing.Point(14, 12);
            this.lblKpiHitoTitulo.Name = "lblKpiHitoTitulo";
            this.lblKpiHitoTitulo.Size = new System.Drawing.Size(72, 20);
            this.lblKpiHitoTitulo.TabIndex = 0;
            this.lblKpiHitoTitulo.Text = "Próx. hito";
            // 
            // pnlKpiDias
            // 
            this.pnlKpiDias.BackColor = System.Drawing.Color.White;
            this.pnlKpiDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiDias.Controls.Add(this.lblKpiDiasValor);
            this.pnlKpiDias.Controls.Add(this.lblKpiDiasTitulo);
            this.pnlKpiDias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiDias.Location = new System.Drawing.Point(1348, 3);
            this.pnlKpiDias.Name = "pnlKpiDias";
            this.pnlKpiDias.Size = new System.Drawing.Size(267, 106);
            this.pnlKpiDias.TabIndex = 5;
            // 
            // lblKpiDiasValor
            // 
            this.lblKpiDiasValor.AutoSize = true;
            this.lblKpiDiasValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiDiasValor.ForeColor = System.Drawing.Color.FromArgb(45, 55, 68);
            this.lblKpiDiasValor.Location = new System.Drawing.Point(14, 38);
            this.lblKpiDiasValor.Name = "lblKpiDiasValor";
            this.lblKpiDiasValor.Size = new System.Drawing.Size(39, 46);
            this.lblKpiDiasValor.TabIndex = 1;
            this.lblKpiDiasValor.Text = "0";
            // 
            // lblKpiDiasTitulo
            // 
            this.lblKpiDiasTitulo.AutoSize = true;
            this.lblKpiDiasTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpiDiasTitulo.ForeColor = System.Drawing.Color.FromArgb(75, 90, 108);
            this.lblKpiDiasTitulo.Location = new System.Drawing.Point(14, 12);
            this.lblKpiDiasTitulo.Name = "lblKpiDiasTitulo";
            this.lblKpiDiasTitulo.Size = new System.Drawing.Size(97, 20);
            this.lblKpiDiasTitulo.TabIndex = 0;
            this.lblKpiDiasTitulo.Text = "Días restantes";
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(231, 242, 252);
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 217);
            this.pnlSeparador.Margin = new System.Windows.Forms.Padding(0, 8, 0, 4);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(1618, 12);
            this.pnlSeparador.TabIndex = 2;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpPrincipal.Controls.Add(this.pnlDescripcion, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnlSalud, 0, 1);
            this.tlpPrincipal.Controls.Add(this.pnlHitos, 0, 2);
            this.tlpPrincipal.Controls.Add(this.pnlAlertas, 1, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 241);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpPrincipal.SetRowSpan(this.pnlAlertas, 2);
            this.tlpPrincipal.Size = new System.Drawing.Size(1618, 610);
            this.tlpPrincipal.TabIndex = 3;
            // 
            // pnlDescripcion
            // 
            this.pnlDescripcion.BackColor = System.Drawing.Color.White;
            this.pnlDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDescripcion.Controls.Add(this.tlpDescripcion);
            this.pnlDescripcion.Controls.Add(this.lblDescripcionTitulo);
            this.pnlDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescripcion.Location = new System.Drawing.Point(3, 3);
            this.pnlDescripcion.Name = "pnlDescripcion";
            this.pnlDescripcion.Size = new System.Drawing.Size(1223, 199);
            this.pnlDescripcion.TabIndex = 0;
            // 
            // tlpDescripcion
            // 
            this.tlpDescripcion.ColumnCount = 2;
            this.tlpDescripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpDescripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDescripcion.Controls.Add(this.lblResultadoValor, 1, 3);
            this.tlpDescripcion.Controls.Add(this.lblResultadoTitulo, 0, 3);
            this.tlpDescripcion.Controls.Add(this.lblPrioridadValor, 1, 2);
            this.tlpDescripcion.Controls.Add(this.lblPrioridadTitulo, 0, 2);
            this.tlpDescripcion.Controls.Add(this.lblFechasValor, 1, 1);
            this.tlpDescripcion.Controls.Add(this.lblFechasTitulo, 0, 1);
            this.tlpDescripcion.Controls.Add(this.lblObjetivoValor, 1, 0);
            this.tlpDescripcion.Controls.Add(this.lblObjetivoTitulo, 0, 0);
            this.tlpDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDescripcion.Location = new System.Drawing.Point(0, 36);
            this.tlpDescripcion.Name = "tlpDescripcion";
            this.tlpDescripcion.Padding = new System.Windows.Forms.Padding(12, 4, 12, 8);
            this.tlpDescripcion.RowCount = 4;
            this.tlpDescripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDescripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDescripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDescripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDescripcion.Size = new System.Drawing.Size(1221, 161);
            this.tlpDescripcion.TabIndex = 1;
            // 
            // lblResultadoValor
            // 
            this.lblResultadoValor.AutoEllipsis = true;
            this.lblResultadoValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultadoValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblResultadoValor.ForeColor = System.Drawing.Color.FromArgb(67, 79, 94);
            this.lblResultadoValor.Location = new System.Drawing.Point(180, 112);
            this.lblResultadoValor.Name = "lblResultadoValor";
            this.lblResultadoValor.Size = new System.Drawing.Size(1026, 37);
            this.lblResultadoValor.TabIndex = 7;
            this.lblResultadoValor.Text = "—";
            this.lblResultadoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResultadoTitulo
            // 
            this.lblResultadoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultadoTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblResultadoTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblResultadoTitulo.Location = new System.Drawing.Point(15, 112);
            this.lblResultadoTitulo.Name = "lblResultadoTitulo";
            this.lblResultadoTitulo.Size = new System.Drawing.Size(159, 37);
            this.lblResultadoTitulo.TabIndex = 6;
            this.lblResultadoTitulo.Text = "Resultado esp.";
            this.lblResultadoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrioridadValor
            // 
            this.lblPrioridadValor.AutoSize = true;
            this.lblPrioridadValor.BackColor = System.Drawing.Color.FromArgb(255, 235, 235);
            this.lblPrioridadValor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPrioridadValor.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPrioridadValor.ForeColor = System.Drawing.Color.FromArgb(210, 52, 61);
            this.lblPrioridadValor.Location = new System.Drawing.Point(180, 75);
            this.lblPrioridadValor.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPrioridadValor.Name = "lblPrioridadValor";
            this.lblPrioridadValor.Padding = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.lblPrioridadValor.Size = new System.Drawing.Size(42, 25);
            this.lblPrioridadValor.TabIndex = 5;
            this.lblPrioridadValor.Text = "—";
            this.lblPrioridadValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrioridadTitulo
            // 
            this.lblPrioridadTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrioridadTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrioridadTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblPrioridadTitulo.Location = new System.Drawing.Point(15, 75);
            this.lblPrioridadTitulo.Name = "lblPrioridadTitulo";
            this.lblPrioridadTitulo.Size = new System.Drawing.Size(159, 37);
            this.lblPrioridadTitulo.TabIndex = 4;
            this.lblPrioridadTitulo.Text = "Prioridad:";
            this.lblPrioridadTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechasValor
            // 
            this.lblFechasValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechasValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechasValor.ForeColor = System.Drawing.Color.FromArgb(67, 79, 94);
            this.lblFechasValor.Location = new System.Drawing.Point(180, 38);
            this.lblFechasValor.Name = "lblFechasValor";
            this.lblFechasValor.Size = new System.Drawing.Size(1026, 37);
            this.lblFechasValor.TabIndex = 3;
            this.lblFechasValor.Text = "—";
            this.lblFechasValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechasTitulo
            // 
            this.lblFechasTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechasTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechasTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblFechasTitulo.Location = new System.Drawing.Point(15, 38);
            this.lblFechasTitulo.Name = "lblFechasTitulo";
            this.lblFechasTitulo.Size = new System.Drawing.Size(159, 37);
            this.lblFechasTitulo.TabIndex = 2;
            this.lblFechasTitulo.Text = "Inicio – Cierre:";
            this.lblFechasTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObjetivoValor
            // 
            this.lblObjetivoValor.AutoEllipsis = true;
            this.lblObjetivoValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObjetivoValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblObjetivoValor.ForeColor = System.Drawing.Color.FromArgb(67, 79, 94);
            this.lblObjetivoValor.Location = new System.Drawing.Point(180, 1);
            this.lblObjetivoValor.Name = "lblObjetivoValor";
            this.lblObjetivoValor.Size = new System.Drawing.Size(1026, 37);
            this.lblObjetivoValor.TabIndex = 1;
            this.lblObjetivoValor.Text = "—";
            this.lblObjetivoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObjetivoTitulo
            // 
            this.lblObjetivoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObjetivoTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblObjetivoTitulo.ForeColor = System.Drawing.Color.FromArgb(84, 99, 116);
            this.lblObjetivoTitulo.Location = new System.Drawing.Point(15, 1);
            this.lblObjetivoTitulo.Name = "lblObjetivoTitulo";
            this.lblObjetivoTitulo.Size = new System.Drawing.Size(159, 37);
            this.lblObjetivoTitulo.TabIndex = 0;
            this.lblObjetivoTitulo.Text = "Objetivo:";
            this.lblObjetivoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcionTitulo
            // 
            this.lblDescripcionTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescripcionTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescripcionTitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDescripcionTitulo.ForeColor = System.Drawing.Color.FromArgb(54, 70, 88);
            this.lblDescripcionTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblDescripcionTitulo.Name = "lblDescripcionTitulo";
            this.lblDescripcionTitulo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblDescripcionTitulo.Size = new System.Drawing.Size(1221, 36);
            this.lblDescripcionTitulo.TabIndex = 0;
            this.lblDescripcionTitulo.Text = "Descripción";
            this.lblDescripcionTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSalud
            // 
            this.pnlSalud.BackColor = System.Drawing.Color.White;
            this.pnlSalud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSalud.Controls.Add(this.tlpSalud);
            this.pnlSalud.Controls.Add(this.lblSaludTitulo);
            this.pnlSalud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalud.Location = new System.Drawing.Point(3, 208);
            this.pnlSalud.Name = "pnlSalud";
            this.pnlSalud.Size = new System.Drawing.Size(1223, 159);
            this.pnlSalud.TabIndex = 1;
            // 
            // tlpSalud
            // 
            this.tlpSalud.ColumnCount = 2;
            this.tlpSalud.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tlpSalud.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSalud.Controls.Add(this.pnlEstadoSalud, 0, 0);
            this.tlpSalud.Controls.Add(this.pnlBarrasSalud, 1, 0);
            this.tlpSalud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSalud.Location = new System.Drawing.Point(0, 36);
            this.tlpSalud.Name = "tlpSalud";
            this.tlpSalud.Padding = new System.Windows.Forms.Padding(12, 8, 12, 10);
            this.tlpSalud.RowCount = 1;
            this.tlpSalud.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSalud.Size = new System.Drawing.Size(1221, 121);
            this.tlpSalud.TabIndex = 1;
            // 
            // pnlEstadoSalud
            // 
            this.pnlEstadoSalud.BackColor = System.Drawing.Color.FromArgb(255, 232, 232);
            this.pnlEstadoSalud.Controls.Add(this.lblEstadoSalud);
            this.pnlEstadoSalud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstadoSalud.Location = new System.Drawing.Point(15, 11);
            this.pnlEstadoSalud.Margin = new System.Windows.Forms.Padding(3, 3, 14, 3);
            this.pnlEstadoSalud.Name = "pnlEstadoSalud";
            this.pnlEstadoSalud.Size = new System.Drawing.Size(118, 97);
            this.pnlEstadoSalud.TabIndex = 0;
            // 
            // lblEstadoSalud
            // 
            this.lblEstadoSalud.AutoEllipsis = true;
            this.lblEstadoSalud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstadoSalud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEstadoSalud.ForeColor = System.Drawing.Color.FromArgb(207, 48, 57);
            this.lblEstadoSalud.Location = new System.Drawing.Point(0, 0);
            this.lblEstadoSalud.Name = "lblEstadoSalud";
            this.lblEstadoSalud.Size = new System.Drawing.Size(118, 97);
            this.lblEstadoSalud.TabIndex = 0;
            this.lblEstadoSalud.Text = "Crítico";
            this.lblEstadoSalud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBarrasSalud
            // 
            this.pnlBarrasSalud.Controls.Add(this.lblRealPorcentaje);
            this.pnlBarrasSalud.Controls.Add(this.pnlBarraReal);
            this.pnlBarrasSalud.Controls.Add(this.lblRealTitulo);
            this.pnlBarrasSalud.Controls.Add(this.lblPlanPorcentaje);
            this.pnlBarrasSalud.Controls.Add(this.pnlBarraPlan);
            this.pnlBarrasSalud.Controls.Add(this.lblPlanTitulo);
            this.pnlBarrasSalud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBarrasSalud.Location = new System.Drawing.Point(150, 11);
            this.pnlBarrasSalud.Name = "pnlBarrasSalud";
            this.pnlBarrasSalud.Size = new System.Drawing.Size(1056, 97);
            this.pnlBarrasSalud.TabIndex = 1;
            // 
            // lblPlanTitulo
            // 
            this.lblPlanTitulo.AutoSize = true;
            this.lblPlanTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPlanTitulo.ForeColor = System.Drawing.Color.FromArgb(80, 94, 111);
            this.lblPlanTitulo.Location = new System.Drawing.Point(3, 6);
            this.lblPlanTitulo.Name = "lblPlanTitulo";
            this.lblPlanTitulo.Size = new System.Drawing.Size(126, 20);
            this.lblPlanTitulo.TabIndex = 0;
            this.lblPlanTitulo.Text = "Avance planificado";
            // 
            // pnlBarraPlan
            // 
            this.pnlBarraPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBarraPlan.BackColor = System.Drawing.Color.FromArgb(222, 230, 239);
            this.pnlBarraPlan.Controls.Add(this.pnlRellenoPlan);
            this.pnlBarraPlan.Location = new System.Drawing.Point(3, 29);
            this.pnlBarraPlan.Name = "pnlBarraPlan";
            this.pnlBarraPlan.Size = new System.Drawing.Size(987, 8);
            this.pnlBarraPlan.SizeChanged += new System.EventHandler(this.pnlBarrasSalud_SizeChanged);
            this.pnlBarraPlan.TabIndex = 1;
            // 
            // pnlRellenoPlan
            // 
            this.pnlRellenoPlan.BackColor = System.Drawing.Color.FromArgb(18, 89, 163);
            this.pnlRellenoPlan.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRellenoPlan.Location = new System.Drawing.Point(0, 0);
            this.pnlRellenoPlan.Name = "pnlRellenoPlan";
            this.pnlRellenoPlan.Size = new System.Drawing.Size(0, 8);
            this.pnlRellenoPlan.TabIndex = 0;
            // 
            // lblPlanPorcentaje
            // 
            this.lblPlanPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlanPorcentaje.AutoSize = true;
            this.lblPlanPorcentaje.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPlanPorcentaje.ForeColor = System.Drawing.Color.FromArgb(63, 75, 91);
            this.lblPlanPorcentaje.Location = new System.Drawing.Point(998, 17);
            this.lblPlanPorcentaje.Name = "lblPlanPorcentaje";
            this.lblPlanPorcentaje.Size = new System.Drawing.Size(29, 20);
            this.lblPlanPorcentaje.TabIndex = 2;
            this.lblPlanPorcentaje.Text = "0%";
            // 
            // lblRealTitulo
            // 
            this.lblRealTitulo.AutoSize = true;
            this.lblRealTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRealTitulo.ForeColor = System.Drawing.Color.FromArgb(80, 94, 111);
            this.lblRealTitulo.Location = new System.Drawing.Point(3, 49);
            this.lblRealTitulo.Name = "lblRealTitulo";
            this.lblRealTitulo.Size = new System.Drawing.Size(84, 20);
            this.lblRealTitulo.TabIndex = 3;
            this.lblRealTitulo.Text = "Avance real";
            // 
            // pnlBarraReal
            // 
            this.pnlBarraReal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBarraReal.BackColor = System.Drawing.Color.FromArgb(238, 224, 224);
            this.pnlBarraReal.Controls.Add(this.pnlRellenoReal);
            this.pnlBarraReal.Location = new System.Drawing.Point(3, 72);
            this.pnlBarraReal.Name = "pnlBarraReal";
            this.pnlBarraReal.Size = new System.Drawing.Size(987, 8);
            this.pnlBarraReal.SizeChanged += new System.EventHandler(this.pnlBarrasSalud_SizeChanged);
            this.pnlBarraReal.TabIndex = 4;
            // 
            // pnlRellenoReal
            // 
            this.pnlRellenoReal.BackColor = System.Drawing.Color.FromArgb(210, 52, 61);
            this.pnlRellenoReal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRellenoReal.Location = new System.Drawing.Point(0, 0);
            this.pnlRellenoReal.Name = "pnlRellenoReal";
            this.pnlRellenoReal.Size = new System.Drawing.Size(0, 8);
            this.pnlRellenoReal.TabIndex = 0;
            // 
            // lblRealPorcentaje
            // 
            this.lblRealPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRealPorcentaje.AutoSize = true;
            this.lblRealPorcentaje.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRealPorcentaje.ForeColor = System.Drawing.Color.FromArgb(63, 75, 91);
            this.lblRealPorcentaje.Location = new System.Drawing.Point(998, 60);
            this.lblRealPorcentaje.Name = "lblRealPorcentaje";
            this.lblRealPorcentaje.Size = new System.Drawing.Size(29, 20);
            this.lblRealPorcentaje.TabIndex = 5;
            this.lblRealPorcentaje.Text = "0%";
            // 
            // lblSaludTitulo
            // 
            this.lblSaludTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaludTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSaludTitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSaludTitulo.ForeColor = System.Drawing.Color.FromArgb(54, 70, 88);
            this.lblSaludTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblSaludTitulo.Name = "lblSaludTitulo";
            this.lblSaludTitulo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblSaludTitulo.Size = new System.Drawing.Size(1221, 36);
            this.lblSaludTitulo.TabIndex = 0;
            this.lblSaludTitulo.Text = "Salud del proyecto";
            this.lblSaludTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHitos
            // 
            this.pnlHitos.BackColor = System.Drawing.Color.White;
            this.pnlHitos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHitos.Controls.Add(this.dgvHitos);
            this.pnlHitos.Controls.Add(this.lblHitosTitulo);
            this.pnlHitos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHitos.Location = new System.Drawing.Point(3, 373);
            this.pnlHitos.Name = "pnlHitos";
            this.pnlHitos.Size = new System.Drawing.Size(1223, 214);
            this.pnlHitos.TabIndex = 2;
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
            this.dgvHitos.ColumnHeadersDefaultCellStyle = encabezadoHitos;
            this.dgvHitos.ColumnHeadersHeight = 34;
            this.dgvHitos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHitos.EnableHeadersVisualStyles = false;
            this.dgvHitos.GridColor = System.Drawing.Color.FromArgb(224, 230, 237);
            this.dgvHitos.Location = new System.Drawing.Point(0, 36);
            this.dgvHitos.MultiSelect = false;
            this.dgvHitos.Name = "dgvHitos";
            this.dgvHitos.ReadOnly = true;
            this.dgvHitos.RowHeadersVisible = false;
            this.dgvHitos.RowTemplate.Height = 34;
            this.dgvHitos.RowsDefaultCellStyle = filasHitos;
            this.dgvHitos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHitos.Size = new System.Drawing.Size(1221, 176);
            this.dgvHitos.TabIndex = 1;
            // 
            // lblHitosTitulo
            // 
            this.lblHitosTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHitosTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHitosTitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHitosTitulo.ForeColor = System.Drawing.Color.FromArgb(54, 70, 88);
            this.lblHitosTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblHitosTitulo.Name = "lblHitosTitulo";
            this.lblHitosTitulo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblHitosTitulo.Size = new System.Drawing.Size(1221, 36);
            this.lblHitosTitulo.TabIndex = 0;
            this.lblHitosTitulo.Text = "Hitos próximos";
            this.lblHitosTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAlertas
            // 
            this.pnlAlertas.BackColor = System.Drawing.Color.White;
            this.pnlAlertas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlertas.Controls.Add(this.flpAlertas);
            this.pnlAlertas.Controls.Add(this.lblAlertasTitulo);
            this.pnlAlertas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlertas.Location = new System.Drawing.Point(1235, 3);
            this.pnlAlertas.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.pnlAlertas.Name = "pnlAlertas";
            this.pnlAlertas.Size = new System.Drawing.Size(380, 364);
            this.pnlAlertas.TabIndex = 3;
            // 
            // flpAlertas
            // 
            this.flpAlertas.AutoScroll = true;
            this.flpAlertas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAlertas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAlertas.Location = new System.Drawing.Point(0, 36);
            this.flpAlertas.Name = "flpAlertas";
            this.flpAlertas.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.flpAlertas.Size = new System.Drawing.Size(378, 326);
            this.flpAlertas.TabIndex = 1;
            this.flpAlertas.WrapContents = false;
            // 
            // lblAlertasTitulo
            // 
            this.lblAlertasTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlertasTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAlertasTitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAlertasTitulo.ForeColor = System.Drawing.Color.FromArgb(54, 70, 88);
            this.lblAlertasTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblAlertasTitulo.Name = "lblAlertasTitulo";
            this.lblAlertasTitulo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblAlertasTitulo.Size = new System.Drawing.Size(378, 36);
            this.lblAlertasTitulo.TabIndex = 0;
            this.lblAlertasTitulo.Text = "Alertas activas";
            this.lblAlertasTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmDetalleProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.frmDetalleProyecto_Load);
            this.MinimumSize = new System.Drawing.Size(1050, 700);
            this.Name = "frmDetalleProyecto";
            this.Text = "Detalle de proyecto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHitos)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.tlpContenido.ResumeLayout(false);
            this.pnlEncabezado.ResumeLayout(false);
            this.flpAcciones.ResumeLayout(false);
            this.tlpIndicadores.ResumeLayout(false);
            this.pnlKpiAvance.ResumeLayout(false);
            this.pnlKpiAvance.PerformLayout();
            this.pnlKpiTareas.ResumeLayout(false);
            this.pnlKpiTareas.PerformLayout();
            this.pnlKpiCompletadas.ResumeLayout(false);
            this.pnlKpiCompletadas.PerformLayout();
            this.pnlKpiVencidas.ResumeLayout(false);
            this.pnlKpiVencidas.PerformLayout();
            this.pnlKpiHito.ResumeLayout(false);
            this.pnlKpiDias.ResumeLayout(false);
            this.pnlKpiDias.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.pnlDescripcion.ResumeLayout(false);
            this.tlpDescripcion.ResumeLayout(false);
            this.tlpDescripcion.PerformLayout();
            this.pnlSalud.ResumeLayout(false);
            this.tlpSalud.ResumeLayout(false);
            this.pnlEstadoSalud.ResumeLayout(false);
            this.pnlBarrasSalud.ResumeLayout(false);
            this.pnlBarrasSalud.PerformLayout();
            this.pnlBarraReal.ResumeLayout(false);
            this.pnlBarraPlan.ResumeLayout(false);
            this.pnlHitos.ResumeLayout(false);
            this.pnlAlertas.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblBreadcrumbBase;
        private System.Windows.Forms.Label lblBreadcrumbActual;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.FlowLayoutPanel flpAcciones;
        private System.Windows.Forms.Button btnVolverListado;
        private System.Windows.Forms.Button btnEditarProyecto;
        private System.Windows.Forms.Button btnEquipoTrabajo;
        private System.Windows.Forms.Button btnCerrarProyecto;
        private System.Windows.Forms.TableLayoutPanel tlpIndicadores;
        private System.Windows.Forms.Panel pnlKpiAvance;
        private System.Windows.Forms.Label lblKpiAvanceTitulo;
        private System.Windows.Forms.Label lblKpiAvanceValor;
        private System.Windows.Forms.Panel pnlKpiTareas;
        private System.Windows.Forms.Label lblKpiTareasTitulo;
        private System.Windows.Forms.Label lblKpiTareasValor;
        private System.Windows.Forms.Panel pnlKpiCompletadas;
        private System.Windows.Forms.Label lblKpiCompletadasTitulo;
        private System.Windows.Forms.Label lblKpiCompletadasValor;
        private System.Windows.Forms.Panel pnlKpiVencidas;
        private System.Windows.Forms.Label lblKpiVencidasTitulo;
        private System.Windows.Forms.Label lblKpiVencidasValor;
        private System.Windows.Forms.Panel pnlKpiHito;
        private System.Windows.Forms.Label lblKpiHitoTitulo;
        private System.Windows.Forms.Label lblKpiHitoValor;
        private System.Windows.Forms.Panel pnlKpiDias;
        private System.Windows.Forms.Label lblKpiDiasTitulo;
        private System.Windows.Forms.Label lblKpiDiasValor;
        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlDescripcion;
        private System.Windows.Forms.Label lblDescripcionTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpDescripcion;
        private System.Windows.Forms.Label lblObjetivoTitulo;
        private System.Windows.Forms.Label lblObjetivoValor;
        private System.Windows.Forms.Label lblFechasTitulo;
        private System.Windows.Forms.Label lblFechasValor;
        private System.Windows.Forms.Label lblPrioridadTitulo;
        private System.Windows.Forms.Label lblPrioridadValor;
        private System.Windows.Forms.Label lblResultadoTitulo;
        private System.Windows.Forms.Label lblResultadoValor;
        private System.Windows.Forms.Panel pnlSalud;
        private System.Windows.Forms.Label lblSaludTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpSalud;
        private System.Windows.Forms.Panel pnlEstadoSalud;
        private System.Windows.Forms.Label lblEstadoSalud;
        private System.Windows.Forms.Panel pnlBarrasSalud;
        private System.Windows.Forms.Label lblPlanTitulo;
        private System.Windows.Forms.Panel pnlBarraPlan;
        private System.Windows.Forms.Panel pnlRellenoPlan;
        private System.Windows.Forms.Label lblPlanPorcentaje;
        private System.Windows.Forms.Label lblRealTitulo;
        private System.Windows.Forms.Panel pnlBarraReal;
        private System.Windows.Forms.Panel pnlRellenoReal;
        private System.Windows.Forms.Label lblRealPorcentaje;
        private System.Windows.Forms.Panel pnlHitos;
        private System.Windows.Forms.Label lblHitosTitulo;
        private System.Windows.Forms.DataGridView dgvHitos;
        private System.Windows.Forms.Panel pnlAlertas;
        private System.Windows.Forms.Label lblAlertasTitulo;
        private System.Windows.Forms.FlowLayoutPanel flpAlertas;
    }
}
