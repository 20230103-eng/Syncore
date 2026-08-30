namespace Vista
{
    partial class UCNotificacion
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.lblPunto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnIrTarea = new System.Windows.Forms.Button();
            this.btnMarcarLeida = new System.Windows.Forms.Button();
            this.lblLeida = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tlpPrincipal.Controls.Add(this.lblPunto, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblTitulo, 1, 0);
            this.tlpPrincipal.Controls.Add(this.btnMarcarLeida, 2, 0);
            this.tlpPrincipal.Controls.Add(this.lblLeida, 2, 0);
            this.tlpPrincipal.Controls.Add(this.lblDescripcion, 1, 1);
            this.tlpPrincipal.Controls.Add(this.lblFecha, 1, 2);
            this.tlpPrincipal.Controls.Add(this.btnIrTarea, 1, 3);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(14, 6, 12, 5);
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.SetColumnSpan(this.lblDescripcion, 2);
            this.tlpPrincipal.Size = new System.Drawing.Size(1558, 128);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // lblPunto
            // 
            this.lblPunto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPunto.AutoSize = true;
            this.lblPunto.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPunto.ForeColor = System.Drawing.Color.FromArgb(229, 37, 42);
            this.lblPunto.Location = new System.Drawing.Point(22, 6);
            this.lblPunto.Margin = new System.Windows.Forms.Padding(0);
            this.lblPunto.Name = "lblPunto";
            this.lblPunto.Size = new System.Drawing.Size(24, 30);
            this.lblPunto.TabIndex = 0;
            this.lblPunto.Text = "●";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(52, 6);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1337, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Nueva tarea asignada";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMarcarLeida
            // 
            this.btnMarcarLeida.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMarcarLeida.BackColor = System.Drawing.Color.White;
            this.btnMarcarLeida.Click += new System.EventHandler(this.btnMarcarLeida_Click);
            this.btnMarcarLeida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcarLeida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.btnMarcarLeida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarLeida.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnMarcarLeida.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.btnMarcarLeida.Location = new System.Drawing.Point(1415, 8);
            this.btnMarcarLeida.Margin = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.btnMarcarLeida.Name = "btnMarcarLeida";
            this.btnMarcarLeida.Size = new System.Drawing.Size(119, 27);
            this.btnMarcarLeida.TabIndex = 2;
            this.btnMarcarLeida.Text = "Marcar leída";
            this.btnMarcarLeida.UseVisualStyleBackColor = false;
            // 
            // lblLeida
            // 
            this.lblLeida.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLeida.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLeida.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblLeida.Location = new System.Drawing.Point(1448, 9);
            this.lblLeida.Margin = new System.Windows.Forms.Padding(0);
            this.lblLeida.Name = "lblLeida";
            this.lblLeida.Size = new System.Drawing.Size(86, 26);
            this.lblLeida.TabIndex = 3;
            this.lblLeida.Text = "✓ Leída";
            this.lblLeida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLeida.Visible = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoEllipsis = true;
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblDescripcion.Location = new System.Drawing.Point(52, 38);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(1482, 28);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Se asignó una nueva tarea.";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblFecha.Location = new System.Drawing.Point(52, 66);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(1337, 22);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "29/08/2026 08:00";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnIrTarea
            // 
            this.btnIrTarea.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnIrTarea.BackColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnIrTarea.Click += new System.EventHandler(this.btnIrTarea_Click);
            this.btnIrTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIrTarea.FlatAppearance.BorderSize = 0;
            this.btnIrTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrTarea.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnIrTarea.ForeColor = System.Drawing.Color.White;
            this.btnIrTarea.Location = new System.Drawing.Point(52, 94);
            this.btnIrTarea.Margin = new System.Windows.Forms.Padding(0);
            this.btnIrTarea.Name = "btnIrTarea";
            this.btnIrTarea.Size = new System.Drawing.Size(105, 27);
            this.btnIrTarea.TabIndex = 6;
            this.btnIrTarea.Text = "Ir a tarea";
            this.btnIrTarea.UseVisualStyleBackColor = false;
            // 
            // UCNotificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.MinimumSize = new System.Drawing.Size(0, 128);
            this.Name = "UCNotificacion";
            this.Size = new System.Drawing.Size(1560, 128);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lblPunto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnIrTarea;
        private System.Windows.Forms.Button btnMarcarLeida;
        private System.Windows.Forms.Label lblLeida;
    }
}
