using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                Name = "Alexander Ege",
                Email = "Alexander@Ege.com",
                Gender = "M",
                RegistrationDate = DateTime.Now,
                SelectedDays = "Day1, Day2",
                Request = "N/A"
            };

            return View(employee);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                //Logic to add Employee to Database
                return RedirectToAction("Index");
            }
            return View(employee);
        }
    }
}