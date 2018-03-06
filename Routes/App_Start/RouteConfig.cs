namespace Routes
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ProjectsList",
                url: "Projects",
                defaults: new { controller = "Projects", action = "ListProjects" }
            );

            routes.MapRoute(
                name: "ProjectsActions",
                url: "Projects/{name}/{action}",
                defaults: new { controller = "Projects", action = "Index", name = UrlParameter.Optional }
            );

        }
    }
}