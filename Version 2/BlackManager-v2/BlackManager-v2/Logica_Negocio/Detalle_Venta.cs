using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackManager_v2.Logica_Negocio
{
    class Detalle_Venta
    {
        private int id_venta;

        private long id_producto;
        public string nom_Producto { get; set; }
        public int cantidad { get; set; }
        public double subtotal { get; set; }
        public int Id_venta { get => id_venta; set => id_venta = value; }
        public long Id_producto { get => id_producto; set => id_producto = value; }

        public static Detalle_Venta Parse(DataRow data)
        {
            Detalle_Venta nuevoDetalle = new Detalle_Venta();

            nuevoDetalle.id_producto = long.Parse(data["id_producto"].ToString());
            nuevoDetalle.cantidad = int.Parse(data["stock"].ToString());
            nuevoDetalle.subtotal = double.Parse(data["subtotal"].ToString());
            return nuevoDetalle;
        }

        public static Detalle_Venta Parse(DataGridViewRow data)
        {
            Detalle_Venta nuevoDetalle = new Detalle_Venta();

            nuevoDetalle.id_producto = long.Parse(data.Cells["cod_prod"].ToString());
            nuevoDetalle.cantidad = int.Parse(data.Cells["cantidad"].ToString());
            nuevoDetalle.subtotal = double.Parse(data.Cells["subtot"].ToString());
            return nuevoDetalle;
        }
    }
}
