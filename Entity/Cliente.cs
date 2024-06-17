using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {

        public Cliente(string id, string nombre, string primerApellido, string segundoApellido, SqlDateTime fechaNacimiento, bool activo)
        {
            IdCliente = Utils.generarRandomId();
            Identificacion = id;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            FechaNacimiento = fechaNacimiento.Value;
            FechaRegistro = new SqlDateTime(DateTime.Now);
            Activo = activo;
        }

        public int IdCliente { get; private set; }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("El Nombre no puede estar vacio");
                nombre = value;
            }
        }

        private string identificacion;
        public string Identificacion
        {
            get { return identificacion; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("La identificacion no puede estar vacia");
                identificacion = value;
            }
        }

        private string primerApellido;
        public string PrimerApellido
        {
            get { return primerApellido; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("El Primer Apellido no puede estar vacio");
                primerApellido = value;
            }
        }

        private string segundoApellido;
        public string SegundoApellido
        {
            get { return segundoApellido; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("El Segundo Apellido no puede estar vacio");
                segundoApellido = value;
            }
        }

        private SqlDateTime fechaNacimiento;
        public SqlDateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set
            {
                if (value.IsNull) throw new Exception("La fecha de nacimiento no es valida");
                fechaNacimiento = value;
            }
        }

        private SqlDateTime fechaRegistro;
        public SqlDateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set
            {
                if (value.IsNull) throw new Exception("La Fecha de registro no es valida");
                fechaRegistro = value;
            }
        }

        public bool Activo { get; private set; }

    }
}
