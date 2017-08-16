using Microsoft.AspNetCore.Html;
using Xunit;

namespace Aurochses.Html.Tests
{
    public class HtmlContentHelpersTests
    {
        [Fact]
        public void GetString_Success()
        {
            // Arrange
            const string html = "<b>test</b>";

            var htmlString = new HtmlString(html);

            // Act & Assert
            Assert.Equal(html, htmlString.GetString());
        }
    }
}