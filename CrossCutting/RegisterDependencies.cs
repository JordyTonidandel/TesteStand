using Microsoft.Extensions.DependencyInjection;
using TesteStand.CrossCutting.Repository;
using TesteStand.CrossCutting.Services;

namespace TesteStand.CrossCutting
{
    public static class RegisterDependencies
    {
        public static IServiceCollection GetServices(this IServiceCollection services)
        {
            ConfigureService.Configure(services);
            ConfigureRepository.Configure(services);
            return services;
        }
    }
}
