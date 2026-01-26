using System;

namespace MyApp.Interface.NestedInterface
{
    // Nested interface 
    public class A
    {
        public interface INestedInterface
        {
            public Boolean isOdd(int number);
        }
    }


    public class B : A.INestedInterface
    {
        public Boolean isOdd(int number)
        {
            return (number & 1) == 1;
        }
    }
}