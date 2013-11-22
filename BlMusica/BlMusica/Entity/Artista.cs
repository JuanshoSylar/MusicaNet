using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlMusica.Entity
{
    public class Artista
    {
        private int id;
        private String nombre;
        private int idGenero;

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

        public int IdGenero
        {
            get { return idGenero; }
            set { idGenero = value; }
        }

        public Artista()
        {
        }

        public Artista(int id)
        {
            Id = id;
        }

        public Artista(int id, String nombre, int idGenero)
        {
            Id = id;
            Nombre = nombre;
            IdGenero = idGenero;
        }
    }
}
