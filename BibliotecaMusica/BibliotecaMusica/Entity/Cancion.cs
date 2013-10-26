using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaMusica.Entity
{
    public class Cancion
    {
        private int id;
        private String nombre;
        private int idDisco;
        
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

        public int IdDisco
        {
            get { return idDisco; }
            set { idDisco = value; }
        }

        public Cancion()
        {
        }

        public Cancion(int id)
        {
            Id = id;
        }

        public Cancion(int id, String nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public Cancion(int id, String nombre, int idDisco)
        {
            Id = id;
            Nombre = nombre;
            IdDisco = idDisco;
        }
    }
}
