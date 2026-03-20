
using MyApp.DataType;

public class Car : Vehicle
{
    public Car(string brand) : base(brand) {  }

    // Implementing the abstract method from Vehicle
    public override void Move()
    {
        Console.WriteLine($"{_brand} car is moving...");
    }

    // Implementing the abstract property from Vehicle
    public override int MaxSpeed => 200; // Example max speed for a car
    
}