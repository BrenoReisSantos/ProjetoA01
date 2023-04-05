using System;
namespace Manutemovel.Domain.Models;

public record HistoricoItemId(Guid Value)
{
    public static HistoricoItemId Novo() => new(Guid.NewGuid());
}

public class HistoricoItem
{
    public HistoricoItemId Id { get; init; } = new();
    public int Instancia { get; init; }
    public Item Item { get; init; }
    public Usuario Usuario { get; init; }
}
