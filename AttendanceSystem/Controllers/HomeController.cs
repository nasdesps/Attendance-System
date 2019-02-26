using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AttendanceSystem.Models;
using AttendanceSystem.Services;
using AttendanceSystem.ViewModels;

namespace AttendanceSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeData _employeeData;
        private readonly IDateTime _dateTime;

        public HomeController (IEmployeeData employeeData, IDateTime dateTime)
        {
            _employeeData = employeeData;
            _dateTime = dateTime;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Clock()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Clock(EmployeeSignInModel model)
        {
            var serverTime = _dateTime.Now;
            if (ModelState.IsValid)
            {
                var newTime = new Employee
                {
                    ClockIn = model.ClockIn,
                    ClockOut = model.ClockOut,
                };
                newTime = _employeeData.SignIn(newTime);
                return RedirectToAction(nameof(Clock), new { id = newTime.ID });
                
            }
            else
            {
                return View();
            }
            
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

        public IActionResult Absence()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
