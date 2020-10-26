using BlackManager_v2.Logica_Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackManager_v2.DAO
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
            var tablaProveedores = BDHelper.Instance.ConsultarTabla("Proveedor");
            foreach (DataRow fila in tablaProveedores.Rows)
            {
                listaProveedores.Add(Mappeo(fila));
            }
            
            return listaProveedores;
        }

        public bool InsertProv(String nombre)
        {
            string sql = "INSERT INTO Proveedor ([nombre]) VALUES (@nom)";
            var parametros = new Dictionary<string, object>();
            parametros.Add("nom", nombre);
            var rtdo = BDHelper.Instance.EjecutarSQL(sql, parametros);
            if (rtdo > 0)
                return true;
            else
                return false;
        }
    }
}
