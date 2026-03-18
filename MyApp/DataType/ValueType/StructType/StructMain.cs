using System;

namespace MyApp.DataType
{

    struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    class StructMain
    {
        public static void Run(string[] args)
        {
            Point p1 = new Point(3, 4);
            Console.WriteLine($"Point p1: ({p1.X}, {p1.Y})");

            Coords c1 = new Coords(1.5, 2.5);
            Console.WriteLine($"Coords c1: {c1}");
        }
    }
}