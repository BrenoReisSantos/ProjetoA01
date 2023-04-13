using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

[StronglyTypedId]
public partial struct HistoricoId
{
    public static bool TryParse(string value, out HistoricoId historicoId)
    {
        var couldConvert = Guid.TryParse(value, out var guid);
        historicoId = new HistoricoId(guid);
        return couldConvert;
    }
}

public class Historico
{
    public HistoricoId HistoricoId { get; init; } = HistoricoId.New();
    public DateTime Data { get; init; }
    public CarroId CarroId { get; init; } = new();
    public UsuarioId UsuarioId { get; init; } = new();
}
