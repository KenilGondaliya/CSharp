using System;

namespace MyApp.Interface
{
    public class Car : IBrake, IEngine , IMedia
    {
        public void Brake()
        {
            Console.WriteLine("Car Breaked");
        }

        public void Start()
        {
            Console.WriteLine("Car Started");
        }

        public void Stop()
        {
            Console.WriteLine("Car Stopped");
        }

        public void Accelerate()
        {
            Console.WriteLine("Car Accelerated");
        }
    }
}