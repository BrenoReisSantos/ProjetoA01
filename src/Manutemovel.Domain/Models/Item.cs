using StronglyTypedIds;
namespace Manutemovel.Domain.Models;

[StronglyTypedId(converters: StronglyTypedIdConverter.TypeConverter | StronglyTypedIdConverter.SystemTextJson | StronglyTypedIdConverter.EfCoreValueConverter)]
public partial struct ItemId { }

public class Item
{
    public ItemId ItemId { get; init; } = ItemId.New();
    public string Nome { get; init; } = string.Empty;
    public List<ModeloItem> ModelosItens { get; init; } = new();
}
