using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Infrastructure.Manifest;

namespace UmbracoPackageTemplate.Composing;

public class Composer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.Services.ConfigureOptions<ConfigApiSwaggerGenOptions>();
        builder.Services.AddSingleton<IPackageManifestReader, PackageManifestReader>();
    }
}
