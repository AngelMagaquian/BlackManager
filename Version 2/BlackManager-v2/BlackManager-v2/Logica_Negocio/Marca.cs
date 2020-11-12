using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackManager_v2.DAO;
using BlackManager_v2.Logica_Negocio;

namespace BlackManager_v2.Logica_Negocio

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
        public bool RegistrarNuevaMarca(string marca)
        {
            return oMarca.InsertMarca(marca);
        }

    }
}
