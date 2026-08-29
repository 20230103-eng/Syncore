namespace Vista
{
    partial class UCBarraSemana
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
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.lblSemana = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.pnlBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarra.Location = new System.Drawing.Point(55, 30);
            this.pnlBarra.Size = new System.Drawing.Size(70, 120);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.TabIndex = 0;
            // lblSemana
            // 
            this.lblSemana.AutoSize = false;
            this.lblSemana.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblSemana.Location = new System.Drawing.Point(60, 164);
            this.lblSemana.Size = new System.Drawing.Size(60, 18);
            this.lblSemana.Text = "S1";
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.TabIndex = 1;
            this.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblValor
            // 
            this.lblValor.AutoSize = false;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblValor.Location = new System.Drawing.Point(60, 184);
            this.lblValor.Size = new System.Drawing.Size(60, 18);
            this.lblValor.Text = "28";
            this.lblValor.Name = "lblValor";
            this.lblValor.TabIndex = 2;
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // UCBarraSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblSemana);
            this.Controls.Add(this.pnlBarra);
            this.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.Name = "UCBarraSemana";
            this.Size = new System.Drawing.Size(180, 210);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.Label lblValor;
    }
}
