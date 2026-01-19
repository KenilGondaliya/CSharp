using System;
using MyApp.Polumorphism;

namespace MyApp.Polymorphism
{
    public class Triangle : Shapes
    {
        public void area()
        {
            Console.WriteLine("Area is 0.5 * h * b");
        }
    }
}