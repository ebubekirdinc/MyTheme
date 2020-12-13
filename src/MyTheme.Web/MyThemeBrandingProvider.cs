using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MyTheme.Web
{
    [Dependency(ReplaceServices = true)]
    public class MyThemeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MyTheme";
    }
}
