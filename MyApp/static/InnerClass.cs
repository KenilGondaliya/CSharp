using System;

namespace MyApp.Static
{
    class Test
    {
        public string name;

        public Test(string name)
        {
            this.name = name;
        }
    }

    internal class InnerClass
    {

        public static void Run(string[] args)
        {
            Test a = new Test("Kenil");
            Console.WriteLine("Name: {0}", a.name);
            Test b = new Test("Rahul");
            Console.WriteLine("Name: {0}", b.name);
        }
    }
}