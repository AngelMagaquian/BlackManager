using BlackManager.Logica_Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackManager.DAO
{
    class DAO_Producto
    {
        public IList<Producto> GetAll()
        {
            List<Producto> listaProductos = new List<Producto>();
            var tablaProdu = BDhelper.Instance.ConsultarTabla("Producto");
            foreach (DataRow fila in tablaProdu.Rows)
            {
                listaProductos.Add(Mappeo(fila));
            }

            return listaProductos;
        }

        private Producto Mappeo(DataRow produ)
        {
            Producto miProducto = new Producto();
            miProducto.Id = long.Parse(produ["id_producto"].ToString());
            miProducto.id_marca = int.Parse(produ["id_marca"].ToString());
            miProducto.nombre = produ["nombre"].ToString();
            miProducto.precio = double.Parse(produ["predio"].ToString());
            miProducto.cantidad = int.Parse(produ["cantidad"].ToString());
            miProducto.tipo = produ["tipo"].ToString();

            return miProducto;
        }
    }
}
