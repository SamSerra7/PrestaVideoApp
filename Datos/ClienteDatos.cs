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
        private static Cliente[] clientes = new Cliente[20];

        //Metodo para registrar un nuevo cliente (agregarla en el arreglo establecido)
        public void RegistrarCliente(Cliente cliente)
        {
            foreach (var c in clientes)
            {
                if (c.IdCliente == cliente.IdCliente || c.Identificacion == cliente.Identificacion) throw new Exception("Ya existe un elemento con este id");
            }
            clientes.Append(cliente);
        }

        //Metodo que retorna el arreglo(datos) de Clientes
        public Cliente[] ObtenerClientes()
        {
            return clientes;
        }
    }
}
