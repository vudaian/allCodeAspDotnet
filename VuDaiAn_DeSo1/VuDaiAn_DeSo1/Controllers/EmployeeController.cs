using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VuDaiAn_DeSo1.Models;

namespace VuDaiAn_DeSo1.Controllers
{
    public class EmployeeController : Controller
    {
        private static List<Employee> employees = new List<Employee>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show()
        {
            return View(employees);
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Save(Employee employee)
        {
            employees.Add(employee);
            return RedirectToAction("Show");
        }
    }
}
