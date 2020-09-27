using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

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
            ".\\..\\BDKiosco.accdb";

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

        private void Desconectar()
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

    }
}
