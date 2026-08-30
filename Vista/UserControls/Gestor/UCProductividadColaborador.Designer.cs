namespace Vista
{
    partial class UCProductividadColaborador
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
            this.pnlPersona = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.lblTareas = new System.Windows.Forms.Label();
            this.lblATiempo = new System.Windows.Forms.Label();
            this.pnlCumplimientoFondo = new System.Windows.Forms.Panel();
            this.tlpCumplimiento = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCumplimiento = new System.Windows.Forms.Panel();
            this.lblTendencia = new System.Windows.Forms.Label();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.tlpDatos.SuspendLayout();
            this.pnlPersona.SuspendLayout();
            this.pnlCumplimientoFondo.SuspendLayout();
            this.tlpCumplimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDatos
            // 
            this.tlpDatos.ColumnCount = 5;
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpDatos.Controls.Add(this.pnlPersona, 0, 0);
            this.tlpDatos.Controls.Add(this.lblTareas, 1, 0);
            this.tlpDatos.Controls.Add(this.lblATiempo, 2, 0);
            this.tlpDatos.Controls.Add(this.pnlCumplimientoFondo, 3, 0);
            this.tlpDatos.Controls.Add(this.lblTendencia, 4, 0);
            this.tlpDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatos.Location = new System.Drawing.Point(0, 0);
            this.tlpDatos.Name = "tlpDatos";
            this.tlpDatos.RowCount = 1;
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatos.Size = new System.Drawing.Size(744, 41);
            this.tlpDatos.TabIndex = 0;
            // 
            // pnlPersona
            // 
            this.pnlPersona.Controls.Add(this.lblNombre);
            this.pnlPersona.Controls.Add(this.lblAvatar);
            this.pnlPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPersona.Location = new System.Drawing.Point(0, 0);
            this.pnlPersona.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPersona.Name = "pnlPersona";
            this.pnlPersona.Size = new System.Drawing.Size(223, 41);
            this.pnlPersona.TabIndex = 0;
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblAvatar.ForeColor = System.Drawing.Color.Black;
            this.lblAvatar.Location = new System.Drawing.Point(5, 4);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(29, 32);
            this.lblAvatar.TabIndex = 0;
            this.lblAvatar.Text = "●";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblNombre.Location = new System.Drawing.Point(40, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(178, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre P.";
            // 
            // lblTareas
            // 
            this.lblTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTareas.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTareas.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTareas.Location = new System.Drawing.Point(226, 0);
            this.lblTareas.Name = "lblTareas";
            this.lblTareas.Size = new System.Drawing.Size(83, 41);
            this.lblTareas.TabIndex = 1;
            this.lblTareas.Text = "10";
            this.lblTareas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblATiempo
            // 
            this.lblATiempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblATiempo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblATiempo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblATiempo.Location = new System.Drawing.Point(315, 0);
            this.lblATiempo.Name = "lblATiempo";
            this.lblATiempo.Size = new System.Drawing.Size(113, 41);
            this.lblATiempo.TabIndex = 2;
            this.lblATiempo.Text = "100%";
            this.lblATiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCumplimientoFondo
            // 
            this.pnlCumplimientoFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCumplimientoFondo.BackColor = System.Drawing.Color.FromArgb(225, 231, 238);
            this.pnlCumplimientoFondo.Controls.Add(this.tlpCumplimiento);
            this.pnlCumplimientoFondo.Location = new System.Drawing.Point(441, 16);
            this.pnlCumplimientoFondo.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlCumplimientoFondo.Name = "pnlCumplimientoFondo";
            this.pnlCumplimientoFondo.Size = new System.Drawing.Size(180, 8);
            this.pnlCumplimientoFondo.TabIndex = 3;
            // 
            // tlpCumplimiento
            // 
            this.tlpCumplimiento.BackColor = System.Drawing.Color.FromArgb(225, 231, 238);
            this.tlpCumplimiento.ColumnCount = 2;
            this.tlpCumplimiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCumplimiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tlpCumplimiento.Controls.Add(this.pnlCumplimiento, 0, 0);
            this.tlpCumplimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCumplimiento.Location = new System.Drawing.Point(0, 0);
            this.tlpCumplimiento.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCumplimiento.Name = "tlpCumplimiento";
            this.tlpCumplimiento.RowCount = 1;
            this.tlpCumplimiento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCumplimiento.Size = new System.Drawing.Size(180, 8);
            this.tlpCumplimiento.TabIndex = 0;
            // 
            // pnlCumplimiento
            // 
            this.pnlCumplimiento.BackColor = System.Drawing.Color.FromArgb(32, 169, 87);
            this.pnlCumplimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCumplimiento.Location = new System.Drawing.Point(0, 0);
            this.pnlCumplimiento.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCumplimiento.Name = "pnlCumplimiento";
            this.pnlCumplimiento.Size = new System.Drawing.Size(180, 8);
            this.pnlCumplimiento.TabIndex = 0;
            // 
            // lblTendencia
            // 
            this.lblTendencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTendencia.AutoSize = true;
            this.lblTendencia.BackColor = System.Drawing.Color.FromArgb(223, 246, 231);
            this.lblTendencia.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTendencia.ForeColor = System.Drawing.Color.FromArgb(32, 169, 87);
            this.lblTendencia.Location = new System.Drawing.Point(665, 10);
            this.lblTendencia.Name = "lblTendencia";
            this.lblTendencia.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.lblTendencia.Size = new System.Drawing.Size(45, 21);
            this.lblTendencia.TabIndex = 4;
            this.lblTendencia.Text = "Alta";
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(180, 190, 202);
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 41);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(744, 1);
            this.pnlSeparador.TabIndex = 1;
            // 
            // UCProductividadColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpDatos);
            this.Controls.Add(this.pnlSeparador);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MaximumSize = new System.Drawing.Size(0, 42);
            this.MinimumSize = new System.Drawing.Size(350, 42);
            this.Name = "UCProductividadColaborador";
            this.Size = new System.Drawing.Size(744, 42);
            this.tlpDatos.ResumeLayout(false);
            this.tlpDatos.PerformLayout();
            this.pnlPersona.ResumeLayout(false);
            this.pnlPersona.PerformLayout();
            this.pnlCumplimientoFondo.ResumeLayout(false);
            this.tlpCumplimiento.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDatos;
        private System.Windows.Forms.Panel pnlPersona;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTareas;
        private System.Windows.Forms.Label lblATiempo;
        private System.Windows.Forms.Panel pnlCumplimientoFondo;
        private System.Windows.Forms.TableLayoutPanel tlpCumplimiento;
        private System.Windows.Forms.Panel pnlCumplimiento;
        private System.Windows.Forms.Label lblTendencia;
        private System.Windows.Forms.Panel pnlSeparador;
    }
}
