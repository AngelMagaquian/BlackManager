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
    public partial class FrmActualizar_Precio : Form
    {
        long id_prod;
        public FrmActualizar_Precio()
        {
            InitializeComponent();
        }



        private void FrmActualizar_Precio_Load(object sender, EventArgs e)
        {
            Marca m = new Marca();
            Reutilizable.LlenarCombo(cboMarcas, m.ObtenerTodos(), "nombre", "id");
            Producto.Llenar_grilla(dgvPrecios);

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
    }
}
