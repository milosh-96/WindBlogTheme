using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Resources;

namespace WindyBlog.WindBlogTheme;
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddResourceManagement().ConfigureOptions<ResourceManagementOptionsConfiguration>();
    }
}
