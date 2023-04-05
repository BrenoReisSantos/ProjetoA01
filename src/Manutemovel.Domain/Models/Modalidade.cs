namespace Manutemovel.Domain.Models;

public record ModalidadeId(Guid Value)
{
    public static ModalidadeId Novo() => new(Guid.NewGuid());
}

public enum TipoManutencao
{
    Inspecao = 0,
    Troca = 1
}

public class Modalidade
{
    public ModalidadeId Id { get; init; } = new();
    public TipoManutencao Tipo { get; init; }
    public int ACadaInspecao { get; init; }
    public int VidaUtilDias { get; init; }
    public int VidaUtilKM { get; init; }
}
