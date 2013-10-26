using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaMusica.Entity;
using BibliotecaMusica.Conexion;
using System.Data;

namespace BibliotecaMusica.DAO
{
    class DAOCancion
    {
   //lo que hicimos hoy     
        
            public static DataTable sqlLeerTodas()
            {
                DataTable dt = new DataTable();
                BD bd = Conexion.BD.getInstance();
                // dt= bd.sqlSelect("select * from cancion");
                String sql = "select * from disco where 1=1";
                
                dt = bd.sqlSelect(20, sql);
                return dt;
            }


            public static Cancion sqlLeer(Cancion cancion)
            {
                String sql = "select * cancion from where id = '" + cancion.Id + "'";
                BD bd = Conexion.BD.getInstance();
                return cancion;
            }

            public static Boolean sqlInsert(Cancion cancion)
            {
                String sql = "insert into cancion (id, nombre) values ('" + cancion.Id + "','" + cancion.Nombre + "')";
                BD bd = Conexion.BD.getInstance();
                return true;
            }

            public static Boolean sqlDelete(Cancion cancion)
            {
                String sql = "Delete from cancion where id = '" + cancion.Id + "'";
                BD bd = Conexion.BD.getInstance();
                return true;

            }
            public static Boolean sqlUpdate(Cancion cancion)
            {
                string sql = "update disco set nombre '" + cancion.Nombre + "' where id = '" + cancion.Id + "'";
                BD bd = Conexion.BD.getInstance();
                return true;

            }
            //jalksjdlakjsdlkajsd por la mierda :c

        }

    }

