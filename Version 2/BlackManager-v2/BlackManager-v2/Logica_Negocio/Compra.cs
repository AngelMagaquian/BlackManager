using BlackManager_v2.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackManager_v2.Logica_Negocio
{
    class Compra
    {
        private int id;
        public long id_prod { get; set; }
        public string nom_prod { get; set; }
        public int id_prov { get; set; }
        public string nom_prov { get; set; }
        public DateTime fecha { get; set; }
        public float precioUnitario { get; set; }
        public int cantidad { get; set; }
        public int Id { get => id; set => id = value; }

        private DAO_Compra oCompra;
        public void RegistrarCompra(Compra comp)
        {
            this.oCompra = new DAO_Compra();
            oCompra.InsertCompra(comp);
        }

        public static Compra Parse(long idprod, /*string nomprod,*/ int idprov,/*string nomprov,*/ float precioU, int cant)
        {
            Compra nuevo = new Compra();
            nuevo.id_prod = idprod;
           //nuevo.nom_prod = nomprod;
            nuevo.id_prov = idprov;
           //nuevo.nom_prov = nomprov;
            nuevo.precioUnitario = precioU;
            nuevo.cantidad = cant;
            nuevo.fecha = DateTime.Now;

            return nuevo;
        }
    }
}
