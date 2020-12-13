using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyTheme.Data;
using Volo.Abp.DependencyInjection;

namespace MyTheme.EntityFrameworkCore
{
    public class EntityFrameworkCoreMyThemeDbSchemaMigrator
        : IMyThemeDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreMyThemeDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the MyThemeMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<MyThemeMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}