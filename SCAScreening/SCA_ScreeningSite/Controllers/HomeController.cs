using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KleinTech.Web.MVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Just a site to test some of the new features with MVC 5.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = @"Contact Reid";

            return View();
        }
    }
}