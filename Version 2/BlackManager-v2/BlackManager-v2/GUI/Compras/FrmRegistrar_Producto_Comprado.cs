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
    }
}
