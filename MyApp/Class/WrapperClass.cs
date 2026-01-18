using System;

class WrapperClass
{
    public static void Wrapper(string[] args)
    {
        int a = 10;
        int b = 20;
        int num = 45;

        swap(ref a, ref b);

        Console.WriteLine("a: " + a + " b: " + b);

        // when a non primitive is const/readonly, you can not reassign it.  
        // kenil = new A("Another Name");

    }

    static void swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
