﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BlackManager_v2.Logica_Negocio;
namespace BlackManager_v2.DAO
{
    class DAO_Marca
    {
        //Creo la funcion que me transforma lo de la BD en un opbjeto
        private Marca Mappeo(DataRow filaProveedor)
        {
            Marca marca = new Marca();
            marca.id = int.Parse(filaProveedor["id_marca"].ToString());
            marca.nombre = filaProveedor["nombre"].ToString();

            return marca;
        }

        public IList<Marca> GetAll()
        {
            List<Marca> listaMarcas = new List<Marca>();

            //string consultaSQL = "SELECT nombre FROM Proveedor";
            var tablaMarcas = BDHelper.Instance.ConsultarTabla("Marca");
            foreach (DataRow fila in tablaMarcas.Rows)
            {
                listaMarcas.Add(Mappeo(fila));
            }

            return listaMarcas;
        }

        public bool InsertMarca(string nombre)
        {
            string sql = "INSERT INTO Marca ([nombre]) VALUES (@nom)";
            var parametros = new Dictionary<string, object>();
            parametros.Add("nom", nombre);
            BDHelper.Instance.ConectarTransaccion();
            var rtdo = BDHelper.Instance.EjecutarSQL(sql, parametros);
            BDHelper.Instance.Desconectar();
            if (rtdo > 0)
                return true;
            else
                return false;
        }
    
    }
}
