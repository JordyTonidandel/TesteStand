using Microsoft.EntityFrameworkCore;
using TesteStand.Context.Mapping;
using TesteStand.Models;

namespace TesteStand.Context
{
    public class EmpresaContext : DbContext
    {
        public EmpresaContext(DbContextOptions<EmpresaContext> options) : base(options) { }

        public DbSet<ClienteModel> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteModel>(new ClienteMap().Configure);
            base.OnModelCreating(modelBuilder);
        }
    }
}
