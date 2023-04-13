using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

[StronglyTypedId]
public partial struct ItemId
{
    public static bool TryParse(string value, out ItemId itemId)
    {
        var couldConvert = Guid.TryParse(value, out var guid);
        itemId = new ItemId(guid);
        return couldConvert;
    }
}

public class Item
{
    public ItemId ItemId { get; init; } = ItemId.New();
    public string Nome { get; init; } = string.Empty;
    public IEnumerable<ModeloItem> ModelosItens { get; init; } = Enumerable.Empty<ModeloItem>();
}
