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
            if (clienteDatos.ObtenerClientes().Count == 20)
            {
                throw new Exception("Limite alcanzado, no se pueden agregar mas datos");
            }
            clienteDatos.RegistrarCliente(cliente);
        }

        // Logica de negocio para obtener clientes
        public List<Cliente> ObtenerClientes()
        {
            return clienteDatos.ObtenerClientes();
        }
    }
}
