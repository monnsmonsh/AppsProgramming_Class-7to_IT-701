namespace Vista
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblIdDiscoVal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spnNumPistas = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btbCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.dtpFechaL = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnNumPistas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDiscos);
            this.groupBox2.Location = new System.Drawing.Point(28, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 183);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla de Discos";
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.AllowUserToAddRows = false;
            this.dgvDiscos.AllowUserToDeleteRows = false;
            this.dgvDiscos.AllowUserToOrderColumns = true;
            this.dgvDiscos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.Location = new System.Drawing.Point(25, 19);
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscos.Size = new System.Drawing.Size(499, 158);
            this.dgvDiscos.TabIndex = 2;
            this.dgvDiscos.DoubleClick += new System.EventHandler(this.dgvDiscos_DoubleClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(498, 448);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(378, 448);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.lblIdDiscoVal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.spnNumPistas);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btbCancelar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.dtpFechaL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtArtista);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 198);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Disco";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(356, 145);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblIdDiscoVal
            // 
            this.lblIdDiscoVal.AutoSize = true;
            this.lblIdDiscoVal.Location = new System.Drawing.Point(122, 41);
            this.lblIdDiscoVal.Name = "lblIdDiscoVal";
            this.lblIdDiscoVal.Size = new System.Drawing.Size(25, 13);
            this.lblIdDiscoVal.TabIndex = 15;
            this.lblIdDiscoVal.Text = "------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "id Disco:";
            // 
            // spnNumPistas
            // 
            this.spnNumPistas.Location = new System.Drawing.Point(389, 64);
            this.spnNumPistas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spnNumPistas.Name = "spnNumPistas";
            this.spnNumPistas.Size = new System.Drawing.Size(135, 20);
            this.spnNumPistas.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(449, 145);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btbCancelar
            // 
            this.btbCancelar.Location = new System.Drawing.Point(356, 145);
            this.btbCancelar.Name = "btbCancelar";
            this.btbCancelar.Size = new System.Drawing.Size(75, 23);
            this.btbCancelar.TabIndex = 11;
            this.btbCancelar.Text = "Cancelar";
            this.btbCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de Estreno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero de Pistas:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(389, 90);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(135, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(389, 38);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(135, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // dtpFechaL
            // 
            this.dtpFechaL.Location = new System.Drawing.Point(122, 93);
            this.dtpFechaL.Name = "dtpFechaL";
            this.dtpFechaL.Size = new System.Drawing.Size(135, 20);
            this.dtpFechaL.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Artista:";
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(122, 66);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(135, 20);
            this.txtArtista.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Catalogo de Discos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnNumPistas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIdDiscoVal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown spnNumPistas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btbCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
    }
}

