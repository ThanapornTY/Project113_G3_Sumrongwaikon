using Pro113_G3.Models.ViewWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Pro113_G3.Controllers
{
    public class DashboardController : Controller
    {
        public ViewWebEntities ve = new ViewWebEntities();

        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        

    }
}