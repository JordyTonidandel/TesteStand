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

        public async Task<IActionResult> Create()
        {
            return View("CadastraCliente");
        }

        //public async IActionResult Create(Models.ClienteModel clienteModel)
        //{
        //    return View(await _clienteService.CadastraCliente(clienteModel));
        //}
    }
}
