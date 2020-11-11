using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
