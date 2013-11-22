using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BlMusica.Conexion;
using BlMusica.Entity;

namespace BlMusica.DAO
{
    public class DAOArtista
    {
        public static DataTable sqlLeerTodas(String nombre)
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            String sql = "Select * from artista where 1=1";
            if (nombre.Trim() != "") sql += String.Format(" and nombre like '%{0}%'", nombre);
            dt = bd.sqlSelect(sql);
            return dt;
        }

        public static DataTable sqlLeerTodas()
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            String sql = @"SELECT  a.Id,
                                  a.nombre as nomArtista,
                                  g.nombre as nomGenero
		                        FROM artista a, genero g
                                where g.Id = a.IdGenero
                                order by id asc";
            dt = bd.sqlSelect(sql);
            return dt;
        }

        public static DataTable sqlComboArtista()
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            String sql = "Select * from artista order by nombre asc";
            dt = bd.sqlSelect(sql);
            return dt;
        }

        public static Artista sqlLeer(Artista artista)
        {
            String sql = "Select * from artista where id = '" + artista.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlSelect(sql);

            DataTable dt = BD.getInstance().sqlSelect(sql);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            artista.Id = int.Parse(dt.Rows[0]["id"].ToString());
            artista.Nombre = dt.Rows[0]["nombre"].ToString();
            artista.IdGenero = int.Parse(dt.Rows[0]["idGenero"].ToString());


            return artista;
        }

        public static Boolean sqlInsert(Artista artista)
        {
            String sql = "Insert into artista (id, nombre, idGenero) values ('" + artista.Id + "','" + artista.Nombre + "', '" + artista.IdGenero + "')";
            BD bd = Conexion.BD.getInstance();
            return bd.sqlEjecutar(sql);
        }

        public static Boolean sqlDelete(Artista artista)
        {
            String sql = "Delete from artista where id = '" + artista.Id + "'";
            BD bd = Conexion.BD.getInstance();
           return bd.sqlEjecutar(sql);
             
        }

        public static Boolean sqlUpdate(Artista artista)
        {
            string sql = "Update artista set nombre = '" + artista.Nombre + "', idGenero = '" + artista.IdGenero + "' where id = '" + artista.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }
    }
}
