using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test1.Models;

namespace test1.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var c = new List<Customer>();
            c.Add(new() { CustomerID = 21, Address = "BKK", FullName = "Tapon Seerat" });
            c.Add(new() { CustomerID = 69, Address = "TOK", FullName = "Miyasaki Hoshii" });
            c.Add(new() { CustomerID = 11, Address = "OSA", FullName = "Hida Joshou" });
            
            return View("Data",c);  //this way, when searching for /customer it will call /customer/data in View file
            //instead of calling /customer/index

        }
    }
}