using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using OrchardCore.Media.Fields;

namespace WindyBlog.WindBlogTheme.Settings;

public class WindBlogThemeSettings : ContentPart
{
    public MediaField SiteLogo { get; init; } = new();
    public TextField PrimaryColor { get; init; } = new();
}
