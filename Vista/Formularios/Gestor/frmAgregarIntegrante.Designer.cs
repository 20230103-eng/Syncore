namespace Vista
{
    partial class frmAgregarIntegrante
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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.flpUsuarios = new System.Windows.Forms.FlowLayoutPanel();
            this.usuario1 = new Vista.UCTarjetaSeleccionUsuario();
            this.usuario2 = new Vista.UCTarjetaSeleccionUsuario();
            this.usuario3 = new Vista.UCTarjetaSeleccionUsuario();
            this.usuario4 = new Vista.UCTarjetaSeleccionUsuario();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.flpUsuarios.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.White;
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(742, 86);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(22, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar integrante";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblSubtitulo.Location = new System.Drawing.Point(25, 55);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(381, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Selecciona uno o varios usuarios y asigna su rol en el equipo.";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(24, 106);
            this.txtBuscar.MaxLength = 150;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ShortcutsEnabled = false;
            this.txtBuscar.Size = new System.Drawing.Size(560, 27);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnBuscar.Location = new System.Drawing.Point(594, 103);
            this.btnBuscar.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 33);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblResultados.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblResultados.Location = new System.Drawing.Point(24, 155);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(153, 20);
            this.lblResultados.TabIndex = 3;
            this.lblResultados.Text = "Usuarios disponibles";
            // 
            // flpUsuarios
            // 
            this.flpUsuarios.AutoScroll = true;
            this.flpUsuarios.BackColor = System.Drawing.Color.White;
            this.flpUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpUsuarios.Controls.Add(this.usuario1);
            this.flpUsuarios.Controls.Add(this.usuario2);
            this.flpUsuarios.Controls.Add(this.usuario3);
            this.flpUsuarios.Controls.Add(this.usuario4);
            this.flpUsuarios.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpUsuarios.Location = new System.Drawing.Point(24, 184);
            this.flpUsuarios.Name = "flpUsuarios";
            this.flpUsuarios.Size = new System.Drawing.Size(694, 330);
            this.flpUsuarios.TabIndex = 2;
            this.flpUsuarios.WrapContents = false;
            // 
            // usuario1
            // 
            this.usuario1.ImagenPerfil = null;
            this.usuario1.Location = new System.Drawing.Point(0, 0);
            this.usuario1.Name = "usuario1";
            this.usuario1.NombreCompleto = "Juan Pérez Mejía";
            this.usuario1.RolAsignado = "Coordinador";
            this.usuario1.Seleccionado = true;
            this.usuario1.Size = new System.Drawing.Size(690, 78);
            this.usuario1.TabIndex = 0;
            this.usuario1.Usuario = "jperez2026";
            // 
            // usuario2
            // 
            this.usuario2.ImagenPerfil = null;
            this.usuario2.Location = new System.Drawing.Point(0, 78);
            this.usuario2.Name = "usuario2";
            this.usuario2.NombreCompleto = "Alex Zometa Hernández";
            this.usuario2.RolAsignado = "Subcoordinador";
            this.usuario2.Seleccionado = false;
            this.usuario2.Size = new System.Drawing.Size(690, 78);
            this.usuario2.TabIndex = 1;
            this.usuario2.Usuario = "azometa";
            // 
            // usuario3
            // 
            this.usuario3.ImagenPerfil = null;
            this.usuario3.Location = new System.Drawing.Point(0, 156);
            this.usuario3.Name = "usuario3";
            this.usuario3.NombreCompleto = "Erick Mercado López";
            this.usuario3.RolAsignado = "Coordinador";
            this.usuario3.Seleccionado = false;
            this.usuario3.Size = new System.Drawing.Size(690, 78);
            this.usuario3.TabIndex = 2;
            this.usuario3.Usuario = "emercado";
            // 
            // usuario4
            // 
            this.usuario4.ImagenPerfil = null;
            this.usuario4.Location = new System.Drawing.Point(0, 234);
            this.usuario4.Name = "usuario4";
            this.usuario4.NombreCompleto = "Elmer Silva Barahona";
            this.usuario4.RolAsignado = "Subcoordinador";
            this.usuario4.Seleccionado = false;
            this.usuario4.Size = new System.Drawing.Size(690, 78);
            this.usuario4.TabIndex = 3;
            this.usuario4.Usuario = "esilva";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.Controls.Add(this.btnAgregar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 532);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(742, 67);
            this.pnlBotones.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(142, 160, 181);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.btnCancelar.Location = new System.Drawing.Point(485, 17);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 34);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(600, 17);
            this.btnAgregar.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 34);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // frmAgregarIntegrante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(742, 599);
            this.AcceptButton = this.btnAgregar;
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.flpUsuarios);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Load += new System.EventHandler(this.frmAgregarIntegrante_Load);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarIntegrante";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar integrante";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.flpUsuarios.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.FlowLayoutPanel flpUsuarios;
        private Vista.UCTarjetaSeleccionUsuario usuario1;
        private Vista.UCTarjetaSeleccionUsuario usuario2;
        private Vista.UCTarjetaSeleccionUsuario usuario3;
        private Vista.UCTarjetaSeleccionUsuario usuario4;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
    }
}
