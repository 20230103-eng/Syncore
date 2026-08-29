namespace Vista
{
    partial class UCFilaAvanceRegistrado
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
            this.tlpDatos = new System.Windows.Forms.TableLayoutPanel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblAvance = new System.Windows.Forms.Label();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.tlpDatos.SuspendLayout();
            this.SuspendLayout();
            // tlpDatos
            // 
            this.tlpDatos.ColumnCount = 4;
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDatos.Controls.Add(this.lblFecha, 0, 0);
            this.tlpDatos.Controls.Add(this.lblTarea, 1, 0);
            this.tlpDatos.Controls.Add(this.lblProyecto, 2, 0);
            this.tlpDatos.Controls.Add(this.lblAvance, 3, 0);
            this.tlpDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatos.Location = new System.Drawing.Point(0, 0);
            this.tlpDatos.Name = "tlpDatos";
            this.tlpDatos.RowCount = 1;
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatos.Size = new System.Drawing.Size(450, 40);
            this.tlpDatos.TabIndex = 0;
            // lblFecha
            // 
            this.lblFecha.AutoEllipsis = true;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblFecha.Location = new System.Drawing.Point(8, 0);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(79, 40);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "28 abr";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblTarea
            // 
            this.lblTarea.AutoEllipsis = true;
            this.lblTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTarea.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTarea.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTarea.Location = new System.Drawing.Point(93, 0);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(129, 40);
            this.lblTarea.TabIndex = 1;
            this.lblTarea.Text = "Tarea 1";
            this.lblTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblProyecto
            // 
            this.lblProyecto.AutoEllipsis = true;
            this.lblProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProyecto.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProyecto.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblProyecto.Location = new System.Drawing.Point(228, 0);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(129, 40);
            this.lblProyecto.TabIndex = 2;
            this.lblProyecto.Text = "Proyecto 1";
            this.lblProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblAvance
            // 
            this.lblAvance.AutoEllipsis = true;
            this.lblAvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvance.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAvance.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.lblAvance.Location = new System.Drawing.Point(363, 0);
            this.lblAvance.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.lblAvance.Name = "lblAvance";
            this.lblAvance.Size = new System.Drawing.Size(79, 40);
            this.lblAvance.TabIndex = 3;
            this.lblAvance.Text = "60%";
            this.lblAvance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(220, 226, 233);
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 40);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(450, 1);
            this.pnlSeparador.TabIndex = 1;
            // UCFilaAvanceRegistrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpDatos);
            this.Controls.Add(this.pnlSeparador);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(0, 41);
            this.MinimumSize = new System.Drawing.Size(300, 41);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Name = "UCFilaAvanceRegistrado";
            this.Size = new System.Drawing.Size(450, 41);
            this.tlpDatos.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDatos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblAvance;
        private System.Windows.Forms.Panel pnlSeparador;
    }
}
