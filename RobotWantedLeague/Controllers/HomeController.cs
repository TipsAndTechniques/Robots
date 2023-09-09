using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RobotWantedLeague.Models;

namespace RobotWantedLeague.Controllers;

public class HomeController : Controller
{
    // public string Index(string name, string weight, string height, string country)
    // {
    //     return $@"\bob?name={name}&weight:{weight}&height={height}&country:{country}";
    // }
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
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
