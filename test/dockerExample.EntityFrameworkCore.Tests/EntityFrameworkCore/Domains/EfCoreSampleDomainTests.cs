using dockerExample.Samples;
using Xunit;

namespace dockerExample.EntityFrameworkCore.Domains;

[Collection(dockerExampleTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<dockerExampleEntityFrameworkCoreTestModule>
{

}
