using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BlackManager_v2.Logica_Negocio;

namespace BlackManager_v2.GUI.Stock
{
    public partial class FrmNueva_Marca : Form
    {
        public FrmNueva_Marca()
        {
            InitializeComponent();
        }

        private void FrmNueva_Marca_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Marca nuevaMarca = new Marca();
            if (nuevaMarca.RegistrarNuevaMarca(txtNombre.Text))
                MessageBox.Show("Marca añadida con exito", "Nueva Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al añadir marca", "Nueva Marca", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
