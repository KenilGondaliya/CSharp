using System;

namespace MyApp.Interface
{
    public class Car : IBreak, IEngine , IMedia
    {
        public void Break()
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