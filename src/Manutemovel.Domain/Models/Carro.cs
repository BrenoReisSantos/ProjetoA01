namespace Manutemovel.Domain.Models;

public record CarroId(Guid Value)
{
    public static CarroId Novo() => new(Guid.NewGuid());
}

public class Carro
{
    public CarroId Id { get; init; } = new();
    public string Nome { get; init; } = string.Empty;
    public string Placa { get; init; } = string.Empty;
    public DateTime AnoFabricacao { get; init; } = string.Empty;
}
