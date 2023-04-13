using Manutemovel.Domain.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manutemovel.Domain.Models.Propriedades;

class ModalidadeConfig : IEntityTypeConfiguration<Modalidade>
{
    public void Configure(EntityTypeBuilder<Modalidade> builder)
    {
        builder.HasKey(c => c.ModalidadeId);
        builder.Property(c => c.ModalidadeId)
            .HasConversion<ModalidadeId.EfCoreValueConverter>();
    }
}