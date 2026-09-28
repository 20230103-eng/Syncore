namespace Vista
{
    partial class UCPaginadorTarjetas
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
            this.tlpControles = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.cboPagina = new System.Windows.Forms.ComboBox();
            this.lblRango = new System.Windows.Forms.Label();
            this.tlpControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpControles
            // 
            this.tlpControles.Name = "tlpControles";
            this.tlpControles.ColumnCount = 4;
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControles.Controls.Add(this.btnAnterior, 0, 0);
            this.tlpControles.Controls.Add(this.cboPagina, 1, 0);
            this.tlpControles.Controls.Add(this.btnSiguiente, 2, 0);
            this.tlpControles.Controls.Add(this.lblRango, 3, 0);
            this.tlpControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControles.Margin = new System.Windows.Forms.Padding(0);
            this.tlpControles.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tlpControles.RowCount = 1;
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            // 
            // btnAnterior
            // 
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(1);
            this.btnAnterior.Text = "‹";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // cboPagina
            // 
            this.cboPagina.Name = "cboPagina";
            this.cboPagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPagina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPagina.Margin = new System.Windows.Forms.Padding(1, 4, 1, 1);
            this.cboPagina.SelectedIndexChanged += new System.EventHandler(this.cboPagina_SelectedIndexChanged);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(1);
            this.btnSiguiente.Text = "›";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblRango
            // 
            this.lblRango.Name = "lblRango";
            this.lblRango.AutoEllipsis = true;
            this.lblRango.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRango.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRango.ForeColor = System.Drawing.Color.FromArgb(48, 65, 82);
            this.lblRango.Text = "Sin registros";
            this.lblRango.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCPaginadorTarjetas";
            this.Height = 37;
            this.MinimumSize = new System.Drawing.Size(132, 34);
            // 
            // UCPaginadorTarjetas
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpControles);
            this.tlpControles.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpControles;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ComboBox cboPagina;
        private System.Windows.Forms.Label lblRango;
    }
}
