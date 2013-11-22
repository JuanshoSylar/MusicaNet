using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BlMusica.Conexion;
using BlMusica.Entity;

namespace BlMusica.DAO
{
    public class DAOGenero
    {
        public static DataTable sqlLeerTodas(int cuantos, String nombre)
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            String sql = "Select * from genero where 1=1";
            if (nombre.Trim() != "") sql += String.Format(" and nombre like '%{0}%'", nombre);
            dt = bd.sqlSelect(cuantos, sql);
            return dt;
        }

        public static DataTable sqlLeerTodas()
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            String sql = @"SELECT g.Id,
                                  g.nombre as nomGenero
		                          FROM genero g
                                  order by id asc";
            dt = bd.sqlSelect(sql);
            return dt;
        }

        public static DataTable sqlComboGenero()
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            String sql = "Select * from genero order by nombre asc";
            dt = bd.sqlSelect(sql);
            return dt;
        }

        public static Genero sqlLeer(Genero genero)
        {
            String sql = "Select * from genero where id = '" + genero.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlSelect(sql);

            DataTable dt = BD.getInstance().sqlSelect(sql);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            genero.Id = int.Parse(dt.Rows[0]["id"].ToString());
            genero.Nombre = dt.Rows[0]["nombre"].ToString();
            return genero;
        }

        public static Boolean sqlInsert(Genero genero)
        {
            String sql = "Insert into genero (id, nombre) values ('" + genero.Id + "','" + genero.Nombre + "')";
            BD bd = Conexion.BD.getInstance();
            return bd.sqlEjecutar(sql);
        }

        public static Boolean sqlDelete(Genero genero)
        {
            String sql = "Delete from genero where id = '" + genero.Id + "'";
            BD bd = Conexion.BD.getInstance();
           return bd.sqlEjecutar(sql);
            
        }

        public static Boolean sqlUpdate(Genero genero)
        {
            string sql = "Update genero set nombre = '" + genero.Nombre + "', where id = '" + genero.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }   
    }
}
