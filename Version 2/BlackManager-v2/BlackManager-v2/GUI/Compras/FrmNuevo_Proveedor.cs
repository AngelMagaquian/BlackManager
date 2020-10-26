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

namespace BlackManager_v2.GUI.Compras
{
    public partial class FrmNuevo_Proveedor : Form
    {
        public FrmNuevo_Proveedor()
        {
            InitializeComponent();
        }


        private void FrmNuevo_Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Proveedor nuevo = new Proveedor();
            if (nuevo.NuevoProveedor(txtNombre.Text))
                MessageBox.Show("Nuevo Proveedor registrado con exito", "Nuevo Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Insercion de nuevo Proveedor fallida", "Nuevo Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
