using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class SucursalDatos
    {
        private static Sucursal[] sucursales = new Sucursal[5];

        //Metodo para registrar una nueva sucursal (agregarla en el arreglo establecido)
        public void RegistrarSucursal(Sucursal sucursal)
        {
            foreach (var cp in sucursales)
            {
                if (cp.IdSucursal == sucursal.IdSucursal) throw new Exception("Ya existe un elemento con este id");
            }
            sucursales.Append(sucursal);
        }

        //Metodo que retorna el arreglo(datos) de las sucursales
        public Sucursal[] ObtenerSucursales()
        {
            return sucursales;
        }
    }
}
