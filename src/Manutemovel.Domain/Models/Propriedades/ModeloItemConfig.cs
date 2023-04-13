using Manutemovel.Domain.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manutemovel.Domain.Models.Propriedades;

class ModeloItemConfig : IEntityTypeConfiguration<ModeloItem>
{
    public void Configure(EntityTypeBuilder<ModeloItem> builder)
    {
        builder.HasKey(c => c.ModeloItemId);
        builder
            .Property(c => c.ModeloItemId)
            .HasConversion<ModeloItemId.EfCoreValueConverter>();
        builder
            .HasOne<ModeloAno>()
            .WithMany(ma => ma.ModelosItens)
            .HasForeignKey(mi => mi.ModeloAnoId);

        builder
            .Property(mi => mi.ModeloAnoId)
            .HasConversion<ModeloAnoId.EfCoreValueConverter>();

        builder
            .HasOne<Item>()
            .WithMany(i => i.ModelosItens)
            .HasForeignKey(mi => mi.ItemId);

        builder
            .Property(mi => mi.ItemId)
            .HasConversion<ItemId.EfCoreValueConverter>();
    }
}