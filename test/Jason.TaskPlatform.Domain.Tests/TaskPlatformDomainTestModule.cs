using Jason.TaskPlatform.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Jason.TaskPlatform;

[DependsOn(
    typeof(TaskPlatformEntityFrameworkCoreTestModule)
    )]
public class TaskPlatformDomainTestModule : AbpModule
{

}
