using BlackManager.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackManager.DAO
{
    class DAO_Proveedor
    {
        //Creo la funcion que me transforma lo de la BD en un opbjeto
        private Proveedor Mappeo(DataRow filaProveedor)
        {
            Proveedor prov = new Proveedor();
            prov.id = int.Parse(filaProveedor["id_proveedor"].ToString());
            prov.nombre = filaProveedor["nombre"].ToString();

            return prov;
        }
        public IList<Proveedor> GetAll()
        {
            List<Proveedor> listaProveedores = new List<Proveedor>();

            //string consultaSQL = "SELECT nombre FROM Proveedor";
            var tablaProveedores = BDhelper.Instance.ConsultarTabla("Proveedor");
            foreach (DataRow fila in tablaProveedores.Rows)
            {
                listaProveedores.Add(Mappeo(fila));
            }

            return listaProveedores;
        }
    }
}
