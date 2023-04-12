using PerformanceIndicator.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PerformanceIndicator.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PerformanceIndicatorEntityFrameworkCoreModule),
    typeof(PerformanceIndicatorApplicationContractsModule)
    )]
public class PerformanceIndicatorDbMigratorModule : AbpModule
{

}
