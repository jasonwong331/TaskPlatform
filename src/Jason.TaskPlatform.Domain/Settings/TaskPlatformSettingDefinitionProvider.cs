using Volo.Abp.Settings;

namespace Jason.TaskPlatform.Settings;

public class TaskPlatformSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TaskPlatformSettings.MySetting1));
    }
}
