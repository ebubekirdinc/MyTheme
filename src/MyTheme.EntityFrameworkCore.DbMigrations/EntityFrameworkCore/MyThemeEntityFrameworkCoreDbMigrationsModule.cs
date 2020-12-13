using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace MyTheme.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyThemeEntityFrameworkCoreModule)
        )]
    public class MyThemeEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MyThemeMigrationsDbContext>();
        }
    }
}
