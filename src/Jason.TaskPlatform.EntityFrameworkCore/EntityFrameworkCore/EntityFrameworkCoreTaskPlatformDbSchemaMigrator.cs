using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Jason.TaskPlatform.Data;
using Volo.Abp.DependencyInjection;

namespace Jason.TaskPlatform.EntityFrameworkCore;

public class EntityFrameworkCoreTaskPlatformDbSchemaMigrator
    : ITaskPlatformDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTaskPlatformDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TaskPlatformDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TaskPlatformDbContext>()
            .Database
            .MigrateAsync();
    }
}
