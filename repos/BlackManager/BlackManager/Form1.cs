using BlackManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvPrueba.DataSource = BDhelper.Instance.ConsultarTabla("Marca");
            if (BDhelper.Instance.Exist("marca", "nombre", "Quilmes"))
                MessageBox.Show("Si se econtro y si existe");
            else
                MessageBox.Show("Nop, no se encontro bro");
            
        }
    }
}
