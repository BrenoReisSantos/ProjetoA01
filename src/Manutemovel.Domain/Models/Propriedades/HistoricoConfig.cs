using Manutemovel.Domain.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manutemovel.Domain.Models.Propriedades;

class HistoricoConfig : IEntityTypeConfiguration<Historico>
{
    public void Configure(EntityTypeBuilder<Historico> builder)
    {
        builder.HasKey(c => c.HistoricoId);
        builder.Property(c => c.HistoricoId)
            .HasConversion<HistoricoId.EfCoreValueConverter>()
            .ValueGeneratedOnAdd();

        builder
            .HasOne<Carro>()
            .WithMany()
            .HasForeignKey(hi => hi.CarroId);

        builder
            .Property(hi => hi.CarroId)
            .HasConversion<CarroId.EfCoreValueConverter>();

        builder
            .HasOne<Usuario>()
            .WithMany()
            .HasForeignKey(hi => hi.UsuarioId);

        builder
            .Property(hi => hi.UsuarioId)
            .HasConversion<UsuarioId.EfCoreValueConverter>();
    }
}