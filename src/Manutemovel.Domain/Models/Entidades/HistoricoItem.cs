using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

[StronglyTypedId]
public partial struct HistoricoItemId { }

public class HistoricoItem
{
    public HistoricoItemId HistoricoItemId { get; init; } = HistoricoItemId.New();
    public int Instancia { get; init; }
    public Item Item { get; init; } = new();
    public Usuario Usuario { get; init; } = new();
}
