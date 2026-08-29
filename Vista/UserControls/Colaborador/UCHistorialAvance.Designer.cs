namespace Vista
{
    partial class UCHistorialAvance
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
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // pnlPunto
            // 
            this.pnlPunto.BackColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.pnlPunto.Location = new System.Drawing.Point(12, 15);
            this.pnlPunto.Name = "pnlPunto";
            this.pnlPunto.Size = new System.Drawing.Size(9, 9);
            this.pnlPunto.TabIndex = 0;
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPorcentaje.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblPorcentaje.Location = new System.Drawing.Point(31, 9);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(36, 20);
            this.lblPorcentaje.TabIndex = 1;
            this.lblPorcentaje.Text = "60%";
            // lblTarea
            // 
            this.lblTarea.AutoEllipsis = true;
            this.lblTarea.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTarea.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarea.AutoEllipsis = true;
            this.lblTarea.Location = new System.Drawing.Point(74, 9);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(175, 20);
            this.lblTarea.TabIndex = 2;
            this.lblTarea.Text = "Tarea 1";
            // lblProyecto
            // 
            this.lblProyecto.AutoEllipsis = true;
            this.lblProyecto.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProyecto.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProyecto.AutoEllipsis = true;
            this.lblProyecto.Location = new System.Drawing.Point(285, 10);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(82, 19);
            this.lblProyecto.TabIndex = 3;
            this.lblProyecto.Text = "Proyecto 1";
            // lblDescripcion
            // 
            this.lblDescripcion.AutoEllipsis = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoEllipsis = true;
            this.lblDescripcion.Location = new System.Drawing.Point(31, 34);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(336, 20);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Secciones completadas";
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblFecha.Location = new System.Drawing.Point(31, 57);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 19);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "28 abr";
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(220, 226, 233);
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 85);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(380, 1);
            this.pnlSeparador.TabIndex = 6;
            // UCHistorialAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlSeparador);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.lblTarea);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.pnlPunto);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(0, 86);
            this.MinimumSize = new System.Drawing.Size(250, 86);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Name = "UCHistorialAvance";
            this.Size = new System.Drawing.Size(380, 86);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlPunto;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlSeparador;
    }
}
