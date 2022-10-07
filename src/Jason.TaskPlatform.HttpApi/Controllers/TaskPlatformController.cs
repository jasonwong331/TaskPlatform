using Jason.TaskPlatform.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Jason.TaskPlatform.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TaskPlatformController : AbpControllerBase
{
    protected TaskPlatformController()
    {
        LocalizationResource = typeof(TaskPlatformResource);
    }
}
