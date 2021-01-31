using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteStand.Models;

namespace TesteStand.Context.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<ClienteModel>
    {
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Id).ValueGeneratedOnAdd();
            builder.HasIndex(prop => prop.Razao_social).IsUnique();
            builder.HasIndex(prop => prop.Cnpj).IsUnique();
        }
    }
}
