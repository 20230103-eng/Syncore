namespace Vista
{
    partial class UCTarjetaTarea
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
            this.pnlColor = new System.Windows.Forms.Panel();
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.tlpContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.pnlColor, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpContenido, 1, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(278, 122);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.pnlColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColor.Location = new System.Drawing.Point(0, 0);
            this.pnlColor.Margin = new System.Windows.Forms.Padding(0);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(5, 122);
            this.pnlColor.TabIndex = 0;
            // 
            // tlpContenido
            // 
            this.tlpContenido.ColumnCount = 2;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpContenido.Controls.Add(this.lblProyecto, 0, 0);
            this.tlpContenido.Controls.Add(this.lblTarea, 0, 1);
            this.tlpContenido.Controls.Add(this.lblFecha, 0, 2);
            this.tlpContenido.Controls.Add(this.btnVer, 1, 2);
            this.tlpContenido.Controls.Add(this.lblEstado, 0, 3);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(5, 0);
            this.tlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.Padding = new System.Windows.Forms.Padding(12, 7, 7, 7);
            this.tlpContenido.RowCount = 4;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpContenido.SetColumnSpan(this.lblProyecto, 2);
            this.tlpContenido.SetColumnSpan(this.lblTarea, 2);
            this.tlpContenido.SetColumnSpan(this.lblEstado, 2);
            this.tlpContenido.Size = new System.Drawing.Size(273, 122);
            this.tlpContenido.TabIndex = 1;
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoEllipsis = true;
            this.lblProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProyecto.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProyecto.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblProyecto.Location = new System.Drawing.Point(17, 7);
            this.lblProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(249, 22);
            this.lblProyecto.TabIndex = 1;
            this.lblProyecto.Text = "Proyecto 1";
            this.lblProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTarea
            // 
            this.lblTarea.AutoEllipsis = true;
            this.lblTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTarea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTarea.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTarea.Location = new System.Drawing.Point(17, 29);
            this.lblTarea.Margin = new System.Windows.Forms.Padding(0);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(249, 34);
            this.lblTarea.TabIndex = 2;
            this.lblTarea.Text = "Nombre de la tarea";
            this.lblTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblFecha.Location = new System.Drawing.Point(17, 63);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(182, 24);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "29/08/2026";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(232, 242, 255);
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblEstado.Location = new System.Drawing.Point(17, 91);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Size = new System.Drawing.Size(249, 24);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "En progreso";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVer
            // 
            this.btnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVer.BackColor = System.Drawing.Color.White;
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(142, 160, 181);
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnVer.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.btnVer.Location = new System.Drawing.Point(208, 64);
            this.btnVer.Margin = new System.Windows.Forms.Padding(0);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(52, 26);
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            // 
            // UCTarjetaTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.MinimumSize = new System.Drawing.Size(0, 122);
            this.Name = "UCTarjetaTarea";
            this.Size = new System.Drawing.Size(280, 122);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpContenido.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnVer;
    }
}
