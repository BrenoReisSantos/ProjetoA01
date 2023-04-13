using Manutemovel.Domain.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manutemovel.Domain.Models.Propriedades;

class ItemConfig : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.HasKey(c => c.ItemId);
        builder.Property(c => c.ItemId)
            .HasConversion<ItemId.EfCoreValueConverter>();
    }
}