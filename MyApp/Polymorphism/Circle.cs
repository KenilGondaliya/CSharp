using System;
using MyApp.Polumorphism;

namespace MyApp.Polymorphism
{
    public class Circle : Shapes
    {

        // this will run when obj of circle class is created
        // hance it is overriding the Parent method    
        public void area()
        {
            Console.WriteLine("Area is π * r * r");
        }
    }
}