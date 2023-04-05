namespace Manutemovel.Domain.Models;

public record ModeloAnoId(Guid Value)
{
    public static ModeloAnoId Novo() => new(Guid.NewGuid());
}

public class ModeloAno
{
    public ModeloAnoId Id { get; init; } = new();
    public string Nome { get; init; } = string.Empty;
    public DateTime Ano { get; init; } = string.Empty;
    public List<Carro> Carros { get; init; } = new();
    public List<ModeloItem> ModelosItens { get; init; } = new();

}
