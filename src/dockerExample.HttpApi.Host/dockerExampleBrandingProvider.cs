using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace dockerExample;

[Dependency(ReplaceServices = true)]
public class dockerExampleBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "dockerExample";
}
