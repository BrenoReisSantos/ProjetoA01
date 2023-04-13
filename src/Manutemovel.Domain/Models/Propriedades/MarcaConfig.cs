using Manutemovel.Domain.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manutemovel.Domain.Models.Propriedades;

class MarcaConfig : IEntityTypeConfiguration<Marca>
{
    public void Configure(EntityTypeBuilder<Marca> builder)
    {
        builder.HasKey(c => c.MarcaId);
        builder.Property(c => c.MarcaId)
            .HasConversion<MarcaId.EfCoreValueConverter>();
    }
}