using System;

namespace MyApp.Static
{
    internal class Main1
    {
        public static void MainMethod(string[] args)
        {
            // Human kenil = new Human(30, "Kenil Gondaliya", 50000, false);
            // Human deep = new Human(22, "Deep Anghan", 15000, true);

            // Console.WriteLine("Human 1: {0}", Human.population);
            // Console.WriteLine("Human 2: {0}", Human.population);

            
        }

        // this is not dependent on object
        static void fun()
        {
            // greeting();
            // but the function you are using it in does not depend on onject

            // you cannot access not static stuff without referring their instance in 
            // a static constext 

            // hence, here i am referencing it 
            Main1 m1 = new Main1();
            m1.greeting();
        }

        //we know that something which is not static, belongs to an object
        // this is dependent on object
        void greeting()
        {
            Console.WriteLine("Hello from Main1 class in Static namespace!");
        }
    }
}