namespace Vista
{
    partial class frmMatrizResponsabilidades
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(40, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(100, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Matriz de responsabilidades";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(105, 118, 135);
            this.lblEstado.Location = new System.Drawing.Point(43, 94);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(188, 25);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "No está terminado aún";
            // 
            // frmMatrizResponsabilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.ClientSize = new System.Drawing.Size(1670, 1080);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMatrizResponsabilidades";
            this.Text = "Matriz de responsabilidades";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEstado;
    }
}
