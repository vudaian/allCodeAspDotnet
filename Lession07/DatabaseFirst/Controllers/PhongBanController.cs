using DatabaseFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseFirst.Controllers
{
    public class PhongBanController : Controller
    {
        List<PhongBan> phongBans = new List<PhongBan>();
        QLDAContext _context = new QLDAContext();
        public IActionResult Index()
        {
            phongBans = _context.PhongBans.ToList();
            return View(phongBans);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PhongBan phongBan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phongBan);
                _context.SaveChanges();// Lưu sự thay đổi xuống database
                return RedirectToAction("Index");
            } return View(phongBan);
        }
        [HttpGet]
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            PhongBan phongBan = _context.PhongBans.Find(id);
            return View(phongBan);
        }
        [HttpPost]
        public IActionResult Edit(PhongBan phongBan)
        {
            if (ModelState.IsValid)
            {
                _context.PhongBans.Update(phongBan);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phongBan);
        }
    }
}
