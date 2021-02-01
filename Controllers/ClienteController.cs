using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TesteStand.Interfaces.Services;

namespace TesteStand.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _clienteService.ListaCliente(1, 10));
        }

        //public async Task<IActionResult> Buscar()
        //{
        //    return View(await _clienteService.ListaCliente(1, 10));
        //}

        public async Task<IActionResult> Create(Models.ClienteModel clienteModel)
        {
            if (clienteModel != null)
            {
                await _clienteService.CadastraCliente(clienteModel);
            }
            return View("CadastraCliente");
        }
    }
}
