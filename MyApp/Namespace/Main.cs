using System;

namespace First
{
    class Test
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Hello Greek!");
        }
    }

    class Test2
    {
        public static void Run1(string[] args)
        {
            Test.Run(args);
        }
    }
}