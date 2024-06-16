using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PeliculaSucursalDatos
    {
        private static PeliculaSucursal[] peliculasSucursales = new PeliculaSucursal[100];

        //Metodo para asociar una pelicula a una sucursal (agregarla en el arreglo establecido)
        public void RegistrarPeliculaSucursal(PeliculaSucursal peliculaSucursal)
        {
            foreach (var ps in peliculasSucursales)
            {
                if (ps.Sucursal == peliculaSucursal.Sucursal || ps.Pelicula == peliculaSucursal.Pelicula) throw new Exception("Ya existe un elemento con este id");
            }
            peliculasSucursales.Append(peliculaSucursal);
        }

        //Metodo que retorna el arreglo(datos) de la relacion entre las peliculas asociadas a las sucursales
        public PeliculaSucursal[] ObtenerPeliculasSucursales()
        {
            return peliculasSucursales;
        }

    }
}
