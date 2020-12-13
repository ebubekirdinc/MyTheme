using MyTheme.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyTheme
{
    [DependsOn(
        typeof(MyThemeEntityFrameworkCoreTestModule)
        )]
    public class MyThemeDomainTestModule : AbpModule
    {

    }
}