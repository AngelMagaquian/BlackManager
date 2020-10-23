using BlackManager_v2.Logica_Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackManager_v2.DAO
{
    class DAO_Compra
    {
        private Compra Mappeo(DataRow fila)
        {
            Compra nueva = new Compra();

            nueva.Id = int.Parse(fila["id_compra"].ToString());
            nueva.id_prod = long.Parse(fila["id_producto"].ToString());
            nueva.nom_prod = fila["NomProd"].ToString();
            nueva.id_prov = int.Parse(fila["id_proveedor"].ToString());
            nueva.nom_prov = fila["NomProv"].ToString();
            nueva.fecha = DateTime.Parse(fila["fecha"].ToString());
            nueva.precioUnitario = float.Parse(fila["precio_unitario"].ToString());
            nueva.cantidad = int.Parse(fila["cantidad"].ToString());

            return nueva;
        }
        public List<Compra> GetAll()
        {
            List<Compra> listaCompras = new List<Compra>();

            string consultaSQL = "SELECT c.id_compra, c.id_producto, p.nombre AS NomProd, c.id_proveedor, pr.nombre AS NomProv, " +
                                "c.fecha, c.precio_unitario, c.cantidad FROM Compra c INNER JOIN Producto p ON (c.id_producto=p.id_producto) " +
                                "INNER JOIN Proveedor pr ON (c.id_proveedor=pr.id_proveedor)";
            var tablaMP = BDHelper.Instance.ConsultarSQL(consultaSQL);
            foreach (DataRow fila in tablaMP.Rows)
            {
                listaCompras.Add(Mappeo(fila));
            }

            return listaCompras;
        }
        internal void InsertCompra(Compra compr)
        {
            string sql = string.Concat("INSERT INTO [Compra] ",
                                        "           ([id_producto]   ",
                                        "           ,[id_proveedor]         ",
                                        "           ,[fecha]       ",
                                        "           ,[precio_unitario]   ",
                                        "           ,[cantidad])    ",
                                        "     VALUES                 ",
                                        "           (@id_producto  ",
                                        "           ,@id_proveedor ",
                                        "           ,@fecha        ",
                                        "           ,@precio       ",
                                        "           ,@cantidad)    ");
            var parametros = new Dictionary<string, object>();
            parametros.Add("id_producto", compr.id_prod);
            parametros.Add("id_proveedor", compr.id_prov);
            parametros.Add("fecha", compr.fecha);
            parametros.Add("precio", compr.precioUnitario);
            parametros.Add("cantidad", compr.cantidad);

            BDHelper.Instance.ConectarTransaccion();
            int rtdo = BDHelper.Instance.EjecutarSQL(sql, parametros);
            int rtdo2 = DAO_Producto.UpdateCantidad(compr.id_prod, compr.cantidad);
            BDHelper.Instance.Desconectar();

            if (rtdo > 0 && rtdo2 > 0)
                MessageBox.Show("Compra registrada con exito", "Insercion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
