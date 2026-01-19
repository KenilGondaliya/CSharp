using System;

namespace MyApp.Inheritance
{
    public class Box
    {
        public double l;
        public double h;
        public double w;

        public Box()
        {
            this.l = -1;
            this.h = -1;
            this.w = -1;
        }

        // cube
        public Box(double side)
        {
            this.l = side;
            this.h = side;
            this.w = side;
        }

        public Box(double l, double h, double w)
        {
            this.l = l;
            this.h = h;
            this.w = w;
        }

        public Box(Box old)
        {
            this.l = old.l;
            this.h = old.h;
            this.w = old.w;
        }

        public void information()
        {
            Console.WriteLine("Running Box class");
        }


        // overriding depend on the object type
        // static method not depend on the object
        // cannot override static method
        static public void greeting()
        {
            Console.WriteLine("Hello everyone!");
        }

    }
}