using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using test1.Models;

namespace test1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
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


        ViewData["customer"] = "Yoma " + Customer.Item1 + " " + Customer.Item2;
        return View();
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
}

