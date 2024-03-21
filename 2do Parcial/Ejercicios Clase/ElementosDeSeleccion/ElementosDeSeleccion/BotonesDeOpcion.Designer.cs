namespace ElementosDeSeleccion
{
    partial class BotonesDeOpcion
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.gbxGrupoBotones = new System.Windows.Forms.GroupBox();
            this.rbtDecimal = new System.Windows.Forms.RadioButton();
            this.rbtOctal = new System.Windows.Forms.RadioButton();
            this.rbtHexadecimal = new System.Windows.Forms.RadioButton();
            this.gbxGrupoBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(21, 24);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(24, 53);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(200, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // gbxGrupoBotones
            // 
            this.gbxGrupoBotones.Controls.Add(this.rbtHexadecimal);
            this.gbxGrupoBotones.Controls.Add(this.rbtOctal);
            this.gbxGrupoBotones.Controls.Add(this.rbtDecimal);
            this.gbxGrupoBotones.Location = new System.Drawing.Point(24, 90);
            this.gbxGrupoBotones.Name = "gbxGrupoBotones";
            this.gbxGrupoBotones.Size = new System.Drawing.Size(200, 100);
            this.gbxGrupoBotones.TabIndex = 2;
            this.gbxGrupoBotones.TabStop = false;
            this.gbxGrupoBotones.Text = "Sistemas Numericos";
            // 
            // rbtDecimal
            // 
            this.rbtDecimal.AutoSize = true;
            this.rbtDecimal.Checked = true;
            this.rbtDecimal.Location = new System.Drawing.Point(7, 20);
            this.rbtDecimal.Name = "rbtDecimal";
            this.rbtDecimal.Size = new System.Drawing.Size(63, 17);
            this.rbtDecimal.TabIndex = 0;
            this.rbtDecimal.TabStop = true;
            this.rbtDecimal.Text = "Decimal";
            this.rbtDecimal.UseVisualStyleBackColor = true;
            this.rbtDecimal.CheckedChanged += new System.EventHandler(this.rbtDecimal_CheckedChanged);
            // 
            // rbtOctal
            // 
            this.rbtOctal.AutoSize = true;
            this.rbtOctal.Location = new System.Drawing.Point(6, 43);
            this.rbtOctal.Name = "rbtOctal";
            this.rbtOctal.Size = new System.Drawing.Size(50, 17);
            this.rbtOctal.TabIndex = 1;
            this.rbtOctal.Text = "Octal";
            this.rbtOctal.UseVisualStyleBackColor = true;
            this.rbtOctal.CheckedChanged += new System.EventHandler(this.rbtOctal_CheckedChanged);
            // 
            // rbtHexadecimal
            // 
            this.rbtHexadecimal.AutoSize = true;
            this.rbtHexadecimal.Location = new System.Drawing.Point(6, 66);
            this.rbtHexadecimal.Name = "rbtHexadecimal";
            this.rbtHexadecimal.Size = new System.Drawing.Size(86, 17);
            this.rbtHexadecimal.TabIndex = 2;
            this.rbtHexadecimal.Text = "Hexadecimal";
            this.rbtHexadecimal.UseVisualStyleBackColor = true;
            this.rbtHexadecimal.CheckedChanged += new System.EventHandler(this.rbtHexadecimal_CheckedChanged);
            // 
            // BotonesDeOpcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 217);
            this.Controls.Add(this.gbxGrupoBotones);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Name = "BotonesDeOpcion";
            this.Text = "BotonesDeOpcion";
            this.gbxGrupoBotones.ResumeLayout(false);
            this.gbxGrupoBotones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox gbxGrupoBotones;
        private System.Windows.Forms.RadioButton rbtHexadecimal;
        private System.Windows.Forms.RadioButton rbtOctal;
        private System.Windows.Forms.RadioButton rbtDecimal;
    }
}