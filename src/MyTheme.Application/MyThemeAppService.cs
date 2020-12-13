using System;
using System.Collections.Generic;
using System.Text;
using MyTheme.Localization;
using Volo.Abp.Application.Services;

namespace MyTheme
{
    /* Inherit your application services from this class.
     */
    public abstract class MyThemeAppService : ApplicationService
    {
        protected MyThemeAppService()
        {
            LocalizationResource = typeof(MyThemeResource);
        }
    }
}
