using System;
using System.Collections.Generic;
using System.Text;
using Polygon.Ecom.Localization;
using Volo.Abp.Application.Services;

namespace Polygon.Ecom;

/* Inherit your application services from this class.
 */
public abstract class EcomAppService : ApplicationService
{
    protected EcomAppService()
    {
        LocalizationResource = typeof(EcomResource);
    }
}
