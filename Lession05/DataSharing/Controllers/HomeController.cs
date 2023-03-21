using DataSharing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DataSharing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        //Action getdata
        public IActionResult GetData()
        {
            List<string> songs = new List<string>()
            {
                "Happy new year",
                "Save me",
                "Buông tay nhau"
            };

            //Các cách chuyền dữ liệu từ controller sang view
            //1. Sử dụng ViewBag
            ViewBag.message1 = "ViewBag là thuộc tính động dùng để truyền dữ liệu từ Controller sang View" +
                ". Ở bên View thì không cần ép kiểu. Khi chuyển hương thì nhận giá trị là null";

            ViewBag.songs = songs;

            //2. Sử dụng ViewData
            ViewData["message2"] = "ViewData là thuộc tính có kiểu ViewDataDictionary dùng để truyền dữ liệu từ Controller" +
                " sang View. Ở bên View phải thực hiện ép kiểu tường minh. Khi chuyển hướng thì nhận giá trị là null";

            ViewData["songs"] = songs;

            //3. Sử dụng TempData
            TempData["message3"] = "TempData là thuộc tính dùng để truyền dữ liệu từ Controller sang View. Khi chuyển hướng" +
                "thì vẫn nhận giá trị";

            //4.Sử dụng Model
            //- Bên Controller: return View(model)
            //- Bên View:
            //  +@model: khai báo model
            //  +@Model: đối tượng chứa dữ liệu nhận được từ Controller

            return RedirectToAction("Index", "Home");
            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
