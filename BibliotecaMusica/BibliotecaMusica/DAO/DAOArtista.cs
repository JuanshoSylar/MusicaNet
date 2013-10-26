using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BibliotecaMusica.Conexion;
using BibliotecaMusica.Entity;

namespace BibliotecaMusica.DAO
{
    class DAOArtista
    {
        public static DataTable sqlLeerTodas(int cuantos, int id, String nombre)
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
           
            String sql = "select * from artista where 1=1";
           // if (id.Trim() != "") sql += String.Format("and id like '%{0}'", id);
            //if (nombre.Trim != "") sql += String.Format("and nombre like '%{0}'", nombre);
            dt = bd.sqlSelect(20, sql);
            return dt;
        }


        public static Artista sqlLeer(Artista artista)
        {
            String sql = "select * artista from where id = '" + artista.Id + "'";
            BD bd = Conexion.BD.getInstance();
            return artista;
        }

        public static Boolean sqlInsert(Artista artista)
        {
            String sql = "insert into artista (id, nombre) values ('" + artista.Id + "','" + artista.Nombre + "')";
            BD bd = Conexion.BD.getInstance();
            return true;
        }

        public static Boolean sqlDelete(Artista artista)
        {
            String sql = "Delete from artista where id = '" + artista.Id + "'";
            BD bd = Conexion.BD.getInstance();
            return true;

        }
        public static Boolean sqlUpdate(Artista artista)
        {
            string sql = "update artista set nombre '" + artista.Nombre + "' where id = '" + artista.Id + "'";
            BD bd = Conexion.BD.getInstance();
            return true;

        }
        //nacha ql tenias una mezcla de artista disco :s hay esta arreglado ahora :D
    }

}
