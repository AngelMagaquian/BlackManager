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

namespace BlackManager_v2.GUI.Ventas
{
    public partial class FrmRegistrar_Ventas : Form
    {
        public FrmRegistrar_Ventas()
        {
            InitializeComponent();
        }

        private void FrmRegistrar_Ventas_Load(object sender, EventArgs e)
        {
            Metodo_Pago miMP = new Metodo_Pago();
            Reutilizable.LlenarCombo(cboMetodoPago, miMP.ObtenerTodos(), "nombre", "id");
        }
        private void txtCodigo_Producto_TextChanged(object sender, EventArgs e)
        {
            Producto prod = Producto.ObtenerPorID(long.Parse(txtCodigo_Producto.Text));
            AgregarProductoAGrilla(prod);
        }

        private void AgregarProductoAGrilla(Producto p)
        {
            int row = ExisteProd(p.Id);
            if (row != -1)
            {
                dgvResumen.Rows.Add(p.Id, p.nombre, p.nom_marca, 1, p.precio, p.precio);
                p.cantidad -= 1;
            }
            else
            {
                int actual = int.Parse(dgvResumen.Rows[row].Cells["cantidad"].Value.ToString());
                p.cantidad -= 1;
                actual += 1;
                dgvResumen.Rows[row].Cells["cantidad"].Value = actual;
                double subtotal = (double)p.cantidad * p.precio;
                dgvResumen.Rows[row].Cells["subtot"].Value = subtotal;
            }
            
        }

        private int ExisteProd(long id_prod)
        {
            for (int i=0; i < dgvResumen.Rows.Count; i++)
            {
                if (id_prod - long.Parse(dgvResumen.Rows[i].Cells["id_prod"].Value.ToString()) == 0)
                    return i;
            }
            return -1;
        }
        private void btnConfirmar_Venta_Click(object sender, EventArgs e)
        {

        }
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
    }
}
