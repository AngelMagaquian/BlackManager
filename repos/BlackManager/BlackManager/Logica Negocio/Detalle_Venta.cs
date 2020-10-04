using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackManager.Logica_Negocio
{
    class Detalle_Venta
    {
        private int id_venta;
        private long id_producto;
        public int metodo_pago { get; set; }
        public int cantidad { get; set; }
        public int Id_venta { get => id_venta; set => id_venta = value; }
        public long Id_producto { get => id_producto; set => id_producto = value; }
    }
}
