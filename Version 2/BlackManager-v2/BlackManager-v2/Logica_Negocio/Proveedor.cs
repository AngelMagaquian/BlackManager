using BlackManager.DAO;
using BlackManager_v2.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackManager_v2.Logica_Negocio
{
    class Proveedor
    {
        public int id { get; set; }
        public string nombre { get; set; }
        private DAO_Proveedor oProveedor;

        public Proveedor()
        {
            oProveedor = new DAO_Proveedor();
        }

        public static IList<Proveedor> ObtenerTodos()
        {
            DAO_Proveedor objProv = new DAO_Proveedor();
            return objProv.GetAll();
        }

        private IList<Proveedor> GetAll()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return nombre;
        }
        public static void LlenarGrilla(DataGridView grilla)
        {
            DAO_Proveedor objProv = new DAO_Proveedor();
            IList<Proveedor> todosProveedores = objProv.GetAll();
            foreach (Proveedor p in todosProveedores)
            {
                grilla.Rows.Add(p.id, p.nombre);
            }
        }

        public bool NuevoProveedor(string nombre)
        {
            return oProveedor.InsertProv(nombre);
        }
    }
}
