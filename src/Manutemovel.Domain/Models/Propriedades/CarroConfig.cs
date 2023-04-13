using Manutemovel.Domain.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manutemovel.Domain.Models.Propriedades;

class CarroConfig : IEntityTypeConfiguration<Carro>
{
    public void Configure(EntityTypeBuilder<Carro> builder)
    {
        builder.HasKey(c => c.CarroId);
        builder.Property(c => c.CarroId)
            .HasConversion<CarroId.EfCoreValueConverter>();
    }
}