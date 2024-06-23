using dockerExample.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace dockerExample.Permissions;

public class dockerExamplePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(dockerExamplePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(dockerExamplePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<dockerExampleResource>(name);
    }
}
