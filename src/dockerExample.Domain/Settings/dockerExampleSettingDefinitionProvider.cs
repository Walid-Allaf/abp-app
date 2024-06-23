using Volo.Abp.Settings;

namespace dockerExample.Settings;

public class dockerExampleSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(dockerExampleSettings.MySetting1));
    }
}
