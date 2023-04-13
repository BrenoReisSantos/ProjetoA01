using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

[StronglyTypedId]
public partial struct CarroId
{
    public static bool TryParse(string value, out CarroId carroId)
    {
        var couldConvert = Guid.TryParse(value, out var guid);
        carroId = new CarroId(guid);
        return couldConvert;
    }
}

public class Carro
{
    public CarroId CarroId { get; init; } = CarroId.New();
    public string Nome { get; init; } = string.Empty;
    public string Placa { get; init; } = string.Empty;
    public DateTime AnoFabricacao { get; init; }
}
