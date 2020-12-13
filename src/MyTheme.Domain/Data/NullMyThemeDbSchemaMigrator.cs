using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MyTheme.Data
{
    /* This is used if database provider does't define
     * IMyThemeDbSchemaMigrator implementation.
     */
    public class NullMyThemeDbSchemaMigrator : IMyThemeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}