using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

[StronglyTypedId]
public partial struct MarcaId { }

public class Marca
{
    public MarcaId MarcaId { get; init; } = MarcaId.New();
    public string Nome { get; init; } = string.Empty;
    public IEnumerable<ModeloAno> ModelosAnos { get; init; } = Enumerable.Empty<ModeloAno>();
}
