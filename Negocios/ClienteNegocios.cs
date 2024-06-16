using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ClienteNegocios
    {
        private ClienteDatos clienteDatos = new ClienteDatos();

        // Logica de negocio para registrar  cliente
        public void RegistrarCliente(Cliente cliente)
        {
            if (clienteDatos.ObtenerClientes().Length == 20)
            {
                throw new Exception("Limite alcanzado, no se pueden agregar mas datos");
            }
            clienteDatos.RegistrarCliente(cliente);
        }

        // Logica de negocio para obtener s clientes
        public Cliente[] ObtenerClientes()
        {
            if (clienteDatos.ObtenerClientes().Length == 0)
            {
                throw new Exception("No hay datos para mostrar");
            }
            return clienteDatos.ObtenerClientes();
        }
    }
}
