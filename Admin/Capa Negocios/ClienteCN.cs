using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocios
{
    public class ClienteCN
    {
        public List<ClienteCE> ListarClientes()
        {
            ClienteCD clienteCD = new ClienteCD();
            List<ClienteCE> listarCliente = new List<ClienteCE>();
            listarCliente = clienteCD.ListarClientes();
            return listarCliente;
        }
        public void AgregarClientes(ClienteCE clienteCE)
        {
            ClienteCD clienteCD = new ClienteCD();
            clienteCD.AgregarCliente(clienteCE);
        }
        public void ActualizarClientes(ClienteCE clienteCE)
        {
            ClienteCD clienteCD = new ClienteCD();
            clienteCD.ActualizarCliente(clienteCE);
        }
    }
}
