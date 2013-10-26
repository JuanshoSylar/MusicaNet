﻿using System;
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
        public static DataTable sqlLeerTodas(int cuantos, String nombre)
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            String sql = "Select * from disco where 1=1";
            if (nombre.Trim() != "") sql += String.Format(" and nombre like '%{0}%'", nombre);
            dt = bd.sqlSelect(cuantos, sql);
            return dt;
        }

        public static Disco sqlLeer(Disco disco)
        {
            String sql = "Select * from disco where id = '" + disco.Id + "'";
             BD bd = Conexion.BD.getInstance();
             bd.sqlEjecutar(sql);
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
            string sql = "Update disco set nombre '" + disco.Nombre + "', idArtista = '" + disco.IdArtista + "' where id = '" + disco.Id + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }         
    }
}
