using StronglyTypedIds;
namespace Manutemovel.Domain.Models.Entidades;

[StronglyTypedId]
public partial struct UsuarioId
{
    public static bool TryParse(string value, out UsuarioId usuarioId)
    {
        var couldConvert = Guid.TryParse(value, out var guid);
        usuarioId = new UsuarioId(guid);
        return couldConvert;
    }
}

public class Usuario
{
    public UsuarioId UsuarioId { get; init; } = UsuarioId.New();
    public string Nome { get; init; } = string.Empty;
    public string Username { get; init; } = string.Empty;
    public string CPFCNPJ { get; init; } = string.Empty;
    public string Telefone { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Senha { get; init; } = string.Empty;
    public IEnumerable<Carro> Carros { get; init; } = Enumerable.Empty<Carro>();
}
