using System;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BlackManager_v2.DAO;

namespace BlackManager_v2.GUI
{
    public partial class ConfiguracionDeRutaBD : Form
    {
        public ConfiguracionDeRutaBD()
        {
            InitializeComponent();
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos Access | *.accdb";
            open.Title = "Abrir";

            if (open.ShowDialog() == DialogResult.OK)
            {

                txtCadenaConexion.Text = open.FileName;
            }
            open.Dispose();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BDHelper.Instance.cadConexion = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + txtCadenaConexion.Text.Replace("\\", "\\\\");
        }
    }
}
