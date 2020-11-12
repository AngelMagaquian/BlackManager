using BlackManager_v2.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BlackManager_v2.Logica_Negocio
{
    class Gasto
    {
        private int id_gasto;
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
        public double monto { get; set; }
        public string producto { get; set; }
        public int Id_gasto { get => id_gasto; set => id_gasto = value; }

        DAO_Gasto oGasto;

        public Gasto()
        {
            oGasto = new DAO_Gasto();
        }

        public void AgregarGasto(Gasto guardar)
        {
            oGasto.InsertGasto(guardar);
        }

        public static Gasto Parse(string descrp, double monto, string prod)
        {
            Gasto nuevo = new Gasto();
            nuevo.producto = prod;
            nuevo.descripcion = descrp;
            nuevo.monto = monto;
            nuevo.fecha = DateTime.Today.Date;

            return nuevo;
        }

        public DataTable ConsultarGastos(DateTime desde, DateTime hasta)
        {
            oGasto = new DAO_Gasto();
            return oGasto.ConsultarGastos(desde, hasta);
        }
    }
}
