namespace Manutemovel.Domain.Models;

public record ModeloItemId(Guid Value)
{
    public static ModeloItemId Novo() => new(Guid.NewGuid());
}

public class ModeloItem
{
    public ModeloItemId Id { get; init; } = new();
    public List<Modalidade> Modalidades { get; init; } = new();
}
