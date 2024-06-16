using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class EncargadoNegocios
    {
        private EncargadoDatos encargadoDatos = new EncargadoDatos();

        // Logica de negocio para registrar  encargado
        public void RegistrarEncargado(Encargado encargado)
        {
            if (encargadoDatos.ObtenerEncargados().Length == 20)
            {
                throw new Exception("Limite alcanzado, no se pueden agregar mas datos");
            }
            encargadoDatos.RegistrarEncargado(encargado);
        }

        // Logica de negocio para obtener los encargados
        public Encargado[] ObtenerEncargados()
        {
            if (encargadoDatos.ObtenerEncargados().Length == 0)
            {
                throw new Exception("No hay datos para mostrar");
            }
            return encargadoDatos.ObtenerEncargados();
        }
    }
}
