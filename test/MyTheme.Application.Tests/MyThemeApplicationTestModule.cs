using Volo.Abp.Modularity;

namespace MyTheme
{
    [DependsOn(
        typeof(MyThemeApplicationModule),
        typeof(MyThemeDomainTestModule)
        )]
    public class MyThemeApplicationTestModule : AbpModule
    {

    }
}