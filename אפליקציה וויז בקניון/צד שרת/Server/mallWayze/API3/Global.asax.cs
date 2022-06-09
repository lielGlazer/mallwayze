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
            List<DTOStor> list = stor.GetAllStor();
            List<DTOStor> list2 = new List<DTOStor>();
            //DTOStor s1 = list.FirstOrDefault(s => s.NameStor == "פנדורה ");
            //DTOStor s2 = list.FirstOrDefault(s => s.NameStor == "מובייל");
            //DTOStor s3 = list.FirstOrDefault(s => s.NameStor == "H&M");
            //list2.Add(s1);
            //list2.Add(s2);
            //list2.Add(s3);
            //List<DTOStor> dTs = Dijkstra.MapSelectedStores(list2);
        }
    }
}
