using Umbraco.Cms.Web.Common.Routing;

namespace UmbracoPackageTemplate.Web;

public class ApiRouteAttribute(string template) : BackOfficeRouteAttribute($"{Constants.Api.Route}/api/v{{version:apiVersion}}/{template.TrimStart('/')}");
