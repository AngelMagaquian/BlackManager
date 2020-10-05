using BlackManager.Logica_Negocio;
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
    class DAO_Producto
    {
        public IList<Producto> GetAll()
        {
            List<Producto> listaProductos = new List<Producto>();
            var tablaProdu = BDHelper.Instance.ConsultarTabla("Producto");
            foreach (DataRow fila in tablaProdu.Rows)
            {
                listaProductos.Add(Mappeo(fila));
            }

            return listaProductos;
        }

        public IList<Producto> GetByMarca(int marca)
        {
            List<Producto> listaProductos = new List<Producto>();
            string sql = "SELECT * FROM Producto p WHERE p.id_marca = @marca";
            var parametros = new Dictionary<string, object>();
            parametros.Add("marca", marca);
            var tablaProdu = BDHelper.Instance.ConsultarSQL(sql, parametros);

            foreach (DataRow fila in tablaProdu.Rows)
            {
                listaProductos.Add(Mappeo(fila));
            }

            return listaProductos;
        }

        private Producto Mappeo(DataRow produ)
        {
            Producto miProducto = new Producto();
            miProducto.Id = long.Parse(produ["id_producto"].ToString());
            miProducto.id_marca = int.Parse(produ["id_marca"].ToString());
            miProducto.nombre = produ["nombre"].ToString();
            miProducto.precio = double.Parse(produ["precio"].ToString());
            miProducto.cantidad = int.Parse(produ["cantidad"].ToString());
            miProducto.tipo = produ["tipo"].ToString();

            return miProducto;
        }

        internal void InsertarProducto(Producto prod)
        {
            string sql = string.Concat("INSERT INTO [Producto] ",
                                        "           ([id_producto]   ",
                                        "           ,[id_marca]         ",
                                        "           ,[nombre]       ",
                                        "           ,[tipo]   ",
                                        "           ,[precio]    ",
                                        "           ,[cantidad])    ",
                                        "     VALUES                 ",
                                        "           (@id_producto  ",
                                        "           ,@id_marca          ",
                                        "           ,@nombre        ",
                                        "           ,@tipo    ",
                                        "           ,@precio     ",
                                        "           ,@cantidad)     ");
            var parametros = new Dictionary<string, object>();
            parametros.Add("id_producto", prod.Id);
            parametros.Add("id_marca", prod.id_marca);
            parametros.Add("nombre", prod.nombre);
            parametros.Add("tipo", prod.tipo);
            parametros.Add("precio", prod.precio);
            parametros.Add("cantidad", 0);

            BDHelper.Instance.ConectarTransaccion();
            int rtdo = BDHelper.Instance.EjecutarSQL(sql, parametros);
            BDHelper.Instance.Desconectar();

            if (rtdo > 0)
                MessageBox.Show("Producto insertado con exito", "Insercion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        internal Producto GetByID(long id)
        {
            Producto nuevo;
            string sql = "SELECT * FROM PRODUCTO p WHERE p.id_producto = @id";
            var parametros = new Dictionary<string, object>();
            parametros.Add("id_producto", id);

            var tablaProd = BDHelper.Instance.ConsultarSQL(sql, parametros);
            nuevo = Mappeo(tablaProd.Rows[0]);
            return nuevo;
        }

        internal void ActualizarPrecio(long id_producto, double precio)
        {
            string sql = string.Concat("Insert INTO Producto",
                                        "           ([precio])",
                                        "VALUES",
                                        "(@precio)",
                                        "WHERE id_producto = @id_producto");
            var parametros = new Dictionary<string, object>();
            parametros.Add("precio", precio);
            parametros.Add("id_producto", id_producto);

            BDHelper.Instance.ConectarTransaccion();
            int rtdo = BDHelper.Instance.EjecutarSQL(sql, parametros);
            BDHelper.Instance.Desconectar();

            if (rtdo > 0)
                MessageBox.Show("Precio actualizado con exito", "Actualizacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
