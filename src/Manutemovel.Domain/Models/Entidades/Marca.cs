using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

[StronglyTypedId]
public partial struct MarcaId
{
    public static bool TryParse(string value, out MarcaId marcaId)
    {
        var couldConvert = Guid.TryParse(value, out var guid);
        marcaId = new MarcaId(guid);
        return couldConvert;
    }
}

public class Marca
{
    public MarcaId MarcaId { get; init; } = MarcaId.New();
    public string Nome { get; init; } = string.Empty;
    public IEnumerable<ModeloAno> ModelosAnos { get; init; } = Enumerable.Empty<ModeloAno>();
}
