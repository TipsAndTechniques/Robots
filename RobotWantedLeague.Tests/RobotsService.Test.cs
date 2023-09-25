namespace RobotWantedLeague.Test.Services;

using RobotsWantedLeague.Models;
using RobotWantedLeague.Services;

[TestClass]
class TestRobotService
{
    public void TestAddRobot()
    {
        RobotsService service = new RobotsService();
        Robot robot = service.AddRobot("Paul", 3, 3, "Canada");
        Assert.AreEqual(robot.Name, "Paul");
        Assert.AreEqual(robot.Weight, 3);
    }

}