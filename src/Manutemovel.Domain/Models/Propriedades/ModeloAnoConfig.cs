using Manutemovel.Domain.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manutemovel.Domain.Models.Propriedades;

class ModeloAnoConfig : IEntityTypeConfiguration<ModeloAno>
{
    public void Configure(EntityTypeBuilder<ModeloAno> builder)
    {
        builder.HasKey(c => c.ModeloAnoId);
        builder
            .Property(c => c.ModeloAnoId)
            .HasConversion<ModeloAnoId.EfCoreValueConverter>();
    }
}