using BlackManager.Logica_Negocio;
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
using BlackManager_v2.Logica_Negocio;
using BlackManager_v2.GUI.Compras;
using BlackManager_v2.Reportes;
using System.Drawing.Imaging;

namespace BlackManager_v2.GUI.Ventas
{
    public partial class FrmRegistrar_Ventas : Form
    {
        Producto prod;
        public FrmRegistrar_Ventas()
        {
            InitializeComponent();
        }
        //hacer aca la global
        public static double total = 0.00;
        private void FrmRegistrar_Ventas_Load(object sender, EventArgs e)
        {
            defecto();
        }
        private void txtCodigo_Producto_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo_Producto.Text))
                prod = null;
            else
            {
                try //Busca el producto en la bd y si lo encuentra lo añade a la grilla, sino muestra mensaje de error.
                {
                    prod = Producto.ObtenerPorID(long.Parse(txtCodigo_Producto.Text));
                    AgregarProductoAGrilla(prod);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El codigo del producto no existe en la base de datos",
                        "Producto Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void AgregarProductoAGrilla(Producto p)
        {
            int row = ExisteProd(p.Id);
            if (row == -1)
            {
                dgvResumen.Rows.Add(p.Id, p.nombre, p.nom_marca, 1, p.precio, p.precio);
                total += p.precio;
                lblTotal.Text = total.ToString();
                txtCodigo_Producto.Text = "";
                txtCodigo_Producto.Focus();
            }
            else
            {
                int actual = int.Parse(dgvResumen.Rows[row].Cells["cantidad"].Value.ToString());
                actual += 1;
                dgvResumen.Rows[row].Cells["cantidad"].Value = actual;
                double subtotal = (double)actual * p.precio;
                dgvResumen.Rows[row].Cells["subtot"].Value = subtotal;
                total += subtotal;
                lblTotal.Text= total.ToString();
                txtCodigo_Producto.Text="";
                txtCodigo_Producto.Focus();
            }
         
           prod = null;
            
        }

        private int ExisteProd(long id_prod)
        {
            for (int i=0; i < dgvResumen.Rows.Count; i++)
            {
                long id_enGrilla = long.Parse(dgvResumen.Rows[i].Cells["cod_prod"].Value.ToString());
                if (id_prod - id_enGrilla == 0)
                    return i;
            }
            return -1;
        }
        private void btnConfirmar_Venta_Click(object sender, EventArgs e)
        {
            List<Detalle_Venta> detalles = new List<Detalle_Venta>();
            foreach (DataGridViewRow data in dgvResumen.Rows)
            {
                detalles.Add(Detalle_Venta.Parse(data));
            }
            int mp = int.Parse(cboMetodoPago.SelectedValue.ToString());
            double total = double.Parse(lblTotal.Text);

            Venta.AgregarVenta(mp, total, detalles);
            defecto();
            MessageBox.Show("Venta registrada con exito", "Registro Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void defecto()
        {
            //Limpiar Grilla
            dgvResumen.Rows.Clear();
            //Limpiar txt y enfocarlo
            txtCodigo_Producto.Clear();
            txtCodigo_Producto.Focus();
            //llenar cbo y dejarlo seleccionando 0
            Metodo_Pago miMP = new Metodo_Pago();
            Reutilizable.LlenarCombo(cboMetodoPago, miMP.ObtenerTodos(), "nombre", "id");
            cboMetodoPago.SelectedIndex = 0;
            //limpiar lbls de total y vuelto
            lblTotal.Text = "0.00";
            lblVuelto.Text = "0.00";
            //poner el valor por defecto de num
            numVuelto.Value = 0;
            prod = null;
        }


        //------------------------------Tool Strip Menu--------------------------------//
        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar_Ventas ventana = new FrmConsultar_Ventas();
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

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrar_Compra ventana = new FrmRegistrar_Compra();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void consultarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar_Compra ventana = new FrmConsultar_Compra();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevo_Proveedor ventana = new FrmNuevo_Proveedor();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            defecto();
        }

        private void numVuelto_ValueChanged(object sender, EventArgs e)
        {
            double vuelto = decimal.ToDouble(numVuelto.Value);
            vuelto = vuelto-total;
            lblVuelto.Text = vuelto.ToString();
        }
    }
}
