using Lesson04_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson04_01.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerDetail()
        {
            // Tạo thông tin khách hàng
            var cus = new Customer()
            {
                CustomerId = "C001",
                FirstName = "Chung",
                LastName = "Trịnh",
                Address = "25 Vũ Ngọc Phan",
                YearOfBirth = 1979
            };

            ViewBag.Customer = cus;

            return View();
        }

        // GET: customer/listCustomer
        public ActionResult ListCustomer()
        {
            var list = new List<Customer>()
            {
                new Customer(){CustomerId="C100",FirstName="Chung",LastName="Trịnh",Address="25 Vũ Ngọc Phan",YearOfBirth=1979},
                new Customer(){CustomerId="C101",FirstName="Hà",LastName="Trần Thu",Address="125 Vũ Ngọc Phan",YearOfBirth=1983},
                new Customer(){CustomerId="C102",FirstName="Hiếu",LastName="Trần ",Address="125 Vũ Ngọc Phan",YearOfBirth=1999},
                new Customer(){CustomerId="C103",FirstName="Hùng",LastName="Trần ",Address="125 Vũ Ngọc Phan",YearOfBirth=2000}
            };
            //ViewBag.list = list;
            return View(list);
        }

        // GET: customer/create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer cus)
        {
            string str = "<p>ID:" + cus.CustomerId;
            str += "<p> Name:" + cus.FirstName + " " + cus.LastName;
            str += "<p> Address:" + cus.Address;
            str += "<p> Year:" + cus.YearOfBirth;
            return Content(str);
        }
    }
}