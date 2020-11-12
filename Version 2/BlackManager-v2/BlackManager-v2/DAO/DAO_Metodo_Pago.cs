using BlackManager_v2.Logica_Negocio;
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

        public Metodo_Pago GetByID(int id)
        {
            Metodo_Pago nuevo;
            string sql = "SELECT * FROM Metodo_Pago m WHERE m.id_metodo_de_pago = @id";
            var parametros = new Dictionary<string, object>();
            parametros.Add("id_producto", id);

            var tablaMP = BDHelper.Instance.ConsultarSQL(sql, parametros);
            nuevo = Mappeo(tablaMP.Rows[0]);
            return nuevo;
        }

        internal bool NewMetodoPago(Metodo_Pago nuevo)
        {
            string sql = "INSERT INTO Metodo_Pago (nombre, descripcion, recargo) VALUES " +
                         " (@nombre, @descripcion, @recargo)";
            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", nuevo.nombre);
            parametros.Add("descripcion", nuevo.descripcion);
            parametros.Add("recargo", nuevo.recargo);
            BDHelper.Instance.ConectarTransaccion();
            int rto = BDHelper.Instance.EjecutarSQL(sql, parametros);
            BDHelper.Instance.Desconectar();
            if (rto > 0)
                return true;
            else
                return false;
        }
    }
}
