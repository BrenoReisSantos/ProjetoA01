using StronglyTypedIds;
namespace Manutemovel.Domain.Models;

[StronglyTypedId(converters: StronglyTypedIdConverter.TypeConverter | StronglyTypedIdConverter.SystemTextJson | StronglyTypedIdConverter.EfCoreValueConverter)]
public partial struct CarroId { }

public class Carro
{
    public CarroId CarroId { get; init; } = CarroId.New();
    public string Nome { get; init; } = string.Empty;
    public string Placa { get; init; } = string.Empty;
    public DateTime AnoFabricacao { get; init; }
}
