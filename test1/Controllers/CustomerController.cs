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
            Customer c = new Customer();
            c.CustomerID = 1;
            c.FullName = "Johny Dave";
            c.Address = "Patcharapon Seesatpank";
            return View(c);
        }
    }
}