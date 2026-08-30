namespace Vista
{
    partial class UCTarjetaSeleccionUsuario
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
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.chkSeleccionar = new System.Windows.Forms.CheckBox();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            // 
            // picUsuario
            // 
            this.picUsuario.BackColor = System.Drawing.Color.FromArgb(232, 242, 255);
            this.picUsuario.Location = new System.Drawing.Point(16, 15);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(48, 48);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuario.TabIndex = 0;
            this.picUsuario.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoEllipsis = true;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblUsuario.Location = new System.Drawing.Point(80, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(91, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "jperez2026";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreCompleto.AutoEllipsis = true;
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblNombreCompleto.Location = new System.Drawing.Point(80, 39);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(80, 20);
            this.lblNombreCompleto.TabIndex = 2;
            this.lblNombreCompleto.Text = "Juan Pérez";
            // 
            // lblRol
            // 
            this.lblRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblRol.Location = new System.Drawing.Point(337, 9);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(101, 19);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol en el equipo";
            // 
            // cboRol
            // 
            this.cboRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Items.AddRange(new object[] {
            "Coordinador",
            "Subcoordinador"});
            this.cboRol.Location = new System.Drawing.Point(341, 32);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(198, 27);
            this.cboRol.TabIndex = 4;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSeleccionar.AutoSize = true;
            this.chkSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSeleccionar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.chkSeleccionar.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.chkSeleccionar.Location = new System.Drawing.Point(570, 29);
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.Size = new System.Drawing.Size(101, 24);
            this.chkSeleccionar.TabIndex = 5;
            this.chkSeleccionar.Text = "Seleccionar";
            this.chkSeleccionar.UseVisualStyleBackColor = true;
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(205, 214, 224);
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 77);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(690, 1);
            this.pnlSeparador.TabIndex = 6;
            // 
            // UCTarjetaSeleccionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlSeparador);
            this.Controls.Add(this.chkSeleccionar);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblNombreCompleto);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.picUsuario);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(540, 78);
            this.Name = "UCTarjetaSeleccionUsuario";
            this.Size = new System.Drawing.Size(690, 78);
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.CheckBox chkSeleccionar;
        private System.Windows.Forms.Panel pnlSeparador;
    }
}
