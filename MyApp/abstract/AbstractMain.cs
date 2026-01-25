using System;

namespace MyApp.Abstract
{
    public class AbstractMain
    {
        public static void Run(String[] args)
        {
            Son son = new Son(29);
            son.Career();

            Daughter daughter = new Daughter(25);
            daughter.Career();

            // Parent parent1 = new Parent(30);   that is not allowed

            Parent.hello();

            son.normal();
        }
    }
}