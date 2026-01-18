using System;

namespace MyApp.Static
{

    internal class InnerClass
    {

        class Test
        {
            public string name;

            public Test(string name)
            {
                this.name = name;
            }
        }


        public static void Run(string[] args)
        {
            Test a = new Test("Kenil");
            Console.WriteLine("Name: {0}", a.name);
            Test b = new Test("Rahul");
            Console.WriteLine("Name: {0}", b.name);
        }
    }
}