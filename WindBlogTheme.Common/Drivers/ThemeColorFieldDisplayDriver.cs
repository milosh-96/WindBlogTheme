using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.Views;
using WindBlogTheme.Common.Fields;
using WindBlogTheme.Common.ViewModels;

namespace WindBlogTheme.Common.Drivers;
public class ThemeColorFieldDisplayDriver : ContentFieldDisplayDriver<ThemeColorField>
{
    public override IDisplayResult Display(ThemeColorField field, BuildFieldDisplayContext fieldDisplayContext)
    =>
        Initialize<DisplayThemeColorFieldViewModel>(
            GetDisplayShapeType(fieldDisplayContext),
            viewModel =>
            {
                viewModel.Field = field;
                viewModel.Part = fieldDisplayContext.ContentPart;
                viewModel.PartFieldDefinition = fieldDisplayContext.PartFieldDefinition;
            })
        .Location("Content")
        .Location("SummaryAdmin", string.Empty);

    public override IDisplayResult Edit(ThemeColorField field, BuildFieldEditorContext context)
    => Initialize<EditThemeColorFieldViewModel>(
            GetEditorShapeType(context),
            viewModel =>
            {
                viewModel.Value = field.Value;
                viewModel.Field = field;
                viewModel.Part = context.ContentPart;
                viewModel.PartFieldDefinition = context.PartFieldDefinition;
            });

    public override async Task<IDisplayResult> UpdateAsync(ThemeColorField field, UpdateFieldEditorContext context)
    {
        var updater = context.Updater;
        var viewModel = new EditThemeColorFieldViewModel();

        // Using this overload of the model updater you can specifically say what properties need to be updated. This
        // way you make sure no other properties will be bound to the view model. Instead of this you could put
        // [BindNever] attributes on the properties to make the model binder to skip those, it's up to you.
        await updater.TryUpdateModelAsync(viewModel, Prefix, m => m.Value);

        field.Value = viewModel.Value;

        return Edit(field, context);
    }

}
