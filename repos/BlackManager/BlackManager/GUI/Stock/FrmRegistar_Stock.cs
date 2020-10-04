using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackManager.Reutilizables;
using System.Windows.Forms;
using BlackManager.Logic;

namespace BlackManager.GUI.Stock
{
    public partial class FrmRegistar_Stock : Form
    {
        public FrmRegistar_Stock()
        {
            InitializeComponent();
        }

        private void FrmRegistar_Stock_Load(object sender, EventArgs e)
        {
            Marca AllMarcas = new Marca();
            Reusar.LlenarCombo(cboMarcas, AllMarcas.ObtenerTodos(), "nombre", "id_marca");
        }
    }
}
