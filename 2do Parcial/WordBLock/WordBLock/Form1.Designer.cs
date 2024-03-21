namespace WordBLock
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mbarMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemGuardarMismoNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemGuardarOtroNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mitemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemAtras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnucboFuente = new System.Windows.Forms.ToolStripComboBox();
            this.mnucboTam = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnitemEdicionCortar = new System.Windows.Forms.ToolStripButton();
            this.btnitemEdicionCopiar = new System.Windows.Forms.ToolStripButton();
            this.btnitemEdicionPegar = new System.Windows.Forms.ToolStripButton();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cnmitemCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.cnmitemCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.cnmitemPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.cnmitemAtras = new System.Windows.Forms.ToolStripMenuItem();
            this.btnitemEdicionVolver = new System.Windows.Forms.ToolStripButton();
            this.mbarMenuPrincipal.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbarMenuPrincipal
            // 
            this.mbarMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuEdicion,
            this.mnucboFuente,
            this.mnucboTam});
            this.mbarMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mbarMenuPrincipal.Name = "mbarMenuPrincipal";
            this.mbarMenuPrincipal.Size = new System.Drawing.Size(708, 27);
            this.mbarMenuPrincipal.TabIndex = 1;
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemAbrir,
            this.mitemGuardar,
            this.toolStripSeparator1,
            this.mitemSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(60, 23);
            this.mnuArchivo.Text = "Archivo";
            // 
            // mitemAbrir
            // 
            this.mitemAbrir.Image = global::WordBLock.Properties.Resources.file_1293983_640;
            this.mitemAbrir.Name = "mitemAbrir";
            this.mitemAbrir.Size = new System.Drawing.Size(116, 22);
            this.mitemAbrir.Tag = "dssd";
            this.mitemAbrir.Text = "Abrir...";
            this.mitemAbrir.Click += new System.EventHandler(this.mitemAbrir_Click);
            // 
            // mitemGuardar
            // 
            this.mitemGuardar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemGuardarMismoNombre,
            this.mitemGuardarOtroNombre});
            this.mitemGuardar.Image = global::WordBLock.Properties.Resources.floppy_disk_98413_640;
            this.mitemGuardar.Name = "mitemGuardar";
            this.mitemGuardar.Size = new System.Drawing.Size(116, 22);
            this.mitemGuardar.Text = "Guardar";
            // 
            // mitemGuardarMismoNombre
            // 
            this.mitemGuardarMismoNombre.Name = "mitemGuardarMismoNombre";
            this.mitemGuardarMismoNombre.Size = new System.Drawing.Size(158, 22);
            this.mitemGuardarMismoNombre.Text = "Mismo Nombre";
            // 
            // mitemGuardarOtroNombre
            // 
            this.mitemGuardarOtroNombre.Name = "mitemGuardarOtroNombre";
            this.mitemGuardarOtroNombre.Size = new System.Drawing.Size(158, 22);
            this.mitemGuardarOtroNombre.Text = "Otro Nombre";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // mitemSalir
            // 
            this.mitemSalir.Name = "mitemSalir";
            this.mitemSalir.Size = new System.Drawing.Size(116, 22);
            this.mitemSalir.Text = "Salir";
            this.mitemSalir.Click += new System.EventHandler(this.mitemSalir_Click);
            // 
            // mnuEdicion
            // 
            this.mnuEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemCortar,
            this.mitemCopiar,
            this.mitemPegar,
            this.mitemAtras});
            this.mnuEdicion.Name = "mnuEdicion";
            this.mnuEdicion.Size = new System.Drawing.Size(58, 23);
            this.mnuEdicion.Text = "Edición";
            // 
            // mitemCortar
            // 
            this.mitemCortar.Name = "mitemCortar";
            this.mitemCortar.Size = new System.Drawing.Size(180, 22);
            this.mitemCortar.Text = "Cortar";
            this.mitemCortar.Click += new System.EventHandler(this.mitemCortar_Click);
            // 
            // mitemCopiar
            // 
            this.mitemCopiar.Name = "mitemCopiar";
            this.mitemCopiar.Size = new System.Drawing.Size(180, 22);
            this.mitemCopiar.Text = "Copiar";
            this.mitemCopiar.Click += new System.EventHandler(this.mitemCopiar_Click);
            // 
            // mitemPegar
            // 
            this.mitemPegar.Name = "mitemPegar";
            this.mitemPegar.Size = new System.Drawing.Size(180, 22);
            this.mitemPegar.Text = "Pegar";
            this.mitemPegar.Click += new System.EventHandler(this.mitemPegar_Click);
            // 
            // mitemAtras
            // 
            this.mitemAtras.Name = "mitemAtras";
            this.mitemAtras.Size = new System.Drawing.Size(180, 22);
            this.mitemAtras.Text = "Atras";
            this.mitemAtras.Click += new System.EventHandler(this.mitemAtras_Click);
            // 
            // mnucboFuente
            // 
            this.mnucboFuente.Name = "mnucboFuente";
            this.mnucboFuente.Size = new System.Drawing.Size(121, 23);
            this.mnucboFuente.SelectedIndexChanged += new System.EventHandler(this.mnucboFuente_SelectedIndexChanged);
            // 
            // mnucboTam
            // 
            this.mnucboTam.Name = "mnucboTam";
            this.mnucboTam.Size = new System.Drawing.Size(121, 23);
            this.mnucboTam.SelectedIndexChanged += new System.EventHandler(this.mnucboTam_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnitemEdicionCortar,
            this.btnitemEdicionCopiar,
            this.btnitemEdicionPegar,
            this.btnitemEdicionVolver});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(708, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnitemEdicionCortar
            // 
            this.btnitemEdicionCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnitemEdicionCortar.Image = global::WordBLock.Properties.Resources.Cut_icon_icons_com_73697;
            this.btnitemEdicionCortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnitemEdicionCortar.Name = "btnitemEdicionCortar";
            this.btnitemEdicionCortar.Size = new System.Drawing.Size(23, 22);
            this.btnitemEdicionCortar.Text = "toolStripButton1";
            this.btnitemEdicionCortar.Click += new System.EventHandler(this.btnitemEdicionCortar_Click);
            // 
            // btnitemEdicionCopiar
            // 
            this.btnitemEdicionCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnitemEdicionCopiar.Image = global::WordBLock.Properties.Resources.copy_paste_documents_1580;
            this.btnitemEdicionCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnitemEdicionCopiar.Name = "btnitemEdicionCopiar";
            this.btnitemEdicionCopiar.Size = new System.Drawing.Size(23, 22);
            this.btnitemEdicionCopiar.Text = "toolStripButton2";
            this.btnitemEdicionCopiar.Click += new System.EventHandler(this.btnitemEdicionCopiar_Click);
            // 
            // btnitemEdicionPegar
            // 
            this.btnitemEdicionPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnitemEdicionPegar.Image = global::WordBLock.Properties.Resources.copy_paste_document_file_1557;
            this.btnitemEdicionPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnitemEdicionPegar.Name = "btnitemEdicionPegar";
            this.btnitemEdicionPegar.Size = new System.Drawing.Size(23, 22);
            this.btnitemEdicionPegar.Text = "toolStripButton1";
            this.btnitemEdicionPegar.Click += new System.EventHandler(this.btnitemEdicionPegar_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.AcceptsReturn = true;
            this.txtTexto.AcceptsTab = true;
            this.txtTexto.ContextMenuStrip = this.contextMenuStrip1;
            this.txtTexto.Location = new System.Drawing.Point(0, 52);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTexto.Size = new System.Drawing.Size(708, 252);
            this.txtTexto.TabIndex = 3;
            this.txtTexto.WordWrap = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cnmitemCortar,
            this.cnmitemCopiar,
            this.cnmitemPegar,
            this.cnmitemAtras});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 92);
            // 
            // cnmitemCortar
            // 
            this.cnmitemCortar.Name = "cnmitemCortar";
            this.cnmitemCortar.Size = new System.Drawing.Size(109, 22);
            this.cnmitemCortar.Text = "Cortar";
            this.cnmitemCortar.Click += new System.EventHandler(this.cnmitemCortar_Click);
            // 
            // cnmitemCopiar
            // 
            this.cnmitemCopiar.Name = "cnmitemCopiar";
            this.cnmitemCopiar.Size = new System.Drawing.Size(109, 22);
            this.cnmitemCopiar.Text = "Copiar";
            this.cnmitemCopiar.Click += new System.EventHandler(this.cnmitemCopiar_Click);
            // 
            // cnmitemPegar
            // 
            this.cnmitemPegar.Name = "cnmitemPegar";
            this.cnmitemPegar.Size = new System.Drawing.Size(109, 22);
            this.cnmitemPegar.Text = "Pegar";
            this.cnmitemPegar.Click += new System.EventHandler(this.cnmitemPegar_Click);
            // 
            // cnmitemAtras
            // 
            this.cnmitemAtras.Name = "cnmitemAtras";
            this.cnmitemAtras.Size = new System.Drawing.Size(109, 22);
            this.cnmitemAtras.Text = "Atras";
            this.cnmitemAtras.Click += new System.EventHandler(this.cnmitemAtras_Click);
            // 
            // btnitemEdicionVolver
            // 
            this.btnitemEdicionVolver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnitemEdicionVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnitemEdicionVolver.Image")));
            this.btnitemEdicionVolver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnitemEdicionVolver.Name = "btnitemEdicionVolver";
            this.btnitemEdicionVolver.Size = new System.Drawing.Size(23, 22);
            this.btnitemEdicionVolver.Text = "toolStripButton2";
            this.btnitemEdicionVolver.Click += new System.EventHandler(this.btnitemEdicionVolver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 305);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mbarMenuPrincipal);
            this.Name = "Form1";
            this.Text = "WordBlock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mbarMenuPrincipal.ResumeLayout(false);
            this.mbarMenuPrincipal.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mbarMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mitemAbrir;
        private System.Windows.Forms.ToolStripMenuItem mitemGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mitemSalir;
        private System.Windows.Forms.ToolStripMenuItem mitemGuardarMismoNombre;
        private System.Windows.Forms.ToolStripMenuItem mitemGuardarOtroNombre;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnitemEdicionCortar;
        private System.Windows.Forms.ToolStripButton btnitemEdicionCopiar;
        private System.Windows.Forms.ToolStripMenuItem mnuEdicion;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.ToolStripButton btnitemEdicionPegar;
        private System.Windows.Forms.ToolStripComboBox mnucboFuente;
        private System.Windows.Forms.ToolStripComboBox mnucboTam;
        private System.Windows.Forms.ToolStripMenuItem mitemCortar;
        private System.Windows.Forms.ToolStripMenuItem mitemCopiar;
        private System.Windows.Forms.ToolStripMenuItem mitemPegar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cnmitemCortar;
        private System.Windows.Forms.ToolStripMenuItem cnmitemCopiar;
        private System.Windows.Forms.ToolStripMenuItem cnmitemPegar;
        private System.Windows.Forms.ToolStripMenuItem mitemAtras;
        private System.Windows.Forms.ToolStripMenuItem cnmitemAtras;
        private System.Windows.Forms.ToolStripButton btnitemEdicionVolver;
    }
}

