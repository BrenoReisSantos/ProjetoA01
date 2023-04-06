using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

[StronglyTypedId]
public partial struct ModeloItemId { }

public class ModeloItem
{
    public ModeloItemId ModeloItemId { get; init; } = ModeloItemId.New();
    public IEnumerable<Modalidade> Modalidades { get; init; } = Enumerable.Empty<Modalidade>();
}
