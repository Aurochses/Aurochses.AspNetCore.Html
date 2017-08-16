using System.IO;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;

namespace Aurochses.Html
{
    /// <summary>
    /// HtmlContentHelpers.
    /// </summary>
    public static class HtmlContentHelpers
    {
        /// <summary>
        /// Gets the string.
        /// </summary>
        /// <param name="htmlContent">Content of the HTML.</param>
        /// <returns>System.String.</returns>
        public static string GetString(this IHtmlContent htmlContent)
        {
            using (var writer = new StringWriter())
            {
                htmlContent.WriteTo(writer, HtmlEncoder.Default);

                return writer.ToString();
            }
        }
    }
}