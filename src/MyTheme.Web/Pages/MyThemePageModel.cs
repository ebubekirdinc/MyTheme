using MyTheme.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MyTheme.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class MyThemePageModel : AbpPageModel
    {
        protected MyThemePageModel()
        {
            LocalizationResourceType = typeof(MyThemeResource);
        }
    }
}