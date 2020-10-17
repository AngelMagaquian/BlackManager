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
    public partial class FrmRegistrar_Compra : Form
    {
        public FrmRegistrar_Compra()
        {
            InitializeComponent();
        }

        private void FrmRegistrar_Compra_Load(object sender, EventArgs e)
        {
            Marca all = new Marca();
            Reutilizable.LlenarCombo(cboMarcas, all.ObtenerTodos(), "nombre", "id");
        }
    }
}
