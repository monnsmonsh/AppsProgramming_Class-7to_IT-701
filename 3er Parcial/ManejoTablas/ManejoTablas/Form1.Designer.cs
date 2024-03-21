namespace ManejoTablas
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
            this.tblTelefonos = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCasado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblTelefonos)).BeginInit();
            this.SuspendLayout();
            // 
            // tblTelefonos
            // 
            this.tblTelefonos.AllowUserToAddRows = false;
            this.tblTelefonos.AllowUserToOrderColumns = true;
            this.tblTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblTelefonos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tblTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTelefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colDirección,
            this.colTelefono,
            this.colSexo,
            this.colCasado});
            this.tblTelefonos.Location = new System.Drawing.Point(13, 54);
            this.tblTelefonos.Name = "tblTelefonos";
            this.tblTelefonos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tblTelefonos.Size = new System.Drawing.Size(543, 283);
            this.tblTelefonos.TabIndex = 0;
            this.tblTelefonos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblTelefonos_CellContentClick);
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colDirección
            // 
            this.colDirección.HeaderText = "Dirección";
            this.colDirección.Name = "colDirección";
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.colSexo.Name = "colSexo";
            // 
            // colCasado
            // 
            this.colCasado.HeaderText = "Casado";
            this.colCasado.Name = "colCasado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 353);
            this.Controls.Add(this.tblTelefonos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tblTelefonos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblTelefonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewComboBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCasado;
    }
}

