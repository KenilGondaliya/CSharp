
namespace MyApp.DataType
{
    public abstract class Vehicle
    {
        protected string _brand;

        // Constructor - implemented method in abstract class
        public Vehicle(string brand)
        {
            _brand = brand;
        }

        // Implemented method - provides functionality that all vehicles share
        public string GetInfo() => $"This is a  {_brand} Vehicle.";

        //Another implemented method
        public virtual void StartEngine() => Console.WriteLine($"{_brand} engine is starting...");

        // Abstract method - must be implemented by derived classes
        public abstract void Move();

        // Abstract property - must be implemented by derived classes
        public abstract int MaxSpeed { get; }
    }
}
