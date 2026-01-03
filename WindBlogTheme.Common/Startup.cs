
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Modules;
using WindBlogTheme.Common.Drivers;
using WindBlogTheme.Common.Fields;

namespace WindBlogTheme.Common;
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddContentField<ThemeColorField>().UseDisplayDriver<ThemeColorFieldDisplayDriver>();
    }
}

