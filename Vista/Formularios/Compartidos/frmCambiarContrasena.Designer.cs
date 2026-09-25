namespace Vista
{
    partial class frmCambiarContrasena
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblActual = new System.Windows.Forms.Label();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.lblNueva = new System.Windows.Forms.Label();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblTitulo.Location = new System.Drawing.Point(28, 22);
            this.lblTitulo.Text = "Cambiar contraseña";
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(31, 76);
            this.lblActual.Text = "Contraseña actual o clave temporal";
            this.txtActual.Location = new System.Drawing.Point(34, 96);
            this.txtActual.MaxLength = 100;
            this.txtActual.PasswordChar = '●';
            this.txtActual.Size = new System.Drawing.Size(390, 20);
            this.lblNueva.AutoSize = true;
            this.lblNueva.Location = new System.Drawing.Point(31, 137);
            this.lblNueva.Text = "Nueva contraseña";
            this.txtNueva.Location = new System.Drawing.Point(34, 157);
            this.txtNueva.MaxLength = 100;
            this.txtNueva.PasswordChar = '●';
            this.txtNueva.Size = new System.Drawing.Size(390, 20);
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(31, 198);
            this.lblConfirmar.Text = "Confirmar nueva contraseña";
            this.txtConfirmar.Location = new System.Drawing.Point(34, 218);
            this.txtConfirmar.MaxLength = 100;
            this.txtConfirmar.PasswordChar = '●';
            this.txtConfirmar.Size = new System.Drawing.Size(390, 20);
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 105, 240);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(220, 271);
            this.btnGuardar.Size = new System.Drawing.Size(100, 38);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnCancelar.Location = new System.Drawing.Point(324, 271);
            this.btnCancelar.Size = new System.Drawing.Size(100, 38);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(462, 338);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.lblNueva);
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.lblActual);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCambiarContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambiar contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
