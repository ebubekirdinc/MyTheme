using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyTheme.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class MyThemeMigrationsDbContextFactory : IDesignTimeDbContextFactory<MyThemeMigrationsDbContext>
    {
        public MyThemeMigrationsDbContext CreateDbContext(string[] args)
        {
            MyThemeEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<MyThemeMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new MyThemeMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MyTheme.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
