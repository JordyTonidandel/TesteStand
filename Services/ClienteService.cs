using System.Collections.Generic;
using System.Threading.Tasks;
using TesteStand.Interfaces.Repository;
using TesteStand.Interfaces.Services;
using TesteStand.Models;
using TesteStand.Validator;

namespace TesteStand.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<bool> CadastraCliente(ClienteModel clienteModel)
        {
            new ClienteValidator();

            return await _clienteRepository.CadastraCliente(clienteModel);
        }

        public Task<bool> EditaCliente(int Id, ClienteModel clienteModel)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> ExcluiCliente(int Id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<ClienteModel>> ListaCliente(int pagina, int totalPagina)
        {
            return await _clienteRepository.ListaCliente(pagina, totalPagina);
        }
    }
}
