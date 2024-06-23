using Volo.Abp.Modularity;

namespace dockerExample;

[DependsOn(
    typeof(dockerExampleApplicationModule),
    typeof(dockerExampleDomainTestModule)
)]
public class dockerExampleApplicationTestModule : AbpModule
{

}
