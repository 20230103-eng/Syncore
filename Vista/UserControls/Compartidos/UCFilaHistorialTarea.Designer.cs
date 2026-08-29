namespace Vista
{
    partial class UCFilaHistorialTarea
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

            this.pnlPunto = new System.Windows.Forms.Panel();
            this.lblCabecera = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblEvidencia = new System.Windows.Forms.Label();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.Margin = new System.Windows.Forms.Padding(0);
            this.SuspendLayout();
            // 
            // pnlPunto
            // 
            this.pnlPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.pnlPunto.Location = new System.Drawing.Point(14, 18);
            this.pnlPunto.Name = "pnlPunto";
            this.pnlPunto.Size = new System.Drawing.Size(9, 9);
            // 
            // lblCabecera
            // 
            this.lblCabecera.AutoSize = true;
            this.lblCabecera.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblCabecera.Name = "lblCabecera";
            this.lblCabecera.Text = "60%  -  28 abr 2026";
            this.lblCabecera.Location = new System.Drawing.Point(34, 10);
            this.lblCabecera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Text = "Secciones 1 y 2 completadas. Pendiente sección 3.";
            this.lblDetalle.Location = new System.Drawing.Point(34, 31);
            this.lblDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // lblEvidencia
            // 
            this.lblEvidencia.AutoSize = true;
            this.lblEvidencia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEvidencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblEvidencia.Name = "lblEvidencia";
            this.lblEvidencia.Text = "Evidencia: 1 archivo";
            this.lblEvidencia.Location = new System.Drawing.Point(34, 50);
            this.lblEvidencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(1000, 1);
            // 
            // UCFilaHistorialTarea
            // 
            this.Size = new System.Drawing.Size(1000, 74);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlPunto);
            this.Controls.Add(this.lblCabecera);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblEvidencia);
            this.Controls.Add(this.pnlSeparador);
            this.Name = "UCFilaHistorialTarea";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlPunto;
        private System.Windows.Forms.Label lblCabecera;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblEvidencia;
        private System.Windows.Forms.Panel pnlSeparador;
    }
}
