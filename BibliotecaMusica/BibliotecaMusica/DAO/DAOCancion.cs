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
            String sql = "Select * from cancion where 1=1";
            if (nombre.Trim() != "") sql += String.Format(" and nombre like '%{0}%'", nombre);
            dt = bd.sqlSelect(20, sql);
            return dt;
        }


        public static Cancion sqlLeer(Cancion cancion)
        {
            String sql = "Select * from cancion where id = '" + cancion.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return cancion;
        }

        public static Boolean sqlInsert(Cancion cancion)
        {
            String sql = "Insert into cancion (id, nombre, idDisco) values ('" + cancion.Id + "','" + cancion.Nombre + "', '" + cancion.IdDisco + "')";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }

        public static Boolean sqlDelete(Cancion cancion)
        {
            String sql = "Delete from cancion where id = '" + cancion.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;

        }
        public static Boolean sqlUpdate(Cancion cancion)
        {
            string sql = "Update cancion set nombre '" + cancion.Nombre + "', idDisco = '" + cancion.IdDisco + "' where id = '" + cancion.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;

        }
        

    }

}

