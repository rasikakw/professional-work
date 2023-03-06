using System.Web.Http;

namespace Service
{
    /// <summary>
    /// Web API Configuration.
    /// </summary>
    /// <permission>© 2021 Rasika Kavinda Wijayaratne.</permission>
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
