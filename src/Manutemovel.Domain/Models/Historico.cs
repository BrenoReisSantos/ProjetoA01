using System;
namespace Manutemovel.Domain.Models;

public record HistoricoId(Guid Value)
{
    public static HistoricoId Novo() => new(Guid.NewGuid());
}

public class Historico
{
    public HistoricoId Id { get; init; } = new();
    public DateTime Data { get; init; }
    public Carro Carro { get; init; }
    public Usuario Usuario { get; init; }
}
