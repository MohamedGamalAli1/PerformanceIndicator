using PerformanceIndicator.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PerformanceIndicator.Permissions;

public class PerformanceIndicatorPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PerformanceIndicatorPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PerformanceIndicatorPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PerformanceIndicatorResource>(name);
    }
}
