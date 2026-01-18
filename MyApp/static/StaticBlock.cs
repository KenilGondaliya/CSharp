using System;


// tihs is demo to show initialization of static variable
namespace MyApp.Static
{
    internal class StaticBlock
    {
        public static int a = 4;
        public static int b;


        // will only run once when the first obj is create i.e. class is loaded for the first time
        static StaticBlock()
        {
            Console.WriteLine("Static block called!");
            b = a * 5;
        }


        public static void run(string[] args)
        {
            StaticBlock obj = new StaticBlock();
            Console.WriteLine("Value of a: {0}", a);
            Console.WriteLine("Value of b: {0}", b);

            StaticBlock.b += 10;

            StaticBlock obj2 = new StaticBlock();
            Console.WriteLine("Value of a: {0}, Value of b: {1}", StaticBlock.a, StaticBlock.b);
        }
    }
}