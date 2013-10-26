using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaMusica.Conexion;
using BibliotecaMusica.Entity;
using System.Data;

namespace BibliotecaMusica.DAO
{
    public class DAOUsuarios
    {
        public static Boolean sqlInsert(Usuarios usuario)
        {
            String sql = "Insert into usuarios (usuario, clave, esAdmin) values ('" + usuario.Usuario + "','" + usuario.Clave + "','" + usuario.EsAdmin + "')";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }

        public static Boolean sqlDelete(Usuarios usuario)
        {
            String sql = "Delete from usuarios where usuario = '" + usuario.Usuario + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }

        public static Boolean sqlUpdate(Usuarios usuario)
        {
            string sql = "Update usuarios set clave '" + usuario.Clave + "', esAdmin = '" + usuario.EsAdmin + "' where usuario = '" + usuario.Usuario + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
            return true;
        }

        public static Usuarios sqlLeer(Usuarios usuario)
        {
            String sql = "Select * from usuarios where usuario = '" + usuario.Usuario + "'";
            BD bd = Conexion.BD.getInstance();
            bd.sqlEjecutar(sql);
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
