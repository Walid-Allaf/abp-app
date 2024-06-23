using Volo.Abp.Modularity;

namespace dockerExample;

[DependsOn(
    typeof(dockerExampleDomainModule),
    typeof(dockerExampleTestBaseModule)
)]
public class dockerExampleDomainTestModule : AbpModule
{

}
