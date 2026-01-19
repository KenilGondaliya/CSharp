using System;


namespace MyApp.Polymorphism
{
    public class ObjectPrint
    {

        int num;

        public ObjectPrint(int n)
        {
            this.num = n;
        }
        
        public static void PrintObject(string[] args)
        {
            ObjectPrint obj1 = new ObjectPrint(10);

            Console.WriteLine(obj1);
        }
    }
}