using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BlMusica.Conexion;
using BlMusica.Entity;

namespace BlMusica.DAO
{
    public class DAOUsuarios
    {
        public static DataTable sqlLeerTodas()
        {
            DataTable dt = new DataTable();
            BD bd = Conexion.BD.getInstance();
            String sql = @"SELECT u.Usuario,
                                  u.Clave,
                                  u.EsAdmin
                                  FROM usuarios u
                                  order by esAdmin desc";
            dt = bd.sqlSelect(sql);
            return dt;
        }

        public static Boolean sqlInsert(Usuarios usuario)
        {
            String sql = "Insert into usuarios (usuario, clave, esAdmin) values ('" + usuario.Usuario + "','" + usuario.Clave + "','" + usuario.EsAdmin + "')";
            BD bd = Conexion.BD.getInstance();
            return bd.sqlEjecutar(sql);
        }

        public static Boolean sqlDelete(Usuarios usuario)
        {
            String sql = "Delete from usuarios where usuario = '" + usuario.Usuario + "'";
            BD bd = Conexion.BD.getInstance();
           return  bd.sqlEjecutar(sql);
           
        }

        public static Boolean sqlUpdate(Usuarios usuario)
        {
            string sql = "Update usuarios set clave = '" + usuario.Clave + "', esAdmin = '" + usuario.EsAdmin + "' where usuario = '" + usuario.Usuario + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }

        public static Usuarios sqlLeer(Usuarios usuario)
        {
            String sql = "Select * from usuarios where usuario = '" + usuario.Usuario + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlSelect(sql);

            DataTable dt = BD.getInstance().sqlSelect(sql);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            usuario.Usuario = dt.Rows[0]["usuario"].ToString();
            usuario.Clave = dt.Rows[0]["clave"].ToString();
            usuario.EsAdmin = int.Parse(dt.Rows[0]["esAdmin"].ToString());
            return usuario;
        }

        public static Boolean esAdmin(Usuarios usuario)
        {
            String sql = "Select esAdmin from usuarios where usuario = '" + usuario.Usuario + "'";
            BD bd = Conexion.BD.getInstance();
            DataTable dt = bd.sqlSelect(sql);
            if (dt.Rows.Count == 0)
            {
                return false;
            }

            int admin = int.Parse(dt.Rows[0]["esAdmin"].ToString());
            if (admin == 0)
            {
                return false;
            }
            return true;
        }

        public static Boolean login(Usuarios usuario)
        {
            String sql = "Select * from usuarios where usuario = '" + usuario.Usuario + "' and clave = '" + usuario.Clave + "'";
            BD bd = Conexion.BD.getInstance();
            DataTable dt = bd.sqlSelect(sql);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

    }
}
