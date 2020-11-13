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
using BlackManager_v2.Logica_Negocio;

namespace BlackManager_v2.GUI.Stock
{
    public partial class FrmConsultar_Stock : Form
    {
        public FrmConsultar_Stock()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Producto.Llenar_Grilla_Marca(dgvResumen, int.Parse(cboMarcas.SelectedValue.ToString()));
            dgvResumen.Refresh();
        }

        private void FrmConsultar_Stock_Load(object sender, EventArgs e)
        {
            Marca all = new Marca();
            Reutilizable.LlenarCombo(cboMarcas, all.ObtenerTodos(), "nombre", "id");
        }

        private void Defecto()
        {
            dgvResumen.Refresh();
            
            Marca m = new Marca();
            Reutilizable.LlenarCombo(cboMarcas, m.ObtenerTodos(), "nombre", "id");
            cboMarcas.SelectedIndex = 0;
        }

        private void Defecto2()
        {
            dgvResumen.Rows.Clear();
            
            Marca m = new Marca();
            Reutilizable.LlenarCombo(cboMarcas, m.ObtenerTodos(), "nombre", "id");
            cboMarcas.SelectedIndex = 0;
        }

        private void btnStock_Completo_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            dgvResumen.DataSource = prod.ConsultarProductos();
            dgvResumen.Refresh();
        }
    }
}
