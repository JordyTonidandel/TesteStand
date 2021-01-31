using System.Collections.Generic;
using System.Threading.Tasks;
using TesteStand.Models;
using TesteStand.Models.Interfaces.Services;

namespace TesteStand.Services
{
    public class ClienteService : IClienteService
    {
        public Task<bool> CadastraCliente(ClienteModel clienteModel)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> EditaCliente(int Id, ClienteModel clienteModel)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> ExcluiCliente(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ClienteModel>> ListaCliente(int pagina, int totalPagina)
        {
            throw new System.NotImplementedException();
        }
    }
}
