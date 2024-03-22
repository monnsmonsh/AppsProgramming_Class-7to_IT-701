namespace MenusBarraHerramientas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mbarMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mitemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.n = new System.Windows.Forms.ToolStripMenuItem();
            this.fuente2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuente3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.opción1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opción2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opción3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.mbarMenuPrincipal.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbarMenuPrincipal
            // 
            this.mbarMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuEdicion});
            this.mbarMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mbarMenuPrincipal.Name = "mbarMenuPrincipal";
            this.mbarMenuPrincipal.Size = new System.Drawing.Size(747, 24);
            this.mbarMenuPrincipal.TabIndex = 0;
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemAbrir,
            this.mitemGuardar,
            this.toolStripSeparator1,
            this.mitemSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnuArchivo.Text = "Archivo";
            // 
            // mitemAbrir
            // 
            this.mitemAbrir.Image = global::MenusBarraHerramientas.Properties.Resources.UTL;
            this.mitemAbrir.Name = "mitemAbrir";
            this.mitemAbrir.Size = new System.Drawing.Size(180, 22);
            this.mitemAbrir.Text = "Abrir...";
            this.mitemAbrir.Click += new System.EventHandler(this.mitemAbrir_Click);
            // 
            // mitemGuardar
            // 
            this.mitemGuardar.Image = global::MenusBarraHerramientas.Properties.Resources.x2;
            this.mitemGuardar.Name = "mitemGuardar";
            this.mitemGuardar.Size = new System.Drawing.Size(180, 22);
            this.mitemGuardar.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mitemSalir
            // 
            this.mitemSalir.Name = "mitemSalir";
            this.mitemSalir.Size = new System.Drawing.Size(180, 22);
            this.mitemSalir.Text = "Salir";
            this.mitemSalir.Click += new System.EventHandler(this.mitemSalir_Click);
            // 
            // mnuEdicion
            // 
            this.mnuEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemFuente,
            this.toolStripComboBox1,
            this.toolStripTextBox1});
            this.mnuEdicion.Name = "mnuEdicion";
            this.mnuEdicion.Size = new System.Drawing.Size(58, 20);
            this.mnuEdicion.Text = "Edición";
            // 
            // mitemFuente
            // 
            this.mitemFuente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.n,
            this.fuente2ToolStripMenuItem,
            this.fuente3ToolStripMenuItem});
            this.mitemFuente.Name = "mitemFuente";
            this.mitemFuente.Size = new System.Drawing.Size(181, 22);
            this.mitemFuente.Text = "Fuente";
            // 
            // n
            // 
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(119, 22);
            this.n.Text = "Fuente 1";
            // 
            // fuente2ToolStripMenuItem
            // 
            this.fuente2ToolStripMenuItem.Name = "fuente2ToolStripMenuItem";
            this.fuente2ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.fuente2ToolStripMenuItem.Text = "Fuente 2";
            // 
            // fuente3ToolStripMenuItem
            // 
            this.fuente3ToolStripMenuItem.Name = "fuente3ToolStripMenuItem";
            this.fuente3ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.fuente3ToolStripMenuItem.Text = "Fuente 3";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripLabel1,
            this.toolStripSplitButton1,
            this.toolStripSeparator2,
            this.toolStripComboBox2,
            this.toolStripComboBox3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(747, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opción1ToolStripMenuItem,
            this.opción2ToolStripMenuItem,
            this.opción3ToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // opción1ToolStripMenuItem
            // 
            this.opción1ToolStripMenuItem.Name = "opción1ToolStripMenuItem";
            this.opción1ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.opción1ToolStripMenuItem.Text = "Opción 1";
            // 
            // opción2ToolStripMenuItem
            // 
            this.opción2ToolStripMenuItem.Name = "opción2ToolStripMenuItem";
            this.opción2ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.opción2ToolStripMenuItem.Text = "Opción 2";
            // 
            // opción3ToolStripMenuItem
            // 
            this.opción3ToolStripMenuItem.Name = "opción3ToolStripMenuItem";
            this.opción3ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.opción3ToolStripMenuItem.Text = "Opción 3";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 380);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mbarMenuPrincipal);
            this.MainMenuStrip = this.mbarMenuPrincipal;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mbarMenuPrincipal.ResumeLayout(false);
            this.mbarMenuPrincipal.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem mnuEdicion;
        private System.Windows.Forms.ToolStripMenuItem mitemFuente;
        private System.Windows.Forms.ToolStripMenuItem n;
        private System.Windows.Forms.ToolStripMenuItem fuente2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuente3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem opción1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opción2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opción3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
    }
}

