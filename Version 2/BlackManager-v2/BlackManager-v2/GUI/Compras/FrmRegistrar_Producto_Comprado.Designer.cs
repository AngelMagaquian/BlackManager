namespace BlackManager_v2.GUI.Compras
{
    partial class FrmRegistrar_Producto_Comprado
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMayor = new System.Windows.Forms.Panel();
            this.lblresultado2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numPrecioTotal = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numUnidadesPorCaja = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numCantCaja = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panelUnidad = new System.Windows.Forms.Panel();
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numPrecioPorUnidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numUnidades = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.rdbUnidad = new System.Windows.Forms.RadioButton();
            this.rdbMayor = new System.Windows.Forms.RadioButton();
            this.cboProveedores = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnNuevoProv = new System.Windows.Forms.Button();
            this.panelMayor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidadesPorCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantCaja)).BeginInit();
            this.panelUnidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioPorUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 76);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(239, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(105, 126);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(239, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo:";
            // 
            // panelMayor
            // 
            this.panelMayor.Controls.Add(this.lblresultado2);
            this.panelMayor.Controls.Add(this.label10);
            this.panelMayor.Controls.Add(this.numPrecioTotal);
            this.panelMayor.Controls.Add(this.label7);
            this.panelMayor.Controls.Add(this.numUnidadesPorCaja);
            this.panelMayor.Controls.Add(this.label5);
            this.panelMayor.Controls.Add(this.numCantCaja);
            this.panelMayor.Controls.Add(this.label6);
            this.panelMayor.Location = new System.Drawing.Point(443, 203);
            this.panelMayor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMayor.Name = "panelMayor";
            this.panelMayor.Size = new System.Drawing.Size(331, 290);
            this.panelMayor.TabIndex = 14;
            // 
            // lblresultado2
            // 
            this.lblresultado2.AutoSize = true;
            this.lblresultado2.Location = new System.Drawing.Point(29, 260);
            this.lblresultado2.Name = "lblresultado2";
            this.lblresultado2.Size = new System.Drawing.Size(67, 17);
            this.lblresultado2.TabIndex = 20;
            this.lblresultado2.Text = "resultado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Resultado (precio por caja):";
            // 
            // numPrecioTotal
            // 
            this.numPrecioTotal.DecimalPlaces = 2;
            this.numPrecioTotal.Location = new System.Drawing.Point(155, 155);
            this.numPrecioTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPrecioTotal.Name = "numPrecioTotal";
            this.numPrecioTotal.Size = new System.Drawing.Size(88, 22);
            this.numPrecioTotal.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Precio total:";
            // 
            // numUnidadesPorCaja
            // 
            this.numUnidadesPorCaja.Location = new System.Drawing.Point(153, 98);
            this.numUnidadesPorCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUnidadesPorCaja.Name = "numUnidadesPorCaja";
            this.numUnidadesPorCaja.Size = new System.Drawing.Size(88, 22);
            this.numUnidadesPorCaja.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Unidades por caja:";
            // 
            // numCantCaja
            // 
            this.numCantCaja.Location = new System.Drawing.Point(155, 39);
            this.numCantCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numCantCaja.Name = "numCantCaja";
            this.numCantCaja.Size = new System.Drawing.Size(88, 22);
            this.numCantCaja.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad de cajas:";
            // 
            // panelUnidad
            // 
            this.panelUnidad.Controls.Add(this.lblResultado1);
            this.panelUnidad.Controls.Add(this.label11);
            this.panelUnidad.Controls.Add(this.numPrecioPorUnidad);
            this.panelUnidad.Controls.Add(this.label4);
            this.panelUnidad.Controls.Add(this.numUnidades);
            this.panelUnidad.Controls.Add(this.label3);
            this.panelUnidad.Location = new System.Drawing.Point(41, 203);
            this.panelUnidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUnidad.Name = "panelUnidad";
            this.panelUnidad.Size = new System.Drawing.Size(301, 290);
            this.panelUnidad.TabIndex = 15;
            // 
            // lblResultado1
            // 
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.Location = new System.Drawing.Point(24, 260);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(67, 17);
            this.lblResultado1.TabIndex = 21;
            this.lblResultado1.Text = "resultado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Resultado (precio por total):";
            // 
            // numPrecioPorUnidad
            // 
            this.numPrecioPorUnidad.DecimalPlaces = 2;
            this.numPrecioPorUnidad.Location = new System.Drawing.Point(149, 107);
            this.numPrecioPorUnidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPrecioPorUnidad.Name = "numPrecioPorUnidad";
            this.numPrecioPorUnidad.Size = new System.Drawing.Size(88, 22);
            this.numPrecioPorUnidad.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio por unidad:";
            // 
            // numUnidades
            // 
            this.numUnidades.Location = new System.Drawing.Point(99, 44);
            this.numUnidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUnidades.Name = "numUnidades";
            this.numUnidades.Size = new System.Drawing.Size(88, 22);
            this.numUnidades.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unidades:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Opcion por unidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Opcion por mayor:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(337, 497);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(119, 38);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // rdbUnidad
            // 
            this.rdbUnidad.AutoSize = true;
            this.rdbUnidad.Location = new System.Drawing.Point(174, 179);
            this.rdbUnidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbUnidad.Name = "rdbUnidad";
            this.rdbUnidad.Size = new System.Drawing.Size(41, 21);
            this.rdbUnidad.TabIndex = 19;
            this.rdbUnidad.TabStop = true;
            this.rdbUnidad.Text = "Si";
            this.rdbUnidad.UseVisualStyleBackColor = true;
            this.rdbUnidad.CheckedChanged += new System.EventHandler(this.rdbUnidad_CheckedChanged);
            // 
            // rdbMayor
            // 
            this.rdbMayor.AutoSize = true;
            this.rdbMayor.Location = new System.Drawing.Point(571, 181);
            this.rdbMayor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbMayor.Name = "rdbMayor";
            this.rdbMayor.Size = new System.Drawing.Size(41, 21);
            this.rdbMayor.TabIndex = 20;
            this.rdbMayor.TabStop = true;
            this.rdbMayor.Text = "Si";
            this.rdbMayor.UseVisualStyleBackColor = true;
            this.rdbMayor.CheckedChanged += new System.EventHandler(this.rdbMayor_CheckedChanged);
            // 
            // cboProveedores
            // 
            this.cboProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProveedores.FormattingEnabled = true;
            this.cboProveedores.Location = new System.Drawing.Point(573, 76);
            this.cboProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.cboProveedores.Name = "cboProveedores";
            this.cboProveedores.Size = new System.Drawing.Size(160, 24);
            this.cboProveedores.TabIndex = 21;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(441, 80);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(78, 17);
            this.lblProveedor.TabIndex = 22;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // btnNuevoProv
            // 
            this.btnNuevoProv.Location = new System.Drawing.Point(437, 126);
            this.btnNuevoProv.Name = "btnNuevoProv";
            this.btnNuevoProv.Size = new System.Drawing.Size(129, 38);
            this.btnNuevoProv.TabIndex = 23;
            this.btnNuevoProv.Text = "Nuevo Proveedor";
            this.btnNuevoProv.UseVisualStyleBackColor = true;
            this.btnNuevoProv.Click += new System.EventHandler(this.btnNuevoProv_Click);
            // 
            // FrmRegistrar_Producto_Comprado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 593);
            this.Controls.Add(this.btnNuevoProv);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.cboProveedores);
            this.Controls.Add(this.rdbMayor);
            this.Controls.Add(this.rdbUnidad);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelUnidad);
            this.Controls.Add(this.panelMayor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRegistrar_Producto_Comprado";
            this.Text = "FrmRegistrar_Producto_Comprado";
            this.Load += new System.EventHandler(this.FrmRegistrar_Producto_Comprado_Load);
            this.panelMayor.ResumeLayout(false);
            this.panelMayor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidadesPorCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantCaja)).EndInit();
            this.panelUnidad.ResumeLayout(false);
            this.panelUnidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioPorUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMayor;
        private System.Windows.Forms.Label lblresultado2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numPrecioTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numUnidadesPorCaja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCantCaja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelUnidad;
        private System.Windows.Forms.Label lblResultado1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numPrecioPorUnidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUnidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.RadioButton rdbUnidad;
        private System.Windows.Forms.RadioButton rdbMayor;
        private System.Windows.Forms.ComboBox cboProveedores;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Button btnNuevoProv;
    }
}