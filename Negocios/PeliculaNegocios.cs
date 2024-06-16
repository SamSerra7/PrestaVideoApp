using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class PeliculaNegocios
    {
        private PeliculaDatos peliculaDatos = new PeliculaDatos();

        // Logica de negocio para registrar  pelicula
        public void RegistrarPelicula(Pelicula pelicula)
        {
            if (peliculaDatos.ObtenerPeliculas().Count == 20)
            {
                throw new Exception("Limite alcanzado, no se pueden agregar mas datos");
            }
            peliculaDatos.RegistrarPelicula(pelicula);
        }

        // Logica de negocio para obtener s peliculas
        public List<Pelicula> ObtenerPeliculas()
        {
            return peliculaDatos.ObtenerPeliculas();
        }
    }
}
