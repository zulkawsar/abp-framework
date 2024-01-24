using Polygon.Ecom.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Polygon.Ecom.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EcomController : AbpControllerBase
{
    protected EcomController()
    {
        LocalizationResource = typeof(EcomResource);
    }
}
