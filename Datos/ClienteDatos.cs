using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteDatos
    {
        private static List<Cliente> clientes = new List<Cliente>();

        //Metodo para registrar un nuevo cliente (agregarla en el arreglo establecido)
        public void RegistrarCliente(Cliente cliente)
        {
            foreach (var c in clientes)
            {
                if (c.IdCliente == cliente.IdCliente || c.Identificacion == cliente.Identificacion) throw new Exception("Ya existe un elemento con este id");
            }
            clientes.Add(cliente);
        }

        //Metodo que retorna el arreglo(datos) de Clientes
        public List<Cliente> ObtenerClientes()
        {
            return clientes;
        }
    }
}
