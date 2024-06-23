using Volo.Abp.Modularity;

namespace dockerExample;

/* Inherit from this class for your domain layer tests. */
public abstract class dockerExampleDomainTestBase<TStartupModule> : dockerExampleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
