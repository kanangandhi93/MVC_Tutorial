using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutorial.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "Hello Kanan";
        }

        public string ShowName(string Name)
        {
            return "Hello " + Name;
        }

        public string ShowId(int id)
        {
            return "Hello " + id;
        }
    }
}