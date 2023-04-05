using StronglyTypedIds;
namespace Manutemovel.Domain.Models;

[StronglyTypedId(converters: StronglyTypedIdConverter.TypeConverter | StronglyTypedIdConverter.SystemTextJson | StronglyTypedIdConverter.EfCoreValueConverter)]
public partial struct HistoricoItemId { }

public class HistoricoItem
{
    public HistoricoItemId HistoricoItemId { get; init; } = HistoricoItemId.New();
    public int Instancia { get; init; }
    public Item Item { get; init; } = new();
    public Usuario Usuario { get; init; } = new();
}
