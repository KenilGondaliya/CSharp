
public class GenericDelegates
{
    public delegate void Del<T>(T item);
    public static void Notify(int i) { }

    public static void TestDelegate()
    {
        Del<int> del = Notify;
        del(42);
    }
}