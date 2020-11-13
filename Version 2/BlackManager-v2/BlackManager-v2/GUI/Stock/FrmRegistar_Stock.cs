﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackManager_v2.GUI.Stock;
using BlackManager_v2.GUI.Gastos;
using BlackManager_v2.GUI.Compras;
using BlackManager_v2.GUI.Ventas;
using BlackManager_v2.Logica_Negocio;


namespace BlackManager_v2.GUI.Stock
{
    public partial class FrmRegistar_Stock : Form
    {
        public FrmRegistar_Stock()
        {
            InitializeComponent();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrar_Ventas ventana = new FrmRegistrar_Ventas();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar_Ventas ventana = new FrmConsultar_Ventas();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void registrarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistar_Stock ventana = new FrmRegistar_Stock();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void consultarStockActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar_Stock ventana = new FrmConsultar_Stock();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void actualizarPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizar_Precio ventana = new FrmActualizar_Precio();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevo_Producto ventana = new FrmNuevo_Producto();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }


        private void registrarGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrar_Gasato ventana = new FrmRegistrar_Gasato();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void consultarGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar_Gasto ventana = new FrmConsultar_Gasto();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void FrmRegistar_Stock_Load(object sender, EventArgs e)
        {
            Marca all = new Marca();
            Reutilizable.LlenarCombo(cboMarcas, all.ObtenerTodos(), "nombre", "id");
        }

        private void Defecto()
        {
            dgvResumen.Rows.Clear();
            Marca marcas = new Marca();
            Reutilizable.LlenarCombo(cboMarcas, marcas.ObtenerTodos(), "nombre", "id");
            cboMarcas.SelectedIndex = 0;
            //se debe llenar la grilla tmb
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //dgvResumen.Rows.Clear();
            Producto.Llenar_Grilla_Marca(dgvResumen, int.Parse(cboMarcas.SelectedValue.ToString()));
            dgvResumen.Refresh();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            long id_prod = long.Parse(dgvResumen.SelectedRows[0].Cells["id_producto"].Value.ToString());
            FrmRegistrar_Producto_Comprado ventana = new FrmRegistrar_Producto_Comprado(id_prod);
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }
    }
}
