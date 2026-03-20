
using MyApp.DataType;

public class Boat : Vehicle
{
    public Boat(string brand) : base(brand) { }
    
    // Implementation of abstract method
    public override void Move() => Console.WriteLine($"{_brand} boat is sailing on the water.");
    
    // Implementation of abstract property
    public override int MaxSpeed => 50;
}
