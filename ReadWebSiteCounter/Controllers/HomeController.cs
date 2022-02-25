using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReadWebSiteCounter.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() { }
        public ActionResult Index()
        { 
            var env = Environment.GetEnvironmentVariable("WEBSITE_COUNTERS_ALL");
            return Json(env,JsonRequestBehavior.AllowGet);
        }
    }
}
