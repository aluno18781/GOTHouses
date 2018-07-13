using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace GOTHouses
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling =
                Newtonsoft.Json.ReferenceLoopHandling.Ignore;


            // Impedir referências circulares no JSON.
            // Nota: isto é uma má ideia, porque esconde erros no nosso código.
            // É preferível usar a anotação [JsonIgnore] no campo que se quer ignorar.
            //config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = 
            //    Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            // Pretty-print do JSON
            config.Formatters.JsonFormatter.SerializerSettings.Formatting =
                Newtonsoft.Json.Formatting.Indented;
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
