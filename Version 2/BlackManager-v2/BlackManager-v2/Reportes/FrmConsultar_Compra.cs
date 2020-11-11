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
        public static double total = 0.00;
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
            total = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Compra comp = new Compra();
            dgvResumen.DataSource = comp.ConsultarCompras(dtpDesde.Value.Date, dtpHasta.Value.Date);
            dgvResumen.Refresh();
            Total();
        }

        private void btnComprasHoy_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "$0.00";
            total = 0.00;
            Compra comp = new Compra();
            dgvResumen.DataSource = comp.ConsultarCompras(DateTime.Today.Date, DateTime.Now.Date);
            dgvResumen.Refresh();
            Total();
        }

        private void Total()
        {
            for(int i = 0; i < dgvResumen.RowCount -1; i++)
            {
                 total += double.Parse(dgvResumen.Rows[i].Cells[6].Value.ToString()) * double.Parse(dgvResumen.Rows[i].Cells[7].Value.ToString());
            }
            lblTotal.Text = "$"+total.ToString();
        }
    }

  
}
