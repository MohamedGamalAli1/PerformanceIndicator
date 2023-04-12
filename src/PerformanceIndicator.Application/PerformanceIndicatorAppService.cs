using System;
using System.Collections.Generic;
using System.Text;
using PerformanceIndicator.Localization;
using Volo.Abp.Application.Services;

namespace PerformanceIndicator;

/* Inherit your application services from this class.
 */
public abstract class PerformanceIndicatorAppService : ApplicationService
{
    protected PerformanceIndicatorAppService()
    {
        LocalizationResource = typeof(PerformanceIndicatorResource);
    }
}
