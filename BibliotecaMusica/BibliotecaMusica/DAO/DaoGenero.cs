using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BibliotecaMusica.Conexion;
using BibliotecaMusica.Entity;


namespace BibliotecaMusica.DAO
{
    class DaoGenero
    {
        public static DataTable sqlLeerTodas()
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            // dt= bd.sqlSelect("select * from genero");
            String sql = "select * from genero where 1=1";

            dt = bd.sqlSelect(20, sql);
            return dt;
        }


        public static Genero sqlLeer(Genero genero)
        {
            String sql = "select * genero from where id = '" + genero.Id + "'";
            BD bd = Conexion.BD.getInstance();
            return genero;
        }

        public static Boolean sqlInsert(Genero genero)
        {
            String sql = "insert into genero (id, nombre) values ('" + genero.Id + "','" + genero.Nombre + "')";
            BD bd = Conexion.BD.getInstance();
            return true;
        }

        public static Boolean sqlDelete(Genero genero)
        {
            String sql = "Delete from cancion where id = '" + genero.Id + "'";
            BD bd = Conexion.BD.getInstance();
            return true;

        }
        public static Boolean sqlUpdate(Genero genero)
        {
            string sql = "update disco set nombre '" + genero.Nombre + "' where id = '" + genero.Id + "'";
            BD bd = Conexion.BD.getInstance();
            return true;

        }


    }
}

