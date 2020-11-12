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

namespace BlackManager_v2.GUI.Gastos
{
    public partial class FrmRegistrar_Gasato : Form
    {
        public FrmRegistrar_Gasato()
        {
            InitializeComponent();
        }


        private void FrmRegistrar_Gasato_Load(object sender, EventArgs e)
        {
            Defecto();
        }

        private void Defecto()
        {
            txtDescripcion.Clear();
            txtProducto.Clear();
            numMonto.Value = 0;
            txtProducto.Focus();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Gasto save = Gasto.Parse(txtDescripcion.Text, double.Parse(numMonto.Value.ToString()), txtProducto.Text);
            save.AgregarGasto(save);
            MessageBox.Show("Gasto registrado con exito", "Gasto Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
