using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackManager_v2.Logica_Negocio;

namespace BlackManager_v2.GUI.Ventas
{
    public partial class FrmConsultar_Ventas : Form
    {
        public static double total = 0.00;
        public FrmConsultar_Ventas()
        {
            InitializeComponent();
        }

        private void FrmConsultar_Ventas_Load(object sender, EventArgs e)
        {
            defecto();
        }

        private void defecto()
        {
            dgvResumen.Rows.Clear();
            lblTotal.Text = "$"+"0.00";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Venta ventas = new Venta();
            dgvResumen.DataSource = ventas.ConsultarVentas(dtpDesde.Value.Date, dtpHasta.Value.Date);
            dgvResumen.Refresh();
            Total();
        }

        private void btnVentasHoy_Click(object sender, EventArgs e)
        {
            Venta ventas = new Venta();
            dgvResumen.DataSource = ventas.ConsultarVentas(DateTime.Today.Date, DateTime.Today.Date);
            dgvResumen.Refresh();
            Total();
        }

        private void Total()
        {
            total = 0;
            for (int i = 0; i < dgvResumen.RowCount - 1; i++)
            {
                total += double.Parse(dgvResumen.Rows[i].Cells[3].Value.ToString());
            }
            lblTotal.Text = "$" + total.ToString();
        }
    }
}
