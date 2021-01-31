using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TesteStand.Context;
using TesteStand.Interfaces.Repository;
using TesteStand.Repository;

namespace TesteStand.CrossCutting.Repository
{
    public static class ConfigureRepository
    {
        public static void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IClienteRepository, ClienteRepository>();
            serviceCollection.AddDbContext<EmpresaContext>(prop => 
                prop.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_standBy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
        }
    }
}
