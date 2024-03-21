namespace Vista
{
    partial class ReportesVentas
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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetalleVentas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVentas);
            this.groupBox1.Font = new System.Drawing.Font("AvantGarde Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 180);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Venta";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToOrderColumns = true;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(16, 20);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(449, 145);
            this.dgvVentas.TabIndex = 4;
            this.dgvVentas.Click += new System.EventHandler(this.dgvVentas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDetalleVentas);
            this.groupBox2.Font = new System.Drawing.Font("AvantGarde Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 180);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Venta";
            // 
            // dgvDetalleVentas
            // 
            this.dgvDetalleVentas.AllowUserToAddRows = false;
            this.dgvDetalleVentas.AllowUserToDeleteRows = false;
            this.dgvDetalleVentas.AllowUserToOrderColumns = true;
            this.dgvDetalleVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVentas.Location = new System.Drawing.Point(16, 20);
            this.dgvDetalleVentas.Name = "dgvDetalleVentas";
            this.dgvDetalleVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVentas.Size = new System.Drawing.Size(449, 145);
            this.dgvDetalleVentas.TabIndex = 4;
            // 
            // ReportesVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportesVentas";
            this.Text = "ReportesVentas";
            this.Load += new System.EventHandler(this.ReportesVentas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetalleVentas;
    }
}