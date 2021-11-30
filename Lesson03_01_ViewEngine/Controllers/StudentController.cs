using System;
using System.Web.Mvc;

namespace Lesson03_01_ViewEngine.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            // Sử dụng ViewData
            ViewData["msg"] = "Thông báo bây giờ là";
            ViewData["Time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy");
            return View();
        }


        // GET: Student/StudentList
        public ActionResult StudentList()
        {
            //Sử dụng ViewBag để mang dữ liệu lên view
            string[] names = { "Nguyễn Văn Đức", "Hồ Diệu Thúy", "Trần Đại Quang Chiến", "Nguyền Trường Xuân" };
            ViewBag.haha = names;
            return View();
        }

        // GET: student/insert
        public ActionResult Insert()
        {
            TempData["key"] = "Xin chào, tôi là TempData";
            return View("AddStudent");

            // Hoặc
            // return View("~/Views/Student/AddStudent.cshtml");
        }


        // test redirect, viewbag,viewdata, tempdata
        public ActionResult Test()
        {
            // đối tượng lưu trữ dữ liệu
            ViewBag.ABC = "Tôi là ViewBag";
            ViewData["ABC"] = "Tôi là ViewData";
            TempData["ABC"] = "Tôi là TempData";
            return Redirect("Hello");
        }
        public ActionResult Hello()
        {
            return View();
        }

        // Lập trình trên view razor
        public ActionResult ViewRazor()
        {
            return View();
        }
    }
}