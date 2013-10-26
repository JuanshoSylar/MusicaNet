using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace BibliotecaMusica.Conexion
{
    public class BD
    {
        //String stConec="Data Source=10.20.64.5;Initial Catalog=ventaProductos;Port=3307;User ID=LibreriaMusica;Password=-juan20121993";
        String stConec = "DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;Port=3306;DATABASE=libreriaMusica;UID=root;PWD=";
        //String stConec = @"Data Source=localhost\sqlexpress;Initial Catalog=master;Integrated Security=True";

        OdbcConnection cnn;
        private static BD bd = null; //new BD();
        private BD()
        {
            // Log.rutea("Constructor 1");
            cnn = new OdbcConnection(stConec);

            //Log.rutea("new 1 " );
            open();
            //Log.rutea("open 1 ");
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
                    return true;
                }
            }
            catch (Exception)
            {
                //System.Forms.MessageBox.Show("ERROR EN SQLEJECUTAR" + ex.Message);
                return false;
            }
            return false;
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
