using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

[StronglyTypedId]
public partial struct HistoricoId { }

public class Historico
{
    public HistoricoId HistoricoId { get; init; } = HistoricoId.New();
    public DateTime Data { get; init; }
    public Carro Carro { get; init; } = new();
    public Usuario Usuario { get; init; } = new();
}
