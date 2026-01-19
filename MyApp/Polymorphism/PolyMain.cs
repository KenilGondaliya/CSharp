using System;
using MyApp.Polumorphism;

namespace MyApp.Polymorphism
{
    public class PolyMain
    {
        public static void Show(string[] args)
        {
            Shapes shape = new Shapes();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();
            Square square = new Square();

            shape.area();
        }
    }
}