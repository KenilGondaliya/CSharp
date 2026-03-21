
class GenericMethods
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static void TestSwap()
    {
        int a = 1;
        int b = 2;

        Swap<int>(ref a, ref b);
        Console.WriteLine($"a: {a}, b: {b}"); // Output: a: 2, b: 1

    }
}