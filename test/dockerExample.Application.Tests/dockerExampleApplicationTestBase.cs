using Volo.Abp.Modularity;

namespace dockerExample;

public abstract class dockerExampleApplicationTestBase<TStartupModule> : dockerExampleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
