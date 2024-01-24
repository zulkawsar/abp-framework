using Polygon.Ecom.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Polygon.Ecom.Permissions;

public class EcomPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EcomPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EcomPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EcomResource>(name);
    }
}
