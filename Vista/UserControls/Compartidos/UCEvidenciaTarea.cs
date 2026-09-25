﻿using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCEvidenciaTarea : UserControl
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;

        public int IdEvidencia { get; set; }

        public string RutaArchivo { get; set; }

        public UCEvidenciaTarea()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            toolTipAyuda.SetToolTip(btnVer, "Ver el detalle del registro.");
            btnVer.Click += btnVer_Click;
        }

        public string NombreArchivo
        {
            get
            {
                return lblArchivo.Text;
            }
            set
            {
                lblArchivo.Text = value;
            }
        }

        public string DetalleArchivo
        {
            get
            {
                return lblDetalle.Text;
            }
            set
            {
                lblDetalle.Text = value;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RutaArchivo) == true)
            {
                MessageBox.Show("La evidencia no tiene una ruta registrada.");
                return;
            }

            if (File.Exists(RutaArchivo) == false)
            {
                MessageBox.Show("No se encontró el archivo de evidencia en la ruta registrada.");
                return;
            }

            Process.Start(RutaArchivo);
        }
    }
}
