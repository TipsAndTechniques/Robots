using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RobotWantedLeague.Models;

namespace RobotWantedLeague.Controllers;

public class RobotsController : Controller
{
    public int id{get; set;}
    public string Nom{get; set;}
    public string Height{get; set;}
    public string Weight{get; set;}
    public string Country{get; set;}
        private readonly ILogger<RobotsController> _logger;

    public RobotsController(ILogger<RobotsController> logger)
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
