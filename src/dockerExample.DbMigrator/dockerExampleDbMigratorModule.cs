using dockerExample.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace dockerExample.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(dockerExampleEntityFrameworkCoreModule),
    typeof(dockerExampleApplicationContractsModule)
    )]
public class dockerExampleDbMigratorModule : AbpModule
{
}
