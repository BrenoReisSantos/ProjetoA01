using Manutemovel.Domain.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manutemovel.Domain.Models.Propriedades;

class HistoricoItemConfig : IEntityTypeConfiguration<HistoricoItem>
{
    public void Configure(EntityTypeBuilder<HistoricoItem> builder)
    {
        builder.HasKey(c => c.HistoricoItemId);

        builder
            .Property(c => c.HistoricoItemId)
            .HasConversion<HistoricoItemId.EfCoreValueConverter>()
            .ValueGeneratedOnAdd();

        builder
            .HasOne<Item>()
            .WithMany()
            .HasForeignKey(hi => hi.ItemId);

        builder
            .Property(hi => hi.ItemId)
            .HasConversion<ItemId.EfCoreValueConverter>();

        builder
            .HasOne<Historico>()
            .WithMany()
            .HasForeignKey(hi => hi.HistoricoId);

        builder
            .Property(hi => hi.HistoricoId)
            .HasConversion<HistoricoId.EfCoreValueConverter>();
    }
}