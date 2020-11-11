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
    public partial class FrmNueva_Marca : Form
    {
        public FrmNueva_Marca()
        {
            InitializeComponent();
        }

        private void FrmNueva_Marca_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }
    }
}
