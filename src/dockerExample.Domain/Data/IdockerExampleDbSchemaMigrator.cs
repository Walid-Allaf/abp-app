using System.Threading.Tasks;

namespace dockerExample.Data;

public interface IdockerExampleDbSchemaMigrator
{
    Task MigrateAsync();
}
