using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CategoriaPeliculaDatos
    {
        private static List<CategoriaPelicula> arregloCategoriaPelicula = new List<CategoriaPelicula>();

        //Metodo para registrar una nueva categoria de pelicula (agregarla en el arreglo establecido)
        public void RegistrarCategoriaPelicula(CategoriaPelicula categoriaPelicula)
        {
            foreach (var cp in arregloCategoriaPelicula)
            {
                if (cp.IdCategoria == categoriaPelicula.IdCategoria) throw new Exception("Ya existe un elemento con este id");
            }
            arregloCategoriaPelicula.Add(categoriaPelicula);
        }

        //Metodo que retorna el arreglo(datos) de categorias de pelicula 
        public List<CategoriaPelicula> ObtenerCategoriaPeliculas()
        {
            return arregloCategoriaPelicula;
        }

    }
}
