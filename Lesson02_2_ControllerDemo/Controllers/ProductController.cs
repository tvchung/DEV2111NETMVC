using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson02_2_ControllerDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product <=> /Product/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Product/Create
        [HttpGet]
        public ActionResult Create()
        {

            return View("product_add");
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(string email)
        {
            ViewBag.email = email;
            ViewBag.add = "Xử lý thêm mới";
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        //GET: (JsonResult) Product/GetNames
        public JsonResult GetNames()
        {
            string[] data = { "Hùng", "Dũng", "Sang", "Trọng" };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}