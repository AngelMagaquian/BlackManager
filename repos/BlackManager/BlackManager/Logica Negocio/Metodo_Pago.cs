using BlackManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackManager.Logica_Negocio
{
    class Metodo_Pago
    {
        private int id;
        public string nombre { get ; set; }
        public string descripcion { get ; set; }
        public double recargo { get ; set ; }
        DAO_Metodo_Pago oMetodo_Pago;

        public Metodo_Pago()
        {
          oMetodo_Pago = new DAO_Metodo_Pago();
        }

        public int Id { get => id; set => id = value; }

        public static void LlenarGrilla(DataGridView grilla)
        {
            Metodo_Pago objMP = new Metodo_Pago();
            List<Metodo_Pago> todosMP = objMP.ObtenerTodos();
            foreach (Metodo_Pago mp in todosMP)
            {
                grilla.Rows.Add(mp.id, mp.nombre);
            }
        }

        public List<Metodo_Pago> ObtenerTodos()
        {
            return oMetodo_Pago.GetAll();
        }
    }
}
