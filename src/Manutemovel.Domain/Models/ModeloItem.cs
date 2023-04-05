using StronglyTypedIds;
namespace Manutemovel.Domain.Models;

[StronglyTypedId(converters: StronglyTypedIdConverter.TypeConverter | StronglyTypedIdConverter.SystemTextJson | StronglyTypedIdConverter.EfCoreValueConverter)]
public partial struct ModeloItemId { }

public class ModeloItem
{
    public ModeloItemId ModeloItemId { get; init; } = ModeloItemId.New();
    public List<Modalidade> Modalidades { get; init; } = new();
}
