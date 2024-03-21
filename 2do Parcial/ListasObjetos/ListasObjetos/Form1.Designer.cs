namespace ListasObjetos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.spnNumPistas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarcbo = new System.Windows.Forms.Button();
            this.btnEliminarcbo = new System.Windows.Forms.Button();
            this.cboListaDisco = new System.Windows.Forms.ComboBox();
            this.lstDiscos = new System.Windows.Forms.ListBox();
            this.btnMostrarVariosls = new System.Windows.Forms.Button();
            this.btnEliminarls = new System.Windows.Forms.Button();
            this.btnMostrarls = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnNumPistas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.spnNumPistas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFechaLanzamiento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtArtista);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Disco";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(397, 112);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(116, 116);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(69, 119);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio:";
            // 
            // spnNumPistas
            // 
            this.spnNumPistas.Location = new System.Drawing.Point(116, 75);
            this.spnNumPistas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spnNumPistas.Name = "spnNumPistas";
            this.spnNumPistas.Size = new System.Drawing.Size(99, 20);
            this.spnNumPistas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Lanzamiento";
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(373, 69);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaLanzamiento.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero de Pistas";
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(373, 34);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(100, 20);
            this.txtArtista.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artista:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(115, 34);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo del Disco";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostrarcbo);
            this.groupBox2.Controls.Add(this.btnEliminarcbo);
            this.groupBox2.Controls.Add(this.cboListaDisco);
            this.groupBox2.Controls.Add(this.lstDiscos);
            this.groupBox2.Controls.Add(this.btnMostrarVariosls);
            this.groupBox2.Controls.Add(this.btnEliminarls);
            this.groupBox2.Controls.Add(this.btnMostrarls);
            this.groupBox2.Location = new System.Drawing.Point(25, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Discos";
            // 
            // btnMostrarcbo
            // 
            this.btnMostrarcbo.Location = new System.Drawing.Point(331, 59);
            this.btnMostrarcbo.Name = "btnMostrarcbo";
            this.btnMostrarcbo.Size = new System.Drawing.Size(75, 37);
            this.btnMostrarcbo.TabIndex = 14;
            this.btnMostrarcbo.Text = "Mostrar Disco";
            this.btnMostrarcbo.UseVisualStyleBackColor = true;
            this.btnMostrarcbo.Click += new System.EventHandler(this.btnMostrarcbo_Click);
            // 
            // btnEliminarcbo
            // 
            this.btnEliminarcbo.Location = new System.Drawing.Point(419, 59);
            this.btnEliminarcbo.Name = "btnEliminarcbo";
            this.btnEliminarcbo.Size = new System.Drawing.Size(54, 37);
            this.btnEliminarcbo.TabIndex = 13;
            this.btnEliminarcbo.Text = "Eliminar";
            this.btnEliminarcbo.UseVisualStyleBackColor = true;
            this.btnEliminarcbo.Click += new System.EventHandler(this.btnEliminarcbo_Click);
            // 
            // cboListaDisco
            // 
            this.cboListaDisco.FormattingEnabled = true;
            this.cboListaDisco.Location = new System.Drawing.Point(331, 32);
            this.cboListaDisco.Name = "cboListaDisco";
            this.cboListaDisco.Size = new System.Drawing.Size(142, 21);
            this.cboListaDisco.TabIndex = 11;
            // 
            // lstDiscos
            // 
            this.lstDiscos.FormattingEnabled = true;
            this.lstDiscos.Location = new System.Drawing.Point(22, 32);
            this.lstDiscos.Name = "lstDiscos";
            this.lstDiscos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDiscos.Size = new System.Drawing.Size(194, 121);
            this.lstDiscos.Sorted = true;
            this.lstDiscos.TabIndex = 3;
            // 
            // btnMostrarVariosls
            // 
            this.btnMostrarVariosls.Location = new System.Drawing.Point(222, 75);
            this.btnMostrarVariosls.Name = "btnMostrarVariosls";
            this.btnMostrarVariosls.Size = new System.Drawing.Size(75, 37);
            this.btnMostrarVariosls.TabIndex = 2;
            this.btnMostrarVariosls.Text = "MostrarVarios Disco";
            this.btnMostrarVariosls.UseVisualStyleBackColor = true;
            this.btnMostrarVariosls.Click += new System.EventHandler(this.btnMostrarVariosls_Click);
            // 
            // btnEliminarls
            // 
            this.btnEliminarls.Location = new System.Drawing.Point(222, 118);
            this.btnEliminarls.Name = "btnEliminarls";
            this.btnEliminarls.Size = new System.Drawing.Size(75, 37);
            this.btnEliminarls.TabIndex = 1;
            this.btnEliminarls.Text = "Eliminar Disco";
            this.btnEliminarls.UseVisualStyleBackColor = true;
            this.btnEliminarls.Click += new System.EventHandler(this.btnEliminarls_Click);
            // 
            // btnMostrarls
            // 
            this.btnMostrarls.Location = new System.Drawing.Point(222, 32);
            this.btnMostrarls.Name = "btnMostrarls";
            this.btnMostrarls.Size = new System.Drawing.Size(75, 37);
            this.btnMostrarls.TabIndex = 0;
            this.btnMostrarls.Text = "Mostrar Disco";
            this.btnMostrarls.UseVisualStyleBackColor = true;
            this.btnMostrarls.Click += new System.EventHandler(this.btnMostrarls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 397);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Discos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnNumPistas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown spnNumPistas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrarVariosls;
        private System.Windows.Forms.Button btnEliminarls;
        private System.Windows.Forms.Button btnMostrarls;
        private System.Windows.Forms.ListBox lstDiscos;
        private System.Windows.Forms.Button btnMostrarcbo;
        private System.Windows.Forms.Button btnEliminarcbo;
        private System.Windows.Forms.ComboBox cboListaDisco;
    }
}

