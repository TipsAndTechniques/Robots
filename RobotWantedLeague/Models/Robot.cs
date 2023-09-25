namespace RobotsWantedLeague.Models;

public class Robot
{
    public int Id { get; set; }
    public string Name { get; set; }

    /**
     * Weight in kg.
     */
    public int Weight { get; set; }

    /**
     * Height in m.
     */
    public int Height { get; set; }
    public string Country { get; set; }
    public Queue<string> Countries { get; set; }

    public Robot(int Id, string Name, int Weight, int Height, string Country)
    {
        this.Id = Id;
        this.Name = Name;
        this.Weight = Weight;
        this.Height = Height;
        this.Country = Country;
        Countries = new Queue<string>();
        Countries.Enqueue(Country);
    }
    public void ChangerPays(string Country)
    {
        this.Country = Country;
        Countries.Enqueue(Country);
    }
}
