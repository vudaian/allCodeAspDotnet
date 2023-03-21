using DataSharing.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataSharing.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> customers = new List<Customer>()
        {
            new Customer() {CustomerID = 1, CustomerName = "Vu Dai An", Phone = "0398270233"},
            new Customer() {CustomerID = 2, CustomerName = "Vu Thanh Nga", Phone = "0398270233"},
            new Customer() {CustomerID = 3, CustomerName = "Pham Tien Dung", Phone = "0398270233"},
        };
        public IActionResult Index()
        {
            return View(customers);
        }
    }
}
