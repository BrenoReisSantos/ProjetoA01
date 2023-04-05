using StronglyTypedIds;
namespace Manutemovel.Domain.Models;

[StronglyTypedId(converters: StronglyTypedIdConverter.TypeConverter | StronglyTypedIdConverter.SystemTextJson | StronglyTypedIdConverter.EfCoreValueConverter)]
public partial struct MarcaId { }

public class Marca
{
    public MarcaId MarcaId { get; init; } = MarcaId.New();
    public string Nome { get; init; } = string.Empty;
    public List<ModeloAno> ModelosAnos { get; init; } = new();
}
