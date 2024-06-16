using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PeliculaSucursal
    {
        public Sucursal Sucursal
        {
            get { return Sucursal; }
            set
            {
                if (value == null) throw new Exception("La Sucursal no puede estar vacia");
                Sucursal = value;
            }
        }

        public Pelicula Pelicula
        {
            get { return Pelicula; }
            set
            {
                if (value == null) throw new Exception("La Pelicula no puede estar vacia");
                Pelicula = value;
            }
        }

        public int Cantidad
        {
            get { return Cantidad; }
            set
            {
                if (value < 0) throw new Exception("Esa cantidad no es valida");
                Cantidad = value;
            }
        }
    }
}
