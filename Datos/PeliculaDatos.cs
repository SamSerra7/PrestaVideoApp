using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PeliculaDatos
    {
        private static List<Pelicula> peliculas = new List<Pelicula>();
        CategoriaPeliculaDatos categoriaPeliculaDatos = new CategoriaPeliculaDatos();

        //Metodo para registrar una nueva pelicula (agregarla en el arreglo establecido)
        public void RegistrarPelicula(Pelicula pelicula)
        {
            foreach (var p in peliculas)
            {
                if (p.IdPelicula == pelicula.IdPelicula) throw new Exception("Ya existe un elemento con este id");
            }
            if(categoriaPeliculaDatos.ObtenerCategoriaPeliculas().Count == 0) throw new Exception("No existen categorias en las cuales asociar la pelicula");
            peliculas.Add(pelicula);
        }

        //Metodo que retorna el arreglo(datos) de peliculas
        public List<Pelicula> ObtenerPeliculas()
        {
            return peliculas;
        }

    }
}
