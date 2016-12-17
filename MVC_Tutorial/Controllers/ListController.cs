﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutorial.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
           ViewBag.Countries = new List<string>() {
                "India",
                "Aus",
                "USA"
            };

            return View();
        }
    }
}