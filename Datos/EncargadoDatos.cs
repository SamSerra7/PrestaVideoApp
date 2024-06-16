using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class EncargadoDatos
    {
        private static Encargado[] encargados = new Encargado[20];

        //Metodo para registrar un nuevo encargado (agregarla en el arreglo establecido)
        public void RegistrarEncargado(Encargado encargado)
        {
            foreach (var cp in encargados)
            {
                if (cp.IdEncargado == encargado.IdEncargado || cp.Identificacion == encargado.Identificacion) throw new Exception("Ya existe un elemento con este id");
            }
            encargados.Append(encargado);
        }

        //Metodo que retorna el arreglo(datos) de encargados de administrar una sucursal 
        public Encargado[] ObtenerEncargados()
        {
            return encargados;
        }
    }
}
