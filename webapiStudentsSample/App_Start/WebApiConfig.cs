using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace webapiStudentsSample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            /* list of all students edit the URL as https://localhost:44329/api/student
            * To fetch the details of a single student, 
            * Edit the URL as: https://localhost:44329/api/student/2 */
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
