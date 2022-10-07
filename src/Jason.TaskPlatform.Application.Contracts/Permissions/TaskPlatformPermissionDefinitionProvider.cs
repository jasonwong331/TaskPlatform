using Jason.TaskPlatform.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Jason.TaskPlatform.Permissions;

public class TaskPlatformPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TaskPlatformPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TaskPlatformPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TaskPlatformResource>(name);
    }
}
