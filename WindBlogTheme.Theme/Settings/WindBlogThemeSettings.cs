using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using OrchardCore.Media.Fields;
using WindBlogTheme.Common.Fields;

namespace WindBlogTheme.Theme.Settings;

public class WindBlogThemeSettings : ContentPart
{
    public MediaField SiteLogo { get; init; } = new();
    public ThemeColorField ThemeColor { get; init; } = new();
}
