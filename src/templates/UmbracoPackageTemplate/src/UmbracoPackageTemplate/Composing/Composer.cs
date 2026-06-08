using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Api.Common.OpenApi;
using Umbraco.Cms.Api.Management.OpenApi;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Infrastructure.Manifest;

namespace UmbracoPackageTemplate.Composing;

public class Composer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.AddBackOfficeOpenApiDocument(Constants.Api.ApiName, document => document
            .WithTitle(Constants.Api.Title)
            .WithBackOfficeAuthentication());

        builder.Services.AddSingleton<IPackageManifestReader, PackageManifestReader>();
    }
}
