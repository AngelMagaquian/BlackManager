using BlackManager_v2.DAO;
using BlackManager_v2.Logica_Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackManager.DAO
{
    class DAO_Detalle_Venta
    {
        public static void InsertDetalle(int id_venta, Detalle_Venta detalle)
        {
            string sql = "INSERT INTO VentaXProducto " +
                         "([id_venta]               ," +
                         "[id_producto]             ," +
                         "[cantidad_producto]       ," +
                         "[subtotal])                " +
                         "VALUES                     " +
                         "(@id_venta                ," +
                         "@id_producto              ," +
                         "@cant                     ," +
                         "@subtotal)                ;";
            var parametros = new Dictionary<string, object>();
            parametros.Add("@id_venta", id_venta);
            parametros.Add("id_producto", detalle.Id_producto);
            parametros.Add("cant", detalle.cantidad);
            parametros.Add("subtotal", detalle.subtotal);

            BDHelper.Instance.EjecutarSQL(sql, parametros);
        }

        public IList<Detalle_Venta> GetAll()
        {
            List<Detalle_Venta> listaDetalles = new List<Detalle_Venta>();
            string sql = "Select d.id_venta, p.nombre,v.id_producto, v.cantidad_producto, v.subtotal " +
                        "From VentaXProducto v INNER JOIN Producto p ON (v.id_producto=p.id_producto)";
            var tablaDetalles = BDHelper.Instance.ConsultarSQL(sql);
            foreach (DataRow fila in tablaDetalles.Rows)
            {
                listaDetalles.Add(Mappeo(fila));
            }

            return listaDetalles;
        }

        public IList<Detalle_Venta> GetById(int id_venta)
        {
            List<Detalle_Venta> listaDetalles = new List<Detalle_Venta>();
            string sql = "Select v.id_venta, p.nombre,v.id_producto, v.cantidad_producto, v.subtotal " +
                        "From VentaXProducto v INNER JOIN Producto p ON (v.id_producto=p.id_producto) " +
                        "WHERE v.id_venta=@id_venta";
            var parametros = new Dictionary<string, object>();
            parametros.Add("id_venta", id_venta);

            var tablaDetalles = BDHelper.Instance.ConsultarSQL(sql, parametros);
            foreach (DataRow fila in tablaDetalles.Rows)
            {
                listaDetalles.Add(Mappeo(fila));
            }

            return listaDetalles;
        }

        private Detalle_Venta Mappeo(DataRow fila)
        {
            Detalle_Venta nuevoDetalle = new Detalle_Venta();
            nuevoDetalle.Id_venta = int.Parse(fila["id_venta"].ToString());
            nuevoDetalle.Id_producto = long.Parse(fila["id_producto"].ToString());
            nuevoDetalle.nom_Producto = fila["nombre"].ToString();
            nuevoDetalle.cantidad = int.Parse(fila["cantidad_producto"].ToString());
            nuevoDetalle.subtotal = double.Parse(fila["subtotal"].ToString());

            return nuevoDetalle;
        }
    }
}
