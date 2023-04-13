using Manutemovel.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Manutemovel.Services;

public static class MigrationRunner
{
    public static async Task Run(IServiceProvider services)
    {
        await using var scope = services.CreateAsyncScope();
        var db = scope.ServiceProvider.GetRequiredService<Context>().Database;
        if (db.IsRelational() && (await db.GetPendingMigrationsAsync()).Any())
            await db.MigrateAsync();
    }
}
