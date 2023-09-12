using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RobotWantedLeague.Models;

namespace RobotWantedLeague.Controllers;

public class Robot
{

    public int id { get; set; }
    public string name { get; set; }
    public string height_m { get; set; }
    public string weight_kg { get; set; }
    public string country { get; set; }

    public Robot(int id, string name, string height_m, string weight_kg, string country)
    {
        this.id = id;
        this.name = name;
        this.height_m = height_m;
        this.weight_kg = weight_kg;
        this.country = country;
    }

}
public static class RobotsService
{
    public static List<Robot> listeRobots = new List<Robot>()
    {
        new Robot(1, "Alice", "17.76 m", "6,578 kg", "Albanie"),
        new Robot(2, "Bob", "15 m", "10,871 kg", "Bénin"),
        new Robot(3, "Cédric", "3.12 m", "1,002 kg", "Cambodge")
    };

}

public class RobotsController : Controller
{
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
