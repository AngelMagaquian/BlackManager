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
            Marca marcas = new Marca();
            Reutilizable.LlenarCombo(cboMarca, marcas.ObtenerTodos(), "nombre", "id");
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
    }
}
