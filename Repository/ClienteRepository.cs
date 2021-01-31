using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteStand.Context;
using TesteStand.Interfaces.Repository;
using TesteStand.Models;

namespace TesteStand.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        protected readonly EmpresaContext _empresaContext;

        public ClienteRepository(EmpresaContext empresaContext)
        {
            _empresaContext = empresaContext;
        }

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

        public async Task<List<ClienteModel>> ListaCliente(int pagina, int totalPagina)
        {
            return await _empresaContext.Cliente.OrderByDescending(prop => prop.Id)
                                                .Skip(totalPagina * (pagina - 1))
                                                .Take(totalPagina)
                                                .ToListAsync();
        }
    }
}
