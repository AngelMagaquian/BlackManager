using BlackManager.DAO;
using BlackManager_v2.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackManager_v2.Logica_Negocio
{
    class Producto
    {
        private long id;
        public int id_marca { get; set; }
        public string nom_marca { get; set; } //Asignamos nombre a la marca
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

        private IList<Producto> ObtenerTodos()
        {
            return oProducto.GetAll();
        }

        public static Producto Parse(long nid, int id_marca, string nombre, string tipo, double precio)
        {
            Producto prod = new Producto();
            prod.Id = nid;
            prod.id_marca = id_marca;
            prod.nombre = nombre;
            prod.tipo = tipo;
            prod.precio = precio;
            prod.cantidad = 0;

            return prod;
        }

        public static void Agregar_Producto(Producto prod)
        {
            DAO_Producto oProducto = new DAO_Producto();
            oProducto.InsertarProducto(prod);
        }

        public static Producto ObtenerPorID(long id)
        {
            DAO_Producto oProducto = new DAO_Producto();
            Producto p = oProducto.GetByID(id);
            return p;
        }

        public static void Llenar_grilla(DataGridView grilla)
        {
            Producto objProd = new Producto();
            IList<Producto> todosProductos = objProd.ObtenerTodos();
            foreach (Producto p in todosProductos)
            {
                grilla.Rows.Add(p.id, p.nombre, p.nom_marca, p.cantidad, p.precio);
                //grilla.Rows[0].Cells["subtot"].Value = (double)p.cantidad * p.precio;
            }
        }

        public static void Llenar_Grilla_Marca(DataGridView grilla, int marca)
        {
            Producto objProd = new Producto();
            IList<Producto> todosProductos = objProd.ObtenerXMarca(marca);
            grilla.DataSource = todosProductos;
        }

        private IList<Producto> ObtenerXMarca(int marca)
        {
            return oProducto.GetByMarca(marca);
        }

        public bool ActualizarPrecio(long id_prod, double nuevoPrecio)
        {
            return oProducto.UpdatePrecio(id_prod, nuevoPrecio);
        }
    }
}
