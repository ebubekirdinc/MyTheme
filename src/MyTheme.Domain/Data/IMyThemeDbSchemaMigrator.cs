using System.Threading.Tasks;

namespace MyTheme.Data
{
    public interface IMyThemeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
