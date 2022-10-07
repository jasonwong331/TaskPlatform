using System;
using System.Collections.Generic;
using System.Text;
using Jason.TaskPlatform.Localization;
using Volo.Abp.Application.Services;

namespace Jason.TaskPlatform;

/* Inherit your application services from this class.
 */
public abstract class TaskPlatformAppService : ApplicationService
{
    protected TaskPlatformAppService()
    {
        LocalizationResource = typeof(TaskPlatformResource);
    }
}
