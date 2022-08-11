using Owin;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Repligram
{
    public class Start
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            // Attribute routing.
            config.MapHttpAttributeRoutes();

            /*
            config.Routes.MapHttpRoute(
                name: "Default Api",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            */

            config.Formatters.JsonFormatter.SupportedMediaTypes
                .Add(new MediaTypeHeaderValue("text/html"));

            app.UseWebApi(config);

            config.EnsureInitialized();
        }
    }
}