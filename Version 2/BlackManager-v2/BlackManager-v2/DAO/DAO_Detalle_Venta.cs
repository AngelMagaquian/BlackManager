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
        public static void InsertarDetalle(int id_venta, Detalle_Venta detalle)
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
    }
}
