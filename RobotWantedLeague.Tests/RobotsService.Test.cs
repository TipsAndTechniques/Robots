namespace RobotWantedLeague.Test.Services;

using RobotWantedLeague.Models;
using RobotWantedLeague.Services;

[TestClass]
public void TestAddRobot()
{
    RobotsService service = new RobotsService();
    Robot robot = service.AddRobot("Paul", new M(3), new Kg(3), "Canada");
    Assert.AreEqual(robot.Name, "Paul");
    Assert.AreEqual(robot.Weight, 3);
}
public void TestGetRobotById(
    {
    RobotsService service = new RobotsService();
    Assert.IsNull(service.GetRobotById());
    Robot robot1 = service.AddRobot("Paul", new M(3), new Kg(3), "Canada");
    Robot robot2 = service.AddRobot("Paul", new M(3), new Kg(3), "Canada");
    Robot? ret = service.GetRobotById(robot2.Id);
    Assert.IsNotNull()
    Assert.AreEqual(robot.Name, "Paul");
    Assert.AreEqual(robot.Weight, 3);

}
)