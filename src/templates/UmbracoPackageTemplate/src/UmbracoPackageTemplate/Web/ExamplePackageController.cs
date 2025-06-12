using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Api.Common.Attributes;
using Umbraco.Cms.Api.Common.Filters;
using Umbraco.Cms.Web.Common.Authorization;

namespace UmbracoPackageTemplate.Web;

[ApiExplorerSettings(GroupName = Constants.Api.ApiName)]
[ApiRoute("")]
[MapToApi(Constants.Api.ApiName)]
[JsonOptionsName(global::Umbraco.Cms.Core.Constants.JsonOptionsNames.BackOffice)]
[ApiController]
[Authorize(Policy = AuthorizationPolicies.BackOfficeAccess)]
[Produces("application/json")]
public class ExamplePackageController
{
    [HttpGet("test")]
    [Produces<string>]
    public IActionResult Test()
    {
        return new OkObjectResult($"Hello from {nameof(ExamplePackageController)}!");
    }
}
