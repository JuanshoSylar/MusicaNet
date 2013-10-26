using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaMusica.Entity
{
    public class Genero
    {
        private int id;
        private String nombre;
        private int idArtista;

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

        public Genero(int id, String nombre, int idArtista)
        {
            Id = id;
            Nombre = nombre;
            IdArtista = idArtista;
        }
    }
}
