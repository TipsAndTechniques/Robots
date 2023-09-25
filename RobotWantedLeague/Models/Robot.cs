namespace RobotWantedLeague.Models;

public class Robot
{
    public int Id { get; set; }
    public string Name { get; set; }
    public M Height { get; set; }
    public Kg Weight { get; set; }
    public string Country { get; set; }

    public Robot (int Id, string Name, M Height, Kg Weight, string Country){
        this.Id = Id;
        this.Name = Name;
        this.Height = Height;
        this.Weight = Weight;
        this.Country= Country; 
    }

}

public class M
{
    public int m { get; set; }
}
public class Kg
{
    public int kg { get; set; }
}