namespace BlackManager_v2.GUI.Ventas
{
    partial class FrmRegistrar_Ventas
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.lblMetodo1 = new System.Windows.Forms.Label();
            this.gastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarStockActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfirmar_Venta = new System.Windows.Forms.Button();
            this.cboMetodoPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo_Producto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numVuelto = new System.Windows.Forms.NumericUpDown();
            this.lblPagacon1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.cod_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVuelto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(-189, 443);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 65);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar Venta";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadisticasDeVentasToolStripMenuItem,
            this.balanceToolStripMenuItem});
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // estadisticasDeVentasToolStripMenuItem
            // 
            this.estadisticasDeVentasToolStripMenuItem.Name = "estadisticasDeVentasToolStripMenuItem";
            this.estadisticasDeVentasToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.estadisticasDeVentasToolStripMenuItem.Text = "Estadisticas de ventas";
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.balanceToolStripMenuItem.Text = "Balance";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVentaToolStripMenuItem,
            this.consultarVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // registrarVentaToolStripMenuItem
            // 
            this.registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            this.registrarVentaToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.registrarVentaToolStripMenuItem.Text = "Registrar venta";
            this.registrarVentaToolStripMenuItem.Click += new System.EventHandler(this.registrarVentaToolStripMenuItem_Click);
            // 
            // consultarVentasToolStripMenuItem
            // 
            this.consultarVentasToolStripMenuItem.Name = "consultarVentasToolStripMenuItem";
            this.consultarVentasToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.consultarVentasToolStripMenuItem.Text = "Consultar ventas";
            this.consultarVentasToolStripMenuItem.Click += new System.EventHandler(this.consultarVentasToolStripMenuItem_Click);
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Location = new System.Drawing.Point(-193, 298);
            this.optTarjeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(74, 21);
            this.optTarjeta.TabIndex = 31;
            this.optTarjeta.Text = "Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Checked = true;
            this.optEfectivo.Location = new System.Drawing.Point(-193, 255);
            this.optEfectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(79, 21);
            this.optEfectivo.TabIndex = 30;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblMetodo1
            // 
            this.lblMetodo1.AutoSize = true;
            this.lblMetodo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodo1.Location = new System.Drawing.Point(-197, 210);
            this.lblMetodo1.Name = "lblMetodo1";
            this.lblMetodo1.Size = new System.Drawing.Size(150, 20);
            this.lblMetodo1.TabIndex = 29;
            this.lblMetodo1.Text = "Método de Pago:";
            // 
            // gastosToolStripMenuItem
            // 
            this.gastosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarGastoToolStripMenuItem,
            this.consultarGastosToolStripMenuItem});
            this.gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            this.gastosToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.gastosToolStripMenuItem.Text = "Gastos";
            // 
            // registrarGastoToolStripMenuItem
            // 
            this.registrarGastoToolStripMenuItem.Name = "registrarGastoToolStripMenuItem";
            this.registrarGastoToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.registrarGastoToolStripMenuItem.Text = "Registrar gasto";
            this.registrarGastoToolStripMenuItem.Click += new System.EventHandler(this.registrarGastoToolStripMenuItem_Click);
            // 
            // consultarGastosToolStripMenuItem
            // 
            this.consultarGastosToolStripMenuItem.Name = "consultarGastosToolStripMenuItem";
            this.consultarGastosToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.consultarGastosToolStripMenuItem.Text = "Consultar gastos";
            this.consultarGastosToolStripMenuItem.Click += new System.EventHandler(this.consultarGastosToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarStockToolStripMenuItem,
            this.consultarStockActualToolStripMenuItem,
            this.actualizarPrecioToolStripMenuItem,
            this.nuevoProductoToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // registrarStockToolStripMenuItem
            // 
            this.registrarStockToolStripMenuItem.Name = "registrarStockToolStripMenuItem";
            this.registrarStockToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.registrarStockToolStripMenuItem.Text = "Registrar stock";
            this.registrarStockToolStripMenuItem.Click += new System.EventHandler(this.registrarStockToolStripMenuItem_Click);
            // 
            // consultarStockActualToolStripMenuItem
            // 
            this.consultarStockActualToolStripMenuItem.Name = "consultarStockActualToolStripMenuItem";
            this.consultarStockActualToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.consultarStockActualToolStripMenuItem.Text = "Consultar stock actual";
            this.consultarStockActualToolStripMenuItem.Click += new System.EventHandler(this.consultarStockActualToolStripMenuItem_Click);
            // 
            // actualizarPrecioToolStripMenuItem
            // 
            this.actualizarPrecioToolStripMenuItem.Name = "actualizarPrecioToolStripMenuItem";
            this.actualizarPrecioToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.actualizarPrecioToolStripMenuItem.Text = "Actualizar precio";
            this.actualizarPrecioToolStripMenuItem.Click += new System.EventHandler(this.actualizarPrecioToolStripMenuItem_Click);
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo Producto";
            this.nuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProductoToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCompraToolStripMenuItem,
            this.consultarComprasToolStripMenuItem,
            this.nuevoProveedorToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // registrarCompraToolStripMenuItem
            // 
            this.registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            this.registrarCompraToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.registrarCompraToolStripMenuItem.Text = "Registrar compra";
            this.registrarCompraToolStripMenuItem.Click += new System.EventHandler(this.registrarCompraToolStripMenuItem_Click);
            // 
            // consultarComprasToolStripMenuItem
            // 
            this.consultarComprasToolStripMenuItem.Name = "consultarComprasToolStripMenuItem";
            this.consultarComprasToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.consultarComprasToolStripMenuItem.Text = "Consultar compras";
            this.consultarComprasToolStripMenuItem.Click += new System.EventHandler(this.consultarComprasToolStripMenuItem_Click);
            // 
            // nuevoProveedorToolStripMenuItem
            // 
            this.nuevoProveedorToolStripMenuItem.Name = "nuevoProveedorToolStripMenuItem";
            this.nuevoProveedorToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.nuevoProveedorToolStripMenuItem.Text = "Nuevo proveedor";
            this.nuevoProveedorToolStripMenuItem.Click += new System.EventHandler(this.nuevoProveedorToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.gastosToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(943, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelto.Location = new System.Drawing.Point(185, 554);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(66, 25);
            this.lblVuelto.TabIndex = 10;
            this.lblVuelto.Text = "15.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "El vuelto es: $";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 535);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 65);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancelar Venta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfirmar_Venta
            // 
            this.btnConfirmar_Venta.Location = new System.Drawing.Point(735, 535);
            this.btnConfirmar_Venta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmar_Venta.Name = "btnConfirmar_Venta";
            this.btnConfirmar_Venta.Size = new System.Drawing.Size(141, 65);
            this.btnConfirmar_Venta.TabIndex = 11;
            this.btnConfirmar_Venta.Text = "Confirmar Venta";
            this.btnConfirmar_Venta.UseVisualStyleBackColor = true;
            this.btnConfirmar_Venta.Click += new System.EventHandler(this.btnConfirmar_Venta_Click);
            // 
            // cboMetodoPago
            // 
            this.cboMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMetodoPago.FormattingEnabled = true;
            this.cboMetodoPago.Location = new System.Drawing.Point(224, 97);
            this.cboMetodoPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMetodoPago.Name = "cboMetodoPago";
            this.cboMetodoPago.Size = new System.Drawing.Size(121, 24);
            this.cboMetodoPago.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Método de Pago:";
            // 
            // txtCodigo_Producto
            // 
            this.txtCodigo_Producto.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo_Producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo_Producto.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtCodigo_Producto.Location = new System.Drawing.Point(224, 58);
            this.txtCodigo_Producto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo_Producto.Name = "txtCodigo_Producto";
            this.txtCodigo_Producto.Size = new System.Drawing.Size(227, 22);
            this.txtCodigo_Producto.TabIndex = 1;
            this.txtCodigo_Producto.TextChanged += new System.EventHandler(this.txtCodigo_Producto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código de Producto:";
            // 
            // numVuelto
            // 
            this.numVuelto.DecimalPlaces = 2;
            this.numVuelto.Location = new System.Drawing.Point(512, 492);
            this.numVuelto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numVuelto.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.numVuelto.Name = "numVuelto";
            this.numVuelto.Size = new System.Drawing.Size(120, 22);
            this.numVuelto.TabIndex = 8;
            this.numVuelto.ValueChanged += new System.EventHandler(this.numVuelto_ValueChanged);
            // 
            // lblPagacon1
            // 
            this.lblPagacon1.AutoSize = true;
            this.lblPagacon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagacon1.Location = new System.Drawing.Point(348, 489);
            this.lblPagacon1.Name = "lblPagacon1";
            this.lblPagacon1.Size = new System.Drawing.Size(128, 25);
            this.lblPagacon1.TabIndex = 7;
            this.lblPagacon1.Text = "Paga con: $";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(142, 483);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(109, 32);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "200.00";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal1.Location = new System.Drawing.Point(11, 482);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(118, 32);
            this.lblTotal1.TabIndex = 5;
            this.lblTotal1.Text = "Total: $";
            // 
            // dgvResumen
            // 
            this.dgvResumen.AllowUserToAddRows = false;
            this.dgvResumen.AllowUserToDeleteRows = false;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_prod,
            this.nombre,
            this.marca,
            this.cantidad,
            this.precio,
            this.subtot});
            this.dgvResumen.Location = new System.Drawing.Point(11, 149);
            this.dgvResumen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.RowHeadersWidth = 51;
            this.dgvResumen.RowTemplate.Height = 24;
            this.dgvResumen.Size = new System.Drawing.Size(880, 331);
            this.dgvResumen.TabIndex = 4;
            // 
            // cod_prod
            // 
            this.cod_prod.HeaderText = "Cod Poducto";
            this.cod_prod.MinimumWidth = 6;
            this.cod_prod.Name = "cod_prod";
            this.cod_prod.ReadOnly = true;
            this.cod_prod.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Producto";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.MinimumWidth = 6;
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 125;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 125;
            // 
            // subtot
            // 
            this.subtot.HeaderText = "Subtotal";
            this.subtot.MinimumWidth = 6;
            this.subtot.Name = "subtot";
            this.subtot.ReadOnly = true;
            this.subtot.Width = 125;
            // 
            // FrmRegistrar_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 638);
            this.Controls.Add(this.lblVuelto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConfirmar_Venta);
            this.Controls.Add(this.cboMetodoPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo_Producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numVuelto);
            this.Controls.Add(this.lblPagacon1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotal1);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.optTarjeta);
            this.Controls.Add(this.optEfectivo);
            this.Controls.Add(this.lblMetodo1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRegistrar_Ventas";
            this.Text = "FrmRegistrar_Ventas";
            this.Load += new System.EventHandler(this.FrmRegistrar_Ventas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVuelto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVentasToolStripMenuItem;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.Label lblMetodo1;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarGastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarStockActualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarPrecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarComprasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConfirmar_Venta;
        private System.Windows.Forms.ComboBox cboMetodoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo_Producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numVuelto;
        private System.Windows.Forms.Label lblPagacon1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtot;
        private System.Windows.Forms.ToolStripMenuItem nuevoProveedorToolStripMenuItem;
    }
}