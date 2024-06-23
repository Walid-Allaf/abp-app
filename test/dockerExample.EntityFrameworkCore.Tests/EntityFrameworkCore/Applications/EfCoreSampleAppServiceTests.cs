using dockerExample.Samples;
using Xunit;

namespace dockerExample.EntityFrameworkCore.Applications;

[Collection(dockerExampleTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<dockerExampleEntityFrameworkCoreTestModule>
{

}
