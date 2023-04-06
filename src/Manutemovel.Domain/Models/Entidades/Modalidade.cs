using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

public enum TipoManutencao : byte
{
    Inspecao,
    Troca
}

[StronglyTypedId]
public partial struct ModalidadeId { }

public class Modalidade
{
    public ModalidadeId ModalidadeId { get; init; } = ModalidadeId.New();
    public TipoManutencao Tipo { get; init; }
    public int ACadaInspecao { get; init; }
    public int VidaUtilDias { get; init; }
    public int VidaUtilKM { get; init; }
}
