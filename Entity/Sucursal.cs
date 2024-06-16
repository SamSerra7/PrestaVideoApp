using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        public int IdSucursal { get; private set; }
        public string Nombre
        {
            get { return Nombre; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("El nombre no puede estar vacio");
                Nombre = value;
            }
        }

        public Encargado Encargado
        {
            get { return Encargado; }
            set
            {
                if (value == null) throw new Exception("El Encargado no puede estar vacio");
                Encargado = value;
            }
        }

        public string Direccion
        {
            get { return Direccion; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("La Direccion no puede estar vacio");
                Direccion = value;
            }
        }

        public string Tel
        {
            get { return Tel; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("El Telefono no puede estar vacio");
                Tel = value;
            }
        }

        public bool Activo { get; private set; }

    }
}
