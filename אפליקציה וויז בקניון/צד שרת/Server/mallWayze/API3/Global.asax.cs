using API3.Controllers;
using BL.BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace API3
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            StorController stor = new StorController();
            List<DTOStor> list = stor.GetSaleStor();
            List<DTOStor> list2 = new List<DTOStor>();
            for (int i = 0; i < 2; i++)
            {
                list2.Add(list[i]);
            }
            List<DTOStor> dTs = Dijkstra.MapSelectedStores(list2);
        }
    }
}
