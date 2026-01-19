using System;

namespace MyApp.Polumorphism
{
    public class Numbers
    {
        int sum(int a, int b)
        {
            return a + b;
        }

        int sum(int a, int b, int c)
        {
            return a + b;
        }

        public static void nums(string[] args)
        {
            Numbers obj = new Numbers();
            obj.sum(2, 3);
            obj.sum(2, 3, 4);
            
        }   
    }
}