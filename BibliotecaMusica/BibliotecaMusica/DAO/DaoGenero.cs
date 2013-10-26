using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BibliotecaMusica.Conexion;
using BibliotecaMusica.Entity;

namespace BibliotecaMusica.DAO
{
    class DAOGenero
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

        public static Genero sqlLeer(Genero genero)
        {
            String sql = "Select * from genero where id = '" + genero.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return genero;
        }

        public static Boolean sqlInsert(Genero genero)
        {
            String sql = "Insert into genero (id, nombre, idArtista) values ('" + genero.Id + "','" + genero.Nombre + "', '" + genero.IdArtista + "')";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }

        public static Boolean sqlDelete(Genero genero)
        {
            String sql = "Delete from genero where id = '" + genero.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }

        public static Boolean sqlUpdate(Genero genero)
        {
            string sql = "Update genero set nombre '" + genero.Nombre + "', idArtista = '" + genero.IdArtista + "' where id = '" + genero.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }   
    }
}
