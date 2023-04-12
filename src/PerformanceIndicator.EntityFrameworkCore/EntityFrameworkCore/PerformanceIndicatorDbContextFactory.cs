using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PerformanceIndicator.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class PerformanceIndicatorDbContextFactory : IDesignTimeDbContextFactory<PerformanceIndicatorDbContext>
{
    public PerformanceIndicatorDbContext CreateDbContext(string[] args)
    {
        PerformanceIndicatorEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<PerformanceIndicatorDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new PerformanceIndicatorDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../PerformanceIndicator.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
