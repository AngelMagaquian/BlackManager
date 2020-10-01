using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackManager.DAO;
using BlackManager.Logica_Negocio;

namespace BlackManager.Logic
{
    class Marca
    {
        public int id { get; set; }
        public string nombre { get; set; }
        private DAO_Marca oMarca;

        public Marca()
        {
            oMarca = new DAO_Marca();
        }

        private IList<Marca> ObtenerTodos()
        {
            return oMarca.GetAll();
        }
        public static void LlenarGrilla(DataGridView grilla)
        {
            Marca objMarca = new Marca();
            IList<Marca> todasMarcas = objMarca.ObtenerTodos();
            foreach (Marca m in todasMarcas)
            {
                grilla.Rows.Add(m.id, m.nombre);
            }
        }

        public override string ToString()
        {
            return nombre;
        }

    }
}
