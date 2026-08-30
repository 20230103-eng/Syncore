namespace Vista
{
    partial class UCAvanceReciente
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
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnlTexto = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.pnlTexto.SuspendLayout();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpPrincipal.Controls.Add(this.picAvatar, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnlTexto, 1, 0);
            this.tlpPrincipal.Controls.Add(this.lblPorcentaje, 2, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(322, 68);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // picAvatar
            // 
            this.picAvatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.Image = global::Vista.Properties.Recursos.AvatarUsuario;
            this.picAvatar.Location = new System.Drawing.Point(6, 15);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(38, 38);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // pnlTexto
            // 
            this.pnlTexto.Controls.Add(this.lblTarea);
            this.pnlTexto.Controls.Add(this.lblNombre);
            this.pnlTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTexto.Location = new System.Drawing.Point(50, 0);
            this.pnlTexto.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTexto.Name = "pnlTexto";
            this.pnlTexto.Size = new System.Drawing.Size(214, 68);
            this.pnlTexto.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(20, 27, 36);
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Padding = new System.Windows.Forms.Padding(4, 8, 0, 0);
            this.lblNombre.Size = new System.Drawing.Size(214, 31);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Alex Zometa";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoEllipsis = true;
            this.lblTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTarea.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblTarea.ForeColor = System.Drawing.Color.FromArgb(105, 118, 135);
            this.lblTarea.Location = new System.Drawing.Point(0, 31);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Padding = new System.Windows.Forms.Padding(4, 1, 0, 0);
            this.lblTarea.Size = new System.Drawing.Size(214, 37);
            this.lblTarea.TabIndex = 1;
            this.lblTarea.Text = "Tarea 1";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPorcentaje.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPorcentaje.ForeColor = System.Drawing.Color.FromArgb(240, 128, 49);
            this.lblPorcentaje.Location = new System.Drawing.Point(264, 0);
            this.lblPorcentaje.Margin = new System.Windows.Forms.Padding(0);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(58, 68);
            this.lblPorcentaje.TabIndex = 2;
            this.lblPorcentaje.Text = "33%";
            this.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCAvanceReciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpPrincipal);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(0, 68);
            this.MinimumSize = new System.Drawing.Size(260, 68);
            this.Name = "UCAvanceReciente";
            this.Size = new System.Drawing.Size(322, 68);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.tlpPrincipal.ResumeLayout(false);
            this.pnlTexto.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel pnlTexto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblPorcentaje;
    }
}
