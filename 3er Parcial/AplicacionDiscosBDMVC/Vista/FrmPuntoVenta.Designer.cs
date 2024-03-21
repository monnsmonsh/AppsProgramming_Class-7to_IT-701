namespace Vista
{
    partial class FrmPuntoVenta
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
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDiscos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValTotal = new System.Windows.Forms.Label();
            this.lblValIva = new System.Windows.Forms.Label();
            this.lblValSubtotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblValFecha = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl1ValColonia = new System.Windows.Forms.Label();
            this.lblValNombre = new System.Windows.Forms.Label();
            this.lblValRfc = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnReporteVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.AllowUserToOrderColumns = true;
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Disco,
            this.Cantidad,
            this.PrecioU,
            this.Total});
            this.dgvDetalleVenta.Location = new System.Drawing.Point(28, 72);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(449, 158);
            this.dgvDetalleVenta.TabIndex = 3;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            // 
            // Disco
            // 
            this.Disco.HeaderText = "Disco";
            this.Disco.Name = "Disco";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioU
            // 
            this.PrecioU.HeaderText = "precioU";
            this.PrecioU.Name = "PrecioU";
            // 
            // Total
            // 
            this.Total.HeaderText = "total";
            this.Total.Name = "Total";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(241, 47);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(114, 20);
            this.txtCantidad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AvantGarde Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Discos disponibles:";
            // 
            // cboDiscos
            // 
            this.cboDiscos.FormattingEnabled = true;
            this.cboDiscos.Location = new System.Drawing.Point(28, 46);
            this.cboDiscos.Name = "cboDiscos";
            this.cboDiscos.Size = new System.Drawing.Size(178, 21);
            this.cboDiscos.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "SubTotal:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("AvantGarde Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(402, 43);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("AvantGarde Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(402, 236);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("AvantGarde Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(321, 236);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 13;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("AvantGarde Bk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(483, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 54);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValTotal);
            this.groupBox1.Controls.Add(this.lblValIva);
            this.groupBox1.Controls.Add(this.lblValSubtotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("AvantGarde Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(483, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detallles de Venta";
            // 
            // lblValTotal
            // 
            this.lblValTotal.AutoSize = true;
            this.lblValTotal.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValTotal.Location = new System.Drawing.Point(91, 70);
            this.lblValTotal.Name = "lblValTotal";
            this.lblValTotal.Size = new System.Drawing.Size(52, 20);
            this.lblValTotal.TabIndex = 15;
            this.lblValTotal.Text = "$0.00";
            // 
            // lblValIva
            // 
            this.lblValIva.AutoSize = true;
            this.lblValIva.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValIva.Location = new System.Drawing.Point(91, 50);
            this.lblValIva.Name = "lblValIva";
            this.lblValIva.Size = new System.Drawing.Size(52, 20);
            this.lblValIva.TabIndex = 14;
            this.lblValIva.Text = "$0.00";
            // 
            // lblValSubtotal
            // 
            this.lblValSubtotal.AutoSize = true;
            this.lblValSubtotal.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValSubtotal.Location = new System.Drawing.Point(91, 30);
            this.lblValSubtotal.Name = "lblValSubtotal";
            this.lblValSubtotal.Size = new System.Drawing.Size(52, 20);
            this.lblValSubtotal.TabIndex = 13;
            this.lblValSubtotal.Text = "$0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "IVA:";
            // 
            // btnCobrar
            // 
            this.btnCobrar.Font = new System.Drawing.Font("AvantGarde Bk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Location = new System.Drawing.Point(483, 116);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(163, 54);
            this.btnCobrar.TabIndex = 16;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblValFecha);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtNoFactura);
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Font = new System.Drawing.Font("AvantGarde Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detallles de la factura";
            // 
            // lblValFecha
            // 
            this.lblValFecha.AutoSize = true;
            this.lblValFecha.Location = new System.Drawing.Point(80, 59);
            this.lblValFecha.Name = "lblValFecha";
            this.lblValFecha.Size = new System.Drawing.Size(27, 14);
            this.lblValFecha.TabIndex = 20;
            this.lblValFecha.Text = "-----";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 14);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fecha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "No. Factura";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("AvantGarde Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(274, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 16);
            this.label16.TabIndex = 17;
            this.label16.Text = "Observaciones";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Location = new System.Drawing.Point(83, 20);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(135, 21);
            this.txtNoFactura.TabIndex = 17;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(374, 20);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(238, 70);
            this.txtObservaciones.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("AvantGarde Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(238, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Cantidad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl1ValColonia);
            this.groupBox3.Controls.Add(this.lblValNombre);
            this.groupBox3.Controls.Add(this.lblValRfc);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cboCliente);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("AvantGarde Bk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(28, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(618, 100);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Cliente";
            // 
            // lbl1ValColonia
            // 
            this.lbl1ValColonia.AutoSize = true;
            this.lbl1ValColonia.Font = new System.Drawing.Font("AvantGarde Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1ValColonia.Location = new System.Drawing.Point(381, 58);
            this.lbl1ValColonia.Name = "lbl1ValColonia";
            this.lbl1ValColonia.Size = new System.Drawing.Size(68, 16);
            this.lbl1ValColonia.TabIndex = 28;
            this.lbl1ValColonia.Text = "---------------";
            // 
            // lblValNombre
            // 
            this.lblValNombre.AutoSize = true;
            this.lblValNombre.Font = new System.Drawing.Font("AvantGarde Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValNombre.Location = new System.Drawing.Point(80, 58);
            this.lblValNombre.Name = "lblValNombre";
            this.lblValNombre.Size = new System.Drawing.Size(68, 16);
            this.lblValNombre.TabIndex = 27;
            this.lblValNombre.Text = "---------------";
            // 
            // lblValRfc
            // 
            this.lblValRfc.AutoSize = true;
            this.lblValRfc.Font = new System.Drawing.Font("AvantGarde Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValRfc.Location = new System.Drawing.Point(308, 23);
            this.lblValRfc.Name = "lblValRfc";
            this.lblValRfc.Size = new System.Drawing.Size(68, 16);
            this.lblValRfc.TabIndex = 26;
            this.lblValRfc.Text = "---------------";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("AvantGarde Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(308, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Direccion:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("AvantGarde Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 16);
            this.label17.TabIndex = 24;
            this.label17.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("AvantGarde Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(274, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "RFC:";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(83, 20);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(178, 23);
            this.cboCliente.TabIndex = 22;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("AvantGarde Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "Cliente:";
            // 
            // btnReporteVentas
            // 
            this.btnReporteVentas.Font = new System.Drawing.Font("AvantGarde Bk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteVentas.Location = new System.Drawing.Point(483, 236);
            this.btnReporteVentas.Name = "btnReporteVentas";
            this.btnReporteVentas.Size = new System.Drawing.Size(163, 23);
            this.btnReporteVentas.TabIndex = 22;
            this.btnReporteVentas.Text = "Reportes";
            this.btnReporteVentas.UseVisualStyleBackColor = true;
            this.btnReporteVentas.Click += new System.EventHandler(this.btnReporteVentas_Click);
            // 
            // FrmPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 490);
            this.Controls.Add(this.btnReporteVentas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboDiscos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Name = "FrmPuntoVenta";
            this.Text = "FrmPuntoVenta";
            this.Load += new System.EventHandler(this.FrmPuntoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDiscos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValTotal;
        private System.Windows.Forms.Label lblValIva;
        private System.Windows.Forms.Label lblValSubtotal;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.Label lblValFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblValRfc;
        private System.Windows.Forms.Label lblValNombre;
        private System.Windows.Forms.Label lbl1ValColonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnReporteVentas;
    }
}