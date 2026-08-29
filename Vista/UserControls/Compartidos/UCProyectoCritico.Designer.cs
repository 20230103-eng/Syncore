namespace Vista
{
    partial class UCProyectoCritico
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
            this.tlpDatos = new System.Windows.Forms.TableLayoutPanel();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.pnlAvanceCelda = new System.Windows.Forms.Panel();
            this.lblAvance = new System.Windows.Forms.Label();
            this.pnlProgresoFondo = new System.Windows.Forms.Panel();
            this.tlpProgreso = new System.Windows.Forms.TableLayoutPanel();
            this.pnlProgreso = new System.Windows.Forms.Panel();
            this.lblTareas = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.tlpDatos.SuspendLayout();
            this.pnlAvanceCelda.SuspendLayout();
            this.pnlProgresoFondo.SuspendLayout();
            this.tlpProgreso.SuspendLayout();
            this.SuspendLayout();
            // tlpDatos
            // 
            this.tlpDatos.ColumnCount = 6;
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpDatos.Controls.Add(this.lblProyecto, 0, 0);
            this.tlpDatos.Controls.Add(this.lblArea, 1, 0);
            this.tlpDatos.Controls.Add(this.pnlAvanceCelda, 2, 0);
            this.tlpDatos.Controls.Add(this.lblTareas, 3, 0);
            this.tlpDatos.Controls.Add(this.lblEstado, 4, 0);
            this.tlpDatos.Controls.Add(this.btnVer, 5, 0);
            this.tlpDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatos.Location = new System.Drawing.Point(0, 0);
            this.tlpDatos.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDatos.Name = "tlpDatos";
            this.tlpDatos.RowCount = 1;
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatos.Size = new System.Drawing.Size(1160, 47);
            this.tlpDatos.TabIndex = 0;
            // lblProyecto
            // 
            this.lblProyecto.AutoEllipsis = true;
            this.lblProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProyecto.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProyecto.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblProyecto.Location = new System.Drawing.Point(10, 0);
            this.lblProyecto.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(276, 47);
            this.lblProyecto.TabIndex = 0;
            this.lblProyecto.Text = "Proyecto 1";
            this.lblProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblArea
            // 
            this.lblArea.AutoEllipsis = true;
            this.lblArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblArea.Location = new System.Drawing.Point(294, 0);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(200, 47);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Social";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // pnlAvanceCelda
            // 
            this.pnlAvanceCelda.Controls.Add(this.pnlProgresoFondo);
            this.pnlAvanceCelda.Controls.Add(this.lblAvance);
            this.pnlAvanceCelda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAvanceCelda.Location = new System.Drawing.Point(502, 0);
            this.pnlAvanceCelda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnlAvanceCelda.Name = "pnlAvanceCelda";
            this.pnlAvanceCelda.Size = new System.Drawing.Size(247, 47);
            this.pnlAvanceCelda.TabIndex = 2;
            // lblAvance
            // 
            this.lblAvance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvance.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblAvance.Location = new System.Drawing.Point(0, 13);
            this.lblAvance.Name = "lblAvance";
            this.lblAvance.Size = new System.Drawing.Size(44, 20);
            this.lblAvance.TabIndex = 0;
            this.lblAvance.Text = "45%";
            this.lblAvance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // pnlProgresoFondo
            // 
            this.pnlProgresoFondo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right))));
            this.pnlProgresoFondo.BackColor = System.Drawing.Color.White;
            this.pnlProgresoFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProgresoFondo.Controls.Add(this.tlpProgreso);
            this.pnlProgresoFondo.Location = new System.Drawing.Point(50, 17);
            this.pnlProgresoFondo.Name = "pnlProgresoFondo";
            this.pnlProgresoFondo.Size = new System.Drawing.Size(190, 14);
            this.pnlProgresoFondo.TabIndex = 1;
            // tlpProgreso
            // 
            this.tlpProgreso.BackColor = System.Drawing.Color.White;
            this.tlpProgreso.ColumnCount = 2;
            this.tlpProgreso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpProgreso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpProgreso.Controls.Add(this.pnlProgreso, 0, 0);
            this.tlpProgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProgreso.Location = new System.Drawing.Point(0, 0);
            this.tlpProgreso.Margin = new System.Windows.Forms.Padding(0);
            this.tlpProgreso.Name = "tlpProgreso";
            this.tlpProgreso.RowCount = 1;
            this.tlpProgreso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProgreso.Size = new System.Drawing.Size(188, 12);
            this.tlpProgreso.TabIndex = 0;
            // pnlProgreso
            // 
            this.pnlProgreso.BackColor = System.Drawing.Color.FromArgb(52, 99, 171);
            this.pnlProgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProgreso.Location = new System.Drawing.Point(0, 0);
            this.pnlProgreso.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProgreso.Name = "pnlProgreso";
            this.pnlProgreso.Size = new System.Drawing.Size(84, 12);
            this.pnlProgreso.TabIndex = 0;
            // lblTareas
            // 
            this.lblTareas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTareas.AutoSize = true;
            this.lblTareas.BackColor = System.Drawing.Color.FromArgb(229, 37, 42);
            this.lblTareas.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTareas.ForeColor = System.Drawing.Color.White;
            this.lblTareas.Location = new System.Drawing.Point(809, 13);
            this.lblTareas.Name = "lblTareas";
            this.lblTareas.Padding = new System.Windows.Forms.Padding(7, 1, 7, 1);
            this.lblTareas.Size = new System.Drawing.Size(31, 21);
            this.lblTareas.TabIndex = 3;
            this.lblTareas.Text = "2";
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstado.AutoSize = true;
            this.lblEstado.MinimumSize = new System.Drawing.Size(86, 21);
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(255, 232, 232);
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(229, 37, 42);
            this.lblEstado.Location = new System.Drawing.Point(927, 13);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Padding = new System.Windows.Forms.Padding(6, 1, 6, 1);
            this.lblEstado.Size = new System.Drawing.Size(59, 21);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Crítico";
            // btnVer
            // 
            this.btnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.Location = new System.Drawing.Point(1072, 8);
            this.btnVer.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(72, 31);
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(180, 190, 202);
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 47);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(1160, 1);
            this.pnlSeparador.TabIndex = 1;
            // UCProyectoCritico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpDatos);
            this.Controls.Add(this.pnlSeparador);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.MaximumSize = new System.Drawing.Size(0, 48);
            this.MinimumSize = new System.Drawing.Size(600, 48);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Name = "UCProyectoCritico";
            this.Size = new System.Drawing.Size(1160, 48);
            this.tlpDatos.ResumeLayout(false);
            this.tlpDatos.PerformLayout();
            this.pnlAvanceCelda.ResumeLayout(false);
            this.pnlProgresoFondo.ResumeLayout(false);
            this.tlpProgreso.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDatos;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Panel pnlAvanceCelda;
        private System.Windows.Forms.Label lblAvance;
        private System.Windows.Forms.Panel pnlProgresoFondo;
        private System.Windows.Forms.TableLayoutPanel tlpProgreso;
        private System.Windows.Forms.Panel pnlProgreso;
        private System.Windows.Forms.Label lblTareas;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Panel pnlSeparador;
    }
}
