using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pro113_G3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /*นับคนดูตามวัน*/
        [HttpPost]
        public ActionResult Index(string url)
        {
            var NameBanner = Request["NameBanner"];
            if (NameBanner != null)
            {
                url = "~/Models/ViewWeb/ViewWeb.aspx?from=" + NameBanner;

                return Redirect(url);
            }
            else
            {
                return View();
            }
        }
    }
}