using Microsoft.CodeAnalysis.CSharp.Syntax;
using OrchardCore.ContentManagement;
using OrchardCore.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBlogTheme.Common.Constants;
using WindBlogTheme.Theme.Constants;
using WindBlogTheme.Theme.Settings;

namespace WindBlogTheme.Theme.Extensions;
public static class SiteServiceExtensions
{
    public static async Task<string> GetPrimaryColorClassAsync(this ISiteService siteService, string prefix = "bg")
    {
        var settings = (await siteService.GetCustomSettingsAsync(ContentTypes.WindBlogThemeSettings)).As<WindBlogThemeSettings>();
        if(settings != null && settings.ThemeColor.Value != null)
        {
            return ColorClasses.GetColorClass(settings.ThemeColor.Value, prefix);
        }
        return ColorClasses.GetColorClass(ColorClasses.SupportedColors.First());
    }
}
