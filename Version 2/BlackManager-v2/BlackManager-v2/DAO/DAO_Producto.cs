
using BlackManager_v2.Logica_Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
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
            string sql = "Select p.id_producto, p.nombre, p.id_marca, m.nombre AS 'NomMarca', p.tipo, p.precio, p.cantidad " +
                        "From Producto p INNER JOIN Marca m ON (p.id_marca=m.id_marca)";
            var tablaProdu = BDHelper.Instance.ConsultarSQL(sql);
            foreach (DataRow fila in tablaProdu.Rows)
            {
                listaProductos.Add(Mappeo(fila));
            }

            return listaProductos;
        }

        public DataTable GetByMarca(int marca)
        {
            //List<Producto> listaProductos = new List<Producto>();
            string sql = "SELECT p.id_producto, p.nombre, m.nombre AS 'NomMarca', p.precio, p.cantidad, p.tipo " +
                        "FROM Producto p INNER JOIN Marca m ON (p.id_marca=m.id_marca) " +
                        "WHERE m.id_marca = @marca " +
                        "ORDER BY m.id_marca";
            var parametros = new Dictionary<string, object>();
            parametros.Add("marca", marca);
            var tablaProdu = BDHelper.Instance.ConsultarSQL(sql, parametros);

            /*foreach (DataRow fila in tablaProdu.Rows)
            {
                listaProductos.Add(Mappeo(fila));
            }*/

            return tablaProdu;
        }

        private Producto Mappeo(DataRow produ)
        {
            Producto miProducto = new Producto();
            miProducto.Id = long.Parse(produ["id_producto"].ToString());
            miProducto.id_marca = int.Parse(produ["id_marca"].ToString());
            miProducto.nom_marca = produ["'NomMarca'"].ToString(); //Marca error de que no se encuentra en la tabla
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

        internal DataTable ConsultarTodos()
        {
            string sql = "SELECT p.id_producto, p.nombre, m.nombre AS 'NomMarca', p.precio, p.cantidad, p.tipo " +
                        "FROM Producto p INNER JOIN Marca m ON (p.id_marca=m.id_marca) " +
                        "ORDER BY m.id_marca";
            var parametros = new Dictionary<string, object>();
            var tablaProdu = BDHelper.Instance.ConsultarSQL(sql);


            return tablaProdu;
        }

        internal Producto GetByID(long id)
        {
            try
            {
                Producto nuevo;
                string sql = "SELECT p.id_producto, p.nombre, p.id_marca, m.nombre AS 'NomMarca', p.precio, p.cantidad, p.tipo " +
                             "FROM Producto p INNER JOIN Marca m ON (p.id_marca=m.id_marca) " +
                             "WHERE p.id_producto = @id"; //creo q aca habia q pegar SELECT p.id_producto, p.nombre, p.id_marca, m.nombre AS 'NomMarca', p.precio, p.cantidad, p.tipo " + "FROM Producto p
                var parametros = new Dictionary<string, object>();
                parametros.Add("id", id);

                var tablaProd = BDHelper.Instance.ConsultarSQL(sql, parametros);
                nuevo = Mappeo(tablaProd.Rows[0]);
                return nuevo;

            }
            catch (Exception ex)
            {
                return null;
            }
            
        }

        internal int GetByIDEscalar(long id)
        {
            try
            {
                string sql = "SELECT p.cantidad " +
                             "FROM Producto p " +
                             "WHERE p.id_producto = " + id.ToString() ; //creo q aca habia q pegar SELECT p.id_producto, p.nombre, p.id_marca, m.nombre AS 'NomMarca', p.precio, p.cantidad, p.tipo " + "FROM Producto p
                var parametros = new Dictionary<string, object>();
                var tablaProd = BDHelper.Instance.ConsultaSQLScalar(sql);
                int nuevo = int.Parse(tablaProd.ToString());
                return nuevo;

            }
            catch
            {
                return 0;
            }

        }

        internal bool UpdatePrecio (long id_producto, double nuevoPrecio)
        {
            string sql = string.Concat("UPDATE Producto p SET p.precio = @precio " +
                                        "WHERE p.id_producto = @id_prodcuto");
            var parametros = new Dictionary<string, object>();
            parametros.Add("precio", nuevoPrecio);
            parametros.Add("id_producto", id_producto);
            BDHelper.Instance.ConectarTransaccion();
            int rto = BDHelper.Instance.EjecutarSQL(sql, parametros);
            BDHelper.Instance.Desconectar();

            if (rto > 0)
                return true;
            else
                return false;
        }

        internal static int UpdateCantidad(long id_producto, int nuevaCantidad)
        {
            string sql = string.Concat("UPDATE Producto p SET p.cantidad = @cantidad " +
                                        "WHERE p.id_producto = @id_prodcuto");

            int cant_Prod = new DAO_Producto().GetByIDEscalar(id_producto);
            int cantidad = cant_Prod + nuevaCantidad;
            var parametros = new Dictionary<string, object>();
            parametros.Add("precio", cantidad);
            parametros.Add("id_producto", id_producto);
            int rto = BDHelper.Instance.EjecutarSQL(sql, parametros);

            return rto;
        }
    }
}
