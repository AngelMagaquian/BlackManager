namespace BlackManager_v2.GUI.Stock
{
    partial class FrmConsultar_Stock
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
            this.btnStock_Completo = new System.Windows.Forms.Button();
            this.cmbMarcas = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStock_Completo
            // 
            this.btnStock_Completo.Location = new System.Drawing.Point(677, 229);
            this.btnStock_Completo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStock_Completo.Name = "btnStock_Completo";
            this.btnStock_Completo.Size = new System.Drawing.Size(86, 47);
            this.btnStock_Completo.TabIndex = 34;
            this.btnStock_Completo.Text = "Ver Stock Completo";
            this.btnStock_Completo.UseVisualStyleBackColor = true;
            // 
            // cmbMarcas
            // 
            this.cmbMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMarcas.FormattingEnabled = true;
            this.cmbMarcas.Location = new System.Drawing.Point(540, 137);
            this.cmbMarcas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMarcas.Name = "cmbMarcas";
            this.cmbMarcas.Size = new System.Drawing.Size(126, 21);
            this.cmbMarcas.TabIndex = 33;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(677, 137);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(86, 21);
            this.btnCargar.TabIndex = 32;
            this.btnCargar.Text = "Buscar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Consultar Stock Actual";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(533, 95);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(209, 26);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "Seleccionar Marca";
            // 
            // dgvResumen
            // 
            this.dgvResumen.AllowUserToAddRows = false;
            this.dgvResumen.AllowUserToDeleteRows = false;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre});
            this.dgvResumen.Location = new System.Drawing.Point(9, 95);
            this.dgvResumen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.ReadOnly = true;
            this.dgvResumen.RowHeadersWidth = 51;
            this.dgvResumen.RowTemplate.Height = 24;
            this.dgvResumen.Size = new System.Drawing.Size(520, 349);
            this.dgvResumen.TabIndex = 29;
            // 
            // id
            // 
            this.id.HeaderText = "Codigo";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Producto";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // FrmConsultar_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 481);
            this.Controls.Add(this.btnStock_Completo);
            this.Controls.Add(this.cmbMarcas);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvResumen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmConsultar_Stock";
            this.Text = "FrmConsultar_Stock";
            this.Load += new System.EventHandler(this.FrmConsultar_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStock_Completo;
        private System.Windows.Forms.ComboBox cmbMarcas;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}