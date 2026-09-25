namespace Vista
{
    partial class UCFilaEquipoTrabajo
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
            this.components = new System.ComponentModel.Container();
            this.tlpFila = new System.Windows.Forms.TableLayoutPanel();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblAsignadas = new System.Windows.Forms.Label();
            this.lblCompletadas = new System.Windows.Forms.Label();
            this.lblVencidas = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.tlpFila.SuspendLayout();
            this.picUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFila
            // 
            this.tlpFila.ColumnCount = 9;
            this.tlpFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.tlpFila.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.tlpFila.Controls.Add(this.picUsuario, 0, 0);
            this.tlpFila.Controls.Add(this.lblNombre, 1, 0);
            this.tlpFila.Controls.Add(this.lblArea, 2, 0);
            this.tlpFila.Controls.Add(this.lblRol, 3, 0);
            this.tlpFila.Controls.Add(this.lblAsignadas, 4, 0);
            this.tlpFila.Controls.Add(this.lblCompletadas, 5, 0);
            this.tlpFila.Controls.Add(this.lblVencidas, 6, 0);
            this.tlpFila.Controls.Add(this.btnEditar, 7, 0);
            this.tlpFila.Controls.Add(this.btnRetirar, 8, 0);
            this.tlpFila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFila.Name = "tlpFila";
            this.tlpFila.RowCount = 1;
            this.tlpFila.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFila.Size = new System.Drawing.Size(1540, 53);
            // 
            // picUsuario
            // 
            this.picUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picUsuario.Image = global::Vista.Properties.Recursos.AvatarUsuario;
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(32, 32);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuario.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblNombre.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Text = "María López";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblArea.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Text = "Tecnología";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblRol.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Text = "Coordinador";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAsignadas
            // 
            this.lblAsignadas.AutoSize = true;
            this.lblAsignadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAsignadas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAsignadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblAsignadas.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lblAsignadas.Name = "lblAsignadas";
            this.lblAsignadas.Text = "8";
            this.lblAsignadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompletadas
            // 
            this.lblCompletadas.AutoSize = true;
            this.lblCompletadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompletadas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCompletadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblCompletadas.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lblCompletadas.Name = "lblCompletadas";
            this.lblCompletadas.Text = "5";
            this.lblCompletadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVencidas
            // 
            this.lblVencidas.AutoSize = true;
            this.lblVencidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVencidas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVencidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblVencidas.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lblVencidas.Name = "lblVencidas";
            this.lblVencidas.Text = "1";
            this.lblVencidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.White;
            this.btnRetirar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRetirar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnRetirar.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(1540, 1);
            // 
            // UCFilaEquipoTrabajo
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpFila);
            this.Controls.Add(this.pnlSeparador);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCFilaEquipoTrabajo";
            this.Size = new System.Drawing.Size(1540, 54);
            this.picUsuario.ResumeLayout(false);
            this.tlpFila.ResumeLayout(false);
            this.tlpFila.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFila;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblAsignadas;
        private System.Windows.Forms.Label lblCompletadas;
        private System.Windows.Forms.Label lblVencidas;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Panel pnlSeparador;
    }
}
