using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BibliotecaMusica.Conexion;
using BibliotecaMusica.Entity;

namespace BibliotecaMusica.DAO
{
    public class DAODisco
    {
        //public static DataTable sqlLeerTodas(String nombre)
        //{
        //    DataTable dt = new DataTable();
        //    BD bd = Conexion.BD.getInstance();
        //    String sql = "Select * from disco where 1=1";
        //    if (nombre.Trim() != "") sql += String.Format(" and nombre like '%{0}%'", nombre);
        //    dt = bd.sqlSelect(sql);
        //    return dt;
        //}

        public static DataTable sqlLeerTodas(String nombre)
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            String sql = @"SELECT  d.Id,
                                  d.nombre as nomDisco,
                                  a.nombre as nomArtista
		                        FROM disco d, artista a
                                where a.Id = d.IdArtista";
            if (nombre.Trim() != "") sql += String.Format(" and d.nombre like '%{0}%'", nombre);
            dt = bd.sqlSelect(sql);
            return dt;
        }

        public static DataTable sqlLeerTodas( )
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            String sql = "Select * from artista order by nombre asc";
            dt = bd.sqlSelect(sql);
            return dt;
        }

        public static Disco sqlLeer(Disco disco)
        {
            String sql = "Select * from disco where id = '" + disco.Id + "'";
             BD bd = Conexion.BD.getInstance();
             bd.sqlSelect(sql);

            DataTable dt = BD.getInstance().sqlSelect(sql);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            disco.Id = int.Parse(dt.Rows[0]["id"].ToString());
            disco.Nombre = dt.Rows[0]["nombre"].ToString();
            disco.IdArtista = int.Parse(dt.Rows[0]["idArtista"].ToString());

            return disco;
        }

        public static Boolean sqlInsert(Disco disco)
        {
            String sql = "Insert into disco (id, nombre, idArtista) values ('" + disco.Id + "','" + disco.Nombre + "', '" + disco.IdArtista + "')";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }

        public static Boolean sqlDelete(Disco disco)
        {
            String sql = "Delete from disco where id = '" + disco.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }

        public static Boolean sqlUpdate(Disco disco)
        {
            string sql = "Update disco set nombre  = '" + disco.Nombre + "', idArtista = '" + disco.IdArtista + "' where id = '" + disco.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }         
    }
}
