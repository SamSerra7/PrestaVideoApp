using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PeliculaSucursal
    {

        public PeliculaSucursal(Sucursal s,Pelicula p, int cant)
        {
            Sucursal = s;
            Pelicula = p;
            Cantidad = cant;
        }

        private Sucursal sucursal;
        public Sucursal Sucursal
        {
            get { return sucursal; }
            set
            {
                if (value == null) throw new Exception("La Sucursal no puede estar vacia");
                sucursal = value;
            }
        }

        private Pelicula pelicula;
        public Pelicula Pelicula
        {
            get { return pelicula; }
            set
            {
                if (value == null) throw new Exception("La Pelicula no puede estar vacia");
                pelicula = value;
            }
        }

        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 0) throw new Exception("Esa cantidad no es valida");
                cantidad = value;
            }
        }
    }
}
