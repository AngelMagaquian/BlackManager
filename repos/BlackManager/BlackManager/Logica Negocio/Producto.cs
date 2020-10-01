using BlackManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackManager.Logica_Negocio
{
    class Producto
    {
        private long id;
        public int id_marca { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
        public long Id { get => id; set => id = value; }
        DAO_Producto oProducto;
        public Producto()
        {
            oProducto = new DAO_Producto();
        }

        public static void Llenar_grilla(DataGridView grilla)
        {
            Producto objProd = new Producto();
            IList<Producto> todosProductos = objProd.ObtenerTodos();
            foreach (Producto p in todosProductos)
            {
                grilla.Rows.Add(p.id, p.nombre, p.tipo, p.precio, p.cantidad);
            }
        }

        private IList<Producto> ObtenerTodos()
        {
            return oProducto.GetAll();
        }
    }
}
