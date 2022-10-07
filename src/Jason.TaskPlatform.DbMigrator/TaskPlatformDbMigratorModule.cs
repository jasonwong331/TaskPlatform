using Jason.TaskPlatform.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Jason.TaskPlatform.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TaskPlatformEntityFrameworkCoreModule),
    typeof(TaskPlatformApplicationContractsModule)
    )]
public class TaskPlatformDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
