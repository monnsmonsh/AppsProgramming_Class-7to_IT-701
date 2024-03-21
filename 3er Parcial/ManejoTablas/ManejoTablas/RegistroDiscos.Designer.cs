namespace ManejoTablas
{
    partial class RegistroDiscos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spnNumPistas = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btbCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.dtpFechaE = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblDiscos = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumPistas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPortada = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.picBxPortada = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnNumPistas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExaminar);
            this.groupBox1.Controls.Add(this.spnNumPistas);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btbCancelar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.dtpFechaE);
            this.groupBox1.Controls.Add(this.picBxPortada);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtArtista);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Disco";
            // 
            // spnNumPistas
            // 
            this.spnNumPistas.Location = new System.Drawing.Point(142, 83);
            this.spnNumPistas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spnNumPistas.Name = "spnNumPistas";
            this.spnNumPistas.Size = new System.Drawing.Size(174, 20);
            this.spnNumPistas.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(241, 173);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btbCancelar
            // 
            this.btbCancelar.Location = new System.Drawing.Point(160, 173);
            this.btbCancelar.Name = "btbCancelar";
            this.btbCancelar.Size = new System.Drawing.Size(75, 23);
            this.btbCancelar.TabIndex = 11;
            this.btbCancelar.Text = "Cancelar";
            this.btbCancelar.UseVisualStyleBackColor = true;
            this.btbCancelar.Click += new System.EventHandler(this.btbCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de Estreno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero de Pistas:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(142, 136);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(174, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(142, 31);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(174, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // dtpFechaE
            // 
            this.dtpFechaE.Location = new System.Drawing.Point(142, 110);
            this.dtpFechaE.Name = "dtpFechaE";
            this.dtpFechaE.Size = new System.Drawing.Size(174, 20);
            this.dtpFechaE.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Artista:";
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(142, 57);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(174, 20);
            this.txtArtista.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(465, 444);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tblDiscos);
            this.groupBox2.Location = new System.Drawing.Point(28, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 183);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla de Discos";
            // 
            // tblDiscos
            // 
            this.tblDiscos.AllowUserToAddRows = false;
            this.tblDiscos.AllowUserToDeleteRows = false;
            this.tblDiscos.AllowUserToOrderColumns = true;
            this.tblDiscos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblDiscos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tblDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDiscos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPortada,
            this.colTitulo,
            this.colArtista,
            this.colNumPistas,
            this.colFechaE,
            this.colPrecio});
            this.tblDiscos.Location = new System.Drawing.Point(6, 19);
            this.tblDiscos.Name = "tblDiscos";
            this.tblDiscos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tblDiscos.Size = new System.Drawing.Size(494, 158);
            this.tblDiscos.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            // 
            // colFechaE
            // 
            this.colFechaE.HeaderText = "Fecha de Estreno";
            this.colFechaE.Name = "colFechaE";
            // 
            // colNumPistas
            // 
            this.colNumPistas.HeaderText = "Num. Pistas";
            this.colNumPistas.Name = "colNumPistas";
            // 
            // colArtista
            // 
            this.colArtista.HeaderText = "Artista";
            this.colArtista.Name = "colArtista";
            // 
            // colTitulo
            // 
            this.colTitulo.HeaderText = "Titulo";
            this.colTitulo.Name = "colTitulo";
            // 
            // colPortada
            // 
            this.colPortada.HeaderText = "Portada";
            this.colPortada.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colPortada.Name = "colPortada";
            this.colPortada.ReadOnly = true;
            this.colPortada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(362, 162);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 14;
            this.btnExaminar.Text = "Examinar..";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // picBxPortada
            // 
            this.picBxPortada.Location = new System.Drawing.Point(332, 31);
            this.picBxPortada.Name = "picBxPortada";
            this.picBxPortada.Size = new System.Drawing.Size(136, 125);
            this.picBxPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxPortada.TabIndex = 4;
            this.picBxPortada.TabStop = false;
            // 
            // RegistroDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistroDiscos";
            this.Text = "RegistroDiscos";
            this.Load += new System.EventHandler(this.RegistroDiscos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnNumPistas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPortada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btbCancelar;
        private System.Windows.Forms.NumericUpDown spnNumPistas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tblDiscos;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.PictureBox picBxPortada;
        private System.Windows.Forms.DataGridViewImageColumn colPortada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumPistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}