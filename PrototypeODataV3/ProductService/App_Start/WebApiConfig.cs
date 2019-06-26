using ProductService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.OData.Extensions;
using System.Web.Http;
using System.Web.Http.OData.Builder;

namespace ProductService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Product>("Products");
            //var result2 = builder.GetEdmModel();
            
           
            config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());


            // Web API routes
            //config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
