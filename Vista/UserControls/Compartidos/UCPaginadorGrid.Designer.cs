namespace Vista
{
    partial class UCPaginadorGrid
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.FlowLayoutPanel flpNavegacion;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.ComboBox cboPagina;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ToolTip toolTipAyuda;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.flpNavegacion = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblPagina = new System.Windows.Forms.Label();
            this.cboPagina = new System.Windows.Forms.ComboBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.flpNavegacion.SuspendLayout();
            this.SuspendLayout();
            this.lblRegistros.AutoEllipsis = true;
            this.lblRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegistros.ForeColor = System.Drawing.Color.FromArgb(71, 87, 107);
            this.lblRegistros.Location = new System.Drawing.Point(8, 4);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(482, 34);
            this.lblRegistros.TabIndex = 0;
            this.lblRegistros.Text = "Sin registros";
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.flpNavegacion.Controls.Add(this.btnAnterior);
            this.flpNavegacion.Controls.Add(this.lblPagina);
            this.flpNavegacion.Controls.Add(this.cboPagina);
            this.flpNavegacion.Controls.Add(this.btnSiguiente);
            this.flpNavegacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpNavegacion.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpNavegacion.Location = new System.Drawing.Point(490, 4);
            this.flpNavegacion.Margin = new System.Windows.Forms.Padding(0);
            this.flpNavegacion.Name = "flpNavegacion";
            this.flpNavegacion.Size = new System.Drawing.Size(302, 34);
            this.flpNavegacion.TabIndex = 1;
            this.flpNavegacion.WrapContents = false;
            this.btnAnterior.Location = new System.Drawing.Point(0, 3);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(80, 27);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.toolTipAyuda.SetToolTip(this.btnAnterior, "Mostrar la página anterior.");
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            this.lblPagina.AutoSize = true;
            this.lblPagina.Location = new System.Drawing.Point(86, 10);
            this.lblPagina.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(39, 15);
            this.lblPagina.TabIndex = 1;
            this.lblPagina.Text = "Página";
            this.cboPagina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPagina.FormattingEnabled = true;
            this.cboPagina.Location = new System.Drawing.Point(131, 3);
            this.cboPagina.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.cboPagina.Name = "cboPagina";
            this.cboPagina.Size = new System.Drawing.Size(55, 23);
            this.cboPagina.TabIndex = 2;
            this.toolTipAyuda.SetToolTip(this.cboPagina, "Ir a una página de resultados.");
            this.cboPagina.SelectedIndexChanged += new System.EventHandler(this.cboPagina_SelectedIndexChanged);
            this.btnSiguiente.Location = new System.Drawing.Point(192, 3);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(90, 27);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.toolTipAyuda.SetToolTip(this.btnSiguiente, "Mostrar la página siguiente.");
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.flpNavegacion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCPaginadorGrid";
            this.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.Size = new System.Drawing.Size(800, 42);
            this.flpNavegacion.ResumeLayout(false);
            this.flpNavegacion.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
