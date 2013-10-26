using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaMusica.Entity
{
    public class Usuarios
    {
        private String usuario;

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private String clave;

        public String Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        private int esAdmin;

        public int EsAdmin
        {
            get { return esAdmin; }
            set { esAdmin = value; }
        }

        public Usuarios(String usuario, String clave)
        {
            Usuario = usuario;
            Clave = clave;
        }

        public Usuarios(String usuario)
        {
            Usuario = usuario;
        }
    }
}
