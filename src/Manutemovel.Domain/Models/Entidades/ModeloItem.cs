using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

[StronglyTypedId]
public partial struct ModeloItemId { }

public class ModeloItem
{
    public ModeloItemId ModeloItemId { get; init; } = ModeloItemId.New();
    public List<Modalidade> Modalidades { get; init; } = new();
}
