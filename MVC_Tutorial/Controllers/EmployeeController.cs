using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Tutorial.Models;

namespace MVC_Tutorial.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee emp = new Models.Employee()
            {
                Id = 1,
                Name = "Kanan"
            };

            return View(emp);
        }
    }
}