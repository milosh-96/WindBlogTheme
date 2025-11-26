using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.Modules;
using WindyBlog.WindBlogTheme.Settings;

namespace WindyBlog.WindBlogTheme;
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddResourceManagement().ConfigureOptions<ResourceManagementOptionsConfiguration>();
    }
}
