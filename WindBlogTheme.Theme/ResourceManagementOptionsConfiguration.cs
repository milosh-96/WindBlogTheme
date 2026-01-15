using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;
using WindBlogTheme.Theme.Constants;

namespace WindBlogTheme.Theme;

public sealed class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
{
    private static readonly ResourceManifest _manifest;

    static ResourceManagementOptionsConfiguration()
    {
        _manifest = new ResourceManifest();

        _manifest.DefineStyle(ResourceNames.TailwindCss)
            .SetUrl("~/WindBlogTheme.Theme/css/app.css")
            .SetVersion("4.1.18");
        _manifest.DefineScript(ResourceNames.LucideIcons)
            .SetCdn("https://unpkg.com/lucide@latest")
            .SetVersion("0.552.0");
    }
    public void Configure(ResourceManagementOptions options)
    {
        options.ResourceManifests.Add(_manifest);
    }
}
