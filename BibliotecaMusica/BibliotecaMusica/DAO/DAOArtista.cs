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
        public static DataTable sqlLeerTodas(int cuantos, String nombre)
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            String sql = "Select * from artista where 1=1";
            if (nombre.Trim() != "") sql += String.Format(" and nombre like '%{0}%'", nombre);
            dt = bd.sqlSelect(cuantos, sql);
            return dt;
        }

        public static Artista sqlLeer(Artista artista)
        {
            String sql = "Select * from artista where id = '" + artista.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return artista;
        }

        public static Boolean sqlInsert(Artista artista)
        {
            String sql = "Insert into artista (id, nombre) values ('" + artista.Id + "','" + artista.Nombre + "')";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }

        public static Boolean sqlDelete(Artista artista)
        {
            String sql = "Delete from artista where id = '" + artista.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;

        }

        public static Boolean sqlUpdate(Artista artista)
        {
            string sql = "Update artista set nombre '" + artista.Nombre + "' where id = '" + artista.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }   
    }
}
