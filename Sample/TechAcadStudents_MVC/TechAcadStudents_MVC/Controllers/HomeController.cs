﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechAcadStudents_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page - Daniel.";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public ActionResult Instructors()
        {
            return View();
        }
    }
}