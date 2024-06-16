using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pelicula
    {

        public Pelicula(string titulo, CategoriaPelicula categoriaPelicula, int lanzamiento, string idiomaPrincipal)
        {
            IdPelicula = Utils.generarRandomId();
            Titulo = titulo;
            Categoria = categoriaPelicula;
            Lanzamiento = lanzamiento;
            IdiomaPrincipal = idiomaPrincipal;
        }

        public int IdPelicula { get; private set; }

        private string titulo;
        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("El Titulo no puede estar vacio");
                titulo = value;
            }
        }

        private CategoriaPelicula categoria;
        public CategoriaPelicula Categoria
        {
            get { return categoria; }
            set
            {
                if (value == null) throw new Exception("Debe tener categoria");
                categoria = value;
            }
        }

        private int lanzamiento;
        public int Lanzamiento
        {
            get { return lanzamiento; }
            set
            {
                if (value < 1896) throw new Exception("No existian peliculas para ese año");
                lanzamiento = value;
            }
        }

        private string idiomaPrincipal;
        public string IdiomaPrincipal
        {
            get { return idiomaPrincipal; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Debe tener un idioma valido");
                idiomaPrincipal = value;
            }
        }

    }
}
