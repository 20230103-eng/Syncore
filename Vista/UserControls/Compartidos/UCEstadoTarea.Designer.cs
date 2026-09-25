namespace Vista
{
    partial class UCEstadoTarea
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
            this.tlpEstado = new System.Windows.Forms.TableLayoutPanel();
            this.lblEstadoTitulo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblAvanceTitulo = new System.Windows.Forms.Label();
            this.lblAvance = new System.Windows.Forms.Label();
            this.lblVencimientoTitulo = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblPrioridadTitulo = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblEvidenciaTitulo = new System.Windows.Forms.Label();
            this.lblEvidencia = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
            this.tlpEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpEstado
            // 
            this.tlpEstado.ColumnCount = 2;
            this.tlpEstado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tlpEstado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tlpEstado.Controls.Add(this.lblEstadoTitulo, 0, 0);
            this.tlpEstado.Controls.Add(this.lblEstado, 1, 0);
            this.tlpEstado.Controls.Add(this.lblAvanceTitulo, 0, 1);
            this.tlpEstado.Controls.Add(this.lblAvance, 1, 1);
            this.tlpEstado.Controls.Add(this.lblVencimientoTitulo, 0, 2);
            this.tlpEstado.Controls.Add(this.lblVencimiento, 1, 2);
            this.tlpEstado.Controls.Add(this.lblPrioridadTitulo, 0, 3);
            this.tlpEstado.Controls.Add(this.lblPrioridad, 1, 3);
            this.tlpEstado.Controls.Add(this.lblEvidenciaTitulo, 0, 4);
            this.tlpEstado.Controls.Add(this.lblEvidencia, 1, 4);
            this.tlpEstado.Controls.Add(this.btnAccion, 0, 5);
            this.tlpEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEstado.Location = new System.Drawing.Point(0, 0);
            this.tlpEstado.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEstado.Name = "tlpEstado";
            this.tlpEstado.RowCount = 6;
            this.tlpEstado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEstado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEstado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEstado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEstado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEstado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpEstado.SetColumnSpan(this.btnAccion, 2);
            this.tlpEstado.Size = new System.Drawing.Size(360, 192);
            this.tlpEstado.TabIndex = 0;
            // 
            // lblEstadoTitulo
            // 
            this.lblEstadoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstadoTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstadoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblEstadoTitulo.Location = new System.Drawing.Point(10, 0);
            this.lblEstadoTitulo.Margin = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.lblEstadoTitulo.Name = "lblEstadoTitulo";
            this.lblEstadoTitulo.Size = new System.Drawing.Size(160, 30);
            this.lblEstadoTitulo.TabIndex = 0;
            this.lblEstadoTitulo.Text = "Estado actual";
            this.lblEstadoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.lblEstado.Location = new System.Drawing.Point(269, 4);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 10, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblEstado.Size = new System.Drawing.Size(81, 22);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "En progreso";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvanceTitulo
            // 
            this.lblAvanceTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvanceTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvanceTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblAvanceTitulo.Location = new System.Drawing.Point(10, 30);
            this.lblAvanceTitulo.Margin = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.lblAvanceTitulo.Name = "lblAvanceTitulo";
            this.lblAvanceTitulo.Size = new System.Drawing.Size(160, 30);
            this.lblAvanceTitulo.TabIndex = 2;
            this.lblAvanceTitulo.Text = "Avance";
            this.lblAvanceTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAvance
            // 
            this.lblAvance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAvance.AutoSize = true;
            this.lblAvance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblAvance.Location = new System.Drawing.Point(318, 37);
            this.lblAvance.Margin = new System.Windows.Forms.Padding(2, 0, 10, 0);
            this.lblAvance.Name = "lblAvance";
            this.lblAvance.Size = new System.Drawing.Size(32, 15);
            this.lblAvance.TabIndex = 3;
            this.lblAvance.Text = "60%";
            this.lblAvance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVencimientoTitulo
            // 
            this.lblVencimientoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVencimientoTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVencimientoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblVencimientoTitulo.Location = new System.Drawing.Point(10, 60);
            this.lblVencimientoTitulo.Margin = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.lblVencimientoTitulo.Name = "lblVencimientoTitulo";
            this.lblVencimientoTitulo.Size = new System.Drawing.Size(160, 30);
            this.lblVencimientoTitulo.TabIndex = 4;
            this.lblVencimientoTitulo.Text = "Vencimiento";
            this.lblVencimientoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVencimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.lblVencimiento.Location = new System.Drawing.Point(326, 67);
            this.lblVencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 10, 0);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(24, 15);
            this.lblVencimiento.TabIndex = 5;
            this.lblVencimiento.Text = "Hoy";
            this.lblVencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrioridadTitulo
            // 
            this.lblPrioridadTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrioridadTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrioridadTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblPrioridadTitulo.Location = new System.Drawing.Point(10, 90);
            this.lblPrioridadTitulo.Margin = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.lblPrioridadTitulo.Name = "lblPrioridadTitulo";
            this.lblPrioridadTitulo.Size = new System.Drawing.Size(160, 30);
            this.lblPrioridadTitulo.TabIndex = 6;
            this.lblPrioridadTitulo.Text = "Prioridad";
            this.lblPrioridadTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.lblPrioridad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrioridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.lblPrioridad.Location = new System.Drawing.Point(314, 94);
            this.lblPrioridad.Margin = new System.Windows.Forms.Padding(2, 0, 10, 0);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblPrioridad.Size = new System.Drawing.Size(36, 22);
            this.lblPrioridad.TabIndex = 7;
            this.lblPrioridad.Text = "Alta";
            this.lblPrioridad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEvidenciaTitulo
            // 
            this.lblEvidenciaTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEvidenciaTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEvidenciaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.lblEvidenciaTitulo.Location = new System.Drawing.Point(10, 120);
            this.lblEvidenciaTitulo.Margin = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.lblEvidenciaTitulo.Name = "lblEvidenciaTitulo";
            this.lblEvidenciaTitulo.Size = new System.Drawing.Size(160, 30);
            this.lblEvidenciaTitulo.TabIndex = 8;
            this.lblEvidenciaTitulo.Text = "Evidencias";
            this.lblEvidenciaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEvidencia
            // 
            this.lblEvidencia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEvidencia.AutoSize = true;
            this.lblEvidencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEvidencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.lblEvidencia.Location = new System.Drawing.Point(294, 127);
            this.lblEvidencia.Margin = new System.Windows.Forms.Padding(2, 0, 10, 0);
            this.lblEvidencia.Name = "lblEvidencia";
            this.lblEvidencia.Size = new System.Drawing.Size(56, 15);
            this.lblEvidencia.TabIndex = 9;
            this.lblEvidencia.Text = "1 archivo";
            this.lblEvidencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAccion
            // 
            this.btnAccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(101)))), ((int)(((byte)(176)))));
            this.btnAccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccion.FlatAppearance.BorderSize = 0;
            this.btnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAccion.ForeColor = System.Drawing.Color.White;
            this.btnAccion.Location = new System.Drawing.Point(10, 156);
            this.btnAccion.Margin = new System.Windows.Forms.Padding(10, 6, 10, 8);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(340, 28);
            this.btnAccion.TabIndex = 10;
            this.btnAccion.Text = "Actualizar avance";
            this.btnAccion.UseVisualStyleBackColor = false;
            // 
            // UCEstadoTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpEstado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCEstadoTarea";
            this.Size = new System.Drawing.Size(360, 192);
            this.tlpEstado.ResumeLayout(false);
            this.tlpEstado.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEstado;
        private System.Windows.Forms.Label lblEstadoTitulo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblAvanceTitulo;
        private System.Windows.Forms.Label lblAvance;
        private System.Windows.Forms.Label lblVencimientoTitulo;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblPrioridadTitulo;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblEvidenciaTitulo;
        private System.Windows.Forms.Label lblEvidencia;
        private System.Windows.Forms.Button btnAccion;
    }
}
