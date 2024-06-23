using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using dockerExample.Data;
using Volo.Abp.DependencyInjection;

namespace dockerExample.EntityFrameworkCore;

public class EntityFrameworkCoredockerExampleDbSchemaMigrator
    : IdockerExampleDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoredockerExampleDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the dockerExampleDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<dockerExampleDbContext>()
            .Database
            .MigrateAsync();
    }
}
