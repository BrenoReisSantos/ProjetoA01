namespace Manutemovel.Domain.Models;

public record MarcaId(Guid Value)
{
    public static MarcaId Novo() => new(Guid.NewGuid());
}

public class Marca
{
    public MarcaId Id { get; init; } = new();
    public string Nome { get; init; } = string.Empty;
    public List<ModeloAno> ModelosAnos { get; init; } = new();
}
