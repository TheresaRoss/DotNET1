using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace test1.Controllers
{
    public class ProductController : Controller
    {
        [Route("api/product/index")]
        public IActionResult Index()
        {
            
            return View();
        }
    }
}