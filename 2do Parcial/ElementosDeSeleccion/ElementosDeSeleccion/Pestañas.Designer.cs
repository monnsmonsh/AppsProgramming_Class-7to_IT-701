namespace ElementosDeSeleccion
{
    partial class Pestañas
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
            this.tbcntPestañas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbcntPestañas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcntPestañas
            // 
            this.tbcntPestañas.Controls.Add(this.tabPage1);
            this.tbcntPestañas.Controls.Add(this.tabPage2);
            this.tbcntPestañas.Location = new System.Drawing.Point(12, 56);
            this.tbcntPestañas.Name = "tbcntPestañas";
            this.tbcntPestañas.SelectedIndex = 0;
            this.tbcntPestañas.Size = new System.Drawing.Size(480, 308);
            this.tbcntPestañas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pestaña1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Pestañas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 378);
            this.Controls.Add(this.tbcntPestañas);
            this.Name = "Pestañas";
            this.Text = "Pestañas";
            this.Load += new System.EventHandler(this.Pestañas_Load);
            this.tbcntPestañas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcntPestañas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}