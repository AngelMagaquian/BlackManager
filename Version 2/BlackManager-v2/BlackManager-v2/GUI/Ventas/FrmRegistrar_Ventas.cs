﻿using BlackManager.Logica_Negocio;
using System;
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

namespace BlackManager_v2.GUI.Ventas
{
    public partial class FrmRegistrar_Ventas : Form
    {
        public FrmRegistrar_Ventas()
        {
            InitializeComponent();
        }

        private void FrmRegistrar_Ventas_Load(object sender, EventArgs e)
        {
            Metodo_Pago miMP = new Metodo_Pago();
            Reutilizable.LlenarCombo(cboMetodoPago, miMP.ObtenerTodos(), "nombre", "id");
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar_Ventas ventana = new FrmConsultar_Ventas();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            FrmRegistrar_Ventas ventana = new FrmRegistrar_Ventas();
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
    }
}