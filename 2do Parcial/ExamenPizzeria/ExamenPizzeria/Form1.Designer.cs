namespace ExamenPizzeria
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDirrecion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.spnNumPizzas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPedido = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkChampinones = new System.Windows.Forms.CheckBox();
            this.chkPina = new System.Windows.Forms.CheckBox();
            this.chkJamon = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtGrande = new System.Windows.Forms.RadioButton();
            this.rbtMediana = new System.Windows.Forms.RadioButton();
            this.rbtChica = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstPizzas = new System.Windows.Forms.ListBox();
            this.btnMostrarls = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnNumPizzas)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizzeria \"SAN MARTIN\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDirrecion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(30, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(119, 95);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(162, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dirrecion";
            // 
            // txtDirrecion
            // 
            this.txtDirrecion.Location = new System.Drawing.Point(119, 69);
            this.txtDirrecion.Name = "txtDirrecion";
            this.txtDirrecion.Size = new System.Drawing.Size(162, 20);
            this.txtDirrecion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre completo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.spnNumPizzas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnPedido);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(30, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 200);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pizza Menu";
            // 
            // spnNumPizzas
            // 
            this.spnNumPizzas.Location = new System.Drawing.Point(101, 160);
            this.spnNumPizzas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spnNumPizzas.Name = "spnNumPizzas";
            this.spnNumPizzas.Size = new System.Drawing.Size(49, 20);
            this.spnNumPizzas.TabIndex = 21;
            this.spnNumPizzas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cantidad";
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(206, 152);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(75, 37);
            this.btnPedido.TabIndex = 19;
            this.btnPedido.Text = "Realizar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkChampinones);
            this.groupBox4.Controls.Add(this.chkPina);
            this.groupBox4.Controls.Add(this.chkJamon);
            this.groupBox4.Location = new System.Drawing.Point(157, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(124, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ingredientes:";
            // 
            // chkChampinones
            // 
            this.chkChampinones.AutoSize = true;
            this.chkChampinones.Location = new System.Drawing.Point(16, 77);
            this.chkChampinones.Name = "chkChampinones";
            this.chkChampinones.Size = new System.Drawing.Size(115, 17);
            this.chkChampinones.TabIndex = 5;
            this.chkChampinones.Text = "Chanpiñones - $10";
            this.chkChampinones.UseVisualStyleBackColor = true;
            // 
            // chkPina
            // 
            this.chkPina.AutoSize = true;
            this.chkPina.Location = new System.Drawing.Point(16, 54);
            this.chkPina.Name = "chkPina";
            this.chkPina.Size = new System.Drawing.Size(74, 17);
            this.chkPina.TabIndex = 4;
            this.chkPina.Text = "Piña - $10";
            this.chkPina.UseVisualStyleBackColor = true;
            // 
            // chkJamon
            // 
            this.chkJamon.AutoSize = true;
            this.chkJamon.Location = new System.Drawing.Point(16, 31);
            this.chkJamon.Name = "chkJamon";
            this.chkJamon.Size = new System.Drawing.Size(84, 17);
            this.chkJamon.TabIndex = 3;
            this.chkJamon.Text = "Jamon - $10";
            this.chkJamon.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtGrande);
            this.groupBox3.Controls.Add(this.rbtMediana);
            this.groupBox3.Controls.Add(this.rbtChica);
            this.groupBox3.Location = new System.Drawing.Point(26, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tamaño de Pizza";
            // 
            // rbtGrande
            // 
            this.rbtGrande.AutoSize = true;
            this.rbtGrande.Location = new System.Drawing.Point(16, 77);
            this.rbtGrande.Name = "rbtGrande";
            this.rbtGrande.Size = new System.Drawing.Size(87, 17);
            this.rbtGrande.TabIndex = 2;
            this.rbtGrande.TabStop = true;
            this.rbtGrande.Text = "Grande $120";
            this.rbtGrande.UseVisualStyleBackColor = true;
            // 
            // rbtMediana
            // 
            this.rbtMediana.AutoSize = true;
            this.rbtMediana.Location = new System.Drawing.Point(16, 54);
            this.rbtMediana.Name = "rbtMediana";
            this.rbtMediana.Size = new System.Drawing.Size(93, 17);
            this.rbtMediana.TabIndex = 1;
            this.rbtMediana.TabStop = true;
            this.rbtMediana.Text = "Mediana - $80";
            this.rbtMediana.UseVisualStyleBackColor = true;
            // 
            // rbtChica
            // 
            this.rbtChica.AutoSize = true;
            this.rbtChica.Location = new System.Drawing.Point(16, 31);
            this.rbtChica.Name = "rbtChica";
            this.rbtChica.Size = new System.Drawing.Size(79, 17);
            this.rbtChica.TabIndex = 0;
            this.rbtChica.TabStop = true;
            this.rbtChica.Text = "Chica - $40";
            this.rbtChica.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTotal);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lstPizzas);
            this.groupBox5.Controls.Add(this.btnMostrarls);
            this.groupBox5.Location = new System.Drawing.Point(372, 70);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(248, 324);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ordenes";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 277);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "00.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lista Pedidos";
            // 
            // lstPizzas
            // 
            this.lstPizzas.FormattingEnabled = true;
            this.lstPizzas.Location = new System.Drawing.Point(23, 41);
            this.lstPizzas.Name = "lstPizzas";
            this.lstPizzas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPizzas.Size = new System.Drawing.Size(204, 225);
            this.lstPizzas.Sorted = true;
            this.lstPizzas.TabIndex = 18;
            // 
            // btnMostrarls
            // 
            this.btnMostrarls.Location = new System.Drawing.Point(152, 275);
            this.btnMostrarls.Name = "btnMostrarls";
            this.btnMostrarls.Size = new System.Drawing.Size(75, 37);
            this.btnMostrarls.TabIndex = 15;
            this.btnMostrarls.Text = "Mostrar";
            this.btnMostrarls.UseVisualStyleBackColor = true;
            this.btnMostrarls.Click += new System.EventHandler(this.btnMostrarls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 452);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnNumPizzas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDirrecion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkChampinones;
        private System.Windows.Forms.CheckBox chkPina;
        private System.Windows.Forms.CheckBox chkJamon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtGrande;
        private System.Windows.Forms.RadioButton rbtMediana;
        private System.Windows.Forms.RadioButton rbtChica;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstPizzas;
        private System.Windows.Forms.Button btnMostrarls;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.NumericUpDown spnNumPizzas;
        private System.Windows.Forms.Label label5;
    }
}

