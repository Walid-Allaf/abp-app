using Xunit;

namespace dockerExample.EntityFrameworkCore;

[CollectionDefinition(dockerExampleTestConsts.CollectionDefinitionName)]
public class dockerExampleEntityFrameworkCoreCollection : ICollectionFixture<dockerExampleEntityFrameworkCoreFixture>
{

}
