using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlMusica.Entity
{
    public class Genero
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

        public Genero()
        {
        }

        public Genero(int id)
        {
            Id = id;
        }

        public Genero(int id, String nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
