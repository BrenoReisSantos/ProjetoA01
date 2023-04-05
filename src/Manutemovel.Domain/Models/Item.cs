using System;
namespace Manutemovel.Domain.Models;

public record ItemId(Guid Value)
{
    public static ItemId Novo() => new(Guid.NewGuid());
}

public class Item
{
    public ItemId Id { get; init; } = new();
    public string Nome { get; init; } = string.Empty;
    public List<ModeloItem> ModelosItens { get; init; } = new();
}
