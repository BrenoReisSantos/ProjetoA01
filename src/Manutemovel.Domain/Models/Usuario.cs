using StronglyTypedIds;
namespace Manutemovel.Domain.Models;

[StronglyTypedId(converters: StronglyTypedIdConverter.TypeConverter | StronglyTypedIdConverter.SystemTextJson | StronglyTypedIdConverter.EfCoreValueConverter)]
public partial struct UsuarioId { }

public class Usuario
{
    public UsuarioId UsuarioId { get; init; } = UsuarioId.New();
    public string Nome { get; init; } = string.Empty;
    public string Username { get; init; } = string.Empty;
    public string CPFCNPJ { get; init; } = string.Empty;
    public string Telefone { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Senha { get; init; } = string.Empty;
    public List<Carro> Carros { get; init; } = new();
}
