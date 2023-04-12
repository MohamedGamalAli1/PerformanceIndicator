using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PerformanceIndicator.Data;
using Volo.Abp.DependencyInjection;

namespace PerformanceIndicator.EntityFrameworkCore;

public class EntityFrameworkCorePerformanceIndicatorDbSchemaMigrator
    : IPerformanceIndicatorDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorePerformanceIndicatorDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the PerformanceIndicatorDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<PerformanceIndicatorDbContext>()
            .Database
            .MigrateAsync();
    }
}
