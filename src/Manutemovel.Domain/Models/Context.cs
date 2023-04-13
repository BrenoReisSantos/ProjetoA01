using Microsoft.EntityFrameworkCore;
using Manutemovel.Domain.Models.Entidades;

namespace Manutemovel.Domain.Models;

public class Context : DbContext
{
    public DbSet<Carro> Carros => Set<Carro>();
    public DbSet<Historico> Historicos => Set<Historico>();
    public DbSet<HistoricoItem> HistoricoItems => Set<HistoricoItem>();
    public DbSet<Item> Items => Set<Item>();
    public DbSet<Marca> Marcas => Set<Marca>();
    public DbSet<Modalidade> Modalidades => Set<Modalidade>();
    public DbSet<ModeloAno> ModeloAnos => Set<ModeloAno>();
    public DbSet<ModeloItem> ModeloItems => Set<ModeloItem>();
    public DbSet<Usuario> Usuarios => Set<Usuario>();

    public Context(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
}
