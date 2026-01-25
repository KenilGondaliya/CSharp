using System;

namespace MyApp.Abstract
{
    public class Son : Parent
    {
        public Son(int age)
        {
            this.age = age;
        }

        public override void Career()
        {
            Console.WriteLine("My career is Engineer");
        }

        public override void Partner()
        {
            Console.WriteLine("My partner is Paper Pots and is 21 years old.");
        }

        // public override void Career(string name)
        // {
        //     Console.WriteLine("My career is " + name);
        // }

        // public override void Partner(string name, int age)
        // {
        //     Console.WriteLine("My partner is " + name + " and is " + age + " years old.");
        // }

        public new void normal()
        {
            Console.WriteLine("This is Son class");
        }
        
    }
}