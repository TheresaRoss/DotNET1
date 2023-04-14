using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using test1.Models;
using Microsoft.EntityFrameworkCore;
using test1.Models.db;

namespace test1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly DemoShopContext _db;

    public HomeController(ILogger<HomeController> logger,DemoShopContext db)
    {
        _db = db;
        _logger = logger;
    }

    public IActionResult Index()
    {
        var Customer = ("John", "Dave");

        int result = 0;

        int AddData(int num1,int num2)
        {
            return num1 + num2;
        }

        ViewData["result"] = AddData(200, 444);
        ViewData["AllCustomer"] = GetAllCustomer();
        //ViewData["AllProduct"] = GetAllProduct();


        ViewData["customer"] = "Yoma " + Customer.Item1 + " " + Customer.Item2;

        var product = from item in _db.Products select item;
        return View(product);
    }
    public IActionResult Info()
    {
        return View();
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

    public List<Customer> GetAllCustomer()
    {
        var c = new List<Customer>();
        c.Add(new() { CustomerID = 21, Address = "BKK", FullName = "Tapon Seerat" });
        c.Add(new() { CustomerID = 69, Address = "TOK", FullName = "Miyasaki Hoshii" });
        c.Add(new() { CustomerID = 11, Address = "OSA", FullName = "Hida Joshou" });

        return c;
    }

  
}

