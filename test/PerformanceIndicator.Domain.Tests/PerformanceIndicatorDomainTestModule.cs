using PerformanceIndicator.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PerformanceIndicator;

[DependsOn(
    typeof(PerformanceIndicatorEntityFrameworkCoreTestModule)
    )]
public class PerformanceIndicatorDomainTestModule : AbpModule
{

}
