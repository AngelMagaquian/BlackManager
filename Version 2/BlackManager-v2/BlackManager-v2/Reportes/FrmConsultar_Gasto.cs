using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BlackManager_v2.Logica_Negocio;

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
            lblTotal.Text = "$" + "0.00";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Gasto gastos = new Gasto();
            dgvResumen.DataSource = gastos.ConsultarGastos(dtpDesde.Value, dtpHasta.Value);
            dgvResumen.Refresh();

        }

        private void btnGastosHoy_Click(object sender, EventArgs e)
        {
            Gasto gastos = new Gasto();
            dgvResumen.DataSource = gastos.ConsultarGastos(DateTime.Today, DateTime.Now);
            dgvResumen.Refresh();
        }
    }
}
