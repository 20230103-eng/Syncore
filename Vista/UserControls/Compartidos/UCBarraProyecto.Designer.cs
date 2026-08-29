namespace Vista
{
    partial class UCBarraProyecto
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
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.pnlBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarra.Location = new System.Drawing.Point(28, 22);
            this.pnlBarra.Size = new System.Drawing.Size(70, 108);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.TabIndex = 0;
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = false;
            this.lblPorcentaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.lblPorcentaje.Location = new System.Drawing.Point(28, 138);
            this.lblPorcentaje.Size = new System.Drawing.Size(70, 20);
            this.lblPorcentaje.Text = "45%";
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.TabIndex = 1;
            this.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblProyecto
            // 
            this.lblProyecto.AutoEllipsis = true;
            this.lblProyecto.AutoSize = false;
            this.lblProyecto.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.lblProyecto.Location = new System.Drawing.Point(5, 158);
            this.lblProyecto.Size = new System.Drawing.Size(115, 16);
            this.lblProyecto.Text = "Proyecto";
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.TabIndex = 2;
            this.lblProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // UCBarraProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.pnlBarra);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Name = "UCBarraProyecto";
            this.Size = new System.Drawing.Size(125, 175);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblProyecto;
    }
}
