namespace Vista
{
    partial class frmPrincipal
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
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlSideNav = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.btnNotificacionesGestion = new System.Windows.Forms.Button();
            this.lblAdministracion = new System.Windows.Forms.Label();
            this.btnProductividad = new System.Windows.Forms.Button();
            this.lblProductividad = new System.Windows.Forms.Label();
            this.btnRevisionTareas = new System.Windows.Forms.Button();
            this.btnNuevaTarea = new System.Windows.Forms.Button();
            this.btnTableroTareas = new System.Windows.Forms.Button();
            this.lblTareas = new System.Windows.Forms.Label();
            this.btnCronograma = new System.Windows.Forms.Button();
            this.btnHitosEntregables = new System.Windows.Forms.Button();
            this.lblPlanificacion = new System.Windows.Forms.Label();
            this.btnNuevoProyecto = new System.Windows.Forms.Button();
            this.btnListadoProyectos = new System.Windows.Forms.Button();
            this.lblProyectos = new System.Windows.Forms.Label();
            this.btnPanelGestion = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.pnlTarjetaUsuario = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlLineaLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlSideNav.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlTarjetaUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(240, 0);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1670, 1061);
            this.pnlContenido.TabIndex = 1;
            // pnlSideNav
            // 
            this.pnlSideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.pnlSideNav.Controls.Add(this.pnlMenu);
            this.pnlSideNav.Controls.Add(this.pnlUsuario);
            this.pnlSideNav.Controls.Add(this.pnlLogo);
            this.pnlSideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideNav.Location = new System.Drawing.Point(0, 0);
            this.pnlSideNav.Name = "pnlSideNav";
            this.pnlSideNav.Size = new System.Drawing.Size(240, 1061);
            this.pnlSideNav.TabIndex = 0;
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.pnlMenu.Controls.Add(this.btnNotificacionesGestion);
            this.pnlMenu.Controls.Add(this.btnAdministracion);
            this.pnlMenu.Controls.Add(this.lblAdministracion);
            this.pnlMenu.Controls.Add(this.btnProductividad);
            this.pnlMenu.Controls.Add(this.lblProductividad);
            this.pnlMenu.Controls.Add(this.btnRevisionTareas);
            this.pnlMenu.Controls.Add(this.btnNuevaTarea);
            this.pnlMenu.Controls.Add(this.btnTableroTareas);
            this.pnlMenu.Controls.Add(this.lblTareas);
            this.pnlMenu.Controls.Add(this.btnCronograma);
            this.pnlMenu.Controls.Add(this.btnHitosEntregables);
            this.pnlMenu.Controls.Add(this.lblPlanificacion);
            this.pnlMenu.Controls.Add(this.btnNuevoProyecto);
            this.pnlMenu.Controls.Add(this.btnListadoProyectos);
            this.pnlMenu.Controls.Add(this.lblProyectos);
            this.pnlMenu.Controls.Add(this.btnPanelGestion);
            this.pnlMenu.Controls.Add(this.lblInicio);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 48);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 951);
            this.pnlMenu.TabIndex = 1;
            // btnAdministracion
            // 
            this.btnAdministracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.btnAdministracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministracion.FlatAppearance.BorderSize = 0;
            this.btnAdministracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnAdministracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdministracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnAdministracion.Image = global::Vista.Properties.Recursos.IconoEquipo;
            this.btnAdministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.Location = new System.Drawing.Point(0, 526);
            this.btnAdministracion.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnAdministracion.Size = new System.Drawing.Size(240, 34);
            this.btnAdministracion.TabIndex = 16;
            this.btnAdministracion.Text = "  Usuarios";
            this.btnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministracion.UseVisualStyleBackColor = false;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // btnNotificacionesGestion
            // 
            this.btnNotificacionesGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.btnNotificacionesGestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotificacionesGestion.FlatAppearance.BorderSize = 0;
            this.btnNotificacionesGestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnNotificacionesGestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnNotificacionesGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificacionesGestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNotificacionesGestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnNotificacionesGestion.Image = global::Vista.Properties.Recursos.IconoRevision;
            this.btnNotificacionesGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotificacionesGestion.Location = new System.Drawing.Point(0, 64);
            this.btnNotificacionesGestion.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnNotificacionesGestion.Name = "btnNotificacionesGestion";
            this.btnNotificacionesGestion.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNotificacionesGestion.Size = new System.Drawing.Size(240, 34);
            this.btnNotificacionesGestion.TabIndex = 17;
            this.btnNotificacionesGestion.Text = "  Notificaciones";
            this.btnNotificacionesGestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotificacionesGestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotificacionesGestion.UseVisualStyleBackColor = false;
            this.btnNotificacionesGestion.Click += new System.EventHandler(this.btnNotificacionesGestion_Click);
            // 
            // lblAdministracion
            // 
            this.lblAdministracion.AutoSize = true;
            this.lblAdministracion.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblAdministracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(226)))), ((int)(((byte)(241)))));
            this.lblAdministracion.Location = new System.Drawing.Point(14, 506);
            this.lblAdministracion.Name = "lblAdministracion";
            this.lblAdministracion.Size = new System.Drawing.Size(94, 13);
            this.lblAdministracion.TabIndex = 15;
            this.lblAdministracion.Text = "ADMINISTRACIÓN";
            // 
            // btnProductividad
            // 
            this.btnProductividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.btnProductividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductividad.FlatAppearance.BorderSize = 0;
            this.btnProductividad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnProductividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnProductividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductividad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductividad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnProductividad.Image = global::Vista.Properties.Recursos.IconoProductividad;
            this.btnProductividad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductividad.Location = new System.Drawing.Point(0, 462);
            this.btnProductividad.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnProductividad.Name = "btnProductividad";
            this.btnProductividad.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnProductividad.Size = new System.Drawing.Size(240, 34);
            this.btnProductividad.TabIndex = 14;
            this.btnProductividad.Text = "  Productividad general";
            this.btnProductividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductividad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductividad.UseVisualStyleBackColor = false;
            this.btnProductividad.Click += new System.EventHandler(this.btnProductividad_Click);
            // lblProductividad
            // 
            this.lblProductividad.AutoSize = true;
            this.lblProductividad.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductividad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(226)))), ((int)(((byte)(241)))));
            this.lblProductividad.Location = new System.Drawing.Point(14, 442);
            this.lblProductividad.Name = "lblProductividad";
            this.lblProductividad.Size = new System.Drawing.Size(93, 13);
            this.lblProductividad.TabIndex = 13;
            this.lblProductividad.Text = "PRODUCTIVIDAD";
            // btnRevisionTareas
            // 
            this.btnRevisionTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.btnRevisionTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevisionTareas.FlatAppearance.BorderSize = 0;
            this.btnRevisionTareas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnRevisionTareas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnRevisionTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisionTareas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRevisionTareas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnRevisionTareas.Image = global::Vista.Properties.Recursos.IconoRevision;
            this.btnRevisionTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevisionTareas.Location = new System.Drawing.Point(0, 398);
            this.btnRevisionTareas.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnRevisionTareas.Name = "btnRevisionTareas";
            this.btnRevisionTareas.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnRevisionTareas.Size = new System.Drawing.Size(240, 34);
            this.btnRevisionTareas.TabIndex = 12;
            this.btnRevisionTareas.Text = "  Revisión de tareas";
            this.btnRevisionTareas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevisionTareas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRevisionTareas.UseVisualStyleBackColor = false;
            this.btnRevisionTareas.Click += new System.EventHandler(this.btnRevisionTareas_Click);
            // btnNuevaTarea
            // 
            this.btnNuevaTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.btnNuevaTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaTarea.FlatAppearance.BorderSize = 0;
            this.btnNuevaTarea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnNuevaTarea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnNuevaTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaTarea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevaTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnNuevaTarea.Image = global::Vista.Properties.Recursos.IconoAgregar;
            this.btnNuevaTarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaTarea.Location = new System.Drawing.Point(0, 364);
            this.btnNuevaTarea.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnNuevaTarea.Name = "btnNuevaTarea";
            this.btnNuevaTarea.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNuevaTarea.Size = new System.Drawing.Size(240, 34);
            this.btnNuevaTarea.TabIndex = 11;
            this.btnNuevaTarea.Text = "  Nueva tarea";
            this.btnNuevaTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaTarea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaTarea.UseVisualStyleBackColor = false;
            this.btnNuevaTarea.Click += new System.EventHandler(this.btnNuevaTarea_Click);
            // btnTableroTareas
            // 
            this.btnTableroTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.btnTableroTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTableroTareas.FlatAppearance.BorderSize = 0;
            this.btnTableroTareas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnTableroTareas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnTableroTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableroTareas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTableroTareas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnTableroTareas.Image = global::Vista.Properties.Recursos.IconoTablero;
            this.btnTableroTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTableroTareas.Location = new System.Drawing.Point(0, 330);
            this.btnTableroTareas.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnTableroTareas.Name = "btnTableroTareas";
            this.btnTableroTareas.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnTableroTareas.Size = new System.Drawing.Size(240, 34);
            this.btnTableroTareas.TabIndex = 10;
            this.btnTableroTareas.Text = "  Tablero de tareas";
            this.btnTableroTareas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTableroTareas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTableroTareas.UseVisualStyleBackColor = false;
            this.btnTableroTareas.Click += new System.EventHandler(this.btnTableroTareas_Click);
            // lblTareas
            // 
            this.lblTareas.AutoSize = true;
            this.lblTareas.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTareas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(226)))), ((int)(((byte)(241)))));
            this.lblTareas.Location = new System.Drawing.Point(14, 310);
            this.lblTareas.Name = "lblTareas";
            this.lblTareas.Size = new System.Drawing.Size(44, 13);
            this.lblTareas.TabIndex = 9;
            this.lblTareas.Text = "TAREAS";
            // btnCronograma
            // 
            this.btnCronograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.btnCronograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCronograma.FlatAppearance.BorderSize = 0;
            this.btnCronograma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnCronograma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnCronograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCronograma.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCronograma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnCronograma.Image = global::Vista.Properties.Recursos.IconoCalendario;
            this.btnCronograma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCronograma.Location = new System.Drawing.Point(0, 266);
            this.btnCronograma.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnCronograma.Name = "btnCronograma";
            this.btnCronograma.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnCronograma.Size = new System.Drawing.Size(240, 34);
            this.btnCronograma.TabIndex = 8;
            this.btnCronograma.Text = "  Cronograma";
            this.btnCronograma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCronograma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCronograma.UseVisualStyleBackColor = false;
            this.btnCronograma.Click += new System.EventHandler(this.btnCronograma_Click);
            // btnHitosEntregables
            // 
            this.btnHitosEntregables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.btnHitosEntregables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHitosEntregables.FlatAppearance.BorderSize = 0;
            this.btnHitosEntregables.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnHitosEntregables.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnHitosEntregables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHitosEntregables.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHitosEntregables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnHitosEntregables.Image = global::Vista.Properties.Recursos.IconoHitos;
            this.btnHitosEntregables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHitosEntregables.Location = new System.Drawing.Point(0, 226);
            this.btnHitosEntregables.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnHitosEntregables.Name = "btnHitosEntregables";
            this.btnHitosEntregables.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnHitosEntregables.Size = new System.Drawing.Size(240, 34);
            this.btnHitosEntregables.TabIndex = 6;
            this.btnHitosEntregables.Text = "  Hitos y entregables";
            this.btnHitosEntregables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHitosEntregables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHitosEntregables.UseVisualStyleBackColor = false;
            this.btnHitosEntregables.Click += new System.EventHandler(this.btnHitosEntregables_Click);
            // lblPlanificacion
            // 
            this.lblPlanificacion.AutoSize = true;
            this.lblPlanificacion.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblPlanificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(226)))), ((int)(((byte)(241)))));
            this.lblPlanificacion.Location = new System.Drawing.Point(14, 206);
            this.lblPlanificacion.Name = "lblPlanificacion";
            this.lblPlanificacion.Size = new System.Drawing.Size(86, 13);
            this.lblPlanificacion.TabIndex = 5;
            this.lblPlanificacion.Text = "PLANIFICACIÓN";
            // btnNuevoProyecto
            // 
            this.btnNuevoProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.btnNuevoProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoProyecto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnNuevoProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnNuevoProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProyecto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevoProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnNuevoProyecto.Image = global::Vista.Properties.Recursos.IconoAgregar;
            this.btnNuevoProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoProyecto.Location = new System.Drawing.Point(0, 162);
            this.btnNuevoProyecto.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnNuevoProyecto.Name = "btnNuevoProyecto";
            this.btnNuevoProyecto.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNuevoProyecto.Size = new System.Drawing.Size(240, 34);
            this.btnNuevoProyecto.TabIndex = 4;
            this.btnNuevoProyecto.Text = "  Nuevo proyecto";
            this.btnNuevoProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoProyecto.UseVisualStyleBackColor = false;
            this.btnNuevoProyecto.Click += new System.EventHandler(this.btnNuevoProyecto_Click);
            // btnListadoProyectos
            // 
            this.btnListadoProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.btnListadoProyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListadoProyectos.FlatAppearance.BorderSize = 0;
            this.btnListadoProyectos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnListadoProyectos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnListadoProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoProyectos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnListadoProyectos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnListadoProyectos.Image = global::Vista.Properties.Recursos.IconoProyectos;
            this.btnListadoProyectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoProyectos.Location = new System.Drawing.Point(0, 128);
            this.btnListadoProyectos.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnListadoProyectos.Name = "btnListadoProyectos";
            this.btnListadoProyectos.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnListadoProyectos.Size = new System.Drawing.Size(240, 34);
            this.btnListadoProyectos.TabIndex = 3;
            this.btnListadoProyectos.Text = "  Listado de proyectos";
            this.btnListadoProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoProyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListadoProyectos.UseVisualStyleBackColor = false;
            this.btnListadoProyectos.Click += new System.EventHandler(this.btnListadoProyectos_Click);
            // lblProyectos
            // 
            this.lblProyectos.AutoSize = true;
            this.lblProyectos.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblProyectos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(226)))), ((int)(((byte)(241)))));
            this.lblProyectos.Location = new System.Drawing.Point(14, 108);
            this.lblProyectos.Name = "lblProyectos";
            this.lblProyectos.Size = new System.Drawing.Size(66, 13);
            this.lblProyectos.TabIndex = 2;
            this.lblProyectos.Text = "PROYECTOS";
            // btnPanelGestion
            // 
            this.btnPanelGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(251)))));
            this.btnPanelGestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPanelGestion.FlatAppearance.BorderSize = 0;
            this.btnPanelGestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.btnPanelGestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            this.btnPanelGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelGestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPanelGestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(95)))), ((int)(((byte)(173)))));
            this.btnPanelGestion.Image = global::Vista.Properties.Recursos.IconoPanelSeleccionado;
            this.btnPanelGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelGestion.Location = new System.Drawing.Point(0, 30);
            this.btnPanelGestion.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnPanelGestion.Name = "btnPanelGestion";
            this.btnPanelGestion.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnPanelGestion.Size = new System.Drawing.Size(240, 34);
            this.btnPanelGestion.TabIndex = 1;
            this.btnPanelGestion.Text = "  Panel de gestión";
            this.btnPanelGestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelGestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPanelGestion.UseVisualStyleBackColor = false;
            this.btnPanelGestion.Click += new System.EventHandler(this.btnPanelGestion_Click);
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(226)))), ((int)(((byte)(241)))));
            this.lblInicio.Location = new System.Drawing.Point(14, 10);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(40, 13);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "INICIO";
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.pnlUsuario.Controls.Add(this.pnlTarjetaUsuario);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 999);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(240, 62);
            this.pnlUsuario.TabIndex = 2;
            // pnlTarjetaUsuario
            // 
            this.pnlTarjetaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pnlTarjetaUsuario.Controls.Add(this.btnCerrarSesion);
            this.pnlTarjetaUsuario.Controls.Add(this.lblRolUsuario);
            this.pnlTarjetaUsuario.Controls.Add(this.lblNombreUsuario);
            this.pnlTarjetaUsuario.Controls.Add(this.picUsuario);
            this.pnlTarjetaUsuario.Location = new System.Drawing.Point(8, 7);
            this.pnlTarjetaUsuario.Name = "pnlTarjetaUsuario";
            this.pnlTarjetaUsuario.Size = new System.Drawing.Size(224, 48);
            this.pnlTarjetaUsuario.TabIndex = 0;
            this.pnlTarjetaUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTarjetaUsuario_Paint);
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Image = global::Vista.Properties.Recursos.IconoSalir;
            this.btnCerrarSesion.Location = new System.Drawing.Point(184, 8);
            this.btnCerrarSesion.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(32, 32);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblRolUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(211)))), ((int)(((byte)(232)))));
            this.lblRolUsuario.Location = new System.Drawing.Point(40, 25);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(98, 12);
            this.lblRolUsuario.TabIndex = 2;
            this.lblRolUsuario.Text = "Gestor";
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(40, 9);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(62, 15);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Juan Pérez";
            // picUsuario
            // 
            this.picUsuario.Image = global::Vista.Properties.Recursos.IconoUsuario;
            this.picUsuario.Location = new System.Drawing.Point(8, 10);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(28, 28);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuario.TabIndex = 0;
            this.picUsuario.TabStop = false;
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.pnlLogo.Controls.Add(this.pnlLineaLogo);
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(240, 48);
            this.pnlLogo.TabIndex = 0;
            // pnlLineaLogo
            // 
            this.pnlLineaLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(169)))), ((int)(((byte)(225)))));
            this.pnlLineaLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLineaLogo.Location = new System.Drawing.Point(0, 46);
            this.pnlLineaLogo.Name = "pnlLineaLogo";
            this.pnlLineaLogo.Size = new System.Drawing.Size(240, 2);
            this.pnlLineaLogo.TabIndex = 1;
            // picLogo
            // 
            this.picLogo.Image = global::Vista.Properties.Recursos.LogoSyncore;
            this.picLogo.Location = new System.Drawing.Point(8, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(104, 34);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1910, 1061);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlSideNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syncore - Gestión de proyectos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlSideNav.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlTarjetaUsuario.ResumeLayout(false);
            this.pnlTarjetaUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlSideNav;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Button btnNotificacionesGestion;
        private System.Windows.Forms.Label lblAdministracion;
        private System.Windows.Forms.Button btnProductividad;
        private System.Windows.Forms.Label lblProductividad;
        private System.Windows.Forms.Button btnRevisionTareas;
        private System.Windows.Forms.Button btnNuevaTarea;
        private System.Windows.Forms.Button btnTableroTareas;
        private System.Windows.Forms.Label lblTareas;
        private System.Windows.Forms.Button btnCronograma;
        private System.Windows.Forms.Button btnHitosEntregables;
        private System.Windows.Forms.Label lblPlanificacion;
        private System.Windows.Forms.Button btnNuevoProyecto;
        private System.Windows.Forms.Button btnListadoProyectos;
        private System.Windows.Forms.Label lblProyectos;
        private System.Windows.Forms.Button btnPanelGestion;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel pnlTarjetaUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlLineaLogo;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
