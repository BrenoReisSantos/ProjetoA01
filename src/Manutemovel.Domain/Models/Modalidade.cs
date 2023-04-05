using StronglyTypedIds;
namespace Manutemovel.Domain.Models;

public enum TipoManutencao : byte
{
    Inspecao = 0,
    Troca = 1
}

[StronglyTypedId(converters: StronglyTypedIdConverter.TypeConverter | StronglyTypedIdConverter.SystemTextJson | StronglyTypedIdConverter.EfCoreValueConverter)]
public partial struct ModalidadeId { }

public class Modalidade
{
    public ModalidadeId ModalidadeId { get; init; } = ModalidadeId.New();
    public TipoManutencao Tipo { get; init; }
    public int ACadaInspecao { get; init; }
    public int VidaUtilDias { get; init; }
    public int VidaUtilKM { get; init; }
}
