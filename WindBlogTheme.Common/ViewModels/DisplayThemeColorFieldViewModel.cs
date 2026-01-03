using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata.Models;
using WindBlogTheme.Common.Fields;

namespace WindBlogTheme.Common.ViewModels;
public class DisplayThemeColorFieldViewModel
{
    public ThemeColorField Field { get; set; }
    public ContentPart Part { get; set; }
    public ContentPartFieldDefinition PartFieldDefinition { get; set; }
}
