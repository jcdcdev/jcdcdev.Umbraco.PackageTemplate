using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace UmbracoPackageTemplate;

public class ConfigApiSwaggerGenOptions : IConfigureOptions<SwaggerGenOptions>
{
    public void Configure(SwaggerGenOptions options)
    {
        options.SwaggerDoc(
            Constants.Api.ApiName,
            new OpenApiInfo
            {
                Title = "Extended Dropdown Editor Api",
                Version = "Latest",
                Description = "API for Extended Dropdown Editor"
            });
    }
}
