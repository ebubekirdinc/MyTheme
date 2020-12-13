using MyTheme.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MyTheme.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MyThemeEntityFrameworkCoreDbMigrationsModule),
        typeof(MyThemeApplicationContractsModule)
        )]
    public class MyThemeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
