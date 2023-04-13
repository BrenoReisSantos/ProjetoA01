using Manutemovel.Domain.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manutemovel.Domain.Models.Propriedades;

class UsuarioConfig : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.HasKey(c => c.UsuarioId);
        builder.Property(c => c.UsuarioId)
            .HasConversion<UsuarioId.EfCoreValueConverter>();
    }
}