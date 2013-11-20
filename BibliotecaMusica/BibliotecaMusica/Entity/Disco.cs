using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaMusica.Entity
{
    public class Disco
    {
        private int id;
        private String nombre;
        private int idArtista;
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

        public int IdArtista
        {
            get { return idArtista; }
            set { idArtista = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Disco()
        {
        }

        public Disco(int id)
        {
            Id = id;
        }

        public Disco(int id, String nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public Disco(int id, String nombre, int idArtista, int precio)
        {
            Id = id;
            Nombre = nombre;
            IdArtista = idArtista;
            Precio = precio;
        }
    }
}
