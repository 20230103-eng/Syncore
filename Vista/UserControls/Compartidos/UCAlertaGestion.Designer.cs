namespace Vista
{
    partial class UCAlertaGestion
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.lblPunto = new System.Windows.Forms.Label();
            this.pnlTexto = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.pnlAccion = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.pnlTexto.SuspendLayout();
            this.pnlAccion.SuspendLayout();
            this.SuspendLayout();
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPrincipal.Controls.Add(this.lblPunto, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnlTexto, 1, 0);
            this.tlpPrincipal.Controls.Add(this.pnlAccion, 2, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(322, 92);
            this.tlpPrincipal.TabIndex = 0;
            // lblPunto
            // 
            this.lblPunto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPunto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblPunto.ForeColor = System.Drawing.Color.FromArgb(229, 37, 42);
            this.lblPunto.Location = new System.Drawing.Point(0, 0);
            this.lblPunto.Margin = new System.Windows.Forms.Padding(0);
            this.lblPunto.Name = "lblPunto";
            this.lblPunto.Size = new System.Drawing.Size(24, 34);
            this.lblPunto.TabIndex = 0;
            this.lblPunto.Text = "•";
            this.lblPunto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // pnlTexto
            // 
            this.pnlTexto.Controls.Add(this.lblDetalle);
            this.pnlTexto.Controls.Add(this.lblTitulo);
            this.pnlTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTexto.Location = new System.Drawing.Point(24, 0);
            this.pnlTexto.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTexto.Name = "pnlTexto";
            this.pnlTexto.Size = new System.Drawing.Size(198, 92);
            this.pnlTexto.TabIndex = 1;
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(198, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Proyecto atrasado";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblDetalle
            // 
            this.lblDetalle.AutoEllipsis = true;
            this.lblDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblDetalle.Location = new System.Drawing.Point(0, 24);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(198, 68);
            this.lblDetalle.TabIndex = 1;
            this.lblDetalle.Text = "PCN: 4 tareas vencidas sin actualizar";
            // pnlAccion
            // 
            this.pnlAccion.Controls.Add(this.btnAccion);
            this.pnlAccion.Controls.Add(this.lblFecha);
            this.pnlAccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccion.Location = new System.Drawing.Point(222, 0);
            this.pnlAccion.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAccion.Name = "pnlAccion";
            this.pnlAccion.Size = new System.Drawing.Size(100, 92);
            this.pnlAccion.TabIndex = 2;
            // lblFecha
            // 
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(105, 118, 135);
            this.lblFecha.Location = new System.Drawing.Point(0, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 28);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Hace 30 min";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // btnAccion
            // 
            this.btnAccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccion.BackColor = System.Drawing.Color.White;
            this.btnAccion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.btnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccion.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnAccion.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.btnAccion.Location = new System.Drawing.Point(6, 36);
            this.btnAccion.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(88, 30);
            this.btnAccion.TabIndex = 1;
            this.btnAccion.Text = "Ver proyecto";
            this.btnAccion.UseVisualStyleBackColor = false;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // UCAlertaGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.MaximumSize = new System.Drawing.Size(0, 92);
            this.MinimumSize = new System.Drawing.Size(260, 92);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Name = "UCAlertaGestion";
            this.Size = new System.Drawing.Size(322, 92);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnlTexto.ResumeLayout(false);
            this.pnlAccion.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lblPunto;
        private System.Windows.Forms.Panel pnlTexto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Panel pnlAccion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnAccion;
    }
}
