using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Jason.TaskPlatform.Data;

/* This is used if database provider does't define
 * ITaskPlatformDbSchemaMigrator implementation.
 */
public class NullTaskPlatformDbSchemaMigrator : ITaskPlatformDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
