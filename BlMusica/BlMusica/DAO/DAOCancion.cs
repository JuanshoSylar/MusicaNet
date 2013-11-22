using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BlMusica.Conexion;
using BlMusica.Entity;

namespace BlMusica.DAO
{
    public class DAOCancion
    {
        public static DataTable sqlLeerTodas(String nombre)
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            String sql = @"SELECT  c.Id,
                                  c.nombre as nomCancion,
                                  d.nombre as nomDisco,
                                  a.nombre as nomArtista,
                                  g.nombre as nomGenero,
                                  c.precio
		                        FROM cancion c, disco d, artista a, genero g
                                where d.Id = c.IdDisco
                                and a.Id = d.IdArtista
                                and g.Id = a.IdGenero";
            if (nombre.Trim() != "") sql += String.Format(" and c.nombre like '%{0}%'", nombre);
            sql += " order by id asc";
            dt = bd.sqlSelect(sql);
            return dt;
        }

        public static DataTable sqlLeerTodas()
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            String sql = @"SELECT  c.Id,
                                  c.nombre as nomCancion,
                                  d.nombre as nomDisco,
                                  c.precio
		                        FROM cancion c, disco d
                                where d.Id = c.IdDisco
                                order by id asc";
            dt = bd.sqlSelect(sql);
            return dt;
        }

        public static Cancion sqlLeer(Cancion cancion)
        {
            String sql = "Select * from cancion where id = '" + cancion.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlSelect(sql);

            DataTable dt = BD.getInstance().sqlSelect(sql);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            cancion.Id = int.Parse(dt.Rows[0]["id"].ToString());
            cancion.Nombre = dt.Rows[0]["nombre"].ToString();
            cancion.IdDisco = int.Parse(dt.Rows[0]["idDisco"].ToString());
            cancion.Precio = int.Parse(dt.Rows[0]["precio"].ToString());
            return cancion;
        }

        public static Boolean sqlInsert(Cancion cancion)
        {
            String sql = "Insert into cancion (id, nombre, idDisco, precio) values ('" + cancion.Id + "','" + cancion.Nombre + "', '" + cancion.IdDisco + "', '" + cancion.Precio + "')";
            BD bd = Conexion.BD.getInstance();
           return  bd.sqlEjecutar(sql);
            
        }

        public static Boolean sqlDelete(Cancion cancion)
        {
            String sql = "Delete from cancion where id = '" + cancion.Id + "'";
            BD bd = Conexion.BD.getInstance();
            return bd.sqlEjecutar(sql);
            
        }

        public static Boolean sqlUpdate(Cancion cancion)
        {
            string sql = "Update cancion set nombre = '" + cancion.Nombre + "', idDisco = '" + cancion.IdDisco + "', precio = '" + cancion.Precio + "' where id = '" + cancion.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }
    }
}
