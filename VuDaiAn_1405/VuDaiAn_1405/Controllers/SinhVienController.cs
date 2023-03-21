using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VuDaiAn_1405.Models;

namespace VuDaiAn_1405.Controllers      
{
    public class SinhVienController : Controller
    {
        private static List<SinhVien> DsSinhVien = new List<SinhVien>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowStudent()
        {
            return View(DsSinhVien);
        }
        public IActionResult AddStudent()
        {
            return View();
        }

        public IActionResult Save(SinhVien sv)
        {
            DsSinhVien.Add(sv);
            return RedirectToAction("ShowStudent");
        }
    }
}
