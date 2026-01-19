using System;

namespace MyApp.Inheritance
{
    public class Main
    {
        public static void Run()
        {
            Box box1 = new Box(4.6, 7.9, 9.9);
            // Box box2 = new Box(box1);
            Console.WriteLine(box1.l + " " + box1.h + " " + box1.w);

            Box box3 = new BoxWeight();
            Box box4 = new BoxWeight(2,3,4,8);

            Console.WriteLine(box3.l + " " + box3.h + " " + box3.w);

            
        }
    }
}