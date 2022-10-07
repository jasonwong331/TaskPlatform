using System.Threading.Tasks;

namespace Jason.TaskPlatform.Data;

public interface ITaskPlatformDbSchemaMigrator
{
    Task MigrateAsync();
}
