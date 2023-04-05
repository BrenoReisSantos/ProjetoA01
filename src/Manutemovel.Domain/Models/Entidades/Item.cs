using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

[StronglyTypedId]
public partial struct ItemId { }

public class Item
{
    public ItemId ItemId { get; init; } = ItemId.New();
    public string Nome { get; init; } = string.Empty;
    public List<ModeloItem> ModelosItens { get; init; } = new();
}
