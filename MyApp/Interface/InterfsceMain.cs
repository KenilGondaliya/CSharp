using System;

namespace MyApp.Interface
{
    public class InterfaceMain
    {
       public static void Run(string[] args)
        {
            // IEngine car = new Car();
            // car.Start();
            
            // car.Accelerate();
            // // car.Break();
            // car.Stop();

            // Console.WriteLine("Engine Price: " + IEngine.PRICE);

            // IMedia carMedia = new Car();
            // carMedia.Stop();

            NiceCar car = new NiceCar();
            car.StartEngine();
            car.StartMusic();
        }   
    }
}