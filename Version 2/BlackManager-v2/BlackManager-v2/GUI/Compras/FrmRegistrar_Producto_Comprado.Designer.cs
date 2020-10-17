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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblresultado2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numPrecioTotal = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numUnidadesPorCaja = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numCantCaja = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numPrecioPorUnidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numUnidades = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidadesPorCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantCaja)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(239, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(105, 125);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(239, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblresultado2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.numPrecioTotal);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numUnidadesPorCaja);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numCantCaja);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(446, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 291);
            this.panel1.TabIndex = 14;
            // 
            // lblresultado2
            // 
            this.lblresultado2.AutoSize = true;
            this.lblresultado2.Location = new System.Drawing.Point(30, 260);
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
            this.numPrecioTotal.Location = new System.Drawing.Point(154, 155);
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
            this.numUnidadesPorCaja.Location = new System.Drawing.Point(153, 99);
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
            this.numCantCaja.Location = new System.Drawing.Point(154, 40);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.lblResultado1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.numPrecioPorUnidad);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.numUnidades);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(43, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 291);
            this.panel2.TabIndex = 15;
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
            this.label8.Location = new System.Drawing.Point(41, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Opcion por unidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Opcion por mayor:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(846, 449);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(119, 54);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // FrmRegistrar_Producto_Comprado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 593);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrar_Producto_Comprado";
            this.Text = "FrmRegistrar_Producto_Comprado";
            this.Load += new System.EventHandler(this.FrmRegistrar_Producto_Comprado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidadesPorCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantCaja)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblresultado2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numPrecioTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numUnidadesPorCaja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCantCaja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblResultado1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numPrecioPorUnidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUnidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCargar;
    }
}