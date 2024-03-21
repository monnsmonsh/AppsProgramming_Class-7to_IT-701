namespace ElementosDeLista
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
            this.txtEx = new System.Windows.Forms.TextBox();
            this.lstExParejas = new System.Windows.Forms.ListBox();
            this.btnAgrgar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnOlvidar = new System.Windows.Forms.Button();
            this.btnMosVarios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboListaExParejas = new System.Windows.Forms.ComboBox();
            this.btnMostar2 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exnovio(a)";
            // 
            // txtEx
            // 
            this.txtEx.Location = new System.Drawing.Point(32, 62);
            this.txtEx.Name = "txtEx";
            this.txtEx.Size = new System.Drawing.Size(120, 20);
            this.txtEx.TabIndex = 1;
            // 
            // lstExParejas
            // 
            this.lstExParejas.FormattingEnabled = true;
            this.lstExParejas.Items.AddRange(new object[] {
            "Alicia",
            "Ana",
            "Carmen",
            "Fernanda",
            "Isabel",
            "Lupita",
            "Maria"});
            this.lstExParejas.Location = new System.Drawing.Point(32, 140);
            this.lstExParejas.Name = "lstExParejas";
            this.lstExParejas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstExParejas.Size = new System.Drawing.Size(120, 108);
            this.lstExParejas.Sorted = true;
            this.lstExParejas.TabIndex = 2;
            // 
            // btnAgrgar
            // 
            this.btnAgrgar.Location = new System.Drawing.Point(172, 62);
            this.btnAgrgar.Name = "btnAgrgar";
            this.btnAgrgar.Size = new System.Drawing.Size(103, 23);
            this.btnAgrgar.TabIndex = 3;
            this.btnAgrgar.Text = "Agregar a Lista";
            this.btnAgrgar.UseVisualStyleBackColor = true;
            this.btnAgrgar.Click += new System.EventHandler(this.btnAgrgar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(183, 140);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(90, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnOlvidar
            // 
            this.btnOlvidar.Location = new System.Drawing.Point(183, 225);
            this.btnOlvidar.Name = "btnOlvidar";
            this.btnOlvidar.Size = new System.Drawing.Size(90, 23);
            this.btnOlvidar.TabIndex = 5;
            this.btnOlvidar.Text = "Olvidar";
            this.btnOlvidar.UseVisualStyleBackColor = true;
            this.btnOlvidar.Click += new System.EventHandler(this.btnOlvidar_Click);
            // 
            // btnMosVarios
            // 
            this.btnMosVarios.Location = new System.Drawing.Point(183, 168);
            this.btnMosVarios.Name = "btnMosVarios";
            this.btnMosVarios.Size = new System.Drawing.Size(90, 23);
            this.btnMosVarios.TabIndex = 6;
            this.btnMosVarios.Text = "Mostrar Varios";
            this.btnMosVarios.UseVisualStyleBackColor = true;
            this.btnMosVarios.Click += new System.EventHandler(this.btnMosVarios_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lista Negra";
            // 
            // cboListaExParejas
            // 
            this.cboListaExParejas.FormattingEnabled = true;
            this.cboListaExParejas.Location = new System.Drawing.Point(329, 140);
            this.cboListaExParejas.Name = "cboListaExParejas";
            this.cboListaExParejas.Size = new System.Drawing.Size(120, 21);
            this.cboListaExParejas.TabIndex = 8;
            // 
            // btnMostar2
            // 
            this.btnMostar2.Location = new System.Drawing.Point(329, 167);
            this.btnMostar2.Name = "btnMostar2";
            this.btnMostar2.Size = new System.Drawing.Size(54, 23);
            this.btnMostar2.TabIndex = 9;
            this.btnMostar2.Text = "Mostrar";
            this.btnMostar2.UseVisualStyleBackColor = true;
            this.btnMostar2.Click += new System.EventHandler(this.btnMostar2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(395, 167);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(183, 197);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 280);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnMostar2);
            this.Controls.Add(this.cboListaExParejas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMosVarios);
            this.Controls.Add(this.btnOlvidar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgrgar);
            this.Controls.Add(this.lstExParejas);
            this.Controls.Add(this.txtEx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEx;
        private System.Windows.Forms.ListBox lstExParejas;
        private System.Windows.Forms.Button btnAgrgar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnOlvidar;
        private System.Windows.Forms.Button btnMosVarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboListaExParejas;
        private System.Windows.Forms.Button btnMostar2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
    }
}

