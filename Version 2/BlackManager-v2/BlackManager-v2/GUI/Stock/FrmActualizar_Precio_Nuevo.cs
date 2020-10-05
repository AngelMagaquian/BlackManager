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

namespace BlackManager_v2.GUI.Stock
{
    public partial class FrmActualizar_Precio_Nuevo : Form
    {
        long myId;
        Producto producto;
        public FrmActualizar_Precio_Nuevo(long id)
        {
            InitializeComponent();
            myId = id;
        }


        private void FrmActualizar_Precio_Nuevo_Load(object sender, EventArgs e)
        {
            producto = Producto.ObtenerPorID(myId);
            LlenarForm();
        }

        private void LlenarForm()
        {
            txtNombre.Text = producto.nombre;
            txtMarca.Text = producto.id_marca.ToString();
            txtPrecioAnterior.Text = producto.precio.ToString();
        }
    }
}
