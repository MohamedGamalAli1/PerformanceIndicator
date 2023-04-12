using System.Threading.Tasks;

namespace PerformanceIndicator.Data;

public interface IPerformanceIndicatorDbSchemaMigrator
{
    Task MigrateAsync();
}
