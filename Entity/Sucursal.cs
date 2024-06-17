using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {

        public Sucursal(string nombre, Encargado encargado, string dir, string tel, bool activo)
        {
            IdSucursal = Utils.generarRandomId();
            Nombre = nombre;
            Encargado = encargado;
            Direccion = dir;
            Tel = tel;
            Activo = activo;
        }

        public int IdSucursal { get; private set; }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("El nombre no puede estar vacio");
                nombre = value;
            }
        }

        private Encargado encargado;
        public Encargado Encargado
        {
            get { return encargado; }
            set
            {
                if (value == null) throw new Exception("El Encargado no puede estar vacio");
                encargado = value;
            }
        }

        private string direccion;
        public string Direccion
        {
            get { return direccion; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("La Direccion no puede estar vacio");
                direccion = value;
            }
        }

        private string tel;
        public string Tel
        {
            get { return tel; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("El Telefono no puede estar vacio");
                tel = value;
            }
        }

        public bool Activo { get; private set; }

    }
}
