using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace MyTheme.EntityFrameworkCore
{
    public static class MyThemeDbContextModelCreatingExtensions
    {
        public static void ConfigureMyTheme(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MyThemeConsts.DbTablePrefix + "YourEntities", MyThemeConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}