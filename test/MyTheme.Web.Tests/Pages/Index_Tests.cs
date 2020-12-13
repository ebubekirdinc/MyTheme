using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MyTheme.Pages
{
    public class Index_Tests : MyThemeWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
