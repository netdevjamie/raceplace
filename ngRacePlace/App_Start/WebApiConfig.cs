using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using ngRacePlace.ApiControllers;

namespace ngRacePlace
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

            builder.BuildApiEntities(); //this is the call to the webapicontroller generator extension method

            builder.EntitySet<RacePlaceDbfEntities>("AspNetUser");
            //builder.Entity<RacePlaceDbfEntities>().Ignore(x => x.Claims);

            config.Routes.MapODataRoute("odata", "api", builder.GetEdmModel());
            
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.EnableQuerySupport();
        }
    }
}
