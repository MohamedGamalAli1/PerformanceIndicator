using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PerformanceIndicator;

[Dependency(ReplaceServices = true)]
public class PerformanceIndicatorBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PerformanceIndicator";
}
