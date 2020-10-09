using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackManager_v2.Logica_Negocio
{
    class Venta
    {
        private int id;
        public int id_metodo_pago { get; set; }
        public string nom_metodo_pago { get; set; }
        public DateTime fecha { get; set; }
        public double monto { get; set; }
        public List<Detalle_Venta> detalle { get; set; }
        public int Id { get => id; set => id = value; }


    }
}
