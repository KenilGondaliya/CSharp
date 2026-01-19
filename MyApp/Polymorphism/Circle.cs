using System;
using MyApp.Polumorphism;

namespace MyApp.Polymorphism
{
    public class Circle : Shapes
    {
        public void area()
        {
            Console.WriteLine("Area is π * r * r");
        }
    }
}