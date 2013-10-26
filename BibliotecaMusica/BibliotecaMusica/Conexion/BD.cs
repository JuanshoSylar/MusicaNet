using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaMusica.Conexion
{
    public class BD
    {
        //String stConec="Data Source=10.20.64.5;Initial Catalog=ventaProductos;Port=3307;User ID=LibreriaMusica;Password=-juan20121993";
        //String stConec = "DRIVER={MySQL ODBC 3.51 Driver};SERVER=10.20.64.5;Port=3307;DATABASE=telefonica;UID=telefonica;PWD=macarena";
        String stConec = @"Data Source=localhost\sqlexpress;Initial Catalog=master;Integrated Security=True";

        SqlConnection cnn;
        private static BD bd = null; //new BD();
        private BD()
        {
            // Log.rutea("Constructor 1");
            cnn = new SqlConnection(stConec);

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
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public bool sqlEjecutar(String sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cnn);
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
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, 0, maxreg, "Datos");

            return ds.Tables[0];
        }
    }
}
