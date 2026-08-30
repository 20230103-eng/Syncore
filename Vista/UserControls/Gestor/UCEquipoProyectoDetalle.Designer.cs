namespace Vista
{
    partial class UCEquipoProyectoDetalle
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
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.pnlFilas = new System.Windows.Forms.Panel();
            this.tlpEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.lblH0 = new System.Windows.Forms.Label();
            this.lblH1 = new System.Windows.Forms.Label();
            this.lblH2 = new System.Windows.Forms.Label();
            this.lblH3 = new System.Windows.Forms.Label();
            this.lblH4 = new System.Windows.Forms.Label();
            this.lblH5 = new System.Windows.Forms.Label();
            this.lblH6 = new System.Windows.Forms.Label();
            this.lblH7 = new System.Windows.Forms.Label();
            this.lblH8 = new System.Windows.Forms.Label();
            this.pnlCabecera.SuspendLayout();
            this.pnlTabla.SuspendLayout();
            this.tlpEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.White;
            this.pnlCabecera.Controls.Add(this.btnAgregar);
            this.pnlCabecera.Controls.Add(this.lblCantidad);
            this.pnlCabecera.Controls.Add(this.lblSubtitulo);
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1500, 90);
            this.pnlCabecera.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(1290, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(185, 36);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "+ Agregar integrante";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(95, 108, 124);
            this.lblCantidad.Location = new System.Drawing.Point(235, 49);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(90, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "0 integrante(s)";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(95, 108, 124);
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 49);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(206, 20);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Integrantes asignados al proyecto";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(18, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(202, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Equipo de trabajo";
            // 
            // pnlTabla
            // 
            this.pnlTabla.BackColor = System.Drawing.Color.White;
            this.pnlTabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTabla.Controls.Add(this.pnlFilas);
            this.pnlTabla.Controls.Add(this.tlpEncabezado);
            this.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabla.Location = new System.Drawing.Point(0, 90);
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTabla.Size = new System.Drawing.Size(1500, 500);
            this.pnlTabla.TabIndex = 1;
            // 
            // pnlFilas
            // 
            this.pnlFilas.AutoScroll = true;
            this.pnlFilas.BackColor = System.Drawing.Color.White;
            this.pnlFilas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilas.Location = new System.Drawing.Point(12, 52);
            this.pnlFilas.Name = "pnlFilas";
            this.pnlFilas.Size = new System.Drawing.Size(1474, 434);
            this.pnlFilas.TabIndex = 1;
            // 
            // tlpEncabezado
            // 
            this.tlpEncabezado.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.tlpEncabezado.ColumnCount = 9;
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.tlpEncabezado.Controls.Add(this.lblH0, 0, 0);
            this.tlpEncabezado.Controls.Add(this.lblH1, 1, 0);
            this.tlpEncabezado.Controls.Add(this.lblH2, 2, 0);
            this.tlpEncabezado.Controls.Add(this.lblH3, 3, 0);
            this.tlpEncabezado.Controls.Add(this.lblH4, 4, 0);
            this.tlpEncabezado.Controls.Add(this.lblH5, 5, 0);
            this.tlpEncabezado.Controls.Add(this.lblH6, 6, 0);
            this.tlpEncabezado.Controls.Add(this.lblH7, 7, 0);
            this.tlpEncabezado.Controls.Add(this.lblH8, 8, 0);
            this.tlpEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpEncabezado.Location = new System.Drawing.Point(12, 12);
            this.tlpEncabezado.Name = "tlpEncabezado";
            this.tlpEncabezado.RowCount = 1;
            this.tlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncabezado.Size = new System.Drawing.Size(1474, 40);
            this.tlpEncabezado.TabIndex = 0;
            // 
            // lblH0
            // 
            this.lblH0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH0.Location = new System.Drawing.Point(3, 0);
            this.lblH0.Name = "lblH0";
            this.lblH0.Size = new System.Drawing.Size(97, 40);
            this.lblH0.TabIndex = 0;
            // 
            // lblH1
            // 
            this.lblH1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblH1.ForeColor = System.Drawing.Color.FromArgb(75, 89, 105);
            this.lblH1.Location = new System.Drawing.Point(106, 0);
            this.lblH1.Name = "lblH1";
            this.lblH1.Size = new System.Drawing.Size(332, 40);
            this.lblH1.TabIndex = 1;
            this.lblH1.Text = "NOMBRE";
            this.lblH1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblH2
            // 
            this.lblH2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblH2.ForeColor = System.Drawing.Color.FromArgb(75, 89, 105);
            this.lblH2.Location = new System.Drawing.Point(444, 0);
            this.lblH2.Name = "lblH2";
            this.lblH2.Size = new System.Drawing.Size(244, 40);
            this.lblH2.TabIndex = 2;
            this.lblH2.Text = "ÁREA";
            this.lblH2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblH3
            // 
            this.lblH3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblH3.ForeColor = System.Drawing.Color.FromArgb(75, 89, 105);
            this.lblH3.Location = new System.Drawing.Point(694, 0);
            this.lblH3.Name = "lblH3";
            this.lblH3.Size = new System.Drawing.Size(288, 40);
            this.lblH3.TabIndex = 3;
            this.lblH3.Text = "ROL EN EL PROYECTO";
            this.lblH3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblH4
            // 
            this.lblH4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblH4.ForeColor = System.Drawing.Color.FromArgb(75, 89, 105);
            this.lblH4.Location = new System.Drawing.Point(988, 0);
            this.lblH4.Name = "lblH4";
            this.lblH4.Size = new System.Drawing.Size(170, 40);
            this.lblH4.TabIndex = 4;
            this.lblH4.Text = "TAREAS ASIGNADAS";
            this.lblH4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblH5
            // 
            this.lblH5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblH5.ForeColor = System.Drawing.Color.FromArgb(75, 89, 105);
            this.lblH5.Location = new System.Drawing.Point(1164, 0);
            this.lblH5.Name = "lblH5";
            this.lblH5.Size = new System.Drawing.Size(156, 40);
            this.lblH5.TabIndex = 5;
            this.lblH5.Text = "COMPLETADAS";
            this.lblH5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblH6
            // 
            this.lblH6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblH6.ForeColor = System.Drawing.Color.FromArgb(75, 89, 105);
            this.lblH6.Location = new System.Drawing.Point(1326, 0);
            this.lblH6.Name = "lblH6";
            this.lblH6.Size = new System.Drawing.Size(145, 40);
            this.lblH6.TabIndex = 6;
            this.lblH6.Text = "VENCIDAS";
            this.lblH6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblH7
            // 
            this.lblH7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblH7.ForeColor = System.Drawing.Color.FromArgb(75, 89, 105);
            this.lblH7.Name = "lblH7";
            this.lblH7.TabIndex = 7;
            this.lblH7.Text = "EDITAR";
            this.lblH7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblH8
            // 
            this.lblH8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblH8.ForeColor = System.Drawing.Color.FromArgb(75, 89, 105);
            this.lblH8.Name = "lblH8";
            this.lblH8.TabIndex = 8;
            this.lblH8.Text = "RETIRAR";
            this.lblH8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCEquipoProyectoDetalle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlTabla);
            this.Controls.Add(this.pnlCabecera);
            this.Name = "UCEquipoProyectoDetalle";
            this.Size = new System.Drawing.Size(1500, 590);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.pnlTabla.ResumeLayout(false);
            this.tlpEncabezado.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.Panel pnlFilas;
        private System.Windows.Forms.TableLayoutPanel tlpEncabezado;
        private System.Windows.Forms.Label lblH0;
        private System.Windows.Forms.Label lblH1;
        private System.Windows.Forms.Label lblH2;
        private System.Windows.Forms.Label lblH3;
        private System.Windows.Forms.Label lblH4;
        private System.Windows.Forms.Label lblH5;
        private System.Windows.Forms.Label lblH6;
        private System.Windows.Forms.Label lblH7;
        private System.Windows.Forms.Label lblH8;
    }
}
