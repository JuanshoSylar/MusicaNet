using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaMusica.Entity
{
    public class Genero
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Genero()
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
