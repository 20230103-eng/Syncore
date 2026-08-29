namespace Vista
{
    partial class UCTarjetaTarea
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
            this.pnlColor = new System.Windows.Forms.Panel();
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.tlpContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.pnlColor, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpContenido, 1, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(278, 105);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.pnlColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColor.Location = new System.Drawing.Point(0, 0);
            this.pnlColor.Margin = new System.Windows.Forms.Padding(0);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(5, 105);
            this.pnlColor.TabIndex = 0;
            // 
            // tlpContenido
            // 
            this.tlpContenido.ColumnCount = 3;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Controls.Add(this.lblProyecto, 0, 0);
            this.tlpContenido.Controls.Add(this.lblTarea, 0, 1);
            this.tlpContenido.Controls.Add(this.lblFecha, 0, 2);
            this.tlpContenido.Controls.Add(this.lblEstado, 1, 2);
            this.tlpContenido.Controls.Add(this.btnVer, 2, 2);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(5, 0);
            this.tlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.tlpContenido.RowCount = 3;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.Size = new System.Drawing.Size(273, 105);
            this.tlpContenido.TabIndex = 1;
            this.tlpContenido.SetColumnSpan(this.lblProyecto, 3);
            this.tlpContenido.SetColumnSpan(this.lblTarea, 3);
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoEllipsis = true;
            this.lblProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProyecto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblProyecto.Location = new System.Drawing.Point(19, 7);
            this.lblProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(251, 22);
            this.lblProyecto.TabIndex = 1;
            this.lblProyecto.Text = "Proyecto 1";
            this.lblProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTarea
            // 
            this.lblTarea.AutoEllipsis = true;
            this.lblTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTarea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblTarea.Location = new System.Drawing.Point(19, 29);
            this.lblTarea.Margin = new System.Windows.Forms.Padding(0);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(251, 32);
            this.lblTarea.TabIndex = 2;
            this.lblTarea.Text = "Nombre de la tarea";
            this.lblTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblFecha.Location = new System.Drawing.Point(19, 72);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 19);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "28 abr";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoEllipsis = true;
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.lblEstado.Location = new System.Drawing.Point(101, 75);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.lblEstado.Size = new System.Drawing.Size(96, 24);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Pendiente";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVer
            // 
            this.btnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVer.BackColor = System.Drawing.Color.White;
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(160)))), ((int)(((byte)(181)))));
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.btnVer.Location = new System.Drawing.Point(214, 73);
            this.btnVer.Margin = new System.Windows.Forms.Padding(0);
            this.btnVer.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(46, 28);
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            // 
            // UCTarjetaTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tlpPrincipal);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(0, 110);
            this.Name = "UCTarjetaTarea";
            this.Size = new System.Drawing.Size(280, 110);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpContenido.ResumeLayout(false);
            this.tlpContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnVer;
    }
}
