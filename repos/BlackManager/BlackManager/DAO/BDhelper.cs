﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace BlackManager.DAO
{
    class BDhelper
    {
        enum TipoConexion
        { comun, transaccion }
        enum EstadoTransaccion {exito, fracaso}

        private OleDbCommand dbCommand;
        private OleDbConnection dbConnection;
        private OleDbTransaction dbTransaction;
        private TipoConexion connType = TipoConexion.comun;
        private EstadoTransaccion connEstado = EstadoTransaccion.exito;
        private String cadConexion = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " +
            "C:\\?Users\\ange\\source\\repos\\BlackManager\\BlackManager\\bin\\BDKiosco.accdb";

        private readonly static BDhelper _instance = new BDhelper();

        private BDhelper()
        {
            dbConnection = new OleDbConnection();
            dbConnection.ConnectionString = cadConexion;
            dbCommand = new OleDbCommand();
        }

        public static BDhelper Instance
        {
            get
            {
                return _instance;
            }
        }

        private void Conectar()
        {
            dbConnection.Open();
            dbCommand.Connection = dbConnection;
            dbCommand.CommandType = CommandType.Text;
        }

        //Utilizamos el Conectar transaccion porque se maneja de forma distinto al conectar simple
        public void ConectarTransaccion()
        {
            dbConnection.Open();
            connType = TipoConexion.transaccion;
            dbTransaction = dbConnection.BeginTransaction();
            dbCommand.Transaction = dbTransaction;
            connEstado = EstadoTransaccion.exito;
            dbCommand.Connection = dbConnection;
        }
        internal void Desconectar()
        {
            if (connType == TipoConexion.transaccion)
            {
                if (connEstado == EstadoTransaccion.exito)
                    dbTransaction.Commit();
                else
                    dbTransaction.Rollback();
            }
            dbConnection.Close();
            connType = TipoConexion.comun;
        }


        //Consulta simple que trae todos los elementos de una tabla pasada por parametro
        public DataTable ConsultarTabla(String NombreTabla)
        {
            DataTable miTabla = new DataTable();
            Conectar();
            dbCommand.CommandText = "SELECT * FROM " + NombreTabla;
            miTabla.Load(dbCommand.ExecuteReader());
            Desconectar();
            return miTabla;
        }

        public bool Exist(String tabla, String col, String consulta)
        {
            DataTable tresultado = new DataTable();
            Conectar();

            dbCommand.CommandText = "SELECT " + col +" FROM " + tabla + " WHERE " + col + "='" + consulta + "'";
            tresultado.Load(dbCommand.ExecuteReader());
            if (tresultado.Rows.Count > 0)
                return true;
            else
                return false;
        }

        /* El EJECUTAR SQL lo usamos para operaciones tipo Insert, Updatee y Delete
         * Va a devolver un int que es la cantidad de filas afectadas (creadas o cambiadas) */

        public int EjecutarSQL(String ejecutar, Dictionary<string, object> parametros = null)
        {
            int resultado = 0;

            try
            {
                dbCommand.CommandType = CommandType.Text;
                //Establecemos todo el sql pasado por parametro
                dbCommand.CommandText = ejecutar;

                //Verificamos si hay parametros y los parseamos
                if(parametros != null)
                {
                    foreach(var param in parametros)
                    {
                        dbCommand.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                //Ejecutamos la instruccion y guardamos el numero de filas obtenidos
                resultado = dbCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error en la transaccion " + ex.Message ,"Error de ejecucion" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                connEstado = EstadoTransaccion.fracaso;
            }

            return resultado;

        }

        public DataTable ConsultarSQL(String ejec, Dictionary<string, object> param = null)
        {
            DataTable tabla = new DataTable();
            try
            {
                Conectar();
                dbCommand.CommandText = ejec;
                if (param != null)
                {
                    foreach (var p in param)
                    {
                        dbCommand.Parameters.AddWithValue(p.Key, p.Value);
                    }
                }
                tabla.Load(dbCommand.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la transaccion " + ex.Message, "Error de ejecucion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return tabla;
        }

    }
}
