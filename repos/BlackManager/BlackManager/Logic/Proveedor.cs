﻿using BlackManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackManager.Logic
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
        public IList<Proveedor> ObtenerTodos()
        {
           return oProveedor.GetAll();
        }
        public override string ToString()
        {
            return nombre;
        }
    }
}
