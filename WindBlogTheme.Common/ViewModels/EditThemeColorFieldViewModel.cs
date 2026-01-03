using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata.Models;
using WindBlogTheme.Common.Fields;
using WindBlogTheme.Common.Constants;

namespace WindBlogTheme.Common.ViewModels;
public class EditThemeColorFieldViewModel
{
    public string Value { get; set; }
    public ThemeColorField? Field { get; set; }
    public ContentPart? Part { get; set; }
    public ContentPartFieldDefinition? PartFieldDefinition { get; set; }
}
