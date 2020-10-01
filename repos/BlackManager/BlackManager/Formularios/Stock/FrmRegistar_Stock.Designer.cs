namespace BlackManager.Formularios.Stock
{
    partial class FrmRegistar_Stock
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.btnVentas_Hoy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(711, 129);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(267, 32);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Seleccionar Marca";
            // 
            // dgvResumen
            // 
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Location = new System.Drawing.Point(12, 129);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.RowHeadersWidth = 51;
            this.dgvResumen.RowTemplate.Height = 24;
            this.dgvResumen.Size = new System.Drawing.Size(693, 430);
            this.dgvResumen.TabIndex = 12;
            // 
            // btnVentas_Hoy
            // 
            this.btnVentas_Hoy.Location = new System.Drawing.Point(778, 500);
            this.btnVentas_Hoy.Name = "btnVentas_Hoy";
            this.btnVentas_Hoy.Size = new System.Drawing.Size(130, 59);
            this.btnVentas_Hoy.TabIndex = 11;
            this.btnVentas_Hoy.Text = "Cargar";
            this.btnVentas_Hoy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Registrar Stock";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(717, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // FrmRegistar_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 587);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.btnVentas_Hoy);
            this.Name = "FrmRegistar_Stock";
            this.Text = "FrmRegistar_Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.Button btnVentas_Hoy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}