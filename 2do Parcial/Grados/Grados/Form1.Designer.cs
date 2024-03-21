namespace Grados
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
            this.lblGradosC = new System.Windows.Forms.Label();
            this.txtGradosC = new System.Windows.Forms.TextBox();
            this.lblGradosF = new System.Windows.Forms.Label();
            this.txtGradosF = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGradosC
            // 
            this.lblGradosC.AutoSize = true;
            this.lblGradosC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradosC.Location = new System.Drawing.Point(36, 69);
            this.lblGradosC.Name = "lblGradosC";
            this.lblGradosC.Size = new System.Drawing.Size(129, 16);
            this.lblGradosC.TabIndex = 0;
            this.lblGradosC.Text = "Grados Centigrados";
            // 
            // txtGradosC
            // 
            this.txtGradosC.Location = new System.Drawing.Point(192, 69);
            this.txtGradosC.Name = "txtGradosC";
            this.txtGradosC.Size = new System.Drawing.Size(100, 20);
            this.txtGradosC.TabIndex = 1;
            this.txtGradosC.Text = "0.00";
            this.txtGradosC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGradosC.Enter += new System.EventHandler(this.txtGradosC_Enter);
            this.txtGradosC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGradosC_KeyPress);
            this.txtGradosC.Validating += new System.ComponentModel.CancelEventHandler(this.txtGradosC_Validating);
            this.txtGradosC.Validated += new System.EventHandler(this.txtGradosC_Validated);
            // 
            // lblGradosF
            // 
            this.lblGradosF.AutoSize = true;
            this.lblGradosF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradosF.Location = new System.Drawing.Point(36, 109);
            this.lblGradosF.Name = "lblGradosF";
            this.lblGradosF.Size = new System.Drawing.Size(112, 16);
            this.lblGradosF.TabIndex = 2;
            this.lblGradosF.Text = "Grados Farenheit";
            // 
            // txtGradosF
            // 
            this.txtGradosF.Location = new System.Drawing.Point(192, 109);
            this.txtGradosF.Name = "txtGradosF";
            this.txtGradosF.Size = new System.Drawing.Size(100, 20);
            this.txtGradosF.TabIndex = 3;
            this.txtGradosF.Text = "32.00";
            this.txtGradosF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGradosF.Enter += new System.EventHandler(this.txtGradosF_Enter);
            this.txtGradosF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGradosF_KeyPress);
            this.txtGradosF.Validating += new System.ComponentModel.CancelEventHandler(this.txtGradosF_Validating);
            this.txtGradosF.Validated += new System.EventHandler(this.txtGradosF_Validated);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(260, 156);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "&Aceptar ";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 228);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtGradosF);
            this.Controls.Add(this.lblGradosF);
            this.Controls.Add(this.txtGradosC);
            this.Controls.Add(this.lblGradosC);
            this.Name = "Form1";
            this.Text = "Conversion de temperaturas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGradosC;
        private System.Windows.Forms.TextBox txtGradosC;
        private System.Windows.Forms.Label lblGradosF;
        private System.Windows.Forms.TextBox txtGradosF;
        private System.Windows.Forms.Button btnAceptar;
    }
}

