using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AttendanceSystem.Models;

namespace AttendanceSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clock()
        {
            ViewData["Message"] = "Add one or more employees by entering their information below. All fields are mandatory";

            return View();
        }

        public IActionResult Employees()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Reports()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
