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

namespace BlackManager_v2.Reportes
{
    public partial class FrmConsultar_Compra : Form
    {
        public FrmConsultar_Compra()
        {
            InitializeComponent();
        }

        private void FrmConsultar_Compra_Load(object sender, EventArgs e)
        {
            Defecto();
        }
        private void Defecto()
        {
            dgvResumen.Rows.Clear();
            lblTotal.Text = "$" + "0.00";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Compra comp = new Compra();
            dgvResumen.DataSource = comp.ConsultarCompras(dtpDesde.Value, dtpHasta.Value);
            dgvResumen.Refresh();
        }

        private void btnComprasHoy_Click(object sender, EventArgs e)
        {
            Compra comp = new Compra();
            dgvResumen.DataSource = comp.ConsultarCompras(DateTime.Today, DateTime.Now);
            dgvResumen.Refresh();
        }
    }
}
