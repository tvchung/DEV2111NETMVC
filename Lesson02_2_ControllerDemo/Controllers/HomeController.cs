using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson02_2_ControllerDemo.Controllers
{
    public class HomeController : Controller
    {
        //Get: /Home/Index
        public ActionResult Index()
        {
            return View();
        }

        //Get: /Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //Get: /Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}