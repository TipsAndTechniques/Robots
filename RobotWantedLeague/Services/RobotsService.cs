namespace RobotWantedLeague.Services;

using RobotsWantedLeague.Models;
public class RobotsService
{

    private readonly List<Robot> robots;

    public List<Robot> Robots { get => robots; }

    public RobotsService()
    {
        robots = new List<Robot>();
    }
    public Robot AddRobot(string name, int height, int weight, string country)
    {
        int id = 0;
        var robot = new Robot(id, name, height, weight, country);
        robots.Add(robot);
        return robot;
    }



}
