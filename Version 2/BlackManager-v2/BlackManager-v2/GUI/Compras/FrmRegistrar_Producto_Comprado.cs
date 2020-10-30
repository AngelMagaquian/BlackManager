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

namespace BlackManager_v2.GUI.Compras
{
    public partial class FrmRegistrar_Producto_Comprado : Form
    {
        public FrmRegistrar_Producto_Comprado()
        {
            InitializeComponent();
        }

        private void FrmRegistrar_Producto_Comprado_Load(object sender, EventArgs e)
        {
            Reutilizable.LlenarCombo(cboProveedores, Proveedor.ObtenerTodos(), "nombre", "id");
        }

        private void Defecto()
        {
            txtCodigo.Clear();
            txtNombre.Clear();

            numCantCaja.Value = 0;
            numPrecioPorUnidad.Value = 0;
            numPrecioTotal.Value = 0;
            numUnidades.Value = 0;
            numUnidadesPorCaja.Value = 0;

            lblResultado1.Text = "0.00";
            lblresultado2.Text = "0.00";
        }

        private void rdbUnidad_CheckedChanged(object sender, EventArgs e)
        {
            panelMayor.Enabled = false;
            panelUnidad.Enabled = true;
        }

        private void rdbMayor_CheckedChanged(object sender, EventArgs e)
        {
            panelUnidad.Enabled = false;
            panelMayor.Enabled = true;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (rdbMayor.Checked)
                CompraPorMayor();
            else
                if (rdbUnidad.Checked)
                CompraPorUnidad();

        }

        private void CompraPorMayor()
        {
            float precioUnitario;
            int cantidad;

            cantidad = (int)numCantCaja.Value * (int)numUnidadesPorCaja.Value;
            precioUnitario = (float)numPrecioTotal.Value / (float)cantidad;
            Compra compraNueva;
            compraNueva = Compra.Parse(long.Parse(txtCodigo.Text), int.Parse(cboProveedores.SelectedValue.ToString()), precioUnitario, cantidad);

            compraNueva.RegistrarCompra(compraNueva);
        }
        private void CompraPorUnidad()
        {
            float precioUnitario;
            int cantidad;

            cantidad = int.Parse(numUnidades.Value.ToString());
            precioUnitario = int.Parse(numPrecioPorUnidad.Value.ToString());
            Compra compraNueva;
            compraNueva = Compra.Parse(long.Parse(txtCodigo.Text), int.Parse(cboProveedores.SelectedValue.ToString()), precioUnitario, cantidad);

            compraNueva.RegistrarCompra(compraNueva);
        }

        private void btnNuevoProv_Click(object sender, EventArgs e)
        {
            FrmNuevo_Proveedor ventana = new FrmNuevo_Proveedor();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }
    }
}
