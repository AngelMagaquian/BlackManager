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
            this.label1.Location = new System.Drawing.Point(19, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 62);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(79, 102);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(180, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
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
            this.panelMayor.Location = new System.Drawing.Point(334, 172);
            this.panelMayor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMayor.Name = "panelMayor";
            this.panelMayor.Size = new System.Drawing.Size(248, 236);
            this.panelMayor.TabIndex = 14;
            // 
            // lblresultado2
            // 
            this.lblresultado2.AutoSize = true;
            this.lblresultado2.Location = new System.Drawing.Point(22, 211);
            this.lblresultado2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblresultado2.Name = "lblresultado2";
            this.lblresultado2.Size = new System.Drawing.Size(50, 13);
            this.lblresultado2.TabIndex = 20;
            this.lblresultado2.Text = "resultado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 181);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Resultado (precio por caja):";
            // 
            // numPrecioTotal
            // 
            this.numPrecioTotal.DecimalPlaces = 2;
            this.numPrecioTotal.Location = new System.Drawing.Point(116, 126);
            this.numPrecioTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numPrecioTotal.Name = "numPrecioTotal";
            this.numPrecioTotal.Size = new System.Drawing.Size(66, 20);
            this.numPrecioTotal.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Precio total:";
            // 
            // numUnidadesPorCaja
            // 
            this.numUnidadesPorCaja.Location = new System.Drawing.Point(115, 80);
            this.numUnidadesPorCaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numUnidadesPorCaja.Name = "numUnidadesPorCaja";
            this.numUnidadesPorCaja.Size = new System.Drawing.Size(66, 20);
            this.numUnidadesPorCaja.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Unidades por caja:";
            // 
            // numCantCaja
            // 
            this.numCantCaja.Location = new System.Drawing.Point(116, 32);
            this.numCantCaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numCantCaja.Name = "numCantCaja";
            this.numCantCaja.Size = new System.Drawing.Size(66, 20);
            this.numCantCaja.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
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
            this.panelUnidad.Location = new System.Drawing.Point(32, 172);
            this.panelUnidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelUnidad.Name = "panelUnidad";
            this.panelUnidad.Size = new System.Drawing.Size(226, 236);
            this.panelUnidad.TabIndex = 15;
            // 
            // lblResultado1
            // 
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.Location = new System.Drawing.Point(18, 211);
            this.lblResultado1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(50, 13);
            this.lblResultado1.TabIndex = 21;
            this.lblResultado1.Text = "resultado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 181);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Resultado (precio por total):";
            // 
            // numPrecioPorUnidad
            // 
            this.numPrecioPorUnidad.DecimalPlaces = 2;
            this.numPrecioPorUnidad.Location = new System.Drawing.Point(112, 87);
            this.numPrecioPorUnidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numPrecioPorUnidad.Name = "numPrecioPorUnidad";
            this.numPrecioPorUnidad.Size = new System.Drawing.Size(66, 20);
            this.numPrecioPorUnidad.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio por unidad:";
            // 
            // numUnidades
            // 
            this.numUnidades.Location = new System.Drawing.Point(74, 36);
            this.numUnidades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numUnidades.Name = "numUnidades";
            this.numUnidades.Size = new System.Drawing.Size(66, 20);
            this.numUnidades.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unidades:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Opcion por unidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 157);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Opcion por mayor:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(462, 102);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(89, 31);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // rdbUnidad
            // 
            this.rdbUnidad.AutoSize = true;
            this.rdbUnidad.Location = new System.Drawing.Point(132, 153);
            this.rdbUnidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbUnidad.Name = "rdbUnidad";
            this.rdbUnidad.Size = new System.Drawing.Size(34, 17);
            this.rdbUnidad.TabIndex = 19;
            this.rdbUnidad.TabStop = true;
            this.rdbUnidad.Text = "Si";
            this.rdbUnidad.UseVisualStyleBackColor = true;
            this.rdbUnidad.CheckedChanged += new System.EventHandler(this.rdbUnidad_CheckedChanged);
            // 
            // rdbMayor
            // 
            this.rdbMayor.AutoSize = true;
            this.rdbMayor.Location = new System.Drawing.Point(430, 154);
            this.rdbMayor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbMayor.Name = "rdbMayor";
            this.rdbMayor.Size = new System.Drawing.Size(34, 17);
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
            this.cboProveedores.Location = new System.Drawing.Point(430, 62);
            this.cboProveedores.Name = "cboProveedores";
            this.cboProveedores.Size = new System.Drawing.Size(121, 21);
            this.cboProveedores.TabIndex = 21;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(331, 65);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 22;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // FrmRegistrar_Producto_Comprado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 482);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}