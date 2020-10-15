using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackManager_v2.GUI.Gastos
{
    public partial class FrmConsultar_Gasto : Form
    {
        public FrmConsultar_Gasto()
        {
            InitializeComponent();
        }

        private void FrmConsultar_Gasto_Load(object sender, EventArgs e)
        {
            Defecto();
        }

        private void Defecto()
        {
            dgvResumen.Rows.Clear();
        }
    }
}
