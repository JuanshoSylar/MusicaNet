using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data;

namespace BlMusica.Conexion
{
    public class BD
    {
        //String stConec = "DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;Port=3306;DATABASE=Musica;UID=root;PWD=";
        String stConec = "DRIVER={MySQL ODBC 3.51 Driver};SERVER=10.20.64.5;Port=3307;DATABASE=LibreriaMusica;UID=LibreriaMusica;PWD=-juan20121993";

        OdbcConnection cnn;
        private static BD bd = null;
        private BD()
        {
            cnn = new OdbcConnection(stConec);
            open();
        }

        private void open()
        {
            cnn.Open();
        }

        private static void createInstance()
        {
            if (bd == null) bd = new BD();
        }

        public static BD getInstance()
        {
            createInstance();
            return bd;
        }

        public DataTable sqlSelect(String sql)
        {
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(sql, cnn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public bool sqlEjecutar(String sql)
        {
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, cnn);
                int reg = cmd.ExecuteNonQuery();
                if (reg == 0)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable sqlSelect(int maxreg, String sql)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            OdbcCommand cmd = new OdbcCommand(sql, cnn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(ds, 0, maxreg, "Datos");

            return ds.Tables[0];
        }
    }
}
