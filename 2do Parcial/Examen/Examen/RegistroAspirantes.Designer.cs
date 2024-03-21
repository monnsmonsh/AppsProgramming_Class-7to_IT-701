namespace Examen
{
    partial class RegistroAspirantes
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtDirreccion = new System.Windows.Forms.TextBox();
            this.lblDirrecion = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chkViajar = new System.Windows.Forms.CheckBox();
            this.chkAmigos = new System.Windows.Forms.CheckBox();
            this.chkMusica = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.chkPeliculas = new System.Windows.Forms.CheckBox();
            this.chkDeporte = new System.Windows.Forms.CheckBox();
            this.chkLeer = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMostrarAceptados = new System.Windows.Forms.Button();
            this.btnRealizarExamen = new System.Windows.Forms.Button();
            this.btnAgregarAspirante = new System.Windows.Forms.Button();
            this.btnAgregarAceptado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstAceptados = new System.Windows.Forms.ListBox();
            this.lstAspirantes = new System.Windows.Forms.ListBox();
            this.btnMostrarAspirantes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(22, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(171, 20);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Registro de Aspirantes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExaminar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.rbtFemenino);
            this.groupBox1.Controls.Add(this.rbtMasculino);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.lblMatricula);
            this.groupBox1.Location = new System.Drawing.Point(26, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(262, 109);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 8;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Examen.Properties.Resources.hombre_foto_de_perfil_avatar_400_20171875;
            this.pictureBox1.Location = new System.Drawing.Point(262, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(163, 98);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 6;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(76, 98);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 5;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sexo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(76, 39);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(158, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(20, 42);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(53, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboEstados);
            this.groupBox2.Controls.Add(this.txtCiudad);
            this.groupBox2.Controls.Add(this.lblCiudad);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblEstado);
            this.groupBox2.Controls.Add(this.txtDirreccion);
            this.groupBox2.Controls.Add(this.lblDirrecion);
            this.groupBox2.Location = new System.Drawing.Point(26, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 94);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Localizacion";
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Items.AddRange(new object[] {
            "Campeche",
            "Chihuahua",
            "Hidalgo",
            "Guanajuato",
            "Guadalajara",
            "Mexico",
            "Monterrey",
            "Zacatecas"});
            this.cboEstados.Location = new System.Drawing.Point(76, 54);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(100, 21);
            this.cboEstados.TabIndex = 11;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(236, 55);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 10;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(182, 58);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 9;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(237, 27);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(20, 55);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado:";
            // 
            // txtDirreccion
            // 
            this.txtDirreccion.Location = new System.Drawing.Point(76, 27);
            this.txtDirreccion.Name = "txtDirreccion";
            this.txtDirreccion.Size = new System.Drawing.Size(100, 20);
            this.txtDirreccion.TabIndex = 1;
            // 
            // lblDirrecion
            // 
            this.lblDirrecion.AutoSize = true;
            this.lblDirrecion.Location = new System.Drawing.Point(20, 30);
            this.lblDirrecion.Name = "lblDirrecion";
            this.lblDirrecion.Size = new System.Drawing.Size(58, 13);
            this.lblDirrecion.TabIndex = 0;
            this.lblDirrecion.Text = "Dirreccion:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.chkViajar);
            this.groupBox3.Controls.Add(this.chkAmigos);
            this.groupBox3.Controls.Add(this.chkMusica);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.chkPeliculas);
            this.groupBox3.Controls.Add(this.chkDeporte);
            this.groupBox3.Controls.Add(this.chkLeer);
            this.groupBox3.Location = new System.Drawing.Point(26, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 106);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Localizacion";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(262, 56);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "- Limpiar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // chkViajar
            // 
            this.chkViajar.AutoSize = true;
            this.chkViajar.Location = new System.Drawing.Point(138, 73);
            this.chkViajar.Name = "chkViajar";
            this.chkViajar.Size = new System.Drawing.Size(52, 17);
            this.chkViajar.TabIndex = 17;
            this.chkViajar.Text = "Viajar";
            this.chkViajar.UseVisualStyleBackColor = true;
            // 
            // chkAmigos
            // 
            this.chkAmigos.AutoSize = true;
            this.chkAmigos.Location = new System.Drawing.Point(138, 50);
            this.chkAmigos.Name = "chkAmigos";
            this.chkAmigos.Size = new System.Drawing.Size(104, 17);
            this.chkAmigos.TabIndex = 16;
            this.chkAmigos.Text = "Salir con Amigos";
            this.chkAmigos.UseVisualStyleBackColor = true;
            // 
            // chkMusica
            // 
            this.chkMusica.AutoSize = true;
            this.chkMusica.Location = new System.Drawing.Point(138, 27);
            this.chkMusica.Name = "chkMusica";
            this.chkMusica.Size = new System.Drawing.Size(108, 17);
            this.chkMusica.TabIndex = 15;
            this.chkMusica.Text = "Escuchar Musica";
            this.chkMusica.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(262, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "+ Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // chkPeliculas
            // 
            this.chkPeliculas.AutoSize = true;
            this.chkPeliculas.Location = new System.Drawing.Point(23, 73);
            this.chkPeliculas.Name = "chkPeliculas";
            this.chkPeliculas.Size = new System.Drawing.Size(87, 17);
            this.chkPeliculas.TabIndex = 14;
            this.chkPeliculas.Text = "Ver Peliculas";
            this.chkPeliculas.UseVisualStyleBackColor = true;
            // 
            // chkDeporte
            // 
            this.chkDeporte.AutoSize = true;
            this.chkDeporte.Location = new System.Drawing.Point(23, 50);
            this.chkDeporte.Name = "chkDeporte";
            this.chkDeporte.Size = new System.Drawing.Size(96, 17);
            this.chkDeporte.TabIndex = 13;
            this.chkDeporte.Text = "Hacer Deporte";
            this.chkDeporte.UseVisualStyleBackColor = true;
            // 
            // chkLeer
            // 
            this.chkLeer.AutoSize = true;
            this.chkLeer.Location = new System.Drawing.Point(23, 27);
            this.chkLeer.Name = "chkLeer";
            this.chkLeer.Size = new System.Drawing.Size(47, 17);
            this.chkLeer.TabIndex = 12;
            this.chkLeer.Text = "Leer";
            this.chkLeer.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMostrarAceptados);
            this.groupBox4.Controls.Add(this.btnRealizarExamen);
            this.groupBox4.Controls.Add(this.btnAgregarAspirante);
            this.groupBox4.Controls.Add(this.btnAgregarAceptado);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lstAceptados);
            this.groupBox4.Controls.Add(this.lstAspirantes);
            this.groupBox4.Controls.Add(this.btnMostrarAspirantes);
            this.groupBox4.Location = new System.Drawing.Point(421, 58);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 392);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alumnos";
            // 
            // btnMostrarAceptados
            // 
            this.btnMostrarAceptados.Location = new System.Drawing.Point(345, 325);
            this.btnMostrarAceptados.Name = "btnMostrarAceptados";
            this.btnMostrarAceptados.Size = new System.Drawing.Size(75, 37);
            this.btnMostrarAceptados.TabIndex = 23;
            this.btnMostrarAceptados.Text = "Mostrar ";
            this.btnMostrarAceptados.UseVisualStyleBackColor = true;
            this.btnMostrarAceptados.Click += new System.EventHandler(this.btnMostrarAceptados_Click);
            // 
            // btnRealizarExamen
            // 
            this.btnRealizarExamen.Location = new System.Drawing.Point(207, 207);
            this.btnRealizarExamen.Name = "btnRealizarExamen";
            this.btnRealizarExamen.Size = new System.Drawing.Size(71, 37);
            this.btnRealizarExamen.TabIndex = 22;
            this.btnRealizarExamen.Text = "Realizar Examen";
            this.btnRealizarExamen.UseVisualStyleBackColor = true;
            this.btnRealizarExamen.Click += new System.EventHandler(this.btnRealizarExamen_Click);
            // 
            // btnAgregarAspirante
            // 
            this.btnAgregarAspirante.Location = new System.Drawing.Point(219, 160);
            this.btnAgregarAspirante.Name = "btnAgregarAspirante";
            this.btnAgregarAspirante.Size = new System.Drawing.Size(48, 23);
            this.btnAgregarAspirante.TabIndex = 21;
            this.btnAgregarAspirante.Text = "<---";
            this.btnAgregarAspirante.UseVisualStyleBackColor = true;
            this.btnAgregarAspirante.Click += new System.EventHandler(this.btnAgregarAspirante_Click);
            // 
            // btnAgregarAceptado
            // 
            this.btnAgregarAceptado.Location = new System.Drawing.Point(220, 117);
            this.btnAgregarAceptado.Name = "btnAgregarAceptado";
            this.btnAgregarAceptado.Size = new System.Drawing.Size(48, 23);
            this.btnAgregarAceptado.TabIndex = 9;
            this.btnAgregarAceptado.Text = "-->";
            this.btnAgregarAceptado.UseVisualStyleBackColor = true;
            this.btnAgregarAceptado.Click += new System.EventHandler(this.btnAgregarAceptado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Lista Aceptados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lista Aspirantes";
            // 
            // lstAceptados
            // 
            this.lstAceptados.FormattingEnabled = true;
            this.lstAceptados.Location = new System.Drawing.Point(284, 50);
            this.lstAceptados.Name = "lstAceptados";
            this.lstAceptados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAceptados.Size = new System.Drawing.Size(178, 264);
            this.lstAceptados.Sorted = true;
            this.lstAceptados.TabIndex = 19;
            // 
            // lstAspirantes
            // 
            this.lstAspirantes.FormattingEnabled = true;
            this.lstAspirantes.Location = new System.Drawing.Point(23, 50);
            this.lstAspirantes.Name = "lstAspirantes";
            this.lstAspirantes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAspirantes.Size = new System.Drawing.Size(178, 264);
            this.lstAspirantes.Sorted = true;
            this.lstAspirantes.TabIndex = 18;
            // 
            // btnMostrarAspirantes
            // 
            this.btnMostrarAspirantes.Location = new System.Drawing.Point(80, 328);
            this.btnMostrarAspirantes.Name = "btnMostrarAspirantes";
            this.btnMostrarAspirantes.Size = new System.Drawing.Size(75, 37);
            this.btnMostrarAspirantes.TabIndex = 15;
            this.btnMostrarAspirantes.Text = "Mostrar";
            this.btnMostrarAspirantes.UseVisualStyleBackColor = true;
            this.btnMostrarAspirantes.Click += new System.EventHandler(this.btnMostrarls_Click);
            // 
            // RegistroAspirantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 473);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistroAspirantes";
            this.Text = "RegistroAspirantes";
            this.Load += new System.EventHandler(this.RegistroAspirantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtDirreccion;
        private System.Windows.Forms.Label lblDirrecion;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkViajar;
        private System.Windows.Forms.CheckBox chkAmigos;
        private System.Windows.Forms.CheckBox chkMusica;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox chkPeliculas;
        private System.Windows.Forms.CheckBox chkDeporte;
        private System.Windows.Forms.CheckBox chkLeer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstAspirantes;
        private System.Windows.Forms.Button btnMostrarAspirantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstAceptados;
        private System.Windows.Forms.Button btnMostrarAceptados;
        private System.Windows.Forms.Button btnRealizarExamen;
        private System.Windows.Forms.Button btnAgregarAspirante;
        private System.Windows.Forms.Button btnAgregarAceptado;
        private System.Windows.Forms.Label label3;
    }
}