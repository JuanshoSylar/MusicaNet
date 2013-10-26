using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaMusica.Entity
{
    public class Usuarios
    {
        private String usuario;
        private String clave;
        private int esAdmin;

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }        

        public String Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public int EsAdmin
        {
            get { return esAdmin; }
            set { esAdmin = value; }
        }

        public Usuarios()
        {
        }

        public Usuarios(String usuario)
        {
            Usuario = usuario;
        }

        public Usuarios(String usuario, String clave)
        {
            Usuario = usuario;
            Clave = clave;
        }

        public Usuarios(String usuario, String clave, int esAdmin)
        {
            Usuario = usuario;
            Clave = clave;
            EsAdmin = esAdmin;
        }
    }
}
