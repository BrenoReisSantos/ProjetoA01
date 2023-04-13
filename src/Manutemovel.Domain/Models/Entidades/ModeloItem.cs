using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

[StronglyTypedId]
public partial struct ModeloItemId
{
    public static bool TryParse(string value, out ModeloItemId modeloItemId)
    {
        var couldConvert = Guid.TryParse(value, out var guid);
        modeloItemId = new ModeloItemId(guid);
        return couldConvert;
    }
}

public class ModeloItem
{
    public ModeloItemId ModeloItemId { get; init; } = ModeloItemId.New();
    public ItemId ItemId { get; init; } = new();
    public ModeloAnoId ModeloAnoId { get; init; } = new();
    public IEnumerable<Modalidade> Modalidades { get; init; } = Enumerable.Empty<Modalidade>();
}
