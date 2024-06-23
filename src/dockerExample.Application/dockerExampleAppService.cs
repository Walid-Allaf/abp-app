using System;
using System.Collections.Generic;
using System.Text;
using dockerExample.Localization;
using Volo.Abp.Application.Services;

namespace dockerExample;

/* Inherit your application services from this class.
 */
public abstract class dockerExampleAppService : ApplicationService
{
    protected dockerExampleAppService()
    {
        LocalizationResource = typeof(dockerExampleResource);
    }
}
