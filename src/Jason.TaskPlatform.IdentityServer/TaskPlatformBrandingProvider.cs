using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Jason.TaskPlatform;

[Dependency(ReplaceServices = true)]
public class TaskPlatformBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TaskPlatform";
}
