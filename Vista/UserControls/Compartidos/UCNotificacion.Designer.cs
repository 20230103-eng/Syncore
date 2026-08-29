namespace Vista
{
    partial class UCNotificacion
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.lblPunto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnIrTarea = new System.Windows.Forms.Button();
            this.btnMarcarLeida = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tlpPrincipal.Controls.Add(this.lblPunto, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblTitulo, 1, 0);
            this.tlpPrincipal.Controls.Add(this.lblDescripcion, 1, 1);
            this.tlpPrincipal.Controls.Add(this.lblFecha, 1, 2);
            this.tlpPrincipal.Controls.Add(this.btnIrTarea, 1, 3);
            this.tlpPrincipal.Controls.Add(this.btnMarcarLeida, 2, 3);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(14, 7, 12, 5);
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1558, 123);
            this.tlpPrincipal.TabIndex = 0;
            this.tlpPrincipal.SetColumnSpan(this.lblDescripcion, 2);
            // 
            // lblPunto
            // 
            this.lblPunto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPunto.AutoSize = true;
            this.lblPunto.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblPunto.Location = new System.Drawing.Point(22, 7);
            this.lblPunto.Margin = new System.Windows.Forms.Padding(0);
            this.lblPunto.Name = "lblPunto";
            this.lblPunto.Size = new System.Drawing.Size(24, 30);
            this.lblPunto.TabIndex = 0;
            this.lblPunto.Text = "●";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblTitulo.Location = new System.Drawing.Point(52, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1362, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Tarea vencida - “Nombre de la tarea”";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoEllipsis = true;
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblDescripcion.Location = new System.Drawing.Point(52, 37);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(1494, 25);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Esta tarea del proyecto “Proyecto 1” venció hoy. Actualiza el avance";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblFecha.Location = new System.Drawing.Point(52, 63);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(72, 19);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Hoy, 08:00";
            // 
            // btnIrTarea
            // 
            this.btnIrTarea.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnIrTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.btnIrTarea.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.btnIrTarea.FlatAppearance.BorderSize = 0;
            this.btnIrTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrTarea.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrTarea.ForeColor = System.Drawing.Color.White;
            this.btnIrTarea.Location = new System.Drawing.Point(52, 86);
            this.btnIrTarea.Margin = new System.Windows.Forms.Padding(0);
            this.btnIrTarea.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnIrTarea.Name = "btnIrTarea";
            this.btnIrTarea.Size = new System.Drawing.Size(92, 28);
            this.btnIrTarea.TabIndex = 4;
            this.btnIrTarea.Text = "Ir a tarea";
            this.btnIrTarea.UseVisualStyleBackColor = false;
            this.btnIrTarea.Click += new System.EventHandler(this.btnIrTarea_Click);
            // 
            // btnMarcarLeida
            // 
            this.btnMarcarLeida.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMarcarLeida.BackColor = System.Drawing.Color.White;
            this.btnMarcarLeida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.btnMarcarLeida.FlatAppearance.BorderSize = 1;
            this.btnMarcarLeida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarLeida.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarLeida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.btnMarcarLeida.Location = new System.Drawing.Point(1426, 85);
            this.btnMarcarLeida.Margin = new System.Windows.Forms.Padding(0);
            this.btnMarcarLeida.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnMarcarLeida.Name = "btnMarcarLeida";
            this.btnMarcarLeida.Size = new System.Drawing.Size(120, 30);
            this.btnMarcarLeida.TabIndex = 5;
            this.btnMarcarLeida.Text = "Marcar leída";
            this.btnMarcarLeida.UseVisualStyleBackColor = false;
            this.btnMarcarLeida.Click += new System.EventHandler(this.btnMarcarLeida_Click);
            // 
            // UCNotificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tlpPrincipal);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(0, 125);
            this.Name = "UCNotificacion";
            this.Size = new System.Drawing.Size(1560, 125);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lblPunto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnIrTarea;
        private System.Windows.Forms.Button btnMarcarLeida;
    }
}
