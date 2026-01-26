using System;

namespace MyApp.Interface
{
    public class CdPlayer : IMedia
    {
        public void Start()
        {
            Console.WriteLine("Cd Player Started");
        }

        public void Stop()
        {
            Console.WriteLine("Cd Player Stopped");
        }
    }
}