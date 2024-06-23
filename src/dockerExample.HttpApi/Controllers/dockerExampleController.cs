using dockerExample.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace dockerExample.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class dockerExampleController : AbpControllerBase
{
    protected dockerExampleController()
    {
        LocalizationResource = typeof(dockerExampleResource);
    }
}
