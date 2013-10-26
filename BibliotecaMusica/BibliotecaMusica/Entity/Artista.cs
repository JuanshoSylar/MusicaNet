using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaMusica.Entity
{
    public class Artista
    {
        private int id;
        private String nombre;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Artista()
        {
        }

        public Artista(int id)
        {
            Id = id;
        }

        public Artista(int id, String nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
