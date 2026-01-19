using System;
using MyApp.Polumorphism;

namespace MyApp.Polymorphism
{
    public class PolyMain
    {
        public static void Show(string[] args)
        {
            Shapes shape = new Shapes();
            Shapes circle = new Circle();
            Shapes square = new Square();

            shape.area();
        }
    }
}