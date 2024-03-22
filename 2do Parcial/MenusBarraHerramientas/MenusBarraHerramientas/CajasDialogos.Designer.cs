namespace MenusBarraHerramientas
{
    partial class CajasDialogos
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
            this.btnInformacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdvertencia = new System.Windows.Forms.Button();
            this.btnConfirmacion2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmacion1 = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.btnInputBox = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMostarDialogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInformacion
            // 
            this.btnInformacion.Location = new System.Drawing.Point(22, 51);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(92, 69);
            this.btnInformacion.TabIndex = 0;
            this.btnInformacion.Text = "Dialogos de informacion";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dialogos para Mostrar Información";
            // 
            // btnAdvertencia
            // 
            this.btnAdvertencia.Location = new System.Drawing.Point(150, 51);
            this.btnAdvertencia.Name = "btnAdvertencia";
            this.btnAdvertencia.Size = new System.Drawing.Size(92, 69);
            this.btnAdvertencia.TabIndex = 2;
            this.btnAdvertencia.Text = "Dialogos de Advertencia";
            this.btnAdvertencia.UseVisualStyleBackColor = true;
            this.btnAdvertencia.Click += new System.EventHandler(this.btnAdvertencia_Click);
            // 
            // btnConfirmacion2
            // 
            this.btnConfirmacion2.Location = new System.Drawing.Point(150, 181);
            this.btnConfirmacion2.Name = "btnConfirmacion2";
            this.btnConfirmacion2.Size = new System.Drawing.Size(92, 69);
            this.btnConfirmacion2.TabIndex = 5;
            this.btnConfirmacion2.Text = "Dialogos de Confirmacion2";
            this.btnConfirmacion2.UseVisualStyleBackColor = true;
            this.btnConfirmacion2.Click += new System.EventHandler(this.btnConfirmacion2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dialogos para Mostrar Información";
            // 
            // btnConfirmacion1
            // 
            this.btnConfirmacion1.Location = new System.Drawing.Point(22, 181);
            this.btnConfirmacion1.Name = "btnConfirmacion1";
            this.btnConfirmacion1.Size = new System.Drawing.Size(92, 69);
            this.btnConfirmacion1.TabIndex = 3;
            this.btnConfirmacion1.Text = "Dialogos de Confirmacion1";
            this.btnConfirmacion1.UseVisualStyleBackColor = true;
            this.btnConfirmacion1.Click += new System.EventHandler(this.btnConfirmacion1_Click);
            // 
            // btnError
            // 
            this.btnError.Location = new System.Drawing.Point(278, 51);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(92, 69);
            this.btnError.TabIndex = 6;
            this.btnError.Text = "Dialogos de Error";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnInputBox
            // 
            this.btnInputBox.Location = new System.Drawing.Point(278, 330);
            this.btnInputBox.Name = "btnInputBox";
            this.btnInputBox.Size = new System.Drawing.Size(92, 35);
            this.btnInputBox.TabIndex = 9;
            this.btnInputBox.Text = "Input Box";
            this.btnInputBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dialogos personalizados";
            // 
            // btnMostarDialogo
            // 
            this.btnMostarDialogo.Location = new System.Drawing.Point(22, 313);
            this.btnMostarDialogo.Name = "btnMostarDialogo";
            this.btnMostarDialogo.Size = new System.Drawing.Size(92, 69);
            this.btnMostarDialogo.TabIndex = 7;
            this.btnMostarDialogo.Text = "Mostrar Dialogo";
            this.btnMostarDialogo.UseVisualStyleBackColor = true;
            this.btnMostarDialogo.Click += new System.EventHandler(this.btnMostarDialogo_Click);
            // 
            // CajasDialogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 412);
            this.Controls.Add(this.btnInputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMostarDialogo);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnConfirmacion2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirmacion1);
            this.Controls.Add(this.btnAdvertencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInformacion);
            this.Name = "CajasDialogos";
            this.Text = "CajasDialogos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdvertencia;
        private System.Windows.Forms.Button btnConfirmacion2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmacion1;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnInputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMostarDialogo;
    }
}