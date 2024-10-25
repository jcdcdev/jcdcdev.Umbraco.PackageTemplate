using jcdcdev.Umbraco.Core.Extensions;
using jcdcdev.Umbraco.Core.Web.Models.Manifests;
using Umbraco.Cms.Core.Manifest;
using Umbraco.Cms.Infrastructure.Manifest;

namespace UmbracoPackageTemplate.Composing;

internal class PackageManifestReader : IPackageManifestReader
{
    public async Task<IEnumerable<PackageManifest>> ReadPackageManifestsAsync()
    {
        var extensions = new List<IManifest>();
        var packageManifest = new PackageManifest
        {
            Name = Constants.PackageName,
            Version = EnvironmentExtensions.CurrentAssemblyVersion().ToSemVer()?.ToString() ?? "0.1.0",
            AllowPublicAccess = false,
            AllowTelemetry = true,
            Extensions = []
        };

        extensions.Add(new EntryPointManifest
        {
            Name = $"{Constants.Api.ApiName}.entrypoint",
            Alias = $"{Constants.Api.ApiName}.entrypoint",
            Js = $"/App_Plugins/{Constants.PackageName}/dist/index.js"
        });

        packageManifest.Extensions = extensions.OfType<object>().ToArray();
        return [packageManifest];
    }
}
