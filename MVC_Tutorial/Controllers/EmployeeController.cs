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
        public ActionResult Index(int id)
        {
            EmpContext db = new Models.EmpContext();
           Employee employee= db.emp.Single(x => x.Id==id);

            return View(employee);
        }
    }
}