namespace Vista
{
    partial class UCCeldaCalendario
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
            this.lblDia = new System.Windows.Forms.Label();
            this.pnlEvento = new System.Windows.Forms.Panel();
            this.lblEvento = new System.Windows.Forms.Label();
            this.pnlEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDia.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblDia.Location = new System.Drawing.Point(8, 7);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(17, 19);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "1";
            // 
            // pnlEvento
            // 
            this.pnlEvento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEvento.BackColor = System.Drawing.Color.FromArgb(232, 242, 255);
            this.pnlEvento.Controls.Add(this.lblEvento);
            this.pnlEvento.Location = new System.Drawing.Point(7, 36);
            this.pnlEvento.Name = "pnlEvento";
            this.pnlEvento.Size = new System.Drawing.Size(202, 30);
            this.pnlEvento.TabIndex = 1;
            // 
            // lblEvento
            // 
            this.lblEvento.AutoEllipsis = true;
            this.lblEvento.BackColor = System.Drawing.Color.FromArgb(232, 242, 255);
            this.lblEvento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEvento.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEvento.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblEvento.Location = new System.Drawing.Point(0, 0);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Padding = new System.Windows.Forms.Padding(6, 0, 4, 0);
            this.lblEvento.Size = new System.Drawing.Size(202, 30);
            this.lblEvento.TabIndex = 0;
            this.lblEvento.Text = "Realizar tarea 1";
            this.lblEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCCeldaCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlEvento);
            this.Controls.Add(this.lblDia);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCCeldaCalendario";
            this.Size = new System.Drawing.Size(218, 105);
            this.pnlEvento.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Panel pnlEvento;
        private System.Windows.Forms.Label lblEvento;
    }
}
