using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class CategoriaPeliculaNegocios
    {
        private CategoriaPeliculaDatos categoriaPeliculaDatos = new CategoriaPeliculaDatos();

        // Logica de negocio para registrar categoria pelicula
        public void RegistrarCategoriaPelicula(CategoriaPelicula categoriaPelicula)
        {
            if (categoriaPeliculaDatos.ObtenerCategoriaPeliculas().Count == 20)
            {
                throw new Exception("Limite alcanzado, no se pueden agregar mas datos");
            }
            categoriaPeliculaDatos.RegistrarCategoriaPelicula(categoriaPelicula);
        }

        // Logica de negocio para obtener categorias peliculas
        public List<CategoriaPelicula> ObtenerCategoriaPeliculas()
        {
            return categoriaPeliculaDatos.ObtenerCategoriaPeliculas();
        }
    }
}
