namespace Vista
{
    partial class UCEvidenciaTarea
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
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.lblIcono = new System.Windows.Forms.Label();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.tlpContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContenido
            // 
            this.tlpContenido.ColumnCount = 3;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpContenido.Controls.Add(this.lblIcono, 0, 0);
            this.tlpContenido.Controls.Add(this.lblArchivo, 1, 0);
            this.tlpContenido.Controls.Add(this.lblDetalle, 1, 1);
            this.tlpContenido.Controls.Add(this.btnVer, 2, 0);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(0, 0);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.RowCount = 2;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContenido.Size = new System.Drawing.Size(360, 68);
            this.tlpContenido.TabIndex = 0;
            // 
            // lblIcono
            // 
            this.lblIcono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIcono.Font = new System.Drawing.Font("Segoe UI Symbol", 16F);
            this.lblIcono.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblIcono.Location = new System.Drawing.Point(3, 0);
            this.lblIcono.Name = "lblIcono";
            this.tlpContenido.SetRowSpan(this.lblIcono, 2);
            this.lblIcono.Size = new System.Drawing.Size(38, 68);
            this.lblIcono.TabIndex = 0;
            this.lblIcono.Text = "▣";
            this.lblIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoEllipsis = true;
            this.lblArchivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArchivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblArchivo.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.lblArchivo.Location = new System.Drawing.Point(47, 0);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(242, 34);
            this.lblArchivo.TabIndex = 1;
            this.lblArchivo.Text = "informe_avance.pdf";
            this.lblArchivo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoEllipsis = true;
            this.lblDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(102, 118, 138);
            this.lblDetalle.Location = new System.Drawing.Point(47, 34);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(242, 34);
            this.lblDetalle.TabIndex = 2;
            this.lblDetalle.Text = "28 abr 2026  ·  250 KB";
            this.lblDetalle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btnVer
            // 
            this.btnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVer.BackColor = System.Drawing.Color.White;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVer.ForeColor = System.Drawing.Color.FromArgb(11, 55, 104);
            this.btnVer.Location = new System.Drawing.Point(300, 20);
            this.btnVer.Name = "btnVer";
            this.tlpContenido.SetRowSpan(this.btnVer, 2);
            this.btnVer.Size = new System.Drawing.Size(52, 28);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            // 
            // UCEvidenciaTarea
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tlpContenido);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.Name = "UCEvidenciaTarea";
            this.Size = new System.Drawing.Size(360, 68);
            this.tlpContenido.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.Label lblIcono;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Button btnVer;
    }
}
