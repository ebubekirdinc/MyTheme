﻿using Volo.Abp.Settings;

namespace MyTheme.Settings
{
    public class MyThemeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MyThemeSettings.MySetting1));
        }
    }
}
