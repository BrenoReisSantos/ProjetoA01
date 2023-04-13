using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

[StronglyTypedId]
public partial struct HistoricoItemId
{
    public static bool TryParse(string value, out HistoricoItemId historicoItemId)
    {
        var couldConvert = Guid.TryParse(value, out var guid);
        historicoItemId = new HistoricoItemId(guid);
        return couldConvert;
    }
}

public class HistoricoItem
{
    public HistoricoItemId HistoricoItemId { get; init; } = HistoricoItemId.New();
    public int Instancia { get; init; }
    public ItemId ItemId { get; init; } = new();
    public HistoricoId HistoricoId { get; init; } = new();
}
