using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult FormAndQuery ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FormAndQuery([FromQuery] string customerName, Customer customer)
        {
            string message = "";
            if(ModelState.IsValid)
            {
                message = "Query string: " + customerName + ", CustomerId: " + customer.CustomerId +
                   ", CustomerName: " + customer.CustomerName + ", address: " + customer.Address;
            }
            else
            {
                message = "Error binding";
            }
            return Content(message);
        }
        
        [HttpGet]
        public IActionResult FormRoute()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FormRoute([FromRoute] string id, Customer customer)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                message = "Route: " + id + ", CustomerId: " + customer.CustomerId +
                   ", CustomerName: " + customer.CustomerName + ", address: " + customer.Address;
            }
            else
            {
                message = "Error binding";
            }
            return Content(message);
        }
    }

}
