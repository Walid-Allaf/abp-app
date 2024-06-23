using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace dockerExample.Data;

/* This is used if database provider does't define
 * IdockerExampleDbSchemaMigrator implementation.
 */
public class NulldockerExampleDbSchemaMigrator : IdockerExampleDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
