using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

[StronglyTypedId]
public partial struct ModeloAnoId { }

public class ModeloAno
{
    public ModeloAnoId ModeloAnoId { get; init; } = ModeloAnoId.New();
    public string Nome { get; init; } = string.Empty;
    public DateTime Ano { get; init; }
    public List<Carro> Carros { get; init; } = new();
    public List<ModeloItem> ModelosItens { get; init; } = new();

}
