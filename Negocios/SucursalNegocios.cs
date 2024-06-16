using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class SucursalNegocios
    {
        private SucursalDatos sucursalDatos = new SucursalDatos();

        // Logica de negocio para registrar  sucursal
        public void RegistrarSucursal(Sucursal sucursal)
        {
            if (sucursalDatos.ObtenerSucursales().Length == 5)
            {
                throw new Exception("Limite alcanzado, no se pueden agregar mas datos");
            }
            sucursalDatos.RegistrarSucursal(sucursal);
        }

        // Logica de negocio para obtener las sucursales
        public Sucursal[] ObtenerSucursales()
        {
            if (sucursalDatos.ObtenerSucursales().Length == 0)
            {
                throw new Exception("No hay datos para mostrar");
            }
            return sucursalDatos.ObtenerSucursales();
        }
    }
}
