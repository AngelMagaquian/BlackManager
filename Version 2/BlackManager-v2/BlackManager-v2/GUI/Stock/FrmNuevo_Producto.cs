using BlackManager.Logica_Negocio;
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
using BlackManager_v2.GUI.Stock;
using BlackManager_v2.GUI.Gastos;
using BlackManager_v2.GUI.Compras;
using BlackManager_v2.GUI.Ventas;

namespace BlackManager_v2.GUI.Stock
{
    public partial class FrmNuevo_Producto : Form
    {
        public FrmNuevo_Producto()
        {
            InitializeComponent();
        }

        private void FrmNuevo_Producto_Load(object sender, EventArgs e)
        {
            Defecto();
        }

        private void Defecto()
        {
            Marca marcas = new Marca();
            Reutilizable.LlenarCombo(cboMarca, marcas.ObtenerTodos(), "nombre", "id");
            cboMarca.SelectedIndex = 0;

            txtProducto.Clear();
            txtProducto.Focus();
            txtNombre.Clear();
            txtTipo.Clear();

            numPrecio.Value = 0;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            long id = Int64.Parse(txtProducto.Text);
            Producto nuevo = Producto.Parse(id,
                                            int.Parse(cboMarca.SelectedValue.ToString()),
                                            txtNombre.Text,
                                            txtTipo.Text,
                                            double.Parse(numPrecio.Value.ToString()));
            Producto.Agregar_Producto(nuevo);
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

        private void consultarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnNueva_Marca_Click(object sender, EventArgs e)
        {
            FrmNueva_Marca ventana = new FrmNueva_Marca();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }
    }
}
