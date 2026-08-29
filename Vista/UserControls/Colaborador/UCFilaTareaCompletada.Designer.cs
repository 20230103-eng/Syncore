namespace Vista
{
    partial class UCFilaTareaCompletada
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(32, 169, 87);
            this.lblMarca.Location = new System.Drawing.Point(12, 8);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(18, 20);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "✓";
            // lblTarea
            // 
            this.lblTarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarea.AutoEllipsis = true;
            this.lblTarea.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTarea.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTarea.Location = new System.Drawing.Point(39, 8);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(380, 20);
            this.lblTarea.TabIndex = 1;
            this.lblTarea.Text = "Nombre de tarea 1";
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(220, 226, 233);
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 36);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(440, 1);
            this.pnlSeparador.TabIndex = 2;
            // UCFilaTareaCompletada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlSeparador);
            this.Controls.Add(this.lblTarea);
            this.Controls.Add(this.lblMarca);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(0, 37);
            this.MinimumSize = new System.Drawing.Size(180, 37);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Name = "UCFilaTareaCompletada";
            this.Size = new System.Drawing.Size(440, 37);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Panel pnlSeparador;
    }
}
