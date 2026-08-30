namespace Vista
{
    partial class frmSeleccionRol
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.tlpOpciones = new System.Windows.Forms.TableLayoutPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnGestor = new System.Windows.Forms.Button();
            this.btnColaborador = new System.Windows.Forms.Button();
            this.pnlFondo.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            this.tlpOpciones.SuspendLayout();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackgroundImage = global::Vista.Properties.Recursos.FondoInicio;
            this.pnlFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFondo.Controls.Add(this.tlpPrincipal);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1366, 768);
            this.pnlFondo.TabIndex = 0;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpPrincipal.Controls.Add(this.pnlOpciones, 0, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1366, 768);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.Transparent;
            this.pnlOpciones.Controls.Add(this.tlpOpciones);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Padding = new System.Windows.Forms.Padding(70, 35, 45, 35);
            this.pnlOpciones.Size = new System.Drawing.Size(614, 768);
            this.pnlOpciones.TabIndex = 0;
            // 
            // tlpOpciones
            // 
            this.tlpOpciones.BackColor = System.Drawing.Color.Transparent;
            this.tlpOpciones.ColumnCount = 1;
            this.tlpOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOpciones.Controls.Add(this.picLogo, 0, 0);
            this.tlpOpciones.Controls.Add(this.lblBienvenido, 0, 2);
            this.tlpOpciones.Controls.Add(this.btnGestor, 0, 4);
            this.tlpOpciones.Controls.Add(this.btnColaborador, 0, 6);
            this.tlpOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOpciones.Location = new System.Drawing.Point(70, 35);
            this.tlpOpciones.Name = "tlpOpciones";
            this.tlpOpciones.RowCount = 8;
            this.tlpOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tlpOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tlpOpciones.Size = new System.Drawing.Size(499, 698);
            this.tlpOpciones.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picLogo.Image = global::Vista.Properties.Recursos.LogoSyncore;
            this.picLogo.Location = new System.Drawing.Point(0, 7);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(190, 55);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(0, 217);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(499, 72);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGestor
            // 
            this.btnGestor.BackColor = System.Drawing.Color.FromArgb(45, 104, 183);
            this.btnGestor.Click += new System.EventHandler(this.btnGestor_Click);
            this.btnGestor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGestor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(135, 190, 255);
            this.btnGestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGestor.ForeColor = System.Drawing.Color.White;
            this.btnGestor.Location = new System.Drawing.Point(0, 309);
            this.btnGestor.Margin = new System.Windows.Forms.Padding(0);
            this.btnGestor.Name = "btnGestor";
            this.btnGestor.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnGestor.Size = new System.Drawing.Size(499, 84);
            this.btnGestor.TabIndex = 2;
            this.btnGestor.Text = "Como Gestor\r\nAccede a las herramientas de gestión";
            this.btnGestor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestor.UseVisualStyleBackColor = false;
            // 
            // btnColaborador
            // 
            this.btnColaborador.BackColor = System.Drawing.Color.FromArgb(45, 104, 183);
            this.btnColaborador.Click += new System.EventHandler(this.btnColaborador_Click);
            this.btnColaborador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnColaborador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(135, 190, 255);
            this.btnColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColaborador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnColaborador.ForeColor = System.Drawing.Color.White;
            this.btnColaborador.Location = new System.Drawing.Point(0, 411);
            this.btnColaborador.Margin = new System.Windows.Forms.Padding(0);
            this.btnColaborador.Name = "btnColaborador";
            this.btnColaborador.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnColaborador.Size = new System.Drawing.Size(499, 84);
            this.btnColaborador.TabIndex = 3;
            this.btnColaborador.Text = "Como Colaborador\r\nAccede a las herramientas de colaboración";
            this.btnColaborador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColaborador.UseVisualStyleBackColor = false;
            // 
            // frmSeleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "frmSeleccionRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syncore - Selección de rol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlFondo.ResumeLayout(false);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnlOpciones.ResumeLayout(false);
            this.tlpOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.TableLayoutPanel tlpOpciones;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnGestor;
        private System.Windows.Forms.Button btnColaborador;
    }
}
