using BlackManager.Logica_Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackManager_v2.DAO
{
    class DAO_Metodo_Pago
    {
        public List<Metodo_Pago> GetAll()
        {
            List<Metodo_Pago> listaMarcas = new List<Metodo_Pago>();

            //string consultaSQL = "SELECT nombre FROM Proveedor";
            var tablaMP = BDHelper.Instance.ConsultarTabla("Metodo_Pago");
            foreach (DataRow fila in tablaMP.Rows)
            {
                listaMarcas.Add(Mappeo(fila));
            }

            return listaMarcas;
        }

        private Metodo_Pago Mappeo(DataRow metodo_pago)
        {
            Metodo_Pago miMP = new Metodo_Pago();
            miMP.Id = int.Parse(metodo_pago["id_metodo_de_pago"].ToString());
            miMP.nombre = metodo_pago["nombre"].ToString();
            miMP.descripcion = metodo_pago["descripcion"].ToString();
            miMP.recargo = float.Parse(metodo_pago["recargo"].ToString());

            return miMP;
        }
    }
}
