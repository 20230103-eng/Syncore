namespace Vista
{
    partial class UCTarjetaIndicador
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.pnlLinea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 16);
            this.lblTitulo.Text = "Indicador";
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.lblValor.Location = new System.Drawing.Point(18, 40);
            this.lblValor.Text = "7";
            this.lblValor.Name = "lblValor";
            this.lblValor.TabIndex = 1;
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.lblDetalle.Location = new System.Drawing.Point(21, 88);
            this.lblDetalle.Text = "Texto auxiliar";
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.TabIndex = 2;
            // pnlLinea
            // 
            this.pnlLinea.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.pnlLinea.Location = new System.Drawing.Point(0, 0);
            this.pnlLinea.Size = new System.Drawing.Size(6, 116);
            this.pnlLinea.Name = "pnlLinea";
            this.pnlLinea.TabIndex = 3;
            // UCTarjetaIndicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlLinea);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.MinimumSize = new System.Drawing.Size(180, 116);
            this.Name = "UCTarjetaIndicador";
            this.Size = new System.Drawing.Size(388, 116);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Panel pnlLinea;
    }
}
