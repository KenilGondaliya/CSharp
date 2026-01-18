using System;

namespace MyApp.Static
{
    internal class Main1
    {
        public static void MainMethod(string[] args)
        {
            Human kenil = new Human(30, "Kenil Gondaliya", 50000, false);
            Human deep = new Human(22, "Deep Anghan", 15000, true);

            Console.WriteLine("Human 1: {0}", Human.population);
            Console.WriteLine("Human 2: {0}", Human.population);
        }
    }
}