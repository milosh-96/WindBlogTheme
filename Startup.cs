using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace WindyBlog.WindBlogTheme;
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddResourceManagement().ConfigureOptions<ResourceManagementOptionsConfiguration>();
    }
}
