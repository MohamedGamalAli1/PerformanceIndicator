using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PerformanceIndicator.Data;

/* This is used if database provider does't define
 * IPerformanceIndicatorDbSchemaMigrator implementation.
 */
public class NullPerformanceIndicatorDbSchemaMigrator : IPerformanceIndicatorDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
