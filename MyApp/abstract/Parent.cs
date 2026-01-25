using System;

namespace MyApp.Abstract
{
    public abstract class Parent
    {
        public int age;
        public abstract void Career();
        public abstract void Partner();

        // this is constructor
        public Parent()
        {
            Console.WriteLine("Parent Constructor called");
        }

        // this is static method
        public static void hello()
        {
            Console.WriteLine("Hello from Parent class");
        }

        // this is normal method
        public void normal()
        {
            Console.WriteLine("This is Parent class");
        }

    }
}