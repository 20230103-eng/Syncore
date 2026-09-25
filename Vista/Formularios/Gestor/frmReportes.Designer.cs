namespace Vista
{
    partial class frmReportes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox cboReporte;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.DataGridView dgvReporte;
        private Vista.UCPaginadorGrid ucPaginador;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnCerrar;

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
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cboReporte = new System.Windows.Forms.ComboBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.ucPaginador = new Vista.UCPaginadorGrid();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlCabecera.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            this.pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.pnlPie.SuspendLayout();
            this.SuspendLayout();

            this.pnlCabecera.BackColor = System.Drawing.Color.White;
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Height = 100;
            this.pnlCabecera.Padding = new System.Windows.Forms.Padding(20, 14, 20, 8);
            this.pnlCabecera.Controls.Add(this.lblDescripcion);
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 61, 117);
            this.lblTitulo.Location = new System.Drawing.Point(20, 12);
            this.lblTitulo.Text = "Reportes de gestión";
            this.lblDescripcion.AutoEllipsis = true;
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDescripcion.Height = 27;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(70, 86, 108);
            this.lblDescripcion.Text = "Seleccione un reporte para consultar sus datos.";

            this.tlpFiltros.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.tlpFiltros.ColumnCount = 3;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFiltros.RowCount = 2;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpFiltros.Height = 84;
            this.tlpFiltros.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.tlpFiltros.Controls.Add(this.lblTipo, 0, 0);
            this.tlpFiltros.Controls.Add(this.lblPeriodo, 1, 0);
            this.tlpFiltros.Controls.Add(this.cboReporte, 0, 1);
            this.tlpFiltros.Controls.Add(this.cboPeriodo, 1, 1);
            this.tlpFiltros.Controls.Add(this.btnActualizar, 2, 1);
            this.lblTipo.Text = "Tipo de reporte";
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPeriodo.Text = "Periodo de productividad";
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cboReporte.Name = "cboReporte";
            this.cboReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboReporte.SelectedIndexChanged += new System.EventHandler(this.cboReporte_SelectedIndexChanged);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            this.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabla.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.pnlTabla.Controls.Add(this.dgvReporte);
            this.pnlTabla.Controls.Add(this.ucPaginador);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporte.AllowUserToAddRows = false;
            this.dgvReporte.AllowUserToDeleteRows = false;
            this.dgvReporte.ReadOnly = true;
            this.dgvReporte.RowHeadersVisible = false;
            this.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporte.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Height = 66;
            this.pnlPie.BackColor = System.Drawing.Color.White;
            this.pnlPie.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.pnlPie.Controls.Add(this.lblTotal);
            this.pnlPie.Controls.Add(this.btnExportar);
            this.pnlPie.Controls.Add(this.btnCerrar);
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotal.Text = "0 registros";
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(70, 86, 108);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportar.Width = 154;
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(0, 61, 117);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Width = 112;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            this.ucPaginador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPaginador.Location = new System.Drawing.Point(0, 0);
            this.ucPaginador.Margin = new System.Windows.Forms.Padding(0);
            this.ucPaginador.Name = "ucPaginador";
            this.ucPaginador.Size = new System.Drawing.Size(800, 42);
            this.ucPaginador.TabIndex = 20;
            this.ucPaginador.Visible = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 680);
            this.MinimumSize = new System.Drawing.Size(710, 480);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syncore - Reportes";
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.Controls.Add(this.pnlTabla);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.tlpFiltros);
            this.Controls.Add(this.pnlCabecera);
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.tlpFiltros.ResumeLayout(false);
            this.tlpFiltros.PerformLayout();
            this.pnlTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.pnlPie.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
