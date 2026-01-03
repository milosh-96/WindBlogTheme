using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace WindBlogTheme.Theme;
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddResourceManagement().ConfigureOptions<ResourceManagementOptionsConfiguration>();
    }
}
