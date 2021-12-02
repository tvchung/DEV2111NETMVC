using Lesson04_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson04_02.Controllers
{
    public class CustomerController : Controller
    {
        // data
        public static List<Customer> catalog = new List<Customer>()
        {
            new Customer(){CustomerId="C100",FirstName="Chung",LastName="Trịnh",Address="25 Vũ Ngọc Phan",YearOfBirth=1979},
            new Customer(){CustomerId="C101",FirstName="Hà",LastName="Trần Thu",Address="125 Vũ Ngọc Phan",YearOfBirth=1983},
            new Customer(){CustomerId="C102",FirstName="Hiếu",LastName="Trần ",Address="125 Vũ Ngọc Phan",YearOfBirth=1999},
            new Customer(){CustomerId="C103",FirstName="Hùng",LastName="Trần ",Address="125 Vũ Ngọc Phan",YearOfBirth=2000}
        };
        // GET: Customer
        public ActionResult Index()
        {
            return View(catalog);
        }

        // GET: customer/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            // Thêm mới đối tượng khách hàng
            catalog.Add(customer);

            // Chuyển sang trang hiển thị danh sách
            return RedirectToAction("Index");
        }


        //GET: customer/Edit/C001
        [HttpGet]
        public ActionResult Edit(string id)
        {
            // Tìm đối tuộng khách hàng cần sửa
            var customer = catalog.FirstOrDefault(x => x.CustomerId == id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            // Cập nhật khách hàng
            var cus = catalog.FirstOrDefault(x => x.CustomerId == customer.CustomerId);
            cus.CustomerId = customer.CustomerId;
            cus.FirstName = customer.FirstName;
            cus.LastName = customer.LastName;
            cus.Address = customer.Address;
            cus.YearOfBirth = customer.YearOfBirth;

            // Chuyển sang trang hiển thị danh sách
            return RedirectToAction("Index");
        }

        // xem chi tiết
        //GET: customer/Details/C001
        public ActionResult Details(string id)
        {
            //Tìm phần tử khách hàng cần xem
            var customer = catalog.FirstOrDefault(x => x.CustomerId == id);
            return View(customer);
        }

        //GET: customer/Delete/C001
        public ActionResult Delete(string id)
        {
            //Tìm phần tử khách hàng cần xóa
            var customer = catalog.FirstOrDefault(x => x.CustomerId == id);
            catalog.Remove(customer);
            return RedirectToAction("Index");
        }
    }
}