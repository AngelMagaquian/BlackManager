using BlackManager.DAO;
using BlackManager_v2.Logica_Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackManager_v2.DAO
{
    class DAO_Venta
    {
        public void InsertVenta(Venta venta, List<Detalle_Venta> detalles)
        {
            string sql = String.Concat("INSERT INTO [Venta]",
                                        "([metodo_pago],   " +
                                        "[fecha]           ," +
                                        "[monto_final])     " +
                                        "VALUES             " +
                                        "(@metodo_pago      ," +
                                        "@fecha             ," +
                                        "@montoFinal);");
            var parmetros = new Dictionary<string, object>();
            parmetros.Add("metodo_pago", venta.id_metodo_pago);
            parmetros.Add("fecha", venta.fecha);
            parmetros.Add("montoFinal", venta.monto);
            BDHelper.Instance.ConectarTransaccion();
            BDHelper.Instance.EjecutarSQL(sql, parmetros);
            var id_v = BDHelper.Instance.ConsultaSQLScalar("SELECT @@IDENTITY FROM Venta");

            int id_venta = Convert.ToInt32(id_v);
            foreach (Detalle_Venta det in detalles)
            {
                DAO_Detalle_Venta.InsertDetalle(id_venta, det);
            }

            BDHelper.Instance.Desconectar();
        }

        internal DataTable ConsultarVentas(DateTime desde, DateTime hasta)
        {
            string sql = "SELECT v.id_venta AS NumVenta, m.nombre AS MetodoPago, v.fecha, v.monto_final" +
                         "FROM Venta v INNER JOIN Metodo_Pago m ON (v.metodo_pago=m.id_metodo_de_pago) " +
                         "WHERE v.fecha BETWEEN @desde AND @hasta";
            var parametros = new Dictionary<string, object>();
            parametros.Add("desde", desde);
            parametros.Add("hasta", hasta);
            return BDHelper.Instance.ConsultarSQL(sql, parametros);
        }

        public IList<Venta> GetAll()
        {
            List<Venta> listaVentas = new List<Venta>();
            string sql = "SELECT v.id_venta, v.metodo_pago, v.fecha, v.monto_final, m.nombre " +
                         "FROM Venta v INNER JOIN Metodo_Pago m ON (v.metodo_pago=m.id_metodo_de_pago)";
            var tablaVentas = BDHelper.Instance.ConsultarSQL(sql);
            foreach (DataRow vta in tablaVentas.Rows)
            {
                listaVentas.Add(Mappeo(vta));
            }

            return listaVentas;
        }

        private Venta Mappeo(DataRow data)
        {
            Venta nueva = new Venta();
            DAO_Detalle_Venta detalles = new DAO_Detalle_Venta();
            nueva.Id = int.Parse(data["id_venta"].ToString());
            nueva.id_metodo_pago = int.Parse(data["metodo_pago"].ToString());
            nueva.nom_metodo_pago = data["nombre"].ToString();
            nueva.fecha = DateTime.Parse(data["fecha"].ToString());
            nueva.monto = double.Parse(data["monto_final"].ToString());
            nueva.detalle = detalles.GetById(nueva.Id);
            return nueva;
        }
    }
}
