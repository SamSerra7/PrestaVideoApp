using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class PeliculaSucursalNegocios
    {
        private PeliculaSucursalDatos peliculaSucursalDatos = new PeliculaSucursalDatos();

        // Logica de negocio para registrar  peliculaSucursal
        public void RegistrarPeliculaSucursal(PeliculaSucursal peliculaSucursal)
        {
            if (peliculaSucursalDatos.ObtenerPeliculasSucursales().Count == 100)
            {
                throw new Exception("Limite alcanzado, no se pueden agregar mas datos");
            }
            peliculaSucursalDatos.RegistrarPeliculaSucursal(peliculaSucursal);
        }

        // Logica de negocio para obtener la asociacion entre peliculas y sucursales
        public List<PeliculaSucursal> ObtenerPeliculaSucursales()
        {
            return peliculaSucursalDatos.ObtenerPeliculasSucursales();
        }
    }
}
