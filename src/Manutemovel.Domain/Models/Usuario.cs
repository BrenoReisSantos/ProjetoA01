namespace Manutemovel.Domain.Models;

public record UsuarioId(Guid Value)
{
    public static UsuarioId Novo() => new(Guid.NewGuid());
}

public class Usuario
{
    public UsuarioId Id { get; init; } = new();
    public string Nome { get; init; } = string.Empty;
    public string Username { get; init; } = string.Empty;
    public string CPFCNPJ { get; init; } = string.Empty;
    public string Telefone { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Senha { get; init; } = string.Empty;
    public List<Carro> Carros { get; init; } = new();
}
