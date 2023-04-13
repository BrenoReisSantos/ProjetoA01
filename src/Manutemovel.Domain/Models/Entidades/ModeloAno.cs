using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

[StronglyTypedId]
public partial struct ModeloAnoId
{
    public static bool TryParse(string value, out ModeloAnoId modeloAnoId)
    {
        var couldConvert = Guid.TryParse(value, out var guid);
        modeloAnoId = new ModeloAnoId(guid);
        return couldConvert;
    }
}

public class ModeloAno
{
    public ModeloAnoId ModeloAnoId { get; init; } = ModeloAnoId.New();
    public string Nome { get; init; } = string.Empty;
    public DateTime Ano { get; init; }
    public IEnumerable<Carro> Carros { get; init; } = Enumerable.Empty<Carro>();
    public IEnumerable<ModeloItem> ModelosItens { get; init; } = Enumerable.Empty<ModeloItem>();

}
