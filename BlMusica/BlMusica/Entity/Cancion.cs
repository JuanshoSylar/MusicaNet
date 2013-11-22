using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlMusica.Entity
{
    public class Cancion
    {
        private int id;
        private String nombre;
        private int idDisco;
        private int precio;

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

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Cancion()
        {
        }

        public Cancion(int id)
        {
            Id = id;
        }

        public Cancion(int id, String nombre, int idDisco, int precio)
        {
            Id = id;
            Nombre = nombre;
            IdDisco = idDisco;
            Precio = precio;
        }
    }
}
