using Pro113_G3.Models.ViewWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Pro113_G3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Session_Start(object sender, EventArgs e)
        {
            //เก็บค่า ViewWeb
            HitCount hc = new HitCount();
            hc.AddCount(new HitCounter { SLID = 0, IPAddress = Request.UserHostAddress, CreateDate = DateTime.Now });
        }
    }
}
