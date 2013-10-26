using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaMusica.Entity;
using BibliotecaMusica.Conexion;
using System.Data;

namespace BibliotecaMusica.DAO
{
    public class DAOCancion
    {


        public static DataTable sqlLeerTodas(String nombre)
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            // dt= bd.sqlSelect("select * from cancion");
            String sql = "select * from cancion where 1=1 ";
            //if (id.ToString().Trim() != "") sql += String.Format("and id like '%{0}'",id);
            if (nombre.Trim() != "") sql += String.Format(" and nombre like '%{0}'", nombre);

            dt = bd.sqlSelect(20, sql);
            return dt;
        }


        public static Cancion sqlLeer(Cancion cancion)
        {
            String sql = "select * cancion from where id = '" + cancion.Id + "'";
            BD bd = Conexion.BD.getInstance();
            return cancion;
        }

        public static Boolean sqlInsert(Cancion cancion)
        {
            String sql = "insert into cancion (id, nombre) values ('" + cancion.Id + "','" + cancion.Nombre + "')";
            BD bd = Conexion.BD.getInstance();
            return true;
        }

        public static Boolean sqlDelete(Cancion cancion)
        {
            String sql = "Delete from cancion where id = '" + cancion.Id + "'";
            BD bd = Conexion.BD.getInstance();
            return true;

        }
        public static Boolean sqlUpdate(Cancion cancion)
        {
            string sql = "update cancion set nombre '" + cancion.Nombre + "' where id = '" + cancion.Id + "'";
            BD bd = Conexion.BD.getInstance();
            return true;

        }
        

    }

}

