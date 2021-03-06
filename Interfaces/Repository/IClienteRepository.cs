﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TesteStand.Models;

namespace TesteStand.Interfaces.Repository
{
    public interface IClienteRepository
    {
        public Task<List<ClienteModel>> ListaCliente(int pagina, int totalPagina);

        public Task<bool> CadastraCliente(ClienteModel clienteModel);

        public Task<bool> EditaCliente(int Id, ClienteModel clienteModel);

        public Task<bool> ExcluiCliente(int Id);
    }
}
