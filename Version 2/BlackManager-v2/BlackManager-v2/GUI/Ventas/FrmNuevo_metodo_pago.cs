using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BlackManager_v2.Logica_Negocio;

namespace BlackManager_v2.GUI.Ventas
{
    public partial class FrmNuevo_metodo_pago : Form
    {
        /*
         * Primero se debe buscar si el metodo existe "WHERE NOMBRE LIKE 'txtnombre%'"
         * Si lo encuentra, lo actualiza, si no lo encentra lo agrega
         * 
         * 
         */
        public FrmNuevo_metodo_pago()
        {
            InitializeComponent();
        }

        private void FrmNuevo_metodo_pago_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Metodo_Pago nuevoMetodo = new Metodo_Pago();
            nuevoMetodo.descripcion = txtDescripcion.Text;
            nuevoMetodo.nombre = txtNombre.Text;
            nuevoMetodo.recargo = double.Parse(numRecargo.Value.ToString());

            if (nuevoMetodo.NuevoMetodoPago(nuevoMetodo))
                MessageBox.Show("Nuevo Metodo de pago añadido con exito", "Nuevo Metodo de pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error en la insercion del nuevo metodo de pago", "Nuevo Metodo de pago", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
