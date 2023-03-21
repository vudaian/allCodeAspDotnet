using DataSharing.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataSharing.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            //Lưu thông tin khách hàng vào Session
            HttpContext.Session.SetString("UserName", user.UserName);
            HttpContext.Session.SetString("PassWord", user.PassWord);
            HttpContext.Session.SetString("Email", user.Email);
            return RedirectToAction("Profile", "User");
        }
        public IActionResult Profile()
        {
            return View();
        }
    }
}
