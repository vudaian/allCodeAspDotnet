using ActionResult.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ActionResult.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public PartialViewResult Index()
        {
            return PartialView("_PartialView");
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

        //Các kiểu dữ liệu trả về của action
        //ContentResult: Trả về 1 chuỗi, hàm sử dụng là content
        public ContentResult GetContent()
        {
            return Content("Vu Dai An");
        }

        //RedirectToActionResult: chuyển sang 1 action hoặc 1 action của controller khác, hàm sử dụng RedirectToAction
        public RedirectToActionResult RedirectToAnother()
        {
            return RedirectToAction("Privacy");
        }

        //RedirectResult: trả về 1 URL khác, hàm sử dụng Redirect()
        public RedirectResult RedirectURL()
        {
            return Redirect("/Home/Privacy");
        }

        //ViewResult: Trả về view  khác để hiển thị, hàm sử dụng View()
        public ViewResult GetView()
        {
            return View("Privacy");
        }

        //JsonResult: trả về dữ liệu dạng Json, hàm sử dụng là Json()
        List<string> flowers = new List<String>()
        {
            "Dao", "Hong"
        };
        public JsonResult GetJson()
        {
            return Json(flowers);
        }

        //Trả về kiểu nguyên thủy: int, float, ...
        public int CountFlower()
        {
            return flowers.Count;
        }
    }
}
