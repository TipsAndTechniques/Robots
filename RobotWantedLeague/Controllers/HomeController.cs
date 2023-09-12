using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RobotWantedLeague.Models;

namespace RobotWantedLeague.Controllers;

public class HomeController : Controller
{
<<<<<<< Updated upstream
    public string Toto(string name, string weight, string height, string country)
    {
        return $@"\bob?name={name}&weight:{weight}&height={height}&country:{country}";
    }
    private readonly ILogger<HomeController> _logger;
=======
    public int Id { get; set; }
    public string Name { get; set; } 
    public string Height { get; set; }
    public string Weight { get; set; }
    public string Pays { get; set; }
>>>>>>> Stashed changes

    
            
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
