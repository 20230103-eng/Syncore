namespace Vista
{
    partial class UCFilaAgendaSemanal
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
            this.lblDia = new System.Windows.Forms.Label();
            this.pnlIndicador = new System.Windows.Forms.Panel();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.tlpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDatos
            // 
            this.tlpDatos.ColumnCount = 4;
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpDatos.Controls.Add(this.lblDia, 0, 0);
            this.tlpDatos.Controls.Add(this.pnlIndicador, 1, 0);
            this.tlpDatos.Controls.Add(this.lblActividad, 2, 0);
            this.tlpDatos.Controls.Add(this.lblHora, 3, 0);
            this.tlpDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatos.Location = new System.Drawing.Point(0, 0);
            this.tlpDatos.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDatos.Name = "tlpDatos";
            this.tlpDatos.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tlpDatos.RowCount = 1;
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatos.Size = new System.Drawing.Size(360, 38);
            this.tlpDatos.TabIndex = 0;
            // 
            // lblDia
            // 
            this.lblDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDia.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblDia.Location = new System.Drawing.Point(8, 0);
            this.lblDia.Margin = new System.Windows.Forms.Padding(0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(46, 38);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Lun";
            this.lblDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlIndicador
            // 
            this.pnlIndicador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.pnlIndicador.Location = new System.Drawing.Point(57, 16);
            this.pnlIndicador.Margin = new System.Windows.Forms.Padding(0);
            this.pnlIndicador.Name = "pnlIndicador";
            this.pnlIndicador.Size = new System.Drawing.Size(6, 6);
            this.pnlIndicador.TabIndex = 1;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoEllipsis = true;
            this.lblActividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActividad.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblActividad.Location = new System.Drawing.Point(66, 0);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(224, 38);
            this.lblActividad.TabIndex = 2;
            this.lblActividad.Text = "Reunión de seguimiento";
            this.lblActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHora
            // 
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblHora.Location = new System.Drawing.Point(290, 0);
            this.lblHora.Margin = new System.Windows.Forms.Padding(0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(62, 38);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "10:00";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(239)))));
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 37);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(360, 1);
            this.pnlSeparador.TabIndex = 1;
            // 
            // UCFilaAgendaSemanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpDatos);
            this.Controls.Add(this.pnlSeparador);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(260, 38);
            this.Name = "UCFilaAgendaSemanal";
            this.Size = new System.Drawing.Size(360, 38);
            this.tlpDatos.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDatos;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Panel pnlIndicador;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel pnlSeparador;
    }
}
