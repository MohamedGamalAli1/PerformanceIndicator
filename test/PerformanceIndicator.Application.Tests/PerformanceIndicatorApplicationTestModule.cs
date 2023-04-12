using Volo.Abp.Modularity;

namespace PerformanceIndicator;

[DependsOn(
    typeof(PerformanceIndicatorApplicationModule),
    typeof(PerformanceIndicatorDomainTestModule)
    )]
public class PerformanceIndicatorApplicationTestModule : AbpModule
{

}
