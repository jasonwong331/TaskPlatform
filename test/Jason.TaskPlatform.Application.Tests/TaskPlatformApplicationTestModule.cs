using Volo.Abp.Modularity;

namespace Jason.TaskPlatform;

[DependsOn(
    typeof(TaskPlatformApplicationModule),
    typeof(TaskPlatformDomainTestModule)
    )]
public class TaskPlatformApplicationTestModule : AbpModule
{

}
