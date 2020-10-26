using BlackManager_v2.Logica_Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackManager_v2.DAO
{
    class DAO_Gasto
    {
        public IList<Gasto> GetAll()
        {
            List<Gasto> listaProveedores = new List<Gasto>();

            //string consultaSQL = "SELECT nombre FROM Proveedor";
            var tablaGasto = BDHelper.Instance.ConsultarTabla("Gasto");
            foreach (DataRow fila in tablaGasto.Rows)
            {
                listaProveedores.Add(Mappeo(fila));
            }

            return listaProveedores;
        }

        private Gasto Mappeo(DataRow fila)
        {
            Gasto gasto = new Gasto();
            gasto.Id_gasto = int.Parse(fila["id_gasto"].ToString());
            gasto.descripcion = fila["descripcion"].ToString();
            gasto.fecha = DateTime.Parse(fila["fecha"].ToString());
            gasto.monto = double.Parse(fila["monto"].ToString());
            gasto.producto = fila["producto"].ToString();

            return gasto;
        }

        public bool InsertGasto(Gasto guardar)
        {
            string sql = "INSERT INTO Gasto ([fecha], [descripcion], [monto], [producto]) " +
                         "VALUES (@fecha, @descr, @monto, @prod)";
            var parametros = new Dictionary<string, object>();
            parametros.Add("fecha", guardar.fecha);
            parametros.Add("descr", guardar.descripcion);
            parametros.Add("monto", guardar.monto);
            parametros.Add("prod", guardar.producto);
            var rtdo = BDHelper.Instance.EjecutarSQL(sql, parametros);
            if (rtdo > 0)
                return true;
            else
                return false;
        }
    }
}
