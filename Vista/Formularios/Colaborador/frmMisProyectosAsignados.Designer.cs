namespace Vista
{
    partial class frmMisProyectosAsignados
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
            this.lblBreadcrumbBase = new System.Windows.Forms.Label();
            this.lblBreadcrumbActual = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlViewport = new System.Windows.Forms.Panel();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboFecha = new System.Windows.Forms.ComboBox();
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.tlpEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.lblHProyecto = new System.Windows.Forms.Label();
            this.lblHResponsable = new System.Windows.Forms.Label();
            this.lblHEstado = new System.Windows.Forms.Label();
            this.lblHAvance = new System.Windows.Forms.Label();
            this.lblHTareas = new System.Windows.Forms.Label();
            this.lblHFecha = new System.Windows.Forms.Label();
            this.lblHAccion = new System.Windows.Forms.Label();
            this.flpProyectos = new System.Windows.Forms.Panel();
            this.proyecto1 = new Vista.UCFilaProyectoAsignado();
            this.proyecto2 = new Vista.UCFilaProyectoAsignado();
            this.proyecto3 = new Vista.UCFilaProyectoAsignado();
            this.pnlTop.SuspendLayout();
            this.pnlViewport.SuspendLayout();
            this.pnlCanvas.SuspendLayout();
            this.pnlTabla.SuspendLayout();
            this.tlpEncabezado.SuspendLayout();
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
            // lblBreadcrumbBase
            // 
            this.lblBreadcrumbBase.AutoSize = true;
            this.lblBreadcrumbBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBreadcrumbBase.ForeColor = System.Drawing.Color.FromArgb(145, 151, 160);
            this.lblBreadcrumbBase.Location = new System.Drawing.Point(20, 11);
            this.lblBreadcrumbBase.Name = "lblBreadcrumbBase";
            this.lblBreadcrumbBase.TabIndex = 0;
            this.lblBreadcrumbBase.Text = "Mis proyectos >";
            // 
            // lblBreadcrumbActual
            // 
            this.lblBreadcrumbActual.AutoSize = true;
            this.lblBreadcrumbActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreadcrumbActual.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblBreadcrumbActual.Location = new System.Drawing.Point(135, 11);
            this.lblBreadcrumbActual.Name = "lblBreadcrumbActual";
            this.lblBreadcrumbActual.TabIndex = 1;
            this.lblBreadcrumbActual.Text = "Proyectos asignados";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(145, 151, 160);
            this.lblFecha.Location = new System.Drawing.Point(1590, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // pnlViewport
            // 
            this.pnlViewport.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
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
            this.pnlCanvas.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlCanvas.Controls.Add(this.pnlTabla);
            this.pnlCanvas.Controls.Add(this.cboFecha);
            this.pnlCanvas.Controls.Add(this.cboEstado);
            this.pnlCanvas.Controls.Add(this.txtBuscar);
            this.pnlCanvas.Controls.Add(this.lblSubtitulo);
            this.pnlCanvas.Controls.Add(this.lblTitulo);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1645, 1025);
            this.pnlCanvas.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(24, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mis proyectos asignados";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblSubtitulo.Location = new System.Drawing.Point(27, 68);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Proyectos en los que participas actualmente";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.txtBuscar.Location = new System.Drawing.Point(24, 112);
            this.txtBuscar.MaxLength = 150;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ShortcutsEnabled = false;
            this.txtBuscar.Size = new System.Drawing.Size(360, 27);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.Text = "Buscar proyecto...";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Todos los estados",
            "Activo",
            "En progreso",
            "Completado"});
            this.cboEstado.Location = new System.Drawing.Point(398, 111);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.SelectedIndex = 0;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.filtros_SelectedIndexChanged);
            this.cboEstado.Size = new System.Drawing.Size(220, 28);
            this.cboEstado.TabIndex = 3;
            // 
            // cboFecha
            // 
            this.cboFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboFecha.FormattingEnabled = true;
            this.cboFecha.Items.AddRange(new object[] {
            "Cualquier fecha",
            "Próximos 7 días",
            "Próximos 30 días"});
            this.cboFecha.Location = new System.Drawing.Point(632, 111);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.SelectedIndex = 0;
            this.cboFecha.SelectedIndexChanged += new System.EventHandler(this.filtros_SelectedIndexChanged);
            this.cboFecha.Size = new System.Drawing.Size(220, 28);
            this.cboFecha.TabIndex = 4;
            // 
            // pnlTabla
            // 
            this.pnlTabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTabla.BackColor = System.Drawing.Color.White;
            this.pnlTabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTabla.Controls.Add(this.flpProyectos);
            this.pnlTabla.Controls.Add(this.tlpEncabezado);
            this.pnlTabla.Location = new System.Drawing.Point(24, 165);
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Size = new System.Drawing.Size(1596, 760);
            this.pnlTabla.TabIndex = 5;
            // 
            // tlpEncabezado
            // 
            this.tlpEncabezado.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.tlpEncabezado.ColumnCount = 7;
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEncabezado.Controls.Add(this.lblHProyecto, 0, 0);
            this.tlpEncabezado.Controls.Add(this.lblHResponsable, 1, 0);
            this.tlpEncabezado.Controls.Add(this.lblHEstado, 2, 0);
            this.tlpEncabezado.Controls.Add(this.lblHAvance, 3, 0);
            this.tlpEncabezado.Controls.Add(this.lblHTareas, 4, 0);
            this.tlpEncabezado.Controls.Add(this.lblHFecha, 5, 0);
            this.tlpEncabezado.Controls.Add(this.lblHAccion, 6, 0);
            this.tlpEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpEncabezado.Location = new System.Drawing.Point(0, 0);
            this.tlpEncabezado.Name = "tlpEncabezado";
            this.tlpEncabezado.RowCount = 1;
            this.tlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncabezado.Size = new System.Drawing.Size(1594, 42);
            this.tlpEncabezado.TabIndex = 0;
            // 
            // lblHProyecto
            // 
            this.lblHProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHProyecto.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblHProyecto.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblHProyecto.Margin = new System.Windows.Forms.Padding(14, 0, 3, 0);
            this.lblHProyecto.Name = "lblHProyecto";
            this.lblHProyecto.TabIndex = 0;
            this.lblHProyecto.Text = "NOMBRE DEL PROYECTO";
            this.lblHProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHResponsable
            // 
            this.lblHResponsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHResponsable.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblHResponsable.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblHResponsable.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblHResponsable.Name = "lblHResponsable";
            this.lblHResponsable.TabIndex = 1;
            this.lblHResponsable.Text = "RESPONSABLE";
            this.lblHResponsable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHEstado
            // 
            this.lblHEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHEstado.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblHEstado.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblHEstado.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblHEstado.Name = "lblHEstado";
            this.lblHEstado.TabIndex = 2;
            this.lblHEstado.Text = "ESTADO";
            this.lblHEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHAvance
            // 
            this.lblHAvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHAvance.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblHAvance.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblHAvance.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblHAvance.Name = "lblHAvance";
            this.lblHAvance.TabIndex = 3;
            this.lblHAvance.Text = "AVANCE GENERAL";
            this.lblHAvance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHTareas
            // 
            this.lblHTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHTareas.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblHTareas.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblHTareas.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblHTareas.Name = "lblHTareas";
            this.lblHTareas.TabIndex = 4;
            this.lblHTareas.Text = "MIS TAREAS";
            this.lblHTareas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHFecha
            // 
            this.lblHFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHFecha.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblHFecha.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblHFecha.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblHFecha.Name = "lblHFecha";
            this.lblHFecha.TabIndex = 5;
            this.lblHFecha.Text = "PRÓXIMA FECHA";
            this.lblHFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHAccion
            // 
            this.lblHAccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHAccion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblHAccion.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblHAccion.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblHAccion.Name = "lblHAccion";
            this.lblHAccion.TabIndex = 6;
            this.lblHAccion.Text = "ACCIÓN";
            this.lblHAccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpProyectos
            // 
            this.flpProyectos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.flpProyectos.AutoScroll = true;
            this.flpProyectos.Controls.Add(this.proyecto3);
            this.flpProyectos.Controls.Add(this.proyecto2);
            this.flpProyectos.Controls.Add(this.proyecto1);
            this.flpProyectos.Location = new System.Drawing.Point(12, 48);
            this.flpProyectos.Name = "flpProyectos";
            this.flpProyectos.Size = new System.Drawing.Size(1568, 438);
            this.flpProyectos.TabIndex = 1;
            // 
            // proyecto1
            // 
            this.proyecto1.Avance = 45;
            this.proyecto1.ColorEstado = System.Drawing.Color.FromArgb(215, 145, 0);
            this.proyecto1.Dock = System.Windows.Forms.DockStyle.Top;
            this.proyecto1.Estado = "En progreso";
            this.proyecto1.FondoEstado = System.Drawing.Color.FromArgb(255, 246, 218);
            this.proyecto1.Location = new System.Drawing.Point(0, 0);
            this.proyecto1.MisTareas = "5 tareas - 2 vencidas";
            this.proyecto1.Name = "proyecto1";
            this.proyecto1.NombreProyecto = "Proyecto 1";
            this.proyecto1.ProximaFecha = "15 may";
            this.proyecto1.Responsable = "Juan R.";
            this.proyecto1.Size = new System.Drawing.Size(1540, 51);
            this.proyecto1.TabIndex = 0;
            // 
            // proyecto2
            // 
            this.proyecto2.Avance = 45;
            this.proyecto2.ColorEstado = System.Drawing.Color.FromArgb(32, 169, 87);
            this.proyecto2.Dock = System.Windows.Forms.DockStyle.Top;
            this.proyecto2.Estado = "Activo";
            this.proyecto2.FondoEstado = System.Drawing.Color.FromArgb(223, 246, 231);
            this.proyecto2.Location = new System.Drawing.Point(0, 0);
            this.proyecto2.MisTareas = "3 tareas - 0 vencidas";
            this.proyecto2.Name = "proyecto2";
            this.proyecto2.NombreProyecto = "Proyecto 2";
            this.proyecto2.ProximaFecha = "01 may";
            this.proyecto2.Responsable = "Juan R.";
            this.proyecto2.Size = new System.Drawing.Size(1540, 51);
            this.proyecto2.TabIndex = 1;
            // 
            // proyecto3
            // 
            this.proyecto3.Avance = 70;
            this.proyecto3.ColorEstado = System.Drawing.Color.FromArgb(32, 169, 87);
            this.proyecto3.Dock = System.Windows.Forms.DockStyle.Top;
            this.proyecto3.Estado = "Activo";
            this.proyecto3.FondoEstado = System.Drawing.Color.FromArgb(223, 246, 231);
            this.proyecto3.Location = new System.Drawing.Point(0, 0);
            this.proyecto3.MisTareas = "2 tareas - 1 vencida";
            this.proyecto3.Name = "proyecto3";
            this.proyecto3.NombreProyecto = "Proyecto 3";
            this.proyecto3.ProximaFecha = "15 may";
            this.proyecto3.Responsable = "Juan R.";
            this.proyecto3.Size = new System.Drawing.Size(1540, 51);
            this.proyecto3.TabIndex = 2;
            // 
            // frmMisProyectosAsignados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.Controls.Add(this.pnlViewport);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.frmMisProyectosAsignados_Load);
            this.Name = "frmMisProyectosAsignados";
            this.Text = "Mis proyectos asignados";
            this.tlpEncabezado.ResumeLayout(false);
            this.pnlTabla.ResumeLayout(false);
            this.pnlCanvas.ResumeLayout(false);
            this.pnlCanvas.PerformLayout();
            this.pnlViewport.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblBreadcrumbBase;
        private System.Windows.Forms.Label lblBreadcrumbActual;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlViewport;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboFecha;
        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.TableLayoutPanel tlpEncabezado;
        private System.Windows.Forms.Label lblHProyecto;
        private System.Windows.Forms.Label lblHResponsable;
        private System.Windows.Forms.Label lblHEstado;
        private System.Windows.Forms.Label lblHAvance;
        private System.Windows.Forms.Label lblHTareas;
        private System.Windows.Forms.Label lblHFecha;
        private System.Windows.Forms.Label lblHAccion;
        private System.Windows.Forms.Panel flpProyectos;
        private Vista.UCFilaProyectoAsignado proyecto1;
        private Vista.UCFilaProyectoAsignado proyecto2;
        private Vista.UCFilaProyectoAsignado proyecto3;
    }
}
