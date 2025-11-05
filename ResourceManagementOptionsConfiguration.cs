using Microsoft.Extensions.Options;
using OrchardCore.Environment.Extensions;
using OrchardCore.ResourceManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindyBlog.WindBlogTheme.Constants;

namespace WindyBlog.WindBlogTheme;
public sealed class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
{
    private static readonly ResourceManifest _manifest;

    static ResourceManagementOptionsConfiguration()
    {
        _manifest = new ResourceManifest();

        _manifest.DefineStyle(ResourceNames.TailwindCss)
            .SetUrl("~/WindyBlog.WindBlogTheme/css/app.css")
            .SetVersion("4.1.16");
        _manifest.DefineScript(ResourceNames.LucideIcons)
            .SetCdn("https://unpkg.com/lucide@latest")
            .SetVersion("0.548.0");
    }
    public void Configure(ResourceManagementOptions options)
    {
        options.ResourceManifests.Add(_manifest);
    }
}
