
namespace MyApp.DataType
{
    public class AbstractMain
    {
        public static void Run(string[] args)
        {
            // Create instances of Car and Boat
            Car car = new Car("Toyota");
            Boat boat = new Boat("Yamaha");

            // Using implemented methods from abstract class
            Console.WriteLine(car.GetInfo());
            car.StartEngine();

            // Using abstract methods implemented in derived class
            car.Move();
            Console.WriteLine($"Max speed: {car.MaxSpeed} km/h");

            Console.WriteLine();

            Console.WriteLine(boat.GetInfo());
            boat.StartEngine();
            boat.Move();
            Console.WriteLine($"Max speed: {boat.MaxSpeed} km/h");
        }
    }
}