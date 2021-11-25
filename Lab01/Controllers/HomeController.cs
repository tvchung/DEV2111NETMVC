using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Sử dụng ViewBag để chứa dữ liệu và đưa lên View
            ViewBag.Message = "Chào mừng bạn đến với khóa học ASP.NET MVC 5 tại Devmaster";
            return View();
        }

        // GET: /Home/About
        public ActionResult About()
        {
            // Sử dụng ViewBag để chứa dữ liệu 
            ViewBag.About = "Thông tin liên hệ";
            return View();
        }
    }
}