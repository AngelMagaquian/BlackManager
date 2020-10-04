using BlackManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackManager.Logic;
using BlackManager.Reutilizables;
using BlackManager.Logica_Negocio;

namespace BlackManager.GUI.Ventas
{
    public partial class FrmRegistar_Venta : Form
    {
        public FrmRegistar_Venta()
        {
            InitializeComponent();
        }
        Proveedor prov = new Proveedor();



        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            cboMetodoPago.Enabled = false;
        }


        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cboMetodoPago.Enabled = true;
        }

        private void FrmRegistar_Venta_Load(object sender, EventArgs e)
        {
            Metodo_Pago miMP = new Metodo_Pago();
            Reusar.LlenarCombo(cboMetodoPago, miMP.ObtenerTodos(), "nombre", "id");

        }

        private void consultarStockActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //FrmConsultar_Stock window
        }
    }
}
