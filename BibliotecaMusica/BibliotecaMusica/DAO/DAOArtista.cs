using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaMusica.Conexion;
using BibliotecaMusica.Entity;

namespace BibliotecaMusica.DAO
{
    class DAOArtista
    {
        public static DataTable sqlLeerTodas(int cuantos, String nombre)
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            String sql = "Select * from artista where 1=1";
            if (nombre.Trim() != "") sql += String.Format(" and nombre like '%{0}%'", nombre);
            dt = bd.sqlSelect(cuantos, sql);
            return dt;
        }

        public static Genero sqlLeer(Artista artista)
        {
            String sql = "Select * from artista where id = '" + genero.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return disco;
        }

        public static Boolean sqlInsert(Artista artista)
        {
            String sql = "Insert into artista (id, nombre) values ('" + disco.Id + "','" + disco.Nombre + "')";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }

        public static Boolean sqlDelete(Artista artista)
        {
            String sql = "Delete from artista where id = '" + disco.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;

        }

        public static Boolean sqlUpdate(Artista artista)
        {
            string sql = "Update artista set nombre '" + disco.Nombre + "' where id = '" + disco.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }   
    }
}
