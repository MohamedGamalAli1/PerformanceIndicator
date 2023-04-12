using PerformanceIndicator.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PerformanceIndicator.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PerformanceIndicatorController : AbpControllerBase
{
    protected PerformanceIndicatorController()
    {
        LocalizationResource = typeof(PerformanceIndicatorResource);
    }
}
