using System;

namespace MyApp.Abstract
{
    public class Daughter : Parent
    {
        public Daughter(int age)
        {
            this.age = age;
        }

        public override void Career()
        {
            Console.WriteLine("My career is Assistant");
        }

        public override void Partner()
        {
            Console.WriteLine("My partner is Ironman and is 21 years old.");
        }
        
    }
}