using System;

namespace MyApp.Interface
{
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("ElectricEngine Started");
        }

        public void Stop()
        {
            Console.WriteLine("ElectricEngine Stopped");
        }

        public void Accelerate()
        {
            Console.WriteLine("ElectricEngine Accelerating");
        }
    }
}