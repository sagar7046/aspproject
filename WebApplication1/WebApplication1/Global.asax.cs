using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

using System.Web.Security;
using System.Web.SessionState;
using Microsoft.AspNet.SignalR;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            CustomRoutes(RouteTable.Routes);
            RouteTable.Routes.MapHubs(HubConfiguration config = new HubConfiguration());

        }
        void CustomRoutes (RouteCollection route)
        {
            route.MapPageRoute(
                "HomeRoute", "First", "~/Default.aspx"
            );         
            route.MapPageRoute(
                "Leave","LeaveApplication/{name}/{desc}","~/WebForm3.aspx"
            );
        }
    }
}