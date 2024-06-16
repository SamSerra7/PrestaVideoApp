using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Encargado
    {
        public int IdEncargado { get; private set; }

        public string Identificacion
        {
            get { return Identificacion; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("La identificacion no puede estar vacia");
                Identificacion = value;
            }
        }

        public string Nombre
        {
            get { return Nombre; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("El Nombre no puede estar vacio");
                Nombre = value;
            }
        }

        public string PrimerApellido
        {
            get { return PrimerApellido; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("El Primer Apellido no puede estar vacio");
                PrimerApellido = value;
            }
        }

        public string SegundoApellido
        {
            get { return SegundoApellido; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("El Segundo Apellido no puede estar vacio");
                SegundoApellido = value;
            }
        }

        public SqlDateTime FechaNacimiento
        {
            get { return FechaNacimiento; }
            set
            {
                if (value.IsNull) throw new Exception("La fecha de nacimiento no es valida");
                FechaNacimiento = value;
            }
        }

        public SqlDateTime FechaIngreso
        {
            get { return FechaIngreso; }
            set
            {
                if (value.IsNull) throw new Exception("La Fecha de ingreso no es valida");
                FechaIngreso = value;
            }
        }
    }
}
