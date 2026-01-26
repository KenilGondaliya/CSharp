using System;

namespace MyApp.Interface.NestedInterface
{
    public class NestedMain
    {
        public static void Run(string[] args)
        {
            B obj = new B();
            int number = 2;
            if (obj.isOdd(number))
            {
                Console.WriteLine(number + " is an odd number.");
            }
            else
            {
                Console.WriteLine(number + " is not an odd number.");
            }
        }
    }
   
}