using Microsoft.Extensions.DependencyInjection;
using TesteStand.Models.Interfaces.Services;
using TesteStand.Services;

namespace TesteStand.CrossCutting.Services
{
    public static class ConfigureService
    {
        public static void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IClienteService, ClienteService>();
        }
    }
}
