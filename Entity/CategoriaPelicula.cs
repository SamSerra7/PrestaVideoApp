using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CategoriaPelicula
    {
        public CategoriaPelicula(string nombre, string desc)
        {
            IdCategoria = Utils.generarRandomId();
            Nombre = nombre;
            Descripcion = desc;
        }
        public CategoriaPelicula(int id, string nombre, string desc)
        {
            IdCategoria = id;
            Nombre = nombre;
            Descripcion = desc;
        }

        public int IdCategoria { get; private set; }

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

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("La descripcion no puede ser nula");
                descripcion = value;
            }
        }

    }
}
