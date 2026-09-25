namespace Vista
{
    partial class UCFilaProyectoAsignado
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
            this.tlpDatos = new System.Windows.Forms.TableLayoutPanel();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.pnlAvanceCelda = new System.Windows.Forms.Panel();
            this.pnlAvanceFondo = new System.Windows.Forms.Panel();
            this.tlpAvance = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAvance = new System.Windows.Forms.Panel();
            this.lblAvance = new System.Windows.Forms.Label();
            this.lblTareas = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnMisTareas = new System.Windows.Forms.Button();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.tlpDatos.SuspendLayout();
            this.pnlAvanceCelda.SuspendLayout();
            this.pnlAvanceFondo.SuspendLayout();
            this.tlpAvance.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDatos
            // 
            this.tlpDatos.ColumnCount = 7;
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpDatos.Controls.Add(this.lblProyecto, 0, 0);
            this.tlpDatos.Controls.Add(this.lblResponsable, 1, 0);
            this.tlpDatos.Controls.Add(this.lblEstado, 2, 0);
            this.tlpDatos.Controls.Add(this.pnlAvanceCelda, 3, 0);
            this.tlpDatos.Controls.Add(this.lblTareas, 4, 0);
            this.tlpDatos.Controls.Add(this.lblFecha, 5, 0);
            this.tlpDatos.Controls.Add(this.btnMisTareas, 6, 0);
            this.tlpDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatos.Location = new System.Drawing.Point(0, 0);
            this.tlpDatos.Name = "tlpDatos";
            this.tlpDatos.RowCount = 1;
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatos.Size = new System.Drawing.Size(1540, 50);
            this.tlpDatos.TabIndex = 0;
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoEllipsis = true;
            this.lblProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProyecto.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProyecto.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblProyecto.Location = new System.Drawing.Point(14, 0);
            this.lblProyecto.Margin = new System.Windows.Forms.Padding(14, 0, 3, 0);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(291, 50);
            this.lblProyecto.TabIndex = 0;
            this.lblProyecto.Text = "Proyecto 1";
            this.lblProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoEllipsis = true;
            this.lblResponsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResponsable.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblResponsable.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblResponsable.Location = new System.Drawing.Point(311, 0);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(209, 50);
            this.lblResponsable.TabIndex = 1;
            this.lblResponsable.Text = "Juan P.";
            this.lblResponsable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(255, 246, 218);
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(215, 145, 0);
            this.lblEstado.Location = new System.Drawing.Point(511, 0);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(155, 49);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "En progreso";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAvanceCelda
            // 
            this.pnlAvanceCelda.Controls.Add(this.lblAvance);
            this.pnlAvanceCelda.Controls.Add(this.pnlAvanceFondo);
            this.pnlAvanceCelda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAvanceCelda.Location = new System.Drawing.Point(708, 0);
            this.pnlAvanceCelda.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAvanceCelda.Name = "pnlAvanceCelda";
            this.pnlAvanceCelda.Size = new System.Drawing.Size(308, 50);
            this.pnlAvanceCelda.TabIndex = 3;
            // 
            // pnlAvanceFondo
            // 
            this.pnlAvanceFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAvanceFondo.BackColor = System.Drawing.Color.FromArgb(225, 230, 236);
            this.pnlAvanceFondo.Controls.Add(this.pnlAvance);
            this.pnlAvanceFondo.Location = new System.Drawing.Point(8, 21);
            this.pnlAvanceFondo.Name = "pnlAvanceFondo";
            this.pnlAvanceFondo.Size = new System.Drawing.Size(235, 8);
            this.pnlAvanceFondo.TabIndex = 0;
            // 
            // tlpAvance
            // 
            this.tlpAvance.BackColor = System.Drawing.Color.FromArgb(225, 230, 236);
            this.tlpAvance.ColumnCount = 2;
            this.tlpAvance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpAvance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpAvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAvance.Location = new System.Drawing.Point(0, 0);
            this.tlpAvance.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAvance.Name = "tlpAvance";
            this.tlpAvance.RowCount = 1;
            this.tlpAvance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAvance.Size = new System.Drawing.Size(235, 8);
            this.tlpAvance.TabIndex = 0;
            // 
            // pnlAvance
            // 
            this.pnlAvance.BackColor = System.Drawing.Color.FromArgb(240, 128, 49);
            this.pnlAvance.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAvance.Location = new System.Drawing.Point(0, 0);
            this.pnlAvance.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAvance.Name = "pnlAvance";
            this.pnlAvance.Size = new System.Drawing.Size(105, 8);
            this.pnlAvance.TabIndex = 0;
            // 
            // lblAvance
            // 
            this.lblAvance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvance.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAvance.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblAvance.Location = new System.Drawing.Point(249, 15);
            this.lblAvance.Name = "lblAvance";
            this.lblAvance.Size = new System.Drawing.Size(52, 20);
            this.lblAvance.TabIndex = 1;
            this.lblAvance.Text = "45%";
            this.lblAvance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTareas
            // 
            this.lblTareas.AutoEllipsis = true;
            this.lblTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTareas.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTareas.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTareas.Location = new System.Drawing.Point(1019, 0);
            this.lblTareas.Name = "lblTareas";
            this.lblTareas.Size = new System.Drawing.Size(271, 50);
            this.lblTareas.TabIndex = 4;
            this.lblTareas.Text = "5 tareas - 2 vencidas";
            this.lblTareas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoEllipsis = true;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblFecha.Location = new System.Drawing.Point(1296, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(117, 50);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "15 may";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMisTareas
            // 
            this.btnMisTareas.BackColor = System.Drawing.Color.White;
            this.btnMisTareas.Click += new System.EventHandler(this.btnMisTareas_Click);
            this.btnMisTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMisTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMisTareas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnMisTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisTareas.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnMisTareas.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnMisTareas.Location = new System.Drawing.Point(1430, 10);
            this.btnMisTareas.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnMisTareas.Name = "btnMisTareas";
            this.btnMisTareas.Size = new System.Drawing.Size(92, 37);
            this.btnMisTareas.TabIndex = 6;
            this.btnMisTareas.Text = "Mis tareas";
            this.btnMisTareas.UseVisualStyleBackColor = false;
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(205, 214, 224);
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 50);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(1540, 1);
            this.pnlSeparador.TabIndex = 1;
            // 
            // UCFilaProyectoAsignado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpDatos);
            this.Controls.Add(this.pnlSeparador);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(0, 51);
            this.MinimumSize = new System.Drawing.Size(620, 51);
            this.Name = "UCFilaProyectoAsignado";
            this.Size = new System.Drawing.Size(1540, 51);
            this.tlpDatos.ResumeLayout(false);
            this.pnlAvanceCelda.ResumeLayout(false);
            this.pnlAvanceFondo.ResumeLayout(false);
            this.tlpAvance.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDatos;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel pnlAvanceCelda;
        private System.Windows.Forms.Panel pnlAvanceFondo;
        private System.Windows.Forms.TableLayoutPanel tlpAvance;
        private System.Windows.Forms.Panel pnlAvance;
        private System.Windows.Forms.Label lblAvance;
        private System.Windows.Forms.Label lblTareas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnMisTareas;
        private System.Windows.Forms.Panel pnlSeparador;
    }
}
