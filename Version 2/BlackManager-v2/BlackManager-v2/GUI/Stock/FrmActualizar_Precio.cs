using BlackManager_v2.Logica_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackManager_v2.GUI.Ventas;
using BlackManager_v2.GUI.Gastos;
using BlackManager_v2.GUI.Compras;
using BlackManager_v2.GUI.Stock;


namespace BlackManager_v2.GUI.Stock
{
    public partial class FrmActualizar_Precio : Form
    {
        long id_prod;
        public FrmActualizar_Precio()
        {
            InitializeComponent();
        }



        private void FrmActualizar_Precio_Load(object sender, EventArgs e)
        {
            Defecto();

        }

        private void Defecto()
        {
            dgvPrecios.Rows.Clear();
            
            Marca m = new Marca();
            Reutilizable.LlenarCombo(cboMarcas, m.ObtenerTodos(), "nombre", "id");
            Producto.Llenar_grilla(dgvPrecios);
            cboMarcas.SelectedIndex = 0;

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvPrecios.Rows.Clear();
            Producto.Llenar_Grilla_Marca(dgvPrecios,  int.Parse(cboMarcas.SelectedValue.ToString()));
            dgvPrecios.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id_prod = long.Parse(dgvPrecios.SelectedRows[0].Cells[0].Value.ToString());
            FrmActualizar_Precio_Nuevo ventana = new FrmActualizar_Precio_Nuevo(id_prod);
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrar_Ventas ventana = new FrmRegistrar_Ventas();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar_Ventas ventana = new FrmConsultar_Ventas();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void registrarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistar_Stock ventana = new FrmRegistar_Stock();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void consultarStockActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar_Stock ventana = new FrmConsultar_Stock();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void actualizarPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizar_Precio ventana = new FrmActualizar_Precio();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevo_Producto ventana = new FrmNuevo_Producto();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrar_Compra ventana = new FrmRegistrar_Compra();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void registrarGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrar_Gasato ventana = new FrmRegistrar_Gasato();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void consultarGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar_Gasto ventana = new FrmConsultar_Gasto();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }
    }
}
