using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackManager.DAO;
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

        public IList<Marca> ObtenerTodos()
        {
            return oMarca.GetAll();
        }

        public override string ToString()
        {
            return nombre;
        }

        public void LlenarGrilla(DataGridView grilla)
        {
            IList<Marca> todasMarcas = ObtenerTodos();
            foreach (Marca m in todasMarcas)
            {
                grilla.Rows.Add(m.id, m.nombre);
            }
        }
    }
}
