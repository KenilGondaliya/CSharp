using System;

namespace first
{
    class Test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Greek!");
        }
    }

    class Test2
    {
        public static void Main(string[] args)
        {
            first.Test.Main(args);
        }
    }
}