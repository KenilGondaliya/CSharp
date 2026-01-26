using System;

namespace MyApp.Interface
{
    public class PowerEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("PowerEngine Started");
        }

        public void Stop()
        {
            Console.WriteLine("PowerEngine Stopped");
        }

        public void Accelerate()
        {
            Console.WriteLine("PowerEngine Accelerating");
        }
    }

}